using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Transactions;
using System.Data.SqlClient;
using System.Data.Common;

using System.Configuration;


namespace AccesoDatos
{
    public class BaseDatos
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlTransaction trans;
        bool swTrans;
        string Cadconex;
        static int codeBdError;

        public static int CodeBdError
        {
            get { return BaseDatos.codeBdError; }
            set { BaseDatos.codeBdError = value; }
        }
        static string msgBdError;
        public static string MsgBdError
        {
            get { return BaseDatos.msgBdError; }
            set { BaseDatos.msgBdError = value; }
        }
        public void configurar()
        {
            string proveedor = "";
            Cadconex = "";
            Cadconex = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
            proveedor = ConfigurationManager.ConnectionStrings["Cadena"].ProviderName;
            swTrans = false;
        }
        public BaseDatos()
        {
            configurar();
        }
        public void Conectar()
        {
            codeBdError = 0;
            msgBdError = "";

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Cadconex;
                cn.Open();
            }
            catch (SqlException ex)
            {
                codeBdError = ex.ErrorCode;
                msgBdError = ex.Message;
            }
        }
        public void IniciarTransacion()
        {
            trans = cn.BeginTransaction();
            swTrans = true;
        }
        public void CrearComando(string vComando, CommandType vTipo)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = vTipo;
            cmd.CommandText = vComando;
            if (swTrans)
            {
                cmd.Transaction = trans;
            }
        }
        public void Asignarparametro(string vNombre, SqlDbType vTipo, Object vValor)
        {
            cmd.Parameters.Add(vNombre, vTipo).Value = vValor;
        }
        public void LimpiarParametros()
        {
            cmd.Parameters.Clear();
        }
        public int Ejecutarcomando()
        {
            BaseDatos.codeBdError = 0;
            BaseDatos.msgBdError = "";
            int numreg = 0;
            try
            {
                numreg = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                BaseDatos.codeBdError = ex.ErrorCode;
                BaseDatos.msgBdError = ex.Message;
                if (swTrans)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (codeBdError != 0)
                {
                    cn.Close();
                }
            }
            return numreg;
        }
        public void FinalizarTransaccion()
        {
            trans.Commit();
            swTrans = false;
        }
        public SqlDataReader EjecutarConsutaReader()
        {
            return cmd.ExecuteReader();
        }
        public DataTable EjecutarConsulta()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public void Desconectar()
        {
            cn.Close();
        }
    }
}
