namespace SistemaDePolideportivo
{
    partial class FrmDeportes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeportes));
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            TxtNombreDeporte = new TextBox();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            RtbDescripcion = new RichTextBox();
            Dgv1 = new DataGridView();
            Pnl1 = new Panel();
            BtnRegresar = new Button();
            BtnNuevo = new Button();
            Lbl5 = new Label();
            Lbl4 = new Label();
            Pic1 = new PictureBox();
            SqlCmd1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.BackColor = Color.Transparent;
            Lbl1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.ForeColor = Color.Black;
            Lbl1.Location = new Point(58, 13);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(95, 33);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Deportes";
            Lbl1.Click += Lbl1_Click;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(27, 53);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(0, 15);
            Lbl2.TabIndex = 1;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.BackColor = Color.Transparent;
            Lbl3.Cursor = Cursors.No;
            Lbl3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl3.ForeColor = Color.Black;
            Lbl3.Location = new Point(15, 67);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(137, 19);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Datos del deporte";
            // 
            // TxtNombreDeporte
            // 
            TxtNombreDeporte.BorderStyle = BorderStyle.FixedSingle;
            TxtNombreDeporte.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombreDeporte.Location = new Point(182, 109);
            TxtNombreDeporte.Name = "TxtNombreDeporte";
            TxtNombreDeporte.Size = new Size(183, 21);
            TxtNombreDeporte.TabIndex = 4;
            TxtNombreDeporte.Text = "Ingrese nombre del deporte";
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            BtnGuardar.ImageAlign = ContentAlignment.TopCenter;
            BtnGuardar.Location = new Point(614, 22);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 50);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(614, 83);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 47);
            BtnEditar.TabIndex = 9;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(614, 138);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 47);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // RtbDescripcion
            // 
            RtbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            RtbDescripcion.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtbDescripcion.Location = new Point(182, 152);
            RtbDescripcion.Name = "RtbDescripcion";
            RtbDescripcion.Size = new Size(292, 83);
            RtbDescripcion.TabIndex = 12;
            RtbDescripcion.Text = "Ingresa descripción";
            // 
            // Dgv1
            // 
            Dgv1.AllowUserToResizeRows = false;
            Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv1.Location = new Point(94, 269);
            Dgv1.MultiSelect = false;
            Dgv1.Name = "Dgv1";
            Dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv1.Size = new Size(492, 150);
            Dgv1.TabIndex = 13;
            Dgv1.CellClick += Dgv1_CellClick;
            Dgv1.CellContentClick += Dgv1_CellContentClick;
            // 
            // Pnl1
            // 
            Pnl1.BackColor = Color.White;
            Pnl1.Controls.Add(BtnRegresar);
            Pnl1.Controls.Add(BtnNuevo);
            Pnl1.Controls.Add(Lbl5);
            Pnl1.Controls.Add(Lbl4);
            Pnl1.Controls.Add(Pic1);
            Pnl1.Controls.Add(Dgv1);
            Pnl1.Controls.Add(Lbl3);
            Pnl1.Controls.Add(TxtNombreDeporte);
            Pnl1.Controls.Add(RtbDescripcion);
            Pnl1.Controls.Add(BtnEliminar);
            Pnl1.Controls.Add(Lbl1);
            Pnl1.Controls.Add(BtnEditar);
            Pnl1.Controls.Add(BtnGuardar);
            Pnl1.Location = new Point(-3, -4);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(694, 455);
            Pnl1.TabIndex = 14;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.Location = new Point(15, 381);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(40, 38);
            BtnRegresar.TabIndex = 19;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(614, 200);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(58, 47);
            BtnNuevo.TabIndex = 18;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.BackColor = Color.Transparent;
            Lbl5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl5.ForeColor = Color.Black;
            Lbl5.Location = new Point(15, 152);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(103, 19);
            Lbl5.TabIndex = 16;
            Lbl5.Text = "Descripción: \r\n";
            Lbl5.Click += Lbl5_Click;
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.BackColor = Color.Transparent;
            Lbl4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            Lbl4.ForeColor = Color.Black;
            Lbl4.Location = new Point(15, 110);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(161, 19);
            Lbl4.TabIndex = 15;
            Lbl4.Text = "Nombre del deporte: \r\n";
            Lbl4.Click += Lbl4_Click_1;
            // 
            // Pic1
            // 
            Pic1.BackColor = Color.Transparent;
            Pic1.BackgroundImageLayout = ImageLayout.Center;
            Pic1.Image = Properties.Resources.pelota;
            Pic1.Location = new Point(15, 13);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(40, 39);
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic1.TabIndex = 14;
            Pic1.TabStop = false;
            // 
            // SqlCmd1
            // 
            SqlCmd1.CacheAge = 0;
            SqlCmd1.Connection = null;
            SqlCmd1.EnableCaching = false;
            SqlCmd1.Transaction = null;
            // 
            // FrmDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 440);
            Controls.Add(Lbl2);
            Controls.Add(Pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDeportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deportes";
            FormClosed += Deportes_FormClosed;
            Load += Deportes_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            Pnl1.ResumeLayout(false);
            Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private TextBox TxtNombreDeporte;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private RichTextBox RtbDescripcion;
        private DataGridView Dgv1;
        private Panel Pnl1;
        private PictureBox Pic1;
        private Label Lbl4;
        private Label Lbl5;
        private MySql.Data.MySqlClient.MySqlCommand SqlCmd1;
        private Button BtnNuevo;
        private Button BtnRegresar;
    }
}