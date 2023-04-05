namespace Presentacion
{
    partial class FrmCerrarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCerrarSesion));
            this.Pbcontrol = new System.Windows.Forms.ProgressBar();
            this.Lblestado = new System.Windows.Forms.Label();
            this.Dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Crono = new System.Windows.Forms.Timer(this.components);
            this.Contimer = new System.Windows.Forms.Label();
            this.LblRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pbcontrol
            // 
            this.Pbcontrol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pbcontrol.Location = new System.Drawing.Point(17, 72);
            this.Pbcontrol.Name = "Pbcontrol";
            this.Pbcontrol.Size = new System.Drawing.Size(288, 23);
            this.Pbcontrol.TabIndex = 7;
            // 
            // Lblestado
            // 
            this.Lblestado.AutoSize = true;
            this.Lblestado.BackColor = System.Drawing.Color.Transparent;
            this.Lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblestado.Location = new System.Drawing.Point(17, 113);
            this.Lblestado.Name = "Lblestado";
            this.Lblestado.Size = new System.Drawing.Size(131, 16);
            this.Lblestado.TabIndex = 10;
            this.Lblestado.Text = "Estado:Verificando...";
            // 
            // Dtfecha
            // 
            this.Dtfecha.Enabled = false;
            this.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfecha.Location = new System.Drawing.Point(217, 26);
            this.Dtfecha.Name = "Dtfecha";
            this.Dtfecha.Size = new System.Drawing.Size(92, 20);
            this.Dtfecha.TabIndex = 11;
            this.Dtfecha.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Guardando Datos...";
            // 
            // Crono
            // 
            this.Crono.Interval = 1000;
            this.Crono.Tick += new System.EventHandler(this.Crono_Tick);
            // 
            // Contimer
            // 
            this.Contimer.AutoSize = true;
            this.Contimer.Location = new System.Drawing.Point(198, 113);
            this.Contimer.Name = "Contimer";
            this.Contimer.Size = new System.Drawing.Size(13, 13);
            this.Contimer.TabIndex = 17;
            this.Contimer.Text = "0";
            this.Contimer.Visible = false;
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Location = new System.Drawing.Point(321, 82);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(13, 13);
            this.LblRegistro.TabIndex = 18;
            this.LblRegistro.Text = "0";
            this.LblRegistro.Visible = false;
            // 
            // FrmCerrarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 165);
            this.Controls.Add(this.LblRegistro);
            this.Controls.Add(this.Contimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtfecha);
            this.Controls.Add(this.Lblestado);
            this.Controls.Add(this.Pbcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCerrarSesion";
            this.Text = "Cerrando Sesion";
            this.Load += new System.EventHandler(this.FrmCerrarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Pbcontrol;
        private System.Windows.Forms.Label Lblestado;
        private System.Windows.Forms.DateTimePicker Dtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Crono;
        private System.Windows.Forms.Label Contimer;
        private System.Windows.Forms.Label LblRegistro;
    }
}