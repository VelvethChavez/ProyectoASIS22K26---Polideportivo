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

        // ============================================================
        // LISTAR PARTIDOS
        // ============================================================
        public DataTable Listado_Partidos(string filtro)
        {
            const string sql =
                "SELECT " +
                "p.id_partido, " +
                "p.fecha_partido, " +
                "p.hora_partido, " +
                "p.marcador_local, " +
                "p.marcador_visitante, " +
                "j.id_jornada, " +
                "j.nombre_jornada, " +
                "el.id_equipo AS id_equipo_local, " +
                "el.nombre_equipo AS equipo_local, " +
                "ev.id_equipo AS id_equipo_visitante, " +
                "ev.nombre_equipo AS equipo_visitante, " +
                "c.id_campo, " +
                "c.nombre_campo, " +
                "a.id_arbitro, " +
                "CONCAT(a.nombres_arbitro, ' ', a.apellidos_arbitro) AS arbitro, " +
                "ep.id_estado_partido, " +
                "ep.nombre_estado " +
                "FROM Partido p " +
                "INNER JOIN Jornada j ON p.id_jornada = j.id_jornada " +
                "INNER JOIN Equipo el ON p.id_equipo_local = el.id_equipo " +
                "INNER JOIN Equipo ev ON p.id_equipo_visitante = ev.id_equipo " +
                "INNER JOIN Campo c ON p.id_campo = c.id_campo " +
                "LEFT JOIN Arbitro a ON p.id_arbitro = a.id_arbitro " +
                "INNER JOIN Estado_Partido ep ON p.id_estado_partido = ep.id_estado_partido " +
                "WHERE el.nombre_equipo LIKE @filtro " +
                "OR ev.nombre_equipo LIKE @filtro " +
                "OR j.nombre_jornada LIKE @filtro " +
                "ORDER BY p.id_partido DESC";

            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = _conexionBD.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
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
        // LISTAR JORNADAS
        // ============================================================
        public DataTable Listado_Jornadas()
        {
            const string sql =
                "SELECT id_jornada, nombre_jornada, fecha_jornada " +
                "FROM Jornada " +
                "ORDER BY numero_jornada, fecha_jornada";

            return EjecutarConsulta(sql);
        }


        // ============================================================
        // LISTAR EQUIPOS
        // ============================================================
        public DataTable Listado_Equipos()
        {
            const string sql =
                "SELECT id_equipo, nombre_equipo " +
                "FROM Equipo " +
                "WHERE estado = 1 " +
                "ORDER BY nombre_equipo";

            return EjecutarConsulta(sql);
        }


        // ============================================================
        // LISTAR CAMPOS
        // ============================================================
        public DataTable Listado_Campos()
        {
            const string sql =
                "SELECT id_campo, nombre_campo " +
                "FROM Campo " +
                "ORDER BY nombre_campo";

            return EjecutarConsulta(sql);
        }


        // ============================================================
        // LISTAR ÁRBITROS
        // ============================================================
        public DataTable Listado_Arbitros()
        {
            const string sql =
                "SELECT id_arbitro, " +
                "CONCAT(nombres_arbitro, ' ', apellidos_arbitro) AS nombre_arbitro " +
                "FROM Arbitro " +
                "ORDER BY nombres_arbitro, apellidos_arbitro";

            return EjecutarConsulta(sql);
        }


        // ============================================================
        // LISTAR ESTADOS DEL PARTIDO
        // ============================================================
        public DataTable Listado_Estados()
        {
            const string sql =
                "SELECT id_estado_partido, nombre_estado " +
                "FROM Estado_Partido " +
                "ORDER BY nombre_estado";

            return EjecutarConsulta(sql);
        }


        // ============================================================
        // MÉTODO GENERAL PARA CONSULTAS
        // ============================================================
        private DataTable EjecutarConsulta(string sql)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = _conexionBD.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar la base de datos: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // GUARDAR / EDITAR PARTIDO
        // opcion = 1 -> INSERTAR
        // opcion = 2 -> ACTUALIZAR
        // ============================================================
        public string Guardar_Partido(
            int opcion,
            int idJornada,
            int idLocal,
            int idVisitante,
            int idCampo,
            int? idArbitro,
            int idEstado,
            DateTime fecha,
            TimeSpan hora,
            int idPartido = 0)
        {
            // ---------------------------------------------
            // VALIDACIONES
            // ---------------------------------------------

            if (idJornada <= 0)
                return "Debe seleccionar una jornada.";

            if (idLocal <= 0)
                return "Debe seleccionar el equipo local.";

            if (idVisitante <= 0)
                return "Debe seleccionar el equipo visitante.";

            if (idLocal == idVisitante)
                return "El equipo local y el visitante no pueden ser el mismo.";

            if (idCampo <= 0)
                return "Debe seleccionar un campo.";

            if (idEstado <= 0)
                return "Debe seleccionar un estado.";

            if (opcion == 2 && idPartido <= 0)
                return "No se ha seleccionado un partido para editar.";


            string sql;


            // ---------------------------------------------
            // INSERTAR
            // ---------------------------------------------
            if (opcion == 1)
            {
                sql =
                    "INSERT INTO Partido " +
                    "(fecha_partido, hora_partido, " +
                    "marcador_local, marcador_visitante, " +
                    "id_estado_partido, id_jornada, id_campo, " +
                    "id_arbitro, id_equipo_local, id_equipo_visitante) " +
                    "VALUES " +
                    "(@fecha, @hora, 0, 0, @estado, @jornada, " +
                    "@campo, @arbitro, @equipoLocal, @equipoVisitante)";
            }
            // ---------------------------------------------
            // ACTUALIZAR
            // ---------------------------------------------
            else
            {
                sql =
                    "UPDATE Partido SET " +
                    "fecha_partido = @fecha, " +
                    "hora_partido = @hora, " +
                    "id_estado_partido = @estado, " +
                    "id_jornada = @jornada, " +
                    "id_campo = @campo, " +
                    "id_arbitro = @arbitro, " +
                    "id_equipo_local = @equipoLocal, " +
                    "id_equipo_visitante = @equipoVisitante " +
                    "WHERE id_partido = @id";
            }


            try
            {
                using (MySqlConnection conexion = _conexionBD.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", fecha.Date);
                    comando.Parameters.AddWithValue("@hora", hora);
                    comando.Parameters.AddWithValue("@estado", idEstado);
                    comando.Parameters.AddWithValue("@jornada", idJornada);
                    comando.Parameters.AddWithValue("@campo", idCampo);
                    comando.Parameters.AddWithValue(
                        "@arbitro",
                        idArbitro.HasValue
                            ? (object)idArbitro.Value
                            : DBNull.Value);
                    comando.Parameters.AddWithValue("@equipoLocal", idLocal);
                    comando.Parameters.AddWithValue("@equipoVisitante", idVisitante);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue("@id", idPartido);
                    }

                    conexion.Open();

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        return "OK";
                    }

                    return "No se completó la operación.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // ============================================================
        // ELIMINAR PARTIDO
        // ============================================================
        public string Eliminar_Partido(int idPartido)
        {
            const string sql =
                "DELETE FROM Partido WHERE id_partido = @id";

            try
            {
                using (MySqlConnection conexion = _conexionBD.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPartido);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se encontró el registro para eliminar.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}