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
    internal class CPartido
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

       
        public DataTable Listado_Partidos(string filtro)
        {
            const string sql =
                "SELECT p.id_partido, j.nombre_jornada, " +
                "el.nombre_equipo AS equipo_local, ev.nombre_equipo AS equipo_visitante, " +
                "c.nombre_campo, CONCAT(a.nombres_arbitro, ' ', a.apellidos_arbitro) AS arbitro, " +
                "p.fecha_partido, p.hora_partido, ep.nombre_estado " +
                "FROM Partido p " +
                "INNER JOIN Jornada j ON p.id_jornada = j.id_jornada " +
                "INNER JOIN Equipo el ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev ON p.id_equipo_visitante = ev.id_equipo " +
                "INNER JOIN Campo c ON p.id_campo = c.id_campo " +
                "LEFT JOIN Arbitro a ON p.id_arbitro = a.id_arbitro " +
                "INNER JOIN Estado_Partido ep ON p.id_estado_partido = ep.id_estado_partido " +
                "WHERE el.nombre_equipo LIKE @filtro OR ev.nombre_equipo LIKE @filtro OR j.nombre_jornada LIKE @filtro " +
                "ORDER BY p.id_partido DESC";

            var tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", filtro);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los partidos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

    
        public string Guardar_Partido(int opcion, string jornadaTexto, string localTexto, string visitanteTexto,
                                      string campoTexto, string arbitroTexto, string estadoTexto,
                                      DateTime fecha, TimeSpan hora, int idPartido = 0)
        {
           
            int idJornada = ObtenerId("Jornada", "id_jornada", "nombre_jornada", jornadaTexto);
            int idLocal = ObtenerId("Equipo", "id_equipo", "nombre_equipo", localTexto);
            int idVisitante = ObtenerId("Equipo", "id_equipo", "nombre_equipo", visitanteTexto);
            int idCampo = ObtenerId("Campo", "id_campo", "nombre_campo", campoTexto);
            int idArbitro = ObtenerId("Arbitro", "id_arbitro", "nombres_arbitro", arbitroTexto);
            int idEstado = ObtenerId("Estado_Partido", "id_estado_partido", "nombre_estado", estadoTexto);

           
            if (idJornada == 0) return "La jornada especificada no existe.";
            if (idLocal == 0) return "El equipo local especificado no existe.";
            if (idVisitante == 0) return "El equipo visitante especificado no existe.";
            if (idLocal == idVisitante) return "El equipo local y el visitante no pueden ser el mismo.";
            if (idCampo == 0) return "El campo especificado no existe.";
            if (idEstado == 0) idEstado = 1; 

            string sql;

            if (opcion == 1)
            {
                sql = "INSERT INTO Partido (fecha_partido, hora_partido, id_jornada, id_equipo_local, id_equipo_visitante, id_campo, id_arbitro, id_estado_partido) " +
                      "VALUES (@fecha, @hora, @idJornada, @idLocal, @idVisitante, @idCampo, @idArbitro, @idEstado)";
            }
            else
            {
                sql = "UPDATE Partido SET fecha_partido = @fecha, hora_partido = @hora, id_jornada = @idJornada, " +
                      "id_equipo_local = @idLocal, id_equipo_visitante = @idVisitante, id_campo = @idCampo, " +
                      "id_arbitro = @idArbitro, id_estado_partido = @idEstado WHERE id_partido = @id";
            }

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@hora", hora);
                    comando.Parameters.AddWithValue("@idJornada", idJornada);
                    comando.Parameters.AddWithValue("@idLocal", idLocal);
                    comando.Parameters.AddWithValue("@idVisitante", idVisitante);
                    comando.Parameters.AddWithValue("@idCampo", idCampo);
                    comando.Parameters.AddWithValue("@idArbitro", idArbitro > 0 ? (object)idArbitro : DBNull.Value);
                    comando.Parameters.AddWithValue("@idEstado", idEstado);

                    if (opcion == 2) comando.Parameters.AddWithValue("@id", idPartido);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0 ? "OK" : "No se completó la operación.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
     
        public string Eliminar_Partido(int idPartido)
        {
            const string sql = "DELETE FROM Partido WHERE id_partido = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPartido);
                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0 ? "OK" : "No se encontró el registro para eliminar.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        private int ObtenerId(string tabla, string campoId, string campoNombre, string texto)
        {
            texto = texto.Trim();
            if (string.IsNullOrEmpty(texto)) return 0;
            if (int.TryParse(texto, out int idDirecto)) return idDirecto;

            string sql = $"SELECT {campoId} FROM {tabla} WHERE {campoNombre} LIKE @nombre LIMIT 1";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", "%" + texto + "%");
                    conexion.Open();
                    object res = comando.ExecuteScalar();
                    return res != null && res != DBNull.Value ? Convert.ToInt32(res) : 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
