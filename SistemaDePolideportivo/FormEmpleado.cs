using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.DAO;
using SistemaDePolideportivo.Modelos;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FormEmpleado : Form
    {
        private int idEmpleado = 0;

        public FormEmpleado()
        {
            InitializeComponent();

            txtNombres.KeyPress += SoloLetras_KeyPress;
            txtApellidos.KeyPress += SoloLetras_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombres.MaxLength = 100;
                txtApellidos.MaxLength = 100;
                txtTelefono.MaxLength = 8;
                txtCorreo.MaxLength = 100;

                CargarPuestos();

                chkEstado.Checked = true;

                txtNombres.Focus();

                CargarEmpleados();

                EstiloDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el formulario.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SoloLetras_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CorreoValido(string correo)
        {
            try
            {
                MailAddress direccion = new MailAddress(correo);

                return direccion.Address.Equals(
                    correo,
                    StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarFormulario()
        {
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres))
            {
                MessageBox.Show(
                    "Ingrese los nombres del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombres.Focus();
                return false;
            }

            if (!Regex.IsMatch(nombres, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los nombres solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombres.Focus();
                txtNombres.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellidos.Focus();
                return false;
            }

            if (!Regex.IsMatch(apellidos, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los apellidos solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellidos.Focus();
                txtApellidos.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show(
                    "Ingrese el teléfono del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }

            if (!Regex.IsMatch(telefono, @"^\d{8}$"))
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 8 números, sin letras, espacios ni guiones.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                txtTelefono.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show(
                    "Ingrese el correo del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return false;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                txtCorreo.SelectAll();
                return false;
            }

            if (cmbPuesto.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(cmbPuesto.Text))
            {
                MessageBox.Show(
                    "Seleccione un puesto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPuesto.Focus();
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBoxEstado_CheckedChanged(
            object sender,
            EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idEmpleado == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidarFormulario())
                return;

            try
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = idEmpleado,
                    NombresEmpleado = txtNombres.Text.Trim(),
                    ApellidosEmpleado = txtApellidos.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Puesto = cmbPuesto.Text,
                    Estado = chkEstado.Checked
                };

                EmpleadoDAO dao = new EmpleadoDAO();

                if (dao.ActualizarEmpleado(empleado))
                {
                    MessageBox.Show(
                        "Empleado actualizado correctamente.",
                        "Sistema Polideportivo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarEmpleados();

                    idEmpleado = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el empleado.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            idEmpleado = 0;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            if (cmbPuesto.Items.Count > 0)
            {
                cmbPuesto.SelectedIndex = 0;
            }

            chkEstado.Checked = true;

            dgvEmpleados.ClearSelection();

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
            if (!ValidarFormulario())
                return;

            try
            {
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
                    MessageBox.Show(
                        "Empleado registrado correctamente.",
                        "Sistema Polideportivo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al registrar el empleado.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = dao.ListarEmpleados();

                dgvEmpleados.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los empleados.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleados_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void dgvEmpleados_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    dgvEmpleados.Rows[e.RowIndex];

                idEmpleado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombres.Text =
                    Convert.ToString(
                        fila.Cells["Nombres"].Value) ?? "";

                txtApellidos.Text =
                    Convert.ToString(
                        fila.Cells["Apellidos"].Value) ?? "";

                txtTelefono.Text =
                    Convert.ToString(
                        fila.Cells["Teléfono"].Value) ?? "";

                txtCorreo.Text =
                    Convert.ToString(
                        fila.Cells["Correo"].Value) ?? "";

                cmbPuesto.Text =
                    Convert.ToString(
                        fila.Cells["Puesto"].Value) ?? "";

                chkEstado.Checked =
                    Convert.ToBoolean(
                        fila.Cells["Estado"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el empleado seleccionado.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEmpleado == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea desactivar este empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                if (dao.EliminarEmpleado(idEmpleado))
                {
                    MessageBox.Show(
                        "Empleado desactivado.",
                        "Sistema Polideportivo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarEmpleados();

                    idEmpleado = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al desactivar el empleado.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                dgvEmpleados.DataSource =
                    dao.BuscarEmpleado(txtBuscar.Text.Trim());

                dgvEmpleados.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar empleados.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;

            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor =
                Color.ForestGreen;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvEmpleados.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvEmpleados.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(144, 238, 144);

            dgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEmpleados.DefaultCellStyle.BackColor =
                Color.White;

            dgvEmpleados.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 255, 240);

            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmpleados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.RowHeadersVisible = false;

            dgvEmpleados.ColumnHeadersHeight = 40;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmMenú nuevoform = new frmMenú();

            nuevoform.Show();

            Hide();
        }
    }
}



