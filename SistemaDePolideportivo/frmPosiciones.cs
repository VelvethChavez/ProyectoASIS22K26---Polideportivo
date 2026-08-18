using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmPosiciones : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idPosicionSeleccionada = 0;

        public FrmPosiciones()
        {
            InitializeComponent();

            Load += FrmPosiciones_Load;

            BtnGuardar.Click += BtnGuardar_Click;
            BtnEditar.Click += BtnEditar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;

            Dgv1.CellClick += Dgv1_CellClick;

            TxtNombrePosicion.KeyPress += SoloLetras_KeyPress;
        }

        private void FrmPosiciones_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                CargarPosiciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo iniciar el formulario.",
                    ex);
            }
        }

        private void ConfigurarFormulario()
        {
            BackColor = Color.FromArgb(241, 248, 233);

            Lbl1.Text = "GESTIÓN DE POSICIONES";
            Lbl1.ForeColor = Color.FromArgb(27, 94, 32);
            Lbl1.Font =
                new Font("Segoe UI", 16, FontStyle.Bold);

            TxtNombrePosicion.MaxLength = 50;
            TxtDescripcion.MaxLength = 255;

            AplicarEstiloBoton(BtnNuevo);
            AplicarEstiloBoton(BtnGuardar);
            AplicarEstiloBoton(BtnEditar);
            AplicarEstiloBoton(BtnEliminar);

            Dgv1.BackgroundColor = Color.White;
            Dgv1.BorderStyle = BorderStyle.None;
            Dgv1.ReadOnly = true;
            Dgv1.MultiSelect = false;
            Dgv1.RowHeadersVisible = false;
            Dgv1.AllowUserToAddRows = false;
            Dgv1.AllowUserToDeleteRows = false;
            Dgv1.AllowUserToResizeRows = false;

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
            boton.BackColor = Color.FromArgb(56, 142, 60);
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
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

        private void CargarPosiciones()
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
                            id_posicion AS ID,
                            nombre_posicion AS Posición,
                            descripcion AS Descripción
                        FROM Posicion
                        ORDER BY id_posicion DESC;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(
                               consulta,
                               conexion))
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
            }
            catch (Exception ex)
            {
                MostrarError(
                    "Error al cargar las posiciones.",
                    ex);
            }
        }

        private bool ValidarFormulario()
        {
            string nombre = TxtNombrePosicion.Text.Trim();
            string descripcion = TxtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la posición.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombrePosicion.Focus();
                return false;
            }

            if (!Regex.IsMatch(nombre, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "El nombre de la posición solamente puede " +
                    "contener letras y espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombrePosicion.Focus();
                TxtNombrePosicion.SelectAll();
                return false;
            }

            if (nombre.Length > 50)
            {
                MessageBox.Show(
                    "El nombre de la posición no puede superar " +
                    "los 50 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombrePosicion.Focus();
                TxtNombrePosicion.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show(
                    "Ingrese la descripción de la posición.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtDescripcion.Focus();
                return false;
            }

            if (descripcion.Length > 255)
            {
                MessageBox.Show(
                    "La descripción no puede superar " +
                    "los 255 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtDescripcion.Focus();
                TxtDescripcion.SelectAll();
                return false;
            }

            return true;
        }

        private bool PosicionDuplicada(
            MySqlConnection conexion,
            string nombre,
            int idExcluir = 0)
        {
            string consulta = @"
                SELECT COUNT(*)
                FROM Posicion
                WHERE LOWER(TRIM(nombre_posicion)) =
                      LOWER(TRIM(@nombre))
                  AND id_posicion <> @idExcluir;";

            using (MySqlCommand comando =
                   new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue(
                    "@nombre",
                    nombre);

                comando.Parameters.AddWithValue(
                    "@idExcluir",
                    idExcluir);

                return Convert.ToInt32(
                    comando.ExecuteScalar()) > 0;
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

                    string nombre = TxtNombrePosicion.Text.Trim();

                    if (PosicionDuplicada(conexion, nombre))
                    {
                        MessageBox.Show(
                            "Ya existe una posición con ese nombre.",
                            "Registro duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        TxtNombrePosicion.Focus();
                        return;
                    }

                    string consulta = @"
                        INSERT INTO Posicion
                        (
                            nombre_posicion,
                            descripcion
                        )
                        VALUES
                        (
                            @nombre,
                            @descripcion
                        );";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombre",
                            nombre);

                        comando.Parameters.AddWithValue(
                            "@descripcion",
                            string.IsNullOrWhiteSpace(TxtDescripcion.Text)
                                ? DBNull.Value
                                : TxtDescripcion.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Posición registrada correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPosiciones();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al guardar la posición.", ex);
            }
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            if (idPosicionSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una posición en la tabla.",
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

                    string nombre = TxtNombrePosicion.Text.Trim();

                    if (PosicionDuplicada(
                            conexion,
                            nombre,
                            idPosicionSeleccionada))
                    {
                        MessageBox.Show(
                            "Ya existe otra posición con ese nombre.",
                            "Registro duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        TxtNombrePosicion.Focus();
                        return;
                    }

                    string consulta = @"
                        UPDATE Posicion
                        SET
                            nombre_posicion = @nombre,
                            descripcion = @descripcion
                        WHERE id_posicion = @idPosicion;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombre",
                            nombre);

                        comando.Parameters.AddWithValue(
                            "@descripcion",
                            string.IsNullOrWhiteSpace(TxtDescripcion.Text)
                                ? DBNull.Value
                                : TxtDescripcion.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@idPosicion",
                            idPosicionSeleccionada);

                        int filasActualizadas = comando.ExecuteNonQuery();

                        if (filasActualizadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró la posición seleccionada.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Posición actualizada correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPosiciones();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al actualizar la posición.", ex);
            }
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (idPosicionSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una posición en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar la posición?",
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
                        FROM Jugador
                        WHERE id_posicion = @idPosicion;";

                    using (MySqlCommand verificar =
                           new MySqlCommand(
                               consultaVerificacion,
                               conexion))
                    {
                        verificar.Parameters.AddWithValue(
                            "@idPosicion",
                            idPosicionSeleccionada);

                        int jugadoresAsignados =
                            Convert.ToInt32(verificar.ExecuteScalar());

                        if (jugadoresAsignados > 0)
                        {
                            MessageBox.Show(
                                "No se puede eliminar la posición porque " +
                                "tiene uno o más jugadores asignados.",
                                "Eliminación no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    string consultaEliminar = @"
                        DELETE FROM Posicion
                        WHERE id_posicion = @idPosicion;";

                    using (MySqlCommand eliminar =
                           new MySqlCommand(
                               consultaEliminar,
                               conexion))
                    {
                        eliminar.Parameters.AddWithValue(
                            "@idPosicion",
                            idPosicionSeleccionada);

                        eliminar.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Posición eliminada correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPosiciones();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al eliminar la posición.", ex);
            }
        }

        private void BtnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
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

                idPosicionSeleccionada =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                TxtNombrePosicion.Text =
                    Convert.ToString(
                        fila.Cells["Posición"].Value) ?? "";

                TxtDescripcion.Text =
                    Convert.ToString(
                        fila.Cells["Descripción"].Value) ?? "";

                BtnGuardar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo cargar la posición seleccionada.",
                    ex);
            }
        }

        private void LimpiarCampos()
        {
            idPosicionSeleccionada = 0;

            TxtNombrePosicion.Clear();
            TxtDescripcion.Clear();

            Dgv1.ClearSelection();

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            TxtNombrePosicion.Focus();
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