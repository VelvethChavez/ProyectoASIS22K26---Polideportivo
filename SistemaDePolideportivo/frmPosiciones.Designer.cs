namespace SistemaDePolideportivo
{
    partial class FrmPosiciones
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
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            TxtNombrePosicion = new TextBox();
            TxtDescripcion = new TextBox();
            Dgv1 = new DataGridView();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new Font("Segoe UI", 14F);
            Lbl1.Location = new Point(312, 22);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(100, 25);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Posiciones";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(40, 61);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(99, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Nombre posición";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(40, 101);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(69, 15);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "Descripción";
            // 
            // TxtNombrePosicion
            // 
            TxtNombrePosicion.Location = new Point(168, 61);
            TxtNombrePosicion.Margin = new Padding(3, 2, 3, 2);
            TxtNombrePosicion.Name = "TxtNombrePosicion";
            TxtNombrePosicion.Size = new Size(213, 23);
            TxtNombrePosicion.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(168, 96);
            TxtDescripcion.Margin = new Padding(3, 2, 3, 2);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(213, 23);
            TxtDescripcion.TabIndex = 4;
            // 
            // Dgv1
            // 
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(32, 188);
            Dgv1.Margin = new Padding(3, 2, 3, 2);
            Dgv1.Name = "Dgv1";
            Dgv1.RowHeadersWidth = 51;
            Dgv1.Size = new Size(637, 141);
            Dgv1.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(32, 161);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(82, 22);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(217, 161);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(82, 22);
            BtnEditar.TabIndex = 7;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(405, 161);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(82, 22);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(586, 161);
            BtnNuevo.Margin = new Padding(3, 2, 3, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(82, 22);
            BtnNuevo.TabIndex = 9;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmPosiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(Dgv1);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombrePosicion);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPosiciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPosiciones";
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private TextBox TxtNombrePosicion;
        private TextBox TxtDescripcion;
        private DataGridView Dgv1;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnNuevo;
    }
}