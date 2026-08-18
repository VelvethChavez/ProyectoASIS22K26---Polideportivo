namespace SistemaDePolideportivo
{
    partial class FrmLoginArbitro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginArbitro));
            Lbl1 = new Label();
            Btn1 = new Button();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            Btn2 = new Button();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.ForeColor = Color.DarkBlue;
            Lbl1.Location = new Point(137, 77);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(165, 28);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Login Arbitro";
            Lbl1.Click += Lbl1_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.DarkBlue;
            Btn1.Cursor = Cursors.Hand;
            Btn1.Font = new Font("Arial Rounded MT Bold", 10F);
            Btn1.ForeColor = SystemColors.ControlLightLight;
            Btn1.Location = new Point(173, 328);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(104, 34);
            Btn1.TabIndex = 1;
            Btn1.Text = "Iniciar Sesión";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(57, 166);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(70, 17);
            Lbl2.TabIndex = 3;
            Lbl2.Text = "Usuario:";
            Lbl2.Click += Lbl2_Click;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(57, 221);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(98, 17);
            Lbl3.TabIndex = 4;
            Lbl3.Text = "Contraseña:";
            // 
            // Txt1
            // 
            Txt1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Txt1.Location = new Point(173, 166);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(168, 25);
            Txt1.TabIndex = 5;
            // 
            // Txt2
            // 
            Txt2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Txt2.Location = new Point(173, 220);
            Txt2.Name = "Txt2";
            Txt2.PasswordChar = '*';
            Txt2.Size = new Size(168, 25);
            Txt2.TabIndex = 6;
            // 
            // Btn2
            // 
            Btn2.BackgroundImage = (Image)resources.GetObject("Btn2.BackgroundImage");
            Btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Btn2.Cursor = Cursors.Hand;
            Btn2.Location = new Point(12, 12);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(43, 41);
            Btn2.TabIndex = 7;
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // FrmLoginArbitro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 424);
            Controls.Add(Btn2);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Btn1);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLoginArbitro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Arbitro";
            Load += FrmLoginArbitro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Button Btn1;
        private Label Lbl2;
        private Label Lbl3;
        private TextBox Txt1;
        private TextBox Txt2;
        private Button Btn2;
    }
}