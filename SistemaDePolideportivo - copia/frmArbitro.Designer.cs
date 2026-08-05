namespace SistemaDePolideportivo
{
    partial class frmArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbitro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombres = new TextBox();
            txtDeporte = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            dgvArbitros = new DataGridView();
            label6 = new Label();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            BtnRegresarMenuCompeticiones = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArbitros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 68);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 1;
            label2.Text = "Datos del Arbitro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 106);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 136);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 172);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 4;
            label5.Text = "Deporte:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(108, 70);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(218, 23);
            txtNombres.TabIndex = 5;
            txtNombres.Text = "Juan";
            // 
            // txtDeporte
            // 
            txtDeporte.Location = new Point(109, 175);
            txtDeporte.Margin = new Padding(3, 2, 3, 2);
            txtDeporte.Name = "txtDeporte";
            txtDeporte.Size = new Size(218, 23);
            txtDeporte.TabIndex = 6;
            txtDeporte.Text = "Futbol";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(109, 139);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.Text = "12345678";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(109, 109);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(218, 23);
            txtApellidos.TabIndex = 8;
            txtApellidos.Text = "Hernandez";
            // 
            // dgvArbitros
            // 
            dgvArbitros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbitros.Location = new Point(342, 70);
            dgvArbitros.Margin = new Padding(3, 2, 3, 2);
            dgvArbitros.Name = "dgvArbitros";
            dgvArbitros.RowHeadersWidth = 51;
            dgvArbitros.Size = new Size(340, 146);
            dgvArbitros.TabIndex = 9;
            dgvArbitros.CellContentClick += dgvArbitros_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(342, 32);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 10;
            label6.Text = "Listado de Arbitros:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(278, 266);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(58, 47);
            btnNuevo.TabIndex = 30;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(194, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 47);
            btnEliminar.TabIndex = 29;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(108, 266);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 47);
            BtnEditar.TabIndex = 28;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click_1;
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
            btnGuardar.Location = new Point(20, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(58, 50);
            btnGuardar.TabIndex = 27;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // BtnRegresarMenuCompeticiones
            // 
            BtnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("BtnRegresarMenuCompeticiones.BackgroundImage");
            BtnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            BtnRegresarMenuCompeticiones.Location = new Point(632, 11);
            BtnRegresarMenuCompeticiones.Name = "BtnRegresarMenuCompeticiones";
            BtnRegresarMenuCompeticiones.Size = new Size(50, 44);
            BtnRegresarMenuCompeticiones.TabIndex = 31;
            BtnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            BtnRegresarMenuCompeticiones.Click += BtnRegresarMenuCompeticiones_Click;
            // 
            // frmArbitro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnRegresarMenuCompeticiones);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(dgvArbitros);
            Controls.Add(txtApellidos);
            Controls.Add(txtTelefono);
            Controls.Add(txtDeporte);
            Controls.Add(txtNombres);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmArbitro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmArbitro";
            Load += frmArbitro_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvArbitros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombres;
        private TextBox txtDeporte;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private DataGridView dgvArbitros;
        private Label label6;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
        private Button BtnRegresarMenuCompeticiones;
    }
}