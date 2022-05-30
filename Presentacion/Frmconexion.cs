using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Negocio;

namespace Presentacion
{
    public partial class Frmconexion : Form
    {
        public Frmconexion()
        {
            InitializeComponent();
        }
      
        private void Btnvolver_Click(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            frm.Show();
            this.Hide();
          }
        private void Btnprobar_Click(object sender, EventArgs e)
        {
 

            Negocio.Seguridad Val = new Negocio.Seguridad();
            Negocio.Functions Fun = new Negocio.Functions();    
            CargarBarra();      

               if (Negocio.Seguridad.ConexionInternet())
               {
                   Lblinternet.BackColor = System.Drawing.Color.Green;
               }
               else
               {
                   Lblinternet.BackColor = System.Drawing.Color.Red;
               }
               if (Val.ConexionDatos())
               {
                   Lbldatos.BackColor = System.Drawing.Color.Green;
               }
               else
               {
                   Lbldatos.BackColor = System.Drawing.Color.Red;
               }
            
                // Lblservidor.BackColor =  System.Drawing.Color.Red;
            }   
        private void CargarBarra()
        {
     
            int i = 0;
            PGBconexion.Maximum = 101;
            PGBconexion.Minimum = 0;
            PGBconexion.Value = 0;
            PGBconexion.Step = 1;
            for (i = PGBconexion.Minimum; i < PGBconexion.Maximum; i = i + PGBconexion.Step)
            {
                PGBconexion.PerformStep();
            }
        }
        private void Frmconexion_Load(object sender, EventArgs e)
        {
            Lblesperar.Visible = false;
        }
    }
}
