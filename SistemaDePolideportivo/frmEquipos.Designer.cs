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
            label1.Location = new Point(33, 59);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 92);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Logo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 126);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Entrenador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 160);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(178, 56);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(253, 27);
            txtNombreEquipo.TabIndex = 4;
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(178, 89);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(74, 27);
            txtLogo.TabIndex = 5;
            // 
            // cmbEntrenador
            // 
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(178, 124);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(169, 28);
            cmbEntrenador.TabIndex = 6;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(179, 159);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(73, 24);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.AutoEllipsis = true;
            BtnGuardar.Location = new Point(33, 215);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(217, 215);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(94, 29);
            BtnEditar.TabIndex = 9;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(425, 215);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(674, 215);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(94, 29);
            BtnNuevo.TabIndex = 11;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(735, 188);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 20);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "Equipos";
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmEquipos";
            Text = "Form1";
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