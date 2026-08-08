namespace SistemaDePolideportivo
{
    partial class usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nombreusu = new TextBox();
            contrasenausu = new TextBox();
            estadousu = new ComboBox();
            dgvUsuarios = new DataGridView();
            panel1 = new Panel();
            rolusu = new ComboBox();
            BtnNuevo = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(69, 31);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 119);
            label2.Name = "label2";
            label2.Size = new Size(159, 24);
            label2.TabIndex = 1;
            label2.Text = "Datos de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(13, 168);
            label3.Name = "label3";
            label3.Size = new Size(182, 24);
            label3.TabIndex = 2;
            label3.Text = "Nombre de usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 212);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 249);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label6.Location = new Point(13, 296);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 5;
            label6.Text = "Rol:";
            // 
            // nombreusu
            // 
            nombreusu.BorderStyle = BorderStyle.FixedSingle;
            nombreusu.Font = new Font("Bell MT", 9F);
            nombreusu.Location = new Point(222, 168);
            nombreusu.Margin = new Padding(3, 4, 3, 4);
            nombreusu.Name = "nombreusu";
            nombreusu.Size = new Size(192, 24);
            nombreusu.TabIndex = 7;
            nombreusu.Text = "Ingrese nombre de usuario";
            // 
            // contrasenausu
            // 
            contrasenausu.BorderStyle = BorderStyle.FixedSingle;
            contrasenausu.Font = new Font("Bell MT", 9F);
            contrasenausu.Location = new Point(222, 211);
            contrasenausu.Margin = new Padding(3, 4, 3, 4);
            contrasenausu.Name = "contrasenausu";
            contrasenausu.Size = new Size(192, 24);
            contrasenausu.TabIndex = 8;
            contrasenausu.Text = "Ingrese Contraseña";
            // 
            // estadousu
            // 
            estadousu.FormattingEnabled = true;
            estadousu.Items.AddRange(new object[] { "Activo", "Inactivo" });
            estadousu.Location = new Point(222, 249);
            estadousu.Margin = new Padding(3, 4, 3, 4);
            estadousu.Name = "estadousu";
            estadousu.Size = new Size(121, 28);
            estadousu.TabIndex = 11;
            estadousu.SelectedIndexChanged += estadousu_SelectedIndexChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(17, 419);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 24;
            dgvUsuarios.Size = new Size(907, 229);
            dgvUsuarios.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rolusu);
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(contrasenausu);
            panel1.Controls.Add(estadousu);
            panel1.Controls.Add(nombreusu);
            panel1.Controls.Add(dgvUsuarios);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 760);
            panel1.TabIndex = 14;
            // 
            // rolusu
            // 
            rolusu.FormattingEnabled = true;
            rolusu.Location = new Point(222, 287);
            rolusu.Margin = new Padding(3, 4, 3, 4);
            rolusu.Name = "rolusu";
            rolusu.Size = new Size(121, 28);
            rolusu.TabIndex = 20;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.Transparent;
            BtnNuevo.BackgroundImage = (Image)resources.GetObject("BtnNuevo.BackgroundImage");
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(971, 396);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 84);
            BtnNuevo.TabIndex = 19;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(971, 305);
            BtnLimpiar.Margin = new Padding(3, 4, 3, 4);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(66, 84);
            BtnLimpiar.TabIndex = 18;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(971, 213);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 84);
            BtnEliminar.TabIndex = 17;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(971, 123);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 84);
            BtnEditar.TabIndex = 16;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click_1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(971, 31);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 84);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 755);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            Load += usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreusu;
        private System.Windows.Forms.TextBox contrasenausu;
        private System.Windows.Forms.ComboBox estadousu;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ComboBox rolusu;
    }
}