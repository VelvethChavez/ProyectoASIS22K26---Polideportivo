namespace SistemaDePolideportivo
{
    partial class FrmRegistrarResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarResultado));
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            Lbl5 = new Label();
            Lbl6 = new Label();
            NudNumMarcadorLocal = new NumericUpDown();
            NudNumMarcadorVisitante = new NumericUpDown();
            Txt2 = new TextBox();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            DgvResultados = new DataGridView();
            CmbPartido = new ComboBox();
            CmbEstado = new ComboBox();
            BtnRegresarMenuCompeticiones = new Button();
            ((System.ComponentModel.ISupportInitialize)NudNumMarcadorLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudNumMarcadorVisitante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvResultados).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1.Location = new Point(12, 43);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(79, 28);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Partido:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(12, 87);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(190, 28);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Datos del Resultado:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl3.Location = new Point(12, 181);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(200, 28);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Goles/PuntoVisitante:";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl4.Location = new Point(12, 132);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(166, 28);
            Lbl4.TabIndex = 3;
            Lbl4.Text = "Goles/PuntoLocal";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl5.Location = new Point(12, 265);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(143, 28);
            Lbl5.TabIndex = 4;
            Lbl5.Text = "Observaciones:";
            // 
            // Lbl6
            // 
            Lbl6.AutoSize = true;
            Lbl6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl6.Location = new Point(12, 227);
            Lbl6.Name = "Lbl6";
            Lbl6.Size = new Size(143, 28);
            Lbl6.TabIndex = 5;
            Lbl6.Text = "Estado Partido:";
            // 
            // NudNumMarcadorLocal
            // 
            NudNumMarcadorLocal.Location = new Point(220, 137);
            NudNumMarcadorLocal.Name = "NudNumMarcadorLocal";
            NudNumMarcadorLocal.Size = new Size(158, 27);
            NudNumMarcadorLocal.TabIndex = 6;
            // 
            // NudNumMarcadorVisitante
            // 
            NudNumMarcadorVisitante.Location = new Point(220, 182);
            NudNumMarcadorVisitante.Name = "NudNumMarcadorVisitante";
            NudNumMarcadorVisitante.Size = new Size(158, 27);
            NudNumMarcadorVisitante.TabIndex = 7;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(220, 269);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(158, 27);
            Txt2.TabIndex = 9;
            Txt2.Text = "Datos del encuentro";
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackgroundImage = Properties.Resources.nuevo;
            BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNuevo.Location = new Point(713, 117);
            BtnNuevo.Margin = new Padding(3, 4, 3, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(66, 63);
            BtnNuevo.TabIndex = 38;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(617, 117);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(66, 63);
            BtnEliminar.TabIndex = 37;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(713, 209);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 36;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click_1;
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
            BtnGuardar.Location = new Point(612, 205);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(66, 67);
            BtnGuardar.TabIndex = 35;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // DgvResultados
            // 
            DgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvResultados.Location = new Point(12, 302);
            DgvResultados.Name = "DgvResultados";
            DgvResultados.RowHeadersWidth = 51;
            DgvResultados.Size = new Size(780, 145);
            DgvResultados.TabIndex = 39;
            // 
            // CmbPartido
            // 
            CmbPartido.FormattingEnabled = true;
            CmbPartido.Location = new Point(220, 43);
            CmbPartido.Name = "CmbPartido";
            CmbPartido.Size = new Size(158, 28);
            CmbPartido.TabIndex = 40;
            // 
            // CmbEstado
            // 
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(220, 227);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(158, 28);
            CmbEstado.TabIndex = 41;
            // 
            // BtnRegresarMenuCompeticiones
            // 
            BtnRegresarMenuCompeticiones.BackgroundImage = (Image)resources.GetObject("BtnRegresarMenuCompeticiones.BackgroundImage");
            BtnRegresarMenuCompeticiones.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegresarMenuCompeticiones.Cursor = Cursors.Hand;
            BtnRegresarMenuCompeticiones.Location = new Point(713, 13);
            BtnRegresarMenuCompeticiones.Margin = new Padding(3, 4, 3, 4);
            BtnRegresarMenuCompeticiones.Name = "BtnRegresarMenuCompeticiones";
            BtnRegresarMenuCompeticiones.Size = new Size(66, 63);
            BtnRegresarMenuCompeticiones.TabIndex = 42;
            BtnRegresarMenuCompeticiones.UseVisualStyleBackColor = true;
            BtnRegresarMenuCompeticiones.Click += BtnRegresarMenuCompeticiones_Click_1;
            // 
            // FrmRegistrarResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRegresarMenuCompeticiones);
            Controls.Add(CmbEstado);
            Controls.Add(CmbPartido);
            Controls.Add(DgvResultados);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(Txt2);
            Controls.Add(NudNumMarcadorVisitante);
            Controls.Add(NudNumMarcadorLocal);
            Controls.Add(Lbl6);
            Controls.Add(Lbl5);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistrarResultado";
            Text = "FrmRegistrarResultado";
            Load += FrmRegistrarResultado_Load;
            ((System.ComponentModel.ISupportInitialize)NudNumMarcadorLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudNumMarcadorVisitante).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private Label Lbl5;
        private Label Lbl6;
        private NumericUpDown NudNumMarcadorLocal;
        private NumericUpDown NudNumMarcadorVisitante;
        private TextBox Txt2;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private DataGridView DgvResultados;
        private ComboBox CmbPartido;
        private ComboBox CmbEstado;
        private Button BtnRegresarMenuCompeticiones;
    }
}