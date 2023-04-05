using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmAbrirCaja : Form
    {
        public FrmAbrirCaja()
        {
            InitializeComponent();
           
        }
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        public string _Switch;
        public string _Documento;
        public string _Equipo;
        private void FrmCaja_Load(object sender, EventArgs e)
        {
            Asignar();
            UltimoRegistro();
            Hora();
            Combos();
        }
        private void Combos()
        {
            try
            {
                Negocio.Functions Cargar = new Negocio.Functions();
                Cargar.CargarComboEstadoCaja(Cmbestado);
                Cmbestado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hora()
        {
            LblHora.Text = DateTime.Now.ToShortTimeString();
            DateTime horai = Convert.ToDateTime(LblHora.Text);
            LblHora.Text = horai.ToString("HH:mm");
        }
        private void Asignar() 
        {

            try
            {
                Txtdocumento.Text = _Documento;
                Txtequipo.Text = _Equipo;
                if (Auditoria.UltimoCierre())
                {
                    Txtsaldoanterior.Text = Auditoria._UltimoCierre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }

        }
        private void UltimoRegistro()
        {
            try
            {
                if (Auditoria.UltimoRegistro())
                {
                    Txtregistro.Text = Auditoria._UltimoIdRegistro;
                    int cont = Convert.ToInt32(Txtregistro.Text);
                    cont = cont + 1;
                    Txtregistro.Text = Convert.ToString(cont);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }
        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Auditoria.AbrirRegistro(Txtregistro,Cmbestado,Txtequipo, Txtdocumento, Dtfecha.Value) && (Auditoria.AbrirCaja(Txtregistro, Txtsaldoanterior, TxtIngresarMonto, LblHora))) 
                {
                    MessageBox.Show("Caja abierta exitosamente","Caja Abierta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("No se pudo abrir la caja", "Error al abrir caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Ocurrio el siguiente error"); 
            }
        }

        private void TxtIngresarMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
