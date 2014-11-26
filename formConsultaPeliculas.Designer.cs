namespace Vidoclu
{
    partial class formConsultaPeliculas
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCaratula = new System.Windows.Forms.Button();
            this.tbCaratula = new System.Windows.Forms.TextBox();
            this.lCaratula = new System.Windows.Forms.Label();
            this.pbCaratula = new System.Windows.Forms.PictureBox();
            this.lbGenero = new System.Windows.Forms.ListBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.lGenero = new System.Windows.Forms.Label();
            this.lClasificación = new System.Windows.Forms.Label();
            this.lDuracción = new System.Windows.Forms.Label();
            this.lAño = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.cbClasificación = new System.Windows.Forms.ComboBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.fileManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancelar);
            this.flowLayoutPanel1.Controls.Add(this.bAceptar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 303);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(363, 9);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(282, 9);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 7;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCaratula);
            this.panel1.Controls.Add(this.tbCaratula);
            this.panel1.Controls.Add(this.lCaratula);
            this.panel1.Controls.Add(this.pbCaratula);
            this.panel1.Controls.Add(this.lbGenero);
            this.panel1.Controls.Add(this.tbDuracion);
            this.panel1.Controls.Add(this.lGenero);
            this.panel1.Controls.Add(this.lClasificación);
            this.panel1.Controls.Add(this.lDuracción);
            this.panel1.Controls.Add(this.lAño);
            this.panel1.Controls.Add(this.lTitulo);
            this.panel1.Controls.Add(this.cbClasificación);
            this.panel1.Controls.Add(this.tbAño);
            this.panel1.Controls.Add(this.tbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 303);
            this.panel1.TabIndex = 1;
            // 
            // bCaratula
            // 
            this.bCaratula.Image = global::Vidoclu.Properties.Resources.browseIcon;
            this.bCaratula.Location = new System.Drawing.Point(208, 261);
            this.bCaratula.Name = "bCaratula";
            this.bCaratula.Size = new System.Drawing.Size(30, 26);
            this.bCaratula.TabIndex = 15;
            this.bCaratula.UseVisualStyleBackColor = true;
            this.bCaratula.Click += new System.EventHandler(this.bCaratula_Click);
            // 
            // tbCaratula
            // 
            this.tbCaratula.Location = new System.Drawing.Point(74, 264);
            this.tbCaratula.Name = "tbCaratula";
            this.tbCaratula.ReadOnly = true;
            this.tbCaratula.Size = new System.Drawing.Size(128, 20);
            this.tbCaratula.TabIndex = 14;
            // 
            // lCaratula
            // 
            this.lCaratula.AutoSize = true;
            this.lCaratula.Location = new System.Drawing.Point(26, 267);
            this.lCaratula.Name = "lCaratula";
            this.lCaratula.Size = new System.Drawing.Size(46, 13);
            this.lCaratula.TabIndex = 13;
            this.lCaratula.Text = "Caratula";
            // 
            // pbCaratula
            // 
            this.pbCaratula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCaratula.Location = new System.Drawing.Point(256, 65);
            this.pbCaratula.Name = "pbCaratula";
            this.pbCaratula.Size = new System.Drawing.Size(181, 222);
            this.pbCaratula.TabIndex = 12;
            this.pbCaratula.TabStop = false;
            // 
            // lbGenero
            // 
            this.lbGenero.FormattingEnabled = true;
            this.lbGenero.Items.AddRange(new object[] {
            "Acción",
            "Animación",
            "Aventuras",
            "Ciencia Ficción",
            "Comedia",
            "Deportiva",
            "Documental",
            "Drama",
            "Erótica",
            "Fantástica",
            "Guerra",
            "Historica",
            "Intriga",
            "Misterio",
            "Musical",
            "Policiaca",
            "Romántica",
            "Suspense",
            "Terror",
            "Thriller",
            "Western"});
            this.lbGenero.Location = new System.Drawing.Point(74, 114);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(164, 134);
            this.lbGenero.TabIndex = 11;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(191, 52);
            this.tbDuracion.MaxLength = 3;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(47, 20);
            this.tbDuracion.TabIndex = 2;
            this.tbDuracion.TextChanged += new System.EventHandler(this.tbDuracion_TextChanged);
            this.tbDuracion.Enter += new System.EventHandler(this.tbDuracion_Enter);
            this.tbDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuracion_KeyPress);
            this.tbDuracion.Leave += new System.EventHandler(this.tbDuracion_Leave);
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Location = new System.Drawing.Point(26, 114);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(42, 13);
            this.lGenero.TabIndex = 10;
            this.lGenero.Text = "Genero";
            // 
            // lClasificación
            // 
            this.lClasificación.AutoSize = true;
            this.lClasificación.Location = new System.Drawing.Point(26, 84);
            this.lClasificación.Name = "lClasificación";
            this.lClasificación.Size = new System.Drawing.Size(66, 13);
            this.lClasificación.TabIndex = 9;
            this.lClasificación.Text = "Clasificación";
            // 
            // lDuracción
            // 
            this.lDuracción.AutoSize = true;
            this.lDuracción.Location = new System.Drawing.Point(129, 55);
            this.lDuracción.Name = "lDuracción";
            this.lDuracción.Size = new System.Drawing.Size(56, 13);
            this.lDuracción.TabIndex = 8;
            this.lDuracción.Text = "Duracción";
            // 
            // lAño
            // 
            this.lAño.AutoSize = true;
            this.lAño.Location = new System.Drawing.Point(26, 55);
            this.lAño.Name = "lAño";
            this.lAño.Size = new System.Drawing.Size(26, 13);
            this.lAño.TabIndex = 7;
            this.lAño.Text = "Año";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Location = new System.Drawing.Point(26, 28);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(33, 13);
            this.lTitulo.TabIndex = 6;
            this.lTitulo.Text = "Titulo";
            // 
            // cbClasificación
            // 
            this.cbClasificación.FormattingEnabled = true;
            this.cbClasificación.Items.AddRange(new object[] {
            "TP",
            "+7",
            "+13",
            "+18"});
            this.cbClasificación.Location = new System.Drawing.Point(98, 81);
            this.cbClasificación.Name = "cbClasificación";
            this.cbClasificación.Size = new System.Drawing.Size(140, 21);
            this.cbClasificación.TabIndex = 3;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(65, 52);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(47, 20);
            this.tbAño.TabIndex = 1;
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            this.tbAño.Leave += new System.EventHandler(this.tbAño_Leave);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(65, 25);
            this.tbTitulo.MaxLength = 45;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(372, 20);
            this.tbTitulo.TabIndex = 0;
            // 
            // fileManagerBindingSource
            // 
            this.fileManagerBindingSource.DataSource = typeof(Vidoclu.FileManager);
            // 
            // formConsultaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formConsultaPeliculas";
            this.ShowInTaskbar = false;
            this.Text = "formConsultaEnter";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.ComboBox cbClasificación;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.Label lClasificación;
        private System.Windows.Forms.Label lDuracción;
        private System.Windows.Forms.Label lAño;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.ListBox lbGenero;
        private System.Windows.Forms.Label lCaratula;
        private System.Windows.Forms.PictureBox pbCaratula;
        private System.Windows.Forms.BindingSource fileManagerBindingSource;
        private System.Windows.Forms.Button bCaratula;
        private System.Windows.Forms.TextBox tbCaratula;
    }
}