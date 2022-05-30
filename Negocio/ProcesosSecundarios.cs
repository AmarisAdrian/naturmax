using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class ProcesosSecundarios
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public string _IdCaja;
        public string _NumCaja;
        public string _Email;

        public bool GuardarCaja(TextBox TxtIdCaja,TextBox TxtNombre) 
        {
            bool save = false;
            try 
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CAJA (IDCAJA,NUMERO)VALUES(@IDCAJA,@NUMERO)",CommandType.Text);
                bd.Asignarparametro("@IDCAJA", SqlDbType.VarChar, TxtIdCaja.Text);
                bd.Asignarparametro("@NUMERO", SqlDbType.Int, TxtNombre.Text);
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
        public bool ConsultarCaja(TextBox TxtNombre) 
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT IDCAJA FROM CAJA WHERE NUMERO='" + TxtNombre.Text + " '", CommandType.Text);
                bd.Asignarparametro("@NUMERO", SqlDbType.VarChar, TxtNombre.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _IdCaja = Convert.ToString(dr["IDCAJA"]);
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
        public bool EliminarCaja(TextBox Txtnumero)
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE  FROM CAJA WHERE NUMERO='" + Txtnumero.Text + " '", CommandType.Text);
                bd.Asignarparametro("@NUMERO", SqlDbType.Int, Txtnumero.Text);
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
        public bool ActualizarCaja(TextBox TxtIdCaja, TextBox TxtNombre)
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CAJA  SET [NUMERO]=@NUMERO,[IDCAJA]=@IDCAJA WHERE [IDCAJA]=@IDCAJA", System.Data.CommandType.Text);
                bd.Asignarparametro("IDCAJA", SqlDbType.VarChar, TxtIdCaja.Text);
                bd.Asignarparametro("NUMERO", SqlDbType.Int, TxtNombre.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    update = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return update;
        }
        public bool GuardarEmail(TextBox TxtIdEmail ,TextBox TxtEmail)
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO EMAIL(ID,EMAIL)VALUES(@ID,@EMAIL)", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.Int, TxtIdEmail.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    save = true;
                }
                else
                {
                    save = false;
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
        public bool EliminarEmail(TextBox TxtIdEmail)
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM EMAIL WHERE ID='" + TxtIdEmail.Text + " '", CommandType.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtIdEmail.Text);
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
        public bool ConsultarEmail(TextBox TxtIdEmail)
        {
            bool cargar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT EMAIL FROM EMAIL WHERE ID='" + TxtIdEmail.Text + " '", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.VarChar, TxtIdEmail.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Email = Convert.ToString(dr["EMAIL"]);
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
        public bool ActualizarEmail(TextBox TxtIdEmail, TextBox TxtEmail)
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE EMAIL SET [EMAIL]=@EMAIL,[ID]=@ID WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.Asignarparametro("ID", SqlDbType.Int, TxtIdEmail.Text);
                bd.Asignarparametro("EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    update = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return update;
        }
        public bool UltimoEmail()
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("ULTIMOEMAIL", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Email = Convert.ToString(dr["EMAIL"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool ActualizarContraseña(Label LblDocumento, TextBox TxtConfirmar)
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CAMBIARPASSWORD", CommandType.StoredProcedure);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, LblDocumento.Text);
                bd.Asignarparametro("@PASSWORD", SqlDbType.VarChar, TxtConfirmar.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    update = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return update;
        }
   
    }
}
