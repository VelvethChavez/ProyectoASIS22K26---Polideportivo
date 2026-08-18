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
    public partial class FrmEntrenadores : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idEntrenadorSeleccionado = 0;

        public FrmEntrenadores()
        {
            InitializeComponent();

            Load += FrmEntrenadores_Load;

            BtnGuardar.Click += BtnGuardar_Click;
            BtnEditar.Click += BtnEditar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;

            Dgv1.CellClick += Dgv1_CellClick;

            TxtNombreEntrenador.KeyPress += SoloLetras_KeyPress;
            TxtApellidoEntrenador.KeyPress += SoloLetras_KeyPress;
            TxtTelefonoEntrenador.KeyPress += SoloNumeros_KeyPress;
        }

        private void FrmEntrenadores_Load(object? sender, EventArgs e)
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

            Lbl1.Text = "GESTIÓN DE ENTRENADORES";
            Lbl1.ForeColor = Color.FromArgb(27, 94, 32);
            Lbl1.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            TxtNombreEntrenador.MaxLength = 100;
            TxtApellidoEntrenador.MaxLength = 100;
            TxtTelefonoEntrenador.MaxLength = 8;
            TxtCorreoEntrenador.MaxLength = 100;

            AplicarEstiloBoton(BtnNuevo);
            AplicarEstiloBoton(BtnGuardar);
            AplicarEstiloBoton(BtnEditar);
            AplicarEstiloBoton(BtnEliminar);

            Dgv1.BackgroundColor = Color.White;
            Dgv1.BorderStyle = BorderStyle.None;
            Dgv1.ReadOnly = true;
            Dgv1.MultiSelect = false;
            Dgv1.AllowUserToAddRows = false;
            Dgv1.AllowUserToDeleteRows = false;
            Dgv1.AllowUserToResizeRows = false;
            Dgv1.RowHeadersVisible = false;

            Dgv1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Dgv1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Dgv1.EnableHeadersVisualStyles = false;

            Dgv1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);

            Dgv1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            Dgv1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            Dgv1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);

            Dgv1.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            Dgv1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void AplicarEstiloBoton(Button boton)
        {
            boton.BackColor = Color.White;
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

                Dgv1.DataSource = tabla;
                Dgv1.ClearSelection();

                if (Dgv1.Columns.Contains("ID"))
                {
                    Dgv1.Columns["ID"].FillWeight = 35;
                }

                if (Dgv1.Columns.Contains("Teléfono"))
                {
                    Dgv1.Columns["Teléfono"].FillWeight = 70;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los entrenadores.", ex);
            }
        }

        private bool ValidarFormulario()
        {
            string nombres = TxtNombreEntrenador.Text.Trim();
            string apellidos = TxtApellidoEntrenador.Text.Trim();
            string telefono = TxtTelefonoEntrenador.Text.Trim();
            string correo = TxtCorreoEntrenador.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres))
            {
                MessageBox.Show(
                    "Ingrese los nombres del entrenador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombreEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(nombres, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "El nombre solamente puede contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombreEntrenador.Focus();
                TxtNombreEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del entrenador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidoEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(apellidos, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Los apellidos solamente pueden contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidoEntrenador.Focus();
                TxtApellidoEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show(
                    "Ingrese el número de teléfono.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtTelefonoEntrenador.Focus();
                return false;
            }

            if (!Regex.IsMatch(telefono, @"^\d{8}$"))
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 8 números, sin letras, espacios ni guiones.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtTelefonoEntrenador.Focus();
                TxtTelefonoEntrenador.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCorreoEntrenador.Focus();
                return false;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show(
                    "Ingrese una dirección de correo válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCorreoEntrenador.Focus();
                TxtCorreoEntrenador.SelectAll();
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

        private void BtnGuardar_Click(object? sender, EventArgs e)
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
                            TxtNombreEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            TxtApellidoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@telefono",
                            TxtTelefonoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@correo",
                            TxtCorreoEntrenador.Text.Trim());

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

        private void BtnEditar_Click(object? sender, EventArgs e)
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
                            TxtNombreEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            TxtApellidoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@telefono",
                            TxtTelefonoEntrenador.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@correo",
                            TxtCorreoEntrenador.Text.Trim());

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

        private void BtnEliminar_Click(object? sender, EventArgs e)
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

        private void BtnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void Dgv1_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    Dgv1.Rows[e.RowIndex];

                idEntrenadorSeleccionado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                TxtNombreEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Nombres"].Value) ?? "";

                TxtApellidoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Apellidos"].Value) ?? "";

                TxtTelefonoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Teléfono"].Value) ?? "";

                TxtCorreoEntrenador.Text =
                    Convert.ToString(
                        fila.Cells["Correo"].Value) ?? "";

                BtnGuardar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
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

            TxtNombreEntrenador.Clear();
            TxtApellidoEntrenador.Clear();
            TxtTelefonoEntrenador.Clear();
            TxtCorreoEntrenador.Clear();

            Dgv1.ClearSelection();

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            TxtNombreEntrenador.Focus();
        }

        private void Dgv1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void Lbl4_Click(object sender, EventArgs e)
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

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}