namespace Presentacion
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.GbMarca = new System.Windows.Forms.GroupBox();
            this.btnactualizarmarca = new System.Windows.Forms.Button();
            this.Btnconsultarmarca = new System.Windows.Forms.Button();
            this.Btneliminarmarca = new System.Windows.Forms.Button();
            this.Btninsertarmarca = new System.Windows.Forms.Button();
            this.Txtnombremarca = new System.Windows.Forms.TextBox();
            this.Txtidmarca = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.GbProductos = new System.Windows.Forms.GroupBox();
            this.Txtprecioiva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RcDescripcion = new System.Windows.Forms.RichTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.Cmbmarca = new System.Windows.Forms.ComboBox();
            this.CmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.BtnActualizarProducto = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnConsultarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.Txtstock = new System.Windows.Forms.TextBox();
            this.BtnInsertarProducto = new System.Windows.Forms.Button();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtReferenciaProducto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GbCategoriaProducto = new System.Windows.Forms.GroupBox();
            this.BtnActualizarCategoria = new System.Windows.Forms.Button();
            this.BtnConsultarCategoria = new System.Windows.Forms.Button();
            this.BtnEliminarCategoria = new System.Windows.Forms.Button();
            this.BtnInsertarCategoria = new System.Windows.Forms.Button();
            this.TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.TxtReferenciaCategoria = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Msproductos = new System.Windows.Forms.MenuStrip();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgproducto = new System.Windows.Forms.DataGridView();
            this.GbMarca.SuspendLayout();
            this.GbProductos.SuspendLayout();
            this.GbCategoriaProducto.SuspendLayout();
            this.Msproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GbMarca
            // 
            this.GbMarca.BackColor = System.Drawing.Color.Transparent;
            this.GbMarca.Controls.Add(this.btnactualizarmarca);
            this.GbMarca.Controls.Add(this.Btnconsultarmarca);
            this.GbMarca.Controls.Add(this.Btneliminarmarca);
            this.GbMarca.Controls.Add(this.Btninsertarmarca);
            this.GbMarca.Controls.Add(this.Txtnombremarca);
            this.GbMarca.Controls.Add(this.Txtidmarca);
            this.GbMarca.Controls.Add(this.label33);
            this.GbMarca.Controls.Add(this.label34);
            this.GbMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMarca.Location = new System.Drawing.Point(12, 31);
            this.GbMarca.Name = "GbMarca";
            this.GbMarca.Size = new System.Drawing.Size(571, 111);
            this.GbMarca.TabIndex = 30;
            this.GbMarca.TabStop = false;
            this.GbMarca.Text = "Marca";
            // 
            // btnactualizarmarca
            // 
            this.btnactualizarmarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnactualizarmarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizarmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarmarca.ForeColor = System.Drawing.Color.White;
            this.btnactualizarmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizarmarca.Location = new System.Drawing.Point(457, 65);
            this.btnactualizarmarca.Name = "btnactualizarmarca";
            this.btnactualizarmarca.Size = new System.Drawing.Size(87, 29);
            this.btnactualizarmarca.TabIndex = 6;
            this.btnactualizarmarca.Text = "Editar";
            this.btnactualizarmarca.UseVisualStyleBackColor = false;
            this.btnactualizarmarca.Click += new System.EventHandler(this.btnactualizarmarca_Click_1);
            // 
            // Btnconsultarmarca
            // 
            this.Btnconsultarmarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnconsultarmarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnconsultarmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconsultarmarca.ForeColor = System.Drawing.Color.White;
            this.Btnconsultarmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnconsultarmarca.Location = new System.Drawing.Point(458, 34);
            this.Btnconsultarmarca.Name = "Btnconsultarmarca";
            this.Btnconsultarmarca.Size = new System.Drawing.Size(86, 26);
            this.Btnconsultarmarca.TabIndex = 4;
            this.Btnconsultarmarca.Text = "Buscar";
            this.Btnconsultarmarca.UseVisualStyleBackColor = false;
            this.Btnconsultarmarca.Click += new System.EventHandler(this.Btnconsultarmarca_Click_1);
            // 
            // Btneliminarmarca
            // 
            this.Btneliminarmarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btneliminarmarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btneliminarmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneliminarmarca.ForeColor = System.Drawing.Color.White;
            this.Btneliminarmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btneliminarmarca.Location = new System.Drawing.Point(376, 65);
            this.Btneliminarmarca.Name = "Btneliminarmarca";
            this.Btneliminarmarca.Size = new System.Drawing.Size(74, 29);
            this.Btneliminarmarca.TabIndex = 5;
            this.Btneliminarmarca.Text = "Eliminar";
            this.Btneliminarmarca.UseVisualStyleBackColor = false;
            this.Btneliminarmarca.Click += new System.EventHandler(this.Btneliminarmarca_Click_1);
            // 
            // Btninsertarmarca
            // 
            this.Btninsertarmarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btninsertarmarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btninsertarmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btninsertarmarca.ForeColor = System.Drawing.Color.White;
            this.Btninsertarmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btninsertarmarca.Location = new System.Drawing.Point(376, 34);
            this.Btninsertarmarca.Name = "Btninsertarmarca";
            this.Btninsertarmarca.Size = new System.Drawing.Size(74, 26);
            this.Btninsertarmarca.TabIndex = 3;
            this.Btninsertarmarca.Text = "Guardar";
            this.Btninsertarmarca.UseVisualStyleBackColor = false;
            this.Btninsertarmarca.Click += new System.EventHandler(this.Btninsertarmarca_Click_1);
            // 
            // Txtnombremarca
            // 
            this.Txtnombremarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnombremarca.Location = new System.Drawing.Point(168, 68);
            this.Txtnombremarca.Name = "Txtnombremarca";
            this.Txtnombremarca.Size = new System.Drawing.Size(158, 26);
            this.Txtnombremarca.TabIndex = 2;
            // 
            // Txtidmarca
            // 
            this.Txtidmarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidmarca.Location = new System.Drawing.Point(168, 34);
            this.Txtidmarca.Name = "Txtidmarca";
            this.Txtidmarca.Size = new System.Drawing.Size(158, 26);
            this.Txtidmarca.TabIndex = 1;
            this.Txtidmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtidmarca_KeyPress_1);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(102, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 17);
            this.label33.TabIndex = 1;
            this.label33.Text = "NOMBRE";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(100, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 17);
            this.label34.TabIndex = 0;
            this.label34.Text = "IDMARCA";
            // 
            // GbProductos
            // 
            this.GbProductos.BackColor = System.Drawing.Color.Transparent;
            this.GbProductos.Controls.Add(this.Txtprecioiva);
            this.GbProductos.Controls.Add(this.label1);
            this.GbProductos.Controls.Add(this.RcDescripcion);
            this.GbProductos.Controls.Add(this.label35);
            this.GbProductos.Controls.Add(this.Cmbmarca);
            this.GbProductos.Controls.Add(this.CmbCategoriaProducto);
            this.GbProductos.Controls.Add(this.CmbProveedor);
            this.GbProductos.Controls.Add(this.BtnActualizarProducto);
            this.GbProductos.Controls.Add(this.TxtPrecio);
            this.GbProductos.Controls.Add(this.BtnConsultarProducto);
            this.GbProductos.Controls.Add(this.BtnEliminarProducto);
            this.GbProductos.Controls.Add(this.Txtstock);
            this.GbProductos.Controls.Add(this.BtnInsertarProducto);
            this.GbProductos.Controls.Add(this.TxtCategoria);
            this.GbProductos.Controls.Add(this.TxtReferenciaProducto);
            this.GbProductos.Controls.Add(this.label19);
            this.GbProductos.Controls.Add(this.label18);
            this.GbProductos.Controls.Add(this.label17);
            this.GbProductos.Controls.Add(this.label16);
            this.GbProductos.Controls.Add(this.label15);
            this.GbProductos.Controls.Add(this.label14);
            this.GbProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProductos.Location = new System.Drawing.Point(12, 306);
            this.GbProductos.Name = "GbProductos";
            this.GbProductos.Size = new System.Drawing.Size(571, 352);
            this.GbProductos.TabIndex = 31;
            this.GbProductos.TabStop = false;
            this.GbProductos.Text = "Informacion del producto";
            // 
            // Txtprecioiva
            // 
            this.Txtprecioiva.Enabled = false;
            this.Txtprecioiva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtprecioiva.Location = new System.Drawing.Point(168, 315);
            this.Txtprecioiva.Name = "Txtprecioiva";
            this.Txtprecioiva.Size = new System.Drawing.Size(158, 26);
            this.Txtprecioiva.TabIndex = 20;
            this.Txtprecioiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecioiva_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "PRECIO CON IVA\r\n\r\n";
            // 
            // RcDescripcion
            // 
            this.RcDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RcDescripcion.Location = new System.Drawing.Point(168, 182);
            this.RcDescripcion.Name = "RcDescripcion";
            this.RcDescripcion.Size = new System.Drawing.Size(158, 55);
            this.RcDescripcion.TabIndex = 17;
            this.RcDescripcion.Text = "";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(112, 146);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(52, 17);
            this.label35.TabIndex = 28;
            this.label35.Text = "MARCA";
            // 
            // Cmbmarca
            // 
            this.Cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbmarca.FormattingEnabled = true;
            this.Cmbmarca.Location = new System.Drawing.Point(168, 146);
            this.Cmbmarca.Name = "Cmbmarca";
            this.Cmbmarca.Size = new System.Drawing.Size(158, 28);
            this.Cmbmarca.TabIndex = 16;
            // 
            // CmbCategoriaProducto
            // 
            this.CmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoriaProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoriaProducto.FormattingEnabled = true;
            this.CmbCategoriaProducto.Location = new System.Drawing.Point(168, 115);
            this.CmbCategoriaProducto.Name = "CmbCategoriaProducto";
            this.CmbCategoriaProducto.Size = new System.Drawing.Size(158, 28);
            this.CmbCategoriaProducto.TabIndex = 15;
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(168, 83);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(158, 28);
            this.CmbProveedor.TabIndex = 14;
            // 
            // BtnActualizarProducto
            // 
            this.BtnActualizarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizarProducto.Image")));
            this.BtnActualizarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizarProducto.Location = new System.Drawing.Point(455, 240);
            this.BtnActualizarProducto.Name = "BtnActualizarProducto";
            this.BtnActualizarProducto.Size = new System.Drawing.Size(105, 40);
            this.BtnActualizarProducto.TabIndex = 24;
            this.BtnActualizarProducto.Text = "Editar";
            this.BtnActualizarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizarProducto.UseVisualStyleBackColor = false;
            this.BtnActualizarProducto.Click += new System.EventHandler(this.BtnActualizarProducto_Click_1);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(168, 285);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(158, 26);
            this.TxtPrecio.TabIndex = 19;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged_1);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // BtnConsultarProducto
            // 
            this.BtnConsultarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarProducto.Image")));
            this.BtnConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarProducto.Location = new System.Drawing.Point(456, 139);
            this.BtnConsultarProducto.Name = "BtnConsultarProducto";
            this.BtnConsultarProducto.Size = new System.Drawing.Size(104, 41);
            this.BtnConsultarProducto.TabIndex = 22;
            this.BtnConsultarProducto.Text = "Buscar";
            this.BtnConsultarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarProducto.UseVisualStyleBackColor = false;
            this.BtnConsultarProducto.Click += new System.EventHandler(this.BtnConsultarProducto_Click_1);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarProducto.Image")));
            this.BtnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(455, 186);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(105, 48);
            this.BtnEliminarProducto.TabIndex = 23;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click_1);
            // 
            // Txtstock
            // 
            this.Txtstock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtstock.Location = new System.Drawing.Point(168, 252);
            this.Txtstock.Name = "Txtstock";
            this.Txtstock.Size = new System.Drawing.Size(158, 26);
            this.Txtstock.TabIndex = 18;
            this.Txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtstock_KeyPress);
            // 
            // BtnInsertarProducto
            // 
            this.BtnInsertarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnInsertarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInsertarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsertarProducto.Image")));
            this.BtnInsertarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertarProducto.Location = new System.Drawing.Point(456, 83);
            this.BtnInsertarProducto.Name = "BtnInsertarProducto";
            this.BtnInsertarProducto.Size = new System.Drawing.Size(105, 50);
            this.BtnInsertarProducto.TabIndex = 21;
            this.BtnInsertarProducto.Text = "Guardar";
            this.BtnInsertarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsertarProducto.UseVisualStyleBackColor = false;
            this.BtnInsertarProducto.Click += new System.EventHandler(this.BtnInsertarProducto_Click_1);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(168, 116);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(142, 26);
            this.TxtCategoria.TabIndex = 11;
            // 
            // TxtReferenciaProducto
            // 
            this.TxtReferenciaProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferenciaProducto.Location = new System.Drawing.Point(168, 50);
            this.TxtReferenciaProducto.Name = "TxtReferenciaProducto";
            this.TxtReferenciaProducto.Size = new System.Drawing.Size(158, 26);
            this.TxtReferenciaProducto.TabIndex = 13;
            this.TxtReferenciaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReferenciaProducto_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(52, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "PRECIO UNITARIO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(117, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "STOCK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(76, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "DESCRIPCION";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "CATEGORIA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "PROVEEDOR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "REFERENCIA PRODUCTO";
            // 
            // GbCategoriaProducto
            // 
            this.GbCategoriaProducto.BackColor = System.Drawing.Color.Transparent;
            this.GbCategoriaProducto.Controls.Add(this.BtnActualizarCategoria);
            this.GbCategoriaProducto.Controls.Add(this.BtnConsultarCategoria);
            this.GbCategoriaProducto.Controls.Add(this.BtnEliminarCategoria);
            this.GbCategoriaProducto.Controls.Add(this.BtnInsertarCategoria);
            this.GbCategoriaProducto.Controls.Add(this.TxtNombreCategoria);
            this.GbCategoriaProducto.Controls.Add(this.TxtReferenciaCategoria);
            this.GbCategoriaProducto.Controls.Add(this.label13);
            this.GbCategoriaProducto.Controls.Add(this.label12);
            this.GbCategoriaProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCategoriaProducto.Location = new System.Drawing.Point(13, 148);
            this.GbCategoriaProducto.Name = "GbCategoriaProducto";
            this.GbCategoriaProducto.Size = new System.Drawing.Size(571, 152);
            this.GbCategoriaProducto.TabIndex = 29;
            this.GbCategoriaProducto.TabStop = false;
            this.GbCategoriaProducto.Text = "Categoria de Producto";
            // 
            // BtnActualizarCategoria
            // 
            this.BtnActualizarCategoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnActualizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarCategoria.Location = new System.Drawing.Point(457, 92);
            this.BtnActualizarCategoria.Name = "BtnActualizarCategoria";
            this.BtnActualizarCategoria.Size = new System.Drawing.Size(87, 32);
            this.BtnActualizarCategoria.TabIndex = 12;
            this.BtnActualizarCategoria.Text = "Editar";
            this.BtnActualizarCategoria.UseVisualStyleBackColor = false;
            this.BtnActualizarCategoria.Click += new System.EventHandler(this.BtnActualizarCategoria_Click_1);
            // 
            // BtnConsultarCategoria
            // 
            this.BtnConsultarCategoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnConsultarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarCategoria.Location = new System.Drawing.Point(457, 50);
            this.BtnConsultarCategoria.Name = "BtnConsultarCategoria";
            this.BtnConsultarCategoria.Size = new System.Drawing.Size(87, 36);
            this.BtnConsultarCategoria.TabIndex = 10;
            this.BtnConsultarCategoria.Text = "Buscar";
            this.BtnConsultarCategoria.UseVisualStyleBackColor = false;
            this.BtnConsultarCategoria.Click += new System.EventHandler(this.BtnConsultarCategoria_Click_1);
            // 
            // BtnEliminarCategoria
            // 
            this.BtnEliminarCategoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminarCategoria.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarCategoria.Location = new System.Drawing.Point(375, 92);
            this.BtnEliminarCategoria.Name = "BtnEliminarCategoria";
            this.BtnEliminarCategoria.Size = new System.Drawing.Size(76, 32);
            this.BtnEliminarCategoria.TabIndex = 11;
            this.BtnEliminarCategoria.Text = "Eliminar";
            this.BtnEliminarCategoria.UseVisualStyleBackColor = false;
            this.BtnEliminarCategoria.Click += new System.EventHandler(this.BtnEliminarCategoria_Click_1);
            // 
            // BtnInsertarCategoria
            // 
            this.BtnInsertarCategoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnInsertarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInsertarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnInsertarCategoria.Location = new System.Drawing.Point(375, 50);
            this.BtnInsertarCategoria.Name = "BtnInsertarCategoria";
            this.BtnInsertarCategoria.Size = new System.Drawing.Size(75, 36);
            this.BtnInsertarCategoria.TabIndex = 9;
            this.BtnInsertarCategoria.Text = "Guardar";
            this.BtnInsertarCategoria.UseVisualStyleBackColor = false;
            this.BtnInsertarCategoria.Click += new System.EventHandler(this.BtnInsertarCategoria_Click_1);
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCategoria.Location = new System.Drawing.Point(168, 93);
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.Size = new System.Drawing.Size(158, 26);
            this.TxtNombreCategoria.TabIndex = 8;
            // 
            // TxtReferenciaCategoria
            // 
            this.TxtReferenciaCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferenciaCategoria.Location = new System.Drawing.Point(168, 55);
            this.TxtReferenciaCategoria.Name = "TxtReferenciaCategoria";
            this.TxtReferenciaCategoria.Size = new System.Drawing.Size(158, 26);
            this.TxtReferenciaCategoria.TabIndex = 7;
            this.TxtReferenciaCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReferenciaCategoria_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(102, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "NOMBRE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "REFERENCIA CATEGORIA";
            // 
            // Msproductos
            // 
            this.Msproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Msproductos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msproductos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Msproductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventana});
            this.Msproductos.Location = new System.Drawing.Point(0, 0);
            this.Msproductos.Name = "Msproductos";
            this.Msproductos.Size = new System.Drawing.Size(596, 28);
            this.Msproductos.TabIndex = 25;
            this.Msproductos.Text = "Msproductos";
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recargarToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.Ventana.ForeColor = System.Drawing.Color.White;
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(75, 24);
            this.Ventana.Text = "Ventana";
            // 
            // recargarToolStripMenuItem
            // 
            this.recargarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recargarToolStripMenuItem.Image")));
            this.recargarToolStripMenuItem.Name = "recargarToolStripMenuItem";
            this.recargarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.recargarToolStripMenuItem.Text = "&Recargar";
            this.recargarToolStripMenuItem.Click += new System.EventHandler(this.recargarToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverToolStripMenuItem.Image")));
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.volverToolStripMenuItem.Text = "&Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // Dgproducto
            // 
            this.Dgproducto.AllowUserToDeleteRows = false;
            this.Dgproducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Dgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgproducto.Location = new System.Drawing.Point(43, 734);
            this.Dgproducto.Name = "Dgproducto";
            this.Dgproducto.ReadOnly = true;
            this.Dgproducto.RowHeadersVisible = false;
            this.Dgproducto.Size = new System.Drawing.Size(507, 148);
            this.Dgproducto.TabIndex = 33;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 667);
            this.Controls.Add(this.Dgproducto);
            this.Controls.Add(this.GbMarca);
            this.Controls.Add(this.GbProductos);
            this.Controls.Add(this.GbCategoriaProducto);
            this.Controls.Add(this.Msproductos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Msproductos;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.GbMarca.ResumeLayout(false);
            this.GbMarca.PerformLayout();
            this.GbProductos.ResumeLayout(false);
            this.GbProductos.PerformLayout();
            this.GbCategoriaProducto.ResumeLayout(false);
            this.GbCategoriaProducto.PerformLayout();
            this.Msproductos.ResumeLayout(false);
            this.Msproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMarca;
        private System.Windows.Forms.Button btnactualizarmarca;
        private System.Windows.Forms.Button Btnconsultarmarca;
        private System.Windows.Forms.Button Btneliminarmarca;
        private System.Windows.Forms.Button Btninsertarmarca;
        private System.Windows.Forms.TextBox Txtnombremarca;
        private System.Windows.Forms.TextBox Txtidmarca;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox GbProductos;
        private System.Windows.Forms.TextBox Txtprecioiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RcDescripcion;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox Cmbmarca;
        private System.Windows.Forms.ComboBox CmbCategoriaProducto;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.Button BtnActualizarProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnConsultarProducto;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.TextBox Txtstock;
        private System.Windows.Forms.Button BtnInsertarProducto;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtReferenciaProducto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox GbCategoriaProducto;
        private System.Windows.Forms.Button BtnActualizarCategoria;
        private System.Windows.Forms.Button BtnConsultarCategoria;
        private System.Windows.Forms.Button BtnEliminarCategoria;
        private System.Windows.Forms.Button BtnInsertarCategoria;
        private System.Windows.Forms.TextBox TxtNombreCategoria;
        private System.Windows.Forms.TextBox TxtReferenciaCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip Msproductos;
        private System.Windows.Forms.ToolStripMenuItem Ventana;
        private System.Windows.Forms.ToolStripMenuItem recargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.DataGridView Dgproducto;

    }
}