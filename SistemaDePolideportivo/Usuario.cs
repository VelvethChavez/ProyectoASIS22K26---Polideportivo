using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
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
        }



        private void usuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;

            CargarRoles();
            CargarEstado();
            CargarDatos();
        }



        private void CargarDatos()
        {
            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "SELECT * FROM Usuario";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }



        private void CargarRoles()
        {
            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "SELECT id_rol,nombre_rol FROM Rol";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                DataTable dt = new DataTable();

                da.Fill(dt);

                rolusu.DataSource = dt;
                rolusu.DisplayMember = "nombre_rol";
                rolusu.ValueMember = "id_rol";
            }
        }



        private void CargarEstado()
        {
            estadousu.Items.Clear();
            estadousu.Items.Add("Activo");
            estadousu.Items.Add("Inactivo");
        }



        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                idUsuario = Convert.ToInt32(fila.Cells["id_usuario"].Value);
                nombreusu.Text = fila.Cells["nombre_usuario"].Value.ToString();
                contrasenausu.Text = fila.Cells["contraseña"].Value.ToString();
                estadousu.SelectedItem = fila.Cells["estado"].Value.ToString();
                rolusu.SelectedValue = fila.Cells["id_rol"].Value;
            }
        }



        private void LimpiarCampos()
        {
            idUsuario = 0;
            nombreusu.Clear();
            contrasenausu.Clear();
            estadousu.SelectedIndex = -1;
            rolusu.SelectedIndex = -1;
            dgvUsuarios.ClearSelection();
        }



        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            nombreusu.Focus();
        }



        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(
                    dgvUsuarios.SelectedRows[0].Cells["id_usuario"].Value
                );

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "DELETE FROM Usuario WHERE id_usuario=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario eliminado correctamente");

                    CargarDatos();

                    LimpiarCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }



        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario de la tabla.");
                    return;
                }


                int id = Convert.ToInt32(
                    dgvUsuarios.SelectedRows[0].Cells["id_usuario"].Value
                );


                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();


                    string sql = @"UPDATE Usuario SET
                           nombre_usuario=@nombre,
                           contraseña=@pass,
                           estado=@estado,
                           id_rol=@rol
                           WHERE id_usuario=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conexion);


                    cmd.Parameters.AddWithValue("@nombre", nombreusu.Text);

                    cmd.Parameters.AddWithValue("@pass", contrasenausu.Text);

                    cmd.Parameters.AddWithValue("@estado", estadousu.SelectedItem);

                    cmd.Parameters.AddWithValue("@rol", rolusu.SelectedValue);

                    cmd.Parameters.AddWithValue("@id", id);


                    int filas = cmd.ExecuteNonQuery();
                    

                    if (filas > 0)
                    {
                        MessageBox.Show("Usuario actualizado correctamente.");

                        CargarDatos();

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }



        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreusu.Text) ||
       string.IsNullOrWhiteSpace(contrasenausu.Text) ||
       estadousu.SelectedIndex == -1 ||
       rolusu.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Hay campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();


                    string sql = @"INSERT INTO Usuario
                    (nombre_usuario, contraseña, estado, id_rol)
                    VALUES
                    (@nombre,@pass,@estado,@rol)";


                    MySqlCommand cmd = new MySqlCommand(sql, conexion);


                    cmd.Parameters.AddWithValue("@nombre", nombreusu.Text);

                    cmd.Parameters.AddWithValue("@pass", contrasenausu.Text);

                    cmd.Parameters.AddWithValue("@estado", estadousu.SelectedItem.ToString());

                    cmd.Parameters.AddWithValue("@rol", rolusu.SelectedValue);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Usuario agregado correctamente");


                    CargarDatos();

                    LimpiarCampos();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}