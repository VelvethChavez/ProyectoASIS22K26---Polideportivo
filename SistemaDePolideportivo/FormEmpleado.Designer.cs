namespace SistemaDePolideportivo
{
    partial class FormEmpleado
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
            Titulo = new Label();
            Nombre = new Label();
            Apellido = new Label();
            Teléfono = new Label();
            Corrreo = new Label();
            Puesto = new Label();
            Estado = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            cmbPuesto = new ComboBox();
            chkEstado = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvEmpleados = new DataGridView();
            Buscar = new Label();
            txtBuscar = new TextBox();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.ForestGreen;
            Titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(253, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(329, 41);
            Titulo.TabIndex = 0;
            Titulo.Text = "Gestión de empleados";
            Titulo.Click += label1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(118, 89);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(74, 20);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombres";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(118, 125);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(74, 20);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellidos";
            // 
            // Teléfono
            // 
            Teléfono.AutoSize = true;
            Teléfono.Location = new Point(118, 158);
            Teléfono.Name = "Teléfono";
            Teléfono.Size = new Size(70, 20);
            Teléfono.TabIndex = 3;
            Teléfono.Text = "Teléfono";
            // 
            // Corrreo
            // 
            Corrreo.AutoSize = true;
            Corrreo.Location = new Point(118, 191);
            Corrreo.Name = "Corrreo";
            Corrreo.Size = new Size(56, 20);
            Corrreo.TabIndex = 4;
            Corrreo.Text = "Correo";
            // 
            // Puesto
            // 
            Puesto.AutoSize = true;
            Puesto.Location = new Point(118, 224);
            Puesto.Name = "Puesto";
            Puesto.Size = new Size(57, 20);
            Puesto.TabIndex = 5;
            Puesto.Text = "Puesto";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Location = new Point(118, 258);
            Estado.Name = "Estado";
            Estado.Size = new Size(56, 20);
            Estado.TabIndex = 6;
            Estado.Text = "Estado";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(222, 89);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(332, 27);
            txtNombres.TabIndex = 7;
            txtNombres.Text = "Ingrese los Nombres";
            txtNombres.TextChanged += txtNombres_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(222, 125);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(332, 27);
            txtApellidos.TabIndex = 8;
            txtApellidos.Text = "Ingrese los apellidos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(222, 158);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(332, 27);
            txtTelefono.TabIndex = 9;
            txtTelefono.Text = "Ingrese el telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(222, 191);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(332, 27);
            txtCorreo.TabIndex = 10;
            txtCorreo.Text = "Ingrese el correo";
            // 
            // cmbPuesto
            // 
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(222, 224);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(332, 28);
            cmbPuesto.TabIndex = 11;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.ForeColor = Color.Black;
            chkEstado.Location = new Point(222, 258);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(149, 24);
            chkEstado.TabIndex = 12;
            chkEstado.Text = "Empleado Activo";
            chkEstado.UseVisualStyleBackColor = true;
            chkEstado.CheckedChanged += checkBoxEstado_CheckedChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.ForestGreen;
            btnNuevo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(73, 319);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 38);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += buttonNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(222, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 38);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(366, 319);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 38);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.ForestGreen;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(514, 319);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 38);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(657, 319);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 38);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.ForestGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(73, 451);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(690, 188);
            dgvEmpleados.TabIndex = 18;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // Buscar
            // 
            Buscar.AutoSize = true;
            Buscar.Location = new Point(118, 394);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(61, 20);
            Buscar.TabIndex = 19;
            Buscar.Text = "Buscar:";
            Buscar.Click += label1_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(222, 394);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(332, 27);
            txtBuscar.TabIndex = 20;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.ForestGreen;
            btnActualizar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(595, 394);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 38);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(838, 673);
            Controls.Add(btnActualizar);
            Controls.Add(txtBuscar);
            Controls.Add(Buscar);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(chkEstado);
            Controls.Add(cmbPuesto);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(Estado);
            Controls.Add(Puesto);
            Controls.Add(Corrreo);
            Controls.Add(Teléfono);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Titulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo Recursos Humanos";
            Load += FormEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label Nombre;
        private Label Apellido;
        private Label Teléfono;
        private Label Corrreo;
        private Label Puesto;
        private Label Estado;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private ComboBox cmbPuesto;
        private CheckBox chkEstado;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvEmpleados;
        private Label Buscar;
        private TextBox txtBuscar;
        private Button btnActualizar;
    }
}