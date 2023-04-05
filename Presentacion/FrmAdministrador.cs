using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Presentacion
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }
        public string _Documento;
        public string _Nombre;
        public string _Apellido;
        public byte[] _FOTOPERADOR;
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
        }
        private void BtnProvedor_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.Show();
        }
        private void BtnConsultaProductos_Click(object sender, EventArgs e)
        {
            FrmReferenciaProducto frm = new FrmReferenciaProducto();
            frm.Show();
        }
        private void Btnsubir_Click(object sender, EventArgs e)
        {
            FrmCargar frm = new FrmCargar();
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void BtnPanelControl_Click(object sender, EventArgs e)
        {
            FrmPanelControl frm = new FrmPanelControl();
            frm.Show();
        }
        private void BtnAuditoria_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Frmlogin frm = new Frmlogin();
                this.Close();
                frm.Show();
            }
        }
        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            Pbfoto.Image = ByteArrayToImage(_FOTOPERADOR);
            Lbldocumento.Text = _Documento;
            LblNombres.Text = _Nombre;
            LblApellidos.Text = _Apellido;
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
        private void BtnContactos_Click_1(object sender, EventArgs e)
        {
            int Cod = 1;
            FrmCliente frm = new FrmCliente();
            frm._CodigoHabilitacion = Cod;
            frm.Show();
        }

        private void BtnOperadores_Click(object sender, EventArgs e)
        {
            Frmusuarios frm = new Frmusuarios();
            frm.Show();
        } 

    }
}
