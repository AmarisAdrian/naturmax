namespace Presentacion
{
    partial class Frmsoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsoporte));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtsoporteemail = new System.Windows.Forms.TextBox();
            this.Txtsoportedoc = new System.Windows.Forms.TextBox();
            this.Rtbsoporte = new System.Windows.Forms.RichTextBox();
            this.Btnsoporteenviar = new System.Windows.Forms.Button();
            this.Btnvolver = new System.Windows.Forms.Button();
            this.Txtemailadmin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOCUMENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Txtsoporteemail);
            this.groupBox1.Controls.Add(this.Txtsoportedoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Txtsoporteemail
            // 
            this.Txtsoporteemail.Location = new System.Drawing.Point(146, 67);
            this.Txtsoporteemail.Name = "Txtsoporteemail";
            this.Txtsoporteemail.Size = new System.Drawing.Size(120, 20);
            this.Txtsoporteemail.TabIndex = 5;
            // 
            // Txtsoportedoc
            // 
            this.Txtsoportedoc.Location = new System.Drawing.Point(146, 26);
            this.Txtsoportedoc.Name = "Txtsoportedoc";
            this.Txtsoportedoc.Size = new System.Drawing.Size(120, 20);
            this.Txtsoportedoc.TabIndex = 3;
            this.Txtsoportedoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtsoportedoc_KeyPress);
            // 
            // Rtbsoporte
            // 
            this.Rtbsoporte.BackColor = System.Drawing.Color.Snow;
            this.Rtbsoporte.Location = new System.Drawing.Point(16, 135);
            this.Rtbsoporte.Name = "Rtbsoporte";
            this.Rtbsoporte.Size = new System.Drawing.Size(306, 85);
            this.Rtbsoporte.TabIndex = 4;
            this.Rtbsoporte.Text = "";
            // 
            // Btnsoporteenviar
            // 
            this.Btnsoporteenviar.Location = new System.Drawing.Point(34, 226);
            this.Btnsoporteenviar.Name = "Btnsoporteenviar";
            this.Btnsoporteenviar.Size = new System.Drawing.Size(99, 51);
            this.Btnsoporteenviar.TabIndex = 5;
            this.Btnsoporteenviar.Text = "Enviar";
            this.Btnsoporteenviar.UseVisualStyleBackColor = true;
            this.Btnsoporteenviar.Click += new System.EventHandler(this.Btnsoporteenviar_Click);
            // 
            // Btnvolver
            // 
            this.Btnvolver.Location = new System.Drawing.Point(207, 226);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(99, 51);
            this.Btnvolver.TabIndex = 6;
            this.Btnvolver.Text = "Volver";
            this.Btnvolver.UseVisualStyleBackColor = true;
            this.Btnvolver.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Txtemailadmin
            // 
            this.Txtemailadmin.Location = new System.Drawing.Point(85, 298);
            this.Txtemailadmin.Name = "Txtemailadmin";
            this.Txtemailadmin.Size = new System.Drawing.Size(170, 20);
            this.Txtemailadmin.TabIndex = 7;
            this.Txtemailadmin.Text = "Adrianprogramacion@outlook.com";
            this.Txtemailadmin.Visible = false;
            // 
            // Frmsoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 329);
            this.Controls.Add(this.Txtemailadmin);
            this.Controls.Add(this.Btnvolver);
            this.Controls.Add(this.Btnsoporteenviar);
            this.Controls.Add(this.Rtbsoporte);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmsoporte";
            this.Text = "CONTACTE CON EL ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Frmsoporte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtsoporteemail;
        private System.Windows.Forms.TextBox Txtsoportedoc;
        private System.Windows.Forms.RichTextBox Rtbsoporte;
        private System.Windows.Forms.Button Btnsoporteenviar;
        private System.Windows.Forms.Button Btnvolver;
        private System.Windows.Forms.TextBox Txtemailadmin;
    }
}