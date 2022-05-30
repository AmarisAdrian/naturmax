using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;

namespace Negocio
{
    public class CargarGrilla
    {
        private BaseDatos bd;
        public void Preparar(string vcomnado)
        {
            bd = new BaseDatos();

            bd.Conectar();
            bd.CrearComando(vcomnado, CommandType.Text);
        }
        public void AsignarParametro(string vNombre, SqlDbType vTipo, Object vValor)
        {
            bd.Asignarparametro(vNombre, vTipo, vValor);
        }
        public void Cargar(DataGridView vGrilla)
        {
            DataTable dt = new DataTable();
            dt = bd.EjecutarConsulta();
            vGrilla.DataSource = dt;

        }

        public void cargar(DataGridView vGrilla, string vComando)
        {
            Preparar(vComando);
            Cargar(vGrilla);

        }

    }
}
