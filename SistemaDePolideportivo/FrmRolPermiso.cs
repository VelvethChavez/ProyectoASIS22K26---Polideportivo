using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmRolPermiso : Form
    {

        ConexionBD conexionBD = new ConexionBD();


        public FrmRolPermiso()
        {
            InitializeComponent();
        }



        //==========================
        // LOAD
        //==========================
        private void FrmRolPermiso_Load(object sender, EventArgs e)
        {
            DgvRolPermiso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRolPermiso.MultiSelect = false;
            DgvRolPermiso.ReadOnly = true;


            CargarRoles();
            CargarPermisos();
            CargarDatos();
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


                    string sql = "SELECT id_rol, nombre_rol FROM FrmRol";


                    MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);


                    DataTable dt = new DataTable();


                    da.Fill(dt);



                    CmbRolrp.DataSource = dt;

                    CmbRolrp.DisplayMember = "nombre_rol";

                    CmbRolrp.ValueMember = "id_rol";

                    CmbRolrp.SelectedIndex = -1;
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



                    ClbPermisos.DataSource = dt;

                    ClbPermisos.DisplayMember = "nombre";

                    ClbPermisos.ValueMember = "id_permiso";

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
                    r.nombre_rol AS FrmRol,
                    p.nombre AS Permiso
                    FROM FrmRol_Permiso rp
                    INNER JOIN FrmRol r 
                    ON rp.id_rol = r.id_rol
                    INNER JOIN Permiso p
                    ON rp.id_permiso = p.id_permiso";


                    MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);


                    DataTable dt = new DataTable();


                    da.Fill(dt);


                    DgvRolPermiso.DataSource = dt;

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

            try
            {

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {

                    conexion.Open();



                    foreach (DataRowView item in ClbPermisos.CheckedItems)
                    {

                        string sql = @"
                        INSERT INTO FrmRol_Permiso
                        (id_rol,id_permiso)
                        VALUES
                        (@rol,@permiso)";


                        MySqlCommand cmd =
                        new MySqlCommand(sql, conexion);



                        cmd.Parameters.AddWithValue("@rol",
                        CmbRolrp.SelectedValue);


                        cmd.Parameters.AddWithValue("@permiso",
                        item["id_permiso"]);



                        cmd.ExecuteNonQuery();

                    }


                    MessageBox.Show("FrmPermisos asignados correctamente");


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
                    "DELETE FROM FrmRol_Permiso WHERE id_rol=@rol";


                    MySqlCommand cmdEliminar =
                    new MySqlCommand(eliminar, conexion);


                    cmdEliminar.Parameters.AddWithValue("@rol",
                    CmbRolrp.SelectedValue);


                    cmdEliminar.ExecuteNonQuery();



                    foreach (DataRowView item in ClbPermisos.CheckedItems)
                    {

                        string sql = @"
                        INSERT INTO FrmRol_Permiso
                        (id_rol,id_permiso)
                        VALUES
                        (@rol,@permiso)";


                        MySqlCommand cmd =
                        new MySqlCommand(sql, conexion);


                        cmd.Parameters.AddWithValue("@rol",
                        CmbRolrp.SelectedValue);


                        cmd.Parameters.AddWithValue("@permiso",
                        item["id_permiso"]);


                        cmd.ExecuteNonQuery();

                    }



                    MessageBox.Show("FrmPermisos actualizados correctamente");


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

            if (DgvRolPermiso.SelectedRows.Count == 0)
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
                    FROM FrmRol_Permiso rp
                    INNER JOIN FrmRol r
                    ON rp.id_rol=r.id_rol
                    INNER JOIN Permiso p
                    ON rp.id_permiso=p.id_permiso
                    WHERE r.nombre_rol=@rol
                    AND p.nombre=@permiso";



                    MySqlCommand cmd =
                    new MySqlCommand(sql, conexion);



                    cmd.Parameters.AddWithValue("@rol",
                    DgvRolPermiso.SelectedRows[0].Cells["FrmRol"].Value);


                    cmd.Parameters.AddWithValue("@permiso",
                    DgvRolPermiso.SelectedRows[0].Cells["Permiso"].Value);



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

            CmbRolrp.SelectedIndex = -1;


            for (int i = 0; i < ClbPermisos.Items.Count; i++)
            {
                ClbPermisos.SetItemChecked(i, false);
            }


            DgvRolPermiso.ClearSelection();

        }

    }
}