namespace Presentacion
{
    partial class FrmCargar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargar));
            this.Tbcargar = new System.Windows.Forms.TabControl();
            this.Tbimportar = new System.Windows.Forms.TabPage();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.txthoja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.Txtruta = new System.Windows.Forms.TextBox();
            this.Gbtablas = new System.Windows.Forms.GroupBox();
            this.Rbdetallefactura = new System.Windows.Forms.RadioButton();
            this.Rbclientes = new System.Windows.Forms.RadioButton();
            this.Rbcontrol = new System.Windows.Forms.RadioButton();
            this.Rbfactura = new System.Windows.Forms.RadioButton();
            this.Rbcategorias = new System.Windows.Forms.RadioButton();
            this.Rboperador = new System.Windows.Forms.RadioButton();
            this.Rbmarcas = new System.Windows.Forms.RadioButton();
            this.Rbproductos = new System.Windows.Forms.RadioButton();
            this.Rbproveedores = new System.Windows.Forms.RadioButton();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btnimportar = new System.Windows.Forms.Button();
            this.Dgimportar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtguardar = new System.Windows.Forms.TextBox();
            this.GbExportar = new System.Windows.Forms.GroupBox();
            this.Rbexdetalle = new System.Windows.Forms.RadioButton();
            this.Rbexcliente = new System.Windows.Forms.RadioButton();
            this.Rbexcontrol = new System.Windows.Forms.RadioButton();
            this.Rbexfactura = new System.Windows.Forms.RadioButton();
            this.Rbexcategorias = new System.Windows.Forms.RadioButton();
            this.Rbexoperadores = new System.Windows.Forms.RadioButton();
            this.Rbexmarcas = new System.Windows.Forms.RadioButton();
            this.Rbexproductos = new System.Windows.Forms.RadioButton();
            this.Rbexproveedores = new System.Windows.Forms.RadioButton();
            this.Btnexlimpiar = new System.Windows.Forms.Button();
            this.Btnexportarexcel = new System.Windows.Forms.Button();
            this.Btnexportar = new System.Windows.Forms.Button();
            this.Dgexportar = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Tbcargar.SuspendLayout();
            this.Tbimportar.SuspendLayout();
            this.Gbtablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgimportar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GbExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgexportar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbcargar
            // 
            this.Tbcargar.Controls.Add(this.Tbimportar);
            this.Tbcargar.Controls.Add(this.tabPage2);
            this.Tbcargar.Location = new System.Drawing.Point(1, 3);
            this.Tbcargar.Name = "Tbcargar";
            this.Tbcargar.SelectedIndex = 0;
            this.Tbcargar.Size = new System.Drawing.Size(647, 658);
            this.Tbcargar.TabIndex = 0;
            // 
            // Tbimportar
            // 
            this.Tbimportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tbimportar.BackgroundImage")));
            this.Tbimportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tbimportar.Controls.Add(this.Btnlimpiar);
            this.Tbimportar.Controls.Add(this.txthoja);
            this.Tbimportar.Controls.Add(this.label2);
            this.Tbimportar.Controls.Add(this.Btnbuscar);
            this.Tbimportar.Controls.Add(this.Txtruta);
            this.Tbimportar.Controls.Add(this.Gbtablas);
            this.Tbimportar.Controls.Add(this.Btnguardar);
            this.Tbimportar.Controls.Add(this.Btnimportar);
            this.Tbimportar.Controls.Add(this.Dgimportar);
            this.Tbimportar.Location = new System.Drawing.Point(4, 22);
            this.Tbimportar.Name = "Tbimportar";
            this.Tbimportar.Padding = new System.Windows.Forms.Padding(3);
            this.Tbimportar.Size = new System.Drawing.Size(639, 632);
            this.Tbimportar.TabIndex = 0;
            this.Tbimportar.Text = "Importar";
            this.Tbimportar.UseVisualStyleBackColor = true;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnlimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.Btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btnlimpiar.Image")));
            this.Btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnlimpiar.Location = new System.Drawing.Point(342, 553);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(116, 49);
            this.Btnlimpiar.TabIndex = 23;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // txthoja
            // 
            this.txthoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoja.Location = new System.Drawing.Point(434, 61);
            this.txthoja.Name = "txthoja";
            this.txthoja.Size = new System.Drawing.Size(184, 26);
            this.txthoja.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hoja a leer";
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Location = new System.Drawing.Point(22, 57);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(88, 36);
            this.Btnbuscar.TabIndex = 20;
            this.Btnbuscar.Text = "Buscar";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // Txtruta
            // 
            this.Txtruta.Enabled = false;
            this.Txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtruta.Location = new System.Drawing.Point(118, 61);
            this.Txtruta.Name = "Txtruta";
            this.Txtruta.Size = new System.Drawing.Size(225, 26);
            this.Txtruta.TabIndex = 19;
            // 
            // Gbtablas
            // 
            this.Gbtablas.Controls.Add(this.Rbdetallefactura);
            this.Gbtablas.Controls.Add(this.Rbclientes);
            this.Gbtablas.Controls.Add(this.Rbcontrol);
            this.Gbtablas.Controls.Add(this.Rbfactura);
            this.Gbtablas.Controls.Add(this.Rbcategorias);
            this.Gbtablas.Controls.Add(this.Rboperador);
            this.Gbtablas.Controls.Add(this.Rbmarcas);
            this.Gbtablas.Controls.Add(this.Rbproductos);
            this.Gbtablas.Controls.Add(this.Rbproveedores);
            this.Gbtablas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbtablas.Location = new System.Drawing.Point(22, 322);
            this.Gbtablas.Name = "Gbtablas";
            this.Gbtablas.Size = new System.Drawing.Size(596, 212);
            this.Gbtablas.TabIndex = 14;
            this.Gbtablas.TabStop = false;
            this.Gbtablas.Text = "¿Que desea guardar?";
            // 
            // Rbdetallefactura
            // 
            this.Rbdetallefactura.AutoSize = true;
            this.Rbdetallefactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbdetallefactura.Location = new System.Drawing.Point(102, 111);
            this.Rbdetallefactura.Name = "Rbdetallefactura";
            this.Rbdetallefactura.Size = new System.Drawing.Size(128, 25);
            this.Rbdetallefactura.TabIndex = 14;
            this.Rbdetallefactura.TabStop = true;
            this.Rbdetallefactura.Text = "Detalle factura";
            this.Tmensaje.SetToolTip(this.Rbdetallefactura, "Para guardar detalle asegurese de que exista una factura con el mismo numero.");
            this.Rbdetallefactura.UseVisualStyleBackColor = true;
            // 
            // Rbclientes
            // 
            this.Rbclientes.AutoSize = true;
            this.Rbclientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbclientes.Location = new System.Drawing.Point(102, 49);
            this.Rbclientes.Name = "Rbclientes";
            this.Rbclientes.Size = new System.Drawing.Size(83, 25);
            this.Rbclientes.TabIndex = 6;
            this.Rbclientes.TabStop = true;
            this.Rbclientes.Text = "Clientes";
            this.Rbclientes.UseVisualStyleBackColor = true;
            // 
            // Rbcontrol
            // 
            this.Rbcontrol.AutoSize = true;
            this.Rbcontrol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbcontrol.Location = new System.Drawing.Point(321, 142);
            this.Rbcontrol.Name = "Rbcontrol";
            this.Rbcontrol.Size = new System.Drawing.Size(184, 25);
            this.Rbcontrol.TabIndex = 13;
            this.Rbcontrol.TabStop = true;
            this.Rbcontrol.Text = "Control de operadores";
            this.Rbcontrol.UseVisualStyleBackColor = true;
            // 
            // Rbfactura
            // 
            this.Rbfactura.AutoSize = true;
            this.Rbfactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbfactura.Location = new System.Drawing.Point(102, 80);
            this.Rbfactura.Name = "Rbfactura";
            this.Rbfactura.Size = new System.Drawing.Size(79, 25);
            this.Rbfactura.TabIndex = 7;
            this.Rbfactura.TabStop = true;
            this.Rbfactura.Text = "Factura";
            this.Rbfactura.UseVisualStyleBackColor = true;
            // 
            // Rbcategorias
            // 
            this.Rbcategorias.AutoSize = true;
            this.Rbcategorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbcategorias.Location = new System.Drawing.Point(321, 111);
            this.Rbcategorias.Name = "Rbcategorias";
            this.Rbcategorias.Size = new System.Drawing.Size(102, 25);
            this.Rbcategorias.TabIndex = 12;
            this.Rbcategorias.TabStop = true;
            this.Rbcategorias.Text = "Categorias";
            this.Rbcategorias.UseVisualStyleBackColor = true;
            // 
            // Rboperador
            // 
            this.Rboperador.AutoSize = true;
            this.Rboperador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rboperador.Location = new System.Drawing.Point(102, 142);
            this.Rboperador.Name = "Rboperador";
            this.Rboperador.Size = new System.Drawing.Size(110, 25);
            this.Rboperador.TabIndex = 10;
            this.Rboperador.TabStop = true;
            this.Rboperador.Text = "Operadores";
            this.Rboperador.UseVisualStyleBackColor = true;
            // 
            // Rbmarcas
            // 
            this.Rbmarcas.AutoSize = true;
            this.Rbmarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbmarcas.Location = new System.Drawing.Point(321, 80);
            this.Rbmarcas.Name = "Rbmarcas";
            this.Rbmarcas.Size = new System.Drawing.Size(78, 25);
            this.Rbmarcas.TabIndex = 9;
            this.Rbmarcas.TabStop = true;
            this.Rbmarcas.Text = "Marcas";
            this.Rbmarcas.UseVisualStyleBackColor = true;
            // 
            // Rbproductos
            // 
            this.Rbproductos.AutoSize = true;
            this.Rbproductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbproductos.Location = new System.Drawing.Point(102, 173);
            this.Rbproductos.Name = "Rbproductos";
            this.Rbproductos.Size = new System.Drawing.Size(98, 25);
            this.Rbproductos.TabIndex = 11;
            this.Rbproductos.TabStop = true;
            this.Rbproductos.Text = "Productos";
            this.Rbproductos.UseVisualStyleBackColor = true;
            // 
            // Rbproveedores
            // 
            this.Rbproveedores.AutoSize = true;
            this.Rbproveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbproveedores.Location = new System.Drawing.Point(321, 49);
            this.Rbproveedores.Name = "Rbproveedores";
            this.Rbproveedores.Size = new System.Drawing.Size(115, 25);
            this.Rbproveedores.TabIndex = 8;
            this.Rbproveedores.TabStop = true;
            this.Rbproveedores.Text = "Proveedores";
            this.Rbproveedores.UseVisualStyleBackColor = true;
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnguardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnguardar.ForeColor = System.Drawing.Color.Black;
            this.Btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("Btnguardar.Image")));
            this.Btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnguardar.Location = new System.Drawing.Point(149, 553);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(116, 49);
            this.Btnguardar.TabIndex = 5;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnguardar.UseVisualStyleBackColor = false;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Btnimportar
            // 
            this.Btnimportar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnimportar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnimportar.ForeColor = System.Drawing.Color.Black;
            this.Btnimportar.Image = ((System.Drawing.Image)(resources.GetObject("Btnimportar.Image")));
            this.Btnimportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnimportar.Location = new System.Drawing.Point(221, 104);
            this.Btnimportar.Name = "Btnimportar";
            this.Btnimportar.Size = new System.Drawing.Size(182, 46);
            this.Btnimportar.TabIndex = 3;
            this.Btnimportar.Text = "Importar Archivos";
            this.Btnimportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnimportar.UseVisualStyleBackColor = false;
            this.Btnimportar.Click += new System.EventHandler(this.Btnimportar_Click);
            // 
            // Dgimportar
            // 
            this.Dgimportar.AllowUserToDeleteRows = false;
            this.Dgimportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgimportar.Location = new System.Drawing.Point(22, 156);
            this.Dgimportar.Name = "Dgimportar";
            this.Dgimportar.ReadOnly = true;
            this.Dgimportar.Size = new System.Drawing.Size(596, 150);
            this.Dgimportar.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Txtguardar);
            this.tabPage2.Controls.Add(this.GbExportar);
            this.tabPage2.Controls.Add(this.Btnexlimpiar);
            this.tabPage2.Controls.Add(this.Btnexportarexcel);
            this.tabPage2.Controls.Add(this.Btnexportar);
            this.tabPage2.Controls.Add(this.Dgexportar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exportar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre a Guardar";
            // 
            // Txtguardar
            // 
            this.Txtguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtguardar.Location = new System.Drawing.Point(227, 543);
            this.Txtguardar.Name = "Txtguardar";
            this.Txtguardar.Size = new System.Drawing.Size(138, 26);
            this.Txtguardar.TabIndex = 26;
            // 
            // GbExportar
            // 
            this.GbExportar.Controls.Add(this.Rbexdetalle);
            this.GbExportar.Controls.Add(this.Rbexcliente);
            this.GbExportar.Controls.Add(this.Rbexcontrol);
            this.GbExportar.Controls.Add(this.Rbexfactura);
            this.GbExportar.Controls.Add(this.Rbexcategorias);
            this.GbExportar.Controls.Add(this.Rbexoperadores);
            this.GbExportar.Controls.Add(this.Rbexmarcas);
            this.GbExportar.Controls.Add(this.Rbexproductos);
            this.GbExportar.Controls.Add(this.Rbexproveedores);
            this.GbExportar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbExportar.Location = new System.Drawing.Point(17, 32);
            this.GbExportar.Name = "GbExportar";
            this.GbExportar.Size = new System.Drawing.Size(596, 212);
            this.GbExportar.TabIndex = 25;
            this.GbExportar.TabStop = false;
            this.GbExportar.Text = "¿Que tabla desea cargar?";
            // 
            // Rbexdetalle
            // 
            this.Rbexdetalle.AutoSize = true;
            this.Rbexdetalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexdetalle.Location = new System.Drawing.Point(102, 111);
            this.Rbexdetalle.Name = "Rbexdetalle";
            this.Rbexdetalle.Size = new System.Drawing.Size(128, 25);
            this.Rbexdetalle.TabIndex = 14;
            this.Rbexdetalle.TabStop = true;
            this.Rbexdetalle.Text = "Detalle factura";
            this.Tmensaje.SetToolTip(this.Rbexdetalle, "Para guardar detalle asegurese de que exista una factura con el mismo numero.");
            this.Rbexdetalle.UseVisualStyleBackColor = true;
            // 
            // Rbexcliente
            // 
            this.Rbexcliente.AutoSize = true;
            this.Rbexcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexcliente.Location = new System.Drawing.Point(102, 49);
            this.Rbexcliente.Name = "Rbexcliente";
            this.Rbexcliente.Size = new System.Drawing.Size(83, 25);
            this.Rbexcliente.TabIndex = 6;
            this.Rbexcliente.TabStop = true;
            this.Rbexcliente.Text = "Clientes";
            this.Rbexcliente.UseVisualStyleBackColor = true;
            // 
            // Rbexcontrol
            // 
            this.Rbexcontrol.AutoSize = true;
            this.Rbexcontrol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexcontrol.Location = new System.Drawing.Point(321, 142);
            this.Rbexcontrol.Name = "Rbexcontrol";
            this.Rbexcontrol.Size = new System.Drawing.Size(184, 25);
            this.Rbexcontrol.TabIndex = 13;
            this.Rbexcontrol.TabStop = true;
            this.Rbexcontrol.Text = "Control de operadores";
            this.Rbexcontrol.UseVisualStyleBackColor = true;
            // 
            // Rbexfactura
            // 
            this.Rbexfactura.AutoSize = true;
            this.Rbexfactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexfactura.Location = new System.Drawing.Point(102, 80);
            this.Rbexfactura.Name = "Rbexfactura";
            this.Rbexfactura.Size = new System.Drawing.Size(79, 25);
            this.Rbexfactura.TabIndex = 7;
            this.Rbexfactura.TabStop = true;
            this.Rbexfactura.Text = "Factura";
            this.Rbexfactura.UseVisualStyleBackColor = true;
            // 
            // Rbexcategorias
            // 
            this.Rbexcategorias.AutoSize = true;
            this.Rbexcategorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexcategorias.Location = new System.Drawing.Point(321, 111);
            this.Rbexcategorias.Name = "Rbexcategorias";
            this.Rbexcategorias.Size = new System.Drawing.Size(102, 25);
            this.Rbexcategorias.TabIndex = 12;
            this.Rbexcategorias.TabStop = true;
            this.Rbexcategorias.Text = "Categorias";
            this.Rbexcategorias.UseVisualStyleBackColor = true;
            // 
            // Rbexoperadores
            // 
            this.Rbexoperadores.AutoSize = true;
            this.Rbexoperadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexoperadores.Location = new System.Drawing.Point(102, 142);
            this.Rbexoperadores.Name = "Rbexoperadores";
            this.Rbexoperadores.Size = new System.Drawing.Size(110, 25);
            this.Rbexoperadores.TabIndex = 10;
            this.Rbexoperadores.TabStop = true;
            this.Rbexoperadores.Text = "Operadores";
            this.Rbexoperadores.UseVisualStyleBackColor = true;
            // 
            // Rbexmarcas
            // 
            this.Rbexmarcas.AutoSize = true;
            this.Rbexmarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexmarcas.Location = new System.Drawing.Point(321, 80);
            this.Rbexmarcas.Name = "Rbexmarcas";
            this.Rbexmarcas.Size = new System.Drawing.Size(78, 25);
            this.Rbexmarcas.TabIndex = 9;
            this.Rbexmarcas.TabStop = true;
            this.Rbexmarcas.Text = "Marcas";
            this.Rbexmarcas.UseVisualStyleBackColor = true;
            // 
            // Rbexproductos
            // 
            this.Rbexproductos.AutoSize = true;
            this.Rbexproductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexproductos.Location = new System.Drawing.Point(102, 173);
            this.Rbexproductos.Name = "Rbexproductos";
            this.Rbexproductos.Size = new System.Drawing.Size(98, 25);
            this.Rbexproductos.TabIndex = 11;
            this.Rbexproductos.TabStop = true;
            this.Rbexproductos.Text = "Productos";
            this.Rbexproductos.UseVisualStyleBackColor = true;
            // 
            // Rbexproveedores
            // 
            this.Rbexproveedores.AutoSize = true;
            this.Rbexproveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbexproveedores.Location = new System.Drawing.Point(321, 49);
            this.Rbexproveedores.Name = "Rbexproveedores";
            this.Rbexproveedores.Size = new System.Drawing.Size(115, 25);
            this.Rbexproveedores.TabIndex = 8;
            this.Rbexproveedores.TabStop = true;
            this.Rbexproveedores.Text = "Proveedores";
            this.Rbexproveedores.UseVisualStyleBackColor = true;
            // 
            // Btnexlimpiar
            // 
            this.Btnexlimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnexlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnexlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnexlimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexlimpiar.ForeColor = System.Drawing.Color.Black;
            this.Btnexlimpiar.Location = new System.Drawing.Point(476, 537);
            this.Btnexlimpiar.Name = "Btnexlimpiar";
            this.Btnexlimpiar.Size = new System.Drawing.Size(102, 38);
            this.Btnexlimpiar.TabIndex = 24;
            this.Btnexlimpiar.Text = "Limpiar";
            this.Btnexlimpiar.UseVisualStyleBackColor = false;
            this.Btnexlimpiar.Click += new System.EventHandler(this.Btnexlimpiar_Click);
            // 
            // Btnexportarexcel
            // 
            this.Btnexportarexcel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnexportarexcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexportarexcel.ForeColor = System.Drawing.Color.Black;
            this.Btnexportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnexportarexcel.Location = new System.Drawing.Point(371, 537);
            this.Btnexportarexcel.Name = "Btnexportarexcel";
            this.Btnexportarexcel.Size = new System.Drawing.Size(99, 38);
            this.Btnexportarexcel.TabIndex = 7;
            this.Btnexportarexcel.Text = "Guardar";
            this.Btnexportarexcel.UseVisualStyleBackColor = false;
            this.Btnexportarexcel.Click += new System.EventHandler(this.Btnexportarexcel_Click);
            // 
            // Btnexportar
            // 
            this.Btnexportar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnexportar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexportar.ForeColor = System.Drawing.Color.Black;
            this.Btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("Btnexportar.Image")));
            this.Btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnexportar.Location = new System.Drawing.Point(207, 250);
            this.Btnexportar.Name = "Btnexportar";
            this.Btnexportar.Size = new System.Drawing.Size(194, 46);
            this.Btnexportar.TabIndex = 6;
            this.Btnexportar.Text = "Cargar Informacion";
            this.Btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnexportar.UseVisualStyleBackColor = false;
            this.Btnexportar.Click += new System.EventHandler(this.Btnexportar_Click);
            // 
            // Dgexportar
            // 
            this.Dgexportar.AllowUserToDeleteRows = false;
            this.Dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgexportar.Location = new System.Drawing.Point(17, 313);
            this.Dgexportar.Name = "Dgexportar";
            this.Dgexportar.ReadOnly = true;
            this.Dgexportar.Size = new System.Drawing.Size(596, 150);
            this.Dgexportar.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lblestado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lblestado
            // 
            this.Lblestado.Name = "Lblestado";
            this.Lblestado.Size = new System.Drawing.Size(113, 17);
            this.Lblestado.Text = "Estado : No cargado";
            // 
            // Tmensaje
            // 
            this.Tmensaje.ToolTipTitle = "Advertencia";
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 666);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Tbcargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargar";
            this.Text = "Cargar";
            this.Load += new System.EventHandler(this.FrmCargar_Load);
            this.Tbcargar.ResumeLayout(false);
            this.Tbimportar.ResumeLayout(false);
            this.Tbimportar.PerformLayout();
            this.Gbtablas.ResumeLayout(false);
            this.Gbtablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgimportar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GbExportar.ResumeLayout(false);
            this.GbExportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgexportar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tbcargar;
        private System.Windows.Forms.TabPage Tbimportar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btnimportar;
        private System.Windows.Forms.DataGridView Dgimportar;
        private System.Windows.Forms.RadioButton Rbproductos;
        private System.Windows.Forms.RadioButton Rboperador;
        private System.Windows.Forms.RadioButton Rbmarcas;
        private System.Windows.Forms.RadioButton Rbproveedores;
        private System.Windows.Forms.RadioButton Rbfactura;
        private System.Windows.Forms.RadioButton Rbclientes;
        private System.Windows.Forms.RadioButton Rbcontrol;
        private System.Windows.Forms.RadioButton Rbcategorias;
        private System.Windows.Forms.GroupBox Gbtablas;
        private System.Windows.Forms.TextBox Txtruta;
        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.TextBox txthoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lblestado;
        private System.Windows.Forms.DataGridView Dgexportar;
        private System.Windows.Forms.Button Btnexportar;
        private System.Windows.Forms.Button Btnexlimpiar;
        private System.Windows.Forms.Button Btnexportarexcel;
        private System.Windows.Forms.RadioButton Rbdetallefactura;
        private System.Windows.Forms.ToolTip Tmensaje;
        private System.Windows.Forms.GroupBox GbExportar;
        private System.Windows.Forms.RadioButton Rbexdetalle;
        private System.Windows.Forms.RadioButton Rbexcliente;
        private System.Windows.Forms.RadioButton Rbexcontrol;
        private System.Windows.Forms.RadioButton Rbexfactura;
        private System.Windows.Forms.RadioButton Rbexcategorias;
        private System.Windows.Forms.RadioButton Rbexoperadores;
        private System.Windows.Forms.RadioButton Rbexmarcas;
        private System.Windows.Forms.RadioButton Rbexproductos;
        private System.Windows.Forms.RadioButton Rbexproveedores;
        private System.Windows.Forms.TextBox Txtguardar;
        private System.Windows.Forms.Label label1;
    }
}