namespace Presentacion
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.Btncancelar = new System.Windows.Forms.Button();
            this.MenuLogin = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haOlvidadoSuContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contacteConElAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeLaConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadConex = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbltimer = new System.Windows.Forms.Label();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btncancelar
            // 
            this.Btncancelar.BackColor = System.Drawing.Color.White;
            this.Btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncancelar.ForeColor = System.Drawing.Color.Black;
            this.Btncancelar.Location = new System.Drawing.Point(245, 141);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(104, 40);
            this.Btncancelar.TabIndex = 2;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btncancelar.UseVisualStyleBackColor = false;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // MenuLogin
            // 
            this.MenuLogin.BackColor = System.Drawing.Color.Transparent;
            this.MenuLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.CadConex});
            this.MenuLogin.Location = new System.Drawing.Point(0, 0);
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Padding = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.MenuLogin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuLogin.Size = new System.Drawing.Size(374, 24);
            this.MenuLogin.TabIndex = 10;
            this.MenuLogin.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haOlvidadoSuContraseñaToolStripMenuItem,
            this.contacteConElAdministradorToolStripMenuItem,
            this.estadoDeLaConexionToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // haOlvidadoSuContraseñaToolStripMenuItem
            // 
            this.haOlvidadoSuContraseñaToolStripMenuItem.Name = "haOlvidadoSuContraseñaToolStripMenuItem";
            this.haOlvidadoSuContraseñaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.haOlvidadoSuContraseñaToolStripMenuItem.Text = "¿Ha olvidado su contraseña?";
            this.haOlvidadoSuContraseñaToolStripMenuItem.Click += new System.EventHandler(this.haOlvidadoSuContraseñaToolStripMenuItem_Click);
            // 
            // contacteConElAdministradorToolStripMenuItem
            // 
            this.contacteConElAdministradorToolStripMenuItem.Name = "contacteConElAdministradorToolStripMenuItem";
            this.contacteConElAdministradorToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.contacteConElAdministradorToolStripMenuItem.Text = "Contacte con el tecnico";
            this.contacteConElAdministradorToolStripMenuItem.Click += new System.EventHandler(this.contacteConElAdministradorToolStripMenuItem_Click);
            // 
            // estadoDeLaConexionToolStripMenuItem
            // 
            this.estadoDeLaConexionToolStripMenuItem.Name = "estadoDeLaConexionToolStripMenuItem";
            this.estadoDeLaConexionToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.estadoDeLaConexionToolStripMenuItem.Text = "Estado de la Conexion";
            this.estadoDeLaConexionToolStripMenuItem.Click += new System.EventHandler(this.estadoDeLaConexionToolStripMenuItem_Click);
            // 
            // CadConex
            // 
            this.CadConex.Name = "CadConex";
            this.CadConex.Size = new System.Drawing.Size(137, 22);
            this.CadConex.Text = "Cadena de Conexion";
            this.CadConex.Visible = false;
            // 
            // Lbltimer
            // 
            this.Lbltimer.AutoSize = true;
            this.Lbltimer.Location = new System.Drawing.Point(95, 38);
            this.Lbltimer.Name = "Lbltimer";
            this.Lbltimer.Size = new System.Drawing.Size(0, 13);
            this.Lbltimer.TabIndex = 11;
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.White;
            this.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.ForeColor = System.Drawing.Color.Black;
            this.Btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("Btnlogin.Image")));
            this.Btnlogin.Location = new System.Drawing.Point(142, 141);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(97, 40);
            this.Btnlogin.TabIndex = 1;
            this.Btnlogin.Text = "Ingresar";
            this.Btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcodigo.Location = new System.Drawing.Point(142, 58);
            this.Txtcodigo.MaxLength = 12;
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(207, 29);
            this.Txtcodigo.TabIndex = 30;
            this.Txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtusuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo";
            // 
            // Txtpassword
            // 
            this.Txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpassword.Location = new System.Drawing.Point(142, 93);
            this.Txtpassword.MaxLength = 35;
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(207, 29);
            this.Txtpassword.TabIndex = 31;
            this.Txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtpassword.UseSystemPasswordChar = true;
            this.Txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbltimer);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.MenuLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuLogin;
            this.MaximizeBox = false;
            this.Name = "Frmlogin";
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.MenuLogin.ResumeLayout(false);
            this.MenuLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.MenuStrip MenuLogin;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haOlvidadoSuContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contacteConElAdministradorToolStripMenuItem;
        private System.Windows.Forms.Label Lbltimer;
        private System.Windows.Forms.ToolStripMenuItem estadoDeLaConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadConex;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Label label2;
    }
}