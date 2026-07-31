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
            label1.Location = new Point(60, 15);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 23;
            label1.Text = "Permisos de Rol";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 99);
            label2.Name = "label2";
            label2.Size = new Size(186, 24);
            label2.TabIndex = 25;
            label2.Text = "Permisos Admitidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 148);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 27;
            label4.Text = "Rol:";
            // 
            // rolrp
            // 
            rolrp.FormattingEnabled = true;
            rolrp.Location = new Point(13, 181);
            rolrp.Margin = new Padding(3, 4, 3, 4);
            rolrp.Name = "rolrp";
            rolrp.Size = new Size(121, 28);
            rolrp.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(13, 231);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
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
            panel1.Location = new Point(-1, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 784);
            panel1.TabIndex = 31;
            // 
            // dgvRolPermiso
            // 
            dgvRolPermiso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolPermiso.Location = new Point(17, 519);
            dgvRolPermiso.Margin = new Padding(3, 4, 3, 4);
            dgvRolPermiso.Name = "dgvRolPermiso";
            dgvRolPermiso.RowHeadersWidth = 51;
            dgvRolPermiso.RowTemplate.Height = 24;
            dgvRolPermiso.Size = new Size(356, 188);
            dgvRolPermiso.TabIndex = 35;
            dgvRolPermiso.Click += RolPermiso_Load;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(233, 428);
            BtnLimpiar.Margin = new Padding(3, 4, 3, 4);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(66, 84);
            BtnLimpiar.TabIndex = 34;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(161, 428);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 84);
            BtnEliminar.TabIndex = 33;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(89, 428);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 84);
            BtnEditar.TabIndex = 32;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(17, 428);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 84);
            BtnGuardar.TabIndex = 31;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // clbPermisos
            // 
            clbPermisos.CheckOnClick = true;
            clbPermisos.FormattingEnabled = true;
            clbPermisos.HorizontalScrollbar = true;
            clbPermisos.Location = new Point(17, 265);
            clbPermisos.Margin = new Padding(3, 4, 3, 4);
            clbPermisos.Name = "clbPermisos";
            clbPermisos.Size = new Size(599, 92);
            clbPermisos.TabIndex = 29;
            // 
            // RolPermiso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 781);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RolPermiso";
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