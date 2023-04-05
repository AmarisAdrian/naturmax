using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmReferenciaProducto : Form
    {
        public FrmReferenciaProducto()
        {
            InitializeComponent();
        }
        Negocio.Functions f = new Negocio.Functions();
        Negocio.ProductosProveedor pr = new Negocio.ProductosProveedor();
        public string _EnviarIdProducto;
        private void FrmReferenciaProducto_Load(object sender, EventArgs e)
        {
            TxtfiltrarNombre.Visible = false;
            Txtfiltrar.Visible = false;
            this.DgCargarProducto.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.DgCargarProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
        }
        private void Txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            pr.FIltrarGrilla(DgCargarProducto, Convert.ToString(Txtfiltrar.Text));
        }
        private void Txtfiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    } 
        
        }
        private void TxtfiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            pr.FIltrarGrillaNombre(DgCargarProducto,TxtfiltrarNombre);
        }
        private void Cmbfiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmbfiltrar.SelectedIndex==0)
            {
                f.CargarReferenciaProducto(DgCargarProducto);
                TxtfiltrarNombre.Visible = false;
                Txtfiltrar.Visible = false;
                TxtfiltrarNombre.Clear();
                Txtfiltrar.Clear();
            }
            else  if(Cmbfiltrar.SelectedIndex ==1)
            {
                TxtfiltrarNombre.Visible = true;
                Txtfiltrar.Visible = false;
                Txtfiltrar.Clear();
            }
            else if (Cmbfiltrar.SelectedIndex ==2)
            {
                TxtfiltrarNombre.Visible = false;
                TxtfiltrarNombre.Clear();
                Txtfiltrar.Visible = true;
            }
        }

        private void DgCargarProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _EnviarIdProducto = Convert.ToString(this.DgCargarProducto.CurrentRow.Cells[0].Value);
         }
    }
}
