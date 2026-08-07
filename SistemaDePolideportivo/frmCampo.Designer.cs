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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampo));
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
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCampos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 12);
            label1.Name = "label1";
            label1.Size = new Size(345, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Campos Deportivos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 47);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Campo:";
            // 
            // txtNombreCampo
            // 
            txtNombreCampo.Location = new Point(203, 52);
            txtNombreCampo.Margin = new Padding(3, 2, 3, 2);
            txtNombreCampo.Name = "txtNombreCampo";
            txtNombreCampo.Size = new Size(248, 23);
            txtNombreCampo.TabIndex = 2;
            txtNombreCampo.Text = "Cementos Progreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 85);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 3;
            label3.Text = "Deporte/Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 126);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(203, 129);
            txtCapacidad.Margin = new Padding(3, 2, 3, 2);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(248, 23);
            txtCapacidad.TabIndex = 6;
            txtCapacidad.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 158);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 7;
            label5.Text = "Estado:";
            // 
            // txtTipoCampo
            // 
            txtTipoCampo.Location = new Point(203, 89);
            txtTipoCampo.Margin = new Padding(3, 2, 3, 2);
            txtTipoCampo.Name = "txtTipoCampo";
            txtTipoCampo.Size = new Size(248, 23);
            txtTipoCampo.TabIndex = 8;
            txtTipoCampo.Text = "Futbol";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(203, 162);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(248, 23);
            txtEstado.TabIndex = 9;
            txtEstado.Text = "Libre";
            // 
            // dgvCampos
            // 
            dgvCampos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampos.Location = new Point(37, 202);
            dgvCampos.Margin = new Padding(3, 2, 3, 2);
            dgvCampos.Name = "dgvCampos";
            dgvCampos.RowHeadersWidth = 51;
            dgvCampos.Size = new Size(590, 126);
            dgvCampos.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(632, 186);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(58, 47);
            btnNuevo.TabIndex = 26;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(632, 124);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 47);
            btnEliminar.TabIndex = 25;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(632, 69);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 47);
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
            btnGuardar.Location = new Point(632, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(58, 50);
            btnGuardar.TabIndex = 23;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(12, 3);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(41, 41);
            BtnMenu.TabIndex = 27;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmCampo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCampo";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button BtnMenu;
    }
}