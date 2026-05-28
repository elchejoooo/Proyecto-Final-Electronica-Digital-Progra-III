using System;
using System.Collections.Generic; // Necesario para manejar List<>
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.Json; // Procesamiento nativo de JSON 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization; // Procesamiento nativo de XML
namespace DigitalProyectoFinal
{
    public partial class Form1 : Form
    {
        float precioBomba1, precioBomba2, precioBomba3, precioBomba4;
        private SerialPort spArduino;

        // Variable para saber si estamos en modo Tanque Lleno
        bool modoTanqueLleno = false;

        // Nombre del archivo para guardar los registros
        private const string ArchivoBitacora = "bitacora_ventas.txt";

        // Variables auxiliares para el registro en tiempo real de la venta actual
        private string modoActual = "Ninguno";
        private float montoActual = 0f;
        private float litrosActuales = 0f;
        public Form1()
        {
            InitializeComponent();
            ConfigurarPuertoSerial();
            ActualizarLabelsPrecio();

        }
        // --- CONFIGURACIÓN Y COMUNICACIÓN ---

        private void ConfigurarPuertoSerial()
        {
            spArduino = new SerialPort();
            try
            {
                spArduino.PortName = "COM9";
                spArduino.BaudRate = 9600;

                // Suscribirse al evento de recepción de datos del Arduino
                spArduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                if (!spArduino.IsOpen) spArduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con Arduino: " + ex.Message);
            }
        }
        private int DetectarBombaActiva()
        {
            if (lblEstadoBomba1.Text.Contains("ABIERTO")) return 1;
            if (lblEstadoBomba2.Text.Contains("ABIERTO")) return 2;
            if (lblEstadoBomba3.Text.Contains("ABIERTO")) return 3;
            if (lblEstadoBomba4.Text.Contains("ABIERTO")) return 4;
            return 1;
        }

        // Este método se ejecuta cuando Arduino envía el mensaje de "Tanque Lleno"
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = spArduino.ReadLine().Trim();

