namespace SistemaDePolideportivo
{
    partial class frmLoginEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(
                    typeof(frmLoginEquipo));

            LblLoginEquipo = new Label();
            LblUsuario = new Label();
            LblContraseña = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            button1 = new Button();
            BtnRegresarLogin = new Button();

            SuspendLayout();

            // 
            // LblLoginEquipo
            // 
            LblLoginEquipo.AutoSize = true;
            LblLoginEquipo.Font = new Font(
                "Arial Rounded MT Bold",
                18F);

            LblLoginEquipo.ForeColor = Color.DarkBlue;
            LblLoginEquipo.Location = new Point(125, 44);
            LblLoginEquipo.Name = "LblLoginEquipo";
            LblLoginEquipo.Size = new Size(163, 28);
            LblLoginEquipo.TabIndex = 0;
            LblLoginEquipo.Text = "Login Equipo";

            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font(
                "Arial Rounded MT Bold",
                11.25F);

            LblUsuario.Location = new Point(37, 131);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(70, 17);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = "Usuario:";

            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font(
                "Arial Rounded MT Bold",
                11.25F);

            LblContraseña.Location = new Point(37, 249);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(98, 17);
            LblContraseña.TabIndex = 2;
            LblContraseña.Text = "Contraseña:";

            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font(
                "Arial Rounded MT Bold",
                11.25F);

            TxtUsuario.Location = new Point(45, 177);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(145, 25);
            TxtUsuario.TabIndex = 3;

            // 
            // TxtContraseña
            // 
            TxtContraseña.Font = new Font(
                "Arial Rounded MT Bold",
                11.25F);

            TxtContraseña.Location = new Point(55, 292);
            TxtContraseña.Name = "TxtContraseña";

            // OCULTAR CONTRASEÑA
            TxtContraseña.PasswordChar = '*';

            TxtContraseña.Size = new Size(135, 25);
            TxtContraseña.TabIndex = 4;

            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font(
                "Arial Rounded MT Bold",
                11.25F);

            button1.ForeColor = Color.White;
            button1.Location = new Point(138, 337);
            button1.Name = "button1";
            button1.Size = new Size(136, 46);
            button1.TabIndex = 5;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // 
            // BtnRegresarLogin
            // 
            BtnRegresarLogin.BackgroundImage =
                (Image)resources.GetObject(
                    "BtnRegresarLogin.BackgroundImage");

            BtnRegresarLogin.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarLogin.Cursor = Cursors.Hand;
            BtnRegresarLogin.Location = new Point(12, 12);
            BtnRegresarLogin.Name = "BtnRegresarLogin";
            BtnRegresarLogin.Size = new Size(33, 35);
            BtnRegresarLogin.TabIndex = 6;
            BtnRegresarLogin.UseVisualStyleBackColor = true;
            BtnRegresarLogin.Click += BtnRegresarLogin_Click;

            // 
            // frmLoginEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 407);

            Controls.Add(BtnRegresarLogin);
            Controls.Add(button1);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(LblContraseña);
            Controls.Add(LblUsuario);
            Controls.Add(LblLoginEquipo);

            MaximizeBox = false;
            MinimizeBox = false;

            Name = "frmLoginEquipo";

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Login Equipo";

            // Evento Load
            Load += frmLoginEquipo_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLoginEquipo;
        private Label LblUsuario;
        private Label LblContraseña;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button button1;
        private Button BtnRegresarLogin;
    }
}