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
    public partial class Frmemail : Form
    {
        public Frmemail()
        {
            InitializeComponent();
        }
        Negocio.Usuario usu = new Negocio.Usuario();
        Negocio.Seguridad Seg = new Negocio.Seguridad();
        Negocio.Functions fun = new Negocio.Functions();
        private void Frmemail_Load(object sender, EventArgs e)
        {

        }
    
        private void Btnenviaremail_Click(object sender, EventArgs e)
        {
            bool enviar = false;
            try
            {
                if (Negocio.Seguridad.ConexionInternet())
                {
                    if (Txtconsultardocumento.Text == "")
                    {
                        MessageBox.Show("No puede dejar el campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (usu.ConsultarPorDocumento(Convert.ToString(Txtconsultardocumento.Text), Convert.ToString(Txtemail.Text)))
                    {
                        Txtusuario.Text = Txtconsultardocumento.Text;
                        Txtemail.Text = usu._VEMAILOP;
                        Txtpassword.Text = usu._VPASS;
                        enviar = true;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        enviar = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay conexión a internet, intente mas tarde", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    enviar = false;
                }
                if (enviar == true)
                {
                    if (fun.EnviarMailRecuperarContraseña(Txtusuario, Txtpassword, Txtemail))
                    {
                        MessageBox.Show("El usuario y contraseña fue enviada a su correo", "Envio exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo enviar su contraseña", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Frmlogin Frm = new Frmlogin();
            Frm.Show();
            this.Hide();
        }
        private void Txtconsultardocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
