namespace Vidoclu
{
    partial class formConsultaPeliculasView
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lBoxData = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDuraccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clClasificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bAnhadir = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbSearch);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 42);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(635, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbSearch, "Escriba cualquier campo del registro que desee buscar.");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 351);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lBoxData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(40, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(710, 351);
            this.panel3.TabIndex = 5;
            // 
            // lBoxData
            // 
            this.lBoxData.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lBoxData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clTitulo,
            this.clAño,
            this.clDuraccion,
            this.clClasificacion,
            this.clGenero});
            this.lBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxData.FullRowSelect = true;
            this.lBoxData.HideSelection = false;
            this.lBoxData.Location = new System.Drawing.Point(8, 8);
            this.lBoxData.Name = "lBoxData";
            this.lBoxData.Size = new System.Drawing.Size(694, 335);
            this.lBoxData.TabIndex = 4;
            this.lBoxData.UseCompatibleStateImageBehavior = false;
            this.lBoxData.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 45;
            // 
            // clTitulo
            // 
            this.clTitulo.Text = "Titulo";
            this.clTitulo.Width = 291;
            // 
            // clAño
            // 
            this.clAño.Text = "Año";
            // 
            // clDuraccion
            // 
            this.clDuraccion.Text = "Duracción";
            this.clDuraccion.Width = 77;
            // 
            // clClasificacion
            // 
            this.clClasificacion.Text = "Clasificación";
            this.clClasificacion.Width = 75;
            // 
            // clGenero
            // 
            this.clGenero.Text = "Genero";
            this.clGenero.Width = 122;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bAnhadir);
            this.flowLayoutPanel2.Controls.Add(this.bBorrar);
            this.flowLayoutPanel2.Controls.Add(this.bEdit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(40, 351);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // bAnhadir
            // 
            this.bAnhadir.Location = new System.Drawing.Point(8, 8);
            this.bAnhadir.Name = "bAnhadir";
            this.bAnhadir.Size = new System.Drawing.Size(23, 23);
            this.bAnhadir.TabIndex = 0;
            this.bAnhadir.Text = "+";
            this.toolTip1.SetToolTip(this.bAnhadir, "Añadir un nuevo registro.\r\n");
            this.bAnhadir.UseVisualStyleBackColor = true;
            this.bAnhadir.Click += new System.EventHandler(this.bAnhadir_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(8, 37);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(23, 23);
            this.bBorrar.TabIndex = 1;
            this.bBorrar.Text = "-";
            this.toolTip1.SetToolTip(this.bBorrar, "Borrar el/los registro/s seleccionado/s.");
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(8, 66);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(23, 23);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "E";
            this.toolTip1.SetToolTip(this.bEdit, "Editar el registro seleccionado.");
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // fileManagerBindingSource
            // 
            this.fileManagerBindingSource.DataSource = typeof(Vidoclu.FileManager);
            // 
            // formConsultaPeliculasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "formConsultaPeliculasView";
            this.ShowInTaskbar = false;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bAnhadir;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.BindingSource fileManagerBindingSource;
        private System.Windows.Forms.ListView lBoxData;
        private System.Windows.Forms.ColumnHeader clTitulo;
        private System.Windows.Forms.ColumnHeader clAño;
        private System.Windows.Forms.ColumnHeader clDuraccion;
        private System.Windows.Forms.ColumnHeader clClasificacion;
        private System.Windows.Forms.ColumnHeader clGenero;
        private System.Windows.Forms.ColumnHeader clID;

    }
}