namespace SistemaDePolideportivo
{
    partial class frmCompeticiones
    {
        
        private System.ComponentModel.IContainer components = null;

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
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnMenu = new Button();
            SuspendLayout();
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.Location = new Point(304, 140);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(87, 28);
            USUARIOS.TabIndex = 7;
            USUARIOS.Text = "CAMPO";
            USUARIOS.Click += USUARIOS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 29);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 8;
            label1.Text = "ARBITRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(532, 140);
            label3.Name = "label3";
            label3.Size = new Size(267, 28);
            label3.TabIndex = 10;
            label3.Text = "ESTADO DE PARTIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 140);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
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
            btnCompetencias.Location = new Point(255, 182);
            btnCompetencias.Margin = new Padding(0);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(187, 59);
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
            button1.Location = new Point(30, 182);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(187, 59);
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
            button3.Location = new Point(570, 69);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(187, 59);
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
            button4.Location = new Point(570, 182);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(187, 59);
            button4.TabIndex = 16;
            button4.Text = "Estado Partido";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(570, 316);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(187, 60);
            button2.TabIndex = 24;
            button2.Text = "Tabla de Posiciones";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.RoyalBlue;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.Font = new Font("Microsoft Sans Serif", 12F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(244, 316);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(187, 59);
            button5.TabIndex = 23;
            button5.Text = "Registrar Resultados";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.RoyalBlue;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.Font = new Font("Microsoft Sans Serif", 12F);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(255, 69);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(187, 59);
            button6.TabIndex = 22;
            button6.Text = "Programar Partido";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 29);
            label2.Name = "label2";
            label2.Size = new Size(267, 28);
            label2.TabIndex = 20;
            label2.Text = "PROGRAMAR PARTIDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(502, 275);
            label5.Name = "label5";
            label5.Size = new Size(297, 28);
            label5.TabIndex = 19;
            label5.Text = "TABLA DE POSICIONES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(166, 275);
            label6.Name = "label6";
            label6.Size = new Size(312, 28);
            label6.TabIndex = 18;
            label6.Text = "REGISTRAR RESULTADOS";
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(14, 16);
            BtnMenu.Margin = new Padding(3, 4, 3, 4);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(59, 60);
            BtnMenu.TabIndex = 17;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmCompeticiones
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(BtnMenu);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnCompetencias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(USUARIOS);
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

        private Button button2;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label5;
        private Label label6;

        private Button BtnMenu;

    }
}