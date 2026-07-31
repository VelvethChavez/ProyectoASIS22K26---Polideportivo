namespace SistemaDePolideportivo
{
    partial class ModuloSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloSeguridad));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            USUARIOS = new Label();
            bitacora = new Button();
            permiso = new Button();
            rolperm = new Button();
            rol = new Button();
            usuario = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(USUARIOS);
            panel1.Controls.Add(bitacora);
            panel1.Controls.Add(permiso);
            panel1.Controls.Add(rolperm);
            panel1.Controls.Add(rol);
            panel1.Controls.Add(usuario);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 461);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(627, 228);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 10;
            label4.Text = "BITACORA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(343, 228);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 9;
            label3.Text = "PERMISOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(608, 31);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 8;
            label2.Text = "ROL PERMISOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 31);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 7;
            label1.Text = "ROL";
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.Location = new Point(62, 31);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(106, 22);
            USUARIOS.TabIndex = 6;
            USUARIOS.Text = "USUARIOS";
            // 
            // bitacora
            // 
            bitacora.BackColor = Color.Navy;
            bitacora.BackgroundImage = (Image)resources.GetObject("bitacora.BackgroundImage");
            bitacora.BackgroundImageLayout = ImageLayout.Zoom;
            bitacora.Location = new Point(594, 252);
            bitacora.Name = "bitacora";
            bitacora.Size = new Size(186, 161);
            bitacora.TabIndex = 5;
            bitacora.UseVisualStyleBackColor = false;
            bitacora.Click += bitacora_Click;
            // 
            // permiso
            // 
            permiso.BackColor = Color.Navy;
            permiso.BackgroundImage = (Image)resources.GetObject("permiso.BackgroundImage");
            permiso.BackgroundImageLayout = ImageLayout.Zoom;
            permiso.Location = new Point(304, 252);
            permiso.Name = "permiso";
            permiso.Size = new Size(186, 161);
            permiso.TabIndex = 4;
            permiso.UseVisualStyleBackColor = false;
            permiso.Click += permiso_Click;
            // 
            // rolperm
            // 
            rolperm.BackColor = Color.Navy;
            rolperm.BackgroundImage = (Image)resources.GetObject("rolperm.BackgroundImage");
            rolperm.BackgroundImageLayout = ImageLayout.Zoom;
            rolperm.Location = new Point(598, 55);
            rolperm.Name = "rolperm";
            rolperm.Size = new Size(182, 160);
            rolperm.TabIndex = 3;
            rolperm.UseVisualStyleBackColor = false;
            rolperm.Click += rolperm_Click;
            // 
            // rol
            // 
            rol.BackColor = Color.Navy;
            rol.BackgroundImage = (Image)resources.GetObject("rol.BackgroundImage");
            rol.BackgroundImageLayout = ImageLayout.Zoom;
            rol.Location = new Point(304, 55);
            rol.Name = "rol";
            rol.Size = new Size(186, 160);
            rol.TabIndex = 2;
            rol.UseVisualStyleBackColor = false;
            rol.Click += rol_Click;
            // 
            // usuario
            // 
            usuario.BackColor = Color.Navy;
            usuario.BackgroundImage = (Image)resources.GetObject("usuario.BackgroundImage");
            usuario.BackgroundImageLayout = ImageLayout.Zoom;
            usuario.Location = new Point(31, 55);
            usuario.Name = "usuario";
            usuario.Size = new Size(186, 358);
            usuario.TabIndex = 0;
            usuario.UseVisualStyleBackColor = false;
            usuario.Click += usuario_Click;
            // 
            // ModuloSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(874, 458);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModuloSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModuloSeguridad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usuario;
        private System.Windows.Forms.Button rol;
        private System.Windows.Forms.Button rolperm;
        private System.Windows.Forms.Button permiso;
        private System.Windows.Forms.Button bitacora;
        private Label label1;
        private Label USUARIOS;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}