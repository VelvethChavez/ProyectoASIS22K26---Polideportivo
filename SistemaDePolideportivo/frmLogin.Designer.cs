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
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            btnIngresar = new Button();
            lblLogin = new Label();
            btnAyuda = new Button();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.None;
            txtContrasena.BackColor = Color.WhiteSmoke;
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Bookerly", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.Black;
            txtContrasena.Location = new Point(76, 282);
            txtContrasena.Margin = new Padding(0);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(300, 29);
            txtContrasena.TabIndex = 13;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.Anchor = AnchorStyles.None;
            lblContrasena.BackColor = Color.White;
            lblContrasena.Font = new Font("OpenSymbol", 10.2F);
            lblContrasena.Location = new Point(76, 253);
            lblContrasena.Margin = new Padding(0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(300, 36);
            lblContrasena.TabIndex = 15;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Bookerly", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(76, 211);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 29);
            txtUsuario.TabIndex = 17;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.BackColor = Color.White;
            lblUsuario.Font = new Font("OpenSymbol", 10.2F);
            lblUsuario.Location = new Point(76, 182);
            lblUsuario.Margin = new Padding(0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(300, 36);
            lblUsuario.TabIndex = 18;
            lblUsuario.Text = "Usuario";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnIngresar.Font = new Font("Bookerly", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(76, 342);
            btnIngresar.Margin = new Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(300, 58);
            btnIngresar.TabIndex = 14;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.BackColor = Color.White;
            lblLogin.FlatStyle = FlatStyle.System;
            lblLogin.Font = new Font("OpenSymbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(18, 91);
            lblLogin.Margin = new Padding(0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(414, 75);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Inicio de Sesión";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAyuda
            // 
            btnAyuda.Anchor = AnchorStyles.None;
            btnAyuda.BackgroundImage = SistemaDePolideportivo.Properties.Resources.ayuda;
            btnAyuda.BackgroundImageLayout = ImageLayout.Zoom;
            btnAyuda.Location = new Point(326, 470);
            btnAyuda.Margin = new Padding(0);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(50, 50);
            btnAyuda.TabIndex = 19;
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(450, 600);
            Controls.Add(btnAyuda);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAyuda;
    }
}