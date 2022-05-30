using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using AccesoDatos;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using Microsoft.Office;
using System.Data.OleDb;
using System.Data.Sql;

namespace Negocio
{
    public class Functions
    {
        public string _Cadena;
        public string _Instancia;
        public string _CONIDPRODUCTO;
        public string _CONIDCATEGORIA;
        public string _CONIDMARCA;
        public string _CONDESCRIPCION;
        public string _CONPRECIOU;
        public string _CONPRECIOIVA;
        public string _NOMBREMARCA;
        public string _NOMBRECATEGORIA;
        public string _ULTIMAFACTURA;
        public string _RegistroDia;
        public string _ErroresDia;
        public string _ErrorFactura;
        private string To;
        private string Subject;
        private string Body;
        private MailMessage mail;
        string Cadconex;
        string miValor = ConfigurationManager.AppSettings["Cadena"];


        BaseDatos bd = new BaseDatos();

        public void Mandarcontraseña(TextBox Clave,TextBox Txtusuario, TextBox Email)
        {
                To = Email.Text;
                Subject = "Clave asignada";
                Body = "Su usuario es: " + " " + Txtusuario.Text + " " + "y Su clave es: " + Clave.Text + "";
                mail = new MailMessage();
                mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("Adrianprogramacion@outlook.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("Adrianprogramacion@outlook.com", "a1042447888*");
                    client.EnableSsl = true;
                    client.Send(mail);
                }    
        }
        public bool EnviarMailProblemas(TextBox Txtemailadmin, TextBox Txtsoportedoc, TextBox Txtsoporteemail, RichTextBox Rtbsoporte)
        {
            bool enviar = false;
            try
            {
                To = Txtemailadmin.Text;
                Subject = "Problemas de Usuario";
                Body = " Mi Documento es : " + " " + Txtsoportedoc.Text + "" + " ,  Mi email es : " + Txtsoporteemail.Text + "" + " ,  Mi Problema es el siguiente : " + Rtbsoporte.Text + "";
                mail = new MailMessage();
                mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("Adrianprogramacion@outlook.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("Adrianprogramacion@outlook.com", "a1042447888*");
                    client.EnableSsl = true;
                    client.Send(mail);
                    enviar = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return enviar;
        }
        public bool EnviarMailRecuperarContraseña( TextBox Txtuser, TextBox Txtpassword,TextBox TxtRecuperarCorreo)
        {
            bool enviar = false;
            try
            {
                To = TxtRecuperarCorreo.Text;
                Subject = "Recuperar contraseña";
                Body = "Su usuario es: " + " " + Txtuser.Text + " " + "y Su clave es: " + Txtpassword.Text + "";
                mail = new MailMessage();
                mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("Adrianprogramacion@outlook.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("Adrianprogramacion@outlook.com", "a1042447888*");
                    client.EnableSsl = true;
                    client.Send(mail);
                    enviar = true;
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            return enviar;
        }
        public void VaciarCampos(TextBox Txtsoportedoc, TextBox Txtsoporteemail, RichTextBox Rtbsoporte)
        {
            Txtsoportedoc.Clear();
            Txtsoporteemail.Clear();
            Rtbsoporte.Clear();
        }
        public void CargarComboGenero(ComboBox CmbSexoPaciente)
        {
                Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
                Tipogenero.Cargar(CmbSexoPaciente, "SELECT  ID ,NOMBRE FROM GENERO", "ID", "NOMBRE");
        }
        public void CargarComboEstadoCaja(ComboBox CmbCerrado)
        {
            Negocio.CargarCombo Estado = new Negocio.CargarCombo();
            Estado.Cargar(CmbCerrado, "SELECT  ID ,NOMBRE FROM ESTADOCAJA", "ID", "NOMBRE");
        }
        public void CargarComboEstado(ComboBox CmbEstadoUsuario)
        {
                Negocio.CargarCombo Estado = new Negocio.CargarCombo();
                Estado.Cargar(CmbEstadoUsuario, "SELECT  ID ,NOMBRE FROM ESTADOUSUARIO", "ID", "NOMBRE");
        }
        public void CargarComboTipoUsuario(ComboBox CmbEstadoOperador)
        {
                Negocio.CargarCombo Tipo = new Negocio.CargarCombo();
                Tipo.Cargar(CmbEstadoOperador, "SELECT  ID ,NOMBRE FROM TIPOUSUARIO", "ID", "NOMBRE");
        }
        public void CargarComboProveedor(ComboBox CmbProveedor)
        {
                Negocio.CargarCombo Tipo = new Negocio.CargarCombo();
                Tipo.Cargar(CmbProveedor, "SELECT  IDPROVEEDOR ,NOMBRE FROM PROVEEDOR", "IDPROVEEDOR", "NOMBRE");
        }
        public void CargarComboCategoria(ComboBox CmbCategoriaProducto)
        {
                Negocio.CargarCombo Tipo = new Negocio.CargarCombo();
                Tipo.Cargar(CmbCategoriaProducto, "SELECT  IDCATEGORIA ,NOMBRE FROM CATEGORIA_PRODUCTO", "IDCATEGORIA", "NOMBRE");
        }
        public void ObtenerCadConex()
        {
            try
            {
                string proveedor = "";
                Cadconex = "";
                Cadconex = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
                proveedor = ConfigurationManager.ConnectionStrings["Cadena"].ProviderName;
                _Cadena = Cadconex;
            }
            catch (Exception)
            {
                throw;
            }
        }      
        public void ObtenerNombreMaquina(Label Lblpc)
        {
               try
            {
                string strHostName = string.Empty;
                strHostName = Dns.GetHostName();
                IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                for (int i = 0; i < hostIPs.Length; i++)
                {
                           Lblpc.Text =  strHostName;
                }            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CargarBasesDatos(DataGridView Dg)
        {
                CargarGrilla g = new CargarGrilla();
                Dg.DataSource = null;
                g.Preparar("SELECT NAME FROM sysdatabases");
                g.Cargar(Dg);
        }
        public void CargarInstancias(DataGridView Dg)
        {
                CargarGrilla g = new CargarGrilla();
                Dg.DataSource = null;
                g.Preparar("select @@SERVERNAME");
                g.Cargar(Dg);
        }
        public void CargarReferenciaProducto(DataGridView Dg)
        {
                CargarGrilla g = new CargarGrilla();
                Dg.DataSource = null;
                g.Preparar("SELECT IDPRODUCTO,DESCRIPCION,STOCK,PRECIOUNITARIO,PRECIOIVA FROM PRODUCTO");
                g.Cargar(Dg);
        }
        public void ReferenciaProducto(DataGridView Dg)
        {
            CargarGrilla g = new CargarGrilla();
            Dg.DataSource = null;
            g.Preparar("SELECT IDPRODUCTO,DESCRIPCION FROM PRODUCTO");
            g.Cargar(Dg);
        }
        public void CargarComboMarca(ComboBox CmbEstadoUsuario)
        {
                Negocio.CargarCombo Estado = new Negocio.CargarCombo();
                Estado.Cargar(CmbEstadoUsuario, "SELECT  IDMARCA ,NOMBRE FROM MARCA", "IDMARCA", "NOMBRE");
        }
        public bool ConsultarProductos(TextBox Txtreferencia)
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARPRODUCTO", CommandType.StoredProcedure);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.Int, Txtreferencia.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CONDESCRIPCION = Convert.ToString(dr["DESCRIPCION"]);
                    _CONIDPRODUCTO = Convert.ToString(dr["IDPRODUCTO"]);
                    _CONIDMARCA = Convert.ToString(dr["IDMARCA"]);
                    _NOMBRECATEGORIA = Convert.ToString(dr["NOMBRECATEGORIA"]);
                    _NOMBREMARCA = Convert.ToString(dr["NOMBREMARCA"]);
                    _CONPRECIOU = Convert.ToString(dr["PRECIOBRUTO"]);
                    _CONPRECIOIVA = Convert.ToString(dr["PRECIOIVA"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool importarExcel(DataGridView Dgimportar,string archivo, string hoja)
        {
            bool imp = false;
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";
                try
                {
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);
                    conexion.Open(); 
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); 
                    dataSet = new DataSet(); 
                    dataAdapter.Fill(dataSet, hoja);
                    Dgimportar.DataSource = dataSet.Tables[0];
                    conexion.Close();
                    Dgimportar.AllowUserToAddRows = false;
                    imp = true;
                }
                catch (Exception)
                {
                    throw;
                }
            return imp;
        }  
        public bool ExportarExcel(DataGridView Dgexportar,TextBox txtnombrearchivo) 
        {
            bool exp = false;
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = txtnombrearchivo.Text;
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int i = 0; i < Dgexportar.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < Dgexportar.Columns.Count; j++)
                        {
                            if ((Dgexportar.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = Dgexportar.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exp;
        }
        public bool GuardarControlOperador(Label LblRegistro, string lblDocumento, string LblHoraI, string LblHoraF, DateTime DtFechaFactura) 
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CONTROLOPERADOR(IDCONTROL,NODOCUMENTO,HORAINICIO,HORAFIN,FECHA)VALUES(@IDCONTROL,@NODOCUMENTO,@HORAINICIO,@HORAFIN,@FECHA)", CommandType.Text);
                bd.Asignarparametro("@IDCONTROL", SqlDbType.BigInt, LblRegistro.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, lblDocumento);
                bd.Asignarparametro("@HORAINICIO", SqlDbType.Time, LblHoraI);
                bd.Asignarparametro("@HORAFIN", SqlDbType.Time, LblHoraF);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, DtFechaFactura);
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
        public bool GuardarControlFactura(string Txtnofac, string LblDocumento, string LblPc) 
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CONTROLFACTURA(NOFACTURA,DOCUMENTO,PC)VALUES(@NOFACTURA,@DOCUMENTO,@PC)", CommandType.Text);
                bd.Asignarparametro("@NOFACTURA", SqlDbType.VarChar, Txtnofac);
                bd.Asignarparametro("@DOCUMENTO", SqlDbType.BigInt, LblDocumento);
                bd.Asignarparametro("@PC", SqlDbType.VarChar, LblPc);
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
        public bool ErroresDia(string Dtfecha)
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT COUNT(*) AS NUMEROERRORES FROM ERRORLOGS WHERE FECHA='" + Dtfecha + " '", CommandType.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _ErroresDia = Convert.ToString(dr["NUMEROERRORES"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
        public bool ErroresDia(TextBox Txtnofac, Label Lblerrorlogs, DateTime Dtfecha)
        {
            bool Insert = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO ERRORLOGS(NOFACTURA,CONT,FECHA)VALUES(@NOFACTURA,@CONT,@FECHA)", CommandType.Text);
                bd.Asignarparametro("NOFACTURA", SqlDbType.VarChar, Txtnofac.Text);
                bd.Asignarparametro("CONT", SqlDbType.Int, Lblerrorlogs.Text);
                bd.Asignarparametro("FECHA", SqlDbType.DateTime, Dtfecha);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Insert = true;
                }
                else if (BaseDatos.CodeBdError == -2146232060) 
                {
                   ActualizacionErroresLogs(Txtnofac,Lblerrorlogs,Dtfecha);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Insert;
        }
        public bool RegistroDia(string Dtfecha)
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT COUNT(*) AS NUMEROREGISTRO FROM FACTURA WHERE FECHA='" + Dtfecha + " '", CommandType.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _RegistroDia = Convert.ToString(dr["NUMEROREGISTRO"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return consulto;
        }
        public bool ActualizacionErroresLogs(TextBox Txtnofac, Label Lblerrorlogs, DateTime Dtfecha) 
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CERRARCAJA  SET [NOFACTURA]=@NOFACTURA,[CONT]=@CONT,[FECHA]=@FECHA  WHERE [NOFACTURA]=@NOFACTURA", System.Data.CommandType.Text);
                bd.Asignarparametro("NOFACTURA", SqlDbType.VarChar, Txtnofac.Text);
                bd.Asignarparametro("CONT", SqlDbType.Int, Lblerrorlogs.Text);
                bd.Asignarparametro("FECHA", SqlDbType.DateTime, Dtfecha);
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
        public bool ConsultarErrorFacturas(TextBox Txtnofac, Label Lblerrorlogs)
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT CONT FROM ERRORLOGS WHERE NOFACTURA='" + Txtnofac.Text + " '", CommandType.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _ErrorFactura = Convert.ToString(dr["CONT"]);
                    consulto = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consulto;
        }
       
    
    }
}
