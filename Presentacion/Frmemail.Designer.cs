namespace Presentacion
{
    partial class Frmemail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmemail));
            this.label3 = new System.Windows.Forms.Label();
            this.Txtconsultardocumento = new System.Windows.Forms.TextBox();
            this.Btnenviaremail = new System.Windows.Forms.Button();
            this.Btnvolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.Txtemail = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE SU DOCUMENTO\r\n";
            // 
            // Txtconsultardocumento
            // 
            this.Txtconsultardocumento.Location = new System.Drawing.Point(164, 39);
            this.Txtconsultardocumento.Name = "Txtconsultardocumento";
            this.Txtconsultardocumento.Size = new System.Drawing.Size(113, 20);
            this.Txtconsultardocumento.TabIndex = 4;
            this.Txtconsultardocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtconsultardocumento_KeyPress);
            // 
            // Btnenviaremail
            // 
            this.Btnenviaremail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnenviaremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnenviaremail.ForeColor = System.Drawing.Color.White;
            this.Btnenviaremail.Location = new System.Drawing.Point(52, 132);
            this.Btnenviaremail.Name = "Btnenviaremail";
            this.Btnenviaremail.Size = new System.Drawing.Size(103, 43);
            this.Btnenviaremail.TabIndex = 5;
            this.Btnenviaremail.Text = "Enviar";
            this.Btnenviaremail.UseVisualStyleBackColor = false;
            this.Btnenviaremail.Click += new System.EventHandler(this.Btnenviaremail_Click);
            // 
            // Btnvolver
            // 
            this.Btnvolver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnvolver.ForeColor = System.Drawing.Color.White;
            this.Btnvolver.Location = new System.Drawing.Point(176, 132);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(103, 43);
            this.Btnvolver.TabIndex = 6;
            this.Btnvolver.Text = "Volver";
            this.Btnvolver.UseVisualStyleBackColor = false;
            this.Btnvolver.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Txtconsultardocumento);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 99);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(42, 181);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(113, 20);
            this.Txtusuario.TabIndex = 7;
            this.Txtusuario.Visible = false;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(176, 181);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(113, 20);
            this.Txtpassword.TabIndex = 7;
            this.Txtpassword.Visible = false;
            // 
            // Txtemail
            // 
            this.Txtemail.Location = new System.Drawing.Point(103, 181);
            this.Txtemail.Name = "Txtemail";
            this.Txtemail.Size = new System.Drawing.Size(113, 20);
            this.Txtemail.TabIndex = 11;
            this.Txtemail.Visible = false;
            // 
            // Frmemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 205);
            this.Controls.Add(this.Txtemail);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btnvolver);
            this.Controls.Add(this.Btnenviaremail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmemail";
            this.Text = "Recuperar Usuario";
            this.Load += new System.EventHandler(this.Frmemail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtconsultardocumento;
        private System.Windows.Forms.Button Btnenviaremail;
        private System.Windows.Forms.Button Btnvolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.TextBox Txtemail;
    }
}