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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        Negocio.Validaciones val = new Negocio.Validaciones();
        public int _CodigoHabilitacion;
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        Negocio.Usuario Usu = new Negocio.Usuario();
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
        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txtcelular_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BtnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdocumento.Text == "" || Txtnombres.Text == "" || Txtapellidos.Text == "" || Txtdireccion.Text == "" || Txttelefono.Text == "" || Txtcelular.Text == "")
                {
                    MessageBox.Show(" Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if( Usu.InsertarCliente(Convert.ToString(Txtdocumento.Text), Convert.ToString(Txtnombres.Text), Convert.ToString(Txtapellidos.Text), Convert.ToString(Txtdireccion.Text), Convert.ToString(Txttelefono.Text), Convert.ToString(Txtcelular.Text)))
                {
                    MessageBox.Show("Usuario Registrado exitosamente", " Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    val.LimpiarCampos(this, Gbclientes);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdocumento.Text == "")
                {
                    MessageBox.Show(" Para borrar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Usu.EliminarCliente(Convert.ToString(Txtdocumento.Text)))
                {
                    MessageBox.Show("Usuario eliminado exitosamente", " Eliminacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    val.LimpiarCampos(this, Gbclientes);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario ", " Eliminacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Txtdocumento.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Usu.ConsultarCliente(Convert.ToString(Txtdocumento.Text)))
            {
                Txtnombres.Text = Usu._NOMBRESCLIENTES;
                Txtapellidos.Text = Usu._APELLIDOSCLIENTES;
                Txtdireccion.Text = Usu._DIRECCIONCLIENTES;
                Txttelefono.Text = Usu._TELEFONOCLIENTES;
                Txtcelular.Text = Usu._CELULARCLIENTES;
            }
            else
            {
                MessageBox.Show(" ¡ El cliente no Existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdocumento.Text == "" || Txtnombres.Text == "" || Txtapellidos.Text == "" || Txtdireccion.Text == "" || Txttelefono.Text == "" || Txtcelular.Text == "")
                {
                    MessageBox.Show(" Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Usu.ActualizarCliente(Convert.ToString(Txtdocumento.Text), Convert.ToString(Txtnombres.Text), Convert.ToString(Txtapellidos.Text), Convert.ToString(Txtdireccion.Text), Convert.ToString(Txttelefono.Text), Convert.ToString(Txtcelular.Text)))
                {
                    MessageBox.Show("Usuario Actualizado exitosamente", " Actualizacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    val.LimpiarCampos(this, Gbclientes);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario", " Actualizacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtdocumento_TextChanged(object sender, EventArgs e)
        {
            if (Txtdocumento.Text == "") 
            {
                val.LimpiarCampos(this, Gbclientes);
            }
        }
        private void HabilitarBoton ()
        {
            int Switch = _CodigoHabilitacion;
            if (Switch == 1) 
            {
                BtnBorrarCliente.Enabled = true;
            }
            else if (Switch == 2)
            {
                BtnBorrarCliente.Enabled = false;
            }
        }
    }
}
