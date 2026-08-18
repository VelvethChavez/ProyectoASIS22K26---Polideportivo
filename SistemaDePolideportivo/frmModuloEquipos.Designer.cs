namespace SistemaDePolideportivo
{
    partial class FrmModuloEquipos
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
            Lbl1 = new Label();
            BtnEquipos = new Button();
            BtnEntrenadores = new Button();
            BtnJugadores = new Button();
            BtnPosiciones = new Button();
            Pic1 = new PictureBox();
            Pic2 = new PictureBox();
            Pic3 = new PictureBox();
            Pic4 = new PictureBox();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic4).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 14F);
            Lbl1.Location = new Point(253, 16);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(176, 25);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Modulo de equipos";
            Lbl1.Click += Lbl1_Click;
            // 
            // BtnEquipos
            // 
            BtnEquipos.BackColor = Color.Green;
            BtnEquipos.Cursor = Cursors.Hand;
            BtnEquipos.ForeColor = Color.Snow;
            BtnEquipos.Location = new Point(71, 139);
            BtnEquipos.Margin = new Padding(3, 2, 3, 2);
            BtnEquipos.Name = "BtnEquipos";
            BtnEquipos.Size = new Size(164, 30);
            BtnEquipos.TabIndex = 1;
            BtnEquipos.Text = "Gestión de equipos";
            BtnEquipos.UseVisualStyleBackColor = false;
            BtnEquipos.Click += BtnEquipos_Click_1;
            // 
            // BtnEntrenadores
            // 
            BtnEntrenadores.BackColor = Color.Green;
            BtnEntrenadores.Cursor = Cursors.Hand;
            BtnEntrenadores.ForeColor = Color.Snow;
            BtnEntrenadores.Location = new Point(455, 139);
            BtnEntrenadores.Margin = new Padding(3, 2, 3, 2);
            BtnEntrenadores.Name = "BtnEntrenadores";
            BtnEntrenadores.Size = new Size(164, 30);
            BtnEntrenadores.TabIndex = 2;
            BtnEntrenadores.Text = "Gestión de entrenadores";
            BtnEntrenadores.UseVisualStyleBackColor = false;
            // 
            // BtnJugadores
            // 
            BtnJugadores.BackColor = Color.Green;
            BtnJugadores.Cursor = Cursors.Hand;
            BtnJugadores.ForeColor = Color.Snow;
            BtnJugadores.Location = new Point(71, 270);
            BtnJugadores.Margin = new Padding(3, 2, 3, 2);
            BtnJugadores.Name = "BtnJugadores";
            BtnJugadores.Size = new Size(164, 30);
            BtnJugadores.TabIndex = 4;
            BtnJugadores.Text = "Gestión de jugadores";
            BtnJugadores.UseVisualStyleBackColor = false;
            BtnJugadores.Click += BtnJugadores_Click_1;
            // 
            // BtnPosiciones
            // 
            BtnPosiciones.BackColor = Color.Green;
            BtnPosiciones.Cursor = Cursors.Hand;
            BtnPosiciones.ForeColor = Color.Snow;
            BtnPosiciones.Location = new Point(455, 270);
            BtnPosiciones.Margin = new Padding(3, 2, 3, 2);
            BtnPosiciones.Name = "BtnPosiciones";
            BtnPosiciones.Size = new Size(164, 30);
            BtnPosiciones.TabIndex = 5;
            BtnPosiciones.Text = "Gestión de posiciones";
            BtnPosiciones.UseVisualStyleBackColor = false;
            // 
            // Pic1
            // 
            Pic1.Location = new Point(455, 51);
            Pic1.Margin = new Padding(3, 2, 3, 2);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(164, 83);
            Pic1.TabIndex = 6;
            Pic1.TabStop = false;
            // 
            // Pic2
            // 
            Pic2.Location = new Point(455, 183);
            Pic2.Margin = new Padding(3, 2, 3, 2);
            Pic2.Name = "Pic2";
            Pic2.Size = new Size(164, 82);
            Pic2.TabIndex = 7;
            Pic2.TabStop = false;
            // 
            // Pic3
            // 
            Pic3.Location = new Point(71, 183);
            Pic3.Margin = new Padding(3, 2, 3, 2);
            Pic3.Name = "Pic3";
            Pic3.Size = new Size(164, 82);
            Pic3.TabIndex = 8;
            Pic3.TabStop = false;
            // 
            // Pic4
            // 
            Pic4.Location = new Point(71, 51);
            Pic4.Margin = new Padding(3, 2, 3, 2);
            Pic4.Name = "Pic4";
            Pic4.Size = new Size(164, 82);
            Pic4.TabIndex = 9;
            Pic4.TabStop = false;
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
            // FrmModuloEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
            Controls.Add(Pic4);
            Controls.Add(Pic3);
            Controls.Add(Pic2);
            Controls.Add(Pic1);
            Controls.Add(BtnPosiciones);
            Controls.Add(BtnJugadores);
            Controls.Add(BtnEntrenadores);
            Controls.Add(BtnEquipos);
            Controls.Add(Lbl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmModuloEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo de Equipos";
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Button BtnEquipos;
        private Button BtnEntrenadores;
        private Button BtnJugadores;
        private Button BtnPosiciones;
        private PictureBox Pic1;
        private PictureBox Pic2;
        private PictureBox Pic3;
        private PictureBox Pic4;
        private Button BtnMenu;
    }
}