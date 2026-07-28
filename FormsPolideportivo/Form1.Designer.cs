namespace FormsPolideportivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Jornada = new TabControl();
            tabPage1 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label12 = new Label();
            label11 = new Label();
            comboBox7 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            button9 = new Button();
            button10 = new Button();
            button8 = new Button();
            comboBox11 = new ComboBox();
            label18 = new Label();
            comboBox10 = new ComboBox();
            label17 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            comboBox9 = new ComboBox();
            comboBox8 = new ComboBox();
            Jornada.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 38);
            label1.Name = "label1";
            label1.Size = new Size(331, 60);
            label1.TabIndex = 0;
            label1.Text = "Competiciones";
            label1.Click += label1_Click;
            // 
            // Jornada
            // 
            Jornada.Controls.Add(tabPage1);
            Jornada.Controls.Add(tabPage2);
            Jornada.Controls.Add(tabPage3);
            Jornada.Location = new Point(58, 143);
            Jornada.Name = "Jornada";
            Jornada.SelectedIndex = 0;
            Jornada.Size = new Size(880, 458);
            Jornada.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Jornadas";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(430, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(187, 27);
            numericUpDown1.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Femenino", "Masculino", "Infantil", "Mixto" });
            comboBox1.Location = new Point(15, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 19;
            comboBox1.Text = "Tipo Campeonato";

            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(430, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 16;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(430, 133);
            label23.Name = "label23";
            label23.Size = new Size(175, 28);
            label23.TabIndex = 13;
            label23.Text = "Fecha Programada";
            label23.Click += label23_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(15, 133);
            label22.Name = "label22";
            label22.Size = new Size(206, 28);
            label22.TabIndex = 12;
            label22.Text = "Nombre de la Jornada";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(430, 49);
            label21.Name = "label21";
            label21.Size = new Size(185, 28);
            label21.TabIndex = 11;
            label21.Text = "Numero de Jornada";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(15, 49);
            label20.Name = "label20";
            label20.Size = new Size(125, 28);
            label20.TabIndex = 10;
            label20.Text = "Campeonato";
            label20.Click += label20_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(260, 38);
            label19.TabIndex = 9;
            label19.Text = "Datos de la Jornada";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 287);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(872, 138);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(424, 231);
            button3.Name = "button3";
            button3.Size = new Size(102, 39);
            button3.TabIndex = 7;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(314, 231);
            button1.Name = "button1";
            button1.Size = new Size(102, 39);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(532, 231);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 5;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Partidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 120);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 238);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox7);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Encuentro";
            // 
            // button7
            // 
            button7.Location = new Point(653, 261);
            button7.Name = "button7";
            button7.Size = new Size(143, 38);
            button7.TabIndex = 21;
            button7.Text = "Limpiar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(258, 261);
            button6.Name = "button6";
            button6.Size = new Size(143, 38);
            button6.TabIndex = 20;
            button6.Text = "Actualizar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(458, 261);
            button5.Name = "button5";
            button5.Size = new Size(143, 38);
            button5.TabIndex = 19;
            button5.Text = "Cancelar Partido";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(52, 261);
            button4.Name = "button4";
            button4.Size = new Size(143, 38);
            button4.TabIndex = 18;
            button4.Text = "Programar Partido";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(504, 209);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 17;
            label12.Text = "ESTADO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(258, 209);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 16;
            label11.Text = "ARBITRO:";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(577, 206);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(128, 28);
            comboBox7.TabIndex = 15;
            comboBox7.Text = "Campo 1";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(336, 206);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(128, 28);
            comboBox6.TabIndex = 14;
            comboBox6.Text = "Campo 1";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(94, 206);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(128, 28);
            comboBox5.TabIndex = 13;
            comboBox5.Text = "Campo 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 209);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 12;
            label10.Text = "CAMPO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(303, 172);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 11;
            label9.Text = "HORA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 172);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 10;
            label8.Text = "FECHA:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(362, 167);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(146, 27);
            dateTimePicker3.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(89, 167);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(146, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(424, 104);
            label7.Name = "label7";
            label7.Size = new Size(40, 31);
            label7.TabIndex = 7;
            label7.Text = "VS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(653, 87);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 6;
            label6.Text = "VISITANTE";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 87);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "LOCAL";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(653, 110);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(184, 28);
            comboBox4.TabIndex = 4;
            comboBox4.Text = "Selección Equipo";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(30, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(184, 28);
            comboBox3.TabIndex = 3;
            comboBox3.Text = "Selección Equipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 29);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Jornada:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 209);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 1;
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(118, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 28);
            comboBox2.TabIndex = 0;
            comboBox2.Text = "Jornada 1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(comboBox11);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(comboBox10);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(numericUpDown4);
            tabPage3.Controls.Add(numericUpDown3);
            tabPage3.Controls.Add(numericUpDown2);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(comboBox9);
            tabPage3.Controls.Add(comboBox8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(872, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Resultados";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 324);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(876, 101);
            dataGridView3.TabIndex = 17;
            // 
            // button9
            // 
            button9.Location = new Point(616, 267);
            button9.Name = "button9";
            button9.Size = new Size(144, 40);
            button9.TabIndex = 16;
            button9.Text = "Cancelar";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(344, 267);
            button10.Name = "button10";
            button10.Size = new Size(144, 40);
            button10.TabIndex = 15;
            button10.Text = "Limpiar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(92, 267);
            button8.Name = "button8";
            button8.Size = new Size(144, 40);
            button8.TabIndex = 13;
            button8.Text = "Guardar Resultado";
            button8.UseVisualStyleBackColor = true;
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(344, 195);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(144, 28);
            comboBox11.TabIndex = 12;
            comboBox11.Text = "Finalizado";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(296, 198);
            label18.Name = "label18";
            label18.Size = new Size(42, 20);
            label18.TabIndex = 11;
            label18.Text = "MVP:";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(92, 195);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(144, 28);
            comboBox10.TabIndex = 10;
            comboBox10.Text = "Finalizado";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(19, 198);
            label17.Name = "label17";
            label17.Size = new Size(67, 20);
            label17.TabIndex = 9;
            label17.Text = "ESTADO:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(171, 149);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(150, 27);
            numericUpDown4.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(570, 149);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(181, 139);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(0, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(461, 86);
            label16.Name = "label16";
            label16.Size = new Size(332, 50);
            label16.TabIndex = 5;
            label16.Text = "EQUIPO VISITANTE";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(97, 86);
            label15.Name = "label15";
            label15.Size = new Size(271, 50);
            label15.TabIndex = 4;
            label15.Text = "EQUIPO LOCAL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(331, 26);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 3;
            label14.Text = "Partido:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 26);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 2;
            label13.Text = "Jornada:";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(435, 23);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(149, 28);
            comboBox9.TabIndex = 1;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(98, 23);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(149, 28);
            comboBox8.TabIndex = 0;
            comboBox8.Text = "Jornada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 613);
            Controls.Add(Jornada);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Jornada.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl Jornada;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label12;
        private Label label11;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private Label label10;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown4;
        private ComboBox comboBox10;
        private Label label17;
        private Button button10;
        private Button button8;
        private ComboBox comboBox11;
        private Label label18;
        private Button button9;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label23;
        private Label label22;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
    }
}
