using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }
        public string _Doc { get; set; }
        public string _User { get; set; }
        public string _Name { get; set; }
        public string _Last { get; set; }
        public string _Subtotal { get; set; }
        public string _Total { get; set; }
        public string _EnviarCantidad;


        Negocio.Usuario usu = new Negocio.Usuario();
        Negocio.Functions fun = new Negocio.Functions();
        Negocio.Seguridad safe = new Negocio.Seguridad();
        Negocio.Validaciones val = new Negocio.Validaciones();
        Negocio.ProcesoFacturacion facturacion = new Negocio.ProcesoFacturacion();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();

       
        private void Frmprincipal_Load(object sender, EventArgs e)
        {
            LblDocumento.Text = _Doc;
            LblNombres.Text = _Name;
            LblApellidos.Text = _Last;
            LblhoraI.Text = DateTime.Now.ToShortTimeString();
            IniciarTimer();
            AsignarPc();
            Pantalla();
            NumeroFactura();
            ValidarRegistro();
            ValidarCierre();

        }
        private void NumeroFactura() 
        {
            try
            {
                if (facturacion.ConsultarUltimaFactura())
                {
                    Txtnofac.Text = facturacion._ULTIMAFACTURA;
                    int cont = Convert.ToInt32(Txtnofac.Text);
                    cont = cont + 1;
                    Txtnofac.Text = string.Format("{0:000000000}", cont);
                }
            }
            catch(Exception)
            {
                Lblestado.Text = "Error al consultar ultima factura";
            }

        }
         private void ValidarRegistro()
        {
            FrmAbrirCaja frm = new FrmAbrirCaja();
            if (Auditoria.ValidarCaja(DtFechaFactura.Value))
            {
                int Switch = Convert.ToInt32(Auditoria._IdRegistroAbierto);
                if (Switch == 0)
                {
                    frm._Documento = LblDocumento.Text;
                    frm._Equipo = Lblpc.Text;
                    frm.Show();
                }
            }
        }   
        private void TxtDocClienteFactura_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 if (TxtDocClienteFactura.Text == "")
                 {
                     MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else if (usu.ConsultarCliente(Convert.ToString(TxtDocClienteFactura.Text)))
                 {
                     Txtnombres.Text = usu._NOMBRESCLIENTES;
                     Txtapellidos.Text = usu._APELLIDOSCLIENTES;
                     Txtdireccion.Text = usu._DIRECCIONCLIENTES;
                     Txttelefono2.Text = usu._TELEFONOCLIENTES;
                     Txtcelular2.Text = usu._CELULARCLIENTES;
                 }
                 else
                 {
                     MessageBox.Show(" ¡ El cliente no Existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
               
             }
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
        private void Txtreferencia_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
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
        private void AsignarPc()
        {
            fun.ObtenerNombreMaquina(Lblpc);
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           
            if (TxtDocClienteFactura.Text == "" || Txtreferencia.Text == "")
            {
                MessageBox.Show("Hay campos Vacios","Verificar Campos Vacios",MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
            }
            else 
            {
                facturacion.TotalViewFactura(DgViewFactura, Txtreferencia, Txtproducto, Txtcantidad, TxtprecioIva, TxtprecioUnitario, Txtimporte);
                facturacion.TotalFactura(DgViewFactura, Txtiva, Txttotalfactura, TxtSubtotalFactura);
                facturacion.FacturaRepetida(DgFactura, Txtnofac, TxtDocClienteFactura, Txtiva, TxtSubtotalFactura, Txttotalfactura, DtFechaFactura);
                facturacion.DetalleFactura(DgDetallesFactura, Txtnofac, Txtreferencia, Txtmarca, Txtimporte, TxtDescuento, Txtcantidad);
            }
        }
        private void referenciasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReferenciaProducto frm = new FrmReferenciaProducto();
            frm.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Recuerde que si desea cerrar sesion debe cerrar la caja", "¿Desea cerrar sesion?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                FrmCerrarSesion frm = new FrmCerrarSesion();
                LblHoraF.Text = DateTime.Now.ToShortTimeString();
                frm._EnviarDocumento = LblDocumento.Text;
                frm._EnviarHoraInicio = LblhoraI.Text;
                frm._EnviarHoraFin = LblHoraF.Text;
                frm.Show();
                this.Close();
                         
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Cod = 2;
            FrmCliente frm = new FrmCliente();
            frm._CodigoHabilitacion = Cod;
            frm.Show();
        }
        private void Txtreferencia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txtreferencia.Text == "")
                {
                    Txtproducto.Clear();
                    Txtnombrecategoria.Clear();
                    Txtnombremarca.Clear();
                    TxtprecioUnitario.Clear();
                    TxtprecioIva.Clear();
                    Txtcantidad.Clear();
                    Txtimporte.Clear();
                    TxtDescuento.Text = "0";
                }
                else if (fun.ConsultarProductos(Txtreferencia))
                {
                    Txtproducto.Text = fun._CONDESCRIPCION;
                    Txtcategoria.Text= fun._CONIDCATEGORIA;
                    Txtnombrecategoria.Text = fun._NOMBRECATEGORIA;
                    Txtnombremarca.Text = fun._NOMBREMARCA;
                    Txtmarca.Text = fun._CONIDMARCA;
                    TxtprecioUnitario.Text = fun._CONPRECIOU;
                    TxtprecioIva.Text = fun._CONPRECIOIVA;
                    Txtimporte.Text = TxtprecioIva.Text;
                    Txtcantidad.Text = "1";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ha ocurrido el siguiente error");
            }
        }

        private void Txtnofac_TextChanged(object sender, EventArgs e)
        {
            Txtnofac.Refresh();
        }
        private void Txtcantidad_TextChanged(object sender, EventArgs e)
        {
            double subtotal = 0;
            double subtotalfinal = 0;
            double iva = 0;
            double ivatotal = 0;
            double total = 0;
            double totalfinal = 0;

            TxtSubtotalFactura.Text = TxtprecioUnitario.Text;
            if (Txtreferencia.Text == "")
            {
                Txtcantidad.Text = "0";
            }
            else if (Txtcantidad.Text == "")
            {
                Txttotaliva.Clear();
                TxtSubtotalFactura.Clear();
                Txtimporte.Clear();
            }
            else
            {
                subtotal = double.Parse(TxtSubtotalFactura.Text) * Convert.ToDouble(Txtcantidad.Text);
                subtotalfinal = Convert.ToDouble(TxtprecioUnitario.Text) * Convert.ToDouble(Txtcantidad.Text);
                iva = double.Parse(Txtiva.Text);
                ivatotal = iva / 100;
                total = ivatotal * subtotal;
                totalfinal = total + subtotal;
                TxtSubtotalFactura.Text = Convert.ToString(subtotalfinal);
                Txttotaliva.Text = Convert.ToString(totalfinal);
                Txtimporte.Text = Convert.ToString(total);
            }
        }
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            int i = 0;        
            EliminarFilasVacias();
 
                try
                {
                    if (Convert.ToString(DgViewFactura[i, 0].Value) == "")
                    {
                        MessageBox.Show("Para registrar un usuario agregue los datos requeridos en la grilla,pulsando el boton agregar");
                    }
                    else if (facturacion.Guardarfactura(DgFactura) && (facturacion.GuardarDetallefactura(DgDetallesFactura)) && fun.GuardarControlFactura(Convert.ToString(Txtnofac.Text), Convert.ToString(LblDocumento.Text), Convert.ToString(Lblpc.Text)))
                    {   
                          MessageBox.Show("IMPRIMIENDO ....", "Facturacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          Lblestado.Text = "Estado:Control Actualizado";
                          Limpiar();
                          NumeroFactura();                                              
                    }                
                    else
                    {
                        MessageBox.Show("No pudo guardarse la factura", "Facturacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Lblestado.Text = "Estado:No se pudo actualizar los registros ";
                        Guardarlogs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No pudo guardarse la factura");
                    Guardarlogs();                  
                }
        }
        private void Limpiar()
        {

            TxtDocClienteFactura.Clear();
            Txtnombres.Clear();
            Txtapellidos.Clear();
            Txtdireccion.Clear();
            Txttelefono2.Clear();
            Txtcelular2.Clear();
            TxtprecioIva.Clear();
            Txtreferencia.Clear();
            Txtproducto.Clear();
            Txtcategoria.Clear();
            Txtmarca.Clear();
            TxtprecioUnitario.Clear();
            Txtcantidad.Text = "0";
            TxtDescuento.Text = "0";
            Txttotaliva.Clear();
            Txtimporte.Clear();
            TxtSubtotalFactura.Clear();
            Txttotalfactura.Clear();
            DgFactura.Rows.Clear();
            DgDetallesFactura.Rows.Clear();
            DgViewFactura.Rows.Clear();
        }
        private void ComprobarConexion()
        {
            try
            {
                if (safe.ConexionDatos())
                {
                    Lblestado.Text = "Estado de Conexion: Conectado";
                }
                else
                {
                    Lblestado.Text = "Estado de Conexion: No Conectado";
                }
            }
            catch (Exception)
            {
                Lblestado.Text = "Estado de Conexion: Error de la conexion";
            }
            DgDetallesFactura.AllowUserToAddRows = true;
        }
        private void Pantalla()
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.DgViewFactura.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.DgViewFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
        }
        private void IniciarTimer()
        {
            Timer t1 = new Timer();
            t1.Interval = 420000;
            t1.Tick += Timer_Tick;
            t1.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            ComprobarConexion();
            try
            {
                if (fun.RegistroDia(Convert.ToString(DtFechaFactura.Value.ToShortDateString())) && (fun.ErroresDia(Convert.ToString(DtFechaFactura.Value.ToShortDateString()))))
                {
                    LblFacturas.Text = fun._RegistroDia;
                    Lblfacturasfallidas.Text = fun._ErroresDia;                   
                }
               else if (fun.ConsultarErrorFacturas(Txtnofac, Lblerrorlog))
               {
                   Lblerrorlog.Text = fun._ErrorFactura;
               }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message ,"Ocurrio el siguiente problema");
            }
        }
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            if (TxtDocClienteFactura.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usu.ConsultarCliente(Convert.ToString(TxtDocClienteFactura.Text)))
            {
                Txtnombres.Text = usu._NOMBRESCLIENTES;
                Txtapellidos.Text = usu._APELLIDOSCLIENTES;
                Txtdireccion.Text = usu._DIRECCIONCLIENTES;
                Txttelefono2.Text = usu._TELEFONOCLIENTES;
                Txtcelular2.Text = usu._CELULARCLIENTES;
            }
            else
            {
                MessageBox.Show(" ¡ El cliente no Existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        private void Cbdescuento_CheckedChanged(object sender, EventArgs e)
        {
            double descuento = 0;
            double op = 0;
            double precioi = 0;
            double preciof = 0;
            double total = 0;
            double importe = 0;
            if (Cbdescuento.Checked)
            {
                if (TxtDescuento.Text == "")
                {
                    importe = Convert.ToDouble(TxtprecioIva.Text) * Convert.ToDouble(Txtcantidad.Text);
                    Txtimporte.Text = Convert.ToString(importe);
                }
                else
                {
                    descuento = Convert.ToDouble(TxtDescuento.Text);
                    precioi = Convert.ToDouble(Txtimporte.Text);
                    op = descuento / 100;
                    preciof = op * precioi;
                    total = precioi - preciof;
                    Txtimporte.Text = Convert.ToString(total);
                }
            }
            else
            {
                TxtDescuento.Text = "0";
                importe = Convert.ToDouble(TxtprecioIva.Text) * Convert.ToDouble(Txtcantidad.Text);
                Txtimporte.Text = Convert.ToString(importe);
            }
        }
        private void EliminarFilasVacias() 
        {
            DgDetallesFactura.AllowUserToAddRows = false;
            List<DataGridViewRow> rowsDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in DgDetallesFactura.Rows)
            {
                bool hascontent = false;
                foreach (DataGridViewColumn col in DgDetallesFactura.Columns)
                {
                    if (Convert.ToString(fila.Cells[col.Index].Value) != "")
                    {
                        hascontent = true;
                        break;
                    }
                }

                if (!hascontent)
                {
                    rowsDelete.Add(fila);
                }
            }
            foreach (var item in rowsDelete)
            {
                DgDetallesFactura.Rows.Remove(item);
            }
        }
        private void Btnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Guardarlogs() 
        {
            int cont = Convert.ToInt32(Lblfacturasfallidas.Text);
            int contlog = Convert.ToInt32(Lblerrorlog.Text);
            contlog = contlog + 1;
            cont = cont + 1;
            Lblerrorlog.Text = Convert.ToString(contlog);
            Lblfacturasfallidas.Text = Convert.ToString(cont);
            
            try 
            {
                if (fun.ErroresDia(Txtnofac, Lblerrorlog, DtFechaFactura.Value))
                {
                    Lblestado.Text = "Estado:Se ha actualizado el registro de errores ";
                }
                else 
                {
                    Lblestado.Text = "Estado:No pudo actualizarse el regitro de errores ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Ha ocurrido el siguiente problema");
            }
        }
        private void facturasProcesadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarFactura frm = new FrmConsultarFactura();
            frm.Show();
        }
        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidarCierre();
        }

        private void Txtcantidad_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void TxtDescuento_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void ValidarCierre() 
        {
            FrmCerrarCaja Caja = new FrmCerrarCaja();         
            if (Auditoria.ValidarCerrarCaja(DtFechaFactura.Value))
            {
                int Switch = Convert.ToInt32(Auditoria._IdRegistroAbierto);         
                if (Switch == 1)
                {
                    Caja._Documento = LblDocumento.Text;
                    Caja._Equipo = Lblpc.Text;
                    Caja.Show();
                }
                else if (Switch == 2)
                {
                    Caja._Documento = LblDocumento.Text;
                    Caja._Equipo = Lblpc.Text;
                    MessageBox.Show("La caja se encuentra parcialmente cerrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    Caja.Show();
                }
                else if (Switch == 3)
                {
                    MessageBox.Show("La caja fue cerrada totalmente , por favor cierre sesión", "Error al cerrar la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnAgregar.Enabled = false;
                    BtnGuardarFactura.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error ,contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {      
               MessageBox.Show("Por favor abra la caja ", "Abrir la caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarContraseña frm = new FrmCambiarContraseña();
            frm._Documento = LblDocumento.Text;
            frm.Show();
        }
        public void Impresion(DataGridView DgViewFactura) 
        {
            DataTable dt1 = new DataTable();
            foreach (DataGridViewColumn columna in this.DgViewFactura.Columns)
            {
                DataColumn col = new DataColumn(columna.Name);
                dt1.Columns.Add(col);
            }
            foreach (DataGridViewRow fila in this.DgViewFactura.Rows)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = fila.Cells[0].Value.ToString();
                dr[1] = fila.Cells[1].Value.ToString();
                dt1.Rows.Add(dr);
            }

            _Subtotal = TxtSubtotalFactura.Text;
            _Total= Txttotalfactura.Text;
        }
      
    }
}

