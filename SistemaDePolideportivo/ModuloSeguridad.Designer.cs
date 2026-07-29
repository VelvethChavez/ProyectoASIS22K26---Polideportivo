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
            bitacora = new Button();
            permiso = new Button();
            rolperm = new Button();
            rol = new Button();
            usuario = new Button();
            USUARIOS = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            panel1.Location = new Point(-4, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 615);
            panel1.TabIndex = 2;
            // 
            // bitacora
            // 
            bitacora.BackColor = Color.Navy;
            bitacora.BackgroundImage = (Image)resources.GetObject("bitacora.BackgroundImage");
            bitacora.BackgroundImageLayout = ImageLayout.Zoom;
            bitacora.Location = new Point(679, 336);
            bitacora.Margin = new Padding(3, 4, 3, 4);
            bitacora.Name = "bitacora";
            bitacora.Size = new Size(212, 215);
            bitacora.TabIndex = 5;
            bitacora.UseVisualStyleBackColor = false;
            bitacora.Click += bitacora_Click;
            // 
            // permiso
            // 
            permiso.BackColor = Color.Navy;
            permiso.BackgroundImage = (Image)resources.GetObject("permiso.BackgroundImage");
            permiso.BackgroundImageLayout = ImageLayout.Zoom;
            permiso.Location = new Point(347, 336);
            permiso.Margin = new Padding(3, 4, 3, 4);
            permiso.Name = "permiso";
            permiso.Size = new Size(212, 215);
            permiso.TabIndex = 4;
            permiso.UseVisualStyleBackColor = false;
            permiso.Click += permiso_Click;
            // 
            // rolperm
            // 
            rolperm.BackColor = Color.Navy;
            rolperm.BackgroundImage = (Image)resources.GetObject("rolperm.BackgroundImage");
            rolperm.BackgroundImageLayout = ImageLayout.Zoom;
            rolperm.Location = new Point(683, 73);
            rolperm.Margin = new Padding(3, 4, 3, 4);
            rolperm.Name = "rolperm";
            rolperm.Size = new Size(208, 214);
            rolperm.TabIndex = 3;
            rolperm.UseVisualStyleBackColor = false;
            rolperm.Click += rolperm_Click;
            // 
            // rol
            // 
            rol.BackColor = Color.Navy;
            rol.BackgroundImage = (Image)resources.GetObject("rol.BackgroundImage");
            rol.BackgroundImageLayout = ImageLayout.Zoom;
            rol.Location = new Point(347, 73);
            rol.Margin = new Padding(3, 4, 3, 4);
            rol.Name = "rol";
            rol.Size = new Size(212, 214);
            rol.TabIndex = 2;
            rol.UseVisualStyleBackColor = false;
            rol.Click += rol_Click;
            // 
            // usuario
            // 
            usuario.BackColor = Color.Navy;
            usuario.BackgroundImage = (Image)resources.GetObject("usuario.BackgroundImage");
            usuario.BackgroundImageLayout = ImageLayout.Zoom;
            usuario.Location = new Point(35, 73);
            usuario.Margin = new Padding(3, 4, 3, 4);
            usuario.Name = "usuario";
            usuario.Size = new Size(213, 478);
            usuario.TabIndex = 0;
            usuario.UseVisualStyleBackColor = false;
            usuario.Click += usuario_Click;
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.Location = new Point(71, 41);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(132, 28);
            USUARIOS.TabIndex = 6;
            USUARIOS.Text = "USUARIOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 7;
            label1.Text = "ROL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(695, 41);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 8;
            label2.Text = "ROL PERMISOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 304);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 9;
            label3.Text = "PERMISOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(717, 304);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 10;
            label4.Text = "BITACORA";
            // 
            // ModuloSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(999, 611);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModuloSeguridad";
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