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
            ((System.ComponentModel.ISupportInitialize)dgvArbitros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 90);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 1;
            label2.Text = "Datos del Arbitro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 141);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 181);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 229);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 4;
            label5.Text = "Deporte:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(124, 94);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(249, 27);
            txtNombres.TabIndex = 5;
            txtNombres.Text = "Juan";
            // 
            // txtDeporte
            // 
            txtDeporte.Location = new Point(125, 233);
            txtDeporte.Name = "txtDeporte";
            txtDeporte.Size = new Size(249, 27);
            txtDeporte.TabIndex = 6;
            txtDeporte.Text = "Futbol";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(125, 185);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(249, 27);
            txtTelefono.TabIndex = 7;
            txtTelefono.Text = "12345678";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(125, 145);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(249, 27);
            txtApellidos.TabIndex = 8;
            txtApellidos.Text = "Hernandez";
            // 
            // dgvArbitros
            // 
            dgvArbitros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbitros.Location = new Point(391, 94);
            dgvArbitros.Name = "dgvArbitros";
            dgvArbitros.RowHeadersWidth = 51;
            dgvArbitros.Size = new Size(388, 195);
            dgvArbitros.TabIndex = 9;
            dgvArbitros.CellContentClick += dgvArbitros_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(391, 43);
            label6.Name = "label6";
            label6.Size = new Size(213, 31);
            label6.TabIndex = 10;
            label6.Text = "Listado de Arbitros:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(318, 355);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 63);
            btnNuevo.TabIndex = 30;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(222, 355);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 63);
            btnEliminar.TabIndex = 29;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(124, 355);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
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
            btnGuardar.Location = new Point(23, 355);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 67);
            btnGuardar.TabIndex = 27;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // frmArbitro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmArbitro";
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
    }
}