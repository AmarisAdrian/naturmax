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
    public partial class FrmPanelControl : Form
    {
        public FrmPanelControl()
        {
            InitializeComponent();
        }
        Negocio.ProcesosSecundarios Pro = new Negocio.ProcesosSecundarios();
        Negocio.Validaciones val = new Negocio.Validaciones();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        Negocio.Usuario Usuario = new Negocio.Usuario();
        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            if (CmbAccion.SelectedIndex == 1)
            {
                try
                {
                    if (TxtIdCaja.Text == "" || Txtnumero.Text == "")
                    {
                        MessageBox.Show("No puede haber campos vacios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Pro.GuardarCaja(TxtIdCaja, Txtnumero))
                    {
                        MessageBox.Show("Caja guardada exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, GbCaja);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CmbAccion.SelectedIndex == 2)
            {
                try
                {
                    if (TxtIdCaja.Text == "" || Txtnumero.Text == "")
                    {
                        MessageBox.Show("No puede haber campos vacios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Pro.ActualizarCaja(TxtIdCaja, Txtnumero))
                    {
                        MessageBox.Show("Caja editada exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, GbCaja);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CmbAccion.SelectedIndex == 3)
            {
                try
                {
                    if (Txtnumero.Text == "")
                    {
                        MessageBox.Show("El numero de la caja no puede ir vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Pro.EliminarCaja(Txtnumero))
                    {
                        MessageBox.Show("Caja Eliminada exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.LimpiarCampos(this, GbCaja);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CmbAccion.SelectedIndex == 4)
            {
                try
                {
                    if (Txtnumero.Text == "")
                    {
                        MessageBox.Show("para consultar por favor rellene el campo numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Pro.ConsultarCaja(Txtnumero))
                    {
                        TxtIdCaja.Text = Pro._IdCaja;
                    }
                    else
                    {
                        MessageBox.Show("La caja no existe", "Caja no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FrmPanelControl_Load(object sender, EventArgs e)
        {
            Combos();
        }
        private void Btnabrir_Click(object sender, EventArgs e)
        {
            Auditoria.EstadoDecaja(Dgcajas);

            for (int i = 0; i < Dgcajas.Rows.Count; i++)
            {
                if (Dgcajas.Rows[i].Cells[2].Value.ToString() == "DISPONIBLE")
                {
                    Dgcajas.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
                else if (Dgcajas.Rows[i].Cells[2].Value.ToString() == "Abierta")
                {
                    Dgcajas.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Blue;
                }
                else if (Dgcajas.Rows[i].Cells[2].Value.ToString() == "Parcialmente Cerrada")
                {
                    Dgcajas.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                }
                else if (Dgcajas.Rows[i].Cells[2].Value.ToString() == "Totalmente Cerrada")
                {
                    Dgcajas.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void Txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }
        private void Txtnumerocaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }
        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }
        private void Combos()
        {
            try
            {
                Negocio.Functions Cargar = new Negocio.Functions();
                Cargar.CargarComboEstadoCaja(CmbEstadoCierre);
                CmbEstadoCierre.SelectedIndex = -1;
                Cargar.CargarComboEstado(CmbEstado);
                CmbEstado.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Inhabilitar()
        {
            TxtDocumento.Enabled = false;
            TxtMontoIngresado.Enabled = false;
            CmbEstadoCierre.Enabled = false;
            TxtMontoR.Enabled = false;
        }
        private void Habilitar()
        {
            TxtDocumento.Enabled = true;
            TxtMontoIngresado.Enabled = true;
            CmbEstadoCierre.Enabled = true;
            TxtMontoR.Enabled = true;
        }

        private void CbHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (CbHabilitar.Checked == true)
            {
                Habilitar();
            }
            else
            {
                Inhabilitar();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Auditoria.EstadoDeCierre(Txtnumerocaja, Dtfecha.Value))
                {
                    TxtIdRegistro.Text = Auditoria._UltimoIdRegistro;
                    TxtDocumento.Text = Auditoria._DocumentoOPerador;
                    Txtfecha.Text = Auditoria._Fecha;
                    TxtMontoA.Text = Auditoria._MontoA;
                    TxtMontoIngresado.Text = Auditoria._MontoI;
                    TxtHoraApertura.Text = Auditoria._HoraI;
                    CmbEstadoCierre.SelectedValue = Auditoria._Estado;
                    TxtFacturasGeneradas.Text = Auditoria._FacturasGeneradas;
                    TxtMontoR.Text = Auditoria._MontoR;
                    TxtHoraCierre.Text = Auditoria._HoraF;
                    Txttotal.Text = Auditoria._Total;
                }
                else
                {
                    MessageBox.Show("No existe registro asociado con el numero de la caja para el dia de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDocumento.Text == "" || TxtMontoIngresado.Text == "" || CmbEstadoCierre.SelectedIndex == -1 || TxtMontoR.Text == "")
                {
                    MessageBox.Show("Para actualizar los datos por favor rellene los datos necesarios", "Advertenci", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (Auditoria.ActualizacionCerrarCaja(TxtIdRegistro, TxtFacturasGeneradas, TxtMontoR, TxtHoraCierre, Txttotal) && (Auditoria.ActualizacionEstadoDeCierre(TxtIdRegistro, CmbEstadoCierre)))
                {
                    MessageBox.Show("La actualizacion del cierre de caja fue exitoso", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    val.LimpiarCampos(this, GbEstadoApertura);
                    val.LimpiarCampos(this, GbestadoCierre);
                    val.LimpiarCampos(this, GbEstadoRegistro);
                }
                else
                {
                    MessageBox.Show("No se pudo editar", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }

        private void BtnBuscarCierre_Click(object sender, EventArgs e)
        {
            if (Auditoria.EstadoCierreSesion(DgControlCierre))
            {
                this.DgControlCierre.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                this.DgControlCierre.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            }
        }


        private void TxtBuscarDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Auditoria.EstadoCierreSesion(DgControlCierre, TxtBuscarDocumento))
                {
                    this.DgControlCierre.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    this.DgControlCierre.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
                }
            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            for (int i = Dgcajas.Rows.Count - 1; i >= 0; i--)
            {
                Dgcajas.Rows.RemoveAt(i);
            }
        }

        private void BtnlimpiarDg_Click(object sender, EventArgs e)
        {
            for (int i = DgControlCierre.Rows.Count - 1; i >= 0; i--)
            {
                DgControlCierre.Rows.RemoveAt(i);
            }
        }

        private void Btncontrolfactura_Click(object sender, EventArgs e)
        {
            if (Auditoria.EstadoControlfactura(DgcontrolFactura)) 
            {
                this.DgcontrolFactura.RowsDefaultCellStyle.BackColor = Color.LightYellow;
                this.DgcontrolFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void BtnLimpiarFactura_Click(object sender, EventArgs e)
        {
            for (int i = DgcontrolFactura.Rows.Count - 1; i >= 0; i--)
            {
                DgcontrolFactura.Rows.RemoveAt(i);
            }
        }

        private void TxtDocumentoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Auditoria.EstadoControlfactura(DgcontrolFactura, TxtDocumentoFactura))
                {
                    this.DgcontrolFactura.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    this.DgcontrolFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
                }
            }
        }

        private void Cbfiltrarfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbfiltrarfecha.Checked == true) 
            {
                if (Auditoria.EstadoControlfacturaFecha(DgcontrolFactura))
                {
                    this.DgcontrolFactura.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    this.DgcontrolFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
                }
            }
        }
        private void BtnBuscarContraseña_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Auditoria.ConsultarContraseña(TxtRecuperarDoc))
                {
                    TxtContraseña.Text = Auditoria._Password;
                }
                else 
                {
                    MessageBox.Show("El usuario no existe","Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        }

        private void TxtRecuperarDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (Auditoria.ConsultarContraseña(TxtRecuperarDoc))
                    {
                        TxtContraseña.Text = Auditoria._Password;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnlimpiarContraseña_Click(object sender, EventArgs e)
        {
            val.LimpiarCampos(this,GbContraseña);
        }

        private void BtnLimpiarCorreo_Click(object sender, EventArgs e)
        {
            TxtIdEmail.Clear();
            TxtEmail.Clear();
            CmbAccionRapida.SelectedIndex = -1;
        }

        private void BtnAceptarCorreo_Click(object sender, EventArgs e)
        {
            if (CmbAccionRapida.SelectedIndex == 1)
            {
                if (val.ValidarEmail(TxtEmail.Text))
                {
                    try
                    {                      
                        if (Pro.GuardarEmail(TxtIdEmail, TxtEmail))
                        {
                            MessageBox.Show("Email guardado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar email", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
                    }
                }
            }
                else if (CmbAccionRapida.SelectedIndex == 2) 
                { 
                 if (val.ValidarEmail(TxtEmail.Text))
                  {
                    try
                    {
                       if (Pro.ActualizarEmail(TxtIdEmail, TxtEmail))
                        {
                            MessageBox.Show("Email Actualizado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Actualizar email", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
                    }
                  }
               }
                else if (CmbAccionRapida.SelectedIndex == 3) 
                {
                    try
                    {
                        if (Pro.EliminarEmail(TxtIdEmail))
                        {
                            MessageBox.Show("Email eliminado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar email", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
                    }
                }
                else if (CmbAccionRapida.SelectedIndex == 4)
                {
                    try
                    {
                        if (Pro.ConsultarEmail(TxtIdEmail))
                        {
                            TxtEmail.Text = Pro._Email;
                        }
                        else
                        {
                            MessageBox.Show("El email no existe", "Proceso Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
                    }
                }
        }

        private void TxtIdEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }

        private void BtnBuscarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (Auditoria.ConsultarEstadoOperador(TxtDocEstado))
                {
                    CmbEstado.SelectedValue = Auditoria._Estado;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Ha ocurrido el siguiente error");
            }
        }

        private void BtnLimpiarEstado_Click(object sender, EventArgs e)
        {
            val.LimpiarCampos(this,GbEstadoOperador);
        }

        private void GbEstadoOperador_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuario.ActualizarOperario(TxtDocEstado, CmbEstado))
                {
                    MessageBox.Show("Estado de usuario actualizado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar estado usuario", "fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtDocEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (Auditoria.ConsultarEstadoOperador(TxtDocEstado))
                    {
                        CmbEstado.SelectedValue = Auditoria._Estado;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
                }
            }
        }

    }
}
