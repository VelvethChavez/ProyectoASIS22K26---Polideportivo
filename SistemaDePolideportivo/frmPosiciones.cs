using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmPosiciones : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idPosicionSeleccionada = 0;

        public frmPosiciones()
        {
            InitializeComponent();

            Load += frmPosiciones_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnNuevo.Click += btnNuevo_Click;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void frmPosiciones_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                CargarPosiciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo iniciar el formulario.", ex);
            }
        }

        private void ConfigurarFormulario()
        {
            BackColor = Color.FromArgb(241, 248, 233);

            label1.Text = "GESTIÓN DE POSICIONES";
            label1.ForeColor = Color.FromArgb(27, 94, 32);
            label1.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            AplicarEstiloBoton(btnNuevo);
            AplicarEstiloBoton(btnGuardar);
            AplicarEstiloBoton(btnEditar);
            AplicarEstiloBoton(btnEliminar);

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;

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
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar las posiciones.", ex);
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(NombrePosicion.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la posición.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                NombrePosicion.Focus();
                return false;
            }

            if (NombrePosicion.Text.Trim().Length > 50)
            {
                MessageBox.Show(
                    "El nombre de la posición no puede superar 50 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                NombrePosicion.Focus();
                return false;
            }

            if (txtDescripcion.Text.Trim().Length > 255)
            {
                MessageBox.Show(
                    "La descripción no puede superar 255 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDescripcion.Focus();
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
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@idExcluir", idExcluir);

                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
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

                    string nombre = NombrePosicion.Text.Trim();

                    if (PosicionDuplicada(conexion, nombre))
                    {
                        MessageBox.Show(
                            "Ya existe una posición con ese nombre.",
                            "Registro duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        NombrePosicion.Focus();
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
                            string.IsNullOrWhiteSpace(txtDescripcion.Text)
                                ? DBNull.Value
                                : txtDescripcion.Text.Trim());

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

        private void btnEditar_Click(object? sender, EventArgs e)
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

                    string nombre = NombrePosicion.Text.Trim();

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

                        NombrePosicion.Focus();
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
                            string.IsNullOrWhiteSpace(txtDescripcion.Text)
                                ? DBNull.Value
                                : txtDescripcion.Text.Trim());

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

        private void btnEliminar_Click(object? sender, EventArgs e)
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

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
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

                idPosicionSeleccionada =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                NombrePosicion.Text =
                    Convert.ToString(
                        fila.Cells["Posición"].Value) ?? "";

                txtDescripcion.Text =
                    Convert.ToString(
                        fila.Cells["Descripción"].Value) ?? "";

                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
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

            NombrePosicion.Clear();
            txtDescripcion.Clear();

            dataGridView1.ClearSelection();

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            NombrePosicion.Focus();
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