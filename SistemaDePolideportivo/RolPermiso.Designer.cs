namespace SistemaDePolideportivo
{
    partial class RolPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolPermiso));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            rolrp = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            dgvRolPermiso = new DataGridView();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            clbPermisos = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolPermiso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(52, 11);
            label1.Name = "label1";
            label1.Size = new Size(156, 33);
            label1.TabIndex = 23;
            label1.Text = "Permisos de Rol";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 25;
            label2.Text = "Permisos Admitidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 111);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 27;
            label4.Text = "Rol:";
            // 
            // rolrp
            // 
            rolrp.FormattingEnabled = true;
            rolrp.Location = new Point(11, 136);
            rolrp.Name = "rolrp";
            rolrp.Size = new Size(106, 23);
            rolrp.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 173);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 30;
            label3.Text = "Permisos:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvRolPermiso);
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(clbPermisos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rolrp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 588);
            panel1.TabIndex = 31;
            // 
            // dgvRolPermiso
            // 
            dgvRolPermiso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolPermiso.Location = new Point(15, 389);
            dgvRolPermiso.Name = "dgvRolPermiso";
            dgvRolPermiso.RowHeadersWidth = 51;
            dgvRolPermiso.RowTemplate.Height = 24;
            dgvRolPermiso.Size = new Size(312, 141);
            dgvRolPermiso.TabIndex = 35;
            dgvRolPermiso.Click += RolPermiso_Load;
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
            // clbPermisos
            // 
            clbPermisos.CheckOnClick = true;
            clbPermisos.FormattingEnabled = true;
            clbPermisos.Location = new Point(15, 199);
            clbPermisos.Name = "clbPermisos";
            clbPermisos.Size = new Size(525, 76);
            clbPermisos.TabIndex = 29;
            // 
            // RolPermiso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 586);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RolPermiso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rol Permisos";
            Load += RolPermiso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolPermiso).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rolrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView dgvRolPermiso;
        private System.Windows.Forms.CheckedListBox clbPermisos;
    }
}