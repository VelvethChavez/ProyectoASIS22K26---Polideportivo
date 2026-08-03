using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDePolideportivo.DAO;
using SistemaDePolideportivo.Modelos;

namespace SistemaDePolideportivo
{
    public partial class FormEmpleado : Form
    {
        private int idEmpleado = 0;

        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            CargarPuestos();

            chkEstado.Checked = true;

            txtNombres.Focus();

            CargarEmpleados();

             EstiloDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (idEmpleado == 0)
                {
                    MessageBox.Show("Seleccione un empleado.");
                    return;
                }

                Empleado empleado = new Empleado
                {
                    IdEmpleado = idEmpleado,
                    NombresEmpleado = txtNombres.Text,
                    ApellidosEmpleado = txtApellidos.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Puesto = cmbPuesto.Text,
                    Estado = chkEstado.Checked
                };

                EmpleadoDAO dao = new EmpleadoDAO();

                if (dao.ActualizarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado actualizado.");

                    LimpiarCampos();

                    CargarEmpleados();

                    idEmpleado = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarPuestos()
        {
            cmbPuesto.Items.Clear();

            cmbPuesto.Items.Add("Administrador");
            cmbPuesto.Items.Add("Coordinador");
            cmbPuesto.Items.Add("Árbitro");
            cmbPuesto.Items.Add("Secretario");
            cmbPuesto.Items.Add("Auxiliar");

            cmbPuesto.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            cmbPuesto.SelectedIndex = 0;

            chkEstado.Checked = true;

            txtNombres.Focus();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text))
                {
                    MessageBox.Show("Ingrese los nombres del empleado.");
                    txtNombres.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    MessageBox.Show("Ingrese los apellidos.");
                    txtApellidos.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Ingrese el teléfono.");
                    txtTelefono.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Ingrese el correo.");
                    txtCorreo.Focus();
                    return;
                }

                Empleado empleado = new Empleado
                {
                    NombresEmpleado = txtNombres.Text.Trim(),
                    ApellidosEmpleado = txtApellidos.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Puesto = cmbPuesto.Text,
                    Estado = chkEstado.Checked
                };

                EmpleadoDAO dao = new EmpleadoDAO();

                if (dao.InsertarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado registrado correctamente.");

                    LimpiarCampos();
                    CargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = dao.ListarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados.\n" + ex.Message);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                idEmpleado = Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

                cmbPuesto.Text = fila.Cells["Puesto"].Value.ToString();

                chkEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (idEmpleado == 0)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea desactivar este empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                if (dao.EliminarEmpleado(idEmpleado))
                {
                    MessageBox.Show("Empleado desactivado.");

                    LimpiarCampos();

                    CargarEmpleados();

                    idEmpleado = 0;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EmpleadoDAO dao = new EmpleadoDAO();

            dgvEmpleados.DataSource = dao.BuscarEmpleado(txtBuscar.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            LimpiarCampos();
        }

        private void EstiloDataGridView()
        {
            // Fondo
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;

            // Encabezados
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas
            dgvEmpleados.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvEmpleados.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(144, 238, 144);

            dgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEmpleados.DefaultCellStyle.BackColor = Color.White;
            dgvEmpleados.DefaultCellStyle.ForeColor = Color.Black;

            // Alternar colores de filas
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 255, 240);

            // Ajustes
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.RowHeadersVisible = false;

            // Altura de encabezados
            dgvEmpleados.ColumnHeadersHeight = 40;
        }
    }
}
    




