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
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Entrenadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 137);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 172);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(37, 214);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(222, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(441, 214);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(661, 214);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(718, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Location = new Point(155, 65);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.Size = new Size(269, 27);
            txtNombreEntrenador.TabIndex = 10;
            // 
            // txtApellidoEntrenador
            // 
            txtApellidoEntrenador.Location = new Point(155, 97);
            txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            txtApellidoEntrenador.Size = new Size(269, 27);
            txtApellidoEntrenador.TabIndex = 11;
            // 
            // txtTelefonoEntrenador
            // 
            txtTelefonoEntrenador.Location = new Point(155, 132);
            txtTelefonoEntrenador.Name = "txtTelefonoEntrenador";
            txtTelefonoEntrenador.Size = new Size(269, 27);
            txtTelefonoEntrenador.TabIndex = 12;
            // 
            // txtCorreoEntrenador
            // 
            txtCorreoEntrenador.Location = new Point(155, 165);
            txtCorreoEntrenador.Name = "txtCorreoEntrenador";
            txtCorreoEntrenador.Size = new Size(269, 27);
            txtCorreoEntrenador.TabIndex = 13;
            // 
            // Entrenadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Entrenadores";
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