using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmJugadores : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idJugadorSeleccionado = 0;

        public FrmJugadores()
        {
            InitializeComponent();

            BtnGuardar.Click += BtnGuardar_Click;
            BtnEditar.Click += BtnEditar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnExaminar.Click += BtnExaminar_Click;
            DgvJugadores.CellClick += DgvJugadores_CellClick;
        }

        private void FrmJugadores_Load(object sender, EventArgs e)
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

            CmbPosicionJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoJugadores.DropDownStyle = ComboBoxStyle.DropDownList;

            NudDorsalJugadores.Minimum = 0;
            NudDorsalJugadores.Maximum = 999;
            NudDorsalJugadores.TextAlign = HorizontalAlignment.Center;

            DtpNacimientoJugadores.Format = DateTimePickerFormat.Short;
            DtpNacimientoJugadores.MaxDate = DateTime.Today;

            PicPtbFotoJugador.SizeMode = PictureBoxSizeMode.Zoom;
            PicPtbFotoJugador.BorderStyle = BorderStyle.FixedSingle;

            DgvJugadores.BackgroundColor = Color.White;
            DgvJugadores.BorderStyle = BorderStyle.None;
            DgvJugadores.ReadOnly = true;
            DgvJugadores.MultiSelect = false;
            DgvJugadores.RowHeadersVisible = false;
            DgvJugadores.AllowUserToAddRows = false;
            DgvJugadores.AllowUserToDeleteRows = false;
            DgvJugadores.AllowUserToResizeRows = false;
            DgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvJugadores.EnableHeadersVisualStyles = false;
            DgvJugadores.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);
            DgvJugadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvJugadores.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            DgvJugadores.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);
            DgvJugadores.DefaultCellStyle.SelectionForeColor = Color.Black;
            DgvJugadores.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            AplicarEstiloBoton(BtnNuevo);
            AplicarEstiloBoton(BtnGuardar);
            AplicarEstiloBoton(BtnEditar);
            AplicarEstiloBoton(BtnEliminar);
            AplicarEstiloBoton(BtnExaminar);
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

                CmbPosicionJugadores.DataSource = tabla;
                CmbPosicionJugadores.DisplayMember = "nombre_posicion";
                CmbPosicionJugadores.ValueMember = "id_posicion";
                CmbPosicionJugadores.SelectedIndex = -1;
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

                CmbEquipoJugadores.DataSource = tabla;
                CmbEquipoJugadores.DisplayMember = "nombre_equipo";
                CmbEquipoJugadores.ValueMember = "id_equipo";
                CmbEquipoJugadores.SelectedIndex = -1;
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

                DgvJugadores.DataSource = tabla;
                ConfigurarColumnasGrid();
                DgvJugadores.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los jugadores.", ex);
            }
        }

        private void ConfigurarColumnasGrid()
        {
            if (DgvJugadores.Columns.Contains("Fotografia"))
                DgvJugadores.Columns["Fotografia"].Visible = false;

            if (DgvJugadores.Columns.Contains("id_posicion"))
                DgvJugadores.Columns["id_posicion"].Visible = false;

            if (DgvJugadores.Columns.Contains("id_equipo"))
                DgvJugadores.Columns["id_equipo"].Visible = false;

            if (DgvJugadores.Columns.Contains("ID"))
                DgvJugadores.Columns["ID"].FillWeight = 40;

            if (DgvJugadores.Columns.Contains("Dorsal"))
                DgvJugadores.Columns["Dorsal"].FillWeight = 50;

            if (DgvJugadores.Columns.Contains("Estado"))
                DgvJugadores.Columns["Estado"].FillWeight = 60;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(TxtNombresJugadores.Text))
            {
                MessageBox.Show(
                    "Ingrese los nombres del jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombresJugadores.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtApellidosJugadores.Text))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidosJugadores.Focus();
                return false;
            }

            if (DtpNacimientoJugadores.Value.Date >= DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de nacimiento debe ser anterior a la fecha actual.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DtpNacimientoJugadores.Focus();
                return false;
            }

            if (CmbPosicionJugadores.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione una posición.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbPosicionJugadores.Focus();
                return false;
            }

            if (CmbEquipoJugadores.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbEquipoJugadores.Focus();
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
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
                            TxtNombresJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            TxtApellidosJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@fechaNacimiento",
                            DtpNacimientoJugadores.Value.Date);

                        comando.Parameters.AddWithValue(
                            "@fotografia",
                            string.IsNullOrWhiteSpace(TxtFotoJugadores.Text)
                                ? DBNull.Value
                                : TxtFotoJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@dorsal",
                            Convert.ToInt32(NudDorsalJugadores.Value));

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ChkCkbEstadoJugadores.Checked);

                        comando.Parameters.AddWithValue(
                            "@idPosicion",
                            Convert.ToInt32(CmbPosicionJugadores.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            Convert.ToInt32(CmbEquipoJugadores.SelectedValue));

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

        private void BtnEditar_Click(object? sender, EventArgs e)
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
                            TxtNombresJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidos",
                            TxtApellidosJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@fechaNacimiento",
                            DtpNacimientoJugadores.Value.Date);

                        comando.Parameters.AddWithValue(
                            "@fotografia",
                            string.IsNullOrWhiteSpace(TxtFotoJugadores.Text)
                                ? DBNull.Value
                                : TxtFotoJugadores.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@dorsal",
                            Convert.ToInt32(NudDorsalJugadores.Value));

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ChkCkbEstadoJugadores.Checked);

                        comando.Parameters.AddWithValue(
                            "@idPosicion",
                            Convert.ToInt32(CmbPosicionJugadores.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            Convert.ToInt32(CmbEquipoJugadores.SelectedValue));

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

        private void BtnEliminar_Click(object? sender, EventArgs e)
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

        private void BtnExaminar_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog())
            {
                abrir.Title = "Seleccionar fotografía del jugador";
                abrir.Filter =
                    "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|" +
                    "Todos los archivos|*.*";

                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    TxtFotoJugadores.Text = abrir.FileName;
                    MostrarFotografia(abrir.FileName);
                }
            }
        }

        private void DgvJugadores_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = DgvJugadores.Rows[e.RowIndex];

                idJugadorSeleccionado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                TxtNombresJugadores.Text =
                    Convert.ToString(fila.Cells["Nombres"].Value) ?? "";

                TxtApellidosJugadores.Text =
                    Convert.ToString(fila.Cells["Apellidos"].Value) ?? "";

                DtpNacimientoJugadores.Value =
                    Convert.ToDateTime(fila.Cells["Nacimiento"].Value);

                TxtFotoJugadores.Text =
                    Convert.ToString(fila.Cells["Fotografia"].Value) ?? "";

                NudDorsalJugadores.Value =
                    ConvertirDecimalSeguro(fila.Cells["Dorsal"].Value);

                CmbPosicionJugadores.SelectedValue =
                    Convert.ToInt32(fila.Cells["id_posicion"].Value);

                CmbEquipoJugadores.SelectedValue =
                    Convert.ToInt32(fila.Cells["id_equipo"].Value);

                string estado =
                    Convert.ToString(fila.Cells["Estado"].Value) ?? "";

                ChkCkbEstadoJugadores.Checked =
                    estado.Equals(
                        "Activo",
                        StringComparison.OrdinalIgnoreCase);

                MostrarFotografia(TxtFotoJugadores.Text);

                BtnGuardar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
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

            if (resultado < NudDorsalJugadores.Minimum)
                return NudDorsalJugadores.Minimum;

            if (resultado > NudDorsalJugadores.Maximum)
                return NudDorsalJugadores.Maximum;

            return resultado;
        }

        private void MostrarFotografia(string ruta)
        {
            if (PicPtbFotoJugador.Image != null)
            {
                PicPtbFotoJugador.Image.Dispose();
                PicPtbFotoJugador.Image = null;
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
                        PicPtbFotoJugador.Image =
                            new Bitmap(imagenTemporal);
                    }
                }
            }
            catch
            {
                PicPtbFotoJugador.Image = null;
            }
        }

        private void LimpiarFormulario()
        {
            idJugadorSeleccionado = 0;

            TxtNombresJugadores.Clear();
            TxtApellidosJugadores.Clear();
            TxtFotoJugadores.Clear();

            DtpNacimientoJugadores.Value = DateTime.Today;
            NudDorsalJugadores.Value = 0;

            CmbPosicionJugadores.SelectedIndex = -1;
            CmbEquipoJugadores.SelectedIndex = -1;

            ChkCkbEstadoJugadores.Checked = true;

            if (PicPtbFotoJugador.Image != null)
            {
                PicPtbFotoJugador.Image.Dispose();
                PicPtbFotoJugador.Image = null;
            }

            DgvJugadores.ClearSelection();

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            TxtNombresJugadores.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
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