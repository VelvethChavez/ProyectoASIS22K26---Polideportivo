using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmJugadores : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idJugadorSeleccionado = 0;

        public frmJugadores()
        {
            InitializeComponent();

            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnExaminar.Click += btnExaminar_Click;
            dgvJugadores.CellClick += dgvJugadores_CellClick;
        }

        private void frmJugadores_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                CargarPosiciones();
                CargarEquipos();
                CargarJugadores();
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

            cmbPosicionJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoJugadores.DropDownStyle = ComboBoxStyle.DropDownList;

            nudDorsalJugadores.Minimum = 0;
            nudDorsalJugadores.Maximum = 999;
            nudDorsalJugadores.TextAlign = HorizontalAlignment.Center;

            dtpNacimientoJugadores.Format = DateTimePickerFormat.Short;
            dtpNacimientoJugadores.MaxDate = DateTime.Today;

            ptbFotoJugador.SizeMode = PictureBoxSizeMode.Zoom;
            ptbFotoJugador.BorderStyle = BorderStyle.FixedSingle;

            dgvJugadores.BackgroundColor = Color.White;
            dgvJugadores.BorderStyle = BorderStyle.None;
            dgvJugadores.ReadOnly = true;
            dgvJugadores.MultiSelect = false;
            dgvJugadores.RowHeadersVisible = false;
            dgvJugadores.AllowUserToAddRows = false;
            dgvJugadores.AllowUserToDeleteRows = false;
            dgvJugadores.AllowUserToResizeRows = false;
            dgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvJugadores.EnableHeadersVisualStyles = false;
            dgvJugadores.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);
            dgvJugadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvJugadores.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvJugadores.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);
            dgvJugadores.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvJugadores.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            AplicarEstiloBoton(btnNuevo);
            AplicarEstiloBoton(btnGuardar);
            AplicarEstiloBoton(btnEditar);
            AplicarEstiloBoton(btnEliminar);
            AplicarEstiloBoton(btnExaminar);
        }

        private void AplicarEstiloBoton(Button boton)
        {
            boton.BackColor = Color.FromArgb(56, 142, 60);
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
        }

        private void CargarPosiciones()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            id_posicion,
                            nombre_posicion
                        FROM Posicion
                        ORDER BY nombre_posicion;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                cmbPosicionJugadores.DataSource = tabla;
                cmbPosicionJugadores.DisplayMember = "nombre_posicion";
                cmbPosicionJugadores.ValueMember = "id_posicion";
                cmbPosicionJugadores.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar las posiciones.", ex);
            }
        }

        private void CargarEquipos()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            id_equipo,
                            nombre_equipo
                        FROM Equipo
                        WHERE estado = 1
                        ORDER BY nombre_equipo;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                cmbEquipoJugadores.DataSource = tabla;
                cmbEquipoJugadores.DisplayMember = "nombre_equipo";
                cmbEquipoJugadores.ValueMember = "id_equipo";
                cmbEquipoJugadores.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los equipos.", ex);
            }
        }

        private void CargarJugadores()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            j.id_jugador AS ID,
                            j.nombres_jugador AS Nombres,
                            j.apellidos_jugador AS Apellidos,
                            j.fecha_nacimiento AS Nacimiento,
                            j.fotografia AS Fotografia,
                            j.dorsal AS Dorsal,
                            p.nombre_posicion AS Posicion,
                            e.nombre_equipo AS Equipo,
                            CASE
                                WHEN j.estado = 1 THEN 'Activo'
                                ELSE 'Inactivo'
                            END AS Estado,
                            j.id_posicion,
                            j.id_equipo
                        FROM Jugador j
                        INNER JOIN Posicion p
                            ON j.id_posicion = p.id_posicion
                        INNER JOIN Equipo e
                            ON j.id_equipo = e.id_equipo
                        ORDER BY j.id_jugador DESC;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                dgvJugadores.DataSource = tabla;
                ConfigurarColumnasGrid();
                dgvJugadores.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los jugadores.", ex);
            }
        }

        private void ConfigurarColumnasGrid()
        {
            if (dgvJugadores.Columns.Contains("Fotografia"))
                dgvJugadores.Columns["Fotografia"].Visible = false;

            if (dgvJugadores.Columns.Contains("id_posicion"))
                dgvJugadores.Columns["id_posicion"].Visible = false;

            if (dgvJugadores.Columns.Contains("id_equipo"))
                dgvJugadores.Columns["id_equipo"].Visible = false;

            if (dgvJugadores.Columns.Contains("ID"))
                dgvJugadores.Columns["ID"].FillWeight = 40;

            if (dgvJugadores.Columns.Contains("Dorsal"))
                dgvJugadores.Columns["Dorsal"].FillWeight = 50;

            if (dgvJugadores.Columns.Contains("Estado"))
                dgvJugadores.Columns["Estado"].FillWeight = 60;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombresJugadores.Text))
            {
                MessageBox.Show(
                    "Ingrese los nombres del jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombresJugadores.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidosJugadores.Text))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellidosJugadores.Focus();
                return false;
            }

            if (dtpNacimientoJugadores.Value.Date >= DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de nacimiento debe ser anterior a la fecha actual.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpNacimientoJugadores.Focus();
                return false;
            }

            if (cmbPosicionJugadores.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione una posición.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPosicionJugadores.Focus();
                return false;
            }

            if (cmbEquipoJugadores.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEquipoJugadores.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        INSERT INTO Jugador
                        (
                            nombres_jugador,
                            apellidos_jugador,
                            fecha_nacimiento,
                            fotografia,
                            dorsal,
                            estado,
                            id_posicion,
                            id_equipo
                        )
                        VALUES
                        (
                            @nombres,
                            @apellidos,
                            @fechaNacimiento,
                            @fotografia,
                            @dorsal,
                            @estado,
                            @idPosicion,
                            @idEquipo
                        );";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombres",
                            txtNombresJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            txtApellidosJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@fechaNacimiento",
                            dtpNacimientoJugadores.Value.Date);

                        comando.Parameters.AddWithValue(
                            "@fotografia",
                            string.IsNullOrWhiteSpace(txtFotoJugadores.Text)
                                ? DBNull.Value
                                : txtFotoJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@dorsal",
                            Convert.ToInt32(nudDorsalJugadores.Value));

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ckbEstadoJugadores.Checked);

                        comando.Parameters.AddWithValue(
                            "@idPosicion",
                            Convert.ToInt32(cmbPosicionJugadores.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            Convert.ToInt32(cmbEquipoJugadores.SelectedValue));

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Jugador registrado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarJugadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al guardar el jugador.", ex);
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (idJugadorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un jugador en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidarFormulario())
                return;

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        UPDATE Jugador
                        SET
                            nombres_jugador = @nombres,
                            apellidos_jugador = @apellidos,
                            fecha_nacimiento = @fechaNacimiento,
                            fotografia = @fotografia,
                            dorsal = @dorsal,
                            estado = @estado,
                            id_posicion = @idPosicion,
                            id_equipo = @idEquipo
                        WHERE id_jugador = @idJugador;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombres",
                            txtNombresJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            txtApellidosJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@fechaNacimiento",
                            dtpNacimientoJugadores.Value.Date);

                        comando.Parameters.AddWithValue(
                            "@fotografia",
                            string.IsNullOrWhiteSpace(txtFotoJugadores.Text)
                                ? DBNull.Value
                                : txtFotoJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@dorsal",
                            Convert.ToInt32(nudDorsalJugadores.Value));

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ckbEstadoJugadores.Checked);

                        comando.Parameters.AddWithValue(
                            "@idPosicion",
                            Convert.ToInt32(cmbPosicionJugadores.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            Convert.ToInt32(cmbEquipoJugadores.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idJugador",
                            idJugadorSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Jugador actualizado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarJugadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al actualizar el jugador.", ex);
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idJugadorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un jugador en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea desactivar al jugador seleccionado?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        UPDATE Jugador
                        SET estado = 0
                        WHERE id_jugador = @idJugador;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idJugador",
                            idJugadorSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Jugador desactivado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarJugadores();
                LimpiarFormulario();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al desactivar el jugador.", ex);
            }
        }

        private void btnExaminar_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog())
            {
                abrir.Title = "Seleccionar fotografía del jugador";
                abrir.Filter =
                    "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|" +
                    "Todos los archivos|*.*";

                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    txtFotoJugadores.Text = abrir.FileName;
                    MostrarFotografia(abrir.FileName);
                }
            }
        }

        private void dgvJugadores_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = dgvJugadores.Rows[e.RowIndex];

                idJugadorSeleccionado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombresJugadores.Text =
                    Convert.ToString(fila.Cells["Nombres"].Value) ?? "";

                txtApellidosJugadores.Text =
                    Convert.ToString(fila.Cells["Apellidos"].Value) ?? "";

                dtpNacimientoJugadores.Value =
                    Convert.ToDateTime(fila.Cells["Nacimiento"].Value);

                txtFotoJugadores.Text =
                    Convert.ToString(fila.Cells["Fotografia"].Value) ?? "";

                nudDorsalJugadores.Value =
                    ConvertirDecimalSeguro(fila.Cells["Dorsal"].Value);

                cmbPosicionJugadores.SelectedValue =
                    Convert.ToInt32(fila.Cells["id_posicion"].Value);

                cmbEquipoJugadores.SelectedValue =
                    Convert.ToInt32(fila.Cells["id_equipo"].Value);

                string estado =
                    Convert.ToString(fila.Cells["Estado"].Value) ?? "";

                ckbEstadoJugadores.Checked =
                    estado.Equals(
                        "Activo",
                        StringComparison.OrdinalIgnoreCase);

                MostrarFotografia(txtFotoJugadores.Text);

                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo cargar el jugador seleccionado.", ex);
            }
        }

        private decimal ConvertirDecimalSeguro(object? valor)
        {
            if (valor == null || valor == DBNull.Value)
                return 0;

            decimal resultado = Convert.ToDecimal(valor);

            if (resultado < nudDorsalJugadores.Minimum)
                return nudDorsalJugadores.Minimum;

            if (resultado > nudDorsalJugadores.Maximum)
                return nudDorsalJugadores.Maximum;

            return resultado;
        }

        private void MostrarFotografia(string ruta)
        {
            if (ptbFotoJugador.Image != null)
            {
                ptbFotoJugador.Image.Dispose();
                ptbFotoJugador.Image = null;
            }

            if (string.IsNullOrWhiteSpace(ruta) || !File.Exists(ruta))
                return;

            try
            {
                using (FileStream archivo =
                       new FileStream(
                           ruta,
                           FileMode.Open,
                           FileAccess.Read))
                {
                    using (Image imagenTemporal = Image.FromStream(archivo))
                    {
                        ptbFotoJugador.Image =
                            new Bitmap(imagenTemporal);
                    }
                }
            }
            catch
            {
                ptbFotoJugador.Image = null;
            }
        }

        private void LimpiarFormulario()
        {
            idJugadorSeleccionado = 0;

            txtNombresJugadores.Clear();
            txtApellidosJugadores.Clear();
            txtFotoJugadores.Clear();

            dtpNacimientoJugadores.Value = DateTime.Today;
            nudDorsalJugadores.Value = 0;

            cmbPosicionJugadores.SelectedIndex = -1;
            cmbEquipoJugadores.SelectedIndex = -1;

            ckbEstadoJugadores.Checked = true;

            if (ptbFotoJugador.Image != null)
            {
                ptbFotoJugador.Image.Dispose();
                ptbFotoJugador.Image = null;
            }

            dgvJugadores.ClearSelection();

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombresJugadores.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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