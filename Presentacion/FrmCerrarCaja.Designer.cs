namespace Presentacion
{
    partial class FrmCerrarCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCerrarCaja));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblHoraF = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCerrado = new System.Windows.Forms.ComboBox();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtfecha = new System.Windows.Forms.DateTimePicker();
            this.TxtSaldoGuardar = new System.Windows.Forms.TextBox();
            this.TxtMontoRetirar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtFacturasGeneradas = new System.Windows.Forms.TextBox();
            this.Txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txtequipo = new System.Windows.Forms.TextBox();
            this.Txtdocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdregistro = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblHoraF);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CmbCerrado);
            this.panel2.Controls.Add(this.BtnCerrarCaja);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Dtfecha);
            this.panel2.Controls.Add(this.TxtSaldoGuardar);
            this.panel2.Controls.Add(this.TxtMontoRetirar);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.TxtFacturasGeneradas);
            this.panel2.Controls.Add(this.Txttotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 302);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LblHoraF
            // 
            this.LblHoraF.AutoSize = true;
            this.LblHoraF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraF.Location = new System.Drawing.Point(153, 50);
            this.LblHoraF.Name = "LblHoraF";
            this.LblHoraF.Size = new System.Drawing.Size(41, 16);
            this.LblHoraF.TabIndex = 29;
            this.LblHoraF.Text = "Hora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado de Cierre:";
            // 
            // CmbCerrado
            // 
            this.CmbCerrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCerrado.FormattingEnabled = true;
            this.CmbCerrado.Location = new System.Drawing.Point(156, 87);
            this.CmbCerrado.Name = "CmbCerrado";
            this.CmbCerrado.Size = new System.Drawing.Size(159, 28);
            this.CmbCerrado.TabIndex = 24;
            this.CmbCerrado.SelectedIndexChanged += new System.EventHandler(this.CmbCerrado_SelectedIndexChanged);
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.Location = new System.Drawing.Point(155, 258);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(82, 28);
            this.BtnCerrarCaja.TabIndex = 9;
            this.BtnCerrarCaja.Text = "Cierre";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Monto a Guardar: $";
            // 
            // Dtfecha
            // 
            this.Dtfecha.Enabled = false;
            this.Dtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtfecha.Location = new System.Drawing.Point(156, 14);
            this.Dtfecha.Name = "Dtfecha";
            this.Dtfecha.Size = new System.Drawing.Size(159, 22);
            this.Dtfecha.TabIndex = 9;
            // 
            // TxtSaldoGuardar
            // 
            this.TxtSaldoGuardar.Enabled = false;
            this.TxtSaldoGuardar.Location = new System.Drawing.Point(156, 232);
            this.TxtSaldoGuardar.Name = "TxtSaldoGuardar";
            this.TxtSaldoGuardar.Size = new System.Drawing.Size(135, 20);
            this.TxtSaldoGuardar.TabIndex = 22;
            this.TxtSaldoGuardar.Text = "0";
            // 
            // TxtMontoRetirar
            // 
            this.TxtMontoRetirar.Location = new System.Drawing.Point(156, 203);
            this.TxtMontoRetirar.Name = "TxtMontoRetirar";
            this.TxtMontoRetirar.Size = new System.Drawing.Size(135, 20);
            this.TxtMontoRetirar.TabIndex = 21;
            this.TxtMontoRetirar.Text = "0";
            this.TxtMontoRetirar.TextChanged += new System.EventHandler(this.TxtMontoRetirar_TextChanged);
            this.TxtMontoRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoRetirar_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Monto a Retirar: $";
            // 
            // TxtFacturasGeneradas
            // 
            this.TxtFacturasGeneradas.Enabled = false;
            this.TxtFacturasGeneradas.Location = new System.Drawing.Point(156, 145);
            this.TxtFacturasGeneradas.Name = "TxtFacturasGeneradas";
            this.TxtFacturasGeneradas.Size = new System.Drawing.Size(135, 20);
            this.TxtFacturasGeneradas.TabIndex = 15;
            this.TxtFacturasGeneradas.Text = "0";
            // 
            // Txttotal
            // 
            this.Txttotal.Enabled = false;
            this.Txttotal.Location = new System.Drawing.Point(156, 174);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(135, 20);
            this.Txttotal.TabIndex = 14;
            this.Txttotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Facturas Generadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total generado: $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "CIERRE DE CAJA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Equipo:";
            // 
            // Txtequipo
            // 
            this.Txtequipo.Enabled = false;
            this.Txtequipo.Location = new System.Drawing.Point(152, 72);
            this.Txtequipo.Name = "Txtequipo";
            this.Txtequipo.Size = new System.Drawing.Size(146, 20);
            this.Txtequipo.TabIndex = 14;
            // 
            // Txtdocumento
            // 
            this.Txtdocumento.Enabled = false;
            this.Txtdocumento.Location = new System.Drawing.Point(152, 45);
            this.Txtdocumento.Name = "Txtdocumento";
            this.Txtdocumento.Size = new System.Drawing.Size(146, 20);
            this.Txtdocumento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Documento:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtIdregistro);
            this.panel1.Controls.Add(this.Txtdocumento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Txtequipo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 113);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Registro N°";
            // 
            // TxtIdregistro
            // 
            this.TxtIdregistro.Enabled = false;
            this.TxtIdregistro.Location = new System.Drawing.Point(152, 18);
            this.TxtIdregistro.Name = "TxtIdregistro";
            this.TxtIdregistro.Size = new System.Drawing.Size(146, 20);
            this.TxtIdregistro.TabIndex = 16;
            // 
            // FrmCerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCerrarCaja";
            this.Text = "Cerrar Caja";
            this.Load += new System.EventHandler(this.FrmCerrarCaja_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtFacturasGeneradas;
        private System.Windows.Forms.TextBox Txttotal;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txtequipo;
        private System.Windows.Forms.TextBox Txtdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtIdregistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMontoRetirar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSaldoGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblHoraF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCerrado;
    }
}