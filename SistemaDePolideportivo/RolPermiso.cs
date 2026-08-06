using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class RolPermiso : Form
    {

        ConexionBD conexionBD = new ConexionBD();

        public RolPermiso()
        {
            InitializeComponent();
        }


        //==========================
        // LOAD
        //==========================
        private void RolPermiso_Load(object sender, EventArgs e)
        {
            dgvRolPermiso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRolPermiso.MultiSelect = false;
            dgvRolPermiso.ReadOnly = true;


            CargarRoles();
            CargarPermisos();
            CargarDatos();

            //Permisos
            BtnGuardar.Enabled = GestorPermisos.TienePermiso("Crear");
            BtnEditar.Enabled = GestorPermisos.TienePermiso("Modificar");
            BtnEliminar.Enabled = GestorPermisos.TienePermiso("Eliminar");
        }


        //==========================
        // CARGAR ROLES
        //==========================
        private void CargarRoles()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();


                    string sql = "SELECT id_rol, nombre_rol FROM Rol";

                    MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);


                    DataTable dt = new DataTable();


                    da.Fill(dt);

                    rolrp.DataSource = dt;

                    rolrp.DisplayMember = "nombre_rol";

                    rolrp.ValueMember = "id_rol";

                    rolrp.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        //==========================
        // CARGAR PERMISOS
        //==========================
        private void CargarPermisos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();


                    string sql =
                    "SELECT id_permiso, nombre FROM Permiso";


                    MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);


                    DataTable dt = new DataTable();


                    da.Fill(dt);

                    clbPermisos.DataSource = dt;

                    clbPermisos.DisplayMember = "nombre";

                    clbPermisos.ValueMember = "id_permiso";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message);
            }
        }

        //==========================
        // MOSTRAR DATOS
        //==========================
        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();


                    string sql = @"
                    SELECT 
                    r.nombre_rol AS Rol,
                    p.nombre AS Permiso
                    FROM Rol_Permiso rp
                    INNER JOIN Rol r 
                    ON rp.id_rol = r.id_rol
                    INNER JOIN Permiso p
                    ON rp.id_permiso = p.id_permiso";


                    MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvRolPermiso.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }

        }

        //==========================
        // GUARDAR
        //==========================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (rolrp.SelectedIndex == -1 ||
         clbPermisos.CheckedItems.Count == 0)
            {
                MessageBox.Show("Error: Hay campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {

                    conexion.Open();

                    foreach (DataRowView item in clbPermisos.CheckedItems)
                    {

                        string sql = @"
                        INSERT INTO Rol_Permiso
                        (id_rol,id_permiso)
                        VALUES
                        (@rol,@permiso)";

                        MySqlCommand cmd =
                        new MySqlCommand(sql, conexion);

                        cmd.Parameters.AddWithValue("@rol",
                        rolrp.SelectedValue);
                        cmd.Parameters.AddWithValue("@permiso",
                        item["id_permiso"]);

                        cmd.ExecuteNonQuery();
                        Bitacora.Registrar(
                            Sesion.IdUsuario,
                            "RolPermiso",
                            "INSERT: Asignó permisos al rol " + rolrp.Text
                            );

                    }

                    MessageBox.Show("Permisos asignados correctamente");


                    CargarDatos();

                    LimpiarCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }


        //==========================
        // EDITAR
        //==========================
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {

                    conexion.Open();

                    string eliminar =
                    "DELETE FROM Rol_Permiso WHERE id_rol=@rol";

                    MySqlCommand cmdEliminar =
                    new MySqlCommand(eliminar, conexion);

                    cmdEliminar.Parameters.AddWithValue("@rol",
                    rolrp.SelectedValue);

                    cmdEliminar.ExecuteNonQuery();

                    foreach (DataRowView item in clbPermisos.CheckedItems)
                    {

                        string sql = @"
                        INSERT INTO Rol_Permiso
                        (id_rol,id_permiso)
                        VALUES
                        (@rol,@permiso)";


                        MySqlCommand cmd =
                        new MySqlCommand(sql, conexion);


                        cmd.Parameters.AddWithValue("@rol",
                        rolrp.SelectedValue);


                        cmd.Parameters.AddWithValue("@permiso",
                        item["id_permiso"]);


                        cmd.ExecuteNonQuery();
                        Bitacora.Registrar(
                            Sesion.IdUsuario,
                            "RolPermiso",
                            "UPDATE: Actualizó permisos del rol " + rolrp.Text
                            );

                    }

                    MessageBox.Show("Permisos actualizados correctamente");


                    CargarDatos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }

        }


        //==========================
        // ELIMINAR
        //==========================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvRolPermiso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un permiso");
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {

                    conexion.Open();

                    string sql = @"
                    DELETE rp
                    FROM Rol_Permiso rp
                    INNER JOIN Rol r
                    ON rp.id_rol=r.id_rol
                    INNER JOIN Permiso p
                    ON rp.id_permiso=p.id_permiso
                    WHERE r.nombre_rol=@rol
                    AND p.nombre=@permiso";

                    MySqlCommand cmd =
                    new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@rol",
                    dgvRolPermiso.SelectedRows[0].Cells["Rol"].Value);

                    cmd.Parameters.AddWithValue("@permiso",
                    dgvRolPermiso.SelectedRows[0].Cells["Permiso"].Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Permiso eliminado");

                    CargarDatos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        //==========================
        // LIMPIAR
        //==========================
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            rolrp.SelectedIndex = -1;

            for (int i = 0; i < clbPermisos.Items.Count; i++)
            {
                clbPermisos.SetItemChecked(i, false);
            }

            dgvRolPermiso.ClearSelection();

        }

    }
}