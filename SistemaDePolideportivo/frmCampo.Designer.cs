namespace SistemaDePolideportivo
{
    partial class frmCampo
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
            txtNombreCampo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCapacidad = new TextBox();
            label5 = new Label();
            txtTipoCampo = new TextBox();
            txtEstado = new TextBox();
            dgvCampos = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCampos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Campos Deportivos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Campo:";
            // 
            // txtNombreCampo
            // 
            txtNombreCampo.Location = new Point(232, 69);
            txtNombreCampo.Name = "txtNombreCampo";
            txtNombreCampo.Size = new Size(283, 27);
            txtNombreCampo.TabIndex = 2;
            txtNombreCampo.Text = "Cementos Progreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(211, 31);
            label3.TabIndex = 3;
            label3.Text = "Deporte/Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(128, 31);
            label4.TabIndex = 5;
            label4.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(232, 172);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(283, 27);
            txtCapacidad.TabIndex = 6;
            txtCapacidad.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 210);
            label5.Name = "label5";
            label5.Size = new Size(88, 31);
            label5.TabIndex = 7;
            label5.Text = "Estado:";
            // 
            // txtTipoCampo
            // 
            txtTipoCampo.Location = new Point(232, 119);
            txtTipoCampo.Name = "txtTipoCampo";
            txtTipoCampo.Size = new Size(283, 27);
            txtTipoCampo.TabIndex = 8;
            txtTipoCampo.Text = "Futbol";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(232, 216);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(283, 27);
            txtEstado.TabIndex = 9;
            txtEstado.Text = "Libre";
            // 
            // dgvCampos
            // 
            dgvCampos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampos.Location = new Point(42, 270);
            dgvCampos.Name = "dgvCampos";
            dgvCampos.RowHeadersWidth = 51;
            dgvCampos.Size = new Size(674, 168);
            dgvCampos.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(722, 248);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 63);
            btnNuevo.TabIndex = 26;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(722, 165);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 63);
            btnEliminar.TabIndex = 25;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(722, 92);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 24;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = Properties.Resources.guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(722, 10);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 67);
            btnGuardar.TabIndex = 23;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCampo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvCampos);
            Controls.Add(txtEstado);
            Controls.Add(txtTipoCampo);
            Controls.Add(label5);
            Controls.Add(txtCapacidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombreCampo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCampo";
            Text = "frmCampo";
            Load += frmCampo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCampos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCampo;
        private Label label3;
        private Label label4;
        private TextBox txtCapacidad;
        private Label label5;
        private TextBox txtTipoCampo;
        private TextBox txtEstado;
        private DataGridView dgvCampos;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
    }
}