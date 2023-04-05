using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using AccesoDatos;

namespace Negocio
{
    public class Auditoria
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public string _DocumentoOPerador;
        public string _Nofactura;
        public string _NombreOPerador;
        public string _ApellidosOPerador;
        public string _FacturasGeneradas;
        public string _IngresoInicial;
        public string _Total;
        public string _UltimoCierre;
        public string _UltimoIdRegistro;
        public string _UltimoIdControl;
        public string _IdCaja,_Fecha,_MontoA,_MontoI,_HoraI,_Estado,_MontoR,_HoraF,_IdEstado;
        public string _IdRegistroAbierto;
        public string _Password , _TipoUsuario;
        //-------------------------//----------------------------------------------//-----------------------------------------//
       

        public bool ConsultarFactura(DataGridView Dgfactura, TextBox Txtdocumento)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            Dgfactura.DataSource = null;
            g.Preparar("SELECT NOFACTURA,IDCLIENTE,IVA,SUBTOTAL,TOTALPAGAR,FECHA FROM FACTURA WHERE IDCLIENTE='" + Txtdocumento.Text + " '");
            g.Cargar(Dgfactura);
            cargar = true;
            return cargar;
        }
        public bool ConsultarDetalleFactura(DataGridView Dgdetallefactura, string Nofactura)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            Dgdetallefactura.DataSource = null;
            g.Preparar("CONSULTARDETALLEFACTURA'" + Nofactura + " '");
            g.Cargar(Dgdetallefactura);
            cargar = true;
            return cargar;
        }
        public bool ConsultarOPeradorFactura(string Numero)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARDOPERADORFACTURA", CommandType.StoredProcedure);
                bd.Asignarparametro("@NOFACTURA", SqlDbType.VarChar, Numero);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _NombreOPerador = Convert.ToString(dr["NOMBRESOPERADOR"]);
                    _ApellidosOPerador = Convert.ToString(dr["APELLIDOSOPERADOR"]);
                    cargar = true;
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

            return cargar;
        }
        public bool ConsultarCerrarCaja(DateTime Fecha)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARCAJA", CommandType.StoredProcedure);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, Fecha);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _IdRegistroAbierto = Convert.ToString(dr["IDREGISTRO"]);
                    _DocumentoOPerador = Convert.ToString(dr["NODOCUMENTO"]);
                    _IdCaja = Convert.ToString(dr["IDCAJA"]);
                    _Total = Convert.ToString(dr["TOTALGENERADO"]);
                    cargar = true;
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
            return cargar;
        }
        public bool CerrarCaja(TextBox TxtIdregistro, TextBox TxtFacturasGeneradas, TextBox TxtMontoRetirar, Label lblHoraF, TextBox TxtSaldoGuardar)
        {
            bool Save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CERRARCAJA(IDREGISTRO,FACTURASG,MONTOR,HORAF,TOTAL)VALUES(@IDREGISTRO,@FACTURASG,@MONTOR,@HORAF,@TOTAL)", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.VarChar, TxtIdregistro.Text);
                bd.Asignarparametro("@FACTURASG", SqlDbType.Int, TxtFacturasGeneradas.Text);
                bd.Asignarparametro("@MONTOR", SqlDbType.Decimal, TxtMontoRetirar.Text);
                bd.Asignarparametro("@HORAF", SqlDbType.Time, lblHoraF.Text);
                bd.Asignarparametro("@TOTAL", SqlDbType.Int, TxtSaldoGuardar.Text);
                int reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Save = true;
                }
                else if (BaseDatos.CodeBdError == -2146232060)
                {
                    if (ActualizacionCerrarCaja(TxtIdregistro, TxtFacturasGeneradas, TxtMontoRetirar, lblHoraF, TxtSaldoGuardar))
                    {
                        Save = true;
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
            return Save;
        }
        public bool ActualizacionCerrarCaja(TextBox TxtIdregistro, TextBox TxtFacturasGeneradas, TextBox TxtMontoRetirar, Label lblHoraF, TextBox TxtSaldoGuardar)
        {
            bool Save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CERRARCAJA SET [IDREGISTRO]=@IDREGISTRO,[FACTURASG]=@FACTURASG,[MONTOR]=@MONTOR,[HORAF]=@HORAF,[TOTAL]=@TOTAL WHERE [IDREGISTRO]=@IDREGISTRO", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.VarChar, TxtIdregistro.Text);
                bd.Asignarparametro("@FACTURASG", SqlDbType.Int, TxtFacturasGeneradas.Text);
                bd.Asignarparametro("@MONTOR", SqlDbType.Decimal, TxtMontoRetirar.Text);
                bd.Asignarparametro("@HORAF", SqlDbType.Time, lblHoraF.Text);
                bd.Asignarparametro("@TOTAL", SqlDbType.Int, TxtSaldoGuardar.Text);
                int reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Save = true;
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
            return Save;
        }
        public bool ActualizacionCerrarCaja(TextBox TxtIdregistro, TextBox TxtFacturasGeneradas, TextBox TxtMontoRetirar, TextBox lblHoraF, TextBox TxtSaldoGuardar)
        {
            bool Save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CERRARCAJA SET [IDREGISTRO]=@IDREGISTRO,[FACTURASG]=@FACTURASG,[MONTOR]=@MONTOR,[HORAF]=@HORAF,[TOTAL]=@TOTAL WHERE [IDREGISTRO]=@IDREGISTRO", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.VarChar, TxtIdregistro.Text);
                bd.Asignarparametro("@FACTURASG", SqlDbType.Int, TxtFacturasGeneradas.Text);
                bd.Asignarparametro("@MONTOR", SqlDbType.Decimal, TxtMontoRetirar.Text);
                bd.Asignarparametro("@HORAF", SqlDbType.Time, lblHoraF.Text);
                bd.Asignarparametro("@TOTAL", SqlDbType.Int, TxtSaldoGuardar.Text);
                int reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Save = true;
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
            return Save;
        }
        public bool ActualizacionEstadoDeCierre(TextBox TxtIdregistro, ComboBox CmbCerrado)
        {
            bool Save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE REGISTROCAJA SET [IDESTADO]=@IDESTADO WHERE [IDREGISTRO]=@IDREGISTRO", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.VarChar, TxtIdregistro.Text);
                bd.Asignarparametro("@IDESTADO", SqlDbType.Int, CmbCerrado.SelectedValue);
                int reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Save = true;
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
            return Save;
        }
        public bool UltimoCierre()
        {
            bool consulta = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARCIERRE", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCierre = Convert.ToString(dr["TOTAL"]);
                    consulta = true;
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
            return consulta;
        }
        public bool UltimoRegistro()
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARULTIMOREGISTRO", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoIdRegistro = Convert.ToString(dr["IDREGISTRO"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool UltimoControlOperador()
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARULTIMOIDCONTROL", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoIdControl = Convert.ToString(dr["IDCONTROL"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool AbrirCaja(TextBox Txtregistro, TextBox Txtsaldoanterior, TextBox TxtIngresarMonto, Label lblHora)
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO ABRIRCAJA(IDREGISTRO,MONTOA,MONTOI,HORAI)VALUES(@IDREGISTRO,@MONTOA,@MONTOI,@HORAI)", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.BigInt, Txtregistro.Text);
                bd.Asignarparametro("@MONTOA", SqlDbType.Decimal, Txtsaldoanterior.Text);
                bd.Asignarparametro("@MONTOI", SqlDbType.Decimal, TxtIngresarMonto.Text);
                bd.Asignarparametro("@HORAI", SqlDbType.Time, lblHora.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    save = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return save;
        }
        public bool AbrirRegistro(TextBox Txtregistro, ComboBox Cmbestado,TextBox Txtequipo, TextBox Txtdocumento, DateTime Dtfecha)
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO REGISTROCAJA(IDREGISTRO,IDCAJA,IDESTADO,DOCUMENTO,FECHA)VALUES(@IDREGISTRO,@IDCAJA,@IDESTADO,@DOCUMENTO,@FECHA)", CommandType.Text);
                bd.Asignarparametro("@IDREGISTRO", SqlDbType.BigInt, Txtregistro.Text);
                bd.Asignarparametro("@IDCAJA", SqlDbType.VarChar, Txtequipo.Text);
                bd.Asignarparametro("@IDESTADO", SqlDbType.BigInt, Cmbestado.SelectedValue);
                bd.Asignarparametro("@DOCUMENTO", SqlDbType.BigInt, Txtdocumento.Text);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, Dtfecha);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    save = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return save;
        }
        public bool ValidarCaja(DateTime Fecha)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("VALIDARABRIRCAJA", CommandType.StoredProcedure);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, Fecha);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _IdRegistroAbierto = Convert.ToString(dr["NUMERO"]);
                    cargar = true;
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
            return cargar;
        }
        public bool ValidarCerrarCaja(DateTime Fecha)
        {
            int Var = 0;
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("VALIDARCERRARCAJA", CommandType.StoredProcedure);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, Fecha);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _IdRegistroAbierto = Convert.ToString(dr["NUMERO"]);
                    cargar = true;
                }
                else 
                {
                    _IdRegistroAbierto = Convert.ToString(Var);
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
            return cargar;
        }
        public bool EstadoDecaja(DataGridView Dgcajas)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            Dgcajas.DataSource = null;
            g.Preparar("ESTADOACTUALCAJA");
            g.Cargar(Dgcajas);
            cargar = true;
            return cargar;
        }
        public bool EstadoCierreSesion(DataGridView DgControlCierre)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            DgControlCierre.DataSource = null;
            g.Preparar("ESTADOACTUALSESION");
            g.Cargar(DgControlCierre);
            cargar = true;
            return cargar;
        }
        public bool EstadoCierreSesion(DataGridView DgControlCierre, TextBox TxtBuscarDocumento)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            DgControlCierre.DataSource = null;
            g.Preparar("ESTADOACTUALSESIONFILTRO'" + TxtBuscarDocumento.Text + " '");
            g.Cargar(DgControlCierre);
            cargar = true;
            return cargar;
        }
        public bool EstadoControlfactura(DataGridView DgcontrolFactura)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            DgcontrolFactura.DataSource = null;
            g.Preparar("CONSULTACONTROLFACTURA");
            g.Cargar(DgcontrolFactura);
            cargar = true;
            return cargar;
        }
        public bool EstadoControlfacturaFecha(DataGridView DgcontrolFactura)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            DgcontrolFactura.DataSource = null;
            g.Preparar("CONSULTACONTROLFACTURAFECHA");
            g.Cargar(DgcontrolFactura);
            cargar = true;
            return cargar;
        }
        public bool EstadoControlfactura(DataGridView DgcontrolFactura,TextBox TxtDocumentoFactura)
        {
            bool cargar = false;
            CargarGrilla g = new CargarGrilla();
            DgcontrolFactura.DataSource = null;
            g.Preparar("CONSULTACONTROLFACTURADOCUMENTO '" + TxtDocumentoFactura.Text + " '");
            g.Cargar(DgcontrolFactura);
            cargar = true;
            return cargar;
        }
        public bool EstadoDeCierre(TextBox TxtNumero,DateTime Fecha)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("ESTADODECIERRE", CommandType.StoredProcedure);
                bd.Asignarparametro("@NUMERO", SqlDbType.Int, TxtNumero.Text);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, Fecha);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoIdRegistro = Convert.ToString(dr["IDREGISTRO"]);
                    _DocumentoOPerador = Convert.ToString(dr["DOCUMENTO"]);
                    _Fecha = Convert.ToString(dr["FECHA"]);
                    _MontoA = Convert.ToString(dr["MONTOA"]);
                    _MontoI = Convert.ToString(dr["MONTOI"]);
                    _HoraI = Convert.ToString(dr["HORAI"]);
                    _Estado = Convert.ToString(dr["ESTADO"]);
                    _FacturasGeneradas = Convert.ToString(dr["FACTURASG"]);
                    _MontoR = Convert.ToString(dr["MONTOR"]);
                    _HoraF = Convert.ToString(dr["HORAF"]);
                    _Total = Convert.ToString(dr["TOTAL"]);

                    cargar = true;
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
            return cargar;
        }
        public bool ConsultarContraseña(TextBox TxtRecuperarDoc)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT PASSWORD FROM OPERADOR WHERE NODOCUMENTO=@NODOCUMENTO", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtRecuperarDoc.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Password = Convert.ToString(dr["PASSWORD"]);
                    cargar = true;
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

            return cargar;
        }
        public bool ConsultarContraseña(Label TxtRecuperarDoc)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT PASSWORD FROM OPERADOR WHERE NODOCUMENTO=@NODOCUMENTO", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtRecuperarDoc.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Password = Convert.ToString(dr["PASSWORD"]);
                    cargar = true;
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

            return cargar;
        }
        public bool ConsultarEstadoOperador(TextBox TxtRecuperarDoc)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT IDESTADO,IDTIPOUSUARIO FROM OPERADOR WHERE NODOCUMENTO=@NODOCUMENTO", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtRecuperarDoc.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Estado = Convert.ToString(dr["IDESTADO"]);
                    _TipoUsuario = Convert.ToString(dr["IDTIPOUSUARIO"]);
                    cargar = true;
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

            return cargar;
        }
    }
}
