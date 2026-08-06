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
            label1 = new Label();
            dgvPosiciones = new DataGridView();
            txtCampeonato = new TextBox();
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
            // 
            // txtCampeonato
            // 
            txtCampeonato.Location = new Point(284, 55);
            txtCampeonato.Name = "txtCampeonato";
            txtCampeonato.Size = new Size(236, 27);
            txtCampeonato.TabIndex = 2;
            // 
            // frmTablaPosiciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCampeonato);
            Controls.Add(dgvPosiciones);
            Controls.Add(label1);
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
        private TextBox txtCampeonato;
    }
}