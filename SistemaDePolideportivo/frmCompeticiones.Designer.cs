namespace SistemaDePolideportivo
{
    partial class FrmCompeticiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompeticiones));
            LblUSUARIOS = new Label();
            Lbl1 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            BtnCompetencias = new Button();
            Btn1 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn2 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Lbl2 = new Label();
            Lbl5 = new Label();
            Lbl6 = new Label();
            BtnMenu = new Button();
            SuspendLayout();
            // 
            // LblUSUARIOS
            // 
            LblUSUARIOS.AutoSize = true;
            LblUSUARIOS.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUSUARIOS.Location = new Point(304, 140);
            LblUSUARIOS.Name = "LblUSUARIOS";
            LblUSUARIOS.Size = new Size(87, 28);
            LblUSUARIOS.TabIndex = 7;
            LblUSUARIOS.Text = "CAMPO";
            LblUSUARIOS.Click += LblUSUARIOS_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(603, 29);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(117, 28);
            Lbl1.TabIndex = 8;
            Lbl1.Text = "ARBITRO";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(532, 140);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(267, 28);
            Lbl3.TabIndex = 10;
            Lbl3.Text = "ESTADO DE PARTIDO";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(65, 140);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(117, 28);
            Lbl4.TabIndex = 11;
            Lbl4.Text = "JORNADA";
            Lbl4.Click += Lbl4_Click;
            // 
            // BtnCompetencias
            // 
            BtnCompetencias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnCompetencias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCompetencias.BackColor = Color.RoyalBlue;
            BtnCompetencias.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnCompetencias.Font = new Font("Microsoft Sans Serif", 12F);
            BtnCompetencias.ForeColor = SystemColors.ControlLightLight;
            BtnCompetencias.Location = new Point(255, 182);
            BtnCompetencias.Margin = new Padding(0);
            BtnCompetencias.Name = "BtnCompetencias";
            BtnCompetencias.Size = new Size(187, 59);
            BtnCompetencias.TabIndex = 12;
            BtnCompetencias.Text = "Campo";
            BtnCompetencias.UseVisualStyleBackColor = false;
            BtnCompetencias.Click += BtnCompetencias_Click;
            // 
            // Btn1
            // 
            Btn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn1.BackColor = Color.RoyalBlue;
            Btn1.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn1.Font = new Font("Microsoft Sans Serif", 12F);
            Btn1.ForeColor = SystemColors.ControlLightLight;
            Btn1.Location = new Point(30, 182);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(187, 59);
            Btn1.TabIndex = 13;
            Btn1.Text = "Jornada";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Btn3
            // 
            Btn3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn3.BackColor = Color.RoyalBlue;
            Btn3.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn3.Font = new Font("Microsoft Sans Serif", 12F);
            Btn3.ForeColor = SystemColors.ControlLightLight;
            Btn3.Location = new Point(570, 69);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(187, 59);
            Btn3.TabIndex = 15;
            Btn3.Text = "Arbitro";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // Btn4
            // 
            Btn4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn4.BackColor = Color.RoyalBlue;
            Btn4.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn4.Font = new Font("Microsoft Sans Serif", 12F);
            Btn4.ForeColor = SystemColors.ControlLightLight;
            Btn4.Location = new Point(570, 182);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(187, 59);
            Btn4.TabIndex = 16;
            Btn4.Text = "Estado Partido";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += Btn4_Click;
            // 
            // Btn2
            // 
            Btn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2.BackColor = Color.RoyalBlue;
            Btn2.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn2.Font = new Font("Microsoft Sans Serif", 12F);
            Btn2.ForeColor = SystemColors.ControlLightLight;
            Btn2.Location = new Point(570, 316);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(187, 60);
            Btn2.TabIndex = 24;
            Btn2.Text = "Tabla de Posiciones";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click_1;
            // 
            // Btn5
            // 
            Btn5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn5.BackColor = Color.RoyalBlue;
            Btn5.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn5.Font = new Font("Microsoft Sans Serif", 12F);
            Btn5.ForeColor = SystemColors.ControlLightLight;
            Btn5.Location = new Point(255, 316);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(187, 59);
            Btn5.TabIndex = 23;
            Btn5.Text = "Registrar Resultados";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn6.BackColor = Color.RoyalBlue;
            Btn6.FlatAppearance.MouseDownBackColor = Color.Black;
            Btn6.Font = new Font("Microsoft Sans Serif", 12F);
            Btn6.ForeColor = SystemColors.ControlLightLight;
            Btn6.Location = new Point(255, 69);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(187, 59);
            Btn6.TabIndex = 22;
            Btn6.Text = "Programar Partido";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += Btn6_Click;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(211, 29);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(267, 28);
            Lbl2.TabIndex = 20;
            Lbl2.Text = "PROGRAMAR PARTIDO";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl5.Location = new Point(502, 275);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(297, 28);
            Lbl5.TabIndex = 19;
            Lbl5.Text = "TABLA DE POSICIONES";
            // 
            // Lbl6
            // 
            Lbl6.AutoSize = true;
            Lbl6.Font = new Font("MS Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl6.Location = new Point(166, 275);
            Lbl6.Name = "Lbl6";
            Lbl6.Size = new Size(312, 28);
            Lbl6.TabIndex = 18;
            Lbl6.Text = "REGISTRAR RESULTADOS";
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
            // FrmCompeticiones
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            Controls.Add(Btn2);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(Lbl2);
            Controls.Add(Lbl5);
            Controls.Add(Lbl6);
            Controls.Add(BtnMenu);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn1);
            Controls.Add(BtnCompetencias);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl1);
            Controls.Add(LblUSUARIOS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompeticiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompeticiones";
            Load += FrmCompeticiones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUSUARIOS;
        private Label Lbl1;
        private Label Lbl3;
        private Label Lbl4;
        private Button BtnCompetencias;
        private Button Btn1;
        private Button Btn3;
        private Button Btn4;

        private Button Btn2;
        private Button Btn5;
        private Button Btn6;
        private Label Lbl2;
        private Label Lbl5;
        private Label Lbl6;

        private Button BtnMenu;

    }
}