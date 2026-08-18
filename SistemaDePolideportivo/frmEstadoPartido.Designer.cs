namespace SistemaDePolideportivo
{
    partial class FrmEstadoPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadoPartido));
            Lbl1 = new Label();
            Lbl2 = new Label();
            TxtNombreEstado = new TextBox();
            Lbl3 = new Label();
            RtbTxtDescripcion = new RichTextBox();
            DgvEstados = new DataGridView();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            Lbl4 = new Label();
            TxtBuscar = new TextBox();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEstados).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(80, 13);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(178, 30);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Datos del Partido";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(19, 70);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(158, 21);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Estado del encuentro:";
            // 
            // TxtNombreEstado
            // 
            TxtNombreEstado.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombreEstado.Location = new Point(213, 73);
            TxtNombreEstado.Margin = new Padding(3, 2, 3, 2);
            TxtNombreEstado.Name = "TxtNombreEstado";
            TxtNombreEstado.Size = new Size(196, 21);
            TxtNombreEstado.TabIndex = 2;
            TxtNombreEstado.Text = "Programado, Finalizado";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(26, 98);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(94, 21);
            Lbl3.TabIndex = 3;
            Lbl3.Text = "Descripción:";
            // 
            // RtbTxtDescripcion
            // 
            RtbTxtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            RtbTxtDescripcion.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtbTxtDescripcion.Location = new Point(135, 104);
            RtbTxtDescripcion.Name = "RtbTxtDescripcion";
            RtbTxtDescripcion.Size = new Size(316, 96);
            RtbTxtDescripcion.TabIndex = 13;
            RtbTxtDescripcion.Text = "Ingresa descripción";
            // 
            // DgvEstados
            // 
            DgvEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEstados.Location = new Point(19, 239);
            DgvEstados.Margin = new Padding(3, 2, 3, 2);
            DgvEstados.Name = "DgvEstados";
            DgvEstados.RowHeadersWidth = 51;
            DgvEstados.Size = new Size(670, 82);
            DgvEstados.TabIndex = 14;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(632, 185);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(58, 47);
            BtnNuevo.TabIndex = 22;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(632, 123);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(58, 47);
            BtnEliminar.TabIndex = 21;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
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
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Transparent;
            BtnGuardar.BackgroundImage = Properties.Resources.guardar;
            BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            BtnGuardar.ImageAlign = ContentAlignment.TopCenter;
            BtnGuardar.Location = new Point(632, 7);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(58, 50);
            BtnGuardar.TabIndex = 19;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(66, 212);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(59, 21);
            Lbl4.TabIndex = 23;
            Lbl4.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(135, 212);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(316, 23);
            TxtBuscar.TabIndex = 24;
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
            // FrmEstadoPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMenu);
            Controls.Add(TxtBuscar);
            Controls.Add(Lbl4);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(DgvEstados);
            Controls.Add(RtbTxtDescripcion);
            Controls.Add(Lbl3);
            Controls.Add(TxtNombreEstado);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstadoPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstadoPartido";
            ((System.ComponentModel.ISupportInitialize)DgvEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private TextBox TxtNombreEstado;
        private Label Lbl3;
        private RichTextBox RtbTxtDescripcion;
        private DataGridView DgvEstados;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Label Lbl4;
        private TextBox TxtBuscar;
        private Button BtnMenu;
    }
}