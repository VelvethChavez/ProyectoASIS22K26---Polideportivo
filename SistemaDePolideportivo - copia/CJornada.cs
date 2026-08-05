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
    internal class CJornada
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

     
        public DataTable Listado_Jornadas(string filtro)
        {
            const string sql =
                "SELECT j.id_jornada, j.nombre_jornada, j.numero_jornada, j.fecha_jornada, " +
                "c.nombre_campeonato, j.id_campeonato " +
                "FROM Jornada j " +
                "INNER JOIN Campeonato c ON j.id_campeonato = c.id_campeonato " +
                "WHERE j.nombre_jornada LIKE @filtro OR c.nombre_campeonato LIKE @filtro " +
                "ORDER BY j.id_jornada DESC";

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
                MessageBox.Show("Error al cargar las jornadas: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        public string Guardar_Jornada(int opcion, string campeonatoTexto, string nombreJornada, int numeroJornada, DateTime fechaJornada, int idJornada = 0)
        {
            // 1. Resolver el ID del campeonato a partir del TextBox
            int idCampeonato = ObtenerOCrearIdCampeonato(campeonatoTexto);

            if (idCampeonato == 0)
            {
                return "El campeonato especificado no es válido.";
            }

            string sql;

            if (opcion == 1)
            {
                sql =
                    "INSERT INTO Jornada (nombre_jornada, numero_jornada, fecha_jornada, id_campeonato) " +
                    "VALUES (@nombre, @numero, @fecha, @idCampeonato)";
            }
            else if (opcion == 2)
            {
                sql =
                    "UPDATE Jornada " +
                    "SET nombre_jornada = @nombre, numero_jornada = @numero, fecha_jornada = @fecha, id_campeonato = @idCampeonato " +
                    "WHERE id_jornada = @id";
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
                    comando.Parameters.AddWithValue("@nombre", nombreJornada);
                    comando.Parameters.AddWithValue("@numero", numeroJornada);
                    comando.Parameters.AddWithValue("@fecha", fechaJornada.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@idCampeonato", idCampeonato);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue("@id", idJornada);
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

        private int ObtenerOCrearIdCampeonato(string texto)
        {
            texto = texto.Trim();

           
            if (int.TryParse(texto, out int idDirecto))
            {
                return idDirecto;
            }

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                {
                    conexion.Open();

               
                    const string sqlBuscar = "SELECT id_campeonato FROM Campeonato WHERE nombre_campeonato = @nombre LIMIT 1";
                    using (var cmdBuscar = new MySqlCommand(sqlBuscar, conexion))
                    {
                        cmdBuscar.Parameters.AddWithValue("@nombre", texto);
                        object resultado = cmdBuscar.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            return Convert.ToInt32(resultado);
                        }
                    }


                    const string sqlInsertar = "INSERT INTO Campeonato (nombre_campeonato, fecha_inicio, id_deporte, id_tipo, id_estado_campeonato) VALUES (@nombre, CURDATE(), 1, 1, 1); SELECT LAST_INSERT_ID();";
                    using (var cmdInsertar = new MySqlCommand(sqlInsertar, conexion))
                    {
                        cmdInsertar.Parameters.AddWithValue("@nombre", texto);
                        return Convert.ToInt32(cmdInsertar.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con el campeonato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        public string Eliminar_Jornada(int idJornada)
        {
            const string sql = "DELETE FROM Jornada WHERE id_jornada = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idJornada);
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
