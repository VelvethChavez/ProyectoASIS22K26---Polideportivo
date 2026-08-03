namespace SistemaDePolideportivo
{
    partial class frmJugadores
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
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            ckbEstadoJugadores = new CheckBox();
            cmbPosicionJugadores = new ComboBox();
            cmbEquipoJugadores = new ComboBox();
            nudDorsalJugadores = new NumericUpDown();
            btnExaminar = new Button();
            dtpNacimientoJugadores = new DateTimePicker();
            txtNombresJugadores = new TextBox();
            txtApellidosJugadores = new TextBox();
            txtFotoJugadores = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudDorsalJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(245, 333);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(460, 333);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(675, 333);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button4_Click;
            // 
            // ckbEstadoJugadores
            // 
            ckbEstadoJugadores.AutoSize = true;
            ckbEstadoJugadores.Location = new Point(144, 289);
            ckbEstadoJugadores.Name = "ckbEstadoJugadores";
            ckbEstadoJugadores.Size = new Size(73, 24);
            ckbEstadoJugadores.TabIndex = 4;
            ckbEstadoJugadores.Text = "Activo";
            ckbEstadoJugadores.UseVisualStyleBackColor = true;
            // 
            // cmbPosicionJugadores
            // 
            cmbPosicionJugadores.FormattingEnabled = true;
            cmbPosicionJugadores.Location = new Point(144, 221);
            cmbPosicionJugadores.Name = "cmbPosicionJugadores";
            cmbPosicionJugadores.Size = new Size(283, 28);
            cmbPosicionJugadores.TabIndex = 5;
            // 
            // cmbEquipoJugadores
            // 
            cmbEquipoJugadores.FormattingEnabled = true;
            cmbEquipoJugadores.Location = new Point(144, 255);
            cmbEquipoJugadores.Name = "cmbEquipoJugadores";
            cmbEquipoJugadores.Size = new Size(283, 28);
            cmbEquipoJugadores.TabIndex = 6;
            // 
            // nudDorsalJugadores
            // 
            nudDorsalJugadores.Location = new Point(144, 187);
            nudDorsalJugadores.Name = "nudDorsalJugadores";
            nudDorsalJugadores.Size = new Size(46, 27);
            nudDorsalJugadores.TabIndex = 7;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(335, 152);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(94, 29);
            btnExaminar.TabIndex = 8;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // dtpNacimientoJugadores
            // 
            dtpNacimientoJugadores.Location = new Point(144, 117);
            dtpNacimientoJugadores.Name = "dtpNacimientoJugadores";
            dtpNacimientoJugadores.Size = new Size(283, 27);
            dtpNacimientoJugadores.TabIndex = 9;
            // 
            // txtNombresJugadores
            // 
            txtNombresJugadores.Location = new Point(144, 51);
            txtNombresJugadores.Name = "txtNombresJugadores";
            txtNombresJugadores.Size = new Size(283, 27);
            txtNombresJugadores.TabIndex = 10;
            // 
            // txtApellidosJugadores
            // 
            txtApellidosJugadores.Location = new Point(144, 84);
            txtApellidosJugadores.Name = "txtApellidosJugadores";
            txtApellidosJugadores.Size = new Size(283, 27);
            txtApellidosJugadores.TabIndex = 11;
            // 
            // txtFotoJugadores
            // 
            txtFotoJugadores.Location = new Point(144, 152);
            txtFotoJugadores.Name = "txtFotoJugadores";
            txtFotoJugadores.Size = new Size(176, 27);
            txtFotoJugadores.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 13;
            label1.Text = "Jugadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 87);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 15;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 117);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 152);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 17;
            label5.Text = "Fotografía";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 186);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 18;
            label6.Text = "Dorsal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 224);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 19;
            label7.Text = "Posición";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 258);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 20;
            label8.Text = "Equipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 293);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 21;
            label9.Text = "Estado";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(735, 162);
            dataGridView1.TabIndex = 22;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFotoJugadores);
            Controls.Add(txtApellidosJugadores);
            Controls.Add(txtNombresJugadores);
            Controls.Add(dtpNacimientoJugadores);
            Controls.Add(btnExaminar);
            Controls.Add(nudDorsalJugadores);
            Controls.Add(cmbEquipoJugadores);
            Controls.Add(cmbPosicionJugadores);
            Controls.Add(ckbEstadoJugadores);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "frmJugadores";
            Text = "frmJugadores";
            Load += frmJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)nudDorsalJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private CheckBox ckbEstadoJugadores;
        private ComboBox cmbPosicionJugadores;
        private ComboBox cmbEquipoJugadores;
        private NumericUpDown nudDorsalJugadores;
        private Button btnExaminar;
        private DateTimePicker dtpNacimientoJugadores;
        private TextBox txtNombresJugadores;
        private TextBox txtApellidosJugadores;
        private TextBox txtFotoJugadores;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
    }
}