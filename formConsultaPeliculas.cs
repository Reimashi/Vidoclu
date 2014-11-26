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
    public partial class formConsultaPeliculas : Form
    {
        private String data;

        public formConsultaPeliculas(String title, Icon ico)
        {
            InitializeComponent();

            this.Text = title;
            this.Icon = ico;

            this.cbClasificación.SelectedIndex = 0;
            this.lbGenero.SelectedIndex = 0;
            this.tbDuracion.Text = "(Min.)";

            try
            {
                this.pbCaratula.Image = PSLibrary.Utils.Image.Resize(new Bitmap("./db/images/default.png"), 181, 222);
            }
            catch { }

            this.data = null;
        }

        public formConsultaPeliculas(String title, Icon ico, String[] data)
        {
            InitializeComponent();

            this.Text = title;
            this.Icon = ico;

            this.cbClasificación.SelectedIndex = 0;
            this.lbGenero.SelectedIndex = 0;
            this.tbDuracion.Text = "(Min.)";

            this.tbTitulo.Text = data[0];
            this.tbAño.Text = data[1];
            this.tbDuracion.Text = data[2];
            this.cbClasificación.SelectedItem = data[3];
            this.lbGenero.SelectedItem = data[4];
            this.tbCaratula.Text = data[5];

            try
            {
                this.pbCaratula.Image = PSLibrary.Utils.Image.Resize(new Bitmap(this.tbCaratula.Text), 181, 222);
            }
            catch { }

            this.data = null;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbTitulo.Text != "" && this.tbTitulo.TextLength >= 3)
            {
                data = tbTitulo.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. El titulo no puede tener menos de 3 caracteres.", "Error en Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';

            if (this.tbAño.Text != "")
            {
                data += tbAño.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. No se ha especificado el año.", "Error en Año", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';

            if (this.tbDuracion.Text != "" && this.tbDuracion.Text != "(Min.)")
            {
                data += this.tbDuracion.Text;
            }
            else
            {
                data = null;
                MessageBox.Show("Error. No se ha especificado la duracción.", "Error en Duracción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data += '#';
            data += this.cbClasificación.SelectedItem.ToString();

            data += '#';
            data += this.lbGenero.SelectedItem.ToString();

            data += '#';

            if (this.tbCaratula.Text != "")
            {
                data += this.tbCaratula.Text;
            }
            else
            {
                if (MessageBox.Show("No se ha seleccionado una caratula. ¿Quiere continuar?.", "No se ha seleccionado una caratula.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    data = null;
                    return;
                }
            }

            this.Close();
        }

        public String getData()
        {
            return data;
        }

        private void tbDuracion_Enter(object sender, EventArgs e)
        {
            if (this.tbDuracion.Text == "(Min.)")
                this.tbDuracion.Text = "";
        }

        private void tbDuracion_Leave(object sender, EventArgs e)
        {
            if (this.tbDuracion.Text == "")
                this.tbDuracion.Text = "(Min.)";
        }

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSLibrary.Utils.EventReply.KeyPress_OnlyNumbers(sender, e);
        }

        private void tbDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSLibrary.Utils.EventReply.KeyPress_OnlyNumbers(sender, e);
        }

        private void bCaratula_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.gif;*.png";
            ofd.Title = "Escoge una caratula para la pelicula";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbCaratula.Text = ofd.FileName;

                try
                {
                    this.pbCaratula.Image = PSLibrary.Utils.Image.Resize(new Bitmap(ofd.FileName), 181, 222);
                }
                catch {
                    this.tbCaratula.Text = "";

                    MessageBox.Show("La imagen esta dañada.", "Error - Caratula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbDuracion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Convert.ToInt32(this.tbDuracion.Text) > 300)
                    this.tbDuracion.Text = "300";
            }
            catch { }
        }

        private void tbAño_Leave(object sender, EventArgs e)
        {
            if (this.tbAño.Text != "")
            {
                try
                {
                    if (System.Convert.ToInt32(this.tbAño.Text) > DateTime.Now.Year)
                        this.tbAño.Text = DateTime.Now.Year.ToString();
                    else if (System.Convert.ToInt32(this.tbAño.Text) < 1895)
                        this.tbAño.Text = "1895";
                }
                catch { }
            }
        }
    }
}
