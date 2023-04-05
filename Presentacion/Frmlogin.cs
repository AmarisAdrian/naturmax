using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Imaging;
namespace Presentacion
{
    public partial class Frmlogin : Form
    {


        public Frmlogin()
        {
            InitializeComponent();
        }
        private void Frmlogin_Load(object sender, EventArgs e)
        {
            
        }
        Negocio.Usuario usu = new Negocio.Usuario();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtcodigo.Text == "" || Txtpassword.Text == "")
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usu.PermitirAcceso(Convert.ToString(Txtcodigo.Text), Convert.ToString(Txtpassword.Text)))
                {

                    if (usu._TIPOUSUARIOLOGIN == 1 && usu.ConsultarPanelAdministrador(Convert.ToString(Txtcodigo.Text)))
                    {
                        FrmAdministrador frm = new FrmAdministrador();
                        frm._Documento = usu._VDOC;
                        frm._Nombre = usu._VNOMBREOP;
                        frm._Apellido = usu._VAPELLIDOSOP;
                        frm._FOTOPERADOR = usu._FOTOPERADOR;
                        frm.Show();
                        this.Hide();
                    }
                    if (usu._TIPOUSUARIOLOGIN == 2 && usu.ConsultarPanelOperador(Convert.ToString(Txtcodigo.Text)))
                    {
                        FrmFactura frm = new FrmFactura();
                        frm._Doc = usu._DOCOPERADOR;
                        frm._Name = usu._NAMEOPERADOR;
                        frm._Last = usu._LASTNAMEOPERADOR;
                        frm.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña no corresponden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ocurrio el Siguiente error");
            }
        }
        private void haOlvidadoSuContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmemail Frm = new Frmemail();
            Frm.Show();
            this.Hide();
        }
        private void contacteConElAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsoporte Frm = new Frmsoporte();
            Frm.Show();
            this.Hide();
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("¿Desea salir?", "Salida Segura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void estadoDeLaConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmconexion Frm = new Frmconexion();
            Frm.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("¿Desea salir?", "Salida Segura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadConexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarCadConex frm = new FrmCambiarCadConex();
            frm.Show();
            this.Hide();
        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (Txtcodigo.Text == "" || Txtpassword.Text == "")
                    {
                        MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (usu.PermitirAcceso(Convert.ToString(Txtcodigo.Text), Convert.ToString(Txtpassword.Text)))
                    {

                        if (usu._TIPOUSUARIOLOGIN == 1 && usu.ConsultarPanelAdministrador(Convert.ToString(Txtcodigo.Text)))
                        {
                            FrmAdministrador frm = new FrmAdministrador();
                            frm._Documento = usu._VDOC;
                            frm._Nombre = usu._VNOMBREOP;
                            frm._Apellido = usu._VAPELLIDOSOP;
                            frm._FOTOPERADOR = usu._FOTOPERADOR;
                            frm.Show();
                            this.Hide();
                        }
                        if (usu._TIPOUSUARIOLOGIN == 2 && usu.ConsultarPanelOperador(Convert.ToString(Txtcodigo.Text)))
                        {
                            FrmFactura frm = new FrmFactura();
                            frm._Doc = usu._DOCOPERADOR;
                            frm._Name = usu._NAMEOPERADOR;
                            frm._Last = usu._LASTNAMEOPERADOR;
                            frm.Show();
                            this.Hide();
                        }
                        else if (usu._ESTADOLOGIN == 2)
                        {
                            MessageBox.Show("El usuario se encuentra bloqueado, Contacte con el administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (usu._ESTADOLOGIN == 3)
                        {
                            MessageBox.Show("El usuario se encuentra  Inactivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña no corresponden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ocurrio el Siguiente error");
                }
            }
        }
    
    }
}