                if (data.Contains("LLENO"))
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        lblEstadoGlobal.Text = "¡DETECCIÓN DE LLENADO! Sistema apagado.";
                        MessageBox.Show("El sensor ha detectado que el recipiente está lleno.");
                    }));
                }
            }
            catch { /* Manejo de errores de lectura */ }
        }

        private void ActualizarLabelsPrecio()
        {
            lblPrecioActual.Text = $"Precio actual: {precioBomba1:C} | {precioBomba2:C} | {precioBomba3:C} | {precioBomba4:C}";
        }


        // --- MÉTODOS DE CONTROL DE FLUJO (BOMBA ÚNICA) ---

        private async Task IniciarDespacho(int numeroBomba, int tiempoSegundos, Label lblEstadoIndividual)
        {
            if (spArduino.IsOpen)
            {
                spArduino.Write("b");
                lblEstadoGlobal.Text = "Generando presión en el sistema...";
                lblEstadoIndividual.Text = "Esperando presión...";

                await Task.Delay(5000);

                spArduino.Write(numeroBomba.ToString());
                lblEstadoGlobal.Text = $"Despachando en Estación {numeroBomba}...";
                lblEstadoIndividual.Text = "Estado: ABIERTO";

                await Task.Delay(tiempoSegundos * 1000);

                if (modoActual == "Prepago")
                {
                    RegistrarVentaEnBitacora(numeroBomba, "Prepago", montoActual, litrosActuales);
                }

                FinalizarCerrado(numeroBomba, lblEstadoIndividual);
            }
            else
            {
                MessageBox.Show("El puerto serial no está abierto.");
            }
        }

        private void FinalizarCerrado(int numeroBomba, Label lblEstadoIndividual)
        {
            string[] comandosApagado = { "q", "w", "e", "r" };

            if (spArduino.IsOpen)
            {
                spArduino.Write(comandosApagado[numeroBomba - 1]);
                System.Threading.Thread.Sleep(500);
                spArduino.Write("x");
            }

            lblEstadoGlobal.Text = "Sistema listo / Esperando orden";
            lblEstadoIndividual.Text = "Estado: CERRADO";
        }
        private void RegistrarVentaEnBitacora(int numeroBomba, string modo, float monto, float litros)
        {
            try
            {
                string linea = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}|{numeroBomba}|{modo}|{monto:F2}|{litros:F2}";

                using (StreamWriter sw = File.AppendText(ArchivoBitacora))
                {
                    sw.WriteLine(linea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el log en TXT: " + ex.Message);
            }
        }

        //ESPACIO DE FUNCIONES DE COMPONENTES VISUALES
        private void btnAjustarPrecio1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrecioBomba1.Text, out precioBomba1))
            {
                MessageBox.Show("Precio de la bomba 1 ajustado.");
                ActualizarLabelsPrecio();
            }
        }

        private void btnAjustarPrecio2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrecioBomba2.Text, out precioBomba2))
            {
                MessageBox.Show("Precio de la bomba 2 ajustado.");
                ActualizarLabelsPrecio();
            }
        }

        private void btnAjustarPrecio3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrecioBomba3.Text, out precioBomba3))
            {
                MessageBox.Show("Precio de la bomba 3 ajustado.");
                ActualizarLabelsPrecio();
            }
        }

        private void btnAjustarPrecio4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrecioBomba4.Text, out precioBomba4))
            {
                MessageBox.Show("Precio de la bomba 4 ajustado.");
                ActualizarLabelsPrecio();
            }
        }

        // --- LÓGICA DE ENCENDIDO (PREPAGO Y TANQUE LLENO) ---
        // Función auxiliar para procesar el encendido según el modo
        private async void ProcesarEncendidoBomba(int numeroBomba, float precioBomba, Label lblEstado)
        {
            if (modoTanqueLleno)
            {
                lblEstadoGlobal.Text = $"Modo Tanque Lleno en Estación {numeroBomba}...";
                await IniciarDespacho(numeroBomba, 3600, lblEstado);
                modoTanqueLleno = false;
            }
            else
            {
                float monto;
                if (float.TryParse(txtPagoPrepago.Text, out monto) && precioBomba > 0)
                {
                    modoActual = "Prepago";
                    montoActual = monto;
                    litrosActuales = monto / precioBomba;

                    int tiempoSegundos = (int)(litrosActuales * 180);

                    // CORREGIDO: Se cambió 'litros' por 'litrosActuales'
                    lblEstadoGlobal.Text = $"Pago: {monto:C}. Litros: {litrosActuales:F2}L";
                    await IniciarDespacho(numeroBomba, tiempoSegundos, lblEstado);
                    txtPagoPrepago.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese un monto de prepago válido o verifique el precio de la bomba.");
                }
            }
        }


        private void btnEncenderBomba1_Click(object sender, EventArgs e)
        {
            ProcesarEncendidoBomba(1, precioBomba1, lblEstadoBomba1);
        }

        private void btnEncenderBomba2_Click(object sender, EventArgs e)
        {
            ProcesarEncendidoBomba(2, precioBomba2, lblEstadoBomba2);
        }

        private void btnEncenderBomba3_Click(object sender, EventArgs e)
        {
            ProcesarEncendidoBomba(3, precioBomba3, lblEstadoBomba3);
        }

        private void btnEncenderBomba4_Click(object sender, EventArgs e)
        {
            ProcesarEncendidoBomba(4, precioBomba4, lblEstadoBomba4);
        }

        // --- BOTONES DE APAGADO MANUAL ---

        private void btnApagarBomba1_Click(object sender, EventArgs e)
        {
            FinalizarCerrado(1, lblEstadoBomba1);
        }

        private void btnApagarBomba2_Click(object sender, EventArgs e)
        {
            FinalizarCerrado(2, lblEstadoBomba2);
        }

        private void btnApagarBomba3_Click(object sender, EventArgs e)
        {
            FinalizarCerrado(3, lblEstadoBomba3);
        }

        private void btnApagarBomba4_Click(object sender, EventArgs e)
        {
            FinalizarCerrado(4, lblEstadoBomba4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spArduino != null && spArduino.IsOpen) spArduino.Close();
        }

        // --- EVENTOS DE CIERRE Y SELECCIÓN DE PAGO ---
        private void btnPagoPrepago_Click(object sender, EventArgs e)
        {
            modoTanqueLleno = false;
            if (string.IsNullOrEmpty(txtPagoPrepago.Text))
                MessageBox.Show("Ingrese el monto para prepago.");
            else
                lblEstadoGlobal.Text = "Modo Prepago: " + txtPagoPrepago.Text + ". Seleccione bomba.";
        }

        private void btnPagoTanqueTotal_Click(object sender, EventArgs e)
        {
            modoTanqueLleno = true;
            lblEstadoGlobal.Text = "Modo: Tanque Lleno Activo. Seleccione Bomba.";
        }
        //APARTADO DE LOS INFORMES
        //AQUI SE UTLIZA UN ARCHIVO DE TEXTO PARA GUARDAR LOS REGISTROS DE LAS VENTAS EN TIEMPO REAL,
        //Y LUEGO SE LEEN ESOS REGISTROS PARA GENERAR LOS INFORMES SOLICITADOS
        private void btnCierreDiario_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ArchivoBitacora))
            {
                MessageBox.Show("No hay registros de transacciones el día de hoy.");
                return;
            }

            float totalDinero = 0;
            float totalLitros = 0;
            int transacciones = 0;

            string[] lineas = File.ReadAllLines(ArchivoBitacora);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    totalDinero += float.Parse(datos[3]);
                    totalLitros += float.Parse(datos[4]);
                    transacciones++;
                }
            }

            string reporte = $"*** CIERRE DIARIO DE OPERACIONES ***\n\n" +
                             $"Transacciones Totales: {transacciones}\n" +
                             $"Total Recaudado: {totalDinero:C}\n" +
                             $"Total de Litros Despachados: {totalLitros:F2} L";

            MessageBox.Show(reporte, "Cierre de Caja");
        }

        private void btnInformesPrepago_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ArchivoBitacora)) return;

            float dineroPrepago = 0;
            int contador = 0;

            string[] lineas = File.ReadAllLines(ArchivoBitacora);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length >= 5 && datos[2].Contains("Prepago"))
                {
                    dineroPrepago += float.Parse(datos[3]);
                    contador++;
                }
            }

            MessageBox.Show($"*** REPORTE MODO PREPAGO ***\n\nDespachos realizados: {contador}\nTotal Ingresos: {dineroPrepago:C}", "Reporte Prepago");
        }

        private void btnInformesTanqueLleno_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ArchivoBitacora)) return;

            int contador = 0;

            string[] lineas = File.ReadAllLines(ArchivoBitacora);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length >= 5 && datos[2].Contains("Tanque Lleno"))
                {
                    contador++;
                }
            }

            MessageBox.Show($"*** REPORTE TANQUE LLENO ***\n\nCantidad de veces que los sensores de cobre detuvieron el llenado completo: {contador} veces.", "Reporte Sensores de Nivel");
        }

        private void btnInformeUsoBombas_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ArchivoBitacora))
            {
                MessageBox.Show("No hay historial suficiente para calcular estadísticas.");
                return;
            }

            int[] conteoBombas = new int[4];

            string[] lineas = File.ReadAllLines(ArchivoBitacora);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    int idBomba = int.Parse(datos[1]);
                    if (idBomba >= 1 && idBomba <= 4)
                    {
                        conteoBombas[idBomba - 1]++;
                    }
                }
            }

            int maxUsos = conteoBombas.Max();
            int minUsos = conteoBombas.Min();

            int bombaMasUsada = Array.IndexOf(conteoBombas, maxUsos) + 1;
            int bombaMenosUsada = Array.IndexOf(conteoBombas, minUsos) + 1;

            string estadisticas = $"*** ESTADÍSTICAS DE USO DE BOMBAS ***\n\n" +
                                 $"Bomba 1: {conteoBombas[0]} veces\n" +
                                 $"Bomba 2: {conteoBombas[1]} veces\n" +
                                 $"Bomba 3: {conteoBombas[2]} veces\n" +
                                 $"Bomba 4: {conteoBombas[3]} veces\n\n" +
                                 $"Bomba MÁS utilizada: Bomba {bombaMasUsada} ({maxUsos} usos)\n" +
                                 $"Bomba MENOS utilizada: Bomba {bombaMenosUsada} ({minUsos} usos)";

            MessageBox.Show(estadisticas, "Análisis de Infraestructura");
        }
        // --- NUEVA FUNCIÓN AUXILIAR: CARGAR TXT A LISTA DE OBJETOS POO ---
        private List<Transaccion> ObtenerListaTransaccionesDesdeTxt()
        {
            List<Transaccion> lista = new List<Transaccion>();
            if (!File.Exists(ArchivoBitacora)) return lista;

            string[] lineas = File.ReadAllLines(ArchivoBitacora);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    lista.Add(new Transaccion
                    {
                        FechaHora = datos[0],
                        Bomba = int.Parse(datos[1]),
                        Modo = datos[2],
                        Monto = float.Parse(datos[3]),
                        Litros = float.Parse(datos[4])
                    });
                }
            }
            return lista;
        }

        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            List<Transaccion> transacciones = ObtenerListaTransaccionesDesdeTxt();
            if (transacciones.Count == 0)
            {
                MessageBox.Show("No hay datos en la bitácora para exportar.");
                return;
            }

            try
            {
                // Serializar con formato legible indentado
                var opciones = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(transacciones, opciones);

                File.WriteAllText("ventas_gasolinera.json", jsonString);
                MessageBox.Show("Datos exportados exitosamente a 'ventas_gasolinera.json'", "Exportación JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a JSON: " + ex.Message);
            }
        }

        private void btnImportarJSON_Click(object sender, EventArgs e)
        {
            string rutaJson = "ventas_gasolinera.json";
            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No se encontró el archivo 'ventas_gasolinera.json'. Primero exporte datos.");
                return;
            }

            try
            {
                string jsonString = File.ReadAllText(rutaJson);
                List<Transaccion> listaImportada = JsonSerializer.Deserialize<List<Transaccion>>(jsonString);

                // Reconstruir la bitácora de texto local a partir del JSON importado
                using (StreamWriter sw = new StreamWriter(ArchivoBitacora, false)) // false sobrescribe el archivo existente
                {
                    foreach (var t in listaImportada)
                    {
                        sw.WriteLine($"{t.FechaHora}|{t.Bomba}|{t.Modo}|{t.Monto:F2}|{t.Litros:F2}");
                    }
                }

                MessageBox.Show($"Se importaron exitosamente {listaImportada.Count} registros desde el JSON a la bitácora del sistema.", "Importación JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar el archivo JSON: " + ex.Message);
            }
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            string rutaXml = "ventas_gasolinera.xml";
            if (!File.Exists(rutaXml))
            {
                MessageBox.Show("No se encontró el archivo 'ventas_gasolinera.xml'. Primero exporte datos.");
                return;
            }

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Transaccion>));
                List<Transaccion> listaImportada;

                using (StreamReader lector = new StreamReader(rutaXml))
                {
                    listaImportada = (List<Transaccion>)serializador.Deserialize(lector);
                }

                // Restaurar los datos leídos del XML dentro de nuestra bitácora de texto normal
                using (StreamWriter sw = new StreamWriter(ArchivoBitacora, false))
                {
                    foreach (var t in listaImportada)
                    {
                        sw.WriteLine($"{t.FechaHora}|{t.Bomba}|{t.Modo}|{t.Monto:F2}|{t.Litros:F2}");
                    }
                }

                MessageBox.Show($"Se importaron exitosamente {listaImportada.Count} registros desde el XML a la bitácora del sistema.", "Importación XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar el archivo XML: " + ex.Message);
            }
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            List<Transaccion> transacciones = ObtenerListaTransaccionesDesdeTxt();
            if (transacciones.Count == 0)
            {
                MessageBox.Show("No hay datos en la bitácora para exportar.");
                return;
            }

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Transaccion>));
                using (StreamWriter escritor = new StreamWriter("ventas_gasolinera.xml"))
                {
                    serializador.Serialize(escritor, transacciones);
                }
                MessageBox.Show("Datos exportados exitosamente a 'ventas_gasolinera.xml'", "Exportación XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a XML: " + ex.Message);
            }
        }
    }
}
