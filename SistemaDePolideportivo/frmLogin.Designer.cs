namespace ProyectoASIS22K26___Polideportivo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnAyuda = new Button();
            PicAdmin = new PictureBox();
            PicGerente = new PictureBox();
            PicArbitro = new PictureBox();
            PicEquipo = new PictureBox();
            BtnLoginAdmin = new Button();
            BtnLoginArbitro = new Button();
            BtnLoginGerente = new Button();
            BtnLoginEquipo = new Button();
            LblBienvenido1 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PicAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicGerente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicArbitro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipo).BeginInit();
            SuspendLayout();
            // 
            // btnAyuda
            // 
            btnAyuda.Anchor = AnchorStyles.None;
            btnAyuda.BackColor = Color.Transparent;
            btnAyuda.BackgroundImage = SistemaDePolideportivo.Properties.Resources.ayuda;
            btnAyuda.BackgroundImageLayout = ImageLayout.Zoom;
            btnAyuda.Cursor = Cursors.Hand;
            btnAyuda.Location = new Point(719, 19);
            btnAyuda.Margin = new Padding(0);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(50, 50);
            btnAyuda.TabIndex = 19;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // PicAdmin
            // 
            PicAdmin.BackColor = Color.Transparent;
            PicAdmin.Cursor = Cursors.Hand;
            PicAdmin.Image = (Image)resources.GetObject("PicAdmin.Image");
            PicAdmin.Location = new Point(59, 305);
            PicAdmin.Name = "PicAdmin";
            PicAdmin.Size = new Size(98, 124);
            PicAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            PicAdmin.TabIndex = 20;
            PicAdmin.TabStop = false;
            PicAdmin.Click += PicAdmin_Click;
            // 
            // PicGerente
            // 
            PicGerente.BackColor = Color.Transparent;
            PicGerente.Cursor = Cursors.Hand;
            PicGerente.Image = (Image)resources.GetObject("PicGerente.Image");
            PicGerente.Location = new Point(455, 305);
            PicGerente.Name = "PicGerente";
            PicGerente.Size = new Size(98, 124);
            PicGerente.SizeMode = PictureBoxSizeMode.Zoom;
            PicGerente.TabIndex = 21;
            PicGerente.TabStop = false;
            PicGerente.Click += PicGerente_Click;
            // 
            // PicArbitro
            // 
            PicArbitro.BackColor = Color.Transparent;
            PicArbitro.BackgroundImageLayout = ImageLayout.Stretch;
            PicArbitro.Cursor = Cursors.Hand;
            PicArbitro.Image = (Image)resources.GetObject("PicArbitro.Image");
            PicArbitro.Location = new Point(261, 305);
            PicArbitro.Name = "PicArbitro";
            PicArbitro.Size = new Size(98, 124);
            PicArbitro.SizeMode = PictureBoxSizeMode.Zoom;
            PicArbitro.TabIndex = 22;
            PicArbitro.TabStop = false;
            PicArbitro.Click += PicArbitro_Click;
            // 
            // PicEquipo
            // 
            PicEquipo.BackColor = Color.Transparent;
            PicEquipo.BackgroundImageLayout = ImageLayout.Stretch;
            PicEquipo.Cursor = Cursors.Hand;
            PicEquipo.Image = (Image)resources.GetObject("PicEquipo.Image");
            PicEquipo.Location = new Point(630, 305);
            PicEquipo.Name = "PicEquipo";
            PicEquipo.Size = new Size(98, 124);
            PicEquipo.SizeMode = PictureBoxSizeMode.Zoom;
            PicEquipo.TabIndex = 23;
            PicEquipo.TabStop = false;
            PicEquipo.Click += PicEquipo_Click;
            // 
            // BtnLoginAdmin
            // 
            BtnLoginAdmin.BackColor = Color.Teal;
            BtnLoginAdmin.Cursor = Cursors.Hand;
            BtnLoginAdmin.FlatStyle = FlatStyle.Flat;
            BtnLoginAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLoginAdmin.ForeColor = SystemColors.ControlLightLight;
            BtnLoginAdmin.Location = new Point(58, 435);
            BtnLoginAdmin.Name = "BtnLoginAdmin";
            BtnLoginAdmin.Size = new Size(99, 34);
            BtnLoginAdmin.TabIndex = 24;
            BtnLoginAdmin.Text = "Administrador";
            BtnLoginAdmin.UseVisualStyleBackColor = false;
            BtnLoginAdmin.Click += BtnLoginAdmin_Click;
            // 
            // BtnLoginArbitro
            // 
            BtnLoginArbitro.BackColor = Color.DarkOrange;
            BtnLoginArbitro.Cursor = Cursors.Hand;
            BtnLoginArbitro.FlatStyle = FlatStyle.Flat;
            BtnLoginArbitro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLoginArbitro.ForeColor = SystemColors.Control;
            BtnLoginArbitro.Location = new Point(260, 435);
            BtnLoginArbitro.Name = "BtnLoginArbitro";
            BtnLoginArbitro.Size = new Size(99, 34);
            BtnLoginArbitro.TabIndex = 25;
            BtnLoginArbitro.Text = "Arbitro";
            BtnLoginArbitro.UseVisualStyleBackColor = false;
            BtnLoginArbitro.Click += BtnLoginArbitro_Click;
            // 
            // BtnLoginGerente
            // 
            BtnLoginGerente.BackColor = Color.Green;
            BtnLoginGerente.Cursor = Cursors.Hand;
            BtnLoginGerente.FlatStyle = FlatStyle.Flat;
            BtnLoginGerente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLoginGerente.ForeColor = SystemColors.Control;
            BtnLoginGerente.Location = new Point(454, 435);
            BtnLoginGerente.Name = "BtnLoginGerente";
            BtnLoginGerente.Size = new Size(99, 34);
            BtnLoginGerente.TabIndex = 26;
            BtnLoginGerente.Text = "Gerente";
            BtnLoginGerente.UseVisualStyleBackColor = false;
            BtnLoginGerente.Click += BtnLoginGerente_Click;
            // 
            // BtnLoginEquipo
            // 
            BtnLoginEquipo.BackColor = Color.DarkBlue;
            BtnLoginEquipo.Cursor = Cursors.Hand;
            BtnLoginEquipo.FlatStyle = FlatStyle.Flat;
            BtnLoginEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLoginEquipo.ForeColor = SystemColors.Control;
            BtnLoginEquipo.Location = new Point(630, 435);
            BtnLoginEquipo.Name = "BtnLoginEquipo";
            BtnLoginEquipo.Size = new Size(99, 34);
            BtnLoginEquipo.TabIndex = 27;
            BtnLoginEquipo.Text = "Equipo";
            BtnLoginEquipo.UseVisualStyleBackColor = false;
            BtnLoginEquipo.Click += BtnLoginEquipo_Click;
            // 
            // LblBienvenido1
            // 
            LblBienvenido1.AutoSize = true;
            LblBienvenido1.BackColor = Color.Transparent;
            LblBienvenido1.BorderStyle = BorderStyle.Fixed3D;
            LblBienvenido1.FlatStyle = FlatStyle.Flat;
            LblBienvenido1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenido1.ForeColor = Color.Navy;
            LblBienvenido1.Location = new Point(131, 57);
            LblBienvenido1.Name = "LblBienvenido1";
            LblBienvenido1.Size = new Size(540, 132);
            LblBienvenido1.TabIndex = 28;
            LblBienvenido1.Text = "Bienvenido al Sistema \r\nPolideportivo";
            LblBienvenido1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(57, 228);
            label1.Name = "label1";
            label1.Size = new Size(368, 43);
            label1.TabIndex = 29;
            label1.Text = "Selecciona el tipo de usuario:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(795, 549);
            Controls.Add(label1);
            Controls.Add(BtnLoginEquipo);
            Controls.Add(BtnLoginGerente);
            Controls.Add(BtnLoginArbitro);
            Controls.Add(BtnLoginAdmin);
            Controls.Add(PicEquipo);
            Controls.Add(PicArbitro);
            Controls.Add(PicGerente);
            Controls.Add(PicAdmin);
            Controls.Add(btnAyuda);
            Controls.Add(LblBienvenido1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)PicAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicGerente).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicArbitro).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAyuda;
        private PictureBox PicAdmin;
        private PictureBox PicGerente;
        private PictureBox PicArbitro;
        private PictureBox PicEquipo;
        private Button BtnLoginAdmin;
        private Button BtnLoginArbitro;
        private Button BtnLoginGerente;
        private Button BtnLoginEquipo;
        private Label LblBienvenido1;
        private Label label1;
    }
}