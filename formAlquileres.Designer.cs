namespace Vidoclu
{
    partial class formAlquileres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCaratula = new System.Windows.Forms.PictureBox();
            this.bIzquierda = new System.Windows.Forms.Button();
            this.bDerecha = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAlquilar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.bAlquilar = new System.Windows.Forms.Button();
            this.flpDevolver = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbAlquilada = new System.Windows.Forms.GroupBox();
            this.lNombreAlquiler = new System.Windows.Forms.Label();
            this.bDevolver = new System.Windows.Forms.Button();
            this.pDatos = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.lGenero = new System.Windows.Forms.Label();
            this.tbClasificacion = new System.Windows.Forms.TextBox();
            this.lClasificación = new System.Windows.Forms.Label();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.lDuracción = new System.Windows.Forms.Label();
            this.lAño = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpAlquilar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpDevolver.SuspendLayout();
            this.gbAlquilada.SuspendLayout();
            this.pDatos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCaratula
            // 
            this.pbCaratula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCaratula.Location = new System.Drawing.Point(200, 17);
            this.pbCaratula.Name = "pbCaratula";
            this.pbCaratula.Size = new System.Drawing.Size(260, 320);
            this.pbCaratula.TabIndex = 0;
            this.pbCaratula.TabStop = false;
            // 
            // bIzquierda
            // 
            this.bIzquierda.Image = global::Vidoclu.Properties.Resources.arrow_left;
            this.bIzquierda.Location = new System.Drawing.Point(160, 276);
            this.bIzquierda.Margin = new System.Windows.Forms.Padding(154, 3, 20, 10);
            this.bIzquierda.Name = "bIzquierda";
            this.bIzquierda.Size = new System.Drawing.Size(17, 54);
            this.bIzquierda.TabIndex = 1;
            this.bIzquierda.UseVisualStyleBackColor = true;
            this.bIzquierda.Click += new System.EventHandler(this.bIzquierda_Click);
            // 
            // bDerecha
            // 
            this.bDerecha.Image = global::Vidoclu.Properties.Resources.arrow_right;
            this.bDerecha.Location = new System.Drawing.Point(483, 276);
            this.bDerecha.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.bDerecha.Name = "bDerecha";
            this.bDerecha.Size = new System.Drawing.Size(17, 54);
            this.bDerecha.TabIndex = 2;
            this.bDerecha.UseVisualStyleBackColor = true;
            this.bDerecha.Click += new System.EventHandler(this.bDerecha_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bIzquierda);
            this.flowLayoutPanel1.Controls.Add(this.pbCaratula);
            this.flowLayoutPanel1.Controls.Add(this.bDerecha);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 352);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flpAlquilar
            // 
            this.flpAlquilar.Controls.Add(this.panel2);
            this.flpAlquilar.Controls.Add(this.groupBox1);
            this.flpAlquilar.Controls.Add(this.bAlquilar);
            this.flpAlquilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAlquilar.Location = new System.Drawing.Point(0, 446);
            this.flpAlquilar.Name = "flpAlquilar";
            this.flpAlquilar.Padding = new System.Windows.Forms.Padding(15);
            this.flpAlquilar.Size = new System.Drawing.Size(656, 75);
            this.flpAlquilar.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(64, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alquilar a:";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(3, 16);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(502, 21);
            this.cbUsuarios.TabIndex = 0;
            // 
            // bAlquilar
            // 
            this.bAlquilar.Location = new System.Drawing.Point(578, 18);
            this.bAlquilar.Name = "bAlquilar";
            this.bAlquilar.Size = new System.Drawing.Size(60, 40);
            this.bAlquilar.TabIndex = 1;
            this.bAlquilar.Text = "Alquilar";
            this.bAlquilar.UseVisualStyleBackColor = true;
            this.bAlquilar.Click += new System.EventHandler(this.bAlquilar_Click);
            // 
            // flpDevolver
            // 
            this.flpDevolver.Controls.Add(this.panel1);
            this.flpDevolver.Controls.Add(this.gbAlquilada);
            this.flpDevolver.Controls.Add(this.bDevolver);
            this.flpDevolver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDevolver.Location = new System.Drawing.Point(0, 371);
            this.flpDevolver.Name = "flpDevolver";
            this.flpDevolver.Padding = new System.Windows.Forms.Padding(15);
            this.flpDevolver.Size = new System.Drawing.Size(656, 75);
            this.flpDevolver.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 40);
            this.panel1.TabIndex = 0;
            // 
            // gbAlquilada
            // 
            this.gbAlquilada.Controls.Add(this.lNombreAlquiler);
            this.gbAlquilada.Location = new System.Drawing.Point(64, 18);
            this.gbAlquilada.Name = "gbAlquilada";
            this.gbAlquilada.Size = new System.Drawing.Size(508, 40);
            this.gbAlquilada.TabIndex = 2;
            this.gbAlquilada.TabStop = false;
            this.gbAlquilada.Text = "Alquilada a:";
            // 
            // lNombreAlquiler
            // 
            this.lNombreAlquiler.AutoSize = true;
            this.lNombreAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNombreAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreAlquiler.Location = new System.Drawing.Point(3, 16);
            this.lNombreAlquiler.Name = "lNombreAlquiler";
            this.lNombreAlquiler.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lNombreAlquiler.Size = new System.Drawing.Size(185, 20);
            this.lNombreAlquiler.TabIndex = 3;
            this.lNombreAlquiler.Text = "Nombre de Ejemplo";
            // 
            // bDevolver
            // 
            this.bDevolver.Location = new System.Drawing.Point(578, 18);
            this.bDevolver.Name = "bDevolver";
            this.bDevolver.Size = new System.Drawing.Size(60, 40);
            this.bDevolver.TabIndex = 1;
            this.bDevolver.Text = "Devolver";
            this.bDevolver.UseVisualStyleBackColor = true;
            this.bDevolver.Click += new System.EventHandler(this.bDevolver_Click);
            // 
            // pDatos
            // 
            this.pDatos.Controls.Add(this.gbDatos);
            this.pDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatos.Location = new System.Drawing.Point(0, 352);
            this.pDatos.Name = "pDatos";
            this.pDatos.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pDatos.Size = new System.Drawing.Size(656, 19);
            this.pDatos.TabIndex = 20;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tbGenero);
            this.gbDatos.Controls.Add(this.lGenero);
            this.gbDatos.Controls.Add(this.tbClasificacion);
            this.gbDatos.Controls.Add(this.lClasificación);
            this.gbDatos.Controls.Add(this.tbDuracion);
            this.gbDatos.Controls.Add(this.lDuracción);
            this.gbDatos.Controls.Add(this.lAño);
            this.gbDatos.Controls.Add(this.tbAño);
            this.gbDatos.Controls.Add(this.tbTitulo);
            this.gbDatos.Controls.Add(this.lTitulo);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(15, 10);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(626, 0);
            this.gbDatos.TabIndex = 18;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de la Pelicula";
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(520, 45);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 20);
            this.tbGenero.TabIndex = 26;
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Location = new System.Drawing.Point(458, 48);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(42, 13);
            this.lGenero.TabIndex = 25;
            this.lGenero.Text = "Genero";
            // 
            // tbClasificacion
            // 
            this.tbClasificacion.Location = new System.Drawing.Point(332, 45);
            this.tbClasificacion.Name = "tbClasificacion";
            this.tbClasificacion.Size = new System.Drawing.Size(100, 20);
            this.tbClasificacion.TabIndex = 24;
            // 
            // lClasificación
            // 
            this.lClasificación.AutoSize = true;
            this.lClasificación.Location = new System.Drawing.Point(251, 48);
            this.lClasificación.Name = "lClasificación";
            this.lClasificación.Size = new System.Drawing.Size(66, 13);
            this.lClasificación.TabIndex = 23;
            this.lClasificación.Text = "Clasificación";
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(179, 45);
            this.tbDuracion.MaxLength = 3;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(47, 20);
            this.tbDuracion.TabIndex = 20;
            // 
            // lDuracción
            // 
            this.lDuracción.AutoSize = true;
            this.lDuracción.Location = new System.Drawing.Point(117, 48);
            this.lDuracción.Name = "lDuracción";
            this.lDuracción.Size = new System.Drawing.Size(56, 13);
            this.lDuracción.TabIndex = 22;
            this.lDuracción.Text = "Duracción";
            // 
            // lAño
            // 
            this.lAño.AutoSize = true;
            this.lAño.Location = new System.Drawing.Point(9, 48);
            this.lAño.Name = "lAño";
            this.lAño.Size = new System.Drawing.Size(26, 13);
            this.lAño.TabIndex = 21;
            this.lAño.Text = "Año";
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(48, 45);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(47, 20);
            this.tbAño.TabIndex = 19;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(48, 19);
            this.tbTitulo.MaxLength = 45;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(572, 20);
            this.tbTitulo.TabIndex = 18;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Location = new System.Drawing.Point(9, 22);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(33, 13);
            this.lTitulo.TabIndex = 17;
            this.lTitulo.Text = "Titulo";
            // 
            // formAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 521);
            this.Controls.Add(this.pDatos);
            this.Controls.Add(this.flpDevolver);
            this.Controls.Add(this.flpAlquilar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formAlquileres";
            this.ShowInTaskbar = false;
            this.Text = "Alquilar";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flpAlquilar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flpDevolver.ResumeLayout(false);
            this.gbAlquilada.ResumeLayout(false);
            this.gbAlquilada.PerformLayout();
            this.pDatos.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaratula;
        private System.Windows.Forms.Button bIzquierda;
        private System.Windows.Forms.Button bDerecha;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpAlquilar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAlquilar;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.FlowLayoutPanel flpDevolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAlquilada;
        private System.Windows.Forms.Label lNombreAlquiler;
        private System.Windows.Forms.Button bDevolver;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.TextBox tbClasificacion;
        private System.Windows.Forms.Label lClasificación;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.Label lDuracción;
        private System.Windows.Forms.Label lAño;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lTitulo;
    }
}