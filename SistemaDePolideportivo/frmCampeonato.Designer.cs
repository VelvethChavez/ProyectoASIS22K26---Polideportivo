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
            BtnMenu = new Button();
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
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 553);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnEstados
            // 
            BtnEstados.BackColor = Color.FromArgb(255, 128, 128);
            BtnEstados.Cursor = Cursors.Hand;
            BtnEstados.FlatStyle = FlatStyle.Flat;
            BtnEstados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnEstados.ForeColor = Color.White;
            BtnEstados.Location = new Point(391, 21);
            BtnEstados.Name = "BtnEstados";
            BtnEstados.Size = new Size(75, 29);
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
            BtnTipoCampeonato.Location = new Point(472, 21);
            BtnTipoCampeonato.Name = "BtnTipoCampeonato";
            BtnTipoCampeonato.Size = new Size(161, 29);
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
            BtnDeportes.Location = new Point(286, 21);
            BtnDeportes.Name = "BtnDeportes";
            BtnDeportes.Size = new Size(94, 29);
            BtnDeportes.TabIndex = 20;
            BtnDeportes.Text = "Deportes";
            BtnDeportes.UseVisualStyleBackColor = false;
            BtnDeportes.Click += BtnDeportes_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 173);
            dataGridView1.TabIndex = 19;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.limpiar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(534, 199);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 50);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += button3_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(534, 137);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 50);
            BtnEditar.TabIndex = 17;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += button2_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(534, 260);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(58, 50);
            BtnNuevo.TabIndex = 16;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += button1_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(534, 72);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 50);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label8.Location = new Point(286, 262);
            label8.Name = "label8";
            label8.Size = new Size(180, 19);
            label8.TabIndex = 14;
            label8.Text = "Estado del campeonato:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label7.Location = new Point(286, 192);
            label7.Name = "label7";
            label7.Size = new Size(160, 19);
            label7.TabIndex = 13;
            label7.Text = "Tipo de campeonato:";
            label7.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Bell MT", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(286, 284);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Seleccione un estado";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBoxtipoCampeonato
            // 
            comboBoxtipoCampeonato.Font = new Font("Bell MT", 9F);
            comboBoxtipoCampeonato.FormattingEnabled = true;
            comboBoxtipoCampeonato.Location = new Point(286, 214);
            comboBoxtipoCampeonato.Name = "comboBoxtipoCampeonato";
            comboBoxtipoCampeonato.Size = new Size(168, 23);
            comboBoxtipoCampeonato.TabIndex = 11;
            comboBoxtipoCampeonato.Text = "Seleccione un tipo";
            comboBoxtipoCampeonato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ComboBoxDeporte
            // 
            ComboBoxDeporte.Font = new Font("Bell MT", 9F);
            ComboBoxDeporte.FormattingEnabled = true;
            ComboBoxDeporte.Location = new Point(286, 146);
            ComboBoxDeporte.Name = "ComboBoxDeporte";
            ComboBoxDeporte.Size = new Size(168, 23);
            ComboBoxDeporte.TabIndex = 10;
            ComboBoxDeporte.Text = "Seleccione un deporte";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label6.Location = new Point(286, 124);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 9;
            label6.Text = "Deporte: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Bell MT", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(21, 286);
            dateTimePicker1.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(94, 21);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 264);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 7;
            label5.Text = "Fecha final:";
            label5.Click += label5_Click;
            // 
            // dateInicio
            // 
            dateInicio.Font = new Font("Bell MT", 9F);
            dateInicio.Format = DateTimePickerFormat.Custom;
            dateInicio.Location = new Point(21, 214);
            dateInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateInicio.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(98, 21);
            dateInicio.TabIndex = 6;
            dateInicio.ValueChanged += dateInicio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 192);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 5;
            label4.Text = "Fecha de inicio:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bell MT", 9F);
            textBox1.Location = new Point(21, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 21);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ingrese nombre del campeonato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 124);
            label3.Name = "label3";
            label3.Size = new Size(189, 19);
            label3.TabIndex = 3;
            label3.Text = "Nombre del campeonato:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(169, 19);
            label2.TabIndex = 2;
            label2.Text = "Datos del campeonato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F);
            label1.Location = new Point(67, 21);
            label1.Name = "label1";
            label1.Size = new Size(125, 33);
            label1.TabIndex = 1;
            label1.Text = "Campeonato";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 39);
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
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(459, 72);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(58, 47);
            BtnMenu.TabIndex = 23;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmCampeonato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 548);
            Controls.Add(panel1);
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