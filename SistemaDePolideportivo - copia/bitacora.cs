using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
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

        public static void Registrar(string modulo, string accion)
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                    INSERT INTO Bitacora
                    (modulo, fecha_hora, accion)
                    VALUES
                    (@modulo,@fecha,@accion)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@modulo", modulo);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@accion", accion);

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

                    string consulta = "SELECT * FROM Bitacora";

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