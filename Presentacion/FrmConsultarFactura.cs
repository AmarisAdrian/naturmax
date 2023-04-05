using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsultarFactura : Form
    {
        public FrmConsultarFactura()
        {
            InitializeComponent();
        }
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        Negocio.Usuario Usu = new Negocio.Usuario();
        Negocio.Functions fun = new Negocio.Functions();
        private void Txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmConsultarFactura_Load(object sender, EventArgs e)
        {
            Pantalla();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {

            if (Txtdocumento.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Auditoria.ConsultarFactura(Dgfactura, Txtdocumento)&& Usu.ConsultarCliente(Convert.ToString(Txtdocumento.Text)))
            {
                Lblnombres.Text = Usu._NOMBRESCLIENTES;
                Lblapellidos.Text = Usu._APELLIDOSCLIENTES;
                Lbldireccion.Text = Usu._DIRECCIONCLIENTES;
                Lbltelefono.Text = Usu._TELEFONOCLIENTES;
                Lblcelular.Text= Usu._CELULARCLIENTES;
            }
            else
            {
                MessageBox.Show(" ¡ El cliente no Existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Dgfactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string Numero = Convert.ToString(this.Dgfactura.CurrentRow.Cells[0].Value);
            Auditoria.ConsultarDetalleFactura(Dgdetallefactura, Convert.ToString(Numero));
            this.Dgdetallefactura.RowsDefaultCellStyle.BackColor = Color.White;
            this.Dgdetallefactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;
            try
            {
                if (Auditoria.ConsultarOPeradorFactura(Convert.ToString(Numero)))
                {
      
                        Lblnombreoperador.Text = Auditoria._NombreOPerador;
                        Lblapellidosoperador.Text = Auditoria._ApellidosOPerador;
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void Pantalla() 
        {
            this.Dgfactura.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.Dgfactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            
        }
        private void Btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Txtdocumento_TextChanged(object sender, EventArgs e)
        {
            if (Txtdocumento.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Auditoria.ConsultarFactura(Dgfactura, Txtdocumento) && Usu.ConsultarCliente(Convert.ToString(Txtdocumento.Text)))
            {
                Lblnombres.Text = Usu._NOMBRESCLIENTES;
                Lblapellidos.Text = Usu._APELLIDOSCLIENTES;
                Lbldireccion.Text = Usu._DIRECCIONCLIENTES;
                Lbltelefono.Text = Usu._TELEFONOCLIENTES;
                Lblcelular.Text = Usu._CELULARCLIENTES;
            }
            else
            {
                MessageBox.Show(" ¡ El cliente no Existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
