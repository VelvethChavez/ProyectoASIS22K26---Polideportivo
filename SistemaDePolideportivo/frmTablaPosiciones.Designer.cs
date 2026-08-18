namespace SistemaDePolideportivo
{
    partial class FrmTablaPosiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTablaPosiciones));
            Lbl1 = new Label();
            DgvPosiciones = new DataGridView();
            BtnRegresarMenuCompeticiones = new Button();
            CmbCboCampeonato = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvPosiciones).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(12, 51);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(266, 31);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "CAMPEONATO/TORNEO:";
            // 
            // DgvPosiciones
            // 
            DgvPosiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPosiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPosiciones.Location = new Point(12, 218);
            DgvPosiciones.Name = "DgvPosiciones";
            DgvPosiciones.RowHeadersWidth = 51;
            DgvPosiciones.Size = new Size(776, 220);
            DgvPosiciones.TabIndex = 1;
            DgvPosiciones.CellContentClick += DgvPosiciones_CellContentClick;
            // 
            // BtnRegresarMenuCompeticiones
            // 
            BtnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("BtnRegresarMenuCompeticiones.BackgroundImage");
            BtnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            BtnRegresarMenuCompeticiones.Location = new Point(722, 13);
            BtnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            BtnRegresarMenuCompeticiones.Name = "BtnRegresarMenuCompeticiones";
            BtnRegresarMenuCompeticiones.Size = new Size(66, 63);
            BtnRegresarMenuCompeticiones.TabIndex = 36;
            BtnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            BtnRegresarMenuCompeticiones.Click += BtnRegresarMenuCompeticiones_Click;
            // 
            // CmbCboCampeonato
            // 
            CmbCboCampeonato.FormattingEnabled = true;
            CmbCboCampeonato.Location = new Point(284, 54);
            CmbCboCampeonato.Name = "CmbCboCampeonato";
            CmbCboCampeonato.Size = new Size(250, 28);
            CmbCboCampeonato.TabIndex = 37;
            CmbCboCampeonato.SelectedIndexChanged += CmbCboCampeonato_SelectedIndexChanged_1;
            // 
            // FrmTablaPosiciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(CmbCboCampeonato);
            Controls.Add(BtnRegresarMenuCompeticiones);
            Controls.Add(DgvPosiciones);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTablaPosiciones";
            Text = "FrmTablaPosiciones";
            Load += FrmTablaPosiciones_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPosiciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private DataGridView DgvPosiciones;
        private Button BtnRegresarMenuCompeticiones;
        private ComboBox CmbCboCampeonato;
    }
}