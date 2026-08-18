namespace SistemaDePolideportivo
{
    partial class FrmJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJornada));
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            Lbl5 = new Label();
            DtpFechaJornada = new DateTimePicker();
            DgvJornadas = new DataGridView();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnRegresarMenuCompeticiones = new Button();
            CmbComboBoxCampeonato = new ComboBox();
            TxtNombreJornada = new TextBox();
            NudNumNumeroJornada = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DgvJornadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudNumNumeroJornada).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(11, 43);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(180, 38);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Campeonato:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(11, 104);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(220, 31);
            Lbl2.TabIndex = 2;
            Lbl2.Text = "Datos de la Jornada:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(11, 197);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(209, 28);
            Lbl3.TabIndex = 3;
            Lbl3.Text = "Numero de la Jornada:";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(11, 149);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(210, 28);
            Lbl4.TabIndex = 4;
            Lbl4.Text = "Nombre de la Jornada:";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl5.Location = new Point(13, 243);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(187, 28);
            Lbl5.TabIndex = 5;
            Lbl5.Text = "Fecha de la Jornada:";
            // 
            // DtpFechaJornada
            // 
            DtpFechaJornada.Location = new Point(227, 245);
            DtpFechaJornada.Name = "DtpFechaJornada";
            DtpFechaJornada.Size = new Size(277, 27);
            DtpFechaJornada.TabIndex = 8;
            // 
            // DgvJornadas
            // 
            DgvJornadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvJornadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvJornadas.Location = new Point(13, 277);
            DgvJornadas.Name = "DgvJornadas";
            DgvJornadas.RowHeadersWidth = 51;
            DgvJornadas.Size = new Size(775, 160);
            DgvJornadas.TabIndex = 9;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(709, 93);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 63);
            BtnNuevo.TabIndex = 34;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(613, 93);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 63);
            BtnEliminar.TabIndex = 33;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(709, 185);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 32;
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
            BtnGuardar.Location = new Point(608, 181);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 31;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnRegresarMenuCompeticiones
            // 
            BtnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("BtnRegresarMenuCompeticiones.BackgroundImage");
            BtnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            BtnRegresarMenuCompeticiones.Location = new Point(709, 16);
            BtnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            BtnRegresarMenuCompeticiones.Name = "BtnRegresarMenuCompeticiones";
            BtnRegresarMenuCompeticiones.Size = new Size(66, 63);
            BtnRegresarMenuCompeticiones.TabIndex = 35;
            BtnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            BtnRegresarMenuCompeticiones.Click += BtnRegresarMenuCompeticiones_Click;
            // 
            // CmbComboBoxCampeonato
            // 
            CmbComboBoxCampeonato.FormattingEnabled = true;
            CmbComboBoxCampeonato.Location = new Point(227, 53);
            CmbComboBoxCampeonato.Name = "CmbComboBoxCampeonato";
            CmbComboBoxCampeonato.Size = new Size(185, 28);
            CmbComboBoxCampeonato.TabIndex = 36;
            CmbComboBoxCampeonato.SelectedIndexChanged += CmbComboBoxCampeonato_SelectedIndexChanged;
            // 
            // TxtNombreJornada
            // 
            TxtNombreJornada.Location = new Point(228, 153);
            TxtNombreJornada.Name = "TxtNombreJornada";
            TxtNombreJornada.Size = new Size(184, 27);
            TxtNombreJornada.TabIndex = 39;
            // 
            // NudNumNumeroJornada
            // 
            NudNumNumeroJornada.Location = new Point(228, 202);
            NudNumNumeroJornada.Name = "NudNumNumeroJornada";
            NudNumNumeroJornada.Size = new Size(184, 27);
            NudNumNumeroJornada.TabIndex = 40;
            // 
            // FrmJornada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(NudNumNumeroJornada);
            Controls.Add(TxtNombreJornada);
            Controls.Add(CmbComboBoxCampeonato);
            Controls.Add(BtnRegresarMenuCompeticiones);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(DgvJornadas);
            Controls.Add(DtpFechaJornada);
            Controls.Add(Lbl5);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CJornada";
            Load += FrmJornada_Load;
            ((System.ComponentModel.ISupportInitialize)DgvJornadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudNumNumeroJornada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private Label Lbl5;
        private DateTimePicker DtpFechaJornada;
        private DataGridView DgvJornadas;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnRegresarMenuCompeticiones;
        private ComboBox CmbComboBoxCampeonato;
        private TextBox TxtNombreJornada;
        private NumericUpDown NudNumNumeroJornada;
    }
}