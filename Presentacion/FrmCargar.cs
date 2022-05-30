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
    public partial class FrmCargar : Form
    {
        public FrmCargar()
        {
            InitializeComponent();
        }
        Negocio.Functions fun = new Negocio.Functions();
        Negocio.Validaciones val = new Negocio.Validaciones();
        Negocio.Usuario usu = new Negocio.Usuario();
        Negocio.ProductosProveedor pv = new Negocio.ProductosProveedor();
        Negocio.ProcesoFacturacion facturacion = new Negocio.ProcesoFacturacion();
        private void FrmCargar_Load(object sender, EventArgs e)
        {
            DeshabilitarRadiobutton();
            Rbexcliente.Checked = true;
        }
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string hoja;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            dialog.Title = "Seleccione el archivo de Excel";
            dialog.FileName = string.Empty;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Txtruta.Text = dialog.FileName;
                hoja = txthoja.Text;
            }
        }
        private void Btnimportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtruta.Text == ""||txthoja.Text=="")
                {
                    MessageBox.Show("Por favor cargue el libro y coloque el nombre de la otra hoja,estos campos no pueden ir vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (fun.importarExcel(Dgimportar, Convert.ToString(Txtruta.Text), Convert.ToString(txthoja.Text)))
                {
                    Lblestado.Text = "Estado: Cargado Correctamente";
                    this.Dgimportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                    this.Dgimportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente evento");
            }

            int cont = Dgimportar.ColumnCount;
            if (cont > 0)
            {
                AsignarRadiobutton();
            }
        }
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txthoja.Clear();
            Txtruta.Clear();
        }
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Rbclientes.Checked)
            {
                try
                {
                    if (usu.InsertarCliente(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbfactura.Checked)
            {
                try
                {
                    if (facturacion.Guardarfactura(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbdetallefactura.Checked)
            {
                try
                {
                    if (facturacion.GuardarDetallefactura(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rboperador.Checked)
            {
                try
                {
                    if (usu.InsertarOperador(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbproductos.Checked)
            {
                try
                {
                    if (pv.InsertarProducto(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbproveedores.Checked)
            {
                try
                {
                    if (pv.InsertarProveedor(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbmarcas.Checked)
            {
                try
                {
                    if (pv.InsertarMarca(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbcategorias.Checked)
            {
                try
                {
                    if (pv.InsertarCategoria(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbcontrol.Checked)
            {
                try
                {
                    if (pv.ControlOperador(Dgimportar))
                    {
                        MessageBox.Show("la informacion se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos a guardar no existan y concuerde con la tabla de informacion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
          }
        }
        private void AsignarRadiobutton()
        {
            int num = Dgimportar.ColumnCount;
            if (num == 2)
            {
                Rbmarcas.Enabled = true;
                Rbcategorias.Enabled = true;
                Rbfactura.Enabled = false;
                Rbclientes.Enabled = false;
                Rbproductos.Enabled = false;
                Rbproveedores.Enabled = false;
                Rboperador.Enabled = false;
                Rbdetallefactura.Enabled = false;
            }
            if (num == 6)
            {
                Rbdetallefactura.Enabled = true;
                Rbfactura.Enabled = true;
                Rbclientes.Enabled = true;
                Rbproductos.Enabled = false;
                Rbproveedores.Enabled = false;
                Rboperador.Enabled = false;
                Rbmarcas.Enabled = false;
                Rbcategorias.Enabled = false;
            }
            if (num == 8)
            {
                Rbproductos.Enabled = true;
                Rbmarcas.Enabled = false;
                Rbcategorias.Enabled = false;
                Rbfactura.Enabled = false;
                Rbclientes.Enabled = false;
                Rbproveedores.Enabled = false;
                Rboperador.Enabled = false;
                Rbdetallefactura.Enabled = false;
            }
            if (num == 11)
            {
                Rbproveedores.Enabled = true;
                Rbproductos.Enabled = false;
                Rbmarcas.Enabled = false;
                Rbcategorias.Enabled = false;
                Rbfactura.Enabled = false;
                Rbclientes.Enabled = false;
                Rboperador.Enabled = false;
                Rbdetallefactura.Enabled = false;
            }
            if (num == 14)
            {
                Rboperador.Enabled = true;
                Rbproveedores.Enabled = false;
                Rbproductos.Enabled = false;
                Rbmarcas.Enabled = false;
                Rbcategorias.Enabled = false;
                Rbfactura.Enabled = false;
                Rbclientes.Enabled = false;
                Rbdetallefactura.Enabled = false;
            }
            if(num >14)
            {
                DeshabilitarRadiobutton();
                MessageBox.Show("No hay tablas relacionadas con el archivo cargado","Datos cargados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void habilitarRadiobutton()
        {
            Rbclientes.Enabled = true;
            Rbfactura.Enabled = true;
            Rboperador.Enabled = true;
            Rbproductos.Enabled = true;
            Rbproveedores.Enabled = true;
            Rbmarcas.Enabled = true;
            Rbcategorias.Enabled = true;
            Rbcontrol.Enabled = true;
        }
        private void DeshabilitarRadiobutton()
        {
            Rbclientes.Enabled = false;
            Rbfactura.Enabled = false;
            Rboperador.Enabled = false;
            Rbproductos.Enabled = false;
            Rbproveedores.Enabled = false;
            Rbmarcas.Enabled = false;
            Rbcategorias.Enabled = false;
            Rbcontrol.Enabled = false;
            Rbdetallefactura.Enabled = false;
        }
        private void Btnexportar_Click(object sender, EventArgs e)
        {
            if (Rbexcliente.Checked)
            {
                try
                {
                    if (usu.ConsultarCliente(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexfactura.Checked)
            {
                try
                {
                    if (facturacion.ConsultarFactura(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexdetalle.Checked)
            {
                try
                {
                    if (facturacion.ConsultarDetalleFactura(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexoperadores.Checked)
            {
                try
                {
                    if (usu.ConsultarOperarios(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexproductos.Checked)
            {
                try
                {
                    if (pv.ConsultarProducto(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexproveedores.Checked)
            {
                try
                {
                    if (pv.ConsultarProveedor(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexmarcas.Checked)
            {
                try
                {
                    if (pv.ConsultarMarca(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexcategorias.Checked)
            {
                try
                {
                    if (pv.ConsultarCategoria(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
            else if (Rbexcontrol.Checked)
            {
                try
                {
                    if (usu.ConsultarControlOperarios(Dgexportar))
                    {
                        Lblestado.Text = "Estado : Datos cargados correctamente";
                        this.Dgexportar.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                        this.Dgexportar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        Lblestado.Text = "Estado : Los datos no pudieron cargarse";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar la informacion");
                }
            }
        }
        private void Btnexportarexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtguardar.Text == "")
                {
                    MessageBox.Show("Por favor coloque el nombre al archivo ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Dgexportar.Rows.Count == 0)
                {
                    MessageBox.Show("Cargue los datos a exportar en la grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    fun.ExportarExcel(Dgexportar, Txtguardar);
                }           
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void Btnexlimpiar_Click(object sender, EventArgs e)
        {
            Rbexcliente.Checked = true;
            Txtguardar.Clear();
        }
    }                            
}
