namespace SistemaDePolideportivo
{
    partial class frmEquipos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreEquipo = new TextBox();
            txtLogo = new TextBox();
            cmbEntrenador = new ComboBox();
            chkEstado = new CheckBox();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 94);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Entrenador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 120);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(156, 42);
            txtNombreEquipo.Margin = new Padding(3, 2, 3, 2);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(222, 23);
            txtNombreEquipo.TabIndex = 4;
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(156, 67);
            txtLogo.Margin = new Padding(3, 2, 3, 2);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(65, 23);
            txtLogo.TabIndex = 5;
            // 
            // cmbEntrenador
            // 
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(156, 93);
            cmbEntrenador.Margin = new Padding(3, 2, 3, 2);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(148, 23);
            cmbEntrenador.TabIndex = 6;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(157, 119);
            chkEstado.Margin = new Padding(3, 2, 3, 2);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.AutoEllipsis = true;
            BtnGuardar.BackColor = Color.White;
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Location = new Point(467, 30);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(52, 44);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.White;
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(467, 93);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(52, 44);
            BtnEditar.TabIndex = 9;
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.White;
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(565, 30);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(52, 44);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.White;
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Location = new Point(565, 94);
            BtnNuevo.Margin = new Padding(3, 2, 3, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(52, 44);
            BtnNuevo.TabIndex = 11;
            BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 188);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(643, 141);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 15);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Equipos";
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 385);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(chkEstado);
            Controls.Add(cmbEntrenador);
            Controls.Add(txtLogo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreEquipo;
        private TextBox txtLogo;
        private ComboBox cmbEntrenador;
        private CheckBox chkEstado;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnNuevo;
        private DataGridView dataGridView1;
        private Label label5;
    }
}