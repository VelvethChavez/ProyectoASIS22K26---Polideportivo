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


        // ============================================================
        // LISTADO DE RESULTADOS
        // ============================================================
        public DataTable Listado_Resultados(string filtro)
        {
            const string sql =
                "SELECT " +
                "p.id_partido, " +
                "j.nombre_jornada, " +
                "el.nombre_equipo AS local, " +
                "p.marcador_local, " +
                "ev.nombre_equipo AS visitante, " +
                "p.marcador_visitante, " +
                "ep.nombre_estado, " +
                "p.fecha_partido, " +
                "p.id_estado_partido " +
                "FROM Partido p " +
                "INNER JOIN Jornada j ON p.id_jornada = j.id_jornada " +
                "INNER JOIN Equipo el ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev ON p.id_equipo_visitante = ev.id_equipo " +
                "INNER JOIN Estado_Partido ep ON p.id_estado_partido = ep.id_estado_partido " +
                "WHERE el.nombre_equipo LIKE @filtro " +
                "OR ev.nombre_equipo LIKE @filtro " +
                "OR j.nombre_jornada LIKE @filtro " +
                "OR ep.nombre_estado LIKE @filtro " +
                "ORDER BY p.id_partido DESC";

            DataTable tabla = new DataTable();

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
                MessageBox.Show(
                    "Error al cargar los resultados: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // LISTADO DE PARTIDOS PARA COMBOBOX
        // ============================================================
        public DataTable Listado_Partidos()
        {
            const string sql =
                "SELECT " +
                "p.id_partido, " +
                "CONCAT(" +
                "el.nombre_equipo, ' vs ', ev.nombre_equipo, " +
                "' - ', DATE_FORMAT(p.fecha_partido, '%d/%m/%Y'), " +
                "' ', TIME_FORMAT(p.hora_partido, '%H:%i')" +
                ") AS partido " +
                "FROM Partido p " +
                "INNER JOIN Equipo el " +
                "ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev " +
                "ON p.id_equipo_visitante = ev.id_equipo " +
                "ORDER BY p.fecha_partido DESC, p.hora_partido DESC";

            DataTable tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.CommandTimeout = 60;

                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los partidos: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // LISTADO DE ESTADOS PARA COMBOBOX
        // ============================================================
        public DataTable Listado_Estados()
        {
            const string sql =
                "SELECT " +
                "id_estado_partido, " +
                "nombre_estado " +
                "FROM Estado_Partido " +
                "ORDER BY id_estado_partido";

            DataTable tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.CommandTimeout = 60;

                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los estados: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // GUARDAR RESULTADO
        // ============================================================
        public string Guardar_Resultado(
            int idPartido,
            int marcadorLocal,
            int marcadorVisitante,
            int idEstado)
        {
            if (idPartido <= 0)
            {
                return "Seleccione un partido.";
            }

            if (idEstado <= 0)
            {
                return "Seleccione un estado.";
            }

            const string sql =
                "UPDATE Partido SET " +
                "marcador_local = @mLocal, " +
                "marcador_visitante = @mVisitante, " +
                "id_estado_partido = @idEstado " +
                "WHERE id_partido = @idPartido";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@mLocal",
                        marcadorLocal);

                    comando.Parameters.AddWithValue(
                        "@mVisitante",
                        marcadorVisitante);

                    comando.Parameters.AddWithValue(
                        "@idEstado",
                        idEstado);

                    comando.Parameters.AddWithValue(
                        "@idPartido",
                        idPartido);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se encontró el partido para actualizar.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // ============================================================
        // ELIMINAR / RESTABLECER RESULTADO
        // ============================================================
        public string Eliminar_Resultado(int idPartido)
        {
            /*
             * Al eliminar el resultado:
             * - marcador local = 0
             * - marcador visitante = 0
             * - estado = 1
             *
             * Se asume que id_estado_partido = 1
             * corresponde a "Programado".
             */

            const string sql =
                "UPDATE Partido SET " +
                "marcador_local = 0, " +
                "marcador_visitante = 0, " +
                "id_estado_partido = 1 " +
                "WHERE id_partido = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        idPartido);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se encontró el partido para restablecer.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}