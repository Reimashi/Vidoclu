using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Vidoclu
{
    public partial class formConsultaPeliculasView : Form
    {
        private FileManager data;
        private FileManager alquileres;

        public formConsultaPeliculasView(String title, Icon icon, FileManager data, FileManager alquileres)
        {
            InitializeComponent();

            this.data = data;
            this.alquileres = alquileres;

            this.Text = title;
            this.Icon = icon;

            LoadData();
        }

        private DataTable ObtenerDatos()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Año");
            dt.Columns.Add("Duracción");
            dt.Columns.Add("Clasificación");
            dt.Columns.Add("Genero");

            DataRow row;

            for (int i = 0; i < data.WEIGHT; i++)
            {
                row = dt.NewRow();
                row["ID"] = data.GetRegistryWithID(i)[0];
                row["Titulo"] = data.GetRegistryWithID(i)[1];
                row["Año"] = data.GetRegistryWithID(i)[2];
                row["Duracción"] = data.GetRegistryWithID(i)[3];
                row["Clasificación"] = data.GetRegistryWithID(i)[4];
                row["Genero"] = data.GetRegistryWithID(i)[5];
                dt.Rows.Add(row);
            }

            return dt;
        }

        private DataTable ObtenerDatos(String search)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Año");
            dt.Columns.Add("Duracción");
            dt.Columns.Add("Clasificación");
            dt.Columns.Add("Genero");

            DataRow row;

            for (int i = 0; i < data.WEIGHT; i++)
            {
                if (FileManager.Encode(data.GetRegistry(i)).Contains(search))
                {
                    row = dt.NewRow();
                    row["ID"] = data.GetRegistryWithID(i)[0];
                    row["Titulo"] = data.GetRegistryWithID(i)[1];
                    row["Año"] = data.GetRegistryWithID(i)[2];
                    row["Duracción"] = data.GetRegistryWithID(i)[3];
                    row["Clasificación"] = data.GetRegistryWithID(i)[4];
                    row["Genero"] = data.GetRegistryWithID(i)[5];
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        private void LoadData()
        {
            DataTable dt;
            
            this.lBoxData.Items.Clear();

            if (this.tbSearch.Text == "")
            {
                dt = ObtenerDatos();
            }
            else
            {
                dt = ObtenerDatos(this.tbSearch.Text);
            }
            
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row["ID"]));
                item.SubItems.Add(Convert.ToString(row["Titulo"]));
                item.SubItems.Add(Convert.ToString(row["Año"]));
                item.SubItems.Add(Convert.ToString(row["Duracción"]));
                item.SubItems.Add(Convert.ToString(row["Clasificación"]));
                item.SubItems.Add(Convert.ToString(row["Genero"]));

                this.lBoxData.Items.Add(item);
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lBoxData.SelectedItems)
            {
                try
                {
                    File.Delete(data.GetRegistry(item.Index)[5]);
                }
                catch { }

                for (int i = 0; i <= this.alquileres.MAX_INDEX; i++)
                {
                    if (this.alquileres.GetRegistry(i)[0] == this.data.GetRegistryWithID(getRealIndex(item))[0])
                    {
                        this.alquileres.DeleteRegistry(i);
                    }
                }

                this.data.DeleteRegistry(getRealIndex(item));
            }

            LoadData();
        }

        private void bAnhadir_Click(object sender, EventArgs e)
        {
            formConsultaPeliculas aux;
            aux = new formConsultaPeliculas(this.Text + " - Nuevo Registro", this.Icon);
            aux.ShowDialog();
            if (aux.getData() != null)
            {
                String Id = data.generateID();

                String[] process = aux.getData().Split('#');

                if (process[5] != "")
                {
                    PSLibrary.Utils.Image.Resize(new Bitmap(process[5]), 260, 320).Save("./db/images/" + Id + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    process[5] = "./db/images/" + Id + ".png";
                }
                else
                {
                    process[5] = "./db/images/default.png";
                }

                data.AddNewRegistry(process, Id);
            }

            LoadData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            formConsultaPeliculas aux;

            foreach (ListViewItem item in this.lBoxData.SelectedItems)
            {
                aux = new formConsultaPeliculas(this.Text + " - Editar Registro", this.Icon, data.GetRegistry(item.Index));
                aux.ShowDialog();
                if (aux.getData() != null)
                {
                    String Id = data.GetRegistry(item.Index)[0];

                    String[] process = aux.getData().Split('#');

                    if (process[5] != "" && process[5][0] != '.')
                    {
                        PSLibrary.Utils.Image.Resize(new Bitmap(process[5]), 260, 320).Save("./db/images/" + Id + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        process[5] = "./db/images/" + Id + ".png";
                    }
                    else if(process[5] == "")
                    {
                        process[5] = "./db/images/default.png";

                        try
                        {
                            File.Delete("./db/images/" + Id + ".png");
                        }
                        catch { }
                    }

                    this.data.ModifyRegistry(getRealIndex(item), process );
                }
            }

            LoadData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private Int32 getRealIndex (ListViewItem It)
        {
            return this.data.GetIndexByID(It.SubItems[0].Text);
        }
    }
}
