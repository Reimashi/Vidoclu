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
    public partial class formConsultaUsuariosView : Form
    {
        private FileManager data;
        private FileManager alquileres;

        public formConsultaUsuariosView(String title, Icon icon, FileManager data, FileManager alquileres)
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
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("DNI");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");

            DataRow row;

            for (int i = 0; i < data.WEIGHT; i++)
            {
                row = dt.NewRow();
                row["ID"] = data.GetRegistryWithID(i)[0];
                row["Nombre"] = data.GetRegistryWithID(i)[1];
                row["Apellidos"] = data.GetRegistryWithID(i)[2];
                row["DNI"] = data.GetRegistryWithID(i)[3];
                row["Edad"] = data.GetRegistryWithID(i)[4];
                row["Sexo"] = data.GetRegistryWithID(i)[5];
                row["Telefono"] = data.GetRegistryWithID(i)[6];
                row["Direccion"] = data.GetRegistryWithID(i)[7];
                dt.Rows.Add(row);
            }

            return dt;
        }

        private DataTable ObtenerDatos(String search)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("DNI");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");

            DataRow row;

            for (int i = 0; i < data.WEIGHT; i++)
            {
                if (FileManager.Encode(data.GetRegistry(i)).Contains(search))
                {
                    row = dt.NewRow();
                    row["ID"] = data.GetRegistryWithID(i)[0];
                    row["Nombre"] = data.GetRegistryWithID(i)[1];
                    row["Apellidos"] = data.GetRegistryWithID(i)[2];
                    row["DNI"] = data.GetRegistryWithID(i)[3];
                    row["Edad"] = data.GetRegistryWithID(i)[4];
                    row["Sexo"] = data.GetRegistryWithID(i)[5];
                    row["Telefono"] = data.GetRegistryWithID(i)[6];
                    row["Direccion"] = data.GetRegistryWithID(i)[7];
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
                item.SubItems.Add(Convert.ToString(row["Nombre"]));
                item.SubItems.Add(Convert.ToString(row["Apellidos"]));
                item.SubItems.Add(Convert.ToString(row["DNI"]));
                item.SubItems.Add(Convert.ToString(row["Edad"]));
                item.SubItems.Add(Convert.ToString(row["Sexo"]));
                item.SubItems.Add(Convert.ToString(row["Telefono"]));
                item.SubItems.Add(Convert.ToString(row["Direccion"]));

                this.lBoxData.Items.Add(item);
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lBoxData.SelectedItems)
            {
                for (int i = 0; i <= this.alquileres.MAX_INDEX; i++)
                {
                    if (this.alquileres.GetRegistry(i)[1] == this.data.GetRegistryWithID(getRealIndex(item))[0])
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
            formConsultaUsuarios aux;
            aux = new formConsultaUsuarios(this.Text + " - Nuevo Registro", this.Icon);
            aux.ShowDialog();
            if (aux.getData() != null)
            {
                data.AddNewRegistry(aux.getData());
            }

            LoadData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            formConsultaUsuarios aux;

            foreach (ListViewItem item in this.lBoxData.SelectedItems)
            {
                aux = new formConsultaUsuarios(this.Text + " - Editar Registro", this.Icon, data.GetRegistry(item.Index));
                aux.ShowDialog();
                if (aux.getData() != null)
                {
                    if (tbSearch.Text != "")
                    {
                        this.data.ModifyRegistry(getRealIndex(item), aux.getData());
                    }
                    else
                        this.data.ModifyRegistry(item.Index, aux.getData());
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
