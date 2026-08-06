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
    internal class CResultado
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();


        public DataTable Listado_Resultados(string filtro)
        {
            const string sql =
                "SELECT p.id_partido, j.nombre_jornada, " +
                "el.nombre_equipo AS local, p.marcador_local, " +
                "ev.nombre_equipo AS visitante, p.marcador_visitante, " +
                "ep.nombre_estado, p.fecha_partido " +
                "FROM Partido p " +
                "INNER JOIN Jornada j ON p.id_jornada = j.id_jornada " +
                "INNER JOIN Equipo el ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev ON p.id_equipo_visitante = ev.id_equipo " +
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
                MessageBox.Show("Error al cargar resultados: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }


        public string Guardar_Resultado(string partidoTexto, int marcadorLocal, int marcadorVisitante, string estadoTexto, int idPartido = 0)
        {
            int idPartidoReal = idPartido > 0 ? idPartido : ObtenerIdPartido(partidoTexto);
            int idEstado = ObtenerIdEstado(estadoTexto);

            if (idPartidoReal == 0) return "El partido especificado no existe o no fue encontrado.";
            if (idEstado == 0) idEstado = 2; 

            const string sql =
                "UPDATE Partido SET marcador_local = @mLocal, marcador_visitante = @mVisitante, " +
                "id_estado_partido = @idEstado WHERE id_partido = @idPartido";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@mLocal", marcadorLocal);
                    comando.Parameters.AddWithValue("@mVisitante", marcadorVisitante);
                    comando.Parameters.AddWithValue("@idEstado", idEstado);
                    comando.Parameters.AddWithValue("@idPartido", idPartidoReal);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0 ? "OK" : "No se encontró el partido para actualizar.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar_Resultado(int idPartido)
        {
            const string sql = "UPDATE Partido SET marcador_local = 0, marcador_visitante = 0, id_estado_partido = 1 WHERE id_partido = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPartido);
                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0 ? "OK" : "No se encontró el partido para restablecer.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private int ObtenerIdPartido(string texto)
        {
            texto = texto.Trim();
            if (string.IsNullOrEmpty(texto)) return 0;
            if (int.TryParse(texto, out int idDirecto)) return idDirecto;

            const string sql =
                "SELECT p.id_partido FROM Partido p " +
                "INNER JOIN Equipo el ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev ON p.id_equipo_visitante = ev.id_equipo " +
                "WHERE el.nombre_equipo LIKE @nombre OR ev.nombre_equipo LIKE @nombre LIMIT 1";

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

        private int ObtenerIdEstado(string texto)
        {
            texto = texto.Trim();
            if (string.IsNullOrEmpty(texto)) return 0;
            if (int.TryParse(texto, out int idDirecto)) return idDirecto;

            const string sql = "SELECT id_estado_partido FROM Estado_Partido WHERE nombre_estado LIKE @nombre LIMIT 1";

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
