using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Imaging;
using Negocio;

namespace Presentacion
{
    public partial class Frmusuarios : Form
    {
        public Frmusuarios()
        {
            InitializeComponent();
           
        }
        Negocio.Validaciones val = new Negocio.Validaciones();
        Negocio.ProductosProveedor pv = new ProductosProveedor();
        Negocio.WebCam Webcam = new Negocio.WebCam();
        Negocio.Usuario usu = new Negocio.Usuario();
        Negocio.Usuario Eli = new Negocio.Usuario();
        private void Combos()
        {
            try
            {
                Negocio.Functions Cargar = new Negocio.Functions();
                Cargar.CargarComboGenero(CmbGeneroOperador);
                CmbGeneroOperador.SelectedIndex = -1;
                Cargar.CargarComboEstado(CmbEstadoOperador);
                CmbEstadoOperador.SelectedIndex = -1;
                Cargar.CargarComboTipoUsuario(CmbTipoOperador);
                CmbTipoOperador.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frmusuarios_Load(object sender, EventArgs e)
        {
            Combos();
            Webcam.InitializeWebCam(ref Pfoto);
        }
        private void TxtDocOperador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void TxtTelefonoOperador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
        private void TxtMovilOperador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
        private void TxtNombresOperador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void TxtApellidosOperador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                return Image.FromStream(ms);
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtDocOperador.Text == "" || TxtPasswordOperador.Text == "" || TxtNombresOperador.Text == "" || TxtApellidosOperador.Text == "" || CmbGeneroOperador.Text == "" || CmbEstadoOperador.Text == "" || CmbTipoOperador.Text == "" || TxtTelefonoOperador.Text == "" || TxtMovilOperador.Text == "" || TxtEmailOperador.Text == "" || TxtCiudadOperador.Text == "" || TxtDireccionOperador.Text == "")
                {
                    MessageBox.Show("Hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (val.ValidarEmail(TxtEmailOperador.Text))
                {
                    if (usu.InsertarOperador(Convert.ToString(TxtDocOperador.Text), Convert.ToString(TxtPasswordOperador.Text), Convert.ToString(TxtNombresOperador.Text), Convert.ToString(TxtApellidosOperador.Text), Convert.ToString(CmbGeneroOperador.SelectedValue), Convert.ToString(CmbEstadoOperador.SelectedValue), Convert.ToString(CmbTipoOperador.SelectedValue), Convert.ToString(TxtTelefonoOperador.Text), Convert.ToString(TxtMovilOperador.Text), Convert.ToString(TxtEmailOperador.Text), Convert.ToString(TxtCiudadOperador.Text), Convert.ToString(TxtDireccionOperador.Text), ImageToByteArray(Psave.Image)))
                    {
                        MessageBox.Show("Usuario Registrado exitosamente", " Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, Gbdatosoperadores);
                        Psave.Image = null;
                        Pfoto.Image = null;
                        Webcam.Stop();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnConsultarOPerario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDocOperador.Text == "")
                {
                    MessageBox.Show("El campo documento esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (usu.ConsultarOperarios(Convert.ToString(TxtDocOperador.Text)))
                {
                    TxtDocOperador.Text = usu._VDOC;
                    TxtPasswordOperador.Text = usu._VPASSWORDOP;
                    TxtNombresOperador.Text = usu._VNOMBREOP;
                    TxtApellidosOperador.Text = usu._VAPELLIDOSOP;
                    CmbGeneroOperador.SelectedValue = usu._VGENEROSOP;
                    CmbEstadoOperador.SelectedValue = usu._VESTADOOP;
                    CmbTipoOperador.SelectedValue = usu._VTIPOOP;
                    TxtTelefonoOperador.Text = usu._VTELEFONOOP;
                    TxtMovilOperador.Text = usu._VMOVILOP;
                    TxtEmailOperador.Text = usu._VEMAILOP;
                    TxtCiudadOperador.Text = usu._VCIUDADOP;
                    TxtDireccionOperador.Text = usu._VDIRECCIONOP;
                    Psave.Image = ByteArrayToImage(usu._FOTOPERADOR);
                }
                else
                {
                    MessageBox.Show("El Usuario no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDocOperador.Text == "")
                {
                    MessageBox.Show("Para eliminar por favor digite el numero de documento", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Eli.EliminarOperario(Convert.ToString(TxtDocOperador.Text)))
                {
                    MessageBox.Show("Cliente eliminado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtDocOperador.Text = "";
                    Psave.Image = null;
                    Pfoto.Image = null;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ImageToByteArray(Psave.Image);
                if (TxtDocOperador.Text == "" || TxtPasswordOperador.Text == "" || TxtNombresOperador.Text == "" || TxtApellidosOperador.Text == "" || CmbGeneroOperador.Text == "" || CmbEstadoOperador.Text == "" || CmbTipoOperador.Text == "" || TxtTelefonoOperador.Text == "" || TxtMovilOperador.Text == "" || TxtEmailOperador.Text == "" || TxtCiudadOperador.Text == "" || TxtDireccionOperador.Text == "")
                {
                    MessageBox.Show("Hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (val.ValidarEmail(TxtEmailOperador.Text))
                {
                    if (usu.ActualizarOperario(Convert.ToString(TxtDocOperador.Text), Convert.ToString(TxtPasswordOperador.Text), Convert.ToString(TxtNombresOperador.Text), Convert.ToString(TxtApellidosOperador.Text), Convert.ToString(CmbGeneroOperador.SelectedValue), Convert.ToString(CmbEstadoOperador.SelectedValue), Convert.ToString(CmbTipoOperador.SelectedValue), Convert.ToString(TxtTelefonoOperador.Text), Convert.ToString(TxtMovilOperador.Text), Convert.ToString(TxtEmailOperador.Text), Convert.ToString(TxtCiudadOperador.Text), Convert.ToString(TxtDireccionOperador.Text), ImageToByteArray(Psave.Image)))
                    {
                        MessageBox.Show("Usuario Actualizado exitosamente", " Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, Gbdatosoperadores);
                        Psave.Image = null;
                        Pfoto.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario", " Actualizacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btnopencam_Click(object sender, EventArgs e)
      {
          try
          {
                if (TxtDocOperador.Text == "" || TxtPasswordOperador.Text == "" || TxtNombresOperador.Text == "" || TxtApellidosOperador.Text == "" || CmbGeneroOperador.Text == "" || CmbEstadoOperador.Text == "" || CmbTipoOperador.Text == "" || TxtTelefonoOperador.Text == "" || TxtMovilOperador.Text == "" || TxtEmailOperador.Text == "" || TxtCiudadOperador.Text == "" || TxtDireccionOperador.Text == "")
                 {
                      MessageBox.Show("Para Abrir la camara primero rellene los datos", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else 
                 {              
                     Webcam.Start();
                 }  
            }
          catch(Exception ex)
          {
              MessageBox.Show(ex.Message ,"Ocurrio el siguiente error",MessageBoxButtons.OK,MessageBoxIcon.Error);
          }
      }
        private void Btncapturar_Click(object sender, EventArgs e)
          {
            try
            {
                Psave.Image = Pfoto.Image;
            }
            catch(Exception ex)
          {
              MessageBox.Show(ex.Message ,"Ocurrio el siguiente error",MessageBoxButtons.OK,MessageBoxIcon.Error);
          }
   }
       private void guardarFotoEnDiscoToolStripMenuItem_Click(object sender, EventArgs e)
      {
          try 
          {
              negocio.Helper.SaveImageCapture(Psave.Image);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
       private void configurarCamarToolStripMenuItem_Click(object sender, EventArgs e)
       {
           try 
           {
               Webcam.AdvanceSetting();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
       private void configurarVideoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           try 
           {
               Webcam.ResolutionSetting();   
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
       private void TxtDocOperador_TextChanged(object sender, EventArgs e)
       {
           if (TxtDocOperador.Text == "") 
           {
               val.LimpiarCampos(this, Gbdatosoperadores);
               Psave.Image = null;
           }
           
       }

       private void checkBox1_CheckedChanged(object sender, EventArgs e)
       {
           TxtPasswordOperador.UseSystemPasswordChar = !Cbhabilitar.Checked;
       }

    }

}
