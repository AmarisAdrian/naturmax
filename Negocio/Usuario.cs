using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using AccesoDatos;

namespace Negocio
{
    public class Usuario
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
       
        string VPASS;
        public string _VPASS
        {
            get { return VPASS; }
            set { VPASS = value; }
        }
        string VDOCOP;
        public string _VDOC
        {
            get { return VDOCOP; }
            set { VDOCOP = value; }
        }    
        string VPASSWORDOP;
        public string _VPASSWORDOP
        {
            get { return VPASSWORDOP; }
            set { VPASSWORDOP = value; }
        }
        string VNOMBREOP;
        public string _VNOMBREOP
        {
            get { return VNOMBREOP; }
            set { VNOMBREOP = value; }
        }
        string VAPELLIDOSOP;
        public string _VAPELLIDOSOP
        {
            get { return VAPELLIDOSOP; }
            set { VAPELLIDOSOP = value; }
        }
        string VGENEROSOP;
        public string _VGENEROSOP
        {
            get { return VGENEROSOP; }
            set { VGENEROSOP = value; }
        }
        string VESTADOOP;
        public string _VESTADOOP
        {
            get { return VESTADOOP; }
            set { VESTADOOP = value; }
        }
        string VTIPOOP;
        public string _VTIPOOP
        {
            get { return VTIPOOP; }
            set { VTIPOOP = value; }
        }
        string VTELEFONOOP;
        public string _VTELEFONOOP
        {
            get { return VTELEFONOOP; }
            set { VTELEFONOOP = value; }
        }
        string VMOVILOP;
        public string _VMOVILOP
        {
            get { return VMOVILOP; }
            set { VMOVILOP = value; }
        }
        string VEMAILOP;
        public string _VEMAILOP
        {
            get { return VEMAILOP; }
            set { VEMAILOP = value; }
        }
        string VCIUDADOP;
        public string _VCIUDADOP
        {
            get { return VCIUDADOP; }
            set { VCIUDADOP = value; }
        }
   
