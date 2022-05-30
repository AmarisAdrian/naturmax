namespace Presentacion
{
    partial class FrmAbrirCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbrirCaja));
            this.label2 = new System.Windows.Forms.Label();
            this.PanelApertura = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Txtsaldoanterior = new System.Windows.Forms.TextBox();
            this.TxtIngresarMonto = new System.Windows.Forms.TextBox();
            this.BtnAbrirCaja = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtfecha = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtregistro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txtequipo = new System.Windows.Forms.TextBox();
            this.Txtdocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmbestado = new System.Windows.Forms.ComboBox();
            this.PanelApertura.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "APERTURA DE CAJA";
            // 
            // PanelApertura
            // 
            this.PanelApertura.BackColor = System.Drawing.Color.Transparent;
            this.PanelApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelApertura.Controls.Add(this.Cmbestado);
            this.PanelApertura.Controls.Add(this.label7);
            this.PanelApertura.Controls.Add(this.label11);
            this.PanelApertura.Controls.Add(this.Txtsaldoanterior);
            this.PanelApertura.Controls.Add(this.TxtIngresarMonto);
            this.PanelApertura.Controls.Add(this.BtnAbrirCaja);
            this.PanelApertura.Controls.Add(this.label4);
            this.PanelApertura.Location = new System.Drawing.Point(15, 230);
            this.PanelApertura.Name = "PanelApertura";
            this.PanelApertura.Size = new System.Drawing.Size(254, 163);
            this.PanelApertura.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Saldo Anterior: $";
            // 
            // Txtsaldoanterior
            // 
            this.Txtsaldoanterior.Enabled = false;
            this.Txtsaldoanterior.Location = new System.Drawing.Point(125, 48);
            this.Txtsaldoanterior.Name = "Txtsaldoanterior";
            this.Txtsaldoanterior.Size = new System.Drawing.Size(115, 20);
            this.Txtsaldoanterior.TabIndex = 20;
            this.Txtsaldoanterior.Text = "0";
            // 
            // TxtIngresarMonto
            // 
            this.TxtIngresarMonto.Location = new System.Drawing.Point(125, 81);
            this.TxtIngresarMonto.Name = "TxtIngresarMonto";
            this.TxtIngresarMonto.Size = new System.Drawing.Size(115, 20);
            this.TxtIngresarMonto.TabIndex = 19;
            this.TxtIngresarMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIngresarMonto_KeyPress);
            // 
            // BtnAbrirCaja
            // 
            this.BtnAbrirCaja.Location = new System.Drawing.Point(125, 122);
            this.BtnAbrirCaja.Name = "BtnAbrirCaja";
            this.BtnAbrirCaja.Size = new System.Drawing.Size(93, 36);
            this.BtnAbrirCaja.TabIndex = 9;
            this.BtnAbrirCaja.Text = "&Abrir Caja";
            this.BtnAbrirCaja.UseVisualStyleBackColor = true;
            this.BtnAbrirCaja.Click += new System.EventHandler(this.BtnAbrirCaja_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingresar Base: $";
            // 
            // Dtfecha
            // 
            this.Dtfecha.Enabled = false;
            this.Dtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfecha.Location = new System.Drawing.Point(117, 43);
            this.Dtfecha.Name = "Dtfecha";
            this.Dtfecha.Size = new System.Drawing.Size(116, 22);
            this.Dtfecha.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.LblHora);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Txtregistro);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.Txtequipo);
            this.panel3.Controls.Add(this.Txtdocumento);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Dtfecha);
            this.panel3.Location = new System.Drawing.Point(15, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 160);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hora :";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(114, 23);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(13, 13);
            this.LblHora.TabIndex = 9;
            this.LblHora.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registro N° :";
            // 
            // Txtregistro
            // 
            this.Txtregistro.Enabled = false;
            this.Txtregistro.Location = new System.Drawing.Point(116, 72);
            this.Txtregistro.Name = "Txtregistro";
            this.Txtregistro.Size = new System.Drawing.Size(115, 20);
            this.Txtregistro.TabIndex = 18;
            this.Txtregistro.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Equipo:";
            // 
            // Txtequipo
            // 
            this.Txtequipo.Enabled = false;
            this.Txtequipo.Location = new System.Drawing.Point(118, 126);
            this.Txtequipo.Name = "Txtequipo";
            this.Txtequipo.Size = new System.Drawing.Size(115, 20);
            this.Txtequipo.TabIndex = 10;
            // 
            // Txtdocumento
            // 
            this.Txtdocumento.Enabled = false;
            this.Txtdocumento.Location = new System.Drawing.Point(118, 99);
            this.Txtdocumento.Name = "Txtdocumento";
            this.Txtdocumento.Size = new System.Drawing.Size(115, 20);
            this.Txtdocumento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado :";
            // 
            // Cmbestado
            // 
            this.Cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbestado.Enabled = false;
            this.Cmbestado.FormattingEnabled = true;
            this.Cmbestado.Location = new System.Drawing.Point(126, 14);
            this.Cmbestado.Name = "Cmbestado";
            this.Cmbestado.Size = new System.Drawing.Size(114, 21);
            this.Cmbestado.TabIndex = 9;
            this.Cmbestado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmAbrirCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 405);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelApertura);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbrirCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.PanelApertura.ResumeLayout(false);
            this.PanelApertura.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelApertura;
        private System.Windows.Forms.Button BtnAbrirCaja;
        private System.Windows.Forms.DateTimePicker Dtfecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txtsaldoanterior;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtdocumento;
        private System.Windows.Forms.TextBox Txtequipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtregistro;
        private System.Windows.Forms.TextBox TxtIngresarMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmbestado;


    }
}