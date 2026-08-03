namespace SistemaDePolideportivo
{
    partial class FormEstadistica
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
            cmbJugador = new ComboBox();
            cmbPartido = new ComboBox();
            cmbDeporte = new ComboBox();
            grpEstadisticas = new GroupBox();
            nudCampo4 = new NumericUpDown();
            nudCampo3 = new NumericUpDown();
            nudCampo2 = new NumericUpDown();
            nudCampo1 = new NumericUpDown();
            lblCampo4 = new Label();
            lblCampo3 = new Label();
            lblCampo2 = new Label();
            lblCampo1 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            dgvEstadisticas = new DataGridView();
            lblTitulo = new Label();
            lblJugador = new Label();
            lblPartido = new Label();
            lblDeporte = new Label();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            grpEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCampo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // cmbJugador
            // 
            cmbJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(208, 164);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(304, 28);
            cmbJugador.TabIndex = 1;
            cmbJugador.SelectedIndexChanged += cmbJugador_SelectedIndexChanged;
            // 
            // cmbPartido
            // 
            cmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartido.FormattingEnabled = true;
            cmbPartido.Location = new Point(208, 206);
            cmbPartido.Name = "cmbPartido";
            cmbPartido.Size = new Size(304, 28);
            cmbPartido.TabIndex = 2;
            cmbPartido.SelectedIndexChanged += cmbPartido_SelectedIndexChanged;
            // 
            // cmbDeporte
            // 
            cmbDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Items.AddRange(new object[] { "Fútbol", "Baloncesto", "Voleibol", "Tenis" });
            cmbDeporte.Location = new Point(208, 249);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(304, 28);
            cmbDeporte.TabIndex = 3;
            cmbDeporte.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // grpEstadisticas
            // 
            grpEstadisticas.Controls.Add(nudCampo4);
            grpEstadisticas.Controls.Add(nudCampo3);
            grpEstadisticas.Controls.Add(nudCampo2);
            grpEstadisticas.Controls.Add(nudCampo1);
            grpEstadisticas.Controls.Add(lblCampo4);
            grpEstadisticas.Controls.Add(lblCampo3);
            grpEstadisticas.Controls.Add(lblCampo2);
            grpEstadisticas.Controls.Add(lblCampo1);
            grpEstadisticas.ForeColor = Color.ForestGreen;
            grpEstadisticas.Location = new Point(89, 443);
            grpEstadisticas.Name = "grpEstadisticas";
            grpEstadisticas.Size = new Size(620, 223);
            grpEstadisticas.TabIndex = 5;
            grpEstadisticas.TabStop = false;
            grpEstadisticas.Text = "Estadísticas";
            grpEstadisticas.Enter += grpEstadisticas_Enter;
            // 
            // nudCampo4
            // 
            nudCampo4.Location = new Point(137, 175);
            nudCampo4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCampo4.Name = "nudCampo4";
            nudCampo4.Size = new Size(286, 27);
            nudCampo4.TabIndex = 7;
            nudCampo4.TextAlign = HorizontalAlignment.Center;
            nudCampo4.ValueChanged += nudCampo4_ValueChanged;
            // 
            // nudCampo3
            // 
            nudCampo3.Location = new Point(137, 130);
            nudCampo3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCampo3.Name = "nudCampo3";
            nudCampo3.Size = new Size(286, 27);
            nudCampo3.TabIndex = 6;
            nudCampo3.TextAlign = HorizontalAlignment.Center;
            nudCampo3.ValueChanged += nudCampo3_ValueChanged;
            // 
            // nudCampo2
            // 
            nudCampo2.Location = new Point(137, 83);
            nudCampo2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCampo2.Name = "nudCampo2";
            nudCampo2.Size = new Size(286, 27);
            nudCampo2.TabIndex = 5;
            nudCampo2.TextAlign = HorizontalAlignment.Center;
            nudCampo2.ValueChanged += nudCampo2_ValueChanged;
            // 
            // nudCampo1
            // 
            nudCampo1.Location = new Point(137, 39);
            nudCampo1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCampo1.Name = "nudCampo1";
            nudCampo1.Size = new Size(286, 27);
            nudCampo1.TabIndex = 4;
            nudCampo1.TextAlign = HorizontalAlignment.Center;
            nudCampo1.ValueChanged += nudCampo1_ValueChanged;
            // 
            // lblCampo4
            // 
            lblCampo4.AutoSize = true;
            lblCampo4.Location = new Point(6, 177);
            lblCampo4.Name = "lblCampo4";
            lblCampo4.Size = new Size(99, 20);
            lblCampo4.TabIndex = 3;
            lblCampo4.Text = "Tarjetas Rojas";
            lblCampo4.Click += lblCampo4_Click;
            // 
            // lblCampo3
            // 
            lblCampo3.AutoSize = true;
            lblCampo3.Location = new Point(6, 132);
            lblCampo3.Name = "lblCampo3";
            lblCampo3.Size = new Size(125, 20);
            lblCampo3.TabIndex = 2;
            lblCampo3.Text = "Tarjetas Amarillas";
            lblCampo3.Click += lblCampo3_Click;
            // 
            // lblCampo2
            // 
            lblCampo2.AutoSize = true;
            lblCampo2.Location = new Point(6, 90);
            lblCampo2.Name = "lblCampo2";
            lblCampo2.Size = new Size(81, 20);
            lblCampo2.TabIndex = 1;
            lblCampo2.Text = "Asistencias";
            lblCampo2.Click += lblCampo2_Click;
            // 
            // lblCampo1
            // 
            lblCampo1.AutoSize = true;
            lblCampo1.Location = new Point(6, 41);
            lblCampo1.Name = "lblCampo1";
            lblCampo1.Size = new Size(49, 20);
            lblCampo1.TabIndex = 0;
            lblCampo1.Text = "Goles:";
            lblCampo1.Click += lblCampo1_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.ForestGreen;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(89, 692);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(208, 692);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(327, 692);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(446, 692);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(559, 692);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(208, 746);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(304, 27);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(95, 753);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 12;
            label1.Text = "Buscar:";
            label1.Click += label1_Click;
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadisticas.Location = new Point(95, 800);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.RowHeadersWidth = 51;
            dgvEstadisticas.Size = new Size(614, 188);
            dgvEstadisticas.TabIndex = 13;
            dgvEstadisticas.CellContentClick += dgvEstadisticas_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.ForestGreen;
            lblTitulo.Location = new Point(274, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(341, 41);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Gestión De Estadísticas";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.ForeColor = Color.ForestGreen;
            lblJugador.Location = new Point(122, 167);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(64, 20);
            lblJugador.TabIndex = 15;
            lblJugador.Text = "jugador:";
            lblJugador.Click += label2_Click;
            // 
            // lblPartido
            // 
            lblPartido.AutoSize = true;
            lblPartido.ForeColor = Color.ForestGreen;
            lblPartido.Location = new Point(122, 209);
            lblPartido.Name = "lblPartido";
            lblPartido.Size = new Size(59, 20);
            lblPartido.TabIndex = 16;
            lblPartido.Text = "Partido:";
            lblPartido.Click += label3_Click;
            // 
            // lblDeporte
            // 
            lblDeporte.AutoSize = true;
            lblDeporte.ForeColor = Color.ForestGreen;
            lblDeporte.Location = new Point(119, 252);
            lblDeporte.Name = "lblDeporte";
            lblDeporte.Size = new Size(67, 20);
            lblDeporte.TabIndex = 17;
            lblDeporte.Text = "Deporte:";
            lblDeporte.Click += label4_Click;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.ForeColor = Color.ForestGreen;
            lblObservaciones.Location = new Point(356, 314);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(108, 20);
            lblObservaciones.TabIndex = 18;
            lblObservaciones.Text = "Observaciones:";
            lblObservaciones.Click += label5_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(89, 358);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(620, 60);
            txtObservaciones.TabIndex = 19;
            txtObservaciones.TextChanged += textBox1_TextChanged;
            // 
            // FormEstadistica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 1006);
            Controls.Add(txtObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(lblDeporte);
            Controls.Add(lblPartido);
            Controls.Add(lblJugador);
            Controls.Add(lblTitulo);
            Controls.Add(dgvEstadisticas);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpEstadisticas);
            Controls.Add(cmbDeporte);
            Controls.Add(cmbPartido);
            Controls.Add(cmbJugador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstadistica";
            Text = "FormEstadistica";
            Load += FormEstadistica_Load;
            grpEstadisticas.ResumeLayout(false);
            grpEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCampo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCampo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbJugador;
        private ComboBox cmbPartido;
        private ComboBox cmbDeporte;
        private GroupBox grpEstadisticas;
        private Label lblCampo4;
        private Label lblCampo3;
        private Label lblCampo2;
        private Label lblCampo1;
        private NumericUpDown nudCampo4;
        private NumericUpDown nudCampo3;
        private NumericUpDown nudCampo2;
        private NumericUpDown nudCampo1;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dgvEstadisticas;
        private Label lblTitulo;
        private Label lblJugador;
        private Label lblPartido;
        private Label lblDeporte;
        private Label lblObservaciones;
        private TextBox txtObservaciones;

        private void cmbJugador_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e) { }
        private void grpEstadisticas_Enter(object sender, EventArgs e) { }
        private void nudCampo1_ValueChanged(object sender, EventArgs e) { }
        private void nudCampo2_ValueChanged(object sender, EventArgs e) { }
        private void nudCampo3_ValueChanged(object sender, EventArgs e) { }
        private void nudCampo4_ValueChanged(object sender, EventArgs e) { }
        private void lblCampo1_Click(object sender, EventArgs e) { }
        private void lblCampo2_Click(object sender, EventArgs e) { }
        private void lblCampo3_Click(object sender, EventArgs e) { }
        private void lblCampo4_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}