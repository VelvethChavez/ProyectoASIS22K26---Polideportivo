namespace SistemaDePolideportivo
{
    partial class FrmEmpleado
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            LblTitulo = new Label();
            LblNombre = new Label();
            LblApellido = new Label();
            LblTeléfono = new Label();
            LblCorrreo = new Label();
            TxtNombres = new TextBox();
            TxtApellidos = new TextBox();
            TxtTelefono = new TextBox();
            TxtCorreo = new TextBox();
            CmbPuesto = new ComboBox();
            ChkEstado = new CheckBox();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnBuscar = new Button();
            DgvEmpleados = new DataGridView();
            LblBuscar = new Label();
            TxtBuscar = new TextBox();
            BtnActualizar = new Button();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.ForestGreen;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(253, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(267, 32);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Gestión de empleados";
            LblTitulo.Click += LblTitulo_Click;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(118, 89);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(58, 15);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Nombres";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Location = new Point(118, 125);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(57, 15);
            LblApellido.TabIndex = 2;
            LblApellido.Text = "Apellidos";
            // 
            // LblTeléfono
            // 
            LblTeléfono.AutoSize = true;
            LblTeléfono.Location = new Point(118, 158);
            LblTeléfono.Name = "LblTeléfono";
            LblTeléfono.Size = new Size(72, 15);
            LblTeléfono.TabIndex = 3;
            LblTeléfono.Text = "LblTeléfono";
            // 
            // LblCorrreo
            // 
            LblCorrreo.AutoSize = true;
            LblCorrreo.Location = new Point(118, 191);
            LblCorrreo.Name = "LblCorrreo";
            LblCorrreo.Size = new Size(45, 15);
            LblCorrreo.TabIndex = 4;
            LblCorrreo.Text = "Correo";
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(222, 89);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(332, 23);
            TxtNombres.TabIndex = 7;
            TxtNombres.Text = "Ingrese los Nombres";
            TxtNombres.TextChanged += TxtNombres_TextChanged;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(222, 125);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(332, 23);
            TxtApellidos.TabIndex = 8;
            TxtApellidos.Text = "Ingrese los apellidos";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(222, 158);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(332, 23);
            TxtTelefono.TabIndex = 9;
            TxtTelefono.Text = "Ingrese el telefono";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(222, 191);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(332, 23);
            TxtCorreo.TabIndex = 10;
            TxtCorreo.Text = "Ingrese el correo";
            // 
            // CmbPuesto
            // 
            CmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPuesto.FormattingEnabled = true;
            CmbPuesto.Location = new Point(222, 224);
            CmbPuesto.Name = "CmbPuesto";
            CmbPuesto.Size = new Size(332, 23);
            CmbPuesto.TabIndex = 11;
            // 
            // ChkEstado
            // 
            ChkEstado.AutoSize = true;
            ChkEstado.Checked = true;
            ChkEstado.CheckState = CheckState.Checked;
            ChkEstado.ForeColor = Color.Black;
            ChkEstado.Location = new Point(222, 258);
            ChkEstado.Name = "ChkEstado";
            ChkEstado.Size = new Size(119, 19);
            ChkEstado.TabIndex = 12;
            ChkEstado.Text = "Empleado Activo";
            ChkEstado.UseVisualStyleBackColor = true;
            ChkEstado.CheckedChanged += ChkEstado_CheckedChanged;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.ForestGreen;
            BtnNuevo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.ForeColor = Color.White;
            BtnNuevo.Location = new Point(73, 319);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(106, 38);
            BtnNuevo.TabIndex = 13;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.ForestGreen;
            BtnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(222, 319);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(106, 38);
            BtnGuardar.TabIndex = 14;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.ForestGreen;
            BtnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(366, 319);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(106, 38);
            BtnEditar.TabIndex = 15;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.ForestGreen;
            BtnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(514, 319);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(106, 38);
            BtnEliminar.TabIndex = 16;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.ForestGreen;
            BtnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(657, 319);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(106, 38);
            BtnBuscar.TabIndex = 17;
            BtnBuscar.Text = "LblBuscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // DgvEmpleados
            // 
            DgvEmpleados.AllowUserToAddRows = false;
            DgvEmpleados.AllowUserToDeleteRows = false;
            DgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEmpleados.BackgroundColor = Color.White;
            DgvEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmpleados.Location = new Point(73, 451);
            DgvEmpleados.MultiSelect = false;
            DgvEmpleados.Name = "DgvEmpleados";
            DgvEmpleados.ReadOnly = true;
            DgvEmpleados.RowHeadersWidth = 51;
            DgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEmpleados.Size = new Size(690, 188);
            DgvEmpleados.TabIndex = 18;
            DgvEmpleados.CellClick += DgvEmpleados_CellClick;
            DgvEmpleados.CellContentClick += DgvEmpleados_CellContentClick;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.Location = new Point(118, 394);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(63, 15);
            LblBuscar.TabIndex = 19;
            LblBuscar.Text = "LblBuscar:";
            LblBuscar.Click += LblBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(222, 394);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(332, 23);
            TxtBuscar.TabIndex = 20;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.ForestGreen;
            BtnActualizar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(595, 394);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(115, 38);
            BtnActualizar.TabIndex = 21;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.BackgroundImage = (Image)resources.GetObject("BtnMenu.BackgroundImage");
            BtnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.Location = new Point(12, 9);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(50, 49);
            BtnMenu.TabIndex = 22;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 673);
            Controls.Add(BtnMenu);
            Controls.Add(BtnActualizar);
            Controls.Add(TxtBuscar);
            Controls.Add(LblBuscar);
            Controls.Add(DgvEmpleados);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(ChkEstado);
            Controls.Add(CmbPuesto);
            Controls.Add(TxtCorreo);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtApellidos);
            Controls.Add(TxtNombres);
            Controls.Add(LblCorrreo);
            Controls.Add(LblTeléfono);
            Controls.Add(LblApellido);
            Controls.Add(LblNombre);
            Controls.Add(LblTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo Recursos Humanos";
            Load += FrmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblNombre;
        private Label LblApellido;
        private Label LblTeléfono;
        private Label LblCorrreo;
        private TextBox TxtNombres;
        private TextBox TxtApellidos;
        private TextBox TxtTelefono;
        private TextBox TxtCorreo;
        private ComboBox CmbPuesto;
        private CheckBox ChkEstado;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnBuscar;
        private DataGridView DgvEmpleados;
        private Label LblBuscar;
        private TextBox TxtBuscar;
        private Button BtnActualizar;
        private Button BtnMenu;
    }
}