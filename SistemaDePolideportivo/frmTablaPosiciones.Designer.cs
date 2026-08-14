namespace SistemaDePolideportivo
{
    partial class frmTablaPosiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablaPosiciones));
            label1 = new Label();
            dgvPosiciones = new DataGridView();
            btnRegresarMenuCompeticiones = new Button();
            cboCampeonato = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 0;
            label1.Text = "CAMPEONATO/TORNEO:";
            // 
            // dgvPosiciones
            // 
            dgvPosiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPosiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosiciones.Location = new Point(12, 218);
            dgvPosiciones.Name = "dgvPosiciones";
            dgvPosiciones.RowHeadersWidth = 51;
            dgvPosiciones.Size = new Size(776, 220);
            dgvPosiciones.TabIndex = 1;
            dgvPosiciones.CellContentClick += dgvPosiciones_CellContentClick;
            // 
            // btnRegresarMenuCompeticiones
            // 
            btnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("btnRegresarMenuCompeticiones.BackgroundImage");
            btnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            btnRegresarMenuCompeticiones.Location = new Point(722, 13);
            btnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            btnRegresarMenuCompeticiones.Name = "btnRegresarMenuCompeticiones";
            btnRegresarMenuCompeticiones.Size = new Size(66, 63);
            btnRegresarMenuCompeticiones.TabIndex = 36;
            btnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            btnRegresarMenuCompeticiones.Click += btnRegresarMenuCompeticiones_Click;
            // 
            // cboCampeonato
            // 
            cboCampeonato.FormattingEnabled = true;
            cboCampeonato.Location = new Point(284, 54);
            cboCampeonato.Name = "cboCampeonato";
            cboCampeonato.Size = new Size(250, 28);
            cboCampeonato.TabIndex = 37;
            cboCampeonato.SelectedIndexChanged += cboCampeonato_SelectedIndexChanged_1;
            // 
            // frmTablaPosiciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCampeonato);
            Controls.Add(btnRegresarMenuCompeticiones);
            Controls.Add(dgvPosiciones);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTablaPosiciones";
            Text = "frmTablaPosiciones";
            Load += frmTablaPosiciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPosiciones;
        private Button btnRegresarMenuCompeticiones;
        private ComboBox cboCampeonato;
    }
}