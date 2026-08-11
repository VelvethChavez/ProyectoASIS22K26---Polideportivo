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
    internal class CCampo
    {
        private readonly ConexionBD _conexionBD = new ConexionBD();

        // ============================================================
        // LISTADO DE CAMPOS
        // ============================================================
        public DataTable Listado_Campos(string filtro)
        {
            const string sql =
                "SELECT c.id_campo, " +
                "c.nombre_campo, " +
                "c.ubicacion_campo, " +
                "c.capacidad, " +
                "tc.id_tipo_campo, " +
                "tc.nombre_tipo " +
                "FROM Campo c " +
                "INNER JOIN Tipo_Campo tc " +
                "ON c.id_tipo_campo = tc.id_tipo_campo " +
                "WHERE c.nombre_campo LIKE @filtro " +
                "OR c.ubicacion_campo LIKE @filtro " +
                "OR tc.nombre_tipo LIKE @filtro " +
                "ORDER BY c.id_campo DESC";

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
                    "Error al cargar los campos: " + ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // LISTADO DE TIPOS DE CAMPO PARA EL COMBOBOX
        // ============================================================
        public DataTable Listado_TiposCampo()
        {
            const string sql =
                "SELECT id_tipo_campo, nombre_tipo " +
                "FROM Tipo_Campo " +
                "ORDER BY id_tipo_campo";

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
                    "Error al cargar los tipos de campo: " + ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tabla;
        }


        // ============================================================
        // GUARDAR CAMPO
        // ============================================================
        public string Guardar_Campo(
            int opcion,
            string nombreCampo,
            string ubicacion,
            int capacidad,
            int idTipoCampo,
            int idCampo = 0)
        {
            string sql;

            // --------------------------------------------------------
            // INSERTAR
            // --------------------------------------------------------
            if (opcion == 1)
            {
                sql =
                    "INSERT INTO Campo " +
                    "(nombre_campo, ubicacion_campo, capacidad, id_tipo_campo) " +
                    "VALUES " +
                    "(@nombre, @ubicacion, @capacidad, @idTipo)";
            }

            // --------------------------------------------------------
            // ACTUALIZAR
            // --------------------------------------------------------
            else if (opcion == 2)
            {
                sql =
                    "UPDATE Campo SET " +
                    "nombre_campo = @nombre, " +
                    "ubicacion_campo = @ubicacion, " +
                    "capacidad = @capacidad, " +
                    "id_tipo_campo = @idTipo " +
                    "WHERE id_campo = @id";
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
                    comando.Parameters.AddWithValue(
                        "@nombre",
                        nombreCampo);

                    comando.Parameters.AddWithValue(
                        "@ubicacion",
                        ubicacion);

                    comando.Parameters.AddWithValue(
                        "@capacidad",
                        capacidad);

                    comando.Parameters.AddWithValue(
                        "@idTipo",
                        idTipoCampo);

                    if (opcion == 2)
                    {
                        comando.Parameters.AddWithValue(
                            "@id",
                            idCampo);
                    }

                    conexion.Open();

                    int filas =
                        comando.ExecuteNonQuery();

                    return filas > 0
                        ? "OK"
                        : "No se pudo completar la operación.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // ============================================================
        // ELIMINAR CAMPO
        // ============================================================
        public string Eliminar_Campo(int idCampo)
        {
            const string sql =
                "DELETE FROM Campo " +
                "WHERE id_campo = @id";

            try
            {
                using (var conexion = _conexionBD.ObtenerConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        idCampo);

                    conexion.Open();

                    int filas =
                        comando.ExecuteNonQuery();

                    return filas > 0
                        ? "OK"
                        : "No se pudo eliminar el registro.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}