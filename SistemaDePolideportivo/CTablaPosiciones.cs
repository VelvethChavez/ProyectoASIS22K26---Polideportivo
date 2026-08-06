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
    internal class CTablaPosiciones
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

        public DataTable ObtenerTablaPosiciones(string filtroCampeonato)
        {

            const string sql = @"
                SELECT 
                    e.nombre_equipo AS 'EQUIPO',
                    COUNT(p.id_partido) AS 'PJ',
                    SUM(CASE 
                        WHEN (p.id_equipo_local = e.id_equipo AND p.marcador_local > p.marcador_visitante) OR 
                             (p.id_equipo_visitante = e.id_equipo AND p.marcador_visitante > p.marcador_local) THEN 1 ELSE 0 END) AS 'PG',
                    SUM(CASE 
                        WHEN p.marcador_local = p.marcador_visitante AND p.id_partido IS NOT NULL THEN 1 ELSE 0 END) AS 'PE',
                    SUM(CASE 
                        WHEN (p.id_equipo_local = e.id_equipo AND p.marcador_local < p.marcador_visitante) OR 
                             (p.id_equipo_visitante = e.id_equipo AND p.marcador_visitante < p.marcador_local) THEN 1 ELSE 0 END) AS 'PP',
                    IFNULL(SUM(CASE WHEN p.id_equipo_local = e.id_equipo THEN p.marcador_local ELSE p.marcador_visitante END), 0) AS 'GF',
                    IFNULL(SUM(CASE WHEN p.id_equipo_local = e.id_equipo THEN p.marcador_visitante ELSE p.marcador_local END), 0) AS 'GC',
                    IFNULL(SUM(CASE WHEN p.id_equipo_local = e.id_equipo THEN p.marcador_local - p.marcador_visitante ELSE p.marcador_visitante - p.marcador_local END), 0) AS 'DG',
                    SUM(CASE 
                        WHEN (p.id_equipo_local = e.id_equipo AND p.marcador_local > p.marcador_visitante) OR 
                             (p.id_equipo_visitante = e.id_equipo AND p.marcador_visitante > p.marcador_local) THEN 3
                        WHEN p.marcador_local = p.marcador_visitante AND p.id_partido IS NOT NULL THEN 1 ELSE 0 END) AS 'PTS'
                FROM Equipo e
                LEFT JOIN Partido p ON (e.id_equipo = p.id_equipo_local OR e.id_equipo = p.id_equipo_visitante) 
                                    AND p.id_estado_partido = 2
                LEFT JOIN Jornada j ON p.id_jornada = j.id_jornada
                LEFT JOIN Campeonato c ON j.id_campeonato = c.id_campeonato
                WHERE c.nombre_campeonato LIKE @filtro OR @filtro = '%'
                GROUP BY e.id_equipo, e.nombre_equipo
                ORDER BY PTS DESC, DG DESC, GF DESC;";

            var tabla = new DataTable();

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", string.IsNullOrEmpty(filtroCampeonato) ? "%" : "%" + filtroCampeonato + "%");
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }

                
                if (!tabla.Columns.Contains("POS"))
                {
                    DataColumn colPos = new DataColumn("POS", typeof(int));
                    tabla.Columns.Add(colPos);
                    colPos.SetOrdinal(0); 

                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        tabla.Rows[i]["POS"] = i + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la tabla de posiciones: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }
    }
}