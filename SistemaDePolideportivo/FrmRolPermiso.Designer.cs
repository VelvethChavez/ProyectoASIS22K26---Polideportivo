namespace SistemaDePolideportivo
{
    partial class FrmRolPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRolPermiso));
            Lbl1 = new Label();
            Pic1 = new PictureBox();
            Lbl2 = new Label();
            Lbl4 = new Label();
            CmbRolrp = new ComboBox();
            Lbl3 = new Label();
            Pnl1 = new Panel();
            DgvRolPermiso = new DataGridView();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            ClbPermisos = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRolPermiso).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F);
            Lbl1.Location = new Point(52, 11);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(156, 33);
            Lbl1.TabIndex = 23;
            Lbl1.Text = "FrmPermisos de FrmRol";
            // 
            // Pic1
            // 
            Pic1.BackColor = Color.Transparent;
            Pic1.BackgroundImageLayout = ImageLayout.Center;
            Pic1.Image = (Image)resources.GetObject("Pic1.Image");
            Pic1.Location = new Point(7, 11);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(40, 49);
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic1.TabIndex = 24;
            Pic1.TabStop = false;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl2.Location = new Point(11, 74);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(152, 19);
            Lbl2.TabIndex = 25;
            Lbl2.Text = "FrmPermisos Admitidos";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl4.Location = new Point(11, 111);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(37, 19);
            Lbl4.TabIndex = 27;
            Lbl4.Text = "FrmRol:";
            // 
            // CmbRolrp
            // 
            CmbRolrp.FormattingEnabled = true;
            CmbRolrp.Location = new Point(11, 136);
            CmbRolrp.Name = "CmbRolrp";
            CmbRolrp.Size = new Size(106, 23);
            CmbRolrp.TabIndex = 28;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl3.Location = new Point(11, 173);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(79, 19);
            Lbl3.TabIndex = 30;
            Lbl3.Text = "FrmPermisos:";
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(DgvRolPermiso);
            Pnl1.Controls.Add(BtnLimpiar);
            Pnl1.Controls.Add(BtnEliminar);
            Pnl1.Controls.Add(BtnEditar);
            Pnl1.Controls.Add(BtnGuardar);
            Pnl1.Controls.Add(ClbPermisos);
            Pnl1.Controls.Add(Lbl3);
            Pnl1.Controls.Add(Pic1);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Controls.Add(CmbRolrp);
            Pnl1.Controls.Add(Lbl2);
            Pnl1.Controls.Add(Lbl4);
            Pnl1.Location = new Point(-1, -3);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(672, 588);
            Pnl1.TabIndex = 31;
            // 
            // DgvRolPermiso
            // 
            DgvRolPermiso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRolPermiso.Location = new Point(15, 389);
            DgvRolPermiso.Name = "DgvRolPermiso";
            DgvRolPermiso.RowHeadersWidth = 51;
            DgvRolPermiso.RowTemplate.Height = 24;
            DgvRolPermiso.Size = new Size(312, 141);
            DgvRolPermiso.TabIndex = 35;
            DgvRolPermiso.Click += FrmRolPermiso_Load;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(204, 321);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(58, 63);
            BtnLimpiar.TabIndex = 34;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(141, 321);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 63);
            BtnEliminar.TabIndex = 33;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(78, 321);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 63);
            BtnEditar.TabIndex = 32;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(15, 321);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 63);
            BtnGuardar.TabIndex = 31;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // ClbPermisos
            // 
            ClbPermisos.CheckOnClick = true;
            ClbPermisos.FormattingEnabled = true;
            ClbPermisos.Location = new Point(15, 199);
            ClbPermisos.Name = "ClbPermisos";
            ClbPermisos.Size = new Size(525, 76);
            ClbPermisos.TabIndex = 29;
            // 
            // FrmRolPermiso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 586);
            Controls.Add(Pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRolPermiso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRol FrmPermisos";
            Load += FrmRolPermiso_Load;
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRolPermiso).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.ComboBox CmbRolrp;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvRolPermiso;
        private System.Windows.Forms.CheckedListBox ClbPermisos;
    }
}