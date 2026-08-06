using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class Rol : Form
    {
        ConexionBD conexionBD = new ConexionBD();
        private int idRol = 0;

        public Rol()
        {
            InitializeComponent();
        }

        private void Rol_Load(object sender, EventArgs e)
        {
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;
            dgvRoles.ReadOnly = true;
            CargarDatos();

            //Permisos
            BtnGuardar.Enabled = GestorPermisos.TienePermiso("Crear");
            BtnEditar.Enabled = GestorPermisos.TienePermiso("Modificar");
            BtnEliminar.Enabled = GestorPermisos.TienePermiso("Eliminar");
            BtnNuevo.Enabled = GestorPermisos.TienePermiso("Crear");
        }

        private void CargarDatos()
        {
            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "SELECT * FROM Rol";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRoles.DataSource = dt;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrerol.Text) ||
       string.IsNullOrWhiteSpace(descripcionrol.Text)) 
            {
                MessageBox.Show("Error: Hay campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"INSERT INTO Rol
                    (nombre_rol, descripcion)
                    VALUES
                    (@nombre,@descripcion)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@nombre", nombrerol.Text);
                    cmd.Parameters.AddWithValue("@descripcion", descripcionrol.Text);

                    cmd.ExecuteNonQuery();
                    Bitacora.Registrar(
                        Sesion.IdUsuario,
                        "Rol",
                        "INSERT: Creó el rol " + nombrerol.Text
                        );


                    MessageBox.Show("Rol agregado correctamente");

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];

                idRol = Convert.ToInt32(fila.Cells["id_rol"].Value);
                nombrerol.Text = fila.Cells["nombre_rol"].Value.ToString();
                descripcionrol.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }

            int id = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["id_rol"].Value);

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"UPDATE Rol SET
                nombre_rol=@nombre,
                descripcion=@descripcion
                WHERE id_rol=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@nombre", nombrerol.Text);
                cmd.Parameters.AddWithValue("@descripcion", descripcionrol.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                Bitacora.Registrar(
                    Sesion.IdUsuario,
                    "Rol",
                    "UPDATE: Editó el rol " + nombrerol.Text
                    );

                MessageBox.Show("Rol actualizado correctamente");

                CargarDatos();
                LimpiarCampos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }

            int id = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["id_rol"].Value);

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "DELETE FROM Rol WHERE id_rol=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                Bitacora.Registrar(
                    Sesion.IdUsuario,
                    "Rol",
                    "DELETE: Eliminó un rol"
                    );

                MessageBox.Show("Rol eliminado correctamente");

                CargarDatos();
                LimpiarCampos();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            nombrerol.Focus();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            idRol = 0;
            nombrerol.Clear();
            descripcionrol.Clear();
            dgvRoles.ClearSelection();
        }
    }
}