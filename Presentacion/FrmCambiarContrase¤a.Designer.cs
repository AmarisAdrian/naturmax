namespace Presentacion
{
    partial class FrmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContraseña));
            this.lbldocumento = new System.Windows.Forms.Label();
            this.TxtPassnueva = new System.Windows.Forms.TextBox();
            this.Txtconfirmar = new System.Windows.Forms.TextBox();
            this.Txtpassantigua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Location = new System.Drawing.Point(12, 109);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(0, 13);
            this.lbldocumento.TabIndex = 0;
            this.lbldocumento.Visible = false;
            // 
            // TxtPassnueva
            // 
            this.TxtPassnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassnueva.Location = new System.Drawing.Point(132, 45);
            this.TxtPassnueva.Name = "TxtPassnueva";
            this.TxtPassnueva.PasswordChar = '*';
            this.TxtPassnueva.Size = new System.Drawing.Size(149, 22);
            this.TxtPassnueva.TabIndex = 2;
            // 
            // Txtconfirmar
            // 
            this.Txtconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtconfirmar.Location = new System.Drawing.Point(132, 71);
            this.Txtconfirmar.Name = "Txtconfirmar";
            this.Txtconfirmar.PasswordChar = '*';
            this.Txtconfirmar.Size = new System.Drawing.Size(149, 22);
            this.Txtconfirmar.TabIndex = 3;
            // 
            // Txtpassantigua
            // 
            this.Txtpassantigua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpassantigua.Location = new System.Drawing.Point(132, 18);
            this.Txtpassantigua.Name = "Txtpassantigua";
            this.Txtpassantigua.PasswordChar = '*';
            this.Txtpassantigua.Size = new System.Drawing.Size(149, 22);
            this.Txtpassantigua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña antigua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar contraseña";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(132, 99);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(84, 33);
            this.BtnCambiar.TabIndex = 7;
            this.BtnCambiar.Text = "Cambiar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(53, 107);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(0, 13);
            this.LblPassword.TabIndex = 8;
            this.LblPassword.Visible = false;
            // 
            // FrmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 151);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpassantigua);
            this.Controls.Add(this.Txtconfirmar);
            this.Controls.Add(this.TxtPassnueva);
            this.Controls.Add(this.lbldocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCambiarContraseña";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.TextBox TxtPassnueva;
        private System.Windows.Forms.TextBox Txtconfirmar;
        private System.Windows.Forms.TextBox Txtpassantigua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Label LblPassword;
    }
}