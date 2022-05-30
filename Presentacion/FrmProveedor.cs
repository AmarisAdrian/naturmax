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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }
        Negocio.ProductosProveedor pv = new ProductosProveedor();
        Negocio.Validaciones val = new Negocio.Validaciones();
        private void BtnInsertarproveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTIdProveedor.Text == "" || TxtNombreproveedor.Text == "" || TxtDireccionProveedor.Text == "" || TxtTelefonoProveedor.Text == "" || TxtEmailProveedor.Text == "" || TxtRutProveedor.Text == "" || TxtNombreContacto.Text == "" || TxtTelefonoContacto.Text == "" || TxtEmailContacto.Text == "" || Txtciudad.Text == "")
                {
                    MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (val.ValidarEmail(TxtEmailContacto.Text))
                {
                    if (pv.InsertarProveedor(Convert.ToString(TXTIdProveedor.Text), Convert.ToString(TxtNombreproveedor.Text), Convert.ToString(TxtDireccionProveedor.Text), Convert.ToString(TxtTelefonoProveedor.Text), Convert.ToString(TxtEmailProveedor.Text), Convert.ToString(TxtRutProveedor.Text), Convert.ToString(TxtNombreContacto.Text), Convert.ToString(TxtTelefonoContacto.Text), Convert.ToString(TxtEmailContacto.Text), Convert.ToString(Txtciudad.Text), Convert.ToString(TxtDepartamento.Text)))
                    {
                        MessageBox.Show("Registros Insertado Exitosamente", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, GbDatosProveedor);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message ,"Error");
            }
        }
        private void BtnElliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTIdProveedor.Text == "")
                {
                    MessageBox.Show("Para eliminar ,Digite el ID del proveedor ,Este campo no puede ir vacio ", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (pv.EliminarProveedor(Convert.ToString(TXTIdProveedor.Text)))
                {
                    MessageBox.Show("Registros Eliminados exitosamente", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    val.LimpiarCampos(this, GbDatosProveedor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void BtnConsultarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTIdProveedor.Text == "")
                {
                    MessageBox.Show("Para consultar por favor digite el Id del proveedor", "Error de validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pv.ConsultarProveedor(Convert.ToString(TXTIdProveedor.Text)))
                {
                    TxtNombreproveedor.Text = pv._PNOMBRE;
                    TxtDireccionProveedor.Text = pv._PDIRECCION;
                    TxtTelefonoProveedor.Text = pv._PTELEFONO;
                    TxtEmailProveedor.Text = pv._PEMAIL;
                    TxtRutProveedor.Text = pv._PRUT;
                    TxtNombreContacto.Text = pv._PNOMBRECONTACTO;
                    TxtTelefonoContacto.Text = pv._PTELEFONOCONTACTO;
                    TxtEmailContacto.Text = pv._PEMAILCONTACTO;
                    Txtciudad.Text = pv._PCIUDAD;
                    TxtDepartamento.Text = pv._PDEPARTAMENTO;
                    pv.ConsultarListaProveedor(DgProveedor);
                }
                else
                {
                    MessageBox.Show("El proveedor no existe", "Error de validacion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void TXTIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtTelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTIdProveedor.Text == "" || TxtNombreproveedor.Text == "" || TxtDireccionProveedor.Text == "" || TxtTelefonoProveedor.Text == "" || TxtEmailProveedor.Text == "" || TxtRutProveedor.Text == "" || TxtNombreContacto.Text == "" || TxtTelefonoContacto.Text == "" || TxtEmailContacto.Text == "" || Txtciudad.Text == "")
                {
                    MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (val.ValidarEmail(TxtEmailContacto.Text))
                {
                    pv.ActualizarProveedor(Convert.ToString(TXTIdProveedor.Text), Convert.ToString(TxtNombreproveedor.Text), Convert.ToString(TxtDireccionProveedor.Text), Convert.ToString(TxtTelefonoProveedor.Text), Convert.ToString(TxtEmailProveedor.Text), Convert.ToString(TxtRutProveedor.Text), Convert.ToString(TxtNombreContacto.Text), Convert.ToString(TxtTelefonoContacto.Text), Convert.ToString(TxtEmailContacto.Text), Convert.ToString(Txtciudad.Text), Convert.ToString(TxtDepartamento.Text));
                    val.LimpiarCampos(this, GbDatosProveedor);
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void TXTIdProveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }
        }
    }
  

