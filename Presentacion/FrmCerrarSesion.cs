using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCerrarSesion : Form
    {
        public FrmCerrarSesion()
        {
            InitializeComponent();
        }
        private void FrmCerrarSesion_Load(object sender, EventArgs e)
        {
            Asignar();
            GuardarDatos();
            ControlDatos();
    
        }
        public string _EnviarDocumento;
        public string _EnviarHoraInicio;
        public string _EnviarHoraFin;
        string Documento, HoraI, Horaf;

        Negocio.Functions fun = new Negocio.Functions();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        private void GuardarDatos() 
        {
            
            Documento = _EnviarDocumento;
            HoraI = _EnviarHoraInicio;
            Horaf = _EnviarHoraFin;
            DateTime horai = Convert.ToDateTime(HoraI);
            DateTime horaf = Convert.ToDateTime(Horaf);
            HoraI = horai.ToString("HH:mm");
            Horaf = horaf.ToString("HH:mm");
    
        }
        public bool CargarBarra()
        {
            bool CargarBarra = false;
            int i = 0;
            Pbcontrol.Maximum = 100;
            Pbcontrol.Minimum = 0;
            Pbcontrol.Value = 0;
            Pbcontrol.Step = 1;
            for (i = Pbcontrol.Minimum; i < Pbcontrol.Maximum; i = i + Pbcontrol.Step)
            {
                Pbcontrol.PerformStep();
            }
            CargarBarra = true;
            return CargarBarra;
        }
        private void Asignar() 
        {
            try
            {
                if (Auditoria.UltimoControlOperador())
                {
                    LblRegistro.Text = Auditoria._UltimoIdControl;
                    int cont = Convert.ToInt32(LblRegistro.Text);
                    cont = cont + 1;
                    LblRegistro.Text = Convert.ToString(cont);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }
        private void ControlDatos()
        {
            Crono.Start();
            Lblestado.Text = "Estado:Guardando ....";
            try
            {
                if (CargarBarra()) 
                {

                    if (fun.GuardarControlOperador(LblRegistro,Convert.ToString(Documento), Convert.ToString(HoraI), Convert.ToString(Horaf), Dtfecha.Value)) 
                    {
                        Pbcontrol.BackColor = Color.Green;
                        Lblestado.Text = "Estado:Guardado";
                    }
                    else 
                    {
                        Pbcontrol.BackColor = Color.Red;
                        Lblestado.Text = "Estado: Error al guardar los datos";
                    }
                    
                }
            }
            catch (Exception)
            {
                Pbcontrol.BackColor = Color.Red;
                Lblestado.Text = "Estado: no se pudo guardar archivos";

            }
    
        }

        private void Crono_Tick(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            Double total = Convert.ToDouble(Contimer.Text);
            total = total + 1;
            Contimer.Text = total.ToString();
            if(Contimer.Text =="2")
            {
                Crono.Stop();
                this.Close();
                frm.Show();
            }
        }
      
    }
}
