namespace Vidoclu
{
    partial class formConsultaUsuarios
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbDNILetra = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lDirección = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lSexo = new System.Windows.Forms.Label();
            this.lEdad = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbDirección = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEdad = new System.Windows.Forms.ComboBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancelar);
            this.flowLayoutPanel1.Controls.Add(this.bAceptar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(164, 9);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(83, 9);
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
            this.panel1.Controls.Add(this.tbDNI);
            this.panel1.Controls.Add(this.tbDNILetra);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.lDirección);
            this.panel1.Controls.Add(this.lTelefono);
            this.panel1.Controls.Add(this.lSexo);
            this.panel1.Controls.Add(this.lEdad);
            this.panel1.Controls.Add(this.lDNI);
            this.panel1.Controls.Add(this.lApellidos);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.tbDirección);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.cbEdad);
            this.panel1.Controls.Add(this.tbApellidos);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 280);
            this.panel1.TabIndex = 1;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(105, 78);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(94, 20);
            this.tbDNI.TabIndex = 2;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNI_KeyPress);
            // 
            // tbDNILetra
            // 
            this.tbDNILetra.Location = new System.Drawing.Point(205, 78);
            this.tbDNILetra.MaxLength = 1;
            this.tbDNILetra.Name = "tbDNILetra";
            this.tbDNILetra.ReadOnly = true;
            this.tbDNILetra.Size = new System.Drawing.Size(21, 20);
            this.tbDNILetra.TabIndex = 13;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(105, 158);
            this.tbTelefono.Mask = "(999) 00 00 00";
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(121, 20);
            this.tbTelefono.TabIndex = 5;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // lDirección
            // 
            this.lDirección.AutoSize = true;
            this.lDirección.Location = new System.Drawing.Point(27, 187);
            this.lDirección.Name = "lDirección";
            this.lDirección.Size = new System.Drawing.Size(52, 13);
            this.lDirección.TabIndex = 12;
            this.lDirección.Text = "Dirección";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(26, 161);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 11;
            this.lTelefono.Text = "Telefono";
            // 
            // lSexo
            // 
            this.lSexo.AutoSize = true;
            this.lSexo.Location = new System.Drawing.Point(27, 134);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(31, 13);
            this.lSexo.TabIndex = 10;
            this.lSexo.Text = "Sexo";
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(26, 107);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(32, 13);
            this.lEdad.TabIndex = 9;
            this.lEdad.Text = "Edad";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(26, 81);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(26, 13);
            this.lDNI.TabIndex = 8;
            this.lDNI.Text = "DNI";
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(26, 55);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(49, 13);
            this.lApellidos.TabIndex = 7;
            this.lApellidos.Text = "Apellidos";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(26, 28);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 6;
            this.lNombre.Text = "Nombre";
            // 
            // tbDirección
            // 
            this.tbDirección.Location = new System.Drawing.Point(105, 184);
            this.tbDirección.MaxLength = 60;
            this.tbDirección.Multiline = true;
            this.tbDirección.Name = "tbDirección";
            this.tbDirección.Size = new System.Drawing.Size(121, 70);
            this.tbDirección.TabIndex = 6;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(105, 131);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 4;
            // 
            // cbEdad
            // 
            this.cbEdad.FormattingEnabled = true;
            this.cbEdad.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "+65"});
            this.cbEdad.Location = new System.Drawing.Point(105, 104);
            this.cbEdad.Name = "cbEdad";
            this.cbEdad.Size = new System.Drawing.Size(121, 21);
            this.cbEdad.TabIndex = 3;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(105, 52);
            this.tbApellidos.MaxLength = 25;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(121, 20);
            this.tbApellidos.TabIndex = 1;
            this.tbApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidos_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(105, 25);
            this.tbUsuario.MaxLength = 15;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(121, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // formConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formConsultaUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "formConsultaEnter";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbEdad;
        private System.Windows.Forms.MaskedTextBox tbTelefono;
        private System.Windows.Forms.Label lDirección;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lSexo;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbDirección;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbDNILetra;
    }
}