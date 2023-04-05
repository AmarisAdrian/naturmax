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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        Negocio.Validaciones val = new Negocio.Validaciones();
        Negocio.Functions Cargar = new Negocio.Functions();
        Negocio.ProductosProveedor pv = new ProductosProveedor();
    private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            Pantalla();
        }
    private void CargarCombo()
        {
            Cargar.CargarComboProveedor(CmbProveedor);
            CmbProveedor.SelectedIndex = -1;
            Cargar.CargarComboCategoria(CmbCategoriaProducto);
            CmbCategoriaProducto.SelectedIndex = -1;
            Cargar.CargarComboMarca(Cmbmarca);
            Cmbmarca.SelectedIndex = -1;
        }
    private void Txtidmarca_KeyPress_1(object sender, KeyPressEventArgs e)
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
    private void TxtReferenciaCategoria_KeyPress(object sender, KeyPressEventArgs e)
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
    private void TxtReferenciaProducto_KeyPress(object sender, KeyPressEventArgs e)
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
    private void Txtstock_KeyPress(object sender, KeyPressEventArgs e)
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
    private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
    private void Txtprecioiva_KeyPress(object sender, KeyPressEventArgs e)
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
    private void ConsultarGeneral()
       {
           pv.ConsultarProductosGenerales(Dgproducto);
       }
    private void TxtPrecio_TextChanged(object sender, EventArgs e)
       {
           double preciofinal, precio = 0;
           if (TxtPrecio.Text == "")
           {
               Txtprecioiva.Clear();
           }
           else
           {
               precio = Convert.ToDouble(TxtPrecio.Text);
               preciofinal = Convert.ToDouble(precio) * 1.16;
               Txtprecioiva.Text = Convert.ToString(preciofinal);
           }
       }
    private void mostrarMasToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Size = new Size(607,955);
       }
    private void mostrarMenosToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Size = new Size(614, 759);
       }
    private void recargarToolStripMenuItem_Click(object sender, EventArgs e)
       {
           CargarCombo();
           this.Refresh();
           Application.DoEvents();
       }
    private void volverToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
       }
    private void Btninsertarmarca_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (Txtidmarca.Text == "" || Txtnombremarca.Text == "")
            {
                MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.InsertarMarca(Convert.ToString(Txtidmarca.Text), Convert.ToString(Txtnombremarca.Text)))
            {
                MessageBox.Show("Marca insertada exitosamente", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val.LimpiarCampos(this, GbMarca);
            }
            else
            {
                MessageBox.Show("No se pudo insertar la marca", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        } 
    }
    private void Btnconsultarmarca_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (Txtidmarca.Text == "")
            {
                MessageBox.Show("Para consultar una marca por favor digite el ID", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.ConsultarMarca(Convert.ToString(Txtidmarca.Text)))
            {
                Txtnombremarca.Text = pv._VNOMBREMARCA;
            }
            else
            {
                MessageBox.Show("¡ La marca no existe!", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtnombremarca.Clear();
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void Btneliminarmarca_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (Txtidmarca.Text == "")
            {
                MessageBox.Show("Para borrar una marca por favor digite el ID", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.EliminarMarca(Convert.ToString(Txtidmarca.Text)))
            {
                MessageBox.Show("La marca ha sido eliminada exitosamente","Proceso exitoso");
                val.LimpiarCampos(this, GbMarca);
            }
            else 
            {
                MessageBox.Show("Error al eliminar producto", "Proceso fallido");
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void btnactualizarmarca_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (Txtidmarca.Text == "" || Txtnombremarca.Text == "")
            {
                MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.ActualizarMarca(Convert.ToString(Txtidmarca.Text), Convert.ToString(Txtnombremarca.Text)))
            {
                MessageBox.Show("Se actualizo correctamente", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                val.LimpiarCampos(this, GbMarca);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el proceso"," Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void BtnInsertarCategoria_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaCategoria.Text == "" || TxtNombreCategoria.Text == "")
            {
                MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.InsertarCategoria(Convert.ToString(TxtReferenciaCategoria.Text), Convert.ToString(TxtNombreCategoria.Text)))
            {
                MessageBox.Show("Categoria insertada exitosamente", " Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val.LimpiarCampos(this, GbCategoriaProducto);
            }
            else 
            {
                MessageBox.Show("No se pudo insertar la categoria", " Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void BtnConsultarCategoria_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaCategoria.Text == "")
            {
                MessageBox.Show("Para consultar ,Digite el ID de la categoria ,Este campo no puede ir vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.ConsultarCategoria(Convert.ToString(TxtReferenciaCategoria.Text)))
            {
                TxtReferenciaCategoria.Text = pv._CIDCATEGORIA;
                TxtNombreCategoria.Text = pv._CNOMBRECATEGORIA;
            }
            else
            {
                MessageBox.Show("¡ La categoria no existe !", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombreCategoria.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void BtnEliminarCategoria_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaCategoria.Text == "")
            {
                MessageBox.Show("Para eliminar ,Digite el ID de la categoria ,Este campo no puede ir vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.EliminarCategoria(Convert.ToString(TxtReferenciaCategoria.Text)))
            {
                MessageBox.Show("la categoria se ha eliminado exitosamente","Proceso exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                val.LimpiarCampos(this, GbCategoriaProducto);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria", " Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void BtnActualizarCategoria_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaCategoria.Text == "" || TxtNombreCategoria.Text == "")
            {
                MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( pv.ActualizarCategoria(Convert.ToString(TxtReferenciaCategoria.Text), Convert.ToString(TxtNombreCategoria.Text)))
            {
                MessageBox.Show("Categoria actualizada exitosamente ","Proceso exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                val.LimpiarCampos(this, GbCategoriaProducto);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el proceso");
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void BtnInsertarProducto_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaProducto.Text == "" || CmbProveedor.SelectedIndex == -1 || CmbCategoriaProducto.SelectedIndex == -1 || RcDescripcion.Text == "" || Txtstock.Text == "" || TxtPrecio.Text == "")
            {
                MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.InsertarProducto(Convert.ToString(TxtReferenciaProducto.Text), Convert.ToString(CmbProveedor.SelectedValue), Convert.ToString(CmbCategoriaProducto.SelectedValue), Convert.ToString(Cmbmarca.SelectedValue), Convert.ToString(RcDescripcion.Text), Convert.ToString(Txtstock.Text), Convert.ToString(TxtPrecio.Text), Convert.ToString(Txtprecioiva.Text)))
            {
                MessageBox.Show("Productos insertado exitosamente", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                val.LimpiarCampos(this, GbProductos);
                RcDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo insertar el producto", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
        }
    }
    private void BtnConsultarProducto_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaProducto.Text == "")
            {
                MessageBox.Show("Para consultar ,Digite el ID del producto ,Este campo no puede ir vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pv.ConsultarProducto(Convert.ToString(TxtReferenciaProducto.Text)))
            {
                TxtReferenciaProducto.Text = pv._PROIDPRODUCTO;
                CmbProveedor.SelectedValue = pv._PROIDPROVEEDOR;
                CmbCategoriaProducto.SelectedValue = pv._PROIDCATEGORIA;
                Cmbmarca.SelectedValue = pv._PROIDMARCA;
                RcDescripcion.Text = pv._PRONOMBRE;
                Txtstock.Text = pv._PROSTOCK;
                TxtPrecio.Text = pv._PROPRECIOUNITARIO;
                Txtprecioiva.Text = pv._VPRECIOIVA;
                ConsultarGeneral();
            }
            else
            {
                MessageBox.Show("¡ El  producto no existe !", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbProveedor.SelectedIndex = -1;
                CmbCategoriaProducto.SelectedIndex = -1;
                Cmbmarca.SelectedIndex = -1;
                RcDescripcion.Clear();
                Txtstock.Clear();
                TxtPrecio.Clear();
                Txtprecioiva.Clear();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"ha ocurrido el siguiente error");
        }
    }
    private void BtnEliminarProducto_Click_1(object sender, EventArgs e)
    {
        try
        {
            if (TxtReferenciaProducto.Text == "")
            {
                MessageBox.Show("Para eliminar ,Digite el ID del producto ,Este campo no puede ir vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pv.EliminarProducto(Convert.ToString(TxtReferenciaProducto.Text)))
            {
                MessageBox.Show("referencia eliminada exitosamente");
                val.LimpiarCampos(this, GbProductos);
                RcDescripcion.Clear();
            }
            else            
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
        }
    }
    private void BtnActualizarProducto_Click_1(object sender, EventArgs e)
  {
      try
      {
          if (TxtReferenciaProducto.Text == "" || CmbProveedor.SelectedIndex == -1 || CmbCategoriaProducto.SelectedIndex == -1 || RcDescripcion.Text == "" || Txtstock.Text == "" || TxtPrecio.Text == "")
          {
              MessageBox.Show("hay campos vacios", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else if (pv.ActualizarProducto(Convert.ToString(TxtReferenciaProducto.Text), Convert.ToString(CmbProveedor.SelectedValue), Convert.ToString(CmbCategoriaProducto.SelectedValue), Convert.ToString(Cmbmarca.SelectedValue), Convert.ToString(RcDescripcion.Text), Convert.ToString(Txtstock.Text), Convert.ToString(TxtPrecio.Text), Convert.ToString(Txtprecioiva.Text)))
          {
              MessageBox.Show("Categoria Actualizada exitosamente", " Actualizar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
              val.LimpiarCampos(this, GbProductos);
              RcDescripcion.Clear();
          }
          else
          {
              MessageBox.Show("No se pudo actualizar el producto","Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
      catch (Exception ex)
      {
          MessageBox.Show(ex.Message, "ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
  }
    private void TxtPrecio_TextChanged_1(object sender, EventArgs e)
   {
       double preciofinal, precio = 0;
       if (TxtPrecio.Text == "")
       {
           Txtprecioiva.Clear();
       }
       else
       {
           precio = Convert.ToDouble(TxtPrecio.Text);
           preciofinal = Convert.ToDouble(precio) * 1.16;
           Txtprecioiva.Text = Convert.ToString(preciofinal);
       }
   }
    private void Pantalla()
    {
        this.Location = Screen.PrimaryScreen.WorkingArea.Location;
    }
    }
  }
