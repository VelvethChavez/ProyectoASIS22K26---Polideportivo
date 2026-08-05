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
    internal class CArbitro
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

      
        public DataTable Listado_Arbitros(string filtro)
        {
            const string sql =
                "SELECT id_arbitro, nombres_arbitro, apellidos_arbitro, telefono, especialidad " +
                "FROM Arbitro " +
                "WHERE nombres_arbitro LIKE @filtro OR apellidos_arbitro LIKE @filtro OR especialidad LIKE @filtro " +
                "ORDER BY id_arbitro";

            var tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", filtro);
                    comando.CommandTimeout = 60;

                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los árbitros: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        public string Guardar_Arbitro(int opcion, string nombres, string apellidos, string telefono, string especialidad, int idArbitro = 0)
        {
            string sql;

            if (opcion == 1)
            {
                sql =
                    "INSERT INTO Arbitro (nombres_arbitro, apellidos_arbitro, telefono, especialidad) " +
                    "VALUES (@nombres, @apellidos, @telefono, @especialidad)";
            }
            else if (opcion == 2)
            {
                sql =
                    "UPDATE Arbitro " +
                    "SET nombres_arbitro = @nombres, apellidos_arbitro = @apellidos, telefono = @telefono, especialidad = @especialidad " +
                    "WHERE id_arbitro = @id";
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
                    comando.Parameters.AddWithValue("@nombres", nombres);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@especialidad", especialidad);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue("@id", idArbitro);
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

      
        public string Eliminar_Arbitro(int idArbitro)
        {
            const string sql = "DELETE FROM Arbitro WHERE id_arbitro = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idArbitro);
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
