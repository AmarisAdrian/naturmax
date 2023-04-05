namespace Presentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Gbclientes = new System.Windows.Forms.GroupBox();
            this.Txtdocumento = new System.Windows.Forms.TextBox();
            this.BtnActualizarCliente = new System.Windows.Forms.Button();
            this.Txtcelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.BtnBorrarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtdireccion = new System.Windows.Forms.TextBox();
            this.BtnGuardarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtapellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtnombres = new System.Windows.Forms.TextBox();
            this.Gbclientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(403, 393);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(91, 27);
            this.Btnsalir.TabIndex = 17;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Gbclientes
            // 
            this.Gbclientes.BackColor = System.Drawing.Color.Transparent;
            this.Gbclientes.Controls.Add(this.Txtdocumento);
            this.Gbclientes.Controls.Add(this.BtnActualizarCliente);
            this.Gbclientes.Controls.Add(this.Txtcelular);
            this.Gbclientes.Controls.Add(this.label2);
            this.Gbclientes.Controls.Add(this.BtnConsultar);
            this.Gbclientes.Controls.Add(this.Txttelefono);
            this.Gbclientes.Controls.Add(this.BtnBorrarCliente);
            this.Gbclientes.Controls.Add(this.label3);
            this.Gbclientes.Controls.Add(this.label1);
            this.Gbclientes.Controls.Add(this.Txtdireccion);
            this.Gbclientes.Controls.Add(this.BtnGuardarUsuario);
            this.Gbclientes.Controls.Add(this.label4);
            this.Gbclientes.Controls.Add(this.Txtapellidos);
            this.Gbclientes.Controls.Add(this.label6);
            this.Gbclientes.Controls.Add(this.label5);
            this.Gbclientes.Controls.Add(this.Txtnombres);
            this.Gbclientes.Location = new System.Drawing.Point(12, 27);
            this.Gbclientes.Name = "Gbclientes";
            this.Gbclientes.Size = new System.Drawing.Size(482, 346);
            this.Gbclientes.TabIndex = 18;
            this.Gbclientes.TabStop = false;
            this.Gbclientes.Text = "Datos Clientes";
            // 
            // Txtdocumento
            // 
            this.Txtdocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdocumento.Location = new System.Drawing.Point(212, 46);
            this.Txtdocumento.Name = "Txtdocumento";
            this.Txtdocumento.Size = new System.Drawing.Size(163, 27);
            this.Txtdocumento.TabIndex = 0;
            this.Txtdocumento.TextChanged += new System.EventHandler(this.Txtdocumento_TextChanged);
            this.Txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdocumento_KeyPress);
            // 
            // BtnActualizarCliente
            // 
            this.BtnActualizarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizarCliente.Image")));
            this.BtnActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizarCliente.Location = new System.Drawing.Point(350, 274);
            this.BtnActualizarCliente.Name = "BtnActualizarCliente";
            this.BtnActualizarCliente.Size = new System.Drawing.Size(91, 47);
            this.BtnActualizarCliente.TabIndex = 15;
            this.BtnActualizarCliente.Text = "Editar";
            this.BtnActualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizarCliente.UseVisualStyleBackColor = false;
            this.BtnActualizarCliente.Click += new System.EventHandler(this.BtnActualizarCliente_Click);
            // 
            // Txtcelular
            // 
            this.Txtcelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcelular.Location = new System.Drawing.Point(212, 211);
            this.Txtcelular.Name = "Txtcelular";
            this.Txtcelular.Size = new System.Drawing.Size(163, 27);
            this.Txtcelular.TabIndex = 5;
            this.Txtcelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcelular_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRES ";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Location = new System.Drawing.Point(243, 274);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(101, 47);
            this.BtnConsultar.TabIndex = 14;
            this.BtnConsultar.Text = "Buscar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Txttelefono
            // 
            this.Txttelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttelefono.Location = new System.Drawing.Point(212, 178);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.Size = new System.Drawing.Size(163, 27);
            this.Txttelefono.TabIndex = 4;
            this.Txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // BtnBorrarCliente
            // 
            this.BtnBorrarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrarCliente.Image")));
            this.BtnBorrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarCliente.Location = new System.Drawing.Point(135, 274);
            this.BtnBorrarCliente.Name = "BtnBorrarCliente";
            this.BtnBorrarCliente.Size = new System.Drawing.Size(102, 47);
            this.BtnBorrarCliente.TabIndex = 13;
            this.BtnBorrarCliente.Text = "Borrar";
            this.BtnBorrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarCliente.UseVisualStyleBackColor = false;
            this.BtnBorrarCliente.Click += new System.EventHandler(this.BtnBorrarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(68, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "APELLIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "NO DOCUMENTO";
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdireccion.Location = new System.Drawing.Point(212, 145);
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.Size = new System.Drawing.Size(163, 27);
            this.Txtdireccion.TabIndex = 3;
            // 
            // BtnGuardarUsuario
            // 
            this.BtnGuardarUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGuardarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarUsuario.Image")));
            this.BtnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarUsuario.Location = new System.Drawing.Point(27, 274);
            this.BtnGuardarUsuario.Name = "BtnGuardarUsuario";
            this.BtnGuardarUsuario.Size = new System.Drawing.Size(102, 47);
            this.BtnGuardarUsuario.TabIndex = 12;
            this.BtnGuardarUsuario.Text = "Guardar";
            this.BtnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarUsuario.UseVisualStyleBackColor = false;
            this.BtnGuardarUsuario.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(68, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "DIRECCION";
            // 
            // Txtapellidos
            // 
            this.Txtapellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtapellidos.Location = new System.Drawing.Point(212, 112);
            this.Txtapellidos.Name = "Txtapellidos";
            this.Txtapellidos.Size = new System.Drawing.Size(163, 27);
            this.Txtapellidos.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(68, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "CELULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(68, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "TELEFONO";
            // 
            // Txtnombres
            // 
            this.Txtnombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnombres.Location = new System.Drawing.Point(212, 79);
            this.Txtnombres.Name = "Txtnombres";
            this.Txtnombres.Size = new System.Drawing.Size(163, 27);
            this.Txtnombres.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 445);
            this.Controls.Add(this.Gbclientes);
            this.Controls.Add(this.Btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Gbclientes.ResumeLayout(false);
            this.Gbclientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.GroupBox Gbclientes;
        private System.Windows.Forms.TextBox Txtdocumento;
        private System.Windows.Forms.Button BtnActualizarCliente;
        private System.Windows.Forms.TextBox Txtcelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.Button BtnBorrarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtdireccion;
        private System.Windows.Forms.Button BtnGuardarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtapellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtnombres;
    }
}