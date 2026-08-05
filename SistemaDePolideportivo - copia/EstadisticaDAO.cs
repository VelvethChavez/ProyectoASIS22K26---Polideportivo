using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using SistemaDePolideportivo.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo.DAO
{
    public class EstadisticaDAO
    {
        private readonly ConexionBD conexionBD;

        public EstadisticaDAO()
        {
            conexionBD = new ConexionBD();
        }

        //=========================================================
        // MOSTRAR MENSAJES DE ERROR
        //=========================================================

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Sistema Polideportivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        //=========================================================
        // CARGAR JUGADORES
        //=========================================================

        public DataTable CargarJugadores()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                    SELECT
                        id_jugador,
                        CONCAT(nombres_jugador,' ',apellidos_jugador) AS jugador
                    FROM Jugador
                    WHERE estado = 1
                    ORDER BY nombres_jugador, apellidos_jugador;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

            return tabla;
        }

        //=========================================================
        // CARGAR PARTIDOS
        //=========================================================

        public DataTable CargarPartidos()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                    SELECT
                        id_partido,
                        CONCAT(
                            'Partido #',
                            id_partido,
                            ' | ',
                            DATE_FORMAT(fecha_partido,'%d/%m/%Y'),
                            ' ',
                            TIME_FORMAT(hora_partido,'%H:%i')
                        ) AS partido
                    FROM Partido
                    ORDER BY fecha_partido DESC,
                             hora_partido DESC;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

            return tabla;
        }

        //=========================================================
        // INSERTAR ESTADISTICA
        //=========================================================

        public bool Insertar(EstadisticaJugador estadistica)
        {
            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    string sql = @"
                    INSERT INTO Estadistica_Jugador
                    (
                        observaciones,
                        id_jugador,
                        id_partido
                    )
                    VALUES
                    (
                        @observaciones,
                        @jugador,
                        @partido
                    );";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion);

                    cmd.Parameters.AddWithValue("@observaciones", estadistica.Observaciones);
                    cmd.Parameters.AddWithValue("@jugador", estadistica.IdJugador);
                    cmd.Parameters.AddWithValue("@partido", estadistica.IdPartido);

                    cmd.ExecuteNonQuery();

                    int idEstadistica = Convert.ToInt32(cmd.LastInsertedId);

                    InsertarDetalle(conexion, transaccion, idEstadistica, estadistica);

                    transaccion.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MostrarError(ex);
                    return false;
                }
            }
        }

        //=========================================================
        // INSERTAR DETALLE
        //=========================================================

        private void InsertarDetalle(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idEstadistica,
            EstadisticaJugador e)
        {
            switch (e.Deporte)
            {
                case "Fútbol":
                    InsertarFutbol(conexion, transaccion, idEstadistica, e);
                    break;

                case "Baloncesto":
                    InsertarBaloncesto(conexion, transaccion, idEstadistica, e);
                    break;

                case "Voleibol":
                    InsertarVoleibol(conexion, transaccion, idEstadistica, e);
                    break;

                case "Tenis":
                    InsertarTenis(conexion, transaccion, idEstadistica, e);
                    break;

                default:
                    throw new Exception("Debe seleccionar un deporte válido.");
            }
        }

        //=========================================================
        // INSERTAR FUTBOL
        //=========================================================

        private void InsertarFutbol(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idEstadistica,
            EstadisticaJugador e)
        {
            string sql = @"
                INSERT INTO Estadistica_Futbol
                (
                    id_estadistica,
                    goles,
                    asistencias,
                    tarjetas_amarillas,
                    tarjetas_rojas
                )
                VALUES
                (
                    @id,
                    @goles,
                    @asistencias,
                    @amarillas,
                    @rojas
                );";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@id", idEstadistica);
                cmd.Parameters.AddWithValue("@goles", e.Goles);
                cmd.Parameters.AddWithValue("@asistencias", e.AsistenciasFutbol);
                cmd.Parameters.AddWithValue("@amarillas", e.TarjetasAmarillas);
                cmd.Parameters.AddWithValue("@rojas", e.TarjetasRojas);

                cmd.ExecuteNonQuery();
            }
        }

        //=========================================================
        // INSERTAR BALONCESTO
        //=========================================================

        private void InsertarBaloncesto(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idEstadistica,
            EstadisticaJugador e)
        {
            string sql = @"
                INSERT INTO Estadistica_Baloncesto
                (
                    id_estadistica,
                    puntos,
                    asistencias,
                    canastas
                )
                VALUES
                (
                    @id,
                    @puntos,
                    @asistencias,
                    @canastas
                );";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@id", idEstadistica);
                cmd.Parameters.AddWithValue("@puntos", e.PuntosBaloncesto);
                cmd.Parameters.AddWithValue("@asistencias", e.AsistenciasBaloncesto);
                cmd.Parameters.AddWithValue("@canastas", e.Canastas);

                cmd.ExecuteNonQuery();
            }
        }

        //=========================================================
        // INSERTAR VOLEIBOL
        //=========================================================

        private void InsertarVoleibol(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idEstadistica,
            EstadisticaJugador e)
        {
            string sql = @"
                INSERT INTO Estadistica_Voleibol
                (
                    id_estadistica,
                    puntos,
                    sets_ganados
                )
                VALUES
                (
                    @id,
                    @puntos,
                    @sets
                );";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@id", idEstadistica);
                cmd.Parameters.AddWithValue("@puntos", e.PuntosVoleibol);
                cmd.Parameters.AddWithValue("@sets", e.SetsGanadosVoleibol);

                cmd.ExecuteNonQuery();
            }
        }

        //=========================================================
        // INSERTAR TENIS
        //=========================================================

        private void InsertarTenis(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idEstadistica,
            EstadisticaJugador e)
        {
            string sql = @"
                INSERT INTO Estadistica_Tenis
                (
                    id_estadistica,
                    puntos,
                    sets_ganados
                )
                VALUES
                (
                    @id,
                    @puntos,
                    @sets
                );";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@id", idEstadistica);
                cmd.Parameters.AddWithValue("@puntos", e.PuntosTenis);
                cmd.Parameters.AddWithValue("@sets", e.SetsGanadosTenis);

                cmd.ExecuteNonQuery();
            }
        }

        //=========================================================
        // LISTAR ESTADISTICAS
        //=========================================================

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                    SELECT
                        ej.id_estadistica,
                        ej.id_jugador,
                        ej.id_partido,

                        CONCAT(j.nombres_jugador,' ',j.apellidos_jugador) AS Jugador,

                        CONCAT(
                            'Partido #',
                            p.id_partido,
                            ' - ',
                            DATE_FORMAT(p.fecha_partido,'%d/%m/%Y')
                        ) AS Partido,

                        ej.observaciones,

                        CASE
                            WHEN ef.id_estadistica IS NOT NULL THEN 'Fútbol'
                            WHEN eb.id_estadistica IS NOT NULL THEN 'Baloncesto'
                            WHEN ev.id_estadistica IS NOT NULL THEN 'Voleibol'
                            WHEN et.id_estadistica IS NOT NULL THEN 'Tenis'
                        END AS Deporte,

                        ef.goles,
                        ef.asistencias,
                        ef.tarjetas_amarillas,
                        ef.tarjetas_rojas,

                        eb.puntos AS puntos_baloncesto,
                        eb.asistencias AS asistencias_baloncesto,
                        eb.canastas,

                        ev.puntos AS puntos_voleibol,
                        ev.sets_ganados AS sets_voleibol,

                        et.puntos AS puntos_tenis,
                        et.sets_ganados AS sets_tenis

                    FROM Estadistica_Jugador ej

                    INNER JOIN Jugador j
                        ON ej.id_jugador = j.id_jugador

                    INNER JOIN Partido p
                        ON ej.id_partido = p.id_partido

                    LEFT JOIN Estadistica_Futbol ef
                        ON ej.id_estadistica = ef.id_estadistica

                    LEFT JOIN Estadistica_Baloncesto eb
                        ON ej.id_estadistica = eb.id_estadistica

                    LEFT JOIN Estadistica_Voleibol ev
                        ON ej.id_estadistica = ev.id_estadistica

                    LEFT JOIN Estadistica_Tenis et
                        ON ej.id_estadistica = et.id_estadistica

                    ORDER BY ej.id_estadistica DESC;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

            return tabla;
        }

        //=========================================================
        // BUSCAR ESTADISTICA POR ID
        //=========================================================

        public EstadisticaJugador BuscarPorId(int idEstadistica)
        {
            EstadisticaJugador estadistica = null;

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"
                    SELECT
                        ej.id_estadistica,
                        ej.id_jugador,
                        ej.id_partido,
                        ej.observaciones,

                        CONCAT(j.nombres_jugador,' ',j.apellidos_jugador) AS jugador,

                        CONCAT(
                            'Partido #',
                            p.id_partido,
                            ' - ',
                            DATE_FORMAT(p.fecha_partido,'%d/%m/%Y')
                        ) AS partido,

                        CASE
                            WHEN ef.id_estadistica IS NOT NULL THEN 'Fútbol'
                            WHEN eb.id_estadistica IS NOT NULL THEN 'Baloncesto'
                            WHEN ev.id_estadistica IS NOT NULL THEN 'Voleibol'
                            WHEN et.id_estadistica IS NOT NULL THEN 'Tenis'
                        END AS deporte,

                        ef.goles,
                        ef.asistencias,
                        ef.tarjetas_amarillas,
                        ef.tarjetas_rojas,

                        eb.puntos AS puntos_baloncesto,
                        eb.asistencias AS asistencias_baloncesto,
                        eb.canastas,

                        ev.puntos AS puntos_voleibol,
                        ev.sets_ganados AS sets_voleibol,

                        et.puntos AS puntos_tenis,
                        et.sets_ganados AS sets_tenis

                    FROM Estadistica_Jugador ej

                    INNER JOIN Jugador j
                        ON ej.id_jugador = j.id_jugador

                    INNER JOIN Partido p
                        ON ej.id_partido = p.id_partido

                    LEFT JOIN Estadistica_Futbol ef
                        ON ej.id_estadistica = ef.id_estadistica

                    LEFT JOIN Estadistica_Baloncesto eb
                        ON ej.id_estadistica = eb.id_estadistica

                    LEFT JOIN Estadistica_Voleibol ev
                        ON ej.id_estadistica = ev.id_estadistica

                    LEFT JOIN Estadistica_Tenis et
                        ON ej.id_estadistica = et.id_estadistica

                    WHERE ej.id_estadistica=@id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", idEstadistica);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                estadistica = new EstadisticaJugador();

                                estadistica.IdEstadistica = Convert.ToInt32(dr["id_estadistica"]);
                                estadistica.IdJugador = Convert.ToInt32(dr["id_jugador"]);
                                estadistica.IdPartido = Convert.ToInt32(dr["id_partido"]);
                                estadistica.Observaciones = dr["observaciones"].ToString();

                                estadistica.NombreJugador = dr["jugador"].ToString();
                                estadistica.NombrePartido = dr["partido"].ToString();

                                estadistica.Deporte = dr["deporte"].ToString();

                                //========== FUTBOL ==========
                                if (estadistica.Deporte == "Fútbol")
                                {
                                    estadistica.Goles = dr["goles"] == DBNull.Value ? 0 : Convert.ToInt32(dr["goles"]);
                                    estadistica.AsistenciasFutbol = dr["asistencias"] == DBNull.Value ? 0 : Convert.ToInt32(dr["asistencias"]);
                                    estadistica.TarjetasAmarillas = dr["tarjetas_amarillas"] == DBNull.Value ? 0 : Convert.ToInt32(dr["tarjetas_amarillas"]);
                                    estadistica.TarjetasRojas = dr["tarjetas_rojas"] == DBNull.Value ? 0 : Convert.ToInt32(dr["tarjetas_rojas"]);
                                }

                                //========== BALONCESTO ==========
                                if (estadistica.Deporte == "Baloncesto")
                                {
                                    estadistica.PuntosBaloncesto = dr["puntos_baloncesto"] == DBNull.Value ? 0 : Convert.ToInt32(dr["puntos_baloncesto"]);
                                    estadistica.AsistenciasBaloncesto = dr["asistencias_baloncesto"] == DBNull.Value ? 0 : Convert.ToInt32(dr["asistencias_baloncesto"]);
                                    estadistica.Canastas = dr["canastas"] == DBNull.Value ? 0 : Convert.ToInt32(dr["canastas"]);
                                }

                                //========== VOLEIBOL ==========
                                if (estadistica.Deporte == "Voleibol")
                                {
                                    estadistica.PuntosVoleibol = dr["puntos_voleibol"] == DBNull.Value ? 0 : Convert.ToInt32(dr["puntos_voleibol"]);
                                    estadistica.SetsGanadosVoleibol = dr["sets_voleibol"] == DBNull.Value ? 0 : Convert.ToInt32(dr["sets_voleibol"]);
                                }

                                //========== TENIS ==========
                                if (estadistica.Deporte == "Tenis")
                                {
                                    estadistica.PuntosTenis = dr["puntos_tenis"] == DBNull.Value ? 0 : Convert.ToInt32(dr["puntos_tenis"]);
                                    estadistica.SetsGanadosTenis = dr["sets_tenis"] == DBNull.Value ? 0 : Convert.ToInt32(dr["sets_tenis"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

            return estadistica;
        }

                    //=========================================================
                    // ACTUALIZAR ESTADISTICA
                    //=========================================================

        public bool Actualizar(EstadisticaJugador estadistica)
        {
            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    string sql = @"
                    UPDATE Estadistica_Jugador
                    SET
                        observaciones=@observaciones,
                        id_jugador=@jugador,
                        id_partido=@partido
                    WHERE id_estadistica=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion);

                    cmd.Parameters.AddWithValue("@observaciones", estadistica.Observaciones);
                    cmd.Parameters.AddWithValue("@jugador", estadistica.IdJugador);
                    cmd.Parameters.AddWithValue("@partido", estadistica.IdPartido);
                    cmd.Parameters.AddWithValue("@id", estadistica.IdEstadistica);

                    cmd.ExecuteNonQuery();

                    ActualizarDetalle(conexion, transaccion, estadistica);

                    transaccion.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MostrarError(ex);

                    return false;
                }
            }
        }

        //=========================================================
        // ACTUALIZAR DETALLE
        //=========================================================

        private void ActualizarDetalle(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            EstadisticaJugador e)
        {
            switch (e.Deporte)
            {
                case "Fútbol":
                    ActualizarFutbol(conexion, transaccion, e);
                    break;

                case "Baloncesto":
                    ActualizarBaloncesto(conexion, transaccion, e);
                    break;

                case "Voleibol":
                    ActualizarVoleibol(conexion, transaccion, e);
                    break;

                case "Tenis":
                    ActualizarTenis(conexion, transaccion, e);
                    break;

                default:
                    throw new Exception("Deporte no válido.");
            }
        }

        private void ActualizarFutbol(
    MySqlConnection conexion,
    MySqlTransaction transaccion,
    EstadisticaJugador e)
        {
            string sql = @"
            UPDATE Estadistica_Futbol
            SET
                goles=@goles,
                asistencias=@asistencias,
                tarjetas_amarillas=@amarillas,
                tarjetas_rojas=@rojas
            WHERE id_estadistica=@id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@goles", e.Goles);
                cmd.Parameters.AddWithValue("@asistencias", e.AsistenciasFutbol);
                cmd.Parameters.AddWithValue("@amarillas", e.TarjetasAmarillas);
                cmd.Parameters.AddWithValue("@rojas", e.TarjetasRojas);
                cmd.Parameters.AddWithValue("@id", e.IdEstadistica);

                cmd.ExecuteNonQuery();
            }
        }

        private void ActualizarBaloncesto(
    MySqlConnection conexion,
    MySqlTransaction transaccion,
    EstadisticaJugador e)
        {
            string sql = @"
            UPDATE Estadistica_Baloncesto
            SET
                puntos=@puntos,
                asistencias=@asistencias,
                canastas=@canastas
            WHERE id_estadistica=@id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@puntos", e.PuntosBaloncesto);
                cmd.Parameters.AddWithValue("@asistencias", e.AsistenciasBaloncesto);
                cmd.Parameters.AddWithValue("@canastas", e.Canastas);
                cmd.Parameters.AddWithValue("@id", e.IdEstadistica);

                cmd.ExecuteNonQuery();
            }
        }

        private void ActualizarVoleibol(
    MySqlConnection conexion,
    MySqlTransaction transaccion,
    EstadisticaJugador e)
        {
            string sql = @"
            UPDATE Estadistica_Voleibol
            SET
                puntos=@puntos,
                sets_ganados=@sets
            WHERE id_estadistica=@id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@puntos", e.PuntosVoleibol);
                cmd.Parameters.AddWithValue("@sets", e.SetsGanadosVoleibol);
                cmd.Parameters.AddWithValue("@id", e.IdEstadistica);

                cmd.ExecuteNonQuery();
            }
        }

        private void ActualizarTenis(
    MySqlConnection conexion,
    MySqlTransaction transaccion,
    EstadisticaJugador e)
        {
            string sql = @"
            UPDATE Estadistica_Tenis
            SET
                puntos=@puntos,
                sets_ganados=@sets
            WHERE id_estadistica=@id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@puntos", e.PuntosTenis);
                cmd.Parameters.AddWithValue("@sets", e.SetsGanadosTenis);
                cmd.Parameters.AddWithValue("@id", e.IdEstadistica);

                cmd.ExecuteNonQuery();
            }
        }

        //=========================================================
        // ELIMINAR ESTADISTICA
        //=========================================================

        public bool Eliminar(int idEstadistica)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"DELETE FROM Estadistica_Jugador
                                   WHERE id_estadistica=@id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", idEstadistica);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
                return false;
            }
        }

        //=========================================================
        // BUSCAR ESTADISTICAS
        //=========================================================

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"

                    SELECT
                        ej.id_estadistica,
                        CONCAT(j.nombres_jugador,' ',j.apellidos_jugador) AS Jugador,

                        CONCAT(
                            'Partido #',
                            p.id_partido,
                            ' - ',
                            DATE_FORMAT(p.fecha_partido,'%d/%m/%Y')
                        ) AS Partido,

                        CASE
                            WHEN ef.id_estadistica IS NOT NULL THEN 'Fútbol'
                            WHEN eb.id_estadistica IS NOT NULL THEN 'Baloncesto'
                            WHEN ev.id_estadistica IS NOT NULL THEN 'Voleibol'
                            WHEN et.id_estadistica IS NOT NULL THEN 'Tenis'
                        END AS Deporte,

                        ej.observaciones

                    FROM Estadistica_Jugador ej

                    INNER JOIN Jugador j
                        ON ej.id_jugador=j.id_jugador

                    INNER JOIN Partido p
                        ON ej.id_partido=p.id_partido

                    LEFT JOIN Estadistica_Futbol ef
                        ON ej.id_estadistica=ef.id_estadistica

                    LEFT JOIN Estadistica_Baloncesto eb
                        ON ej.id_estadistica=eb.id_estadistica

                    LEFT JOIN Estadistica_Voleibol ev
                        ON ej.id_estadistica=ev.id_estadistica

                    LEFT JOIN Estadistica_Tenis et
                        ON ej.id_estadistica=et.id_estadistica

                    WHERE

                        CONCAT(j.nombres_jugador,' ',j.apellidos_jugador)
                        LIKE @texto

                        OR

                        ej.observaciones
                        LIKE @texto

                    ORDER BY ej.id_estadistica DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

            return tabla;
        }

    }
}

