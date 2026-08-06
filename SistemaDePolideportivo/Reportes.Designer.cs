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
            dataGridView1 = new DataGridView();
            lblResultados = new Label();
            panel1 = new Panel();
            BtnMenu = new Button();
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
            dataGridView1.Location = new Point(15, 100);
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
            lblResultados.Location = new Point(15, 485);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(78, 15);
            lblResultados.TabIndex = 6;
            lblResultados.Text = "0 resultado(s)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(lblResultados);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BtnExportarPDF);
            panel1.Controls.Add(BtnActualizar);
            panel1.Controls.Add(cmbReportes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 515);
            panel1.TabIndex = 7;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = Properties.Resources.Menu;
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.Location = new Point(723, 13);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(52, 52);
            BtnMenu.TabIndex = 7;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 515);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "Reportes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private DataGridView dataGridView1;
        private Label lblResultados;
        private Panel panel1;
        private Button BtnMenu;
    }
}
