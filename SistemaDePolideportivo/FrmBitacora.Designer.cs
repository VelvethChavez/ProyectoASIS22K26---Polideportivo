namespace SistemaDePolideportivo
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            Lbl1 = new Label();
            Pnl1 = new Panel();
            DgvBitacora = new DataGridView();
            Pic1 = new PictureBox();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F);
            Lbl1.Location = new Point(55, 9);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(88, 33);
            Lbl1.TabIndex = 22;
            Lbl1.Text = "Bitacora";
            Lbl1.Click += Lbl1_Click;
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(DgvBitacora);
            Pnl1.Controls.Add(Pic1);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Location = new Point(1, -1);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(700, 428);
            Pnl1.TabIndex = 23;
            // 
            // DgvBitacora
            // 
            DgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBitacora.Location = new Point(24, 90);
            DgvBitacora.Name = "DgvBitacora";
            DgvBitacora.RowHeadersWidth = 51;
            DgvBitacora.RowTemplate.Height = 24;
            DgvBitacora.Size = new Size(637, 322);
            DgvBitacora.TabIndex = 26;
            // 
            // Pic1
            // 
            Pic1.BackColor = Color.Transparent;
            Pic1.BackgroundImageLayout = ImageLayout.Center;
            Pic1.Image = (Image)resources.GetObject("Pic1.Image");
            Pic1.Location = new Point(10, 9);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(40, 49);
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic1.TabIndex = 25;
            Pic1.TabStop = false;
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(Pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBitacora";
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.DataGridView DgvBitacora;
    }
}