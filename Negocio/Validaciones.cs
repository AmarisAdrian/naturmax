using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Negocio
{
    public class Validaciones
    {
        public Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool ValidarSoportetecnico(TextBox Txtsoportedoc, TextBox Txtsoporteemail, RichTextBox Rtbsoporte)
        {
            bool val = false;
            if (Txtsoportedoc.Text == "" || Txtsoporteemail.Text == "" || Rtbsoporte.Text == "")
            {
                val = true;
            }
            else 
            {
                val = false;
            }
            return val;
        } 
        public bool ValidarModificar(TextBox TxtDocOperador, TextBox TxtPasswordOperador, TextBox TxtNombresOperador, TextBox TxtApellidosOperador, ComboBox CmbGeneroOperador, ComboBox CmbEstadoOperador, ComboBox CmbTipoOperador, TextBox TxtTelefonoOperador, TextBox TxtMovilOperador, TextBox TxtEmailOperador, TextBox TxtCiudadOperador, TextBox TxtDireccionOperador) 
        {
            bool Vacio = false;
            if( TxtDocOperador.Text =="" ||TxtPasswordOperador.Text ==""|| TxtNombresOperador.Text ==""||TxtApellidosOperador.Text=="" ||CmbGeneroOperador.SelectedIndex ==-1|| CmbEstadoOperador.SelectedIndex == -1 ||CmbTipoOperador.SelectedIndex == -1|| TxtTelefonoOperador.Text ==""||  TxtMovilOperador.Text =="" ||TxtEmailOperador.Text ==""||TxtCiudadOperador.Text =="" || TxtDireccionOperador.Text ==""  )
            {
                Vacio = true;
            }
            else
            {
                Vacio = false;
            }
            return Vacio; 
        }    
        public void LimpiarCampos(Control control,GroupBox gb) 
        {
            foreach(var  txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = -1;
                }
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = -1;
                }
            }
        }
    }
}