        string VDIRECCIONOP;
        public string _VDIRECCIONOP
        {
            get { return VDIRECCIONOP; }
            set { VDIRECCIONOP = value; }
        }
        int ESTADOLOGIN;
        public int _ESTADOLOGIN
        {
            get { return ESTADOLOGIN; }
            set { ESTADOLOGIN = value; }
        }
        int TIPOUSUARIOLOGIN;
       string VNODOCUMENTO;
        public string _VNODOCUMENTO
        {
            get { return VNODOCUMENTO; }
            set { VNODOCUMENTO = value; }
        }
       string VNOMBRESOPERADOR;
        public string _VNOMBRESOPERADOR
        {
            get { return VNOMBRESOPERADOR; }
            set { VNOMBRESOPERADOR = value; }
        }
        string VAPELLIDOS;
      public string _VAPELLIDOS
        {
            get { return VAPELLIDOS;  }
            set { VAPELLIDOS = value; }
        }
        public int _TIPOUSUARIOLOGIN
        {
            get { return TIPOUSUARIOLOGIN; }
            set { TIPOUSUARIOLOGIN = value; }
        }
        string DOCOPERADOR;
        public string _DOCOPERADOR
        {
            get { return DOCOPERADOR; }
            set { DOCOPERADOR = value; }
        }
        string USEROPERADOR;
        public string _USEROPERADOR
        {
            get { return USEROPERADOR; }
            set { USEROPERADOR = value; }
        }
        string NAMEOPERADOR;
        public string _NAMEOPERADOR
        {
            get { return NAMEOPERADOR; }
            set { NAMEOPERADOR = value; }
        }
        string LASTNAMEOPERADOR;
        public string _LASTNAMEOPERADOR
        {
            get { return LASTNAMEOPERADOR; }
            set { LASTNAMEOPERADOR = value; }
        }
        string DOCUMENTOCLIENTE;
        public string _DOCUMENTOCLIENTE
        {
            get { return DOCUMENTOCLIENTE; }
            set { DOCUMENTOCLIENTE = value; }
        }
        string NOMBRESCLIENTES;
        public string _NOMBRESCLIENTES
        {
            get { return NOMBRESCLIENTES; }
            set { NOMBRESCLIENTES = value; }
        }
        string APELLIDOSCLIENTES;
        public string _APELLIDOSCLIENTES
        {
            get { return APELLIDOSCLIENTES; }
            set { APELLIDOSCLIENTES = value; }
        }
        string DIRECCIONCLIENTES;
        public string _DIRECCIONCLIENTES
        {
            get { return DIRECCIONCLIENTES; }
            set { DIRECCIONCLIENTES = value; }
        }
        string TELEFONOCLIENTES;
        public string _TELEFONOCLIENTES
        {
            get { return TELEFONOCLIENTES; }
            set { TELEFONOCLIENTES = value; }
        }
        string  CELULARCLIENTES;
        public string _CELULARCLIENTES
        {
            get { return CELULARCLIENTES; }
            set { CELULARCLIENTES = value; }
        }
        public byte[]  _FOTOPERADOR;
        public bool  InsertarOperador(string TxtDocOperador, string TxtPasswordOperador, string TxtNombresOperador, string TxtApellidosOperador, string CmbGeneroOperador, string CmbEstadoOperador, string CmbTipoOperador, string TxtTelefonoOperador, string TxtMovilOperador, string TxtEmailOperador, string TxtCiudadOperador, string TxtDireccionOperador,byte[]psave) 
        {
            bool save = false;
              try
              {
                bd.Conectar();
                bd.CrearComando("INSERT INTO OPERADOR(NODOCUMENTO,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR,FOTOPERADOR)VALUES(@NODOCUMENTO,@PASSWORD,@NOMBRESOPERADOR,@APELLIDOSOPERADOR,@IDTIPOGENERO,@IDESTADO,@IDTIPOUSUARIO,@TELEFONOOPERADOR,@MOVILOPERADOR,@EMAILOPERADOR,@CIUDADOPERADOR,@DIRECCIONOPERADOR,@FOTOPERADOR)", System.Data.CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador);
                bd.Asignarparametro("@PASSWORD", SqlDbType.NVarChar, TxtPasswordOperador);
                bd.Asignarparametro("@NOMBRESOPERADOR", SqlDbType.NVarChar, TxtNombresOperador);
                bd.Asignarparametro("@APELLIDOSOPERADOR", SqlDbType.NVarChar, TxtApellidosOperador);
                bd.Asignarparametro("@IDTIPOGENERO", SqlDbType.Int, CmbGeneroOperador);
                bd.Asignarparametro("@IDESTADO", SqlDbType.Int, CmbEstadoOperador);
                bd.Asignarparametro("@IDTIPOUSUARIO", SqlDbType.Int, CmbTipoOperador);
                bd.Asignarparametro("@TELEFONOOPERADOR", SqlDbType.NVarChar, TxtTelefonoOperador);
                bd.Asignarparametro("@MOVILOPERADOR", SqlDbType.NVarChar, TxtMovilOperador);
                bd.Asignarparametro("@EMAILOPERADOR", SqlDbType.NVarChar, TxtEmailOperador);
                bd.Asignarparametro("@CIUDADOPERADOR", SqlDbType.NVarChar, TxtCiudadOperador);
                bd.Asignarparametro("@DIRECCIONOPERADOR", SqlDbType.NVarChar, TxtDireccionOperador);
                bd.Asignarparametro("@FOTOPERADOR", SqlDbType.Image, psave);
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
              finally 
              {
                  bd.Desconectar();
              }
              return save;
         }
        public bool ActualizarOperario(string TxtDocOperador, string TxtPasswordOperador, string TxtNombresOperador, string TxtApellidosOperador, string CmbGeneroOperador, string CmbEstadoOperador, string CmbTipoOperador, string TxtTelefonoOperador, string TxtMovilOperador, string TxtEmailOperador, string TxtCiudadOperador, string TxtDireccionOperador, byte[] psave)
        {
         bool Actualizar = false;
         try 
          { 
            bd.Conectar();
            bd.CrearComando("UPDATE OPERADOR SET [NODOCUMENTO]=@NODOCUMENTO,[PASSWORD]=@PASSWORD,[NOMBRESOPERADOR]=@NOMBRESOPERADOR,[APELLIDOSOPERADOR]=@APELLIDOSOPERADOR,[IDTIPOGENERO]=@IDTIPOGENERO,[IDESTADO]=@IDESTADO,[IDTIPOUSUARIO]=@IDTIPOUSUARIO,[TELEFONOOPERADOR]=@TELEFONOOPERADOR,[MOVILOPERADOR]=@MOVILOPERADOR ,[EMAILOPERADOR]=@EMAILOPERADOR,[CIUDADOPERADOR]=@CIUDADOPERADOR,[DIRECCIONOPERADOR]=@DIRECCIONOPERADOR,[FOTOPERADOR]=@FOTOPERADOR WHERE [NODOCUMENTO]=@NODOCUMENTO", System.Data.CommandType.Text);
            bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador);
            bd.Asignarparametro("@PASSWORD", SqlDbType.NVarChar, TxtPasswordOperador);
            bd.Asignarparametro("@NOMBRESOPERADOR", SqlDbType.NVarChar, TxtNombresOperador);
            bd.Asignarparametro("@APELLIDOSOPERADOR", SqlDbType.NVarChar, TxtApellidosOperador);
            bd.Asignarparametro("@IDTIPOGENERO", SqlDbType.Int, CmbGeneroOperador);
            bd.Asignarparametro("@IDESTADO", SqlDbType.Int, CmbEstadoOperador);
            bd.Asignarparametro("@IDTIPOUSUARIO", SqlDbType.Int, CmbTipoOperador);
            bd.Asignarparametro("@TELEFONOOPERADOR", SqlDbType.NVarChar, TxtTelefonoOperador);
            bd.Asignarparametro("@MOVILOPERADOR", SqlDbType.NVarChar, TxtMovilOperador);
            bd.Asignarparametro("@EMAILOPERADOR", SqlDbType.NVarChar, TxtEmailOperador);
            bd.Asignarparametro("@CIUDADOPERADOR", SqlDbType.NVarChar, TxtCiudadOperador);
            bd.Asignarparametro("@DIRECCIONOPERADOR", SqlDbType.NVarChar, TxtDireccionOperador);
            bd.Asignarparametro("@FOTOPERADOR", SqlDbType.Image, psave);
            int reg = 0;
            reg = bd.Ejecutarcomando();
            if (reg > 0)
            {               
                Actualizar = true;
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
            return Actualizar;
        }
        public bool ActualizarOperario(TextBox TxtDocOperador, ComboBox CmbEstadoOperador)
        {
            bool Actualizar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE OPERADOR SET [NODOCUMENTO]=@NODOCUMENTO,[IDESTADO]=@IDESTADO WHERE [NODOCUMENTO]=@NODOCUMENTO", System.Data.CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador.Text);
                bd.Asignarparametro("@IDESTADO", SqlDbType.Int, CmbEstadoOperador.SelectedValue);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Actualizar = true;
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
            return Actualizar;
        }
        public bool EliminarOperario(string TxtDocOperador)
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM OPERADOR WHERE NODOCUMENTO=@NODOCUMENTO", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador);
                int res;
                res = bd.Ejecutarcomando();
                bd.Desconectar();
                if (BaseDatos.CodeBdError == 0)
                {
                    if (res > 0)
                        delete = true;                     
                }
            }
            catch (Exception)
            {
                throw;
            }
            return delete;
        }
        public bool ConsultarOperarios(string TxtDocOperador)
        {
          bool consulto = false;
          try 
           { 
            bd.Conectar();
            bd.CrearComando("SELECT NODOCUMENTO,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR,FOTOPERADOR FROM OPERADOR WHERE NODOCUMENTO='" + TxtDocOperador + " '", CommandType.Text);
            bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador);
            SqlDataReader dr;
            dr = bd.EjecutarConsutaReader();
            if (dr.Read())
            {
                _VDOC = Convert.ToString(dr["NODOCUMENTO"]);
                _VPASSWORDOP = Convert.ToString(dr["PASSWORD"]);
                _VNOMBREOP = Convert.ToString(dr["NOMBRESOPERADOR"]);
                _VAPELLIDOSOP = Convert.ToString(dr["APELLIDOSOPERADOR"]);
                _VGENEROSOP = Convert.ToString(dr["IDTIPOGENERO"]);
                _VESTADOOP = Convert.ToString(dr["IDESTADO"]);
                _VTIPOOP = Convert.ToString(dr["IDTIPOUSUARIO"]);
                _VTELEFONOOP = Convert.ToString(dr["TELEFONOOPERADOR"]);
                _VMOVILOP = Convert.ToString(dr["MOVILOPERADOR"]);
                _VEMAILOP = Convert.ToString(dr["EMAILOPERADOR"]);
                _VCIUDADOP = Convert.ToString(dr["CIUDADOPERADOR"]);
                _VDIRECCIONOP = Convert.ToString(dr["DIRECCIONOPERADOR"]); ;
                _FOTOPERADOR =   (byte[])(dr["FOTOPERADOR"]); 
                consulto = true;
              }
            }
            catch(Exception)
          {
              throw;
           }
            return consulto;
        }
        public bool ConsultarPanelAdministrador(string TxtDocOperador) 
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NODOCUMENTO,NOMBRESOPERADOR,APELLIDOSOPERADOR,FOTOPERADOR FROM OPERADOR WHERE NODOCUMENTO='" + TxtDocOperador + " '", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocOperador);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _VDOC = Convert.ToString(dr["NODOCUMENTO"]);
                    _VNOMBREOP = Convert.ToString(dr["NOMBRESOPERADOR"]);
                    _VAPELLIDOSOP = Convert.ToString(dr["APELLIDOSOPERADOR"]);
                    _FOTOPERADOR = (byte[])(dr["FOTOPERADOR"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public void ConsultarOperariosActivo(DataGridView DgConsultarOperario)
        {
                CargarGrilla g = new CargarGrilla();
                DgConsultarOperario.DataSource = null;
                g.Preparar("SELECT NODOCUMENTO,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR FROM OPERADOR WHERE IDESTADO='1'");
                g.Cargar(DgConsultarOperario);
        }
        public void ConsultarOperariosInactivo(DataGridView DgConsultarOperario)
        {
                CargarGrilla g = new CargarGrilla();
                DgConsultarOperario.DataSource = null;
                g.Preparar("SELECT NODOCUMENTO,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR FROM OPERADOR WHERE IDESTADO='2'");
                g.Cargar(DgConsultarOperario);
        }
        public void ConsultarOperarioBloqueados(DataGridView DgConsultarOperario)
        {
                CargarGrilla g = new CargarGrilla();
                DgConsultarOperario.DataSource = null;
                g.Preparar("SELECT NODOCUMENTO,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR FROM OPERADOR WHERE IDESTADO='3'");
                g.Cargar(DgConsultarOperario);
        } 
        public bool PermitirAcceso(string Txtcodigo, string Txtpassword)
        {
            bool permitir = false;
            bd.Conectar();
            bd.CrearComando("SELECT NODOCUMENTO ,NOMBRESOPERADOR,APELLIDOSOPERADOR, IDESTADO ,IDTIPOUSUARIO FROM OPERADOR WHERE NODOCUMENTO='" + Txtcodigo + " ' AND PASSWORD='" + Txtpassword + "' ", CommandType.Text);
            SqlDataReader dr;
            dr = bd.EjecutarConsutaReader();
            if (dr.Read())
            {
                _VNODOCUMENTO = Convert.ToString(dr["NODOCUMENTO"]);
                _VNOMBRESOPERADOR = Convert.ToString(dr["NOMBRESOPERADOR"]);
                _VAPELLIDOS = Convert.ToString(dr["APELLIDOSOPERADOR"]);
                _ESTADOLOGIN = Convert.ToInt32(dr["IDESTADO"]);
                _TIPOUSUARIOLOGIN = Convert.ToInt32(dr["IDTIPOUSUARIO"]);        
            }
            if (_ESTADOLOGIN == 1)
            {
                permitir = true;
            }
            return permitir;
        }   
        public bool ConsultarPorDocumento(string Txtconsultardocumento,string Txtemail)
        {
          bool consulto = false;
          try
          {
              bd.Conectar();
              bd.CrearComando("SELECT PASSWORD,EMAILOPERADOR FROM OPERADOR WHERE NODOCUMENTO='" + Txtconsultardocumento + " '", System.Data.CommandType.Text);
              bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Txtconsultardocumento);
              bd.Asignarparametro("@EMAILOPERADOR", SqlDbType.VarChar, Txtemail);
              SqlDataReader dr;
              dr = bd.EjecutarConsutaReader();
              if (dr.Read())
              {
                  _VPASS = Convert.ToString(dr["PASSWORD"]);
                  _VEMAILOP = Convert.ToString(dr["EMAILOPERADOR"]);
                  consulto = true;
              }
              else
              {
                  consulto = false;
              }
          }
            catch(Exception )
          {
              throw;
          }
          finally 
          {
              bd.Desconectar();
          }
           return consulto;
       }
        public bool ConsultarPanelOperador(string TxtDocumento)
        {
            bool Consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NODOCUMENTO,NOMBRESOPERADOR,APELLIDOSOPERADOR FROM OPERADOR WHERE NODOCUMENTO ='" + TxtDocumento + " '", CommandType.Text);
                DbDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _DOCOPERADOR = Convert.ToString(dr["NODOCUMENTO"]);
                    _NAMEOPERADOR = Convert.ToString(dr["NOMBRESOPERADOR"]);
                    _LASTNAMEOPERADOR = Convert.ToString(dr["APELLIDOSOPERADOR"]);
                    Consulto = true;
                }
                else
                {
                    Consulto = false;
                }
                return Consulto;
            }
            catch(Exception )
            {
                throw;
            }
            finally 
            {
                bd.Desconectar();
            }
        }
        public bool InsertarCliente(string Txtdocumento,string Txtnombres,string Txtapellidos,string Txtdireccion,string Txttelefono,string Txtcelular) 
        {
            bool inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CLIENTE(NODOCUMENTO,NOMBRES,APELLIDOS,DIRECCION,TELEFONO,CELULAR)VALUES(@NODOCUMENTO,@NOMBRES,@APELLIDOS,@DIRECCION,@TELEFONO,@CELULAR)", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Txtdocumento);
                bd.Asignarparametro("@NOMBRES", SqlDbType.NVarChar, Txtnombres);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.NVarChar, Txtapellidos);
                bd.Asignarparametro("@DIRECCION", SqlDbType.NVarChar, Txtdireccion);
                bd.Asignarparametro("@TELEFONO", SqlDbType.NVarChar, Txttelefono);
                bd.Asignarparametro("@CELULAR", SqlDbType.NVarChar, Txtcelular);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    inserto = true;
                }
            }
            catch (Exception) 
            {
                throw;
            }
            return inserto;
        }
        public bool EliminarCliente(string Txtdocumento) 
        {
            bool eliminar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM CLIENTE WHERE NODOCUMENTO=@NODOCUMENTO", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Txtdocumento);
                int res = 0;
                res = bd.Ejecutarcomando();
                if (BaseDatos.CodeBdError == 0)
                {
                    if (res > 0)
                    eliminar = true;
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
            return eliminar;
        }
        public bool ConsultarCliente(string Txtdocumento)
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NOMBRES,APELLIDOS,DIRECCION,TELEFONO,CELULAR  FROM CLIENTE WHERE NODOCUMENTO='" + Txtdocumento + " '", System.Data.CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Txtdocumento);
                DbDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _NOMBRESCLIENTES = Convert.ToString(dr["NOMBRES"]);
                    _APELLIDOSCLIENTES = Convert.ToString(dr["APELLIDOS"]);
                    _DIRECCIONCLIENTES = Convert.ToString(dr["DIRECCION"]);
                    _TELEFONOCLIENTES = Convert.ToString(dr["TELEFONO"]);
                    _CELULARCLIENTES = Convert.ToString(dr["CELULAR"]);
                    consulto = true;
                }
            }
            catch (Exception) 
            {
                throw;
            }
            return consulto;
        }     
        public bool ActualizarCliente(string Txtdocumento, string Txtnombres, string Txtapellidos, string Txtdireccion, string Txttelefono, string Txtcelular)
        {
            bool Actualizar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CLIENTE  SET [NODOCUMENTO]=@NODOCUMENTO,[NOMBRES]=@NOMBRES,[APELLIDOS]=@APELLIDOS,[DIRECCION]=@DIRECCION,[TELEFONO]=@TELEFONO,[CELULAR]=@CELULAR  WHERE [NODOCUMENTO]=@NODOCUMENTO", System.Data.CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Txtdocumento);
                bd.Asignarparametro("@NOMBRES", SqlDbType.NVarChar, Txtnombres);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.NVarChar, Txtapellidos);
                bd.Asignarparametro("@DIRECCION", SqlDbType.NVarChar, Txtdireccion);
                bd.Asignarparametro("@TELEFONO", SqlDbType.NVarChar, Txttelefono);
                bd.Asignarparametro("@CELULAR", SqlDbType.NVarChar, Txtcelular);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {        
                    Actualizar = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                bd.Desconectar();
            }
            return Actualizar;
        }
        public bool InsertarCliente(DataGridView DgImportar) 
        {
                int i=0;
                bool Save = false; 
                try
                {

                    foreach (DataGridViewRow Rows in DgImportar.Rows)
                    {
                        bd.Conectar();
                        bd.CrearComando("INSERT INTO CLIENTE (NODOCUMENTO ,NOMBRES,APELLIDOS,DIRECCION,TELEFONO ,CELULAR) values (@NODOCUMENTO,@NOMBRES,@APELLIDOS,@DIRECCION,@TELEFONO,@CELULAR)", CommandType.Text);
                        bd.Asignarparametro("@NODOCUMENTO ", SqlDbType.BigInt, DgImportar.Rows[i].Cells[0].Value.ToString());
                        bd.Asignarparametro("@NOMBRES", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
                        bd.Asignarparametro("@APELLIDOS", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[2].Value.ToString());
                        bd.Asignarparametro("@DIRECCION", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[3].Value.ToString());
                        bd.Asignarparametro("@TELEFONO ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[4].Value.ToString());
                        bd.Asignarparametro("@CELULAR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[5].Value.ToString());
                        int reg = 0;
                        reg = bd.Ejecutarcomando();
                        if (reg > 0)
                        {
                            Save = true;
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
                return Save;
        }
        public bool InsertarOperador(DataGridView DgImportar)
        {
            bool save = false;
            int i =0;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO OPERADOR(NODOCUMENTO,USERNAME,PASSWORD,NOMBRESOPERADOR,APELLIDOSOPERADOR,IDTIPOGENERO,IDESTADO,IDTIPOUSUARIO,TELEFONOOPERADOR,MOVILOPERADOR,EMAILOPERADOR,CIUDADOPERADOR,DIRECCIONOPERADOR,FOTOPERADOR)VALUES(@NODOCUMENTO,@USERNAME,@PASSWORD,@NOMBRESOPERADOR,@APELLIDOSOPERADOR,@IDTIPOGENERO,@IDESTADO,@IDTIPOUSUARIO,@TELEFONOOPERADOR,@MOVILOPERADOR,@EMAILOPERADOR,@CIUDADOPERADOR,@DIRECCIONOPERADOR,@FOTOPERADOR)", System.Data.CommandType.Text);
                    bd.Asignarparametro("@NODOCUMENTO ", SqlDbType.BigInt, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@USERNAME", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
                    bd.Asignarparametro("@PASSWORD", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@NOMBRESOPERADOR", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[3].Value.ToString());
                    bd.Asignarparametro("@APELLIDOSOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[4].Value.ToString());
                    bd.Asignarparametro("@IDTIPOGENERO ", SqlDbType.Int, DgImportar.Rows[i].Cells[5].Value.ToString());
                    bd.Asignarparametro("@IDESTADO ", SqlDbType.Int, DgImportar.Rows[i].Cells[6].Value.ToString());
                    bd.Asignarparametro("@IDTIPOUSUARIO ", SqlDbType.Int, DgImportar.Rows[i].Cells[7].Value.ToString());
                    bd.Asignarparametro("@TELEFONOOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[8].Value.ToString());
                    bd.Asignarparametro("@MOVILOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[9].Value.ToString());
                    bd.Asignarparametro("@EMAILOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[10].Value.ToString());
                    bd.Asignarparametro("@CIUDADOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[11].Value.ToString());
                    bd.Asignarparametro("@DIRECCIONOPERADOR ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[12].Value.ToString());
                    bd.Asignarparametro("@FOTOPERADOR ", SqlDbType.Image, DgImportar.Rows[i].Cells[13].Value.ToString());
                    int reg = 0;
                    reg = bd.Ejecutarcomando();
                    if (reg > 0)
                    {
                        save = true;
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
            return save;
        }
        public bool ConsultarCliente(DataGridView DgExportar) 
        {
            bool Con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM CLIENTE");
            g.Cargar(DgExportar);
            return Con;        
        }
        public bool ConsultarOperarios(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM OPERADOR");
            g.Cargar(DgExportar);
            return con;
        }
        public bool ConsultarControlOperarios(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM CONTROLOPERADOR");
            g.Cargar(DgExportar);
            return con;
        }

    } 
}
