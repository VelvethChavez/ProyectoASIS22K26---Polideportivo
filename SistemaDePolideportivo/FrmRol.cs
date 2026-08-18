using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmRol : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        private int idRol = 0;

        public FrmRol()
        {
            InitializeComponent();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            DgvRoles.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DgvRoles.MultiSelect = false;
            DgvRoles.ReadOnly = true;

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        SELECT
                            id_rol,
                            nombre_rol,
                            descripcion
                        FROM Rol
                        ORDER BY id_rol";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    DgvRoles.DataSource = dt;
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNombrerol.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del rol.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    TxtNombrerol.Focus();
                    return;
                }

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        INSERT INTO Rol
                        (
                            nombre_rol,
                            descripcion
                        )
                        VALUES
                        (
                            @nombre,
                            @descripcion
                        )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            TxtNombrerol.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@descripcion",
                            TxtDescripcionrol.Text.Trim()
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Rol agregado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Ese nombre de rol ya existe.",
                        "Rol duplicado",
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
        }

        private void DgvRoles_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                DgvRoles.Rows[e.RowIndex];

            if (fila.Cells["id_rol"].Value == null)
                return;

            idRol =
                Convert.ToInt32(fila.Cells["id_rol"].Value);

            TxtNombrerol.Text =
                fila.Cells["nombre_rol"].Value?.ToString() ?? "";

            TxtDescripcionrol.Text =
                fila.Cells["descripcion"].Value?.ToString() ?? "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idRol == 0)
            {
                MessageBox.Show(
                    "Seleccione un rol.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                        UPDATE Rol
                        SET
                            nombre_rol = @nombre,
                            descripcion = @descripcion
                        WHERE id_rol = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            TxtNombrerol.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@descripcion",
                            TxtDescripcionrol.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idRol
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Rol actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al editar el rol:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idRol == 0)
            {
                MessageBox.Show(
                    "Seleccione un rol.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este rol?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conexion =
                       conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql =
                        "DELETE FROM Rol WHERE id_rol = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            idRol
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Rol eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "No se puede eliminar el rol.\n\n" +
                    "Es posible que tenga usuarios asociados.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            TxtNombrerol.Focus();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idRol = 0;

            TxtNombrerol.Clear();
            TxtDescripcionrol.Clear();

            DgvRoles.ClearSelection();

            TxtNombrerol.Focus();
        }
    }
}