namespace ProyectoASIS22K26___Polideportivo
{
    partial class frmReglamento
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
            panel2 = new Panel();
            cboDeporte = new ComboBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnAyuda = new Button();
            btnActualizar = new Button();
            btnLeer = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dgvReglas = new DataGridView();
            lblNombreRegla = new Label();
            txtNombreRegla = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new RichTextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnBuscar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cboDeporte);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 80);
            panel2.TabIndex = 3;
            // 
            // cboDeporte
            // 
            cboDeporte.Anchor = AnchorStyles.None;
            cboDeporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDeporte.FormattingEnabled = true;
            cboDeporte.Items.AddRange(new object[] { "Fútbol", "Basquetbol", "Voleibol", "Tenis" });
            cboDeporte.Location = new Point(406, 33);
            cboDeporte.Name = "cboDeporte";
            cboDeporte.Size = new Size(198, 27);
            cboDeporte.TabIndex = 12;
            cboDeporte.Text = "Eliga un deporte ...";
            cboDeporte.SelectedIndexChanged += cboDeporte_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.FlatStyle = FlatStyle.System;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(50, 26);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reglas y Sanciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnLeer);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 520);
            panel1.TabIndex = 4;
            // 
            // btnAyuda
            // 
            btnAyuda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAyuda.BackColor = Color.Gray;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = SystemColors.ControlLightLight;
            btnAyuda.Location = new Point(50, 422);
            btnAyuda.Margin = new Padding(0);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(187, 58);
            btnAyuda.TabIndex = 13;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(50, 326);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(187, 58);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLeer
            // 
            btnLeer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLeer.BackColor = Color.RoyalBlue;
            btnLeer.FlatAppearance.MouseDownBackColor = Color.Black;
            btnLeer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeer.ForeColor = SystemColors.ControlLightLight;
            btnLeer.Location = new Point(50, 230);
            btnLeer.Margin = new Padding(0);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(187, 58);
            btnLeer.TabIndex = 10;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = false;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.White;
            btnEliminar.BackgroundImage = SistemaDePolideportivo.Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlDarkDark;
            btnEliminar.Location = new Point(50, 134);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(62, 58);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.BackgroundImage = SistemaDePolideportivo.Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Black;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Location = new Point(50, 38);
            btnNuevo.Margin = new Padding(0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(62, 58);
            btnNuevo.TabIndex = 8;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvReglas
            // 
            dgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglas.Location = new Point(282, 359);
            dgvReglas.Name = "dgvReglas";
            dgvReglas.RowHeadersWidth = 51;
            dgvReglas.RowTemplate.Height = 24;
            dgvReglas.Size = new Size(666, 201);
            dgvReglas.TabIndex = 5;
            // 
            // lblNombreRegla
            // 
            lblNombreRegla.AutoSize = true;
            lblNombreRegla.Location = new Point(282, 121);
            lblNombreRegla.Name = "lblNombreRegla";
            lblNombreRegla.Size = new Size(99, 15);
            lblNombreRegla.TabIndex = 6;
            lblNombreRegla.Text = "Nombre Sanción:";
            // 
            // txtNombreRegla
            // 
            txtNombreRegla.BackColor = Color.WhiteSmoke;
            txtNombreRegla.Enabled = false;
            txtNombreRegla.Location = new Point(409, 118);
            txtNombreRegla.Name = "txtNombreRegla";
            txtNombreRegla.Size = new Size(396, 23);
            txtNombreRegla.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(279, 160);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(124, 16);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(368, 160);
            txtDescripcion.Margin = new Padding(0);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(437, 112);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.Text = "";
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.BackColor = Color.RoyalBlue;
            btnGuardar.Enabled = false;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(829, 107);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.BackColor = Color.RoyalBlue;
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(829, 160);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.WhiteSmoke;
            txtBuscar.Location = new Point(368, 307);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(437, 23);
            txtBuscar.TabIndex = 21;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(279, 310);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(121, 16);
            lblBuscar.TabIndex = 20;
            lblBuscar.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            btnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscar.BackColor = Color.RoyalBlue;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(829, 296);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 40);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmReglamento
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombreRegla);
            Controls.Add(lblNombreRegla);
            Controls.Add(dgvReglas);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReglamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reglamento";
            FormClosed += frmReglamento_FormClosed;
            Load += frmReglamento_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReglas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridView dgvReglas;
        private System.Windows.Forms.Label lblNombreRegla;
        private System.Windows.Forms.TextBox txtNombreRegla;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}