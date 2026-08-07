namespace SistemaDePolideportivo
{
    partial class frmModuloEquipos
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
            label1 = new Label();
            btnEquipos = new Button();
            btnEntrenadores = new Button();
            btnJugadores = new Button();
            btnPosiciones = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(253, 16);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Modulo de equipos";
            label1.Click += label1_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = Color.Green;
            btnEquipos.Cursor = Cursors.Hand;
            btnEquipos.ForeColor = Color.Snow;
            btnEquipos.Location = new Point(71, 139);
            btnEquipos.Margin = new Padding(3, 2, 3, 2);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(164, 30);
            btnEquipos.TabIndex = 1;
            btnEquipos.Text = "Gestión de equipos";
            btnEquipos.UseVisualStyleBackColor = false;
            btnEquipos.Click += button1_Click;
            // 
            // btnEntrenadores
            // 
            btnEntrenadores.BackColor = Color.Green;
            btnEntrenadores.Cursor = Cursors.Hand;
            btnEntrenadores.ForeColor = Color.Snow;
            btnEntrenadores.Location = new Point(455, 139);
            btnEntrenadores.Margin = new Padding(3, 2, 3, 2);
            btnEntrenadores.Name = "btnEntrenadores";
            btnEntrenadores.Size = new Size(164, 30);
            btnEntrenadores.TabIndex = 2;
            btnEntrenadores.Text = "Gestión de entrenadores";
            btnEntrenadores.UseVisualStyleBackColor = false;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = Color.Green;
            btnJugadores.Cursor = Cursors.Hand;
            btnJugadores.ForeColor = Color.Snow;
            btnJugadores.Location = new Point(71, 270);
            btnJugadores.Margin = new Padding(3, 2, 3, 2);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(164, 30);
            btnJugadores.TabIndex = 4;
            btnJugadores.Text = "Gestión de jugadores";
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += button3_Click;
            // 
            // btnPosiciones
            // 
            btnPosiciones.BackColor = Color.Green;
            btnPosiciones.Cursor = Cursors.Hand;
            btnPosiciones.ForeColor = Color.Snow;
            btnPosiciones.Location = new Point(455, 270);
            btnPosiciones.Margin = new Padding(3, 2, 3, 2);
            btnPosiciones.Name = "btnPosiciones";
            btnPosiciones.Size = new Size(164, 30);
            btnPosiciones.TabIndex = 5;
            btnPosiciones.Text = "Gestión de posiciones";
            btnPosiciones.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(455, 51);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 83);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(455, 183);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 82);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(71, 183);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 82);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(71, 51);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(164, 82);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = Properties.Resources.Menu;
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.Location = new Point(640, 12);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(48, 45);
            BtnMenu.TabIndex = 10;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmModuloEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnPosiciones);
            Controls.Add(btnJugadores);
            Controls.Add(btnEntrenadores);
            Controls.Add(btnEquipos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmModuloEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo de Equipos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEquipos;
        private Button btnEntrenadores;
        private Button btnJugadores;
        private Button btnPosiciones;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button BtnMenu;
    }
}