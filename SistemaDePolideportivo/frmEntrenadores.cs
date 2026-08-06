using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmEntrenadores : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idEntrenadorSeleccionado = 0;

        public frmEntrenadores()
        {
            InitializeComponent();

            Load += frmEntrenadores_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnNuevo.Click += btnNuevo_Click;

            dataGridView1.CellClick += dataGridView1_CellClick;

            txtNombreEntrenador.KeyPress += SoloLetras_KeyPress;
            txtApellidoEntrenador.KeyPress += SoloLetras_KeyPress;
            txtTelefonoEntrenador.KeyPress += SoloNumeros_KeyPress;
        }

        private void frmEntrenadores_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                CargarEntrenadores();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo iniciar el formulario.", ex);
            }
        }

        private void ConfigurarFormulario()
        {
            BackColor = Color.FromArgb(241, 248, 233);

            label1.Text = "GESTIÓN DE ENTRENADORES";
            label1.ForeColor = Color.FromArgb(27, 94, 32);
            label1.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            txtNombreEntrenador.MaxLength = 100;
            txtApellidoEntrenador.MaxLength = 100;
            txtTelefonoEntrenador.MaxLength = 8;
            txtCorreoEntrenador.MaxLength = 100;

            AplicarEstiloBoton(btnNuevo);
            AplicarEstiloBoton(btnGuardar);
            AplicarEstiloBoton(btnEditar);
            AplicarEstiloBoton(btnEliminar);

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void AplicarEstiloBoton(Button boton)
        {
            boton.BackColor = Color.FromArgb(56, 142, 60);
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
        }

        private void SoloLetras_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarEntrenadores()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            id_entrenador AS ID,
                            nombres_entrenador AS Nombres,
                            apellidos_entrenador AS Apellidos,
                            telefono AS Teléfono,
                            correo AS Correo
                        FROM Entrenador
                        ORDER BY id_entrenador DESC;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                dataGridView1.DataSource = tabla;
                dataGridView1.ClearSelection();

                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].FillWeight = 35;
                }

                if (dataGridView1.Columns.Contains("Teléfono"))
                {
                    dataGridView1.Columns["Teléfono"].FillWeight = 70;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los entrenadores.", ex);
            }
        }

        private bool ValidarFormulario()
        {
            string nombres = txtNombreEntrenador.Text.Trim();
            string apellidos = txtApellidoEntrenador.Text.Trim();
            string telefono = txtTelefonoEntrenador.Text.Trim();
            string correo = txtCorreoEntrenador.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres))
            {
                MessageBox.Show(
                    "Ingrese los nombres del entrenador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(nombres, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "El nombre solamente puede contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreEntrenador.Focus();
                txtNombreEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del entrenador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellidoEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(apellidos, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los apellidos solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellidoEntrenador.Focus();
                txtApellidoEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show(
                    "Ingrese el número de teléfono.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefonoEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(telefono, @"^\d{8}$"))
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 8 números, sin letras, espacios ni guiones.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefonoEntrenador.Focus();
                txtTelefonoEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreoEntrenador.Focus();
                return false;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show(
                    "Ingrese una dirección de correo válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreoEntrenador.Focus();
                txtCorreoEntrenador.SelectAll();
                return false;
            }

            return true;
        }

        private bool CorreoValido(string correo)
        {
            try
            {
                MailAddress direccion = new MailAddress(correo);
                return direccion.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        INSERT INTO Entrenador
                        (
                            nombres_entrenador,
                            apellidos_entrenador,
                            telefono,
                            correo
                        )
                        VALUES
                        (
                            @nombres,
                            @apellidos,
                            @telefono,
                            @correo
                        );";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombres",
                            txtNombreEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            txtApellidoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefonoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@correo",
                            txtCorreoEntrenador.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Entrenador registrado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEntrenadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al guardar el entrenador.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al guardar el entrenador.", ex);
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (idEntrenadorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un entrenador en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidarFormulario())
                return;

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        UPDATE Entrenador
                        SET
                            nombres_entrenador = @nombres,
                            apellidos_entrenador = @apellidos,
                            telefono = @telefono,
                            correo = @correo
                        WHERE id_entrenador = @idEntrenador;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombres",
                            txtNombreEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            txtApellidoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefonoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@correo",
                            txtCorreoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@idEntrenador",
                            idEntrenadorSeleccionado);

                        int filasActualizadas = comando.ExecuteNonQuery();

                        if (filasActualizadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el entrenador seleccionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Entrenador actualizado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEntrenadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al actualizar el entrenador.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al actualizar el entrenador.", ex);
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idEntrenadorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un entrenador en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar al entrenador?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consultaVerificacion = @"
                        SELECT COUNT(*)
                        FROM Equipo
                        WHERE id_entrenador = @idEntrenador;";

                    using (MySqlCommand verificar =
                           new MySqlCommand(
                               consultaVerificacion,
                               conexion))
                    {
                        verificar.Parameters.AddWithValue(
                            "@idEntrenador",
                            idEntrenadorSeleccionado);

                        int equiposAsignados =
                            Convert.ToInt32(verificar.ExecuteScalar());

                        if (equiposAsignados > 0)
                        {
                            MessageBox.Show(
                                "No se puede eliminar al entrenador porque " +
                                "tiene uno o más equipos asignados.",
                                "Eliminación no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    string consultaEliminar = @"
                        DELETE FROM Entrenador
                        WHERE id_entrenador = @idEntrenador;";

                    using (MySqlCommand eliminar =
                           new MySqlCommand(
                               consultaEliminar,
                               conexion))
                    {
                        eliminar.Parameters.AddWithValue(
                            "@idEntrenador",
                            idEntrenadorSeleccionado);

                        eliminar.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Entrenador eliminado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEntrenadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al eliminar el entrenador.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al eliminar el entrenador.", ex);
            }
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dataGridView1_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    dataGridView1.Rows[e.RowIndex];

                idEntrenadorSeleccionado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombreEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Nombres"].Value) ?? "";

                txtApellidoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Apellidos"].Value) ?? "";

                txtTelefonoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Teléfono"].Value) ?? "";

                txtCorreoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Correo"].Value) ?? "";

                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo cargar el entrenador seleccionado.",
                    ex);
            }
        }

        private void LimpiarFormulario()
        {
            idEntrenadorSeleccionado = 0;

            txtNombreEntrenador.Clear();
            txtApellidoEntrenador.Clear();
            txtTelefonoEntrenador.Clear();
            txtCorreoEntrenador.Clear();

            dataGridView1.ClearSelection();

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombreEntrenador.Focus();
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(
                mensaje + "\n\n" + ex.Message,
                "Sistema Polideportivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}