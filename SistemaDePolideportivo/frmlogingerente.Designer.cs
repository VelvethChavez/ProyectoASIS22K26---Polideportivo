namespace SistemaDePolideportivo
{
    partial class FrmLoginGerente
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginGerente));
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            Btn1 = new Button();
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.ForeColor = Color.DarkBlue;
            Lbl1.Location = new Point(114, 75);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(155, 24);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Login Gerente";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Lbl2.Location = new Point(66, 166);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(70, 17);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Usuario:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Lbl3.Location = new Point(66, 202);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(98, 17);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Contraseña:";
            // 
            // Txt1
            // 
            Txt1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Txt1.Location = new Point(170, 165);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(170, 25);
            Txt1.TabIndex = 3;
            // 
            // Txt2
            // 
            Txt2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Txt2.Location = new Point(170, 201);
            Txt2.Name = "Txt2";
            Txt2.PasswordChar = '*';
            Txt2.Size = new Size(170, 25);
            Txt2.TabIndex = 4;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.DarkBlue;
            Btn1.Cursor = Cursors.Hand;
            Btn1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Btn1.ForeColor = Color.WhiteSmoke;
            Btn1.Location = new Point(132, 293);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(111, 39);
            Btn1.TabIndex = 5;
            Btn1.Text = "Iniciar Sesión";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.Location = new Point(19, 22);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(41, 39);
            BtnRegresar.TabIndex = 6;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // FrmLoginGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 399);
            Controls.Add(BtnRegresar);
            Controls.Add(Btn1);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLoginGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Gerente";
            Load += FrmLoginGerente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private TextBox Txt1;
        private TextBox Txt2;
        private Button Btn1;
        private Button BtnRegresar;
    }
}