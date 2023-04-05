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
    public partial class FrmCambiarContraseña : Form
    {
        public FrmCambiarContraseña()
        {
            InitializeComponent();
        }
        public string _Documento;
        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {
            lbldocumento.Text = _Documento;
            Password();
        }
        Negocio.ProcesosSecundarios Proceso = new Negocio.ProcesosSecundarios();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtPassnueva.Text==""||Txtpassantigua.Text==""||Txtconfirmar.Text=="")
                {
                    MessageBox.Show("Hay campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(Txtpassantigua.Text!= LblPassword.Text)
                {
                    MessageBox.Show("Contraseña antigua erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtPassnueva.Text != Txtconfirmar.Text)
                {
                    MessageBox.Show("Las contraseña no concuerdan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txtconfirmar.Clear();
                    TxtPassnueva.Clear();
                }
                else if (TxtPassnueva.Text == TxtPassnueva.Text)
                {
                    if (Proceso.ActualizarContraseña(lbldocumento, Txtconfirmar))
                    {
                        MessageBox.Show("Se ha actualizado su contraseña exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error");
            }
        }
        private void Password() 
        {
            try
            {
                if (Auditoria.ConsultarContraseña(lbldocumento))
                {
                    LblPassword.Text = Auditoria._Password;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
