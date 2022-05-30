using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using AccesoDatos;

namespace Negocio
{
    public class ProcesoFacturacion
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public string _ULTIMAFACTURA;


        public bool ConsultarUltimaFactura()
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARULTIMAFACTURA", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _ULTIMAFACTURA = Convert.ToString(dr["NOFACTURA"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool Guardarfactura(DataGridView Dgfactura)
        {
            bool save = false;
            int i = 0;
            bd.Conectar();
            bd.CrearComando("INSERT INTO FACTURA (NOFACTURA,IDCLIENTE,IVA,SUBTOTAL,TOTALPAGAR,FECHA)VALUES(@NOFACTURA,@IDCLIENTE,@IVA,@SUBTOTAL,@TOTALPAGAR,@FECHA)", System.Data.CommandType.Text);
            bd.Asignarparametro("@NOFACTURA ", SqlDbType.VarChar, Dgfactura.Rows[i].Cells[0].Value.ToString());
            bd.Asignarparametro("@IDCLIENTE ", SqlDbType.BigInt, Dgfactura.Rows[i].Cells[1].Value.ToString());
            bd.Asignarparametro("@IVA ", SqlDbType.NVarChar, Dgfactura.Rows[i].Cells[2].Value.ToString());
            bd.Asignarparametro("@SUBTOTAL ", SqlDbType.Decimal, Dgfactura.Rows[i].Cells[3].Value.ToString());
            bd.Asignarparametro("@TOTALPAGAR ", SqlDbType.Decimal, Dgfactura.Rows[i].Cells[4].Value.ToString());
            bd.Asignarparametro("@FECHA ", SqlDbType.DateTime, Dgfactura.Rows[i].Cells[5].Value.ToString());
            int reg = 0;
            reg = bd.Ejecutarcomando();
            if (reg > 0)
            {
                save = true;
                i++;
            }
            else
            {
                save = false;
            }

            bd.Desconectar();
            return save;
        }
        public bool GuardarDetallefactura(DataGridView DgDetallesFactura)
        {
            bool guardar = false;
            int i = 0;
            try
            {
                foreach (DataGridViewRow Rows in DgDetallesFactura.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERTARDETALLE", CommandType.StoredProcedure);
                    bd.Asignarparametro("@NOFACTURA", SqlDbType.VarChar, DgDetallesFactura.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@IDPRODUCTO", SqlDbType.Int, DgDetallesFactura.Rows[i].Cells[1].Value.ToString());
                    bd.Asignarparametro("@IDMARCA", SqlDbType.VarChar, DgDetallesFactura.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@PRECIO", SqlDbType.Decimal, DgDetallesFactura.Rows[i].Cells[3].Value.ToString());
                    bd.Asignarparametro("@DESCUENTO", SqlDbType.Int, DgDetallesFactura.Rows[i].Cells[4].Value.ToString());
                    bd.Asignarparametro("@CANTIDAD", SqlDbType.NVarChar, DgDetallesFactura.Rows[i].Cells[5].Value.ToString());
                    int reg = 0;
                    reg = bd.Ejecutarcomando();
                    if (reg > 0)
                    {
                        guardar = true;
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                bd.Desconectar();
            }
            return guardar;
        }
        public bool ConsultarFactura(DataGridView DgExportar)
        {
            bool con = false;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM FACTURA");
            g.Cargar(DgExportar);
            return con;
        }
        public bool ConsultarDetalleFactura(DataGridView DgExportar)
        {
            bool con = false;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM DETALLEFACTURA");
            g.Cargar(DgExportar);
            return con;
        }
        public void TotalViewFactura(DataGridView DgViewFactura, TextBox Txtreferencia, TextBox Txtproducto, TextBox Txtcantidad, TextBox TxtprecioUnitario, TextBox TxtprecioIva, TextBox Txtimporte)
        {
            double Cantidad = 0;
            double total = 0;
            bool agregar = false;
            int i = 0;
            try
            {

                while (DgViewFactura[0, i].Value != null)
                {
                    if (Convert.ToString(DgViewFactura[0, i].Value) == Convert.ToString(Txtreferencia.Text))
                    {
                        Cantidad = Convert.ToDouble(DgViewFactura[2, i].Value) + Convert.ToDouble(Txtcantidad.Text);
                        DgViewFactura[2, i].Value = Convert.ToString(Cantidad);
                        total = Convert.ToDouble(Txtimporte.Text) * Convert.ToDouble(Cantidad);
                        DgViewFactura[4, i].Value = Convert.ToString(total);
                        agregar = true;
                    }
                    i++;
                }
                if (agregar == false)
                {

                    DgViewFactura.Rows.Add(Txtreferencia.Text, Txtproducto.Text, Txtcantidad.Text, TxtprecioUnitario.Text, Txtimporte.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void TotalFactura(DataGridView DgViewFactura,TextBox Txtiva, TextBox TxtTotalFactura,TextBox TxtSubtotalFactura)
        {
            double total = 0;
            double subtotal = 0;
            double iva = 0;
            foreach (DataGridViewRow row in DgViewFactura.Rows)
            {
                total += Convert.ToDouble(row.Cells["Totalview"].Value);
            }
            iva = double.Parse(Txtiva.Text) / 100;
            subtotal =  total/ iva ;
            TxtSubtotalFactura.Text = Convert.ToString(subtotal) ;
            TxtTotalFactura.Text = Convert.ToString(total);
        }
        public void FacturaRepetida(DataGridView DgFactura, TextBox Txtnofac, TextBox TxtDocClienteFactura, TextBox Txtiva, TextBox TxtSubtotalFactura, TextBox Txttotalfactura, DateTimePicker DtFechaFactura)
        {
            int i = 0;
            bool permitir = false;
            while (DgFactura[0, i].Value != null)
            {
                if (Convert.ToString(DgFactura[0, i].Value) == Convert.ToString(Txtnofac.Text))
                {
                    DgFactura[3, i].Value = TxtSubtotalFactura.Text;
                    DgFactura[4, i].Value = Txttotalfactura.Text;
                    permitir = true;
                } 
                i++;
            }
            if (permitir == false)
            {
                DgFactura.Rows.Add(Txtnofac.Text, TxtDocClienteFactura.Text, Txtiva.Text, TxtSubtotalFactura.Text, Txttotalfactura.Text, DtFechaFactura.Text);
            }
        }
        public void DetalleFactura(DataGridView DgDetallesFactura, TextBox Txtnofac, TextBox Txtreferencia, TextBox Txtmarca, TextBox Txtdescuento, TextBox TxtprecioUnitario, TextBox Txtcantidad)
        {
            int i = 0;
            double Cantidad = 0;
            bool permitir = false;
            while (DgDetallesFactura[0, i].Value != null)
            {
            if (Convert.ToString(DgDetallesFactura[1, i].Value) == Convert.ToString(Txtreferencia.Text))
                {
                    Cantidad = Convert.ToDouble(DgDetallesFactura[5, i].Value) + Convert.ToDouble(Txtcantidad.Text);
                    DgDetallesFactura[5, i].Value = Convert.ToString(Cantidad);
                    permitir = true;
                }
            i++;
            }
            if (permitir == false)
            {
                DgDetallesFactura.Rows.Add(Txtnofac.Text, Txtreferencia.Text, Txtmarca.Text, Txtdescuento.Text, TxtprecioUnitario.Text, Txtcantidad.Text);
            }
        }


    }
}
