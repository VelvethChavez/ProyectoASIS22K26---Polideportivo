namespace SistemaDePolideportivo
{
    partial class FrmReportes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Lbl1 = new Label();
            Lbl2 = new Label();
            CmbReportes = new ComboBox();
            BtnActualizar = new Button();
            BtnExportarPDF = new Button();
            LblCampeonato = new Label();
            CmbCampeonato = new ComboBox();
            LblEstado = new Label();
            CmbEstado = new ComboBox();
            BtnFiltrar = new Button();
            LblDesde = new Label();
            DtpDesde = new DateTimePicker();
            LblHasta = new Label();
            DtpHasta = new DateTimePicker();
            ChkFiltrarFecha = new CheckBox();
            LblBuscar = new Label();
            TxtBuscar = new TextBox();
            Dgv1 = new DataGridView();
            LblResultados = new Label();
            Pnl1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            Pnl1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.BackColor = Color.Transparent;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.ForeColor = Color.Black;
            Lbl1.Location = new Point(15, 13);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(94, 33);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "FrmReportes";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.BackColor = Color.Transparent;
            Lbl2.Font = new Font("Bell MT", 11F, FontStyle.Bold);
            Lbl2.ForeColor = Color.Black;
            Lbl2.Location = new Point(15, 65);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(132, 19);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Seleccione reporte:";
            // 
            // CmbReportes
            // 
            CmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbReportes.Font = new Font("Bell MT", 9.5F);
            CmbReportes.FormattingEnabled = true;
            CmbReportes.Location = new Point(150, 62);
            CmbReportes.Name = "CmbReportes";
            CmbReportes.Size = new Size(250, 23);
            CmbReportes.TabIndex = 2;
            CmbReportes.SelectedIndexChanged += CmbReportes_SelectedIndexChanged;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Cursor = Cursors.Hand;
            BtnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnActualizar.Location = new Point(415, 61);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(95, 27);
            BtnActualizar.TabIndex = 3;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnExportarPDF
            // 
            BtnExportarPDF.BackColor = Color.IndianRed;
            BtnExportarPDF.Cursor = Cursors.Hand;
            BtnExportarPDF.FlatStyle = FlatStyle.Flat;
            BtnExportarPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnExportarPDF.ForeColor = Color.White;
            BtnExportarPDF.Location = new Point(520, 61);
            BtnExportarPDF.Name = "BtnExportarPDF";
            BtnExportarPDF.Size = new Size(130, 27);
            BtnExportarPDF.TabIndex = 4;
            BtnExportarPDF.Text = "Exportar a PDF";
            BtnExportarPDF.UseVisualStyleBackColor = false;
            BtnExportarPDF.Click += BtnExportarPDF_Click;
            // 
            // LblCampeonato
            // 
            LblCampeonato.AutoSize = true;
            LblCampeonato.BackColor = Color.Transparent;
            LblCampeonato.Font = new Font("Segoe UI", 8.5F);
            LblCampeonato.ForeColor = Color.Black;
            LblCampeonato.Location = new Point(15, 100);
            LblCampeonato.Name = "LblCampeonato";
            LblCampeonato.Size = new Size(79, 15);
            LblCampeonato.TabIndex = 8;
            LblCampeonato.Text = "Campeonato:";
            LblCampeonato.Visible = false;
            // 
            // CmbCampeonato
            // 
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCampeonato.Font = new Font("Segoe UI", 8.5F);
            CmbCampeonato.FormattingEnabled = true;
            CmbCampeonato.Location = new Point(95, 97);
            CmbCampeonato.Name = "CmbCampeonato";
            CmbCampeonato.Size = new Size(190, 21);
            CmbCampeonato.TabIndex = 9;
            CmbCampeonato.Visible = false;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.BackColor = Color.Transparent;
            LblEstado.Font = new Font("Segoe UI", 8.5F);
            LblEstado.ForeColor = Color.Black;
            LblEstado.Location = new Point(300, 100);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(45, 15);
            LblEstado.TabIndex = 10;
            LblEstado.Text = "Estado:";
            LblEstado.Visible = false;
            // 
            // CmbEstado
            // 
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEstado.Font = new Font("Segoe UI", 8.5F);
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(348, 97);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(130, 21);
            CmbEstado.TabIndex = 11;
            CmbEstado.Visible = false;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.BackColor = Color.SteelBlue;
            BtnFiltrar.Cursor = Cursors.Hand;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            BtnFiltrar.ForeColor = Color.White;
            BtnFiltrar.Location = new Point(650, 96);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(125, 26);
            BtnFiltrar.TabIndex = 12;
            BtnFiltrar.Text = "Aplicar filtros";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // LblDesde
            // 
            LblDesde.AutoSize = true;
            LblDesde.BackColor = Color.Transparent;
            LblDesde.Font = new Font("Segoe UI", 8.5F);
            LblDesde.ForeColor = Color.Black;
            LblDesde.Location = new Point(15, 132);
            LblDesde.Name = "LblDesde";
            LblDesde.Size = new Size(42, 15);
            LblDesde.TabIndex = 13;
            LblDesde.Text = "Desde:";
            LblDesde.Visible = false;
            // 
            // DtpDesde
            // 
            DtpDesde.Font = new Font("Segoe UI", 8.5F);
            DtpDesde.Format = DateTimePickerFormat.Short;
            DtpDesde.Location = new Point(95, 128);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(110, 23);
            DtpDesde.TabIndex = 14;
            DtpDesde.Visible = false;
            // 
            // LblHasta
            // 
            LblHasta.AutoSize = true;
            LblHasta.BackColor = Color.Transparent;
            LblHasta.Font = new Font("Segoe UI", 8.5F);
            LblHasta.ForeColor = Color.Black;
            LblHasta.Location = new Point(220, 132);
            LblHasta.Name = "LblHasta";
            LblHasta.Size = new Size(40, 15);
            LblHasta.TabIndex = 15;
            LblHasta.Text = "Hasta:";
            LblHasta.Visible = false;
            // 
            // DtpHasta
            // 
            DtpHasta.Font = new Font("Segoe UI", 8.5F);
            DtpHasta.Format = DateTimePickerFormat.Short;
            DtpHasta.Location = new Point(295, 128);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(110, 23);
            DtpHasta.TabIndex = 16;
            DtpHasta.Visible = false;
            // 
            // ChkFiltrarFecha
            // 
            ChkFiltrarFecha.AutoSize = true;
            ChkFiltrarFecha.BackColor = Color.Transparent;
            ChkFiltrarFecha.Font = new Font("Segoe UI", 8.5F);
            ChkFiltrarFecha.ForeColor = Color.Black;
            ChkFiltrarFecha.Location = new Point(420, 130);
            ChkFiltrarFecha.Name = "ChkFiltrarFecha";
            ChkFiltrarFecha.Size = new Size(109, 19);
            ChkFiltrarFecha.TabIndex = 17;
            ChkFiltrarFecha.Text = "Filtrar por fecha";
            ChkFiltrarFecha.UseVisualStyleBackColor = false;
            ChkFiltrarFecha.Visible = false;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.BackColor = Color.Transparent;
            LblBuscar.Font = new Font("Segoe UI", 8.5F);
            LblBuscar.ForeColor = Color.Black;
            LblBuscar.Location = new Point(15, 163);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(45, 15);
            LblBuscar.TabIndex = 18;
            LblBuscar.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            TxtBuscar.Font = new Font("Segoe UI", 8.5F);
            TxtBuscar.Location = new Point(95, 159);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "Escribe para filtrar la tabla...";
            TxtBuscar.Size = new Size(300, 23);
            TxtBuscar.TabIndex = 19;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // Dgv1
            // 
            Dgv1.AllowUserToAddRows = false;
            Dgv1.AllowUserToResizeRows = false;
            Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(15, 195);
            Dgv1.MultiSelect = false;
            Dgv1.Name = "Dgv1";
            Dgv1.ReadOnly = true;
            Dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv1.Size = new Size(760, 380);
            Dgv1.TabIndex = 5;
            Dgv1.CellContentClick += Dgv1_CellContentClick;
            // 
            // LblResultados
            // 
            LblResultados.AutoSize = true;
            LblResultados.BackColor = Color.Transparent;
            LblResultados.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            LblResultados.ForeColor = Color.DimGray;
            LblResultados.Location = new Point(15, 580);
            LblResultados.Name = "LblResultados";
            LblResultados.Size = new Size(78, 15);
            LblResultados.TabIndex = 6;
            LblResultados.Text = "0 resultado(s)";
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(LblResultados);
            Pnl1.Controls.Add(Dgv1);
            Pnl1.Controls.Add(TxtBuscar);
            Pnl1.Controls.Add(LblBuscar);
            Pnl1.Controls.Add(ChkFiltrarFecha);
            Pnl1.Controls.Add(DtpHasta);
            Pnl1.Controls.Add(LblHasta);
            Pnl1.Controls.Add(DtpDesde);
            Pnl1.Controls.Add(LblDesde);
            Pnl1.Controls.Add(BtnFiltrar);
            Pnl1.Controls.Add(CmbEstado);
            Pnl1.Controls.Add(LblEstado);
            Pnl1.Controls.Add(CmbCampeonato);
            Pnl1.Controls.Add(LblCampeonato);
            Pnl1.Controls.Add(BtnExportarPDF);
            Pnl1.Controls.Add(BtnActualizar);
            Pnl1.Controls.Add(CmbReportes);
            Pnl1.Controls.Add(Lbl2);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Location = new Point(0, 0);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(790, 610);
            Pnl1.TabIndex = 7;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 610);
            Controls.Add(Pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(700, 595);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private ComboBox CmbReportes;
        private Button BtnActualizar;
        private Button BtnExportarPDF;
        private Label LblCampeonato;
        private ComboBox CmbCampeonato;
        private Label LblEstado;
        private ComboBox CmbEstado;
        private Button BtnFiltrar;
        private Label LblDesde;
        private DateTimePicker DtpDesde;
        private Label LblHasta;
        private DateTimePicker DtpHasta;
        private CheckBox ChkFiltrarFecha;
        private Label LblBuscar;
        private TextBox TxtBuscar;
        private DataGridView Dgv1;
        private Label LblResultados;
        private Panel Pnl1;
    }
}
