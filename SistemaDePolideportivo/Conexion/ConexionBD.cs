using MySql.Data.MySqlClient;

namespace SistemaDePolideportivo.Conexion
{
    public class ConexionBD
    {

        // 1. Reemplaza 'TU_CONTRASEÑA_AQUI' por la contraseña con la que entras a MySQL Workbench
        // (Si no le pusiste contraseña al instalar MySQL, déjalo vacío: pwd=;)
        private string cadenaConexion =
            "server=localhost;port=3306;database=sistemapolideportivo;uid=root;pwd=localhost123;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    MessageBox.Show("¡Conexión exitosa a la base de datos!", "Sistema Polideportivo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}