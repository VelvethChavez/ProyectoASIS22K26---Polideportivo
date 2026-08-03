namespace SistemaDePolideportivo
{
    partial class frmProgramarPartido
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            txtJornada = new TextBox();
            txtEquipoLocal = new TextBox();
            txtCampo = new TextBox();
            txtEquipoVisitante = new TextBox();
            txtArbitro = new TextBox();
            dgvPartidos = new DataGridView();
            dtpFechaPartido = new DateTimePicker();
            dtpHoraPartido = new DateTimePicker();
            txtEstado = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(0, 31);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 278);
            label6.Name = "label6";
            label6.Size = new Size(0, 31);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(0, 31);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 205);
            label8.Name = "label8";
            label8.Size = new Size(0, 31);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 9);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 8;
            label9.Text = "Jornada:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 47);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 9;
            label10.Text = "Equipo Local:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 174);
            label11.Name = "label11";
            label11.Size = new Size(79, 28);
            label11.TabIndex = 10;
            label11.Text = "Arbitro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 132);
            label12.Name = "label12";
            label12.Size = new Size(79, 28);
            label12.TabIndex = 11;
            label12.Text = "Campo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(18, 90);
            label13.Name = "label13";
            label13.Size = new Size(158, 28);
            label13.TabIndex = 12;
            label13.Text = "Equipo Visitante:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(18, 275);
            label15.Name = "label15";
            label15.Size = new Size(143, 28);
            label15.TabIndex = 14;
            label15.Text = "Estado Partido:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(18, 212);
            label16.Name = "label16";
            label16.Size = new Size(134, 28);
            label16.TabIndex = 15;
            label16.Text = "Fecha Partido:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(18, 246);
            label17.Name = "label17";
            label17.Size = new Size(126, 28);
            label17.TabIndex = 16;
            label17.Text = "Hora:Partido:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(18, 337);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 18;
            // 
            // txtJornada
            // 
            txtJornada.Location = new Point(109, 13);
            txtJornada.Name = "txtJornada";
            txtJornada.Size = new Size(236, 27);
            txtJornada.TabIndex = 19;
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(182, 51);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(236, 27);
            txtEquipoLocal.TabIndex = 20;
            // 
            // txtCampo
            // 
            txtCampo.Location = new Point(109, 133);
            txtCampo.Name = "txtCampo";
            txtCampo.Size = new Size(236, 27);
            txtCampo.TabIndex = 21;
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(182, 94);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(236, 27);
            txtEquipoVisitante.TabIndex = 22;
            // 
            // txtArbitro
            // 
            txtArbitro.Location = new Point(109, 174);
            txtArbitro.Name = "txtArbitro";
            txtArbitro.Size = new Size(236, 27);
            txtArbitro.TabIndex = 23;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(24, 309);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.RowHeadersWidth = 51;
            dgvPartidos.Size = new Size(764, 125);
            dgvPartidos.TabIndex = 24;
            // 
            // dtpFechaPartido
            // 
            dtpFechaPartido.Location = new Point(158, 213);
            dtpFechaPartido.Name = "dtpFechaPartido";
            dtpFechaPartido.Size = new Size(269, 27);
            dtpFechaPartido.TabIndex = 25;
            // 
            // dtpHoraPartido
            // 
            dtpHoraPartido.Format = DateTimePickerFormat.Time;
            dtpHoraPartido.Location = new Point(158, 246);
            dtpHoraPartido.Name = "dtpHoraPartido";
            dtpHoraPartido.Size = new Size(137, 27);
            dtpHoraPartido.TabIndex = 26;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(158, 276);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(236, 27);
            txtEstado.TabIndex = 27;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(693, 55);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 63);
            btnNuevo.TabIndex = 38;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(597, 55);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 63);
            btnEliminar.TabIndex = 37;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(693, 147);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 36;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = Properties.Resources.guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(592, 143);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 67);
            btnGuardar.TabIndex = 35;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // frmProgramarPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstado);
            Controls.Add(dtpHoraPartido);
            Controls.Add(dtpFechaPartido);
            Controls.Add(dgvPartidos);
            Controls.Add(txtArbitro);
            Controls.Add(txtEquipoVisitante);
            Controls.Add(txtCampo);
            Controls.Add(txtEquipoLocal);
            Controls.Add(txtJornada);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProgramarPartido";
            Text = "frmProgramarPartido";
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private TextBox txtJornada;
        private TextBox txtEquipoLocal;
        private TextBox txtCampo;
        private TextBox txtEquipoVisitante;
        private TextBox txtArbitro;
        private DataGridView dgvPartidos;
        private DateTimePicker dtpFechaPartido;
        private DateTimePicker dtpHoraPartido;
        private TextBox txtEstado;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
    }
}