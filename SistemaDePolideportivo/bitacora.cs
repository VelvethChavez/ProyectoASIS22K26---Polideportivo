using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
            MostrarBitacora();
        }

        public static void Registrar(int idUsuario, string modulo, string accion)
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"INSERT INTO Bitacora
                    (id_usuario, accion, modulo)
                    VALUES
                    (@id_usuario,@accion,@modulo)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.Parameters.AddWithValue("@modulo", modulo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar bitácora: " + ex.Message);
            }
        }

        private void MostrarBitacora()
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"SELECT 
                    b.id_bitacora,
                    u.nombre_usuario,
                    b.accion,
                    b.modulo,
                    b.fecha_hora
                    FROM Bitacora b
                    INNER JOIN Usuario u ON b.id_usuario=u.id_usuario
                    ORDER BY b.fecha_hora DESC";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvBitacora.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bitácora: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}