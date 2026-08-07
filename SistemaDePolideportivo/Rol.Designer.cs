namespace SistemaDePolideportivo
{
    partial class Rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rol));
            panel1 = new Panel();
            dgvRoles = new DataGridView();
            descripcionrol = new TextBox();
            nombrerol = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnNuevo = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvRoles);
            panel1.Controls.Add(descripcionrol);
            panel1.Controls.Add(nombrerol);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 538);
            panel1.TabIndex = 0;
            panel1.Click += Rol_Load;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(57, 310);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.RowTemplate.Height = 24;
            dgvRoles.Size = new Size(405, 183);
            dgvRoles.TabIndex = 28;
            // 
            // descripcionrol
            // 
            descripcionrol.BorderStyle = BorderStyle.FixedSingle;
            descripcionrol.Font = new Font("Bell MT", 9F);
            descripcionrol.Location = new Point(196, 178);
            descripcionrol.Multiline = true;
            descripcionrol.Name = "descripcionrol";
            descripcionrol.Size = new Size(292, 102);
            descripcionrol.TabIndex = 27;
            descripcionrol.Text = "Ingrese descripcion de rol";
            // 
            // nombrerol
            // 
            nombrerol.BorderStyle = BorderStyle.FixedSingle;
            nombrerol.Font = new Font("Bell MT", 9F);
            nombrerol.Location = new Point(196, 121);
            nombrerol.Name = "nombrerol";
            nombrerol.Size = new Size(168, 21);
            nombrerol.TabIndex = 26;
            nombrerol.Text = "Ingrese el rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 176);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 25;
            label4.Text = "Descripcion de rol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 24;
            label3.Text = "Nombre de rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 23;
            label2.Text = "Datos de rol";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 33);
            label1.TabIndex = 21;
            label1.Text = "Roles";
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.Transparent;
            BtnNuevo.BackgroundImage = (Image)resources.GetObject("BtnNuevo.BackgroundImage");
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(805, 286);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(58, 63);
            BtnNuevo.TabIndex = 20;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(805, 218);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(58, 63);
            BtnLimpiar.TabIndex = 19;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(805, 149);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 63);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(805, 81);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 63);
            BtnEditar.TabIndex = 17;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(805, 12);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 63);
            BtnGuardar.TabIndex = 16;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // Rol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 537);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Rol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rol";
            Load += Rol_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TextBox descripcionrol;
        private System.Windows.Forms.TextBox nombrerol;
        private System.Windows.Forms.Button BtnEliminar;
    }
}