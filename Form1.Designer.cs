namespace ProgramaFacturacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatosDelCliente = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcesamientoDeLaOrden = new System.Windows.Forms.GroupBox();
            this.txtSubtotalVestido = new System.Windows.Forms.TextBox();
            this.txtSubtotalPantalon = new System.Windows.Forms.TextBox();
            this.txtSubtotalCamisa = new System.Windows.Forms.TextBox();
            this.txtPrecioVestido = new System.Windows.Forms.TextBox();
            this.txtPrecioPantalon = new System.Windows.Forms.TextBox();
            this.txtPrecioCamisa = new System.Windows.Forms.TextBox();
            this.CantidadVestidos = new System.Windows.Forms.NumericUpDown();
            this.CantidadPantalones = new System.Windows.Forms.NumericUpDown();
            this.CantidadCamisas = new System.Windows.Forms.NumericUpDown();
            this.lblVestido = new System.Windows.Forms.Label();
            this.lblPantalon = new System.Windows.Forms.Label();
            this.lblCamisas = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTipoArticulo = new System.Windows.Forms.Label();
            this.ResumenDeLaOrden = new System.Windows.Forms.GroupBox();
            this.txtPrecioNeto = new System.Windows.Forms.TextBox();
            this.txtMontoImpuestos = new System.Windows.Forms.TextBox();
            this.txtTasaImpuestos = new System.Windows.Forms.TextBox();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            this.lblMontoImpuesto = new System.Windows.Forms.Label();
            this.lblTasaImpuestos = new System.Windows.Forms.Label();
            this.lblTotalOrden = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.DatosDelCliente.SuspendLayout();
            this.ProcesamientoDeLaOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVestidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPantalones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCamisas)).BeginInit();
            this.ResumenDeLaOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosDelCliente
            // 
            this.DatosDelCliente.Controls.Add(this.dateTimePicker1);
            this.DatosDelCliente.Controls.Add(this.label4);
            this.DatosDelCliente.Controls.Add(this.txtDireccionCliente);
            this.DatosDelCliente.Controls.Add(this.label3);
            this.DatosDelCliente.Controls.Add(this.txtNumCliente);
            this.DatosDelCliente.Controls.Add(this.txtNombreCliente);
            this.DatosDelCliente.Controls.Add(this.label2);
            this.DatosDelCliente.Controls.Add(this.label1);
            this.DatosDelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelCliente.Location = new System.Drawing.Point(12, 12);
            this.DatosDelCliente.Name = "DatosDelCliente";
            this.DatosDelCliente.Size = new System.Drawing.Size(710, 122);
            this.DatosDelCliente.TabIndex = 0;
            this.DatosDelCliente.TabStop = false;
            this.DatosDelCliente.Text = "Datos del Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(369, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de la Orden:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(473, 32);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(198, 20);
            this.txtDireccionCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(360, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección del Cliente:";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCliente.Location = new System.Drawing.Point(74, 83);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(257, 20);
            this.txtNumCliente.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(74, 32);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(257, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // ProcesamientoDeLaOrden
            // 
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtSubtotalVestido);
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtSubtotalPantalon);
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtSubtotalCamisa);
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtPrecioVestido);
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtPrecioPantalon);
            this.ProcesamientoDeLaOrden.Controls.Add(this.txtPrecioCamisa);
            this.ProcesamientoDeLaOrden.Controls.Add(this.CantidadVestidos);
            this.ProcesamientoDeLaOrden.Controls.Add(this.CantidadPantalones);
            this.ProcesamientoDeLaOrden.Controls.Add(this.CantidadCamisas);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblVestido);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblPantalon);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblCamisas);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblSubtotal);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblPrecioUnidad);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblCantidad);
            this.ProcesamientoDeLaOrden.Controls.Add(this.lblTipoArticulo);
            this.ProcesamientoDeLaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesamientoDeLaOrden.Location = new System.Drawing.Point(12, 169);
            this.ProcesamientoDeLaOrden.Name = "ProcesamientoDeLaOrden";
            this.ProcesamientoDeLaOrden.Size = new System.Drawing.Size(477, 174);
            this.ProcesamientoDeLaOrden.TabIndex = 1;
            this.ProcesamientoDeLaOrden.TabStop = false;
            this.ProcesamientoDeLaOrden.Text = "Procesamiento de la Orden";
            // 
            // txtSubtotalVestido
            // 
            this.txtSubtotalVestido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalVestido.Location = new System.Drawing.Point(348, 135);
            this.txtSubtotalVestido.Name = "txtSubtotalVestido";
            this.txtSubtotalVestido.ReadOnly = true;
            this.txtSubtotalVestido.Size = new System.Drawing.Size(94, 20);
            this.txtSubtotalVestido.TabIndex = 12;
            this.txtSubtotalVestido.TabStop = false;
            // 
            // txtSubtotalPantalon
            // 
            this.txtSubtotalPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalPantalon.Location = new System.Drawing.Point(348, 102);
            this.txtSubtotalPantalon.Name = "txtSubtotalPantalon";
            this.txtSubtotalPantalon.ReadOnly = true;
            this.txtSubtotalPantalon.Size = new System.Drawing.Size(94, 20);
            this.txtSubtotalPantalon.TabIndex = 9;
            this.txtSubtotalPantalon.TabStop = false;
            // 
            // txtSubtotalCamisa
            // 
            this.txtSubtotalCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalCamisa.Location = new System.Drawing.Point(348, 69);
            this.txtSubtotalCamisa.Name = "txtSubtotalCamisa";
            this.txtSubtotalCamisa.ReadOnly = true;
            this.txtSubtotalCamisa.Size = new System.Drawing.Size(94, 20);
            this.txtSubtotalCamisa.TabIndex = 6;
            this.txtSubtotalCamisa.TabStop = false;
            // 
            // txtPrecioVestido
            // 
            this.txtPrecioVestido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVestido.Location = new System.Drawing.Point(227, 135);
            this.txtPrecioVestido.Name = "txtPrecioVestido";
            this.txtPrecioVestido.Size = new System.Drawing.Size(85, 20);
            this.txtPrecioVestido.TabIndex = 11;
            this.txtPrecioVestido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVestido.TextChanged += new System.EventHandler(this.txtPrecioCamisa_TextChanged);
            this.txtPrecioVestido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCamisa_KeyPress);
            // 
            // txtPrecioPantalon
            // 
            this.txtPrecioPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPantalon.Location = new System.Drawing.Point(227, 102);
            this.txtPrecioPantalon.Name = "txtPrecioPantalon";
            this.txtPrecioPantalon.Size = new System.Drawing.Size(85, 20);
            this.txtPrecioPantalon.TabIndex = 8;
            this.txtPrecioPantalon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioPantalon.TextChanged += new System.EventHandler(this.txtPrecioCamisa_TextChanged);
            this.txtPrecioPantalon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCamisa_KeyPress);
            // 
            // txtPrecioCamisa
            // 
            this.txtPrecioCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCamisa.Location = new System.Drawing.Point(227, 70);
            this.txtPrecioCamisa.Name = "txtPrecioCamisa";
            this.txtPrecioCamisa.Size = new System.Drawing.Size(85, 20);
            this.txtPrecioCamisa.TabIndex = 5;
            this.txtPrecioCamisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCamisa.TextChanged += new System.EventHandler(this.txtPrecioCamisa_TextChanged);
            this.txtPrecioCamisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCamisa_KeyPress);
            // 
            // CantidadVestidos
            // 
            this.CantidadVestidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadVestidos.Location = new System.Drawing.Point(146, 136);
            this.CantidadVestidos.Name = "CantidadVestidos";
            this.CantidadVestidos.Size = new System.Drawing.Size(32, 20);
            this.CantidadVestidos.TabIndex = 10;
            // 
            // CantidadPantalones
            // 
            this.CantidadPantalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadPantalones.Location = new System.Drawing.Point(146, 103);
            this.CantidadPantalones.Name = "CantidadPantalones";
            this.CantidadPantalones.Size = new System.Drawing.Size(32, 20);
            this.CantidadPantalones.TabIndex = 7;
            // 
            // CantidadCamisas
            // 
            this.CantidadCamisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCamisas.Location = new System.Drawing.Point(146, 70);
            this.CantidadCamisas.Name = "CantidadCamisas";
            this.CantidadCamisas.Size = new System.Drawing.Size(32, 20);
            this.CantidadCamisas.TabIndex = 4;
            // 
            // lblVestido
            // 
            this.lblVestido.AutoSize = true;
            this.lblVestido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVestido.Location = new System.Drawing.Point(26, 138);
            this.lblVestido.Name = "lblVestido";
            this.lblVestido.Size = new System.Drawing.Size(42, 13);
            this.lblVestido.TabIndex = 9;
            this.lblVestido.Text = "Vestido";
            // 
            // lblPantalon
            // 
            this.lblPantalon.AutoSize = true;
            this.lblPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalon.Location = new System.Drawing.Point(26, 105);
            this.lblPantalon.Name = "lblPantalon";
            this.lblPantalon.Size = new System.Drawing.Size(49, 13);
            this.lblPantalon.TabIndex = 8;
            this.lblPantalon.Text = "Pantalón";
            // 
            // lblCamisas
            // 
            this.lblCamisas.AutoSize = true;
            this.lblCamisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamisas.Location = new System.Drawing.Point(26, 72);
            this.lblCamisas.Name = "lblCamisas";
            this.lblCamisas.Size = new System.Drawing.Size(41, 13);
            this.lblCamisas.TabIndex = 7;
            this.lblCamisas.Text = "Camisa";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(345, 33);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(52, 15);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnidad.Location = new System.Drawing.Point(224, 30);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(88, 15);
            this.lblPrecioUnidad.TabIndex = 5;
            this.lblPrecioUnidad.Text = "Precio Unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(143, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(35, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cant.";
            // 
            // lblTipoArticulo
            // 
            this.lblTipoArticulo.AutoSize = true;
            this.lblTipoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArticulo.Location = new System.Drawing.Point(21, 30);
            this.lblTipoArticulo.Name = "lblTipoArticulo";
            this.lblTipoArticulo.Size = new System.Drawing.Size(91, 15);
            this.lblTipoArticulo.TabIndex = 3;
            this.lblTipoArticulo.Text = "Tipo de Artículo";
            // 
            // ResumenDeLaOrden
            // 
            this.ResumenDeLaOrden.Controls.Add(this.txtPrecioNeto);
            this.ResumenDeLaOrden.Controls.Add(this.txtMontoImpuestos);
            this.ResumenDeLaOrden.Controls.Add(this.txtTasaImpuestos);
            this.ResumenDeLaOrden.Controls.Add(this.txtTotalOrden);
            this.ResumenDeLaOrden.Controls.Add(this.lblPrecioNeto);
            this.ResumenDeLaOrden.Controls.Add(this.lblMontoImpuesto);
            this.ResumenDeLaOrden.Controls.Add(this.lblTasaImpuestos);
            this.ResumenDeLaOrden.Controls.Add(this.lblTotalOrden);
            this.ResumenDeLaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumenDeLaOrden.Location = new System.Drawing.Point(505, 169);
            this.ResumenDeLaOrden.Name = "ResumenDeLaOrden";
            this.ResumenDeLaOrden.Size = new System.Drawing.Size(217, 174);
            this.ResumenDeLaOrden.TabIndex = 2;
            this.ResumenDeLaOrden.TabStop = false;
            this.ResumenDeLaOrden.Text = "Resumen de Orden";
            // 
            // txtPrecioNeto
            // 
            this.txtPrecioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioNeto.Location = new System.Drawing.Point(141, 136);
            this.txtPrecioNeto.Name = "txtPrecioNeto";
            this.txtPrecioNeto.ReadOnly = true;
            this.txtPrecioNeto.Size = new System.Drawing.Size(61, 20);
            this.txtPrecioNeto.TabIndex = 16;
            // 
            // txtMontoImpuestos
            // 
            this.txtMontoImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoImpuestos.Location = new System.Drawing.Point(141, 102);
            this.txtMontoImpuestos.Name = "txtMontoImpuestos";
            this.txtMontoImpuestos.ReadOnly = true;
            this.txtMontoImpuestos.Size = new System.Drawing.Size(61, 20);
            this.txtMontoImpuestos.TabIndex = 15;
            // 
            // txtTasaImpuestos
            // 
            this.txtTasaImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaImpuestos.Location = new System.Drawing.Point(141, 68);
            this.txtTasaImpuestos.Name = "txtTasaImpuestos";
            this.txtTasaImpuestos.Size = new System.Drawing.Size(61, 20);
            this.txtTasaImpuestos.TabIndex = 14;
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrden.Location = new System.Drawing.Point(141, 29);
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.ReadOnly = true;
            this.txtTotalOrden.Size = new System.Drawing.Size(61, 20);
            this.txtTotalOrden.TabIndex = 13;
            this.txtTotalOrden.TextChanged += new System.EventHandler(this.txtTotalOrden_TextChanged);
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNeto.Location = new System.Drawing.Point(17, 137);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(71, 15);
            this.lblPrecioNeto.TabIndex = 6;
            this.lblPrecioNeto.Text = "Precio Neto";
            // 
            // lblMontoImpuesto
            // 
            this.lblMontoImpuesto.AutoSize = true;
            this.lblMontoImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoImpuesto.Location = new System.Drawing.Point(17, 103);
            this.lblMontoImpuesto.Name = "lblMontoImpuesto";
            this.lblMontoImpuesto.Size = new System.Drawing.Size(102, 15);
            this.lblMontoImpuesto.TabIndex = 5;
            this.lblMontoImpuesto.Text = "Monto Impuestos";
            // 
            // lblTasaImpuestos
            // 
            this.lblTasaImpuestos.AutoSize = true;
            this.lblTasaImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaImpuestos.Location = new System.Drawing.Point(17, 69);
            this.lblTasaImpuestos.Name = "lblTasaImpuestos";
            this.lblTasaImpuestos.Size = new System.Drawing.Size(114, 15);
            this.lblTasaImpuestos.TabIndex = 4;
            this.lblTasaImpuestos.Text = "Tasa de Impuestos:";
            // 
            // lblTotalOrden
            // 
            this.lblTotalOrden.AutoSize = true;
            this.lblTotalOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrden.Location = new System.Drawing.Point(17, 30);
            this.lblTotalOrden.Name = "lblTotalOrden";
            this.lblTotalOrden.Size = new System.Drawing.Size(104, 15);
            this.lblTotalOrden.TabIndex = 3;
            this.lblTotalOrden.Text = "Total de la Orden:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(477, 49);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(505, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 49);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(566, 418);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(156, 13);
            this.lblCredits.TabIndex = 19;
            this.lblCredits.Text = "Winston Pichardo, ID: 1115997";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(735, 437);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ResumenDeLaOrden);
            this.Controls.Add(this.ProcesamientoDeLaOrden);
            this.Controls.Add(this.DatosDelCliente);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Programa de Facturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DatosDelCliente.ResumeLayout(false);
            this.DatosDelCliente.PerformLayout();
            this.ProcesamientoDeLaOrden.ResumeLayout(false);
            this.ProcesamientoDeLaOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVestidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPantalones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCamisas)).EndInit();
            this.ResumenDeLaOrden.ResumeLayout(false);
            this.ResumenDeLaOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosDelCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox ProcesamientoDeLaOrden;
        private System.Windows.Forms.Label lblTipoArticulo;
        private System.Windows.Forms.GroupBox ResumenDeLaOrden;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblVestido;
        private System.Windows.Forms.Label lblPantalon;
        private System.Windows.Forms.Label lblCamisas;
        private System.Windows.Forms.TextBox txtSubtotalVestido;
        private System.Windows.Forms.TextBox txtSubtotalPantalon;
        private System.Windows.Forms.TextBox txtSubtotalCamisa;
        private System.Windows.Forms.TextBox txtPrecioVestido;
        private System.Windows.Forms.TextBox txtPrecioPantalon;
        private System.Windows.Forms.TextBox txtPrecioCamisa;
        private System.Windows.Forms.NumericUpDown CantidadVestidos;
        private System.Windows.Forms.NumericUpDown CantidadPantalones;
        private System.Windows.Forms.NumericUpDown CantidadCamisas;
        private System.Windows.Forms.TextBox txtPrecioNeto;
        private System.Windows.Forms.TextBox txtMontoImpuestos;
        private System.Windows.Forms.TextBox txtTasaImpuestos;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.Label lblPrecioNeto;
        private System.Windows.Forms.Label lblMontoImpuesto;
        private System.Windows.Forms.Label lblTasaImpuestos;
        private System.Windows.Forms.Label lblTotalOrden;
        private System.Windows.Forms.Label lblCredits;
    }
}

