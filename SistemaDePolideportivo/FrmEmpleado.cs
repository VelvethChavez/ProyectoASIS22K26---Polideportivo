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
    public partial class FrmEmpleado : Form
    {
        private int idEmpleado = 0;

        public FrmEmpleado()
        {
            InitializeComponent();

            TxtNombres.KeyPress += SoloLetras_KeyPress;
            TxtApellidos.KeyPress += SoloLetras_KeyPress;
            TxtTelefono.KeyPress += SoloNumeros_KeyPress;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                TxtNombres.MaxLength = 100;
                TxtApellidos.MaxLength = 100;
                TxtTelefono.MaxLength = 8;
                TxtCorreo.MaxLength = 100;

                CargarPuestos();

                ChkEstado.Checked = true;

                TxtNombres.Focus();

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
            string nombres = TxtNombres.Text.Trim();
            string apellidos = TxtApellidos.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();
            string correo = TxtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres))
            {
                MessageBox.Show(
                    "Ingrese los nombres del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombres.Focus();
                return false;
            }

            if (!Regex.IsMatch(nombres, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los nombres solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombres.Focus();
                TxtNombres.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidos.Focus();
                return false;
            }

            if (!Regex.IsMatch(apellidos, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los apellidos solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidos.Focus();
                TxtApellidos.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show(
                    "Ingrese el teléfono del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtTelefono.Focus();
                return false;
            }

            if (!Regex.IsMatch(telefono, @"^\d{8}$"))
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 8 números, sin letras, espacios ni guiones.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtTelefono.Focus();
                TxtTelefono.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show(
                    "Ingrese el correo del empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCorreo.Focus();
                return false;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
                return false;
            }

            if (CmbPuesto.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(CmbPuesto.Text))
            {
                MessageBox.Show(
                    "Seleccione un puesto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbPuesto.Focus();
                return false;
            }

            return true;
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void ChkEstado_CheckedChanged(
            object sender,
            EventArgs e)
        {
        }

        private void BtnEditar_Click(object sender, EventArgs e)
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
                    NombresEmpleado = TxtNombres.Text.Trim(),
                    ApellidosEmpleado = TxtApellidos.Text.Trim(),
                    Telefono = TxtTelefono.Text.Trim(),
                    Correo = TxtCorreo.Text.Trim(),
                    
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
            CmbPuesto.Items.Clear();

            CmbPuesto.Items.Add("Administrador");
            CmbPuesto.Items.Add("Coordinador");
            CmbPuesto.Items.Add("Árbitro");
            CmbPuesto.Items.Add("Secretario");
            CmbPuesto.Items.Add("Auxiliar");

            CmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPuesto.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            idEmpleado = 0;

            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();

            if (CmbPuesto.Items.Count > 0)
            {
                CmbPuesto.SelectedIndex = 0;
            }

            ChkEstado.Checked = true;

            DgvEmpleados.ClearSelection();

            TxtNombres.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                Empleado empleado = new Empleado
                {
                    NombresEmpleado = TxtNombres.Text.Trim(),
                    ApellidosEmpleado = TxtApellidos.Text.Trim(),
                    Telefono = TxtTelefono.Text.Trim(),
                    Correo = TxtCorreo.Text.Trim(),
                    
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

                DgvEmpleados.DataSource = null;
                DgvEmpleados.DataSource = dao.ListarEmpleados();

                DgvEmpleados.ClearSelection();
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

        private void DgvEmpleados_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void DgvEmpleados_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    DgvEmpleados.Rows[e.RowIndex];

                idEmpleado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                TxtNombres.Text =
                    Convert.ToString(
                        fila.Cells["Nombres"].Value) ?? "";

                TxtApellidos.Text =
                    Convert.ToString(
                        fila.Cells["Apellidos"].Value) ?? "";

                TxtTelefono.Text =
                    Convert.ToString(
                        fila.Cells["LblTeléfono"].Value) ?? "";

                TxtCorreo.Text =
                    Convert.ToString(
                        fila.Cells["Correo"].Value) ?? "";

                CmbPuesto.Text =
                    Convert.ToString(
                        fila.Cells["LblPuesto"].Value) ?? "";

                ChkEstado.Checked =
                    Convert.ToBoolean(
                        fila.Cells["LblEstado"].Value);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoDAO dao = new EmpleadoDAO();

                DgvEmpleados.DataSource =
                    dao.BuscarEmpleado(TxtBuscar.Text.Trim());

                DgvEmpleados.ClearSelection();
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

        private void LblBuscar_Click(object sender, EventArgs e)
        {
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            LimpiarCampos();
        }

        private void EstiloDataGridView()
        {
            DgvEmpleados.BackgroundColor = Color.White;
            DgvEmpleados.BorderStyle = BorderStyle.None;

            DgvEmpleados.EnableHeadersVisualStyles = false;
            DgvEmpleados.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            DgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor =
                Color.ForestGreen;

            DgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            DgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            DgvEmpleados.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            DgvEmpleados.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(144, 238, 144);

            DgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            DgvEmpleados.DefaultCellStyle.BackColor =
                Color.White;

            DgvEmpleados.DefaultCellStyle.ForeColor =
                Color.Black;

            DgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 255, 240);

            DgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DgvEmpleados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DgvEmpleados.MultiSelect = false;
            DgvEmpleados.ReadOnly = true;
            DgvEmpleados.AllowUserToAddRows = false;
            DgvEmpleados.AllowUserToDeleteRows = false;
            DgvEmpleados.RowHeadersVisible = false;

            DgvEmpleados.ColumnHeadersHeight = 40;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoform = new FrmMenu();

            nuevoform.Show();

            Hide();
        }
    }
}



