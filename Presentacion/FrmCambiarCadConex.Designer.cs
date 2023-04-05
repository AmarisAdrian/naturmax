namespace Presentacion
{
    partial class FrmCambiarCadConex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarCadConex));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.Btnobtener = new System.Windows.Forms.Button();
            this.Txtcadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtservidor = new System.Windows.Forms.TextBox();
            this.TxtBaseDatos = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtcadenafinal = new System.Windows.Forms.TextBox();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgbasesDatos = new System.Windows.Forms.DataGridView();
            this.BtnCargarbases = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Dginstancias = new System.Windows.Forms.DataGridView();
            this.BtnInstancias = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Panelservidores = new System.Windows.Forms.Panel();
            this.CbSeguridad = new System.Windows.Forms.CheckBox();
            this.TpIp = new System.Windows.Forms.ToolTip(this.components);
            this.TpUserPass = new System.Windows.Forms.ToolTip(this.components);
            this.Paneldatos = new System.Windows.Forms.Panel();
            this.panelcadenafinal = new System.Windows.Forms.Panel();
            this.panelcadena = new System.Windows.Forms.Panel();
            this.MsHabilitarLogin = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DgbasesDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dginstancias)).BeginInit();
            this.Panelservidores.SuspendLayout();
            this.Paneldatos.SuspendLayout();
            this.panelcadenafinal.SuspendLayout();
            this.panelcadena.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(333, 67);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(91, 38);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click_1);
            // 
            // Btnobtener
            // 
            this.Btnobtener.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btnobtener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnobtener.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnobtener.ForeColor = System.Drawing.Color.White;
            this.Btnobtener.Location = new System.Drawing.Point(147, 231);
            this.Btnobtener.Name = "Btnobtener";
            this.Btnobtener.Size = new System.Drawing.Size(180, 38);
            this.Btnobtener.TabIndex = 2;
            this.Btnobtener.Text = "Cadena de Conexion";
            this.Btnobtener.UseVisualStyleBackColor = false;
            this.Btnobtener.Click += new System.EventHandler(this.Btnobtener_Click);
            // 
            // Txtcadena
            // 
            this.Txtcadena.Enabled = false;
            this.Txtcadena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcadena.Location = new System.Drawing.Point(148, 14);
            this.Txtcadena.Name = "Txtcadena";
            this.Txtcadena.Size = new System.Drawing.Size(774, 26);
            this.Txtcadena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "CADCONEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base de Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(61, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(76, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // Txtservidor
            // 
            this.Txtservidor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtservidor.Location = new System.Drawing.Point(147, 37);
            this.Txtservidor.Name = "Txtservidor";
            this.Txtservidor.Size = new System.Drawing.Size(277, 26);
            this.Txtservidor.TabIndex = 11;
            // 
            // TxtBaseDatos
            // 
            this.TxtBaseDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBaseDatos.Location = new System.Drawing.Point(147, 86);
            this.TxtBaseDatos.Name = "TxtBaseDatos";
            this.TxtBaseDatos.Size = new System.Drawing.Size(277, 26);
            this.TxtBaseDatos.TabIndex = 13;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(147, 135);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(277, 26);
            this.TxtUsuario.TabIndex = 14;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(147, 184);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(277, 26);
            this.TxtPassword.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(29, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cadena Final\r\n";
            // 
            // Txtcadenafinal
            // 
            this.Txtcadenafinal.Enabled = false;
            this.Txtcadenafinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcadenafinal.Location = new System.Drawing.Point(148, 19);
            this.Txtcadenafinal.Name = "Txtcadenafinal";
            this.Txtcadenafinal.Size = new System.Drawing.Size(774, 26);
            this.Txtcadenafinal.TabIndex = 16;
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAsignar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignar.ForeColor = System.Drawing.Color.White;
            this.BtnAsignar.Location = new System.Drawing.Point(333, 231);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(91, 38);
            this.BtnAsignar.TabIndex = 20;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = false;
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(147, 67);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(180, 38);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgbasesDatos
            // 
            this.DgbasesDatos.AllowUserToAddRows = false;
            this.DgbasesDatos.AllowUserToDeleteRows = false;
            this.DgbasesDatos.BackgroundColor = System.Drawing.Color.White;
            this.DgbasesDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgbasesDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgbasesDatos.GridColor = System.Drawing.Color.Blue;
            this.DgbasesDatos.Location = new System.Drawing.Point(252, 37);
            this.DgbasesDatos.Name = "DgbasesDatos";
            this.DgbasesDatos.ReadOnly = true;
            this.DgbasesDatos.RowHeadersVisible = false;
            this.DgbasesDatos.Size = new System.Drawing.Size(137, 163);
            this.DgbasesDatos.TabIndex = 22;
            this.DgbasesDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbasesDatos_CellDoubleClick);
            // 
            // BtnCargarbases
            // 
            this.BtnCargarbases.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCargarbases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCargarbases.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarbases.ForeColor = System.Drawing.Color.White;
            this.BtnCargarbases.Location = new System.Drawing.Point(252, 226);
            this.BtnCargarbases.Name = "BtnCargarbases";
            this.BtnCargarbases.Size = new System.Drawing.Size(139, 43);
            this.BtnCargarbases.TabIndex = 23;
            this.BtnCargarbases.Text = "Base de Datos";
            this.BtnCargarbases.UseVisualStyleBackColor = false;
            this.BtnCargarbases.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(578, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bases de Datos";
            // 
            // Dginstancias
            // 
            this.Dginstancias.AllowUserToAddRows = false;
            this.Dginstancias.AllowUserToDeleteRows = false;
            this.Dginstancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dginstancias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dginstancias.BackgroundColor = System.Drawing.Color.White;
            this.Dginstancias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dginstancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dginstancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dginstancias.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dginstancias.GridColor = System.Drawing.Color.Blue;
            this.Dginstancias.Location = new System.Drawing.Point(23, 37);
            this.Dginstancias.Name = "Dginstancias";
            this.Dginstancias.ReadOnly = true;
            this.Dginstancias.RowHeadersVisible = false;
            this.Dginstancias.Size = new System.Drawing.Size(223, 163);
            this.Dginstancias.TabIndex = 25;
            this.Dginstancias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dginstancias_CellContentClick);
            // 
            // BtnInstancias
            // 
            this.BtnInstancias.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInstancias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInstancias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstancias.ForeColor = System.Drawing.Color.White;
            this.BtnInstancias.Location = new System.Drawing.Point(23, 226);
            this.BtnInstancias.Name = "BtnInstancias";
            this.BtnInstancias.Size = new System.Drawing.Size(223, 43);
            this.BtnInstancias.TabIndex = 26;
            this.BtnInstancias.Text = "Servidores";
            this.BtnInstancias.UseVisualStyleBackColor = false;
            this.BtnInstancias.Click += new System.EventHandler(this.BtnInstancias_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(728, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Instancias Server";
            // 
            // Panelservidores
            // 
            this.Panelservidores.BackColor = System.Drawing.Color.Transparent;
            this.Panelservidores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panelservidores.Controls.Add(this.Dginstancias);
            this.Panelservidores.Controls.Add(this.DgbasesDatos);
            this.Panelservidores.Controls.Add(this.BtnInstancias);
            this.Panelservidores.Controls.Add(this.BtnCargarbases);
            this.Panelservidores.Location = new System.Drawing.Point(541, 87);
            this.Panelservidores.Name = "Panelservidores";
            this.Panelservidores.Size = new System.Drawing.Size(416, 301);
            this.Panelservidores.TabIndex = 28;
            // 
            // CbSeguridad
            // 
            this.CbSeguridad.AutoSize = true;
            this.CbSeguridad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSeguridad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CbSeguridad.Location = new System.Drawing.Point(430, 143);
            this.CbSeguridad.Name = "CbSeguridad";
            this.CbSeguridad.Size = new System.Drawing.Size(74, 20);
            this.CbSeguridad.TabIndex = 29;
            this.CbSeguridad.Text = "Activar";
            this.TpUserPass.SetToolTip(this.CbSeguridad, "En caso de que Sql tenga (\"Sql security\")presionar click para activar (\"User ID\"," +
        "\"Password\")");
            this.CbSeguridad.UseVisualStyleBackColor = true;
            this.CbSeguridad.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Paneldatos
            // 
            this.Paneldatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paneldatos.Controls.Add(this.Txtservidor);
            this.Paneldatos.Controls.Add(this.CbSeguridad);
            this.Paneldatos.Controls.Add(this.Btnobtener);
            this.Paneldatos.Controls.Add(this.label2);
            this.Paneldatos.Controls.Add(this.label4);
            this.Paneldatos.Controls.Add(this.label5);
            this.Paneldatos.Controls.Add(this.label6);
            this.Paneldatos.Controls.Add(this.BtnAsignar);
            this.Paneldatos.Controls.Add(this.TxtBaseDatos);
            this.Paneldatos.Controls.Add(this.TxtUsuario);
            this.Paneldatos.Controls.Add(this.TxtPassword);
            this.Paneldatos.Location = new System.Drawing.Point(13, 87);
            this.Paneldatos.Name = "Paneldatos";
            this.Paneldatos.Size = new System.Drawing.Size(522, 301);
            this.Paneldatos.TabIndex = 30;
            // 
            // panelcadenafinal
            // 
            this.panelcadenafinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcadenafinal.Controls.Add(this.Txtcadenafinal);
            this.panelcadenafinal.Controls.Add(this.BtnVolver);
            this.panelcadenafinal.Controls.Add(this.label7);
            this.panelcadenafinal.Controls.Add(this.BtnGuardar);
            this.panelcadenafinal.Location = new System.Drawing.Point(13, 394);
            this.panelcadenafinal.Name = "panelcadenafinal";
            this.panelcadenafinal.Size = new System.Drawing.Size(944, 117);
            this.panelcadenafinal.TabIndex = 31;
            // 
            // panelcadena
            // 
            this.panelcadena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcadena.Controls.Add(this.Txtcadena);
            this.panelcadena.Controls.Add(this.label1);
            this.panelcadena.Location = new System.Drawing.Point(13, 27);
            this.panelcadena.Name = "panelcadena";
            this.panelcadena.Size = new System.Drawing.Size(944, 57);
            this.panelcadena.TabIndex = 32;
            // 
            // MsHabilitarLogin
            // 
            this.MsHabilitarLogin.Location = new System.Drawing.Point(0, 0);
            this.MsHabilitarLogin.Name = "MsHabilitarLogin";
            this.MsHabilitarLogin.Size = new System.Drawing.Size(969, 24);
            this.MsHabilitarLogin.TabIndex = 33;
            this.MsHabilitarLogin.Text = "menuStrip1";
            // 
            // FrmCambiarCadConex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 523);
            this.Controls.Add(this.panelcadena);
            this.Controls.Add(this.panelcadenafinal);
            this.Controls.Add(this.Paneldatos);
            this.Controls.Add(this.Panelservidores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MsHabilitarLogin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsHabilitarLogin;
            this.MaximizeBox = false;
            this.Name = "FrmCambiarCadConex";
            this.Text = "Cambiar Cadena de Conexion";
            this.Load += new System.EventHandler(this.FrmCambiarCadConex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbasesDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dginstancias)).EndInit();
            this.Panelservidores.ResumeLayout(false);
            this.Paneldatos.ResumeLayout(false);
            this.Paneldatos.PerformLayout();
            this.panelcadenafinal.ResumeLayout(false);
            this.panelcadenafinal.PerformLayout();
            this.panelcadena.ResumeLayout(false);
            this.panelcadena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button Btnobtener;
        private System.Windows.Forms.TextBox Txtcadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtservidor;
        private System.Windows.Forms.TextBox TxtBaseDatos;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txtcadenafinal;
        private System.Windows.Forms.Button BtnAsignar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgbasesDatos;
        private System.Windows.Forms.Button BtnCargarbases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dginstancias;
        private System.Windows.Forms.Button BtnInstancias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel Panelservidores;
        private System.Windows.Forms.CheckBox CbSeguridad;
        private System.Windows.Forms.ToolTip TpUserPass;
        private System.Windows.Forms.ToolTip TpIp;
        private System.Windows.Forms.Panel Paneldatos;
        private System.Windows.Forms.Panel panelcadenafinal;
        private System.Windows.Forms.Panel panelcadena;
        private System.Windows.Forms.MenuStrip MsHabilitarLogin;
    }
}