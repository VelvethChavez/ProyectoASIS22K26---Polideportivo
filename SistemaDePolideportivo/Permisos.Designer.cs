namespace SistemaDePolideportivo
{
    partial class Permiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permiso));
            panel1 = new Panel();
            BtnNuevo = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            dgvPermisos = new DataGridView();
            descripcionpermiso = new TextBox();
            nombrepermiso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(dgvPermisos);
            panel1.Controls.Add(descripcionpermiso);
            panel1.Controls.Add(nombrepermiso);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 666);
            panel1.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.Transparent;
            BtnNuevo.BackgroundImage = (Image)resources.GetObject("BtnNuevo.BackgroundImage");
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(937, 401);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 84);
            BtnNuevo.TabIndex = 34;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(937, 310);
            BtnLimpiar.Margin = new Padding(3, 4, 3, 4);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(66, 84);
            BtnLimpiar.TabIndex = 33;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(937, 219);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 84);
            BtnEliminar.TabIndex = 32;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(937, 128);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 84);
            BtnEditar.TabIndex = 31;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(937, 31);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 84);
            BtnGuardar.TabIndex = 30;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // dgvPermisos
            // 
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new Point(134, 401);
            dgvPermisos.Margin = new Padding(3, 4, 3, 4);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.RowHeadersWidth = 51;
            dgvPermisos.RowTemplate.Height = 24;
            dgvPermisos.Size = new Size(429, 199);
            dgvPermisos.TabIndex = 29;
            // 
            // descripcionpermiso
            // 
            descripcionpermiso.BorderStyle = BorderStyle.FixedSingle;
            descripcionpermiso.Font = new Font("Bell MT", 9F);
            descripcionpermiso.Location = new Point(254, 241);
            descripcionpermiso.Margin = new Padding(3, 4, 3, 4);
            descripcionpermiso.Multiline = true;
            descripcionpermiso.Name = "descripcionpermiso";
            descripcionpermiso.Size = new Size(333, 136);
            descripcionpermiso.TabIndex = 28;
            descripcionpermiso.Text = "Ingrese descripcion de permiso";
            // 
            // nombrepermiso
            // 
            nombrepermiso.BorderStyle = BorderStyle.FixedSingle;
            nombrepermiso.Font = new Font("Bell MT", 9F);
            nombrepermiso.Location = new Point(254, 181);
            nombrepermiso.Margin = new Padding(3, 4, 3, 4);
            nombrepermiso.Name = "nombrepermiso";
            nombrepermiso.Size = new Size(192, 24);
            nombrepermiso.TabIndex = 27;
            nombrepermiso.Text = "Ingrese el permiso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(27, 181);
            label4.Name = "label4";
            label4.Size = new Size(161, 24);
            label4.TabIndex = 26;
            label4.Text = "Nombre permiso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(27, 241);
            label3.Name = "label3";
            label3.Size = new Size(195, 24);
            label3.TabIndex = 25;
            label3.Text = "Descripcion permiso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 109);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 24;
            label2.Text = "Datos de permisos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 22;
            label1.Text = "Permisos";
            // 
            // Permiso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 661);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Permiso";
            Text = "Permisos";
            Load += Permiso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombrepermiso;
        private System.Windows.Forms.TextBox descripcionpermiso;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}