namespace SistemaDePolideportivo
{
    partial class frmEntrenadores
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
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dataGridView1 = new DataGridView();
            txtNombreEntrenador = new TextBox();
            txtApellidoEntrenador = new TextBox();
            txtTelefonoEntrenador = new TextBox();
            txtCorreoEntrenador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Entrenadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 75);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 103);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 129);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(479, 30);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(52, 44);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = Properties.Resources.editar;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(479, 87);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(52, 44);
            btnEditar.TabIndex = 6;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(572, 30);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(52, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Location = new Point(572, 88);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(52, 44);
            btnNuevo.TabIndex = 8;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 187);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 141);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Location = new Point(136, 49);
            txtNombreEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.Size = new Size(236, 23);
            txtNombreEntrenador.TabIndex = 10;
            // 
            // txtApellidoEntrenador
            // 
            txtApellidoEntrenador.Location = new Point(136, 73);
            txtApellidoEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            txtApellidoEntrenador.Size = new Size(236, 23);
            txtApellidoEntrenador.TabIndex = 11;
            // 
            // txtTelefonoEntrenador
            // 
            txtTelefonoEntrenador.Location = new Point(136, 99);
            txtTelefonoEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoEntrenador.Name = "txtTelefonoEntrenador";
            txtTelefonoEntrenador.Size = new Size(236, 23);
            txtTelefonoEntrenador.TabIndex = 12;
            // 
            // txtCorreoEntrenador
            // 
            txtCorreoEntrenador.Location = new Point(136, 124);
            txtCorreoEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtCorreoEntrenador.Name = "txtCorreoEntrenador";
            txtCorreoEntrenador.Size = new Size(236, 23);
            txtCorreoEntrenador.TabIndex = 13;
            // 
            // frmEntrenadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(txtCorreoEntrenador);
            Controls.Add(txtTelefonoEntrenador);
            Controls.Add(txtApellidoEntrenador);
            Controls.Add(txtNombreEntrenador);
            Controls.Add(dataGridView1);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntrenadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrenadores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dataGridView1;
        private TextBox txtNombreEntrenador;
        private TextBox txtApellidoEntrenador;
        private TextBox txtTelefonoEntrenador;
        private TextBox txtCorreoEntrenador;
    }
}