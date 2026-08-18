namespace SistemaDePolideportivo
{
    partial class FrmEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadistica));
            CmbJugador = new ComboBox();
            CmbPartido = new ComboBox();
            CmbDeporte = new ComboBox();
            GrpEstadisticas = new GroupBox();
            NudCampo4 = new NumericUpDown();
            NudCampo3 = new NumericUpDown();
            NudCampo2 = new NumericUpDown();
            NudCampo1 = new NumericUpDown();
            LblCampo4 = new Label();
            LblCampo3 = new Label();
            LblCampo2 = new Label();
            LblCampo1 = new Label();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            Lbl1 = new Label();
            DgvEstadisticas = new DataGridView();
            LblTitulo = new Label();
            LblJugador = new Label();
            LblPartido = new Label();
            LblDeporte = new Label();
            LblObservaciones = new Label();
            TxtObservaciones = new TextBox();
            BtnMenu = new Button();
            GrpEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudCampo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // CmbJugador
            // 
            CmbJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbJugador.FormattingEnabled = true;
            CmbJugador.Location = new Point(102, 81);
            CmbJugador.Margin = new Padding(3, 2, 3, 2);
            CmbJugador.Name = "CmbJugador";
            CmbJugador.Size = new Size(266, 23);
            CmbJugador.TabIndex = 1;
            CmbJugador.SelectedIndexChanged += CmbJugador_SelectedIndexChanged;
            // 
            // CmbPartido
            // 
            CmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPartido.FormattingEnabled = true;
            CmbPartido.Location = new Point(102, 112);
            CmbPartido.Margin = new Padding(3, 2, 3, 2);
            CmbPartido.Name = "CmbPartido";
            CmbPartido.Size = new Size(266, 23);
            CmbPartido.TabIndex = 2;
            CmbPartido.SelectedIndexChanged += CmbPartido_SelectedIndexChanged;
            // 
            // CmbDeporte
            // 
            CmbDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbDeporte.FormattingEnabled = true;
            CmbDeporte.Items.AddRange(new object[] { "Fútbol", "Baloncesto", "Voleibol", "Tenis" });
            CmbDeporte.Location = new Point(102, 145);
            CmbDeporte.Margin = new Padding(3, 2, 3, 2);
            CmbDeporte.Name = "CmbDeporte";
            CmbDeporte.Size = new Size(266, 23);
            CmbDeporte.TabIndex = 3;
            CmbDeporte.SelectedIndexChanged += CmbDeporte_SelectedIndexChanged;
            // 
            // GrpEstadisticas
            // 
            GrpEstadisticas.Controls.Add(NudCampo4);
            GrpEstadisticas.Controls.Add(NudCampo3);
            GrpEstadisticas.Controls.Add(NudCampo2);
            GrpEstadisticas.Controls.Add(NudCampo1);
            GrpEstadisticas.Controls.Add(LblCampo4);
            GrpEstadisticas.Controls.Add(LblCampo3);
            GrpEstadisticas.Controls.Add(LblCampo2);
            GrpEstadisticas.Controls.Add(LblCampo1);
            GrpEstadisticas.ForeColor = Color.ForestGreen;
            GrpEstadisticas.Location = new Point(143, 198);
            GrpEstadisticas.Margin = new Padding(3, 2, 3, 2);
            GrpEstadisticas.Name = "GrpEstadisticas";
            GrpEstadisticas.Padding = new Padding(3, 2, 3, 2);
            GrpEstadisticas.Size = new Size(542, 167);
            GrpEstadisticas.TabIndex = 5;
            GrpEstadisticas.TabStop = false;
            GrpEstadisticas.Text = "Estadísticas";
            GrpEstadisticas.Enter += GrpEstadisticas_Enter;
            // 
            // NudCampo4
            // 
            NudCampo4.Location = new Point(120, 131);
            NudCampo4.Margin = new Padding(3, 2, 3, 2);
            NudCampo4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudCampo4.Name = "NudCampo4";
            NudCampo4.Size = new Size(250, 23);
            NudCampo4.TabIndex = 7;
            NudCampo4.TextAlign = HorizontalAlignment.Center;
            NudCampo4.ValueChanged += NudCampo4_ValueChanged;
            // 
            // NudCampo3
            // 
            NudCampo3.Location = new Point(120, 98);
            NudCampo3.Margin = new Padding(3, 2, 3, 2);
            NudCampo3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudCampo3.Name = "NudCampo3";
            NudCampo3.Size = new Size(250, 23);
            NudCampo3.TabIndex = 6;
            NudCampo3.TextAlign = HorizontalAlignment.Center;
            NudCampo3.ValueChanged += NudCampo3_ValueChanged;
            // 
            // NudCampo2
            // 
            NudCampo2.Location = new Point(120, 62);
            NudCampo2.Margin = new Padding(3, 2, 3, 2);
            NudCampo2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudCampo2.Name = "NudCampo2";
            NudCampo2.Size = new Size(250, 23);
            NudCampo2.TabIndex = 5;
            NudCampo2.TextAlign = HorizontalAlignment.Center;
            NudCampo2.ValueChanged += NudCampo2_ValueChanged;
            // 
            // NudCampo1
            // 
            NudCampo1.Location = new Point(120, 29);
            NudCampo1.Margin = new Padding(3, 2, 3, 2);
            NudCampo1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudCampo1.Name = "NudCampo1";
            NudCampo1.Size = new Size(250, 23);
            NudCampo1.TabIndex = 4;
            NudCampo1.TextAlign = HorizontalAlignment.Center;
            NudCampo1.ValueChanged += NudCampo1_ValueChanged;
            // 
            // LblCampo4
            // 
            LblCampo4.AutoSize = true;
            LblCampo4.Location = new Point(5, 133);
            LblCampo4.Name = "LblCampo4";
            LblCampo4.Size = new Size(78, 15);
            LblCampo4.TabIndex = 3;
            LblCampo4.Text = "Tarjetas Rojas";
            LblCampo4.Click += LblCampo4_Click;
            // 
            // LblCampo3
            // 
            LblCampo3.AutoSize = true;
            LblCampo3.Location = new Point(5, 99);
            LblCampo3.Name = "LblCampo3";
            LblCampo3.Size = new Size(99, 15);
            LblCampo3.TabIndex = 2;
            LblCampo3.Text = "Tarjetas Amarillas";
            LblCampo3.Click += LblCampo3_Click;
            // 
            // LblCampo2
            // 
            LblCampo2.AutoSize = true;
            LblCampo2.Location = new Point(5, 68);
            LblCampo2.Name = "LblCampo2";
            LblCampo2.Size = new Size(65, 15);
            LblCampo2.TabIndex = 1;
            LblCampo2.Text = "Asistencias";
            LblCampo2.Click += LblCampo2_Click;
            // 
            // LblCampo1
            // 
            LblCampo1.AutoSize = true;
            LblCampo1.Location = new Point(5, 31);
            LblCampo1.Name = "LblCampo1";
            LblCampo1.Size = new Size(39, 15);
            LblCampo1.TabIndex = 0;
            LblCampo1.Text = "Goles:";
            LblCampo1.Click += LblCampo1_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.ForestGreen;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.ForeColor = Color.White;
            BtnNuevo.Location = new Point(152, 387);
            BtnNuevo.Margin = new Padding(3, 2, 3, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(82, 37);
            BtnNuevo.TabIndex = 6;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.ForestGreen;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(256, 387);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(82, 37);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.ForestGreen;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(360, 387);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(82, 37);
            BtnEditar.TabIndex = 8;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.ForestGreen;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(464, 387);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(82, 37);
            BtnEliminar.TabIndex = 9;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.ForestGreen;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(563, 387);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(82, 37);
            BtnBuscar.TabIndex = 10;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(315, 453);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(266, 23);
            TxtBuscar.TabIndex = 11;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.ForeColor = Color.ForestGreen;
            Lbl1.Location = new Point(216, 458);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(45, 15);
            Lbl1.TabIndex = 12;
            Lbl1.Text = "Buscar:";
            Lbl1.Click += Lbl1_Click;
            // 
            // DgvEstadisticas
            // 
            DgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEstadisticas.Location = new Point(148, 496);
            DgvEstadisticas.Margin = new Padding(3, 2, 3, 2);
            DgvEstadisticas.Name = "DgvEstadisticas";
            DgvEstadisticas.RowHeadersWidth = 51;
            DgvEstadisticas.Size = new Size(537, 141);
            DgvEstadisticas.TabIndex = 13;
            DgvEstadisticas.CellContentClick += DgvEstadisticas_CellContentClick;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.ForestGreen;
            LblTitulo.Location = new Point(240, 7);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(277, 32);
            LblTitulo.TabIndex = 14;
            LblTitulo.Text = "Gestión De Estadísticas";
            LblTitulo.Click += LblTitulo_Click;
            // 
            // LblJugador
            // 
            LblJugador.AutoSize = true;
            LblJugador.ForeColor = Color.ForestGreen;
            LblJugador.Location = new Point(27, 83);
            LblJugador.Name = "LblJugador";
            LblJugador.Size = new Size(52, 15);
            LblJugador.TabIndex = 15;
            LblJugador.Text = "Jugador:";
            LblJugador.Click += LblJugador_Click;
            // 
            // LblPartido
            // 
            LblPartido.AutoSize = true;
            LblPartido.ForeColor = Color.ForestGreen;
            LblPartido.Location = new Point(27, 115);
            LblPartido.Name = "LblPartido";
            LblPartido.Size = new Size(48, 15);
            LblPartido.TabIndex = 16;
            LblPartido.Text = "Partido:";
            LblPartido.Click += LblPartido_Click;
            // 
            // LblDeporte
            // 
            LblDeporte.AutoSize = true;
            LblDeporte.ForeColor = Color.ForestGreen;
            LblDeporte.Location = new Point(24, 147);
            LblDeporte.Name = "LblDeporte";
            LblDeporte.Size = new Size(52, 15);
            LblDeporte.TabIndex = 17;
            LblDeporte.Text = "Deporte:";
            LblDeporte.Click += LblDeporte_Click;
            // 
            // LblObservaciones
            // 
            LblObservaciones.AutoSize = true;
            LblObservaciones.ForeColor = Color.ForestGreen;
            LblObservaciones.Location = new Point(430, 81);
            LblObservaciones.Name = "LblObservaciones";
            LblObservaciones.Size = new Size(87, 15);
            LblObservaciones.TabIndex = 18;
            LblObservaciones.Text = "Observaciones:";
            LblObservaciones.Click += LblObservaciones_Click;
            // 
            // TxtObservaciones
            // 
            TxtObservaciones.Location = new Point(430, 98);
            TxtObservaciones.Margin = new Padding(3, 2, 3, 2);
            TxtObservaciones.Multiline = true;
            TxtObservaciones.Name = "TxtObservaciones";
            TxtObservaciones.Size = new Size(346, 70);
            TxtObservaciones.TabIndex = 19;
            TxtObservaciones.TextChanged += TxtObservaciones_TextChanged;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.Location = new Point(12, 12);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(62, 51);
            BtnMenu.TabIndex = 20;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // FrmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 667);
            Controls.Add(BtnMenu);
            Controls.Add(TxtObservaciones);
            Controls.Add(LblObservaciones);
            Controls.Add(LblDeporte);
            Controls.Add(LblPartido);
            Controls.Add(LblJugador);
            Controls.Add(LblTitulo);
            Controls.Add(DgvEstadisticas);
            Controls.Add(Lbl1);
            Controls.Add(TxtBuscar);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(GrpEstadisticas);
            Controls.Add(CmbDeporte);
            Controls.Add(CmbPartido);
            Controls.Add(CmbJugador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstadistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstadistica";
            Load += FrmEstadistica_Load;
            GrpEstadisticas.ResumeLayout(false);
            GrpEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudCampo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCampo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvEstadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CmbJugador;
        private ComboBox CmbPartido;
        private ComboBox CmbDeporte;
        private GroupBox GrpEstadisticas;
        private Label LblCampo4;
        private Label LblCampo3;
        private Label LblCampo2;
        private Label LblCampo1;
        private NumericUpDown NudCampo4;
        private NumericUpDown NudCampo3;
        private NumericUpDown NudCampo2;
        private NumericUpDown NudCampo1;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnBuscar;
        private TextBox TxtBuscar;
        private Label Lbl1;
        private DataGridView DgvEstadisticas;
        private Label LblTitulo;
        private Label LblJugador;
        private Label LblPartido;
        private Label LblDeporte;
        private Label LblObservaciones;
        private TextBox TxtObservaciones;

        private void CmbJugador_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CmbPartido_SelectedIndexChanged(object sender, EventArgs e) { }
        private void GrpEstadisticas_Enter(object sender, EventArgs e) { }
        private void NudCampo1_ValueChanged(object sender, EventArgs e) { }
        private void NudCampo2_ValueChanged(object sender, EventArgs e) { }
        private void NudCampo3_ValueChanged(object sender, EventArgs e) { }
        private void NudCampo4_ValueChanged(object sender, EventArgs e) { }
        private void LblCampo1_Click(object sender, EventArgs e) { }
        private void LblCampo2_Click(object sender, EventArgs e) { }
        private void LblCampo3_Click(object sender, EventArgs e) { }
        private void LblCampo4_Click(object sender, EventArgs e) { }
        private void LblTitulo_Click(object sender, EventArgs e) { }
        private void Lbl1_Click(object sender, EventArgs e) { }
        private void LblJugador_Click(object sender, EventArgs e) { }
        private void LblPartido_Click(object sender, EventArgs e) { }
        private void LblDeporte_Click(object sender, EventArgs e) { }
        private void LblObservaciones_Click(object sender, EventArgs e) { }
        private void TxtObservaciones_TextChanged(object sender, EventArgs e) { }
        private Button BtnMenu;
    }
}