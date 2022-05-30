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
    public partial class Frmsoporte : Form
    {
        public Frmsoporte()
        {
            InitializeComponent();
        }
        Negocio.Validaciones neg = new Negocio.Validaciones();
        Negocio.Functions Fun = new Negocio.Functions();
        Negocio.ProcesosSecundarios Procesos = new Negocio.ProcesosSecundarios();

        private void Btnsoporteenviar_Click(object sender, EventArgs e)
        {
            if (Negocio.Seguridad.ConexionInternet())
            {
                if (neg.ValidarSoportetecnico( Txtsoportedoc, Txtsoporteemail, Rtbsoporte))
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (neg.ValidarEmail(Txtsoporteemail.Text)&& Fun.EnviarMailProblemas(Txtemailadmin, Txtsoportedoc, Txtsoporteemail, Rtbsoporte))
                {
                    MessageBox.Show("Correo enviado exitosamente", "Envio exitoso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Formato no correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Fun.EnviarMailProblemas(Txtemailadmin, Txtsoportedoc, Txtsoporteemail, Rtbsoporte);
                Fun.VaciarCampos(Txtsoportedoc, Txtsoporteemail, Rtbsoporte);
            }
            else 
            {
                MessageBox.Show("No hay conexión a internet, intente mas tarde", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            frm.Show();
            this.Hide();
        }

        private void Frmsoporte_Load(object sender, EventArgs e)
        {
            Email();
        }
        private void Email() 
        {
            try 
            {
                if(Procesos.UltimoEmail())
                {
                    Txtemailadmin.Text = Procesos._Email;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
        private void Txtsoportedoc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
