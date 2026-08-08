namespace SistemaDePolideportivo
{
    partial class frmCampeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampeonato));
            panel1 = new Panel();
            BtnMenu = new Button();
            BtnEstados = new Button();
            BtnTipoCampeonato = new Button();
            BtnDeportes = new Button();
            dataGridView1 = new DataGridView();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBoxtipoCampeonato = new ComboBox();
            ComboBoxDeporte = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateInicio = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(BtnEstados);
            panel1.Controls.Add(BtnTipoCampeonato);
            panel1.Controls.Add(BtnDeportes);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBoxtipoCampeonato);
            panel1.Controls.Add(ComboBoxDeporte);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateInicio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 737);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(525, 96);
            BtnMenu.Margin = new Padding(3, 4, 3, 4);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(66, 63);
            BtnMenu.TabIndex = 23;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // BtnEstados
            // 
            BtnEstados.BackColor = Color.FromArgb(255, 128, 128);
            BtnEstados.Cursor = Cursors.Hand;
            BtnEstados.FlatStyle = FlatStyle.Flat;
            BtnEstados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnEstados.ForeColor = Color.White;
            BtnEstados.Location = new Point(447, 28);
            BtnEstados.Margin = new Padding(3, 4, 3, 4);
            BtnEstados.Name = "BtnEstados";
            BtnEstados.Size = new Size(86, 39);
            BtnEstados.TabIndex = 22;
            BtnEstados.Text = "Estados";
            BtnEstados.UseVisualStyleBackColor = false;
            BtnEstados.Click += BtnEstados_Click;
            // 
            // BtnTipoCampeonato
            // 
            BtnTipoCampeonato.BackColor = Color.RoyalBlue;
            BtnTipoCampeonato.Cursor = Cursors.Hand;
            BtnTipoCampeonato.FlatStyle = FlatStyle.Flat;
            BtnTipoCampeonato.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTipoCampeonato.ForeColor = SystemColors.Info;
            BtnTipoCampeonato.Location = new Point(539, 28);
            BtnTipoCampeonato.Margin = new Padding(3, 4, 3, 4);
            BtnTipoCampeonato.Name = "BtnTipoCampeonato";
            BtnTipoCampeonato.Size = new Size(184, 39);
            BtnTipoCampeonato.TabIndex = 21;
            BtnTipoCampeonato.Text = "Tipo de Campeonato";
            BtnTipoCampeonato.UseVisualStyleBackColor = false;
            BtnTipoCampeonato.Click += BtnTipoCampeonato_Click;
            // 
            // BtnDeportes
            // 
            BtnDeportes.BackColor = Color.ForestGreen;
            BtnDeportes.Cursor = Cursors.Hand;
            BtnDeportes.FlatStyle = FlatStyle.Flat;
            BtnDeportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeportes.ForeColor = SystemColors.Info;
            BtnDeportes.Location = new Point(327, 28);
            BtnDeportes.Margin = new Padding(3, 4, 3, 4);
            BtnDeportes.Name = "BtnDeportes";
            BtnDeportes.Size = new Size(107, 39);
            BtnDeportes.TabIndex = 20;
            BtnDeportes.Text = "Deportes";
            BtnDeportes.UseVisualStyleBackColor = false;
            BtnDeportes.Click += BtnDeportes_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 461);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(629, 231);
            dataGridView1.TabIndex = 19;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.limpiar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(610, 265);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 67);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += button3_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(610, 183);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 67);
            BtnEditar.TabIndex = 17;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += button2_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(610, 347);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 67);
            BtnNuevo.TabIndex = 16;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += button1_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(610, 96);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label8.Location = new Point(327, 349);
            label8.Name = "label8";
            label8.Size = new Size(220, 24);
            label8.TabIndex = 14;
            label8.Text = "Estado del campeonato:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label7.Location = new Point(327, 256);
            label7.Name = "label7";
            label7.Size = new Size(196, 24);
            label7.TabIndex = 13;
            label7.Text = "Tipo de campeonato:";
            label7.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Bell MT", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(327, 379);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 27);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Seleccione un estado";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBoxtipoCampeonato
            // 
            comboBoxtipoCampeonato.Font = new Font("Bell MT", 9F);
            comboBoxtipoCampeonato.FormattingEnabled = true;
            comboBoxtipoCampeonato.Location = new Point(327, 285);
            comboBoxtipoCampeonato.Margin = new Padding(3, 4, 3, 4);
            comboBoxtipoCampeonato.Name = "comboBoxtipoCampeonato";
            comboBoxtipoCampeonato.Size = new Size(191, 27);
            comboBoxtipoCampeonato.TabIndex = 11;
            comboBoxtipoCampeonato.Text = "Seleccione un tipo";
            comboBoxtipoCampeonato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ComboBoxDeporte
            // 
            ComboBoxDeporte.Font = new Font("Bell MT", 9F);
            ComboBoxDeporte.FormattingEnabled = true;
            ComboBoxDeporte.Location = new Point(327, 195);
            ComboBoxDeporte.Margin = new Padding(3, 4, 3, 4);
            ComboBoxDeporte.Name = "ComboBoxDeporte";
            ComboBoxDeporte.Size = new Size(191, 27);
            ComboBoxDeporte.TabIndex = 10;
            ComboBoxDeporte.Text = "Seleccione un deporte";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label6.Location = new Point(327, 165);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 9;
            label6.Text = "Deporte: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Bell MT", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(24, 381);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 24);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 352);
            label5.Name = "label5";
            label5.Size = new Size(112, 24);
            label5.TabIndex = 7;
            label5.Text = "Fecha final:";
            label5.Click += label5_Click;
            // 
            // dateInicio
            // 
            dateInicio.Font = new Font("Bell MT", 9F);
            dateInicio.Format = DateTimePickerFormat.Custom;
            dateInicio.Location = new Point(24, 285);
            dateInicio.Margin = new Padding(3, 4, 3, 4);
            dateInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateInicio.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(111, 24);
            dateInicio.TabIndex = 6;
            dateInicio.ValueChanged += dateInicio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(19, 256);
            label4.Name = "label4";
            label4.Size = new Size(147, 24);
            label4.TabIndex = 5;
            label4.Text = "Fecha de inicio:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bell MT", 9F);
            textBox1.Location = new Point(24, 195);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 24);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ingrese nombre del campeonato";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(19, 165);
            label3.Name = "label3";
            label3.Size = new Size(230, 24);
            label3.TabIndex = 3;
            label3.Text = "Nombre del campeonato:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(207, 24);
            label2.TabIndex = 2;
            label2.Text = "Datos del campeonato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(77, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 1;
            label1.Text = "Campeonato";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // frmCampeonato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 731);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCampeonato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campeonato";
            Load += frmCampeonato_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateInicio;
        private DateTimePicker dateTimePicker1;
        private ComboBox ComboBoxDeporte;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBoxtipoCampeonato;
        private Label label8;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button BtnGuardar;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dataGridView1;
        private Button BtnDeportes;
        private Button BtnTipoCampeonato;
        private Button BtnEstados;
        private Button BtnMenu;
    }
}