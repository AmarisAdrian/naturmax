namespace Presentacion
{
    partial class Frmconexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmconexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbldatos = new System.Windows.Forms.Label();
            this.Lblservidor = new System.Windows.Forms.Label();
            this.Lblinternet = new System.Windows.Forms.Label();
            this.Btnprobar = new System.Windows.Forms.Button();
            this.Btnvolver = new System.Windows.Forms.Button();
            this.PGBconexion = new System.Windows.Forms.ProgressBar();
            this.Lblesperar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONEXION A INTERNET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONEXION A SERVIDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONEXION A BASE DE DATOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Lbldatos);
            this.groupBox1.Controls.Add(this.Lblservidor);
            this.groupBox1.Controls.Add(this.Lblinternet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Lbldatos
            // 
            this.Lbldatos.AutoSize = true;
            this.Lbldatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbldatos.Location = new System.Drawing.Point(202, 136);
            this.Lbldatos.Name = "Lbldatos";
            this.Lbldatos.Size = new System.Drawing.Size(33, 15);
            this.Lbldatos.TabIndex = 5;
            this.Lbldatos.Text = "        ";
            // 
            // Lblservidor
            // 
            this.Lblservidor.AutoSize = true;
            this.Lblservidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblservidor.Location = new System.Drawing.Point(202, 86);
            this.Lblservidor.Name = "Lblservidor";
            this.Lblservidor.Size = new System.Drawing.Size(33, 15);
            this.Lblservidor.TabIndex = 4;
            this.Lblservidor.Text = "        ";
            // 
            // Lblinternet
            // 
            this.Lblinternet.AutoSize = true;
            this.Lblinternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblinternet.Location = new System.Drawing.Point(202, 39);
            this.Lblinternet.Name = "Lblinternet";
            this.Lblinternet.Size = new System.Drawing.Size(33, 15);
            this.Lblinternet.TabIndex = 3;
            this.Lblinternet.Text = "        ";
            // 
            // Btnprobar
            // 
            this.Btnprobar.Location = new System.Drawing.Point(42, 318);
            this.Btnprobar.Name = "Btnprobar";
            this.Btnprobar.Size = new System.Drawing.Size(83, 43);
            this.Btnprobar.TabIndex = 1;
            this.Btnprobar.Text = "probar";
            this.Btnprobar.UseVisualStyleBackColor = true;
            this.Btnprobar.Click += new System.EventHandler(this.Btnprobar_Click);
            // 
            // Btnvolver
            // 
            this.Btnvolver.Location = new System.Drawing.Point(147, 318);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(83, 43);
            this.Btnvolver.TabIndex = 2;
            this.Btnvolver.Text = "Volver";
            this.Btnvolver.UseVisualStyleBackColor = true;
            this.Btnvolver.Click += new System.EventHandler(this.Btnvolver_Click);
            // 
            // PGBconexion
            // 
            this.PGBconexion.BackColor = System.Drawing.Color.Yellow;
            this.PGBconexion.Location = new System.Drawing.Point(66, 263);
            this.PGBconexion.Name = "PGBconexion";
            this.PGBconexion.Size = new System.Drawing.Size(132, 23);
            this.PGBconexion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PGBconexion.TabIndex = 6;
            // 
            // Lblesperar
            // 
            this.Lblesperar.AutoSize = true;
            this.Lblesperar.Location = new System.Drawing.Point(77, 307);
            this.Lblesperar.Name = "Lblesperar";
            this.Lblesperar.Size = new System.Drawing.Size(0, 13);
            this.Lblesperar.TabIndex = 7;
            // 
            // Frmconexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 373);
            this.Controls.Add(this.Lblesperar);
            this.Controls.Add(this.PGBconexion);
            this.Controls.Add(this.Btnvolver);
            this.Controls.Add(this.Btnprobar);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmconexion";
            this.Text = "Verificar Conexiones";
            this.Load += new System.EventHandler(this.Frmconexion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnprobar;
        private System.Windows.Forms.Button Btnvolver;
        private System.Windows.Forms.Label Lbldatos;
        private System.Windows.Forms.Label Lblservidor;
        private System.Windows.Forms.Label Lblinternet;
        private System.Windows.Forms.ProgressBar PGBconexion;
        private System.Windows.Forms.Label Lblesperar;
    }
}