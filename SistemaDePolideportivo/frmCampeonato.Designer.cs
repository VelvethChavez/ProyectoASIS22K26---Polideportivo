namespace SistemaDePolideportivo
{
    partial class FrmCampeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCampeonato));
            Pnl1 = new Panel();
            BtnMenu = new Button();
            BtnEstados = new Button();
            BtnTipoCampeonato = new Button();
            BtnDeportes = new Button();
            Dgv1 = new DataGridView();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            Lbl8 = new Label();
            Lbl7 = new Label();
            Cmb2 = new ComboBox();
            CmbComboBoxtipoCampeonato = new ComboBox();
            CmbComboBoxDeporte = new ComboBox();
            Lbl6 = new Label();
            Dtp1 = new DateTimePicker();
            Lbl5 = new Label();
            DtpDateInicio = new DateTimePicker();
            Lbl4 = new Label();
            Txt1 = new TextBox();
            Lbl3 = new Label();
            Lbl2 = new Label();
            Lbl1 = new Label();
            Pic1 = new PictureBox();
            SqlCmd1 = new MySql.Data.MySqlClient.MySqlCommand();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            SuspendLayout();
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(BtnMenu);
            Pnl1.Controls.Add(BtnEstados);
            Pnl1.Controls.Add(BtnTipoCampeonato);
            Pnl1.Controls.Add(BtnDeportes);
            Pnl1.Controls.Add(Dgv1);
            Pnl1.Controls.Add(BtnEliminar);
            Pnl1.Controls.Add(BtnEditar);
            Pnl1.Controls.Add(BtnNuevo);
            Pnl1.Controls.Add(BtnGuardar);
            Pnl1.Controls.Add(Lbl8);
            Pnl1.Controls.Add(Lbl7);
            Pnl1.Controls.Add(Cmb2);
            Pnl1.Controls.Add(CmbComboBoxtipoCampeonato);
            Pnl1.Controls.Add(CmbComboBoxDeporte);
            Pnl1.Controls.Add(Lbl6);
            Pnl1.Controls.Add(Dtp1);
            Pnl1.Controls.Add(Lbl5);
            Pnl1.Controls.Add(DtpDateInicio);
            Pnl1.Controls.Add(Lbl4);
            Pnl1.Controls.Add(Txt1);
            Pnl1.Controls.Add(Lbl3);
            Pnl1.Controls.Add(Lbl2);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Controls.Add(Pic1);
            Pnl1.Location = new Point(-3, -4);
            Pnl1.Margin = new Padding(3, 4, 3, 4);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(739, 737);
            Pnl1.TabIndex = 0;
            Pnl1.Paint += Pnl1_Paint;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(525, 96);
            BtnMenu.Margin = new Padding(3, 4, 3, 4);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(66, 63);
            BtnMenu.TabIndex = 23;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // BtnEstados
            // 
            BtnEstados.BackColor = Color.FromArgb(255, 128, 128);
            BtnEstados.Cursor = Cursors.Hand;
            BtnEstados.FlatStyle = FlatStyle.Flat;
            BtnEstados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnEstados.ForeColor = Color.White;
            BtnEstados.Location = new Point(447, 28);
            BtnEstados.Margin = new Padding(3, 4, 3, 4);
            BtnEstados.Name = "BtnEstados";
            BtnEstados.Size = new Size(86, 39);
            BtnEstados.TabIndex = 22;
            BtnEstados.Text = "Estados";
            BtnEstados.UseVisualStyleBackColor = false;
            BtnEstados.Click += BtnEstados_Click;
            // 
            // BtnTipoCampeonato
            // 
            BtnTipoCampeonato.BackColor = Color.RoyalBlue;
            BtnTipoCampeonato.Cursor = Cursors.Hand;
            BtnTipoCampeonato.FlatStyle = FlatStyle.Flat;
            BtnTipoCampeonato.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTipoCampeonato.ForeColor = SystemColors.Info;
            BtnTipoCampeonato.Location = new Point(539, 28);
            BtnTipoCampeonato.Margin = new Padding(3, 4, 3, 4);
            BtnTipoCampeonato.Name = "BtnTipoCampeonato";
            BtnTipoCampeonato.Size = new Size(184, 39);
            BtnTipoCampeonato.TabIndex = 21;
            BtnTipoCampeonato.Text = "Tipo de Campeonato";
            BtnTipoCampeonato.UseVisualStyleBackColor = false;
            BtnTipoCampeonato.Click += BtnTipoCampeonato_Click;
            // 
            // BtnDeportes
            // 
            BtnDeportes.BackColor = Color.ForestGreen;
            BtnDeportes.Cursor = Cursors.Hand;
            BtnDeportes.FlatStyle = FlatStyle.Flat;
            BtnDeportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeportes.ForeColor = SystemColors.Info;
            BtnDeportes.Location = new Point(327, 28);
            BtnDeportes.Margin = new Padding(3, 4, 3, 4);
            BtnDeportes.Name = "BtnDeportes";
            BtnDeportes.Size = new Size(107, 39);
            BtnDeportes.TabIndex = 20;
            BtnDeportes.Text = "Deportes";
            BtnDeportes.UseVisualStyleBackColor = false;
            BtnDeportes.Click += BtnDeportes_Click;
            // 
            // Dgv1
            // 
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(48, 461);
            Dgv1.Margin = new Padding(3, 4, 3, 4);
            Dgv1.Name = "Dgv1";
            Dgv1.RowHeadersWidth = 51;
            Dgv1.Size = new Size(629, 231);
            Dgv1.TabIndex = 19;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.limpiar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(610, 265);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 67);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(610, 183);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 67);
            BtnEditar.TabIndex = 17;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(610, 347);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 67);
            BtnNuevo.TabIndex = 16;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(610, 96);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // Lbl8
            // 
            Lbl8.AutoSize = true;
            Lbl8.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl8.Location = new Point(327, 349);
            Lbl8.Name = "Lbl8";
            Lbl8.Size = new Size(220, 24);
            Lbl8.TabIndex = 14;
            Lbl8.Text = "Estado del campeonato:";
            Lbl8.Click += Lbl8_Click;
            // 
            // Lbl7
            // 
            Lbl7.AutoSize = true;
            Lbl7.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl7.Location = new Point(327, 256);
            Lbl7.Name = "Lbl7";
            Lbl7.Size = new Size(196, 24);
            Lbl7.TabIndex = 13;
            Lbl7.Text = "Tipo de campeonato:";
            Lbl7.Click += Lbl7_Click;
            // 
            // Cmb2
            // 
            Cmb2.Font = new Font("Bell MT", 9F);
            Cmb2.FormattingEnabled = true;
            Cmb2.Location = new Point(327, 379);
            Cmb2.Margin = new Padding(3, 4, 3, 4);
            Cmb2.Name = "Cmb2";
            Cmb2.Size = new Size(191, 27);
            Cmb2.TabIndex = 12;
            Cmb2.Text = "Seleccione un estado";
            Cmb2.SelectedIndexChanged += Cmb2_SelectedIndexChanged;
            // 
            // CmbComboBoxtipoCampeonato
            // 
            CmbComboBoxtipoCampeonato.Font = new Font("Bell MT", 9F);
            CmbComboBoxtipoCampeonato.FormattingEnabled = true;
            CmbComboBoxtipoCampeonato.Location = new Point(327, 285);
            CmbComboBoxtipoCampeonato.Margin = new Padding(3, 4, 3, 4);
            CmbComboBoxtipoCampeonato.Name = "CmbComboBoxtipoCampeonato";
            CmbComboBoxtipoCampeonato.Size = new Size(191, 27);
            CmbComboBoxtipoCampeonato.TabIndex = 11;
            CmbComboBoxtipoCampeonato.Text = "Seleccione un tipo";
            CmbComboBoxtipoCampeonato.SelectedIndexChanged += CmbComboBoxtipoCampeonato_SelectedIndexChanged;
            // 
            // CmbComboBoxDeporte
            // 
            CmbComboBoxDeporte.Font = new Font("Bell MT", 9F);
            CmbComboBoxDeporte.FormattingEnabled = true;
            CmbComboBoxDeporte.Location = new Point(327, 195);
            CmbComboBoxDeporte.Margin = new Padding(3, 4, 3, 4);
            CmbComboBoxDeporte.Name = "CmbComboBoxDeporte";
            CmbComboBoxDeporte.Size = new Size(191, 27);
            CmbComboBoxDeporte.TabIndex = 10;
            CmbComboBoxDeporte.Text = "Seleccione un deporte";
            // 
            // Lbl6
            // 
            Lbl6.AutoSize = true;
            Lbl6.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl6.Location = new Point(327, 165);
            Lbl6.Name = "Lbl6";
            Lbl6.Size = new Size(94, 24);
            Lbl6.TabIndex = 9;
            Lbl6.Text = "Deporte: ";
            // 
            // Dtp1
            // 
            Dtp1.Font = new Font("Bell MT", 9F);
            Dtp1.Format = DateTimePickerFormat.Custom;
            Dtp1.Location = new Point(24, 381);
            Dtp1.Margin = new Padding(3, 4, 3, 4);
            Dtp1.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            Dtp1.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            Dtp1.Name = "Dtp1";
            Dtp1.Size = new Size(107, 24);
            Dtp1.TabIndex = 8;
            Dtp1.ValueChanged += Dtp1_ValueChanged;
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl5.Location = new Point(19, 352);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(112, 24);
            Lbl5.TabIndex = 7;
            Lbl5.Text = "Fecha final:";
            Lbl5.Click += Lbl5_Click;
            // 
            // DtpDateInicio
            // 
            DtpDateInicio.Font = new Font("Bell MT", 9F);
            DtpDateInicio.Format = DateTimePickerFormat.Custom;
            DtpDateInicio.Location = new Point(24, 285);
            DtpDateInicio.Margin = new Padding(3, 4, 3, 4);
            DtpDateInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            DtpDateInicio.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            DtpDateInicio.Name = "DtpDateInicio";
            DtpDateInicio.Size = new Size(111, 24);
            DtpDateInicio.TabIndex = 6;
            DtpDateInicio.ValueChanged += DtpDateInicio_ValueChanged;
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl4.Location = new Point(19, 256);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(147, 24);
            Lbl4.TabIndex = 5;
            Lbl4.Text = "Fecha de inicio:";
            Lbl4.Click += Lbl4_Click;
            // 
            // Txt1
            // 
            Txt1.Font = new Font("Bell MT", 9F);
            Txt1.Location = new Point(24, 195);
            Txt1.Margin = new Padding(3, 4, 3, 4);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(213, 24);
            Txt1.TabIndex = 4;
            Txt1.Text = "Ingrese nombre del campeonato";
            Txt1.TextChanged += Txt1_TextChanged;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl3.Location = new Point(19, 165);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(230, 24);
            Lbl3.TabIndex = 3;
            Lbl3.Text = "Nombre del campeonato:\r\n";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl2.Location = new Point(17, 113);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(207, 24);
            Lbl2.TabIndex = 2;
            Lbl2.Text = "Datos del campeonato";
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F);
            Lbl1.Location = new Point(77, 28);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(157, 41);
            Lbl1.TabIndex = 1;
            Lbl1.Text = "Campeonato";
            Lbl1.TextAlign = ContentAlignment.MiddleLeft;
            Lbl1.Click += Lbl1_Click;
            // 
            // Pic1
            // 
            Pic1.Image = (Image)resources.GetObject("Pic1.Image");
            Pic1.Location = new Point(24, 28);
            Pic1.Margin = new Padding(3, 4, 3, 4);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(46, 52);
            Pic1.SizeMode = PictureBoxSizeMode.Zoom;
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            // 
            // SqlCmd1
            // 
            SqlCmd1.CacheAge = 0;
            SqlCmd1.Connection = null;
            SqlCmd1.EnableCaching = false;
            SqlCmd1.Transaction = null;
            // 
            // FrmCampeonato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 731);
            Controls.Add(Pnl1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCampeonato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campeonato";
            Load += FrmCampeonato_Load;
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl1;
        private PictureBox Pic1;
        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private TextBox Txt1;
        private Label Lbl4;
        private Label Lbl5;
        private DateTimePicker DtpDateInicio;
        private DateTimePicker Dtp1;
        private ComboBox CmbComboBoxDeporte;
        private Label Lbl6;
        private Label Lbl7;
        private ComboBox Cmb2;
        private ComboBox CmbComboBoxtipoCampeonato;
        private Label Lbl8;
        private MySql.Data.MySqlClient.MySqlCommand SqlCmd1;
        private Button BtnGuardar;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView Dgv1;
        private Button BtnDeportes;
        private Button BtnTipoCampeonato;
        private Button BtnEstados;
        private Button BtnMenu;
    }
}