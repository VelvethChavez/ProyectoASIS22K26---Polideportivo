namespace SistemaDePolideportivo
{
    partial class FrmArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArbitro));
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            Lbl5 = new Label();
            TxtNombres = new TextBox();
            TxtTelefono = new TextBox();
            TxtApellidos = new TextBox();
            DgvArbitros = new DataGridView();
            Lbl6 = new Label();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnRegresarMenuCompeticiones = new Button();
            CmbDeporte = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvArbitros).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(21, 91);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(97, 28);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Nombres:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(21, 24);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(194, 31);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Datos del Arbitro:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(21, 141);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(98, 28);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Apellidos:";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(21, 181);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(90, 28);
            Lbl4.TabIndex = 3;
            Lbl4.Text = "Telefono:";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl5.Location = new Point(23, 229);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(88, 28);
            Lbl5.TabIndex = 4;
            Lbl5.Text = "Deporte:";
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(123, 93);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(249, 27);
            TxtNombres.TabIndex = 5;
            TxtNombres.Text = "Juan";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(125, 185);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(249, 27);
            TxtTelefono.TabIndex = 7;
            TxtTelefono.Text = "12345678";
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(125, 145);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(249, 27);
            TxtApellidos.TabIndex = 8;
            TxtApellidos.Text = "Hernandez";
            // 
            // DgvArbitros
            // 
            DgvArbitros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvArbitros.Location = new Point(391, 93);
            DgvArbitros.Name = "DgvArbitros";
            DgvArbitros.RowHeadersWidth = 51;
            DgvArbitros.Size = new Size(389, 195);
            DgvArbitros.TabIndex = 9;
            DgvArbitros.CellContentClick += DgvArbitros_CellContentClick;
            // 
            // Lbl6
            // 
            Lbl6.AutoSize = true;
            Lbl6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl6.Location = new Point(391, 43);
            Lbl6.Name = "Lbl6";
            Lbl6.Size = new Size(213, 31);
            Lbl6.TabIndex = 10;
            Lbl6.Text = "Listado de Arbitros:";
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(318, 355);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 63);
            BtnNuevo.TabIndex = 30;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(222, 355);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 63);
            BtnEliminar.TabIndex = 29;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(123, 355);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 28;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click_1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            BtnGuardar.ImageAlign = ContentAlignment.TopCenter;
            BtnGuardar.Location = new Point(23, 355);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 27;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // BtnRegresarMenuCompeticiones
            // 
            BtnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("BtnRegresarMenuCompeticiones.BackgroundImage");
            BtnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            BtnRegresarMenuCompeticiones.Location = new Point(722, 15);
            BtnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            BtnRegresarMenuCompeticiones.Name = "BtnRegresarMenuCompeticiones";
            BtnRegresarMenuCompeticiones.Size = new Size(57, 59);
            BtnRegresarMenuCompeticiones.TabIndex = 31;
            BtnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            BtnRegresarMenuCompeticiones.Click += BtnRegresarMenuCompeticiones_Click;
            // 
            // CmbDeporte
            // 
            CmbDeporte.FormattingEnabled = true;
            CmbDeporte.Location = new Point(123, 233);
            CmbDeporte.Name = "CmbDeporte";
            CmbDeporte.Size = new Size(251, 28);
            CmbDeporte.TabIndex = 32;
            // 
            // FrmArbitro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(CmbDeporte);
            Controls.Add(BtnRegresarMenuCompeticiones);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(Lbl6);
            Controls.Add(DgvArbitros);
            Controls.Add(TxtApellidos);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtNombres);
            Controls.Add(Lbl5);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmArbitro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmArbitro";
            Load += FrmArbitro_Load_1;
            ((System.ComponentModel.ISupportInitialize)DgvArbitros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private Label Lbl5;
        private TextBox TxtNombres;
        private TextBox TxtTelefono;
        private TextBox TxtApellidos;
        private DataGridView DgvArbitros;
        private Label Lbl6;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnRegresarMenuCompeticiones;
        private ComboBox CmbDeporte;
    }
}