namespace SistemaDePolideportivo
{
    partial class FrmLoginAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            LblLogin = new Label();
            LblUsuario = new Label();
            LblContraseña = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnIniciarSesion = new Button();
            BtnRegrear = new Button();
            SuspendLayout();
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLogin.ForeColor = Color.DarkBlue;
            LblLogin.Location = new Point(81, 34);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(281, 28);
            LblLogin.TabIndex = 0;
            LblLogin.Text = "Login de administrador";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.Location = new Point(32, 100);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(70, 17);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Arial Rounded MT Bold", 11.25F);
            LblContraseña.Location = new Point(32, 194);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(98, 17);
            LblContraseña.TabIndex = 2;
            LblContraseña.Text = "Contraseña:";
            LblContraseña.Click += LblContraseña_Click;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Arial Rounded MT Bold", 11.25F);
            TxtUsuario.Location = new Point(32, 134);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(185, 25);
            TxtUsuario.TabIndex = 3;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Font = new Font("Arial Rounded MT Bold", 11.25F);
            TxtContraseña.Location = new Point(32, 237);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(185, 25);
            TxtContraseña.TabIndex = 4;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = Color.Navy;
            BtnIniciarSesion.Cursor = Cursors.Hand;
            BtnIniciarSesion.Font = new Font("Arial Rounded MT Bold", 11.25F);
            BtnIniciarSesion.ForeColor = Color.White;
            BtnIniciarSesion.Location = new Point(155, 299);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(124, 41);
            BtnIniciarSesion.TabIndex = 5;
            BtnIniciarSesion.Text = "Iniciar sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // BtnRegrear
            // 
            BtnRegrear.BackgroundImage = (Image)resources.GetObject("BtnRegrear.BackgroundImage");
            BtnRegrear.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegrear.Cursor = Cursors.Hand;
            BtnRegrear.Location = new Point(12, 12);
            BtnRegrear.Name = "BtnRegrear";
            BtnRegrear.Size = new Size(36, 33);
            BtnRegrear.TabIndex = 6;
            BtnRegrear.UseVisualStyleBackColor = true;
            BtnRegrear.Click += BtnRegrear_Click;
            // 
            // FrmLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 407);
            Controls.Add(BtnRegrear);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(LblContraseña);
            Controls.Add(LblUsuario);
            Controls.Add(LblLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login de Administrador";
            Load += FrmLoginAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLogin;
        private Label LblUsuario;
        private Label LblContraseña;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BtnIniciarSesion;
        private Button BtnRegrear;
    }
}