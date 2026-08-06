namespace SistemaDePolideportivo
{
    partial class frmRegistrarResultado
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
            label5 = new Label();
            label6 = new Label();
            numMarcadorLocal = new NumericUpDown();
            numMarcadorVisitante = new NumericUpDown();
            txtEstado = new TextBox();
            textBox2 = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            BtnEditar = new Button();
            btnGuardar = new Button();
            dgvResultados = new DataGridView();
            txtPartido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numMarcadorLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMarcadorVisitante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Partido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 1;
            label2.Text = "Datos del Resultado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 2;
            label3.Text = "Goles/PuntoVisitante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 3;
            label4.Text = "Goles/PuntoLocal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 4;
            label5.Text = "Observaciones:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 227);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 5;
            label6.Text = "Estado Partido:";
            // 
            // numMarcadorLocal
            // 
            numMarcadorLocal.Location = new Point(220, 137);
            numMarcadorLocal.Name = "numMarcadorLocal";
            numMarcadorLocal.Size = new Size(158, 27);
            numMarcadorLocal.TabIndex = 6;
            // 
            // numMarcadorVisitante
            // 
            numMarcadorVisitante.Location = new Point(220, 182);
            numMarcadorVisitante.Name = "numMarcadorVisitante";
            numMarcadorVisitante.Size = new Size(158, 27);
            numMarcadorVisitante.TabIndex = 7;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(220, 231);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(158, 27);
            txtEstado.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Location = new Point(701, 29);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 63);
            btnNuevo.TabIndex = 38;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(605, 29);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 63);
            btnEliminar.TabIndex = 37;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.editar;
            BtnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Location = new Point(701, 121);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(66, 63);
            BtnEditar.TabIndex = 36;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click_1;
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
            btnGuardar.Location = new Point(600, 117);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 67);
            btnGuardar.TabIndex = 35;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 302);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(780, 145);
            dgvResultados.TabIndex = 39;
            // 
            // txtPartido
            // 
            txtPartido.Location = new Point(97, 44);
            txtPartido.Name = "txtPartido";
            txtPartido.Size = new Size(158, 27);
            txtPartido.TabIndex = 40;
            txtPartido.Text = "ID Partido";
            // 
            // frmRegistrarResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPartido);
            Controls.Add(dgvResultados);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox2);
            Controls.Add(txtEstado);
            Controls.Add(numMarcadorVisitante);
            Controls.Add(numMarcadorLocal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistrarResultado";
            Text = "frmRegistrarResultado";
            Load += frmRegistrarResultado_Load;
            ((System.ComponentModel.ISupportInitialize)numMarcadorLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMarcadorVisitante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numMarcadorLocal;
        private NumericUpDown numMarcadorVisitante;
        private TextBox txtEstado;
        private TextBox textBox2;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button BtnEditar;
        private Button btnGuardar;
        private DataGridView dgvResultados;
        private TextBox txtPartido;
    }
}