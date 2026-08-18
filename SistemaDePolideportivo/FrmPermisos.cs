using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class Permiso : Form
    {

        ConexionBD conexionBD = new ConexionBD();

        private int idPermiso = 0;


        public Permiso()
        {
            InitializeComponent();
        }



        //==========================
        // LOAD
        //==========================
        private void Permiso_Load(object sender, EventArgs e)
        {
            DgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPermisos.MultiSelect = false;
            DgvPermisos.ReadOnly = true;


            CargarDatos();
        }




        //==========================
        // MOSTRAR PERMISOS
        //==========================
        private void CargarDatos()
        {

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {

                conexion.Open();


                string sql = "SELECT * FROM Permiso";


                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conexion);


                DataTable dt = new DataTable();


                da.Fill(dt);


                DgvPermisos.DataSource = dt;

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


                    string sql = @"INSERT INTO Permiso
                    (nombre, descripcion)
                    VALUES
                    (@nombre,@descripcion)";


                    MySqlCommand cmd =
                    new MySqlCommand(sql, conexion);



                    cmd.Parameters.AddWithValue("@nombre",
                    TxtNombrepermiso.Text);



                    cmd.Parameters.AddWithValue("@descripcion",
                    TxtDescripcionpermiso.Text);



                    cmd.ExecuteNonQuery();

                    Bitacora.Registrar(
                        "Permiso",
                        "Agregó el permiso: " + TxtNombrepermiso.Text
                    );

                    MessageBox.Show("Permiso agregado correctamente");
                    CargarDatos();

                    LimpiarCampos();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        //==========================
        // SELECCIONAR GRID
        //==========================
        private void DgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila =
                DgvPermisos.Rows[e.RowIndex];



                idPermiso =
                Convert.ToInt32(
                fila.Cells["id_permiso"].Value);



                TxtNombrepermiso.Text =
                fila.Cells["nombre"].Value.ToString();



                TxtDescripcionpermiso.Text =
                fila.Cells["descripcion"].Value.ToString();

            }

        }





        //==========================
        // EDITAR
        //==========================
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (DgvPermisos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un permiso");
                return;
            }

            int id =
            Convert.ToInt32(
            DgvPermisos.SelectedRows[0]
            .Cells["id_permiso"].Value);



            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {

                conexion.Open();

                string sql = @"UPDATE Permiso SET
                nombre=@nombre,
                descripcion=@descripcion
                WHERE id_permiso=@id";

                MySqlCommand cmd =
                new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@nombre",
                TxtNombrepermiso.Text);

                cmd.Parameters.AddWithValue("@descripcion",
                TxtDescripcionpermiso.Text);

                cmd.Parameters.AddWithValue("@id",
                id);

                cmd.ExecuteNonQuery();

                Bitacora.Registrar(
                    "Permiso",
                    "Editó el permiso: " + TxtNombrepermiso.Text
                );

                MessageBox.Show("Permiso actualizado correctamente");

                CargarDatos();

                LimpiarCampos();

            }

        }

        //==========================
        // ELIMINAR
        //==========================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (DgvPermisos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un permiso");
                return;
            }

            int id =
            Convert.ToInt32(
            DgvPermisos.SelectedRows[0]
            .Cells["id_permiso"].Value);


            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {

                conexion.Open();

                string sql =
                "DELETE FROM Permiso WHERE id_permiso=@id";

                MySqlCommand cmd =
                new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Permiso eliminado correctamente");

                CargarDatos();

                LimpiarCampos();

            }

        }





        //==========================
        // NUEVO
        //==========================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            TxtNombrepermiso.Focus();
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

            idPermiso = 0;


            TxtNombrepermiso.Clear();

            TxtDescripcionpermiso.Clear();


            DgvPermisos.ClearSelection();

        }

    }
}