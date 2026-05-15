using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProyectoFinal
{
    public partial class Form1 : Form
    {
        float precioBomba1, precioBomba2, precioBomba3, precioBomba4;
        private SerialPort spArduino;

        public Form1()
        {
            InitializeComponent();
            ConfigurarPuertoSerial();
            ActualizarLabelsPrecio();

        }
        //METODOS Y FUNCIONES REALIZADAS
        private void ConfigurarPuertoSerial()
        {
            spArduino = new SerialPort();
            try
            {
                spArduino.PortName = "COM9"; // Asegúrate que sea el COM correcto
                spArduino.BaudRate = 9600;
                if (!spArduino.IsOpen) spArduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con Arduino: " + ex.Message);
            }
        }

        private void ActualizarLabelsPrecio()
        {
            lblPrecioActual.Text = $"Precio actual: {precioBomba1:C} | {precioBomba2:C} | {precioBomba3:C} | {precioBomba4:C}";
        }


        // --- MÉTODOS DE CONTROL DE FLUJO ---

        private async Task IniciarDespacho(int numeroBomba, int tiempoSegundos, Label lblEstadoIndividual)
        {
            if (spArduino.IsOpen)
            {
                // 1. Encender la BOMBA ÚNICA para generar presión
                spArduino.Write("b");
                lblEstadoGlobal.Text = "Generando presión en el sistema...";
                lblEstadoIndividual.Text = "Esperando presión...";

                // 2. Tiempo de presurización (ajustado a 5s para pruebas, puedes subirlo a 60000 para 1 min)
                await Task.Delay(5000);

                // 3. Encender la electroválvula correspondiente
                spArduino.Write(numeroBomba.ToString());
                lblEstadoGlobal.Text = $"Despachando en Estación {numeroBomba}...";
                lblEstadoIndividual.Text = "Estado: ABIERTO";

                // 4. Tiempo de llenado (Simulando 1 litro en 3 min -> 180s)
                await Task.Delay(tiempoSegundos * 1000);

                // 5. Finalizar proceso
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
                spArduino.Write(comandosApagado[numeroBomba - 1]); // Apaga Válvula
                System.Threading.Thread.Sleep(500);
                spArduino.Write("x"); // Apaga la Bomba Única
            }

            lblEstadoGlobal.Text = "Sistema listo / Esperando orden";
            lblEstadoIndividual.Text = "Estado: CERRADO";
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

        private async void btnEncenderBomba1_Click(object sender, EventArgs e)
        {
            float monto;
            // 1. Validamos que haya dinero ingresado y que el precio no sea 0
            if (float.TryParse(txtPagoPrepago.Text, out monto) && precioBomba1 > 0)
            {
                // 2. Calculamos los litros y luego el tiempo en segundos
                // Ejemplo: Si paga Q10 y el litro cuesta Q10 -> 1 litro -> 180 segundos
                float litros = monto / precioBomba1;
                int tiempoSegundos = (int)(litros * 180);

                lblEstadoGlobal.Text = $"Pago: {monto:C}. Litros a servir: {litros:F2}L";

                // 3. Iniciamos el proceso automático
                await IniciarDespacho(1, tiempoSegundos, lblEstadoBomba1);

                // 4. Limpiamos el pago al terminar
                txtPagoPrepago.Clear();
            }
            else
            {
                MessageBox.Show("Asegúrese de ingresar un monto válido y que el precio de la bomba sea mayor a 0.");
            }
        }

        private async void btnEncenderBomba2_Click(object sender, EventArgs e)
        {
            float monto;
            // 1. Validamos que haya dinero ingresado y que el precio no sea 0
            if (float.TryParse(txtPagoPrepago.Text, out monto) && precioBomba2 > 0)
            {
                // 2. Calculamos los litros y luego el tiempo en segundos
                // Ejemplo: Si paga Q10 y el litro cuesta Q10 -> 1 litro -> 180 segundos
                float litros = monto / precioBomba2;
                int tiempoSegundos = (int)(litros * 180);

                lblEstadoGlobal.Text = $"Pago: {monto:C}. Litros a servir: {litros:F2}L";

                // 3. Iniciamos el proceso automático
                await IniciarDespacho(2, tiempoSegundos, lblEstadoBomba2);

                // 4. Limpiamos el pago al terminar
                txtPagoPrepago.Clear();
            }
            else
            {
                MessageBox.Show("Asegúrese de ingresar un monto válido y que el precio de la bomba sea mayor a 0.");
            }
        }

        private async void btnEncenderBomba3_Click(object sender, EventArgs e)
        {
            float monto;
            // 1. Validamos que haya dinero ingresado y que el precio no sea 0
            if (float.TryParse(txtPagoPrepago.Text, out monto) && precioBomba3 > 0)
            {
                // 2. Calculamos los litros y luego el tiempo en segundos
                // Ejemplo: Si paga Q10 y el litro cuesta Q10 -> 1 litro -> 180 segundos
                float litros = monto / precioBomba3;
                int tiempoSegundos = (int)(litros * 180);

                lblEstadoGlobal.Text = $"Pago: {monto:C}. Litros a servir: {litros:F2}L";

                // 3. Iniciamos el proceso automático
                await IniciarDespacho(3, tiempoSegundos, lblEstadoBomba3);

                // 4. Limpiamos el pago al terminar
                txtPagoPrepago.Clear();
            }
            else
            {
                MessageBox.Show("Asegúrese de ingresar un monto válido y que el precio de la bomba sea mayor a 0.");
            }
        }

        private async void btnEncenderBomba4_Click(object sender, EventArgs e)
        {
            float monto;
            // 1. Validamos que haya dinero ingresado y que el precio no sea 0
            if (float.TryParse(txtPagoPrepago.Text, out monto) && precioBomba4 > 0)
            {
                // 2. Calculamos los litros y luego el tiempo en segundos
                // Ejemplo: Si paga Q10 y el litro cuesta Q10 -> 1 litro -> 180 segundos
                float litros = monto / precioBomba4;
                int tiempoSegundos = (int)(litros * 180);

                lblEstadoGlobal.Text = $"Pago: {monto:C}. Litros a servir: {litros:F2}L";

                // 3. Iniciamos el proceso automático
                await IniciarDespacho(4, tiempoSegundos, lblEstadoBomba4);

                // 4. Limpiamos el pago al terminar
                txtPagoPrepago.Clear();
            }
            else
            {
                MessageBox.Show("Asegúrese de ingresar un monto válido y que el precio de la bomba sea mayor a 0.");
            }
        }

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
            if (spArduino.IsOpen) spArduino.Close();
        }

        private void btnPagoPrepago_Click(object sender, EventArgs e)
        {
            // Este botón podría servir solo para validar el monto, 
            // pero la acción real ocurre cuando eligen QUÉ bomba encender.
            if (string.IsNullOrEmpty(txtPagoPrepago.Text))
            {
                MessageBox.Show("Por favor, ingrese el monto a pagar.");
            }
            else
            {
                lblEstadoGlobal.Text = "Monto ingresado: " + txtPagoPrepago.Text + ". Seleccione bomba.";
            }
        }

        private void btnPagoTanqueTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
