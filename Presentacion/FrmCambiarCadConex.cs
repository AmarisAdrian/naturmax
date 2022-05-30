using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Runtime.InteropServices;
using System.Data.Common;
using System.Reflection;
using Negocio;

namespace Presentacion
{
    public partial class FrmCambiarCadConex : Form
    {
        public FrmCambiarCadConex()
        {
            InitializeComponent();
        }
        Negocio.Functions F = new Negocio.Functions();
        private void FrmCambiarCadConex_Load(object sender, EventArgs e)
        {
        }
        private void Btnobtener_Click(object sender, EventArgs e)
        {
            F.ObtenerCadConex();
            Txtcadena.Text = F._Cadena;
        }
        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            frm.Show();
            this.Hide();
        }
        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            if (TxtBaseDatos.Text == "" || Txtservidor.Text =="")
            {
                MessageBox.Show("Los campos (Server Name),(Base Datos) No pueden estar vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CbSeguridad.Checked == true)
            {
                if (TxtUsuario.Text == "" || TxtPassword.Text == "")
                {
                    MessageBox.Show("Los campos (usuario),(Password) No pueden estar vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Txtcadenafinal.Text = "data source=" + "'" + Txtservidor.Text + "'; initial catalog=" + "'" + TxtBaseDatos.Text + "'" + "; user id=" + "'" + TxtUsuario.Text + "'" + "; password=" + "'" + TxtPassword.Text + "'";
                }
            }
            else if (CbSeguridad.Checked==false)
            {
                Txtcadenafinal.Text = "data source=" + "'" + Txtservidor.Text + "'; initial catalog=" + "'" + TxtBaseDatos.Text + "'" + ";Integrated Security=True'";
            }   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            F.CargarBasesDatos(DgbasesDatos);
        }
        private void DgbasesDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TxtBaseDatos.Text = Convert.ToString(this.DgbasesDatos.CurrentRow.Cells[0].Value);
        }
        private void BtnInstancias_Click(object sender, EventArgs e)
        {
            F.CargarInstancias(Dginstancias);
        }
        private void Dginstancias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Txtservidor.Text = Convert.ToString(this.Dginstancias.CurrentRow.Cells[0].Value);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSeguridad.Checked == true)
            {
                TxtUsuario.Enabled = true;
                TxtPassword.Enabled = true;
            }
            else 
            {
                TxtUsuario.Enabled = false;
                TxtPassword.Enabled = false;
                TxtUsuario.Text = "";
                TxtPassword.Text = "";
            }

        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Txtcadenafinal.Text == "")
            {
                MessageBox.Show("No se ha asignado la nueva cadena de conexion , por favor verifique de nuevo", "Advertencia",MessageBoxButtons.OK ,MessageBoxIcon.Stop);
            }
            else
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string path = assembly.Location;
                Configuration config = ConfigurationManager.OpenExeConfiguration(path);
                config.ConnectionStrings.ConnectionStrings["Cadena"].ConnectionString = Txtcadenafinal.Text;
                config.Save(ConfigurationSaveMode.Modified);
                val = 1;
            }
            if (val == 1)
            {
                DialogResult result;
                result = MessageBox.Show("Los cambios se harán patentes al reiniciar el programa. ¿Desea reiniciarlo ahora?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }            
        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            this.Hide();
            frm.Show();           
        }
    }
}
