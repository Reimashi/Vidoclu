using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.Utils;

namespace Vidoclu
{
    public partial class formConsultaUsuarios : Form
    {
        private String data;

        public formConsultaUsuarios(String title, Icon ico)
        {
            InitializeComponent();

            this.Text = title;
            this.Icon = ico;

            this.cbEdad.SelectedIndex = 0;
            this.cbSexo.SelectedIndex = 0;
        }

        public formConsultaUsuarios(String title, Icon ico, String[] data)
        {
            InitializeComponent();

            this.Text = title;
            this.Icon = ico;

            this.cbEdad.SelectedIndex = 0;
            this.cbSexo.SelectedIndex = 0;

            this.tbUsuario.Text = data[0];
            this.tbApellidos.Text = data[1];
            this.tbDNI.Text = data[2];
            this.cbEdad.SelectedItem = data[3];
            this.cbSexo.SelectedItem = data[4];
            this.tbTelefono.Text = data[5];
            this.tbDirección.Text = data[6];

            this.data = null;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbUsuario.Text != "" && this.tbUsuario.TextLength >= 3)
            {
                data = tbUsuario.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. El usuario no puede ser una cadena vacía \nni puede tener menos de 3 caracteres.", "Error en Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';

            if (this.tbApellidos.Text != "" && this.tbApellidos.TextLength >= 8)
            {
                data += tbApellidos.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. Los apellidos no pueden ser una cadena vacía \nni pueden tener menos de 8 caracteres.", "Error en Apellidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';

            if (this.tbDNI.TextLength == 8)
            {
                data += tbDNI.Text + '-' + tbDNILetra.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. El DNI no está completo.", "Error en DNI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';
            data += this.cbEdad.SelectedItem.ToString();

            data += '#';
            data += this.cbSexo.SelectedItem.ToString();

            data += '#';

            if (this.tbTelefono.TextLength == 14)
            {
                data += tbTelefono.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. El telefono no está completo.", "Error en Telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';

            if (this.tbDirección.Text != "" && this.tbDirección.TextLength >= 8)
            {
                data += tbDirección.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. La dirección no puede ser una cadena vacía \nni puede tener menos de 8 caracteres.", "Error en Dirección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        public String getData()
        {
            return data;
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventReply.KeyPress_OnlyLetters(sender, e);
        }

        private void tbApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventReply.KeyPress_OnlyLetters(sender, e);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventReply.KeyPress_OnlyNumbers(sender, e);
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventReply.KeyPress_OnlyNumbers(sender, e);
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (this.tbDNI.Text.Length == 8)
            {
                this.tbDNILetra.Text = CheckCodes.CheckDNI(this.tbDNI.Text).ToString();
            }
            else
            {
                this.tbDNILetra.Text = "";
            }
        }
    }
}
