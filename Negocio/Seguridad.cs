using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using AccesoDatos;

namespace Negocio
{
    public class Seguridad
    {
        AccesoDatos.BaseDatos Bd = new AccesoDatos.BaseDatos();
        public static bool ConexionInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool ConexionDatos()
        {         
            bool Con = false;
            try
            {
                Bd.Conectar();
                {
                    Con = true;
                }               
            }
            catch(Exception)
            {
                throw;                
            }
            finally
            {
                Bd.Desconectar();
            }
              return Con;                
          }
        public bool Masterkey(TextBox Txtusername ,TextBox Txtpassword) 
        {
            bool Login = false;
            string Username, Password;
            Username = "187599102";
            Password = "120120256";
            try
            {
                if (Username == Txtusername.Text && Password == Txtpassword.Text)
                {
                    Login = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Login;
        }
    
        }         
  }
