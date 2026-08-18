namespace ProyectoASIS22K26___Polideportivo
{
    partial class FrmReglamento
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
            Pnl2 = new Panel();
            CmbCboDeporte = new ComboBox();
            LblTitulo = new Label();
            Pnl1 = new Panel();
            BtnAyuda = new Button();
            BtnActualizar = new Button();
            BtnLeer = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            DgvReglas = new DataGridView();
            LblNombreRegla = new Label();
            TxtNombreRegla = new TextBox();
            LblDescripcion = new Label();
            RtbTxtDescripcion = new RichTextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            TxtBuscar = new TextBox();
            LblBuscar = new Label();
            BtnBuscar = new Button();
            Pnl2.SuspendLayout();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReglas).BeginInit();
            SuspendLayout();
            // 
            // Pnl2
            // 
            Pnl2.BackColor = Color.White;
            Pnl2.Controls.Add(CmbCboDeporte);
            Pnl2.Controls.Add(LblTitulo);
            Pnl2.Dock = DockStyle.Top;
            Pnl2.Location = new Point(0, 0);
            Pnl2.Name = "Pnl2";
            Pnl2.Size = new Size(1000, 80);
            Pnl2.TabIndex = 3;
            // 
            // CmbCboDeporte
            // 
            CmbCboDeporte.Anchor = AnchorStyles.None;
            CmbCboDeporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCboDeporte.FormattingEnabled = true;
            CmbCboDeporte.Items.AddRange(new object[] { "Fútbol", "Basquetbol", "Voleibol", "Tenis" });
            CmbCboDeporte.Location = new Point(406, 33);
            CmbCboDeporte.Name = "CmbCboDeporte";
            CmbCboDeporte.Size = new Size(198, 27);
            CmbCboDeporte.TabIndex = 12;
            CmbCboDeporte.Text = "Eliga un deporte ...";
            CmbCboDeporte.SelectedIndexChanged += CmbCboDeporte_SelectedIndexChanged;
            // 
            // LblTitulo
            // 
            LblTitulo.Anchor = AnchorStyles.None;
            LblTitulo.AutoSize = true;
            LblTitulo.FlatStyle = FlatStyle.System;
            LblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(50, 26);
            LblTitulo.Margin = new Padding(0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(243, 29);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Reglas y Sanciones";
            LblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pnl1
            // 
            Pnl1.Controls.Add(BtnAyuda);
            Pnl1.Controls.Add(BtnActualizar);
            Pnl1.Controls.Add(BtnLeer);
            Pnl1.Controls.Add(BtnEliminar);
            Pnl1.Controls.Add(BtnNuevo);
            Pnl1.Dock = DockStyle.Left;
            Pnl1.Location = new Point(0, 80);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(250, 520);
            Pnl1.TabIndex = 4;
            // 
            // BtnAyuda
            // 
            BtnAyuda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAyuda.BackColor = Color.Gray;
            BtnAyuda.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnAyuda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAyuda.ForeColor = SystemColors.ControlLightLight;
            BtnAyuda.Location = new Point(50, 422);
            BtnAyuda.Margin = new Padding(0);
            BtnAyuda.Name = "BtnAyuda";
            BtnAyuda.Size = new Size(187, 58);
            BtnAyuda.TabIndex = 13;
            BtnAyuda.Text = "Ayuda";
            BtnAyuda.UseVisualStyleBackColor = false;
            BtnAyuda.Click += BtnAyuda_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnActualizar.BackColor = Color.Orange;
            BtnActualizar.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnActualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizar.ForeColor = SystemColors.ControlLightLight;
            BtnActualizar.Location = new Point(50, 326);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(187, 58);
            BtnActualizar.TabIndex = 11;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnLeer
            // 
            BtnLeer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLeer.BackColor = Color.RoyalBlue;
            BtnLeer.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnLeer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLeer.ForeColor = SystemColors.ControlLightLight;
            BtnLeer.Location = new Point(50, 230);
            BtnLeer.Margin = new Padding(0);
            BtnLeer.Name = "BtnLeer";
            BtnLeer.Size = new Size(187, 58);
            BtnLeer.TabIndex = 10;
            BtnLeer.Text = "Leer";
            BtnLeer.UseVisualStyleBackColor = false;
            BtnLeer.Click += BtnLeer_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEliminar.BackColor = Color.White;
            BtnEliminar.BackgroundImage = SistemaDePolideportivo.Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnEliminar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = SystemColors.ControlDarkDark;
            BtnEliminar.Location = new Point(50, 134);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(62, 58);
            BtnEliminar.TabIndex = 9;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.BackColor = Color.Transparent;
            BtnNuevo.BackgroundImage = SistemaDePolideportivo.Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnNuevo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevo.ForeColor = SystemColors.ControlLightLight;
            BtnNuevo.Location = new Point(50, 38);
            BtnNuevo.Margin = new Padding(0);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(62, 58);
            BtnNuevo.TabIndex = 8;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // DgvReglas
            // 
            DgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReglas.Location = new Point(282, 359);
            DgvReglas.Name = "DgvReglas";
            DgvReglas.RowHeadersWidth = 51;
            DgvReglas.RowTemplate.Height = 24;
            DgvReglas.Size = new Size(666, 201);
            DgvReglas.TabIndex = 5;
            // 
            // LblNombreRegla
            // 
            LblNombreRegla.AutoSize = true;
            LblNombreRegla.Location = new Point(282, 121);
            LblNombreRegla.Name = "LblNombreRegla";
            LblNombreRegla.Size = new Size(99, 15);
            LblNombreRegla.TabIndex = 6;
            LblNombreRegla.Text = "Nombre Sanción:";
            // 
            // TxtNombreRegla
            // 
            TxtNombreRegla.BackColor = Color.WhiteSmoke;
            TxtNombreRegla.Enabled = false;
            TxtNombreRegla.Location = new Point(409, 118);
            TxtNombreRegla.Name = "TxtNombreRegla";
            TxtNombreRegla.Size = new Size(396, 23);
            TxtNombreRegla.TabIndex = 7;
            // 
            // LblDescripcion
            // 
            LblDescripcion.Location = new Point(279, 160);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(124, 16);
            LblDescripcion.TabIndex = 8;
            LblDescripcion.Text = "Descripción:";
            LblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RtbTxtDescripcion
            // 
            RtbTxtDescripcion.Anchor = AnchorStyles.None;
            RtbTxtDescripcion.BackColor = Color.WhiteSmoke;
            RtbTxtDescripcion.Enabled = false;
            RtbTxtDescripcion.Location = new Point(368, 160);
            RtbTxtDescripcion.Margin = new Padding(0);
            RtbTxtDescripcion.Name = "RtbTxtDescripcion";
            RtbTxtDescripcion.Size = new Size(437, 112);
            RtbTxtDescripcion.TabIndex = 9;
            RtbTxtDescripcion.Text = "";
            // 
            // BtnGuardar
            // 
            BtnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGuardar.BackColor = Color.RoyalBlue;
            BtnGuardar.Enabled = false;
            BtnGuardar.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ControlLightLight;
            BtnGuardar.Location = new Point(829, 107);
            BtnGuardar.Margin = new Padding(0);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(119, 40);
            BtnGuardar.TabIndex = 14;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelar.BackColor = Color.RoyalBlue;
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ControlLightLight;
            BtnCancelar.Location = new Point(829, 160);
            BtnCancelar.Margin = new Padding(0);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(119, 40);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.BackColor = Color.WhiteSmoke;
            TxtBuscar.Location = new Point(368, 307);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(437, 23);
            TxtBuscar.TabIndex = 21;
            // 
            // LblBuscar
            // 
            LblBuscar.Location = new Point(279, 310);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(121, 16);
            LblBuscar.TabIndex = 20;
            LblBuscar.Text = "Buscar:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBuscar.BackColor = Color.RoyalBlue;
            BtnBuscar.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = SystemColors.ControlLightLight;
            BtnBuscar.Location = new Point(829, 296);
            BtnBuscar.Margin = new Padding(0);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(119, 40);
            BtnBuscar.TabIndex = 22;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // FrmReglamento
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(BtnBuscar);
            Controls.Add(TxtBuscar);
            Controls.Add(LblBuscar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(RtbTxtDescripcion);
            Controls.Add(LblDescripcion);
            Controls.Add(TxtNombreRegla);
            Controls.Add(LblNombreRegla);
            Controls.Add(DgvReglas);
            Controls.Add(Pnl1);
            Controls.Add(Pnl2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReglamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reglamento";
            FormClosed += FrmReglamento_FormClosed;
            Load += FrmReglamento_Load;
            Pnl2.ResumeLayout(false);
            Pnl2.PerformLayout();
            Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvReglas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ComboBox CmbCboDeporte;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.DataGridView DgvReglas;
        private System.Windows.Forms.Label LblNombreRegla;
        private System.Windows.Forms.TextBox TxtNombreRegla;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.RichTextBox RtbTxtDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}