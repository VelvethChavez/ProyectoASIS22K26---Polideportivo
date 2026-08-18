namespace SistemaDePolideportivo
{
    partial class FrmRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRol));
            Pnl1 = new Panel();
            DgvRoles = new DataGridView();
            TxtDescripcionrol = new TextBox();
            TxtNombrerol = new TextBox();
            Lbl4 = new Label();
            Lbl3 = new Label();
            Lbl2 = new Label();
            Pic1 = new PictureBox();
            Lbl1 = new Label();
            BtnNuevo = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            SuspendLayout();
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(DgvRoles);
            Pnl1.Controls.Add(TxtDescripcionrol);
            Pnl1.Controls.Add(TxtNombrerol);
            Pnl1.Controls.Add(Lbl4);
            Pnl1.Controls.Add(Lbl3);
            Pnl1.Controls.Add(Lbl2);
            Pnl1.Controls.Add(Pic1);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Controls.Add(BtnNuevo);
            Pnl1.Controls.Add(BtnLimpiar);
            Pnl1.Controls.Add(BtnEliminar);
            Pnl1.Controls.Add(BtnEditar);
            Pnl1.Controls.Add(BtnGuardar);
            Pnl1.Location = new Point(-1, -1);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(898, 538);
            Pnl1.TabIndex = 0;
            Pnl1.Click += FrmRol_Load;
            // 
            // DgvRoles
            // 
            DgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRoles.Location = new Point(57, 310);
            DgvRoles.Name = "DgvRoles";
            DgvRoles.RowHeadersWidth = 51;
            DgvRoles.RowTemplate.Height = 24;
            DgvRoles.Size = new Size(405, 183);
            DgvRoles.TabIndex = 28;
            // 
            // TxtDescripcionrol
            // 
            TxtDescripcionrol.BorderStyle = BorderStyle.FixedSingle;
            TxtDescripcionrol.Font = new Font("Bell MT", 9F);
            TxtDescripcionrol.Location = new Point(196, 178);
            TxtDescripcionrol.Multiline = true;
            TxtDescripcionrol.Name = "TxtDescripcionrol";
            TxtDescripcionrol.Size = new Size(292, 102);
            TxtDescripcionrol.TabIndex = 27;
            TxtDescripcionrol.Text = "Ingrese descripcion de rol";
            // 
            // TxtNombrerol
            // 
            TxtNombrerol.BorderStyle = BorderStyle.FixedSingle;
            TxtNombrerol.Font = new Font("Bell MT", 9F);
            TxtNombrerol.Location = new Point(196, 121);
            TxtNombrerol.Name = "TxtNombrerol";
            TxtNombrerol.Size = new Size(168, 21);
            TxtNombrerol.TabIndex = 26;
            TxtNombrerol.Text = "Ingrese el rol";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl4.Location = new Point(11, 176);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(144, 19);
            Lbl4.TabIndex = 25;
            Lbl4.Text = "Descripcion de rol:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl3.Location = new Point(11, 121);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(117, 19);
            Lbl3.TabIndex = 24;
            Lbl3.Text = "Nombre de rol:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl2.Location = new Point(11, 81);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(97, 19);
            Lbl2.TabIndex = 23;
            Lbl2.Text = "Datos de rol";
            // 
            // Pic1
            // 
            Pic1.BackColor = Color.Transparent;
            Pic1.BackgroundImageLayout = ImageLayout.Center;
            Pic1.Image = (Image)resources.GetObject("Pic1.Image");
            Pic1.Location = new Point(11, 16);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(40, 49);
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic1.TabIndex = 22;
            Pic1.TabStop = false;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F);
            Lbl1.Location = new Point(51, 16);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(63, 33);
            Lbl1.TabIndex = 21;
            Lbl1.Text = "Roles";
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.Transparent;
            BtnNuevo.BackgroundImage = (Image)resources.GetObject("BtnNuevo.BackgroundImage");
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(805, 286);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(58, 63);
            BtnNuevo.TabIndex = 20;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Transparent;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLimpiar.Location = new Point(805, 218);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(58, 63);
            BtnLimpiar.TabIndex = 19;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Transparent;
            BtnEliminar.BackgroundImage = (Image)resources.GetObject("BtnEliminar.BackgroundImage");
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Location = new Point(805, 149);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 63);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.BackgroundImage = (Image)resources.GetObject("BtnEditar.BackgroundImage");
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Location = new Point(805, 81);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 63);
            BtnEditar.TabIndex = 17;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Location = new Point(805, 12);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 63);
            BtnGuardar.TabIndex = 16;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FrmRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 537);
            Controls.Add(Pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRol";
            Load += FrmRol_Load;
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.DataGridView DgvRoles;
        private System.Windows.Forms.TextBox TxtDescripcionrol;
        private System.Windows.Forms.TextBox TxtNombrerol;
        private System.Windows.Forms.Button BtnEliminar;
    }
}