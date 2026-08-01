using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaDePolideportivo
{
    internal class CEstadoPartido
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

        public DataTable Listado_Estados(string filtro)
        {
            const string sql =
                "SELECT id_estado_partido, nombre_estado, descripcion " +
                "FROM estado_partido " +
                "WHERE nombre_estado LIKE @filtro " +
                "ORDER BY id_estado_partido";

            var tabla = new DataTable();

            using (var conexion = _conexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@filtro", filtro);
                comando.CommandTimeout = 60;
                conexion.Open();

                using (var resultado = comando.ExecuteReader())
                {
                    tabla.Load(resultado);
                }
            }

            return tabla;
        }

        public string Guardar_Estado(int opcion, string nombreEstado, string descripcion, int idEstadoPartido = 0)
        {
            string sql;

            if (opcion == 1)
            {
                sql =
                    "INSERT INTO estado_partido (nombre_estado, descripcion) " +
                    "VALUES (@nombre, @descripcion)";
            }
            else if (opcion == 2)
            {
                sql =
                    "UPDATE estado_partido " +
                    "SET nombre_estado = @nombre, descripcion = @descripcion " +
                    "WHERE id_estado_partido = @id";
            }
            else
            {
                return "Operación no soportada.";
            }

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombreEstado);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue("@id", idEstadoPartido);
                    }

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se pudo completar la operación";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar_Estado(int idEstadoPartido)
        {
            const string sql = "DELETE FROM estado_partido WHERE id_estado_partido = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEstadoPartido);
                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se pudo eliminar el registro";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
