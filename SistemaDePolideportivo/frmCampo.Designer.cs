namespace SistemaDePolideportivo
{
    partial class FrmCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCampo));
            Lbl1 = new Label();
            Lbl2 = new Label();
            TxtNombreCampo = new TextBox();
            Lbl3 = new Label();
            Lbl4 = new Label();
            TxtCapacidad = new TextBox();
            Lbl5 = new Label();
            DgvCampos = new DataGridView();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnMenu = new Button();
            CmbTipoCampo = new ComboBox();
            TxtUbicacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvCampos).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(192, 16);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(432, 41);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Gestión de Campos Deportivos";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(11, 63);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(214, 31);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Nombre de Campo:";
            // 
            // TxtNombreCampo
            // 
            TxtNombreCampo.Location = new Point(232, 69);
            TxtNombreCampo.Name = "TxtNombreCampo";
            TxtNombreCampo.Size = new Size(283, 27);
            TxtNombreCampo.TabIndex = 2;
            TxtNombreCampo.Text = "Cementos Progreso";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(11, 113);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(121, 31);
            Lbl3.TabIndex = 3;
            Lbl3.Text = "Ubicacion:";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(11, 168);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(128, 31);
            Lbl4.TabIndex = 5;
            Lbl4.Text = "Capacidad:";
            // 
            // TxtCapacidad
            // 
            TxtCapacidad.Location = new Point(232, 172);
            TxtCapacidad.Name = "TxtCapacidad";
            TxtCapacidad.Size = new Size(283, 27);
            TxtCapacidad.TabIndex = 6;
            TxtCapacidad.Text = "100";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl5.Location = new Point(11, 211);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(175, 31);
            Lbl5.TabIndex = 7;
            Lbl5.Text = "Tipo de Campo:";
            // 
            // DgvCampos
            // 
            DgvCampos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCampos.Location = new Point(42, 269);
            DgvCampos.Name = "DgvCampos";
            DgvCampos.RowHeadersWidth = 51;
            DgvCampos.Size = new Size(674, 168);
            DgvCampos.TabIndex = 10;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(722, 248);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 63);
            BtnNuevo.TabIndex = 26;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(722, 165);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 63);
            BtnEliminar.TabIndex = 25;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(722, 92);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 24;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
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
            BtnGuardar.Location = new Point(722, 11);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 23;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(14, 4);
            BtnMenu.Margin = new Padding(3, 4, 3, 4);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(47, 55);
            BtnMenu.TabIndex = 27;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // CmbTipoCampo
            // 
            CmbTipoCampo.FormattingEnabled = true;
            CmbTipoCampo.Location = new Point(232, 226);
            CmbTipoCampo.Name = "CmbTipoCampo";
            CmbTipoCampo.Size = new Size(283, 28);
            CmbTipoCampo.TabIndex = 28;
            CmbTipoCampo.Text = "Cancha Sintentica";
            // 
            // TxtUbicacion
            // 
            TxtUbicacion.Location = new Point(232, 119);
            TxtUbicacion.Name = "TxtUbicacion";
            TxtUbicacion.Size = new Size(283, 27);
            TxtUbicacion.TabIndex = 29;
            TxtUbicacion.Text = "Cancha 1";
            // 
            // FrmCampo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            Controls.Add(TxtUbicacion);
            Controls.Add(CmbTipoCampo);
            Controls.Add(BtnMenu);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(DgvCampos);
            Controls.Add(Lbl5);
            Controls.Add(TxtCapacidad);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(TxtNombreCampo);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCampo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCampo";
            Load += FrmCampo_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCampos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private TextBox TxtNombreCampo;
        private Label Lbl3;
        private Label Lbl4;
        private TextBox TxtCapacidad;
        private Label Lbl5;
        private DataGridView DgvCampos;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnMenu;
        private ComboBox CmbTipoCampo;
        private TextBox TxtUbicacion;
    }
}