namespace Presentacion
{
    partial class FrmReferenciaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReferenciaProducto));
            this.DgCargarProducto = new System.Windows.Forms.DataGridView();
            this.Txtfiltrar = new System.Windows.Forms.TextBox();
            this.TxtfiltrarNombre = new System.Windows.Forms.TextBox();
            this.Cmbfiltrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgCargarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgCargarProducto
            // 
            this.DgCargarProducto.AllowUserToDeleteRows = false;
            this.DgCargarProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCargarProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgCargarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCargarProducto.Location = new System.Drawing.Point(45, 74);
            this.DgCargarProducto.Name = "DgCargarProducto";
            this.DgCargarProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCargarProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgCargarProducto.RowHeadersVisible = false;
            this.DgCargarProducto.Size = new System.Drawing.Size(504, 248);
            this.DgCargarProducto.TabIndex = 2;
            this.DgCargarProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCargarProducto_CellDoubleClick);
            // 
            // Txtfiltrar
            // 
            this.Txtfiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfiltrar.Location = new System.Drawing.Point(45, 37);
            this.Txtfiltrar.Name = "Txtfiltrar";
            this.Txtfiltrar.Size = new System.Drawing.Size(316, 27);
            this.Txtfiltrar.TabIndex = 4;
            this.Txtfiltrar.TextChanged += new System.EventHandler(this.Txtfiltrar_TextChanged);
            this.Txtfiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtfiltrar_KeyPress);
            // 
            // TxtfiltrarNombre
            // 
            this.TxtfiltrarNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtfiltrarNombre.Location = new System.Drawing.Point(45, 37);
            this.TxtfiltrarNombre.Name = "TxtfiltrarNombre";
            this.TxtfiltrarNombre.Size = new System.Drawing.Size(316, 27);
            this.TxtfiltrarNombre.TabIndex = 5;
            this.TxtfiltrarNombre.TextChanged += new System.EventHandler(this.TxtfiltrarNombre_TextChanged);
            // 
            // Cmbfiltrar
            // 
            this.Cmbfiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbfiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbfiltrar.FormattingEnabled = true;
            this.Cmbfiltrar.Items.AddRange(new object[] {
            "Todos Los Productos",
            "FIltrar Por Descripcion",
            "Filtrar Por Refencia"});
            this.Cmbfiltrar.Location = new System.Drawing.Point(367, 37);
            this.Cmbfiltrar.Name = "Cmbfiltrar";
            this.Cmbfiltrar.Size = new System.Drawing.Size(182, 29);
            this.Cmbfiltrar.TabIndex = 6;
            this.Cmbfiltrar.SelectedIndexChanged += new System.EventHandler(this.Cmbfiltrar_SelectedIndexChanged);
            // 
            // FrmReferenciaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 369);
            this.Controls.Add(this.Cmbfiltrar);
            this.Controls.Add(this.TxtfiltrarNombre);
            this.Controls.Add(this.Txtfiltrar);
            this.Controls.Add(this.DgCargarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReferenciaProducto";
            this.Text = "Referencia Producto";
            this.Load += new System.EventHandler(this.FrmReferenciaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCargarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgCargarProducto;
        private System.Windows.Forms.TextBox Txtfiltrar;
        private System.Windows.Forms.TextBox TxtfiltrarNombre;
        private System.Windows.Forms.ComboBox Cmbfiltrar;
    }
}