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


    
        public DataTable Listado_Campeonatos()
        {
            const string sql =
                "SELECT id_campeonato, nombre_campeonato " +
                "FROM Campeonato " +
                "ORDER BY nombre_campeonato";

            return EjecutarConsulta(sql);
        }



        public DataTable Listado_Jornadas(string filtro)
        {
            const string sql =
                "SELECT " +
                "j.id_jornada, " +
                "j.nombre_jornada, " +
                "j.numero_jornada, " +
                "j.fecha_jornada, " +
                "c.nombre_campeonato, " +
                "j.id_campeonato " +
                "FROM Jornada j " +
                "INNER JOIN Campeonato c " +
                "ON j.id_campeonato = c.id_campeonato " +
                "WHERE j.nombre_jornada LIKE @filtro " +
                "OR c.nombre_campeonato LIKE @filtro " +
                "ORDER BY j.id_jornada DESC";

            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion =
                       _conexionBD.ObtenerConexion())
                using (MySqlCommand comando =
                       new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@filtro",
                        filtro);

                    comando.CommandTimeout = 60;

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las jornadas: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        private DataTable EjecutarConsulta(string sql)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion =
                       _conexionBD.ObtenerConexion())
                using (MySqlCommand comando =
                       new MySqlCommand(sql, conexion))
                using (MySqlDataAdapter adaptador =
                       new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar la base de datos: " +
                    ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }



        public string Guardar_Jornada(
            int opcion,
            int idCampeonato,
            string nombreJornada,
            int numeroJornada,
            DateTime fechaJornada,
            int idJornada = 0)
        {


            if (idCampeonato <= 0)
            {
                return "Debe seleccionar un campeonato.";
            }

            if (string.IsNullOrWhiteSpace(nombreJornada))
            {
                return "Debe ingresar el nombre de la jornada.";
            }

            if (numeroJornada <= 0)
            {
                return "El número de jornada debe ser mayor que cero.";
            }

            if (opcion == 2 && idJornada <= 0)
            {
                return "No se ha seleccionado una jornada para editar.";
            }


            string sql;



            if (opcion == 1)
            {
                sql =
                    "INSERT INTO Jornada " +
                    "(nombre_jornada, numero_jornada, " +
                    "fecha_jornada, id_campeonato) " +
                    "VALUES " +
                    "(@nombre, @numero, @fecha, @campeonato)";
            }


            else if (opcion == 2)
            {
                sql =
                    "UPDATE Jornada SET " +
                    "nombre_jornada = @nombre, " +
                    "numero_jornada = @numero, " +
                    "fecha_jornada = @fecha, " +
                    "id_campeonato = @campeonato " +
                    "WHERE id_jornada = @id";
            }


            else
            {
                return "Operación no válida.";
            }


            try
            {
                using (MySqlConnection conexion =
                       _conexionBD.ObtenerConexion())
                using (MySqlCommand comando =
                       new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@nombre",
                        nombreJornada.Trim());

                    comando.Parameters.AddWithValue(
                        "@numero",
                        numeroJornada);

                    comando.Parameters.AddWithValue(
                        "@fecha",
                        fechaJornada.Date);

                    comando.Parameters.AddWithValue(
                        "@campeonato",
                        idCampeonato);


                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue(
                            "@id",
                            idJornada);
                    }


                    conexion.Open();

                    int filas =
                        comando.ExecuteNonQuery();


                    return filas > 0
                        ? "OK"
                        : "No se completó la operación.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar_Jornada(int idJornada)
        {
            const string sql =
                "DELETE FROM Jornada " +
                "WHERE id_jornada = @id";

            try
            {
                using (MySqlConnection conexion =
                       _conexionBD.ObtenerConexion())
                using (MySqlCommand comando =
                       new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        idJornada);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0
                        ? "OK"
                        : "No se encontró la jornada.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
