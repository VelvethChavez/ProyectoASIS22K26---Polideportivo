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
            label1.Location = new Point(289, 21);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 0;
            label1.Text = "Modulo de equipos";
            label1.Click += label1_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Location = new Point(81, 185);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(188, 29);
            btnEquipos.TabIndex = 1;
            btnEquipos.Text = "Gestión de equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += button1_Click;
            // 
            // btnEntrenadores
            // 
            btnEntrenadores.Location = new Point(520, 185);
            btnEntrenadores.Name = "btnEntrenadores";
            btnEntrenadores.Size = new Size(188, 29);
            btnEntrenadores.TabIndex = 2;
            btnEntrenadores.Text = "Gestión de entrenadores";
            btnEntrenadores.UseVisualStyleBackColor = true;
            // 
            // btnJugadores
            // 
            btnJugadores.Location = new Point(81, 360);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(188, 29);
            btnJugadores.TabIndex = 4;
            btnJugadores.Text = "Gestión de jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += button3_Click;
            // 
            // btnPosiciones
            // 
            btnPosiciones.Location = new Point(520, 360);
            btnPosiciones.Name = "btnPosiciones";
            btnPosiciones.Size = new Size(188, 29);
            btnPosiciones.TabIndex = 5;
            btnPosiciones.Text = "Gestión de posiciones";
            btnPosiciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(520, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 111);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(520, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 110);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(81, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 110);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(81, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 110);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // frmModuloEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnPosiciones);
            Controls.Add(btnJugadores);
            Controls.Add(btnEntrenadores);
            Controls.Add(btnEquipos);
            Controls.Add(label1);
            Name = "frmModuloEquipos";
            Text = "frmModuloEquipos";
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
    }
}