namespace SistemaDePolideportivo
{
    partial class FrmEquipos
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
            TxtNombreEquipo = new TextBox();
            TxtLogo = new TextBox();
            CmbEntrenador = new ComboBox();
            ChkEstado = new CheckBox();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            Dgv1 = new DataGridView();
            Lbl5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AllowDrop = true;
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(29, 44);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(110, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Nombre del equipo";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(29, 69);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(34, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Logo";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(29, 94);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(65, 15);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Entrenador";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Location = new Point(29, 120);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(42, 15);
            Lbl4.TabIndex = 3;
            Lbl4.Text = "Estado";
            // 
            // TxtNombreEquipo
            // 
            TxtNombreEquipo.Location = new Point(156, 42);
            TxtNombreEquipo.Margin = new Padding(3, 2, 3, 2);
            TxtNombreEquipo.Name = "TxtNombreEquipo";
            TxtNombreEquipo.Size = new Size(222, 23);
            TxtNombreEquipo.TabIndex = 4;
            // 
            // TxtLogo
            // 
            TxtLogo.Location = new Point(156, 67);
            TxtLogo.Margin = new Padding(3, 2, 3, 2);
            TxtLogo.Name = "TxtLogo";
            TxtLogo.Size = new Size(65, 23);
            TxtLogo.TabIndex = 5;
            // 
            // CmbEntrenador
            // 
            CmbEntrenador.FormattingEnabled = true;
            CmbEntrenador.Location = new Point(156, 93);
            CmbEntrenador.Margin = new Padding(3, 2, 3, 2);
            CmbEntrenador.Name = "CmbEntrenador";
            CmbEntrenador.Size = new Size(148, 23);
            CmbEntrenador.TabIndex = 6;
            // 
            // ChkEstado
            // 
            ChkEstado.AutoSize = true;
            ChkEstado.Location = new Point(157, 119);
            ChkEstado.Margin = new Padding(3, 2, 3, 2);
            ChkEstado.Name = "ChkEstado";
            ChkEstado.Size = new Size(60, 19);
            ChkEstado.TabIndex = 7;
            ChkEstado.Text = "Activo";
            ChkEstado.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.AutoEllipsis = true;
            BtnGuardar.BackColor = Color.White;
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(467, 30);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(52, 44);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.White;
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(467, 93);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(52, 44);
            BtnEditar.TabIndex = 9;
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.White;
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(565, 30);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(52, 44);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.White;
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(565, 94);
            BtnNuevo.Margin = new Padding(3, 2, 3, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(52, 44);
            BtnNuevo.TabIndex = 11;
            BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // Dgv1
            // 
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(29, 188);
            Dgv1.Margin = new Padding(3, 2, 3, 2);
            Dgv1.Name = "Dgv1";
            Dgv1.RowHeadersWidth = 51;
            Dgv1.Size = new Size(643, 141);
            Dgv1.TabIndex = 12;
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Location = new Point(29, 15);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(49, 15);
            Lbl5.TabIndex = 13;
            Lbl5.Text = "Equipos";
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 385);
            Controls.Add(Lbl5);
            Controls.Add(Dgv1);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(ChkEstado);
            Controls.Add(CmbEntrenador);
            Controls.Add(TxtLogo);
            Controls.Add(TxtNombreEquipo);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private TextBox TxtNombreEquipo;
        private TextBox TxtLogo;
        private ComboBox CmbEntrenador;
        private CheckBox ChkEstado;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnNuevo;
        private DataGridView Dgv1;
        private Label Lbl5;
    }
}