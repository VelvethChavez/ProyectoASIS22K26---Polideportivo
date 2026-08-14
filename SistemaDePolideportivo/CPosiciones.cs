using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    internal class CPosiciones
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

        // ============================================================
        // LISTADO DE CAMPEONATOS
        // ============================================================
        public DataTable Listado_Campeonatos()
        {
            const string sql =
                "SELECT id_campeonato, nombre_campeonato " +
                "FROM Campeonato " +
                "ORDER BY id_campeonato";

            DataTable tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                using (var adaptador = new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los campeonatos: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // TABLA DE POSICIONES
        // ============================================================
        public DataTable ObtenerTablaPosiciones(int idCampeonato)
        {
            DataTable tabla = new DataTable();

            const string sql =
                "SELECT " +
                "   equipo, " +
                "   SUM(pj) AS PJ, " +
                "   SUM(pg) AS PG, " +
                "   SUM(pe) AS PE, " +
                "   SUM(pp) AS PP, " +
                "   SUM(gf) AS GF, " +
                "   SUM(gc) AS GC, " +
                "   SUM(gf) - SUM(gc) AS DG, " +
                "   SUM(puntos) AS PTS " +
                "FROM ( " +

                // ====================================================
                // EQUIPO LOCAL
                // ====================================================
                "   SELECT " +
                "       el.id_equipo, " +
                "       el.nombre_equipo AS equipo, " +

                "       1 AS pj, " +

                "       CASE " +
                "           WHEN p.marcador_local > p.marcador_visitante THEN 1 " +
                "           ELSE 0 " +
                "       END AS pg, " +

                "       CASE " +
                "           WHEN p.marcador_local = p.marcador_visitante THEN 1 " +
                "           ELSE 0 " +
                "       END AS pe, " +

                "       CASE " +
                "           WHEN p.marcador_local < p.marcador_visitante THEN 1 " +
                "           ELSE 0 " +
                "       END AS pp, " +

                "       p.marcador_local AS gf, " +
                "       p.marcador_visitante AS gc, " +

                "       CASE " +
                "           WHEN p.marcador_local > p.marcador_visitante THEN 3 " +
                "           WHEN p.marcador_local = p.marcador_visitante THEN 1 " +
                "           ELSE 0 " +
                "       END AS puntos " +

                "   FROM Partido p " +
                "   INNER JOIN Jornada j " +
                "       ON p.id_jornada = j.id_jornada " +
                "   INNER JOIN Equipo el " +
                "       ON p.id_equipo_local = el.id_equipo " +
                "   INNER JOIN Estado_Partido ep " +
                "       ON p.id_estado_partido = ep.id_estado_partido " +

                "   WHERE j.id_campeonato = @idCampeonato " +
                "   AND LOWER(ep.nombre_estado) IN ('finalizado', 'concluido') " +

                "   UNION ALL " +

                // ====================================================
                // EQUIPO VISITANTE
                // ====================================================
                "   SELECT " +
                "       ev.id_equipo, " +
                "       ev.nombre_equipo AS equipo, " +

                "       1 AS pj, " +

                "       CASE " +
                "           WHEN p.marcador_visitante > p.marcador_local THEN 1 " +
                "           ELSE 0 " +
                "       END AS pg, " +

                "       CASE " +
                "           WHEN p.marcador_visitante = p.marcador_local THEN 1 " +
                "           ELSE 0 " +
                "       END AS pe, " +

                "       CASE " +
                "           WHEN p.marcador_visitante < p.marcador_local THEN 1 " +
                "           ELSE 0 " +
                "       END AS pp, " +

                "       p.marcador_visitante AS gf, " +
                "       p.marcador_local AS gc, " +

                "       CASE " +
                "           WHEN p.marcador_visitante > p.marcador_local THEN 3 " +
                "           WHEN p.marcador_visitante = p.marcador_local THEN 1 " +
                "           ELSE 0 " +
                "       END AS puntos " +

                "   FROM Partido p " +
                "   INNER JOIN Jornada j " +
                "       ON p.id_jornada = j.id_jornada " +
                "   INNER JOIN Equipo ev " +
                "       ON p.id_equipo_visitante = ev.id_equipo " +
                "   INNER JOIN Estado_Partido ep " +
                "       ON p.id_estado_partido = ep.id_estado_partido " +

                "   WHERE j.id_campeonato = @idCampeonato " +
                "   AND LOWER(ep.nombre_estado) IN ('finalizado', 'concluido') " +

                ") AS resultados " +

                "GROUP BY id_equipo, equipo " +

                "ORDER BY PTS DESC, DG DESC, GF DESC, equipo ASC";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@idCampeonato",
                        idCampeonato);

                    comando.CommandTimeout = 60;

                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                // ====================================================
                // AGREGAR POSICIÓN
                // ====================================================
                tabla.Columns.Add("POS", typeof(int));

                int posicion = 1;

                foreach (DataRow fila in tabla.Rows)
                {
                    fila["POS"] = posicion;
                    posicion++;
                }


                tabla.Columns["POS"].SetOrdinal(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar la tabla de posiciones: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }
    }
}    
