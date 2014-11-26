using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vidoclu
{
    public partial class formAlquileres : Form
    {
        private FileManager users;
        private FileManager films;
        private FileManager data;

        private List<String> userIds = new List<string>();

        private Int32 actualIndex = 0;

        public formAlquileres(String title, Icon icon, FileManager users, FileManager films, FileManager data)
        {
            InitializeComponent();

            this.users = users;
            this.films = films;
            this.data = data;

            this.Text = title;
            this.Icon = icon;

            this.tbTitulo.ReadOnly = true;
            this.tbAño.ReadOnly = true;
            this.tbDuracion.ReadOnly = true;
            this.tbGenero.ReadOnly = true;
            this.tbClasificacion.ReadOnly = true;

            this.bIzquierda.Enabled = false;
            if (films.WEIGHT < 1)
                this.bDerecha.Enabled = false;

            this.flpDevolver.Hide();

            if (0 < users.WEIGHT)
            {
                for (int i = 0; i < users.WEIGHT; i++)
                {
                    this.userIds.Add(users.GetRegistryWithID(i)[0]);
                    this.cbUsuarios.Items.Add(users.GetRegistryWithID(i)[1] + " " + users.GetRegistryWithID(i)[2]);
                }
            }
            else
                this.bAlquilar.Enabled = false;

            if (0 < films.WEIGHT)
            {
                LoadDataInForm(0);
            }
            else
                this.bAlquilar.Enabled = false;
        }

        private void bAlquilar_Click(object sender, EventArgs e)
        {
            if (this.cbUsuarios.SelectedIndex >= 0 && this.cbUsuarios.SelectedIndex < users.WEIGHT)
            {
                String[] aux =  new String[2];
                aux[0] = films.GetRegistryWithID(actualIndex)[0];
                aux[1] = users.GetRegistryWithID(this.cbUsuarios.SelectedIndex)[0];

                data.AddNewRegistry(aux);

                this.lNombreAlquiler.Text = this.cbUsuarios.Items[this.cbUsuarios.SelectedIndex].ToString();

                this.flpAlquilar.Hide();
                this.flpDevolver.Show();
            }
        }

        private void bDevolver_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= data.MAX_INDEX; i++)
            {
                if (films.GetRegistryWithID(actualIndex)[0] == data.GetRegistry(i)[0])
                {
                    data.DeleteRegistry(i);

                    this.flpDevolver.Hide();
                    this.flpAlquilar.Show();

                    break;
                }
            }
        }

        private void bIzquierda_Click(object sender, EventArgs e)
        {
            if (actualIndex > 0)
            {
                LoadDataInForm(actualIndex - 1);
            }
            else
            {
                // Aquí no debería entrar nunca
                this.bIzquierda.Enabled = false;
            }
        }

        private void bDerecha_Click(object sender, EventArgs e)
        {
            if (actualIndex < films.MAX_INDEX)
            {
                LoadDataInForm(actualIndex + 1);
            }
            else
            {
                // Aquí no debería entrar nunca
                this.bDerecha.Enabled = false;
            }
        }

        private void LoadDataInForm(Int32 index)
        {
            this.actualIndex = index;

            // Cargamos los datos
            this.tbTitulo.Text = films.GetRegistry(actualIndex)[0];
            this.tbAño.Text = films.GetRegistry(actualIndex)[1];
            this.tbDuracion.Text = films.GetRegistry(actualIndex)[2];
            this.tbClasificacion.Text = films.GetRegistry(actualIndex)[3];
            this.tbGenero.Text = films.GetRegistry(actualIndex)[4];

            // Cargamos la imagen
            try
            {
                this.pbCaratula.Image = new Bitmap(films.GetRegistry(actualIndex)[5]);
            }
            catch
            {
                try
                {
                    this.pbCaratula.Image = new Bitmap("./db/images/default.png");
                }
                catch { }
            }

            // Comprobamos los botones de siguiente y anterior
            if (actualIndex >= films.MAX_INDEX)
                this.bDerecha.Enabled = false;
            else
                this.bDerecha.Enabled = true;
            if (actualIndex <= 0)
                this.bIzquierda.Enabled = false;
            else
                this.bIzquierda.Enabled = true;

            // Comprobamos los paneles de alquilar / devolver
            this.flpDevolver.Hide();
            this.flpAlquilar.Show();

            for (int i = 0; i < data.WEIGHT; i++)
            {
                if (films.GetRegistryWithID(actualIndex)[0] == data.GetRegistry(i)[0])
                {
                    this.flpAlquilar.Hide();
                    this.flpDevolver.Show();
                    this.lNombreAlquiler.Text = users.GetRegistry(users.GetIndexByID(data.GetRegistryWithID(i)[2]))[0] + " " + users.GetRegistry(users.GetIndexByID(data.GetRegistryWithID(i)[2]))[1];
                    this.bDevolver.Enabled = true;
                }
            }
        }
    }
}
