namespace SistemaDePolideportivo
{
    partial class frmEstadoCampeonato
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoCampeonato));
            panelEstado = new Panel();
            BtnNuevo = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            NombreEstadoCampeonato = new TextBox();
            Descripcion = new RichTextBox();
            BtnEliminar = new Button();
            label1 = new Label();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnRegresar = new Button();
            panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelEstado
            // 
            panelEstado.BackColor = Color.White;
            panelEstado.Controls.Add(BtnRegresar);
            panelEstado.Controls.Add(BtnNuevo);
            panelEstado.Controls.Add(label5);
            panelEstado.Controls.Add(label4);
            panelEstado.Controls.Add(pictureBox1);
            panelEstado.Controls.Add(dataGridView1);
            panelEstado.Controls.Add(label3);
            panelEstado.Controls.Add(NombreEstadoCampeonato);
            panelEstado.Controls.Add(Descripcion);
            panelEstado.Controls.Add(BtnEliminar);
            panelEstado.Controls.Add(label1);
            panelEstado.Controls.Add(BtnEditar);
            panelEstado.Controls.Add(BtnGuardar);
            panelEstado.Location = new Point(-3, -7);
            panelEstado.Name = "panelEstado";
            panelEstado.Size = new Size(694, 455);
            panelEstado.TabIndex = 15;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 152);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 16;
            label5.Text = "Descripción: \r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 110);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 15;
            label4.Text = "Nombre del estado: \r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(107, 253);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(492, 150);
            dataGridView1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 67);
            label3.Name = "label3";
            label3.Size = new Size(251, 19);
            label3.TabIndex = 2;
            label3.Text = "Datos del Estado del Campeonato";
            // 
            // NombreEstadoCampeonato
            // 
            NombreEstadoCampeonato.BorderStyle = BorderStyle.FixedSingle;
            NombreEstadoCampeonato.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreEstadoCampeonato.Location = new Point(182, 109);
            NombreEstadoCampeonato.Name = "NombreEstadoCampeonato";
            NombreEstadoCampeonato.Size = new Size(183, 21);
            NombreEstadoCampeonato.TabIndex = 4;
            NombreEstadoCampeonato.Text = "Ingrese nombre del deporte";
            // 
            // Descripcion
            // 
            Descripcion.BorderStyle = BorderStyle.FixedSingle;
            Descripcion.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion.Location = new Point(182, 152);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(292, 83);
            Descripcion.TabIndex = 12;
            Descripcion.Text = "Ingresa descripción";
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 13);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 0;
            label1.Text = "Estado de Campeonato";
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
            // BtnRegresar
            // 
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(15, 356);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(56, 47);
            BtnRegresar.TabIndex = 19;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // frmEstadoCampeonato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 440);
            Controls.Add(panelEstado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEstadoCampeonato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estado de campeonato";
            Load += frmEstadoCampeonato_Load;
            panelEstado.ResumeLayout(false);
            panelEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEstado;
        private Button BtnNuevo;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox NombreEstadoCampeonato;
        private RichTextBox Descripcion;
        private Button BtnEliminar;
        private Label label1;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnRegresar;
    }
}