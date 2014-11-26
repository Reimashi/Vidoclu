using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.Dialogs;
using System.IO;
using System.Security.Permissions;
using System.Security;

namespace Vidoclu
{
    public partial class fPrincipal : Form
    {
        private FileManager usuarios;
        private FileManager peliculas;
        private FileManager alquileres;

        public fPrincipal()
        {
            InitializeComponent();

            this.Icon = Vidoclu.Properties.Resources.icono;

            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Write;

            #region Creación de los archivos del programa si no existen

            if (!Directory.Exists("./help/img"))
            {
                if (!Directory.Exists("./help/img"))
                {
                    try
                    {
                        Directory.CreateDirectory("./help/img");

                        Properties.Resources._000.Save("./help/img/000.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._001.Save("./help/img/001.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._002.Save("./help/img/002.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._003.Save("./help/img/003.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._004.Save("./help/img/004.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._005.Save("./help/img/005.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._006.Save("./help/img/006.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._007.Save("./help/img/007.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._008.Save("./help/img/008.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._009.Save("./help/img/009.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._010.Save("./help/img/010.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._011.Save("./help/img/011.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._012.Save("./help/img/012.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._013.Save("./help/img/013.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._014.Save("./help/img/014.png", System.Drawing.Imaging.ImageFormat.Png);
                        Properties.Resources._015.Save("./help/img/015.png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch { }
                }

                try
                {
                    Directory.CreateDirectory("./help");

                    StreamWriter sw = new StreamWriter("./help/index.html");
                    sw.Write(Properties.Resources.index);
                    sw.Close();

                    sw = new StreamWriter("./help/about.html");
                    sw.Write(Properties.Resources.about);
                    sw.Close();

                    sw = new StreamWriter("./help/films.html");
                    sw.Write(Properties.Resources.films);
                    sw.Close();

                    sw = new StreamWriter("./help/rent.html");
                    sw.Write(Properties.Resources.rent);
                    sw.Close();

                    sw = new StreamWriter("./help/users.html");
                    sw.Write(Properties.Resources.users);
                    sw.Close();

                    sw = new StreamWriter("./help/style.css");
                    sw.Write(Properties.Resources.style);
                    sw.Close();
                }
                catch { }
            }

            if (!Directory.Exists("./db/images"))
            {
                if (!Directory.Exists("./db"))
                {
                    try
                    {
                        Directory.CreateDirectory("./db");
                    }
                    catch { }
                }

                try
                {
                    Directory.CreateDirectory("./db/images");
                    Properties.Resources.default_image.Save("./db/images/default.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                catch { }
            }

            #endregion

            this.LoadData();
        }

        private void LoadData()
        {
            String[] aux = { "ID", "Nombre", "Apellidos", "DNI", "Edad", "Sexo", "Telefono", "Dirección" };
            usuarios = new FileManager("usuarios", aux);
            usuarios.Load();

            String[] aux2 = { "ID", "Titulo", "Año", "Duracción", "Clasificación", "Genero", "UriPortada" };
            peliculas = new FileManager("peliculas", aux2);
            peliculas.Load();

            String[] aux3 = { "ID", "IDUsuario", "IDPelicula" };
            alquileres = new FileManager("alquileres", aux3);
            alquileres.Load();
        }

        #region Respuesta a eventos del menuStrip
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri link;

            try
            {
                link = new Uri("http://proyectsource.tk");
                new PSLibrary.Dialogs.DialogAbout(
                    "Gestion Videoclub", 
                    "Vidoclú", 
                    "0.1",
                    "Gestiona con facilidad todos tus usuarios y peliculas.", 
                    "GNU GPL v3", 
                    "Proyect Source", link, 
                    new Bitmap(Vidoclu.Properties.Resources.icon),
                    Vidoclu.Properties.Resources.icono
                    ).ShowDialog();
            }
            catch { }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar antes de salir?", "¿Guardar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                guardarToolStripMenuItem_Click(this, null);
            }
            Application.Exit();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios.Load();
            peliculas.Load();
            alquileres.Load();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios.Save();
            peliculas.Save();
            alquileres.Save();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PSLibrary.Dialogs.DialogHelpHTML(this.Text, 
                                                "help/index.html", 
                                                "http://ProyectSource.tk", 
                                                Vidoclu.Properties.Resources.icono
                                                ).ShowDialog();
        }
        #endregion

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            new formConsultaUsuariosView(this.Text + " - Usuarios", Vidoclu.Properties.Resources.icono, this.usuarios, this.alquileres).ShowDialog();
        }

        private void bPeliculas_Click(object sender, EventArgs e)
        {
            new formConsultaPeliculasView(this.Text + " - Peliculas", Vidoclu.Properties.Resources.icono, this.peliculas, this.alquileres).ShowDialog();
        }

        private void bAlquilar_Click(object sender, EventArgs e)
        {
            new formAlquileres(this.Text + " - Alquileres", Vidoclu.Properties.Resources.icono, this.usuarios, this.peliculas, this.alquileres).ShowDialog();
        }

        private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere limpiar la base de datos?. Al hacerlo todos los datos se eliminarán.", "Limpiar la Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                new PSLibrary.Dialogs.PSDialogPopUpMessage("Borrando la Base de Datos...", 2200).Show();

                try
                {
                    File.Delete("./db/alquileres.dat");
                    File.Delete("./db/peliculas.dat");
                    File.Delete("./db/usuarios.dat");
                }
                catch { }

                try
                {
                    DirectoryInfo imageFolder = new DirectoryInfo("./db/images");
                    FileInfo[] imageFiles = imageFolder.GetFiles();

                    foreach (FileInfo iFile in imageFiles)
                    {
                        if (!iFile.FullName.Contains("default.png"))
                            File.Delete(iFile.FullName);
                    }
                }
                catch { }

                this.LoadData();
            }
        }
    }
}
