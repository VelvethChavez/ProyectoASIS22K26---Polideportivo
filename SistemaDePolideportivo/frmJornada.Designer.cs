namespace SistemaDePolideportivo
{
    partial class frmJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJornada));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpFechaJornada = new DateTimePicker();
            dgvJornadas = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            btnRegresarMenuCompeticiones = new Button();
            comboBoxCampeonato = new ComboBox();
            txtNombreJornada = new TextBox();
            numNumeroJornada = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvJornadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumeroJornada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 43);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 0;
            label1.Text = "Campeonato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 104);
            label2.Name = "label2";
            label2.Size = new Size(220, 31);
            label2.TabIndex = 2;
            label2.Text = "Datos de la Jornada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 197);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 3;
            label3.Text = "Numero de la Jornada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 149);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 4;
            label4.Text = "Nombre de la Jornada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 243);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 5;
            label5.Text = "Fecha de la Jornada:";
            // 
            // dtpFechaJornada
            // 
            dtpFechaJornada.Location = new Point(227, 245);
            dtpFechaJornada.Name = "dtpFechaJornada";
            dtpFechaJornada.Size = new Size(277, 27);
            dtpFechaJornada.TabIndex = 8;
            // 
            // dgvJornadas
            // 
            dgvJornadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJornadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJornadas.Location = new Point(13, 277);
            dgvJornadas.Name = "dgvJornadas";
            dgvJornadas.RowHeadersWidth = 51;
            dgvJornadas.Size = new Size(775, 160);
            dgvJornadas.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Location = new Point(709, 93);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 63);
            btnNuevo.TabIndex = 34;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(613, 93);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 63);
            btnEliminar.TabIndex = 33;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(709, 185);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 32;
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
            btnGuardar.Location = new Point(608, 181);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 67);
            btnGuardar.TabIndex = 31;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresarMenuCompeticiones
            // 
            btnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("btnRegresarMenuCompeticiones.BackgroundImage");
            btnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            btnRegresarMenuCompeticiones.Location = new Point(709, 16);
            btnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            btnRegresarMenuCompeticiones.Name = "btnRegresarMenuCompeticiones";
            btnRegresarMenuCompeticiones.Size = new Size(66, 63);
            btnRegresarMenuCompeticiones.TabIndex = 35;
            btnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            btnRegresarMenuCompeticiones.Click += btnRegresarMenuCompeticiones_Click;
            // 
            // comboBoxCampeonato
            // 
            comboBoxCampeonato.FormattingEnabled = true;
            comboBoxCampeonato.Location = new Point(227, 53);
            comboBoxCampeonato.Name = "comboBoxCampeonato";
            comboBoxCampeonato.Size = new Size(185, 28);
            comboBoxCampeonato.TabIndex = 36;
            comboBoxCampeonato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNombreJornada
            // 
            txtNombreJornada.Location = new Point(228, 153);
            txtNombreJornada.Name = "txtNombreJornada";
            txtNombreJornada.Size = new Size(184, 27);
            txtNombreJornada.TabIndex = 39;
            // 
            // numNumeroJornada
            // 
            numNumeroJornada.Location = new Point(228, 202);
            numNumeroJornada.Name = "numNumeroJornada";
            numNumeroJornada.Size = new Size(184, 27);
            numNumeroJornada.TabIndex = 40;
            // 
            // frmJornada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(numNumeroJornada);
            Controls.Add(txtNombreJornada);
            Controls.Add(comboBoxCampeonato);
            Controls.Add(btnRegresarMenuCompeticiones);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvJornadas);
            Controls.Add(dtpFechaJornada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CJornada";
            Load += frmJornada_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJornadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumeroJornada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFechaJornada;
        private DataGridView dgvJornadas;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
        private Button btnRegresarMenuCompeticiones;
        private ComboBox comboBoxCampeonato;
        private TextBox txtNombreJornada;
        private NumericUpDown numNumeroJornada;
    }
}