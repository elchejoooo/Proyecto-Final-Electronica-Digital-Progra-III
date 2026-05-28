namespace DigitalProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrecioActual = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblEstadoGlobal = new Label();
            groupBox1 = new GroupBox();
            btnPagoTanqueTotal = new Button();
            label15 = new Label();
            btnPagoPrepago = new Button();
            label14 = new Label();
            txtPagoPrepago = new TextBox();
            btnApagarBomba4 = new Button();
            btnEncenderBomba4 = new Button();
            btnApagarBomba3 = new Button();
            btnEncenderBomba3 = new Button();
            btnApagarBomba2 = new Button();
            btnEncenderBomba2 = new Button();
            lblEstadoBomba4 = new Label();
            lblEstadoBomba3 = new Label();
            lblEstadoBomba2 = new Label();
            lblEstadoBomba1 = new Label();
            btnApagarBomba1 = new Button();
            btnEncenderBomba1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnAjustarPrecio4 = new Button();
            btnAjustarPrecio3 = new Button();
            btnAjustarPrecio2 = new Button();
            btnAjustarPrecio1 = new Button();
            txtPrecioBomba4 = new TextBox();
            txtPrecioBomba3 = new TextBox();
            txtPrecioBomba2 = new TextBox();
            txtPrecioBomba1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabPage3 = new TabPage();
            btnExportarJSON = new Button();
            btnImportarJSON = new Button();
            btnExportarXML = new Button();
            btnImportarXML = new Button();
            btnInformeUsoBombas = new Button();
            label8 = new Label();
            btnInformesTanqueLleno = new Button();
            label7 = new Label();
            btnInformesPrepago = new Button();
            label6 = new Label();
            btnCierreDiario = new Button();
            label5 = new Label();
            dtgvServicios = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvServicios).BeginInit();
            SuspendLayout();
            // 
            // lblPrecioActual
            // 
            lblPrecioActual.AutoSize = true;
            lblPrecioActual.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioActual.Location = new Point(18, 23);
            lblPrecioActual.Name = "lblPrecioActual";
            lblPrecioActual.Size = new Size(464, 89);
            lblPrecioActual.TabIndex = 0;
            lblPrecioActual.Text = "Precio de Hoy:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2860, 1320);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(lblEstadoGlobal);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnApagarBomba4);
            tabPage1.Controls.Add(btnEncenderBomba4);
            tabPage1.Controls.Add(btnApagarBomba3);
            tabPage1.Controls.Add(btnEncenderBomba3);
            tabPage1.Controls.Add(btnApagarBomba2);
            tabPage1.Controls.Add(btnEncenderBomba2);
            tabPage1.Controls.Add(lblEstadoBomba4);
            tabPage1.Controls.Add(lblEstadoBomba3);
            tabPage1.Controls.Add(lblEstadoBomba2);
            tabPage1.Controls.Add(lblEstadoBomba1);
            tabPage1.Controls.Add(btnApagarBomba1);
            tabPage1.Controls.Add(btnEncenderBomba1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblPrecioActual);
            tabPage1.Location = new Point(10, 58);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2840, 1252);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Despacho de Gasolina";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEstadoGlobal
            // 
            lblEstadoGlobal.AutoSize = true;
            lblEstadoGlobal.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoGlobal.Location = new Point(52, 1102);
            lblEstadoGlobal.Name = "lblEstadoGlobal";
            lblEstadoGlobal.Size = new Size(443, 89);
            lblEstadoGlobal.TabIndex = 18;
            lblEstadoGlobal.Text = "Estado Global";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPagoTanqueTotal);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(btnPagoPrepago);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtPagoPrepago);
            groupBox1.Location = new Point(2058, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(732, 803);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBoxMetodoPago";
            // 
            // btnPagoTanqueTotal
            // 
            btnPagoTanqueTotal.Location = new Point(21, 380);
            btnPagoTanqueTotal.Name = "btnPagoTanqueTotal";
            btnPagoTanqueTotal.Size = new Size(289, 53);
            btnPagoTanqueTotal.TabIndex = 5;
            btnPagoTanqueTotal.Text = "Pago Total";
            btnPagoTanqueTotal.UseVisualStyleBackColor = true;
            btnPagoTanqueTotal.Click += btnPagoTanqueTotal_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 326);
            label15.Name = "label15";
            label15.Size = new Size(532, 41);
            label15.TabIndex = 3;
            label15.Text = "Pago Total (Ingrese tamaño de tanque)";
            // 
            // btnPagoPrepago
            // 
            btnPagoPrepago.Location = new Point(24, 228);
            btnPagoPrepago.Name = "btnPagoPrepago";
            btnPagoPrepago.Size = new Size(289, 53);
            btnPagoPrepago.TabIndex = 2;
            btnPagoPrepago.Text = "Pago Prepago";
            btnPagoPrepago.UseVisualStyleBackColor = true;
            btnPagoPrepago.Click += btnPagoPrepago_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 95);
            label14.Name = "label14";
            label14.Size = new Size(292, 41);
            label14.TabIndex = 1;
            label14.Text = "Ingreso por Prepago";
            // 
            // txtPagoPrepago
            // 
            txtPagoPrepago.Location = new Point(24, 154);
            txtPagoPrepago.Name = "txtPagoPrepago";
            txtPagoPrepago.Size = new Size(526, 47);
            txtPagoPrepago.TabIndex = 0;
            // 
            // btnApagarBomba4
            // 
            btnApagarBomba4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagarBomba4.Location = new Point(1669, 666);
            btnApagarBomba4.Name = "btnApagarBomba4";
            btnApagarBomba4.Size = new Size(327, 140);
            btnApagarBomba4.TabIndex = 16;
            btnApagarBomba4.Text = "Apagar";
            btnApagarBomba4.UseVisualStyleBackColor = true;
            btnApagarBomba4.Click += btnApagarBomba4_Click;
            // 
            // btnEncenderBomba4
            // 
            btnEncenderBomba4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncenderBomba4.Location = new Point(1669, 484);
            btnEncenderBomba4.Name = "btnEncenderBomba4";
            btnEncenderBomba4.Size = new Size(327, 140);
            btnEncenderBomba4.TabIndex = 15;
            btnEncenderBomba4.Text = "Encender";
            btnEncenderBomba4.UseVisualStyleBackColor = true;
            btnEncenderBomba4.Click += btnEncenderBomba4_Click;
            // 
            // btnApagarBomba3
            // 
            btnApagarBomba3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagarBomba3.Location = new Point(1150, 666);
            btnApagarBomba3.Name = "btnApagarBomba3";
            btnApagarBomba3.Size = new Size(327, 140);
            btnApagarBomba3.TabIndex = 14;
            btnApagarBomba3.Text = "Apagar";
            btnApagarBomba3.UseVisualStyleBackColor = true;
            btnApagarBomba3.Click += btnApagarBomba3_Click;
            // 
            // btnEncenderBomba3
            // 
            btnEncenderBomba3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncenderBomba3.Location = new Point(1150, 484);
            btnEncenderBomba3.Name = "btnEncenderBomba3";
            btnEncenderBomba3.Size = new Size(327, 140);
            btnEncenderBomba3.TabIndex = 13;
            btnEncenderBomba3.Text = "Encender";
            btnEncenderBomba3.UseVisualStyleBackColor = true;
            btnEncenderBomba3.Click += btnEncenderBomba3_Click;
            // 
            // btnApagarBomba2
            // 
            btnApagarBomba2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagarBomba2.Location = new Point(585, 666);
            btnApagarBomba2.Name = "btnApagarBomba2";
            btnApagarBomba2.Size = new Size(327, 140);
            btnApagarBomba2.TabIndex = 12;
            btnApagarBomba2.Text = "Apagar";
            btnApagarBomba2.UseVisualStyleBackColor = true;
            btnApagarBomba2.Click += btnApagarBomba2_Click;
            // 
            // btnEncenderBomba2
            // 
            btnEncenderBomba2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncenderBomba2.Location = new Point(585, 484);
            btnEncenderBomba2.Name = "btnEncenderBomba2";
            btnEncenderBomba2.Size = new Size(327, 140);
            btnEncenderBomba2.TabIndex = 11;
            btnEncenderBomba2.Text = "Encender";
            btnEncenderBomba2.UseVisualStyleBackColor = true;
            btnEncenderBomba2.Click += btnEncenderBomba2_Click;
            // 
            // lblEstadoBomba4
            // 
            lblEstadoBomba4.AutoSize = true;
            lblEstadoBomba4.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoBomba4.Location = new Point(1669, 321);
            lblEstadoBomba4.Name = "lblEstadoBomba4";
            lblEstadoBomba4.Size = new Size(380, 62);
            lblEstadoBomba4.TabIndex = 10;
            lblEstadoBomba4.Text = "Estado: Apagado";
            // 
            // lblEstadoBomba3
            // 
            lblEstadoBomba3.AutoSize = true;
            lblEstadoBomba3.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoBomba3.Location = new Point(1150, 321);
            lblEstadoBomba3.Name = "lblEstadoBomba3";
            lblEstadoBomba3.Size = new Size(380, 62);
            lblEstadoBomba3.TabIndex = 9;
            lblEstadoBomba3.Text = "Estado: Apagado";
            // 
            // lblEstadoBomba2
            // 
            lblEstadoBomba2.AutoSize = true;
            lblEstadoBomba2.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoBomba2.Location = new Point(585, 321);
            lblEstadoBomba2.Name = "lblEstadoBomba2";
            lblEstadoBomba2.Size = new Size(380, 62);
            lblEstadoBomba2.TabIndex = 8;
            lblEstadoBomba2.Text = "Estado: Apagado";
            // 
            // lblEstadoBomba1
            // 
            lblEstadoBomba1.AutoSize = true;
            lblEstadoBomba1.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoBomba1.Location = new Point(65, 321);
            lblEstadoBomba1.Name = "lblEstadoBomba1";
            lblEstadoBomba1.Size = new Size(380, 62);
            lblEstadoBomba1.TabIndex = 7;
            lblEstadoBomba1.Text = "Estado: Apagado";
            // 
            // btnApagarBomba1
            // 
            btnApagarBomba1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagarBomba1.Location = new Point(65, 666);
            btnApagarBomba1.Name = "btnApagarBomba1";
            btnApagarBomba1.Size = new Size(327, 140);
            btnApagarBomba1.TabIndex = 6;
            btnApagarBomba1.Text = "Apagar";
            btnApagarBomba1.UseVisualStyleBackColor = true;
            btnApagarBomba1.Click += btnApagarBomba1_Click;
            // 
            // btnEncenderBomba1
            // 
            btnEncenderBomba1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncenderBomba1.Location = new Point(65, 484);
            btnEncenderBomba1.Name = "btnEncenderBomba1";
            btnEncenderBomba1.Size = new Size(327, 140);
            btnEncenderBomba1.TabIndex = 5;
            btnEncenderBomba1.Text = "Encender";
            btnEncenderBomba1.UseVisualStyleBackColor = true;
            btnEncenderBomba1.Click += btnEncenderBomba1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1150, 211);
            label4.Name = "label4";
            label4.Size = new Size(340, 89);
            label4.TabIndex = 4;
            label4.Text = "Bomba #3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1669, 211);
            label3.Name = "label3";
            label3.Size = new Size(340, 89);
            label3.TabIndex = 3;
            label3.Text = "Bomba #4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(585, 211);
            label2.Name = "label2";
            label2.Size = new Size(340, 89);
            label2.TabIndex = 2;
            label2.Text = "Bomba #2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 211);
            label1.Name = "label1";
            label1.Size = new Size(340, 89);
            label1.TabIndex = 1;
            label1.Text = "Bomba #1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAjustarPrecio4);
            tabPage2.Controls.Add(btnAjustarPrecio3);
            tabPage2.Controls.Add(btnAjustarPrecio2);
            tabPage2.Controls.Add(btnAjustarPrecio1);
            tabPage2.Controls.Add(txtPrecioBomba4);
            tabPage2.Controls.Add(txtPrecioBomba3);
            tabPage2.Controls.Add(txtPrecioBomba2);
            tabPage2.Controls.Add(txtPrecioBomba1);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(10, 58);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2840, 1252);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administracion de Precio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAjustarPrecio4
            // 
            btnAjustarPrecio4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustarPrecio4.Location = new Point(1703, 463);
            btnAjustarPrecio4.Name = "btnAjustarPrecio4";
            btnAjustarPrecio4.Size = new Size(327, 140);
            btnAjustarPrecio4.TabIndex = 14;
            btnAjustarPrecio4.Text = "Ajustar";
            btnAjustarPrecio4.UseVisualStyleBackColor = true;
            btnAjustarPrecio4.Click += btnAjustarPrecio4_Click;
            // 
            // btnAjustarPrecio3
            // 
            btnAjustarPrecio3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustarPrecio3.Location = new Point(1157, 463);
            btnAjustarPrecio3.Name = "btnAjustarPrecio3";
            btnAjustarPrecio3.Size = new Size(327, 140);
            btnAjustarPrecio3.TabIndex = 13;
            btnAjustarPrecio3.Text = "Ajustar";
            btnAjustarPrecio3.UseVisualStyleBackColor = true;
            btnAjustarPrecio3.Click += btnAjustarPrecio3_Click;
            // 
            // btnAjustarPrecio2
            // 
            btnAjustarPrecio2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustarPrecio2.Location = new Point(620, 465);
            btnAjustarPrecio2.Name = "btnAjustarPrecio2";
            btnAjustarPrecio2.Size = new Size(327, 140);
            btnAjustarPrecio2.TabIndex = 12;
            btnAjustarPrecio2.Text = "Ajustar";
            btnAjustarPrecio2.UseVisualStyleBackColor = true;
            btnAjustarPrecio2.Click += btnAjustarPrecio2_Click;
            // 
            // btnAjustarPrecio1
            // 
            btnAjustarPrecio1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustarPrecio1.Location = new Point(53, 465);
            btnAjustarPrecio1.Name = "btnAjustarPrecio1";
            btnAjustarPrecio1.Size = new Size(327, 140);
            btnAjustarPrecio1.TabIndex = 11;
            btnAjustarPrecio1.Text = "Ajustar";
            btnAjustarPrecio1.UseVisualStyleBackColor = true;
            btnAjustarPrecio1.Click += btnAjustarPrecio1_Click;
            // 
            // txtPrecioBomba4
            // 
            txtPrecioBomba4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioBomba4.Location = new Point(1703, 310);
            txtPrecioBomba4.Name = "txtPrecioBomba4";
            txtPrecioBomba4.Size = new Size(363, 87);
            txtPrecioBomba4.TabIndex = 10;
            // 
            // txtPrecioBomba3
            // 
            txtPrecioBomba3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioBomba3.Location = new Point(1161, 310);
            txtPrecioBomba3.Name = "txtPrecioBomba3";
            txtPrecioBomba3.Size = new Size(363, 87);
            txtPrecioBomba3.TabIndex = 9;
            // 
            // txtPrecioBomba2
            // 
            txtPrecioBomba2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioBomba2.Location = new Point(620, 310);
            txtPrecioBomba2.Name = "txtPrecioBomba2";
            txtPrecioBomba2.Size = new Size(363, 87);
            txtPrecioBomba2.TabIndex = 8;
            // 
            // txtPrecioBomba1
            // 
            txtPrecioBomba1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioBomba1.Location = new Point(53, 310);
            txtPrecioBomba1.Name = "txtPrecioBomba1";
            txtPrecioBomba1.Size = new Size(363, 87);
            txtPrecioBomba1.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(1703, 174);
            label13.Name = "label13";
            label13.Size = new Size(340, 89);
            label13.TabIndex = 6;
            label13.Text = "Bomba #4";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1161, 174);
            label12.Name = "label12";
            label12.Size = new Size(340, 89);
            label12.TabIndex = 5;
            label12.Text = "Bomba #3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(620, 174);
            label11.Name = "label11";
            label11.Size = new Size(340, 89);
            label11.TabIndex = 4;
            label11.Text = "Bomba #2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(53, 174);
            label10.Name = "label10";
            label10.Size = new Size(340, 89);
            label10.TabIndex = 3;
            label10.Text = "Bomba #1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 39);
            label9.Name = "label9";
            label9.Size = new Size(577, 89);
            label9.TabIndex = 2;
            label9.Text = "Control de Precios";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnExportarJSON);
            tabPage3.Controls.Add(btnImportarJSON);
            tabPage3.Controls.Add(btnExportarXML);
            tabPage3.Controls.Add(btnImportarXML);
            tabPage3.Controls.Add(btnInformeUsoBombas);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(btnInformesTanqueLleno);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(btnInformesPrepago);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(btnCierreDiario);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dtgvServicios);
            tabPage3.Location = new Point(10, 58);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(2840, 1252);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Historial de servicio";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExportarJSON
            // 
            btnExportarJSON.Location = new Point(321, 912);
            btnExportarJSON.Name = "btnExportarJSON";
            btnExportarJSON.Size = new Size(282, 114);
            btnExportarJSON.TabIndex = 12;
            btnExportarJSON.Text = "Exportar JSON";
            btnExportarJSON.UseVisualStyleBackColor = true;
            btnExportarJSON.Click += btnExportarJSON_Click;
            // 
            // btnImportarJSON
            // 
            btnImportarJSON.Location = new Point(3, 912);
            btnImportarJSON.Name = "btnImportarJSON";
            btnImportarJSON.Size = new Size(282, 114);
            btnImportarJSON.TabIndex = 11;
            btnImportarJSON.Text = "Importar JSON";
            btnImportarJSON.UseVisualStyleBackColor = true;
            btnImportarJSON.Click += btnImportarJSON_Click;
            // 
            // btnExportarXML
            // 
            btnExportarXML.Location = new Point(321, 761);
            btnExportarXML.Name = "btnExportarXML";
            btnExportarXML.Size = new Size(282, 114);
            btnExportarXML.TabIndex = 10;
            btnExportarXML.Text = "Exportar XML";
            btnExportarXML.UseVisualStyleBackColor = true;
            btnExportarXML.Click += btnExportarXML_Click;
            // 
            // btnImportarXML
            // 
            btnImportarXML.Location = new Point(6, 761);
            btnImportarXML.Name = "btnImportarXML";
            btnImportarXML.Size = new Size(282, 114);
            btnImportarXML.TabIndex = 9;
            btnImportarXML.Text = "Importar XML";
            btnImportarXML.UseVisualStyleBackColor = true;
            btnImportarXML.Click += btnImportarXML_Click;
            // 
            // btnInformeUsoBombas
            // 
            btnInformeUsoBombas.Location = new Point(18, 606);
            btnInformeUsoBombas.Name = "btnInformeUsoBombas";
            btnInformeUsoBombas.Size = new Size(385, 71);
            btnInformeUsoBombas.TabIndex = 8;
            btnInformeUsoBombas.Text = "Informes Uso de Bombas";
            btnInformeUsoBombas.UseVisualStyleBackColor = true;
            btnInformeUsoBombas.Click += btnInformeUsoBombas_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 542);
            label8.Name = "label8";
            label8.Size = new Size(270, 41);
            label8.TabIndex = 7;
            label8.Text = "Uso de las Bombas";
            // 
            // btnInformesTanqueLleno
            // 
            btnInformesTanqueLleno.Location = new Point(18, 445);
            btnInformesTanqueLleno.Name = "btnInformesTanqueLleno";
            btnInformesTanqueLleno.Size = new Size(385, 71);
            btnInformesTanqueLleno.TabIndex = 6;
            btnInformesTanqueLleno.Text = "Informes de Tanque Lleno";
            btnInformesTanqueLleno.UseVisualStyleBackColor = true;
            btnInformesTanqueLleno.Click += btnInformesTanqueLleno_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 380);
            label7.Name = "label7";
            label7.Size = new Size(475, 41);
            label7.TabIndex = 5;
            label7.Text = "Abastecimientos por Tanque Lleno";
            // 
            // btnInformesPrepago
            // 
            btnInformesPrepago.Location = new Point(18, 268);
            btnInformesPrepago.Name = "btnInformesPrepago";
            btnInformesPrepago.Size = new Size(385, 71);
            btnInformesPrepago.TabIndex = 4;
            btnInformesPrepago.Text = "Informes de Prepago";
            btnInformesPrepago.UseVisualStyleBackColor = true;
            btnInformesPrepago.Click += btnInformesPrepago_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 205);
            label6.Name = "label6";
            label6.Size = new Size(411, 41);
            label6.TabIndex = 3;
            label6.Text = "Abastecimientos por Prepago";
            // 
            // btnCierreDiario
            // 
            btnCierreDiario.Location = new Point(18, 101);
            btnCierreDiario.Name = "btnCierreDiario";
            btnCierreDiario.Size = new Size(385, 71);
            btnCierreDiario.TabIndex = 2;
            btnCierreDiario.Text = "Cierre Diario";
            btnCierreDiario.UseVisualStyleBackColor = true;
            btnCierreDiario.Click += btnCierreDiario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 29);
            label5.Name = "label5";
            label5.Size = new Size(324, 41);
            label5.TabIndex = 1;
            label5.Text = "Desplegar Cierre Diario";
            // 
            // dtgvServicios
            // 
            dtgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServicios.Location = new Point(628, 6);
            dtgvServicios.Name = "dtgvServicios";
            dtgvServicios.RowHeadersWidth = 102;
            dtgvServicios.Size = new Size(2206, 1062);
            dtgvServicios.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2899, 1323);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrecioActual;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnEncenderBomba1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Button btnApagarBomba4;
        private Button btnEncenderBomba4;
        private Button btnApagarBomba3;
        private Button btnEncenderBomba3;
        private Button btnApagarBomba2;
        private Button btnEncenderBomba2;
        private Label lblEstadoBomba4;
        private Label lblEstadoBomba3;
        private Label lblEstadoBomba2;
        private Label lblEstadoBomba1;
        private Button btnApagarBomba1;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnInformesPrepago;
        private Label label6;
        private Button btnCierreDiario;
        private Label label5;
        private DataGridView dtgvServicios;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnInformeUsoBombas;
        private Label label8;
        private Button btnInformesTanqueLleno;
        private Button btnAjustarPrecio4;
        private Button btnAjustarPrecio3;
        private Button btnAjustarPrecio2;
        private Button btnAjustarPrecio1;
        private TextBox txtPrecioBomba4;
        private TextBox txtPrecioBomba3;
        private TextBox txtPrecioBomba2;
        private TextBox txtPrecioBomba1;
        private Label label14;
        private TextBox txtPagoPrepago;
        private Button btnPagoTanqueTotal;
        private Label label15;
        private Button btnPagoPrepago;
        private Label lblEstadoGlobal;
        private Button btnExportarXML;
        private Button btnImportarXML;
        private Button btnExportarJSON;
        private Button btnImportarJSON;
    }
}
