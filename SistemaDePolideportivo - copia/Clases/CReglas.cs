using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;

namespace ProyectoASIS22K26___Polideportivo
{
    internal class CReglas
    {
        private readonly CConexion _conexionBD = new CConexion();

        public DataTable Listado_Reglas(string filtro)
        {
            const string sql =
                "SELECT id_tipo_sancion, nombre_tipo, descripcion " +
                "FROM tipo_sancion " +
                "WHERE nombre_tipo LIKE @filtro " +
                "ORDER BY id_tipo_sancion";

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

        public string Guardar_Reglas(int opcion, string nombreTipo, string descripcion, int idTipoSancion = 0)
        {
            string sql;

            if (opcion == 1)
            {
                sql =
                    "INSERT INTO tipo_sancion (nombre_tipo, descripcion) " +
                    "VALUES (@nombre, @descripcion)";
            }
            else if (opcion == 2)
            {
                sql =
                    "UPDATE tipo_sancion " +
                    "SET nombre_tipo = @nombre, descripcion = @descripcion " +
                    "WHERE id_tipo_sancion = @id";
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
                    comando.Parameters.AddWithValue("@nombre", nombreTipo);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue("@id", idTipoSancion);
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

        public string Eliminar_Regla(int idTipoSancion)
        {
            const string sql = "DELETE FROM tipo_sancion WHERE id_tipo_sancion = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idTipoSancion);
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
