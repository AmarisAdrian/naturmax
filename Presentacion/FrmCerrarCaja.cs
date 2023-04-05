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
    public partial class FrmCerrarCaja : Form
    {
        public FrmCerrarCaja()
        {
            InitializeComponent();
        }
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        Negocio.Functions fun = new Negocio.Functions();
        public string _Documento;
        public string _Equipo;
        private void BtnDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {

            try
            {
                    if (TxtMontoRetirar.Text == "" || CmbCerrado.SelectedIndex == -1)
                    {
                        TxtMontoRetirar.Text = "0";
                    }
                    else if (Auditoria.CerrarCaja(TxtIdregistro, TxtFacturasGeneradas, TxtMontoRetirar, LblHoraF,TxtSaldoGuardar)&& (Auditoria.ActualizacionEstadoDeCierre(TxtIdregistro,CmbCerrado)))
                    {
                        MessageBox.Show("Ha cerrado caja Correctamente", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al cerrar caja", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCerrarCaja_Load(object sender, EventArgs e)
        {      
            CerrarCaja();
            UltimoRegistro();
            Combos();
            Hora();
            Txtdocumento.Text = _Documento;
            Txtequipo.Text = _Equipo;
        }
        private void Hora()
        {
            LblHoraF.Text = DateTime.Now.ToShortTimeString();
            DateTime horai = Convert.ToDateTime(LblHoraF.Text);
            LblHoraF.Text = horai.ToString("HH:mm");
        }
        private void Combos()
        {
            try
            {
                Negocio.Functions Cargar = new Negocio.Functions();
                Cargar.CargarComboEstadoCaja(CmbCerrado);
                CmbCerrado.SelectedIndex = -1;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CerrarCaja() 
        {
            try
            {
                if (Auditoria.ConsultarCerrarCaja(Dtfecha.Value) && (fun.RegistroDia(Convert.ToString(Dtfecha.Value.ToShortDateString()))))
                {
                    TxtIdregistro.Text = Auditoria._IdRegistroAbierto;
                    Txtdocumento.Text = Auditoria._DocumentoOPerador;
                    Txtequipo.Text = Auditoria._IdCaja;
                    TxtFacturasGeneradas.Text = fun._RegistroDia;
                    Txttotal.Text = Auditoria._Total;
                    TxtSaldoGuardar.Text = Txttotal.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }
        private void TxtMontoRetirar_TextChanged(object sender, EventArgs e)
        {
                decimal Total=0;
                if (TxtMontoRetirar.Text == "")
                {

                    TxtSaldoGuardar.Text = Txttotal.Text;
                }
                else
                {
                    Total = Convert.ToDecimal(Txttotal.Text) - Convert.ToDecimal(TxtMontoRetirar.Text);
                    TxtSaldoGuardar.Text = Convert.ToString(Total);
                }
        }
        private void UltimoRegistro()
        {
            try
            {
                if (Auditoria.UltimoRegistro())
                {
                    TxtIdregistro.Text = Auditoria._UltimoIdRegistro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }

        private void TxtMontoRetirar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CmbCerrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCerrado.SelectedIndex == 0)
            {
                CmbCerrado.SelectedIndex = -1;
            }
            if (CmbCerrado.SelectedIndex == 2)
            {
                MessageBox.Show("El cierre total se realiza al terminar la jornada y al cerrar la caja total no puede seguir realizando procesos de facturacion, si desea seguir facturando posteriormente realice un cierre parcial.Solo se puede hacer un vez el cierre total, el cierre parcial puede hacerse varias veces.","Atencion",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
