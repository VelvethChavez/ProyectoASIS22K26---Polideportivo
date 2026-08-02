using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmEquipos : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        private int idEquipo = 0;

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CargarEntrenadores();
            CargarDatos();
        }

        private void CargarEntrenadores()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"SELECT id_entrenador,
                                   CONCAT(nombres_entrenador,' ',apellidos_entrenador) AS entrenador
                                   FROM Entrenador";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbEntrenador.DataSource = dt;
                    cmbEntrenador.DisplayMember = "entrenador";
                    cmbEntrenador.ValueMember = "id_entrenador";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        e.id_equipo,
                        e.nombre_equipo,
                        e.logo,
                        e.estado,
                        CONCAT(en.nombres_entrenador,' ',en.apellidos_entrenador) AS entrenador
                    FROM Equipo e
                    LEFT JOIN Entrenador en
                    ON e.id_entrenador = en.id_entrenador";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"INSERT INTO Equipo
                                   (nombre_equipo,logo,estado,id_entrenador)
                                   VALUES
                                   (@nombre,@logo,@estado,@entrenador)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@nombre", txtNombreEquipo.Text);
                    cmd.Parameters.AddWithValue("@logo", txtLogo.Text);
                    cmd.Parameters.AddWithValue("@estado", chkEstado.Checked);
                    cmd.Parameters.AddWithValue("@entrenador", cmbEntrenador.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Equipo guardado correctamente");

                    LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idEquipo == 0)
            {
                MessageBox.Show("Seleccione un equipo");
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"UPDATE Equipo
                                   SET nombre_equipo=@nombre,
                                       logo=@logo,
                                       estado=@estado,
                                       id_entrenador=@entrenador
                                   WHERE id_equipo=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@nombre", txtNombreEquipo.Text);
                    cmd.Parameters.AddWithValue("@logo", txtLogo.Text);
                    cmd.Parameters.AddWithValue("@estado", chkEstado.Checked);
                    cmd.Parameters.AddWithValue("@entrenador", cmbEntrenador.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", idEquipo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Equipo actualizado");

                    LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idEquipo == 0)
            {
                MessageBox.Show("Seleccione un equipo");
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "DELETE FROM Equipo WHERE id_equipo=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@id", idEquipo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Equipo eliminado");

                    LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idEquipo = Convert.ToInt32(fila.Cells["id_equipo"].Value);

                txtNombreEquipo.Text = fila.Cells["nombre_equipo"].Value.ToString();
                txtLogo.Text = fila.Cells["logo"].Value.ToString();

                chkEstado.Checked =
                    Convert.ToBoolean(fila.Cells["estado"].Value);
            }
        }

        private void LimpiarCampos()
        {
            idEquipo = 0;

            txtNombreEquipo.Clear();
            txtLogo.Clear();

            chkEstado.Checked = true;

            dataGridView1.ClearSelection();
        }
    }
}