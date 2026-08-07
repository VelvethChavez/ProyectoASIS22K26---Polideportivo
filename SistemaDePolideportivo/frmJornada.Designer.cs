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
            txtCampeonato = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreJornada = new TextBox();
            numNumeroJornada = new NumericUpDown();
            dtpFechaJornada = new DateTimePicker();
            dgvJornadas = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            btnRegresarMenuCompeticiones = new Button();
            ((System.ComponentModel.ISupportInitialize)numNumeroJornada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJornadas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "Campeonato:";
            // 
            // txtCampeonato
            // 
            txtCampeonato.Location = new Point(173, 40);
            txtCampeonato.Margin = new Padding(3, 2, 3, 2);
            txtCampeonato.Name = "txtCampeonato";
            txtCampeonato.Size = new Size(206, 23);
            txtCampeonato.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 78);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 2;
            label2.Text = "Datos de la Jornada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 148);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 3;
            label3.Text = "Numero de la Jornada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 112);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 4;
            label4.Text = "Nombre de la Jornada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 182);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 5;
            label5.Text = "Fecha de la Jornada:";
            // 
            // txtNombreJornada
            // 
            txtNombreJornada.Location = new Point(200, 112);
            txtNombreJornada.Margin = new Padding(3, 2, 3, 2);
            txtNombreJornada.Name = "txtNombreJornada";
            txtNombreJornada.Size = new Size(206, 23);
            txtNombreJornada.TabIndex = 6;
            // 
            // numNumeroJornada
            // 
            numNumeroJornada.Location = new Point(200, 152);
            numNumeroJornada.Margin = new Padding(3, 2, 3, 2);
            numNumeroJornada.Name = "numNumeroJornada";
            numNumeroJornada.Size = new Size(108, 23);
            numNumeroJornada.TabIndex = 7;
            // 
            // dtpFechaJornada
            // 
            dtpFechaJornada.Location = new Point(187, 184);
            dtpFechaJornada.Margin = new Padding(3, 2, 3, 2);
            dtpFechaJornada.Name = "dtpFechaJornada";
            dtpFechaJornada.Size = new Size(243, 23);
            dtpFechaJornada.TabIndex = 8;
            // 
            // dgvJornadas
            // 
            dgvJornadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJornadas.Location = new Point(11, 208);
            dgvJornadas.Margin = new Padding(3, 2, 3, 2);
            dgvJornadas.Name = "dgvJornadas";
            dgvJornadas.RowHeadersWidth = 51;
            dgvJornadas.Size = new Size(678, 120);
            dgvJornadas.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Location = new Point(620, 70);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(58, 47);
            btnNuevo.TabIndex = 34;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(536, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 47);
            btnEliminar.TabIndex = 33;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(620, 139);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 47);
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
            btnGuardar.Location = new Point(532, 136);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(58, 50);
            btnGuardar.TabIndex = 31;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresarMenuCompeticiones
            // 
            btnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("btnRegresarMenuCompeticiones.BackgroundImage");
            btnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            btnRegresarMenuCompeticiones.Location = new Point(620, 12);
            btnRegresarMenuCompeticiones.Name = "btnRegresarMenuCompeticiones";
            btnRegresarMenuCompeticiones.Size = new Size(58, 47);
            btnRegresarMenuCompeticiones.TabIndex = 35;
            btnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            btnRegresarMenuCompeticiones.Click += btnRegresarMenuCompeticiones_Click;
            // 
            // frmJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(btnRegresarMenuCompeticiones);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvJornadas);
            Controls.Add(dtpFechaJornada);
            Controls.Add(numNumeroJornada);
            Controls.Add(txtNombreJornada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCampeonato);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CJornada";
            Load += frmJornada_Load;
            ((System.ComponentModel.ISupportInitialize)numNumeroJornada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJornadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCampeonato;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreJornada;
        private NumericUpDown numNumeroJornada;
        private DateTimePicker dtpFechaJornada;
        private DataGridView dgvJornadas;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
        private Button btnRegresarMenuCompeticiones;
    }
}