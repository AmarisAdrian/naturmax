using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AccesoDatos;

namespace Negocio
{
    public class CargarCombo
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();

        public void Preparar(string vComando)
        {
            bd.Conectar();
            bd.CrearComando(vComando, CommandType.Text);
        }

        public void AsignarParametro(string vNombre, SqlDbType vTipo, object vValor)
        {
            bd.Asignarparametro(vNombre, vTipo, vValor);
        }

        public void Cargar(ComboBox vCombo, string vValueMember, string vDisplayMember)
        {
            DataTable dt = new DataTable();
            dt = bd.EjecutarConsulta();
            vCombo.DataSource = dt;
            vCombo.ValueMember = vValueMember;
            vCombo.DisplayMember = vDisplayMember;
        }

        public void Cargar(ComboBox vCombo, string vComando, string vValueMember, string vDisplayMember)
        {
            Preparar(vComando);
            Cargar(vCombo, vValueMember, vDisplayMember);

        }

    }
}