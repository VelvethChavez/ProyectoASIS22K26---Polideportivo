using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmEquipos : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int idEquipoSeleccionado = 0;

        public FrmEquipos()
        {
            InitializeComponent();

            Load += FrmEquipos_Load;

            BtnGuardar.Click += BtnGuardar_Click;
            BtnEditar.Click += BtnEditar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;

            Dgv1.CellClick += Dgv1_CellClick;
        }

        private void FrmEquipos_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                CargarEntrenadores();
                CargarEquipos();
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

            Lbl5.Text = "GESTIÓN DE EQUIPOS";
            Lbl5.ForeColor = Color.FromArgb(27, 94, 32);
            Lbl5.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            CmbEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;

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
            boton.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
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
                            id_entrenador,
                            CONCAT(
                                nombres_entrenador,
                                ' ',
                                apellidos_entrenador
                            ) AS entrenador
                        FROM Entrenador
                        ORDER BY nombres_entrenador,
                                 apellidos_entrenador;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                CmbEntrenador.DataSource = tabla;
                CmbEntrenador.DisplayMember = "entrenador";
                CmbEntrenador.ValueMember = "id_entrenador";
                CmbEntrenador.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los entrenadores.", ex);
            }
        }

        private void CargarEquipos()
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
                            e.id_equipo AS ID,
                            e.nombre_equipo AS Equipo,
                            e.logo AS Logo,
                            e.id_entrenador,
                            CONCAT(
                                en.nombres_entrenador,
                                ' ',
                                en.apellidos_entrenador
                            ) AS Entrenador,
                            CASE
                                WHEN e.estado = 1 THEN 'Activo'
                                ELSE 'Inactivo'
                            END AS Estado
                        FROM Equipo e
                        LEFT JOIN Entrenador en
                            ON e.id_entrenador = en.id_entrenador
                        ORDER BY e.id_equipo DESC;";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                Dgv1.DataSource = tabla;
                ConfigurarColumnasGrid();
                Dgv1.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los equipos.", ex);
            }
        }

        private void ConfigurarColumnasGrid()
        {
            if (Dgv1.Columns.Contains("id_entrenador"))
            {
                Dgv1.Columns["id_entrenador"].Visible = false;
            }

            if (Dgv1.Columns.Contains("Logo"))
            {
                Dgv1.Columns["Logo"].Visible = false;
            }

            if (Dgv1.Columns.Contains("ID"))
            {
                Dgv1.Columns["ID"].FillWeight = 35;
            }

            if (Dgv1.Columns.Contains("Estado"))
            {
                Dgv1.Columns["Estado"].FillWeight = 60;
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(TxtNombreEquipo.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombreEquipo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtLogo.Text))
            {
                MessageBox.Show(
                    "Ingrese o seleccione el logo del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtLogo.Focus();
                return false;
            }

            if (CmbEntrenador.SelectedIndex < 0 ||
                CmbEntrenador.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione un entrenador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbEntrenador.Focus();
                return false;
            }

            if (!ChkEstado.Checked)
            {
                MessageBox.Show(
                    "El equipo debe registrarse como activo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ChkEstado.Focus();
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
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        INSERT INTO Equipo
                        (
                            nombre_equipo,
                            logo,
                            estado,
                            id_entrenador
                        )
                        VALUES
                        (
                            @nombre,
                            @logo,
                            @estado,
                            @entrenador
                        );";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombre",
                            TxtNombreEquipo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@logo",
                            TxtLogo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ChkEstado.Checked);

                        comando.Parameters.AddWithValue(
                            "@entrenador",
                            Convert.ToInt32(
                                CmbEntrenador.SelectedValue));

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Equipo registrado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEquipos();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al guardar el equipo.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al guardar el equipo.", ex);
            }
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            if (idEquipoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un equipo en la tabla.",
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
                        UPDATE Equipo
                        SET
                            nombre_equipo = @nombre,
                            logo = @logo,
                            estado = @estado,
                            id_entrenador = @entrenador
                        WHERE id_equipo = @idEquipo;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombre",
                            TxtNombreEquipo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@logo",
                            TxtLogo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@estado",
                            ChkEstado.Checked);

                        comando.Parameters.AddWithValue(
                            "@entrenador",
                            Convert.ToInt32(
                                CmbEntrenador.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            idEquipoSeleccionado);

                        int filasActualizadas =
                            comando.ExecuteNonQuery();

                        if (filasActualizadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el equipo seleccionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Equipo actualizado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEquipos();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al actualizar el equipo.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al actualizar el equipo.", ex);
            }
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (idEquipoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un equipo en la tabla.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea desactivar el equipo seleccionado?",
                "Confirmar desactivación",
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

                    string consulta = @"
                        UPDATE Equipo
                        SET estado = 0
                        WHERE id_equipo = @idEquipo;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idEquipo",
                            idEquipoSeleccionado);

                        int filasActualizadas =
                            comando.ExecuteNonQuery();

                        if (filasActualizadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el equipo seleccionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Equipo desactivado correctamente.",
                    "Sistema Polideportivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEquipos();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MostrarError("Error al desactivar el equipo.", ex);
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al desactivar el equipo.", ex);
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

                idEquipoSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["ID"].Value);

                TxtNombreEquipo.Text =
                    Convert.ToString(
                        fila.Cells["Equipo"].Value) ?? "";

                TxtLogo.Text =
                    Convert.ToString(
                        fila.Cells["Logo"].Value) ?? "";

                if (fila.Cells["id_entrenador"].Value ==
                    DBNull.Value)
                {
                    CmbEntrenador.SelectedIndex = -1;
                }
                else
                {
                    CmbEntrenador.SelectedValue =
                        Convert.ToInt32(
                            fila.Cells["id_entrenador"].Value);
                }

                string estado =
                    Convert.ToString(
                        fila.Cells["Estado"].Value) ?? "";

                ChkEstado.Checked =
                    estado.Equals(
                        "Activo",
                        StringComparison.OrdinalIgnoreCase);

                BtnGuardar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo cargar el equipo seleccionado.",
                    ex);
            }
        }

        private void LimpiarCampos()
        {
            idEquipoSeleccionado = 0;

            TxtNombreEquipo.Clear();
            TxtLogo.Clear();

            CmbEntrenador.SelectedIndex = -1;
            ChkEstado.Checked = true;

            Dgv1.ClearSelection();

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            TxtNombreEquipo.Focus();
        }

        private void MostrarError(
            string mensaje,
            Exception ex)
        {
            MessageBox.Show(
                mensaje + "\n\n" + ex.Message,
                "Sistema Polideportivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}