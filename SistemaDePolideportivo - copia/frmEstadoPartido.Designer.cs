namespace SistemaDePolideportivo
{
    partial class frmEstadoPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoPartido));
            label1 = new Label();
            label2 = new Label();
            txtNombreEstado = new TextBox();
            label3 = new Label();
            txtDescripcion = new RichTextBox();
            dgvEstados = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            txtBuscar = new TextBox();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 13);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos del Partido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 1;
            label2.Text = "Estado del encuentro:";
            // 
            // txtNombreEstado
            // 
            txtNombreEstado.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEstado.Location = new Point(213, 73);
            txtNombreEstado.Margin = new Padding(3, 2, 3, 2);
            txtNombreEstado.Name = "txtNombreEstado";
            txtNombreEstado.Size = new Size(196, 21);
            txtNombreEstado.TabIndex = 2;
            txtNombreEstado.Text = "Programado, Finalizado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 98);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(135, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(316, 96);
            txtDescripcion.TabIndex = 13;
            txtDescripcion.Text = "Ingresa descripción";
            // 
            // dgvEstados
            // 
            dgvEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstados.Location = new Point(19, 239);
            dgvEstados.Margin = new Padding(3, 2, 3, 2);
            dgvEstados.Name = "dgvEstados";
            dgvEstados.RowHeadersWidth = 51;
            dgvEstados.Size = new Size(670, 82);
            dgvEstados.TabIndex = 14;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(632, 185);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(58, 47);
            btnNuevo.TabIndex = 22;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(632, 123);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 47);
            btnEliminar.TabIndex = 21;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(632, 68);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(58, 47);
            BtnEditar.TabIndex = 20;
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
            btnGuardar.Location = new Point(632, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(58, 50);
            btnGuardar.TabIndex = 19;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 212);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 23;
            label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(135, 212);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(316, 23);
            txtBuscar.TabIndex = 24;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Location = new Point(12, 13);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(43, 44);
            BtnMenu.TabIndex = 25;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // frmEstadoPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEstados);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombreEstado);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEstadoPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEstadoPartido";
            ((System.ComponentModel.ISupportInitialize)dgvEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreEstado;
        private Label label3;
        private RichTextBox txtDescripcion;
        private DataGridView dgvEstados;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
        private Label label4;
        private TextBox txtBuscar;
        private Button BtnMenu;
    }
}