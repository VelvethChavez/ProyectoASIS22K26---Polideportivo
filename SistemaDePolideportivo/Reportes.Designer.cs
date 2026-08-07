namespace SistemaDePolideportivo
{
    partial class Reportes
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
            label1 = new Label();
            label2 = new Label();
            cmbReportes = new ComboBox();
            BtnActualizar = new Button();
            BtnExportarPDF = new Button();
            lblCampeonato = new Label();
            cmbCampeonato = new ComboBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            BtnFiltrar = new Button();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            chkFiltrarFecha = new CheckBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            lblResultados = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(94, 33);
            label1.TabIndex = 0;
            label1.Text = "Reportes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bell MT", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 1;
            label2.Text = "Seleccione reporte:";
            // 
            // cmbReportes
            // 
            cmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportes.Font = new Font("Bell MT", 9.5F);
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(150, 62);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(250, 23);
            cmbReportes.TabIndex = 2;
            cmbReportes.SelectedIndexChanged += cmbReportes_SelectedIndexChanged;
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
            // lblCampeonato
            // 
            lblCampeonato.AutoSize = true;
            lblCampeonato.BackColor = Color.Transparent;
            lblCampeonato.Font = new Font("Segoe UI", 8.5F);
            lblCampeonato.ForeColor = Color.Black;
            lblCampeonato.Location = new Point(15, 100);
            lblCampeonato.Name = "lblCampeonato";
            lblCampeonato.Size = new Size(79, 15);
            lblCampeonato.TabIndex = 8;
            lblCampeonato.Text = "Campeonato:";
            lblCampeonato.Visible = false;
            // 
            // cmbCampeonato
            // 
            cmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCampeonato.Font = new Font("Segoe UI", 8.5F);
            cmbCampeonato.FormattingEnabled = true;
            cmbCampeonato.Location = new Point(95, 97);
            cmbCampeonato.Name = "cmbCampeonato";
            cmbCampeonato.Size = new Size(190, 21);
            cmbCampeonato.TabIndex = 9;
            cmbCampeonato.Visible = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 8.5F);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(300, 100);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado:";
            lblEstado.Visible = false;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 8.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(348, 97);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(130, 21);
            cmbEstado.TabIndex = 11;
            cmbEstado.Visible = false;
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
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.BackColor = Color.Transparent;
            lblDesde.Font = new Font("Segoe UI", 8.5F);
            lblDesde.ForeColor = Color.Black;
            lblDesde.Location = new Point(15, 132);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 13;
            lblDesde.Text = "Desde:";
            lblDesde.Visible = false;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 8.5F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(95, 128);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(110, 23);
            dtpDesde.TabIndex = 14;
            dtpDesde.Visible = false;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.BackColor = Color.Transparent;
            lblHasta.Font = new Font("Segoe UI", 8.5F);
            lblHasta.ForeColor = Color.Black;
            lblHasta.Location = new Point(220, 132);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 15;
            lblHasta.Text = "Hasta:";
            lblHasta.Visible = false;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 8.5F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(295, 128);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(110, 23);
            dtpHasta.TabIndex = 16;
            dtpHasta.Visible = false;
            // 
            // chkFiltrarFecha
            // 
            chkFiltrarFecha.AutoSize = true;
            chkFiltrarFecha.BackColor = Color.Transparent;
            chkFiltrarFecha.Font = new Font("Segoe UI", 8.5F);
            chkFiltrarFecha.ForeColor = Color.Black;
            chkFiltrarFecha.Location = new Point(420, 130);
            chkFiltrarFecha.Name = "chkFiltrarFecha";
            chkFiltrarFecha.Size = new Size(109, 19);
            chkFiltrarFecha.TabIndex = 17;
            chkFiltrarFecha.Text = "Filtrar por fecha";
            chkFiltrarFecha.UseVisualStyleBackColor = false;
            chkFiltrarFecha.Visible = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 8.5F);
            lblBuscar.ForeColor = Color.Black;
            lblBuscar.Location = new Point(15, 163);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 8.5F);
            txtBuscar.Location = new Point(95, 159);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escribe para filtrar la tabla...";
            txtBuscar.Size = new Size(300, 23);
            txtBuscar.TabIndex = 19;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 195);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(760, 380);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.BackColor = Color.Transparent;
            lblResultados.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblResultados.ForeColor = Color.DimGray;
            lblResultados.Location = new Point(15, 580);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(78, 15);
            lblResultados.TabIndex = 6;
            lblResultados.Text = "0 resultado(s)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblResultados);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(chkFiltrarFecha);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(lblHasta);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(lblDesde);
            panel1.Controls.Add(BtnFiltrar);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(cmbCampeonato);
            panel1.Controls.Add(lblCampeonato);
            panel1.Controls.Add(BtnExportarPDF);
            panel1.Controls.Add(BtnActualizar);
            panel1.Controls.Add(cmbReportes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 610);
            panel1.TabIndex = 7;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 610);
            Controls.Add(panel1);
            MinimumSize = new Size(700, 595);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbReportes;
        private Button BtnActualizar;
        private Button BtnExportarPDF;
        private Label lblCampeonato;
        private ComboBox cmbCampeonato;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button BtnFiltrar;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private CheckBox chkFiltrarFecha;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private Label lblResultados;
        private Panel panel1;
    }
}
