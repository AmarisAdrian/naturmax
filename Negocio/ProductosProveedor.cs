using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;

namespace Negocio
{
    public class ProductosProveedor
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        string PID;
        public string _PID
        {
            get { return PID; }
            set { PID = value; }
        }
        string PNOMBRE;
        public string _PNOMBRE
        {
            get { return PNOMBRE; }
            set { PNOMBRE = value; }
        }
        string PDIRECCION;
        public string _PDIRECCION
        {
            get { return PDIRECCION; }
            set { PDIRECCION = value; }
        }
        string PTELEFONO;
        public string _PTELEFONO
        {
            get { return PTELEFONO; }
            set { PTELEFONO = value; }
        }
        string PEMAIL;
        public string _PEMAIL
        {
            get { return PEMAIL; }
            set { PEMAIL = value; }
        }
        string PRUT;
        public string _PRUT
        {
            get { return PRUT; }
            set { PRUT = value; }
        }
        string PNOMBRECONTACTO;
        public string _PNOMBRECONTACTO
        {
            get { return PNOMBRECONTACTO; }
            set { PNOMBRECONTACTO = value; }
        }
        string PTELEFONOCONTACTO;
        public string _PTELEFONOCONTACTO
        {
            get { return PTELEFONOCONTACTO; }
            set { PTELEFONOCONTACTO = value; }
        }
        string PEMAILCONTACTO;
        public string _PEMAILCONTACTO
        {
            get { return PEMAILCONTACTO; }
            set { PEMAILCONTACTO = value; }
        }
        string PCIUDAD;
        public string _PCIUDAD
        {
            get { return PCIUDAD; }
            set { PCIUDAD = value; }
        }
        string PDEPARTAMENTO;
        public string _PDEPARTAMENTO
        {
            get { return PDEPARTAMENTO; }
            set { PDEPARTAMENTO = value; }
        }
        string CIDCATEGORIA;
        public string _CIDCATEGORIA
        {
            get { return CIDCATEGORIA; }
            set { CIDCATEGORIA = value; }
        }
        string CNOMBRECATEGORIA;
        public string _CNOMBRECATEGORIA
        {
            get { return CNOMBRECATEGORIA; }
            set { CNOMBRECATEGORIA = value; }
        }
        string PROIDPRODUCTO;
        public string _PROIDPRODUCTO
        {
            get { return PROIDPRODUCTO; }
            set { PROIDPRODUCTO = value; }
        }
        string PROIDPROVEEDOR;
        public string _PROIDPROVEEDOR
        {
            get { return PROIDPROVEEDOR; }
            set { PROIDPROVEEDOR = value; }
        }
        string PROIDCATEGORIA;
        public string _PROIDCATEGORIA
        {
            get { return PROIDCATEGORIA; }
            set { PROIDCATEGORIA = value; }
        }
        string PROIDMARCA;
        public string _PROIDMARCA
        {
            get { return PROIDMARCA; }
            set { PROIDMARCA = value; }
        }
        string PRONOMBRE;
        public string _PRONOMBRE
        {
            get { return PRONOMBRE; }
            set { PRONOMBRE = value; }
        }
        string PROSTOCK;
        public string _PROSTOCK
        {
            get { return PROSTOCK; }
            set { PROSTOCK = value; }
        }
        string PROPRECIOUNITARIO;
        public string _PROPRECIOUNITARIO
        {
            get { return PROPRECIOUNITARIO; }
            set { PROPRECIOUNITARIO = value; }
        }
        string VIDMARCA;
        public string _VIDMARCA
        {
            get { return VIDMARCA; }
            set { VIDMARCA = value; }
        }
        string VNOMBREMARCA;
        public string _VNOMBREMARCA
        {
            get { return VNOMBREMARCA; }
            set { VNOMBREMARCA = value; }
        }
        public string _VPRECIOIVA;
        public bool InsertarProveedor(string TXTIdProveedor,string TxtNombreproveedor,string TxtDireccionProveedor,string TxtTelefonoProveedor,string TxtEmailProveedor,string TxtRutProveedor,string TxtNombreContacto,string TxtTelefonoContacto,string TxtEmailContacto,string Txtciudad,string TxtDepartamento)
       {
           bool save = false;
           try
           { 
             bd.Conectar();
             bd.CrearComando("Insert into proveedor(IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO,EMAIL,RUT,NOMBRECONTACTO,TELEFONOCONTACTO,EMAILCONTACTO,CIUDAD,DEPARTAMENTO)Values(@IDPROVEEDOR,@NOMBRE,@DIRECCION,@TELEFONO,@EMAIL,@RUT,@NOMBRECONTACTO,@TELEFONOCONTACTO,@EMAILCONTACTO,@CIUDAD,@DEPARTAMENTO)",System.Data.CommandType.Text );
             bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, TXTIdProveedor);
             bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, TxtNombreproveedor);
             bd.Asignarparametro("@DIRECCION", SqlDbType.NVarChar, TxtDireccionProveedor);
             bd.Asignarparametro("@TELEFONO", SqlDbType.NVarChar, TxtTelefonoProveedor);
             bd.Asignarparametro("@EMAIL", SqlDbType.NVarChar, TxtEmailProveedor);
             bd.Asignarparametro("@RUT", SqlDbType.NVarChar, TxtRutProveedor);
             bd.Asignarparametro("@NOMBRECONTACTO", SqlDbType.NVarChar, TxtNombreContacto);
             bd.Asignarparametro("@TELEFONOCONTACTO", SqlDbType.NVarChar, TxtTelefonoContacto);
             bd.Asignarparametro("@EMAILCONTACTO", SqlDbType.NVarChar, TxtEmailContacto);
             bd.Asignarparametro("@CIUDAD", SqlDbType.NVarChar, Txtciudad);
             bd.Asignarparametro("@DEPARTAMENTO", SqlDbType.NVarChar, TxtDepartamento);
             int reg = 0;
             reg = bd.Ejecutarcomando();
             if (reg > 0)
             {
                 save = true;
             }
           }
             catch(Exception )
             {
                 throw;
             }
           return save;
        }
        public bool  EliminarProveedor(string TXTIdProveedor)
        {
            bool delete = false;
            try
            { 
            bd.Conectar();
            bd.CrearComando("DELETE FROM proveedor WHERE IDPROVEEDOR=@IDPROVEEDOR", CommandType.Text);
            bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, TXTIdProveedor);
            int res;
            res = bd.Ejecutarcomando();
            bd.Desconectar();
            if (BaseDatos.CodeBdError == 0)
            {
                if (res > 0)
                 delete = true;
            }
           }
            catch(Exception)
            {
                throw;
           }
            return delete;
        }
        public bool ActualizarProveedor(string TXTIdProveedor,string TxtNombreproveedor,string TxtDireccionProveedor,string TxtTelefonoProveedor,string TxtEmailProveedor,string TxtRutProveedor,string TxtNombreContacto,string TxtTelefonoContacto,string TxtEmailContacto,string Txtciudad,string TxtDepartamento)
        {
            bool update = false;
            try
            { 
            bd.Conectar();
            bd.CrearComando("UPDATE proveedor SET [IDPROVEEDOR]=@IDPROVEEDOR,[NOMBRE]=@NOMBRE,[DIRECCION]=@DIRECCION,[TELEFONO]=@TELEFONO,[EMAIL]=@EMAIL,[RUT]=@RUT,[NOMBRECONTACTO]=@NOMBRECONTACTO,[TELEFONOCONTACTO]=@TELEFONOCONTACTO,[EMAILCONTACTO]=@EMAILCONTACTO,[CIUDAD]=@CIUDAD ,[DEPARTAMENTO]=@DEPARTAMENTO WHERE [IDPROVEEDOR]=@IDPROVEEDOR", System.Data.CommandType.Text);
            bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, TXTIdProveedor);
            bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, TxtNombreproveedor);
            bd.Asignarparametro("@DIRECCION", SqlDbType.NVarChar, TxtDireccionProveedor);
            bd.Asignarparametro("@TELEFONO", SqlDbType.NVarChar, TxtTelefonoProveedor);
            bd.Asignarparametro("@EMAIL", SqlDbType.NVarChar, TxtEmailProveedor);
            bd.Asignarparametro("@RUT", SqlDbType.NVarChar, TxtRutProveedor);
            bd.Asignarparametro("@NOMBRECONTACTO", SqlDbType.NVarChar, TxtNombreContacto);
            bd.Asignarparametro("@TELEFONOCONTACTO", SqlDbType.NVarChar, TxtTelefonoContacto);
            bd.Asignarparametro("@EMAILCONTACTO", SqlDbType.NVarChar, TxtEmailContacto);
            bd.Asignarparametro("@CIUDAD", SqlDbType.NVarChar, Txtciudad);
            bd.Asignarparametro("@DEPARTAMENTO", SqlDbType.NVarChar, TxtDepartamento);
            int reg = 0;
            reg = bd.Ejecutarcomando();
            if (reg > 0)
            {
                update = true;
             }
            }
            catch(Exception)
            {
                throw;
            }
            return update;
        }
        public bool ConsultarProveedor(string TXTIdProveedor)
      {
          bool consultar = false;
          try
          {
              bd.Conectar();
              bd.CrearComando(" SELECT IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO,EMAIL,RUT,NOMBRECONTACTO,TELEFONOCONTACTO,EMAILCONTACTO,CIUDAD,DEPARTAMENTO FROM PROVEEDOR WHERE IDPROVEEDOR='" + TXTIdProveedor + " '", System.Data.CommandType.Text);
              DbDataReader dr;
              dr = bd.EjecutarConsutaReader();
              if (dr.Read())
              {
                  _PID = Convert.ToString(dr["IDPROVEEDOR"]);
                  _PNOMBRE = Convert.ToString(dr["NOMBRE"]);
                  _PDIRECCION = Convert.ToString(dr["DIRECCION"]);
                  _PTELEFONO = Convert.ToString(dr["TELEFONO"]);
                  _PEMAIL = Convert.ToString(dr["EMAIL"]);
                  _PRUT = Convert.ToString(dr["RUT"]);
                  _PNOMBRECONTACTO = Convert.ToString(dr["NOMBRECONTACTO"]);
                  _PTELEFONOCONTACTO = Convert.ToString(dr["TELEFONOCONTACTO"]);
                  _PEMAILCONTACTO = Convert.ToString(dr["EMAILCONTACTO"]);
                  _PCIUDAD = Convert.ToString(dr["CIUDAD"]);
                  _PDEPARTAMENTO = Convert.ToString(dr["DEPARTAMENTO"]);
                  consultar = true;
              }
          }
          catch (Exception)
          {
              throw;    
          }
          return consultar;  
      }
        public void ConsultarListaProveedor(DataGridView DgProveedor)
        {
                CargarGrilla g = new CargarGrilla();
                DgProveedor.DataSource = null;
                g.Preparar("SELECT * FROM PROVEEDOR");
                g.Cargar(DgProveedor);
        }
        public bool InsertarCategoria(string TxtReferenciaCategoria, string TxtNombreCategoria) 
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CATEGORIA_PRODUCTO(IDCATEGORIA,NOMBRE)VALUES(@IDCATEGORIA,@NOMBRE)", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, TxtReferenciaCategoria);
                bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, TxtNombreCategoria);
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
        public bool  EliminarCategoria(string TxtReferenciaCategoria)
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM CATEGORIA_PRODUCTO WHERE IDCATEGORIA=@IDCATEGORIA", CommandType.Text);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, TxtReferenciaCategoria);
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
        public bool ActualizarCategoria(string TxtReferenciaCategoria, string TxtNombreCategoria)
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CATEGORIA_PRODUCTO SET [IDCATEGORIA]=@IDCATEGORIA,[NOMBRE]=@NOMBRE WHERE [IDCATEGORIA]=@IDCATEGORIA", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, TxtReferenciaCategoria);
                bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, TxtNombreCategoria);
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
        public bool  ConsultarCategoria(string TxtReferenciaCategoria)
        {
            bool consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando(" SELECT IDCATEGORIA,NOMBRE FROM CATEGORIA_PRODUCTO WHERE IDCATEGORIA='" + TxtReferenciaCategoria + " '", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, TxtReferenciaCategoria);
                DbDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CIDCATEGORIA = Convert.ToString(dr["IDCATEGORIA"]);
                    _CNOMBRECATEGORIA = Convert.ToString(dr["NOMBRE"]);
                    consultar = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consultar;
          }
        public bool InsertarProducto(string TxtReferenciaProducto, string CmbProveedor, string CmbCategoriaProducto,string Cmbmarca , string Rcdescripcion, string Txtstock, string TxtPrecio,string Txtprecioiva) 
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO PRODUCTO(IDPRODUCTO,IDPROVEEDOR,IDCATEGORIA,IDMARCA,DESCRIPCION,STOCK,PRECIOUNITARIO,PRECIOIVA)VALUES(@IDPRODUCTO,@IDPROVEEDOR,@IDCATEGORIA,@IDMARCA,@DESCRIPCION,@STOCK,@PRECIOUNITARIO,@PRECIOIVA)", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.Int, TxtReferenciaProducto);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, CmbProveedor);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, CmbCategoriaProducto);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Cmbmarca);
                bd.Asignarparametro("@DESCRIPCION", SqlDbType.NVarChar, Rcdescripcion);
                bd.Asignarparametro("@STOCK", SqlDbType.NVarChar, Txtstock);
                bd.Asignarparametro("@PRECIOUNITARIO", SqlDbType.NVarChar, TxtPrecio);
                bd.Asignarparametro("@PRECIOIVA", SqlDbType.NVarChar, Txtprecioiva);
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
        public bool EliminarProducto(string TxtReferenciaProducto)
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM PRODUCTO WHERE IDPRODUCTO=@IDPRODUCTO", CommandType.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.Int, TxtReferenciaProducto);
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
        public bool ActualizarProducto(string TxtReferenciaProducto, string CmbProveedor, string CmbCategoriaProducto,string Cmbmarca, string TxtNombreProducto, string Txtstock, string TxtPrecio,string Txtprecioiva) 
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE  PRODUCTO SET [IDPRODUCTO]=@IDPRODUCTO,[IDPROVEEDOR]=@IDPROVEEDOR,[IDCATEGORIA]=@IDCATEGORIA,[IDMARCA]=@IDMARCA,[DESCRIPCION]=@DESCRIPCION,[STOCK]=@STOCK,[PRECIOUNITARIO]=@PRECIOUNITARIO,[PRECIOIVA]=@PRECIOIVA WHERE [IDPRODUCTO]=@IDPRODUCTO", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.Int, TxtReferenciaProducto);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, CmbProveedor);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, CmbCategoriaProducto);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Cmbmarca);
                bd.Asignarparametro("@DESCRIPCION", SqlDbType.NVarChar, TxtNombreProducto);
                bd.Asignarparametro("@STOCK", SqlDbType.NVarChar, Txtstock);
                bd.Asignarparametro("@PRECIOUNITARIO", SqlDbType.NVarChar, TxtPrecio);
                bd.Asignarparametro("@PRECIOIVA", SqlDbType.NVarChar, Txtprecioiva);
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
        public bool ConsultarProducto(string TxtReferenciaProducto) 
        {
            bool consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando(" SELECT IDPRODUCTO,IDPROVEEDOR, IDCATEGORIA, IDMARCA,DESCRIPCION, STOCK,PRECIOUNITARIO,PRECIOIVA FROM PRODUCTO WHERE IDPRODUCTO='" + TxtReferenciaProducto + " '", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.VarChar, TxtReferenciaProducto);
                DbDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _PROIDPRODUCTO = Convert.ToString(dr["IDPRODUCTO"]);
                    _PROIDPROVEEDOR = Convert.ToString(dr["IDPROVEEDOR"]);
                    _PROIDCATEGORIA = Convert.ToString(dr["IDCATEGORIA"]);
                    _PROIDMARCA = Convert.ToString(dr["IDMARCA"]);
                    _PRONOMBRE = Convert.ToString(dr["DESCRIPCION"]);
                    _PROSTOCK = Convert.ToString(dr["STOCK"]);
                    _PROPRECIOUNITARIO = Convert.ToString(dr["PRECIOUNITARIO"]);
                    _VPRECIOIVA = Convert.ToString(dr["PRECIOIVA"]);
                    consultar = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consultar;
        }
        public void ConsultarProductosGenerales(DataGridView Dgproducto)
        {
                CargarGrilla g = new CargarGrilla();
                Dgproducto.DataSource = null;
                g.Preparar("SELECT * FROM PRODUCTO");
                g.Cargar(Dgproducto);
        }
        public void FIltrarGrilla(DataGridView Dgproducto,string TxtReferenciaProducto) 
        {
                CargarGrilla g = new CargarGrilla();
                Dgproducto.DataSource = null;
                g.Preparar("  SELECT IDPRODUCTO,DESCRIPCION, STOCK,PRECIOUNITARIO,PRECIOIVA FROM PRODUCTO WHERE IDPRODUCTO='" + TxtReferenciaProducto + " '");
                g.Cargar(Dgproducto);
        }
        public void FIltrarGrillaNombre(DataGridView Dgproducto, TextBox TxtfiltrarNombre)
        {
                CargarGrilla g = new CargarGrilla();
                Dgproducto.DataSource = null;
                g.Preparar("  SELECT IDPRODUCTO,DESCRIPCION, STOCK,PRECIOUNITARIO,PRECIOIVA FROM PRODUCTO WHERE DESCRIPCION='" + TxtfiltrarNombre.Text + " '");
                g.Cargar(Dgproducto);
        }
        public bool InsertarMarca(string Txtidmarca,string Txtnombremarca)
        {
            bool save = true;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO MARCA(IDMARCA,NOMBRE)VALUES(@IDMARCA,@NOMBRE)", CommandType.Text);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Txtidmarca);
                bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, Txtnombremarca);
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
        public bool EliminarMarca(string Txtidmarca) 
        {
            bool delete = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("DELETE FROM MARCA WHERE IDMARCA=@IDMARCA", CommandType.Text);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Txtidmarca);
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
        public bool  ConsultarMarca(string Txtidmarca) 
        {
            bool consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT IDMARCA,NOMBRE  FROM MARCA WHERE IDMARCA='" + Txtidmarca + " '", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Txtidmarca);
                DbDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _VIDMARCA = Convert.ToString(dr["IDMARCA"]);
                    _VNOMBREMARCA = Convert.ToString(dr["NOMBRE"]);
                    consultar = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return consultar;
        }
        public bool  ActualizarMarca(string Txtidmarca, string Txtnombremarca) 
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE MARCA  SET [IDMARCA]=@IDMARCA,[NOMBRE]=@NOMBRE WHERE [IDMARCA]=@IDMARCA", System.Data.CommandType.Text);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Txtidmarca);
                bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, Txtnombremarca);
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
        public bool InsertarProducto(DataGridView DgImportar) 
        {
            int i = 0;
            bool Save = false;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO PRODUCTO(IDPRODUCTO,IDPROVEEDOR,IDCATEGORIA,IDMARCA,DESCRIPCION,STOCK,PRECIOUNITARIO,PRECIOIVA)VALUES(@IDPRODUCTO,@IDPROVEEDOR,@IDCATEGORIA,@IDMARCA,@DESCRIPCION,@STOCK,@PRECIOUNITARIO,@PRECIOIVA)", System.Data.CommandType.Text);
                    bd.Asignarparametro("@IDPRODUCTO ", SqlDbType.Int, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, DgImportar.Rows[i].Cells[1].Value.ToString());
                    bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, DgImportar.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@IDMARCA", SqlDbType.Int, DgImportar.Rows[i].Cells[3].Value.ToString());
                    bd.Asignarparametro("@DESCRIPCION ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[4].Value.ToString());
                    bd.Asignarparametro("@STOCK ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[5].Value.ToString());
                    bd.Asignarparametro("@PRECIOUNITARIO ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[9].Value.ToString());
                    bd.Asignarparametro("@PRECIOIVA ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[7].Value.ToString());
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
        public bool InsertarMarca(DataGridView DgImportar) 
        {
            int i = 0;
            bool Save = false;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO MARCA(IDMARCA,NOMBRE)VALUES(@IDMARCA,@NOMBRE)", CommandType.Text);
                    bd.Asignarparametro("@IDMARCA ", SqlDbType.Int, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
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
        public bool InsertarCategoria(DataGridView DgImportar) 
        {
            int i = 0;
            bool Save = false;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO CATEGORIA_PRODUCTO(IDCATEGORIA,NOMBRE)VALUES(@IDCATEGORIA,@NOMBRE)", System.Data.CommandType.Text);
                    bd.Asignarparametro("@IDCATEGORIA ", SqlDbType.Int, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
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
        public bool InsertarProveedor(DataGridView DgImportar) 
        {
            int i = 0;
            bool Save = false;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO PROVEEDOR(IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO,EMAIL,RUT,NOMBRECONTACTO,TELEFONOCONTACTO,EMAILCONTACTO,CIUDAD,DEPARTAMENTO)Values(@IDPROVEEDOR,@NOMBRE,@DIRECCION,@TELEFONO,@EMAIL,@RUT,@NOMBRECONTACTO,@TELEFONOCONTACTO,@EMAILCONTACTO,@CIUDAD,@DEPARTAMENTO)", System.Data.CommandType.Text);
                    bd.Asignarparametro("@IDCATEGORIA ", SqlDbType.Int, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@NOMBRE", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
                    bd.Asignarparametro("@DIRECCION ", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@TELEFONO", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[3].Value.ToString());
                    bd.Asignarparametro("@EMAIL ", SqlDbType.Int, DgImportar.Rows[i].Cells[4].Value.ToString());
                    bd.Asignarparametro("@RUT", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[5].Value.ToString());
                    bd.Asignarparametro("@NOMBRECONTACTO ", SqlDbType.Int, DgImportar.Rows[i].Cells[6].Value.ToString());
                    bd.Asignarparametro("@TELEFONOCONTACTO", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[7].Value.ToString());
                    bd.Asignarparametro("@CIUDAD ", SqlDbType.Int, DgImportar.Rows[i].Cells[8].Value.ToString());
                    bd.Asignarparametro("@DEPARTAMENTO", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[9].Value.ToString());
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
        public bool ControlOperador(DataGridView DgImportar) 
        {
            int i = 0;
            bool Save = false;
            try
            {
                foreach (DataGridViewRow Rows in DgImportar.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERT INTO CONTROLOPERADOR(DOCUMENTO,NOFACTURA,USERNAME,NOMBRES,APELLIDOS,HORAINICIO,HORAFIN,FECHA)Values(@DOCUMENTO(@,NOFACTURA,(@USERNAME,(@NOMBRES,(@APELLIDOS,(@HORAINICIO,(@HORAFIN,(@FECHA)", System.Data.CommandType.Text);
                    bd.Asignarparametro("@DOCUMENTO ", SqlDbType.Int, DgImportar.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@NOFACTURA", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[1].Value.ToString());
                    bd.Asignarparametro("@USERNAME ", SqlDbType.Int, DgImportar.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@NOMBRES", SqlDbType.NVarChar, DgImportar.Rows[i].Cells[3].Value.ToString());
                    bd.Asignarparametro("@APELLIDOS ", SqlDbType.Int, DgImportar.Rows[i].Cells[4].Value.ToString());
                    bd.Asignarparametro("@HORAINICIO", SqlDbType.Date, DgImportar.Rows[i].Cells[5].Value.ToString());
                    bd.Asignarparametro("@HORAFIN ", SqlDbType.Date, DgImportar.Rows[i].Cells[6].Value.ToString());
                    bd.Asignarparametro("@FECHA", SqlDbType.DateTime, DgImportar.Rows[i].Cells[7].Value.ToString());
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
        public bool ConsultarProducto(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM PRODUCTO");
            g.Cargar(DgExportar);
            return con;
        }
        public bool ConsultarProveedor(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM PROVEEDOR");
            g.Cargar(DgExportar);
            return con;
        }
        public bool ConsultarMarca(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM MARCA");
            g.Cargar(DgExportar);
            return con;
        }
        public bool ConsultarCategoria(DataGridView DgExportar)
        {
            bool con = true;
            CargarGrilla g = new CargarGrilla();
            DgExportar.DataSource = null;
            g.Preparar("SELECT * FROM CATEGORIA_PRODUCTO");
            g.Cargar(DgExportar);
            return con;
        }
    }
}
