namespace SistemaDePolideportivo
{
    partial class FrmEntrenadores
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
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            Lbl5 = new Label();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            Dgv1 = new DataGridView();
            TxtNombreEntrenador = new TextBox();
            TxtApellidoEntrenador = new TextBox();
            TxtTelefonoEntrenador = new TextBox();
            TxtCorreoEntrenador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 14F);
            Lbl1.ImageAlign = ContentAlignment.BottomCenter;
            Lbl1.Location = new Point(32, 9);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(124, 25);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Entrenadores";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(32, 49);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(56, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Nombres";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(32, 75);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(56, 15);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Apellidos";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Location = new Point(32, 103);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(53, 15);
            Lbl4.TabIndex = 3;
            Lbl4.Text = "Teléfono";
            Lbl4.Click += Lbl4_Click;
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Location = new Point(32, 129);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(43, 15);
            Lbl5.TabIndex = 4;
            Lbl5.Text = "Correo";
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(479, 30);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(52, 44);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(479, 87);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(52, 44);
            BtnEditar.TabIndex = 6;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(572, 30);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(52, 44);
            BtnEliminar.TabIndex = 7;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(572, 88);
            BtnNuevo.Margin = new Padding(3, 2, 3, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(52, 44);
            BtnNuevo.TabIndex = 8;
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // Dgv1
            // 
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(32, 187);
            Dgv1.Margin = new Padding(3, 2, 3, 2);
            Dgv1.Name = "Dgv1";
            Dgv1.RowHeadersWidth = 51;
            Dgv1.Size = new Size(628, 141);
            Dgv1.TabIndex = 9;
            Dgv1.CellContentClick += Dgv1_CellContentClick;
            // 
            // TxtNombreEntrenador
            // 
            TxtNombreEntrenador.Location = new Point(136, 49);
            TxtNombreEntrenador.Margin = new Padding(3, 2, 3, 2);
            TxtNombreEntrenador.Name = "TxtNombreEntrenador";
            TxtNombreEntrenador.Size = new Size(236, 23);
            TxtNombreEntrenador.TabIndex = 10;
            // 
            // TxtApellidoEntrenador
            // 
            TxtApellidoEntrenador.Location = new Point(136, 73);
            TxtApellidoEntrenador.Margin = new Padding(3, 2, 3, 2);
            TxtApellidoEntrenador.Name = "TxtApellidoEntrenador";
            TxtApellidoEntrenador.Size = new Size(236, 23);
            TxtApellidoEntrenador.TabIndex = 11;
            // 
            // TxtTelefonoEntrenador
            // 
            TxtTelefonoEntrenador.Location = new Point(136, 99);
            TxtTelefonoEntrenador.Margin = new Padding(3, 2, 3, 2);
            TxtTelefonoEntrenador.Name = "TxtTelefonoEntrenador";
            TxtTelefonoEntrenador.Size = new Size(236, 23);
            TxtTelefonoEntrenador.TabIndex = 12;
            // 
            // TxtCorreoEntrenador
            // 
            TxtCorreoEntrenador.Location = new Point(136, 124);
            TxtCorreoEntrenador.Margin = new Padding(3, 2, 3, 2);
            TxtCorreoEntrenador.Name = "TxtCorreoEntrenador";
            TxtCorreoEntrenador.Size = new Size(236, 23);
            TxtCorreoEntrenador.TabIndex = 13;
            // 
            // FrmEntrenadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(TxtCorreoEntrenador);
            Controls.Add(TxtTelefonoEntrenador);
            Controls.Add(TxtApellidoEntrenador);
            Controls.Add(TxtNombreEntrenador);
            Controls.Add(Dgv1);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(Lbl5);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEntrenadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrenadores";
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private Label Lbl5;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnNuevo;
        private DataGridView Dgv1;
        private TextBox TxtNombreEntrenador;
        private TextBox TxtApellidoEntrenador;
        private TextBox TxtTelefonoEntrenador;
        private TextBox TxtCorreoEntrenador;
    }
}