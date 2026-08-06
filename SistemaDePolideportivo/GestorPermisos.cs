using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public static class GestorPermisos
    {
        public static bool TienePermiso(string permiso)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM Rol_Permiso rp
                INNER JOIN Permiso p 
                ON rp.id_permiso = p.id_permiso
                WHERE rp.id_rol = @rol
                AND p.nombre = @permiso";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@rol", Sesion.IdRol);
                cmd.Parameters.AddWithValue("@permiso", permiso);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }


        public static void AplicarPermisoBoton(Button boton, string permiso)
        {
            bool tienePermiso = TienePermiso(permiso);

            boton.Enabled = tienePermiso;

            if (!tienePermiso)
            {
                boton.FlatStyle = FlatStyle.Flat;
                boton.BackColor = Color.Gray;
                boton.ForeColor = Color.White;
            }
    
    }
    }
}