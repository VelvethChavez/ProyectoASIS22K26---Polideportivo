namespace SistemaDePolideportivo
{
    partial class frmCompeticiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompeticiones));
            USUARIOS = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCompetencias = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            BtnMenu = new Button();
            SuspendLayout();
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.Location = new Point(108, 44);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(70, 22);
            USUARIOS.TabIndex = 7;
            USUARIOS.Text = "CAMPO";
            USUARIOS.Click += USUARIOS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(514, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 8;
            label1.Text = "ARBITRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 220);
            label3.Name = "label3";
            label3.Size = new Size(214, 22);
            label3.TabIndex = 10;
            label3.Text = "ESTADO DE PARTIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 220);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 11;
            label4.Text = "JORNADA";
            label4.Click += label4_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompetencias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCompetencias.BackColor = Color.RoyalBlue;
            btnCompetencias.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCompetencias.Font = new Font("Microsoft Sans Serif", 12F);
            btnCompetencias.ForeColor = SystemColors.ControlLightLight;
            btnCompetencias.Location = new Point(73, 82);
            btnCompetencias.Margin = new Padding(0);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(164, 44);
            btnCompetencias.TabIndex = 12;
            btnCompetencias.Text = "Campo";
            btnCompetencias.UseVisualStyleBackColor = false;
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(73, 254);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(164, 44);
            button1.TabIndex = 13;
            button1.Text = "Jornada";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.RoyalBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.Font = new Font("Microsoft Sans Serif", 12F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(481, 82);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(164, 44);
            button3.TabIndex = 15;
            button3.Text = "Arbitro";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.Font = new Font("Microsoft Sans Serif", 12F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(481, 254);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(164, 44);
            button4.TabIndex = 16;
            button4.Text = "Estado Partido";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(12, 12);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(52, 45);
            BtnMenu.TabIndex = 17;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmCompeticiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnCompetencias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(USUARIOS);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCompeticiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCompeticiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label USUARIOS;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnCompetencias;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button BtnMenu;
    }
}