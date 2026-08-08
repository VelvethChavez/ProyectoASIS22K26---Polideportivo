using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class usuario : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        private int idUsuario = 0;

        public usuario()
        {
            InitializeComponent();

            // Conectar evento del DataGridView
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
        }

        // ============================================================
        // CARGAR FORMULARIO
        // ============================================================

        private void usuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;

            CargarRoles();
            CargarEstado();
            CargarDatos();

            LimpiarCampos();
        }

        // ============================================================
        // CARGAR DATOS DE USUARIOS
        // ============================================================

        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        SELECT 
                            id_usuario,
                            nombre_usuario,
                            contrasena,
                            CASE 
                                WHEN estado = TRUE THEN 'Activo'
                                ELSE 'Inactivo'
                            END AS estado,
                            fecha_creacion,
                            id_rol
                        FROM Usuario";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvUsuarios.DataSource = dt;

                    // Cambiar encabezados
                    if (dgvUsuarios.Columns.Contains("id_usuario"))
                        dgvUsuarios.Columns["id_usuario"].HeaderText = "ID";

                    if (dgvUsuarios.Columns.Contains("nombre_usuario"))
                        dgvUsuarios.Columns["nombre_usuario"].HeaderText = "Nombre de usuario";

                    if (dgvUsuarios.Columns.Contains("contrasena"))
                        dgvUsuarios.Columns["contrasena"].HeaderText = "Contraseña";

                    if (dgvUsuarios.Columns.Contains("estado"))
                        dgvUsuarios.Columns["estado"].HeaderText = "Estado";

                    if (dgvUsuarios.Columns.Contains("fecha_creacion"))
                        dgvUsuarios.Columns["fecha_creacion"].HeaderText = "Fecha de creación";

                    if (dgvUsuarios.Columns.Contains("id_rol"))
                        dgvUsuarios.Columns["id_rol"].HeaderText = "ID Rol";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar usuarios:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CARGAR ROLES
        // ============================================================

        private void CargarRoles()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        SELECT 
                            id_rol,
                            nombre_rol
                        FROM Rol
                        ORDER BY nombre_rol";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    rolusu.DataSource = dt;
                    rolusu.DisplayMember = "nombre_rol";
                    rolusu.ValueMember = "id_rol";
                    rolusu.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los roles:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CARGAR ESTADOS
        // ============================================================

        private void CargarEstado()
        {
            estadousu.Items.Clear();

            estadousu.Items.Add("Activo");
            estadousu.Items.Add("Inactivo");

            estadousu.SelectedIndex = -1;
        }

        // ============================================================
        // SELECCIONAR USUARIO EN EL DATAGRIDVIEW
        // ============================================================

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                if (fila.Cells["id_usuario"].Value == null)
                    return;

                // ID
                idUsuario = Convert.ToInt32(
                    fila.Cells["id_usuario"].Value
                );

                // Nombre
                nombreusu.Text =
                    fila.Cells["nombre_usuario"].Value?.ToString() ?? "";

                // Contraseña
                // IMPORTANTE: la columna correcta es "contrasena"
                contrasenausu.Text =
                    fila.Cells["contrasena"].Value?.ToString() ?? "";

                // Estado
                string estado =
                    fila.Cells["estado"].Value?.ToString() ?? "";

                if (estado == "Activo")
                {
                    estadousu.SelectedItem = "Activo";
                }
                else
                {
                    estadousu.SelectedItem = "Inactivo";
                }

                // Rol
                if (fila.Cells["id_rol"].Value != null)
                {
                    rolusu.SelectedValue =
                        Convert.ToInt32(fila.Cells["id_rol"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar usuario:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // LIMPIAR CAMPOS
        // ============================================================

        private void LimpiarCampos()
        {
            idUsuario = 0;

            nombreusu.Clear();
            contrasenausu.Clear();

            estadousu.SelectedIndex = -1;
            rolusu.SelectedIndex = -1;

            dgvUsuarios.ClearSelection();

            nombreusu.Focus();
        }

        // ============================================================
        // BOTÓN NUEVO
        // ============================================================

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ============================================================
        // BOTÓN LIMPIAR
        // ============================================================

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ============================================================
        // BOTÓN GUARDAR
        // ============================================================

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar nombre
                if (string.IsNullOrWhiteSpace(nombreusu.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    nombreusu.Focus();
                    return;
                }

                // Validar contraseña
                if (string.IsNullOrWhiteSpace(contrasenausu.Text))
                {
                    MessageBox.Show(
                        "Ingrese la contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    contrasenausu.Focus();
                    return;
                }

                // Validar estado
                if (estadousu.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un estado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Validar rol
                if (rolusu.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un rol.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Convertir Estado
                bool estado = estadousu.SelectedItem.ToString() == "Activo";

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        INSERT INTO Usuario
                        (
                            nombre_usuario,
                            contrasena,
                            estado,
                            id_rol
                        )
                        VALUES
                        (
                            @nombre,
                            @pass,
                            @estado,
                            @rol
                        )";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            nombreusu.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@pass",
                            contrasenausu.Text
                        );

                        cmd.Parameters.AddWithValue(
                            "@estado",
                            estado
                        );

                        cmd.Parameters.AddWithValue(
                            "@rol",
                            Convert.ToInt32(rolusu.SelectedValue)
                        );

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario agregado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarDatos();
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "El nombre de usuario ya existe.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error de MySQL:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // BOTÓN EDITAR
        // ============================================================

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idUsuario == 0)
                {
                    MessageBox.Show(
                        "Seleccione un usuario de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (string.IsNullOrWhiteSpace(nombreusu.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (string.IsNullOrWhiteSpace(contrasenausu.Text))
                {
                    MessageBox.Show(
                        "Ingrese la contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (estadousu.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un estado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (rolusu.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un rol.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Convertir Activo/Inactivo a TRUE/FALSE
                bool estado = estadousu.SelectedItem.ToString() == "Activo";

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        UPDATE Usuario
                        SET
                            nombre_usuario = @nombre,
                            contrasena = @pass,
                            estado = @estado,
                            id_rol = @rol
                        WHERE id_usuario = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            nombreusu.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@pass",
                            contrasenausu.Text
                        );

                        cmd.Parameters.AddWithValue(
                            "@estado",
                            estado
                        );

                        cmd.Parameters.AddWithValue(
                            "@rol",
                            Convert.ToInt32(rolusu.SelectedValue)
                        );

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idUsuario
                        );

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Usuario actualizado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            CargarDatos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se pudo actualizar el usuario.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "El nombre de usuario ya existe.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error de MySQL:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al editar:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // BOTÓN ELIMINAR
        // ============================================================

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idUsuario == 0)
                {
                    MessageBox.Show(
                        "Seleccione un usuario de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta != DialogResult.Yes)
                    return;

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql =
                        "DELETE FROM Usuario WHERE id_usuario = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            idUsuario
                        );

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Usuario eliminado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            CargarDatos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se pudo eliminar el usuario.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "No se puede eliminar el usuario.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void estadousu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}