using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using SistemaDePolideportivo.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo.DAO
{
    public class EmpleadoDAO
    {
        ConexionBD conexionBD = new ConexionBD();

        public bool InsertarEmpleado(Empleado empleado)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Empleado
                    (
                        nombres_empleado,
                        apellidos_empleado,
                        telefono,
                        correo,
                        puesto,
                        estado
                    )
                    VALUES
                    (
                        @nombres,
                        @apellidos,
                        @telefono,
                        @correo,
                        @puesto,
                        @estado
                    )";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombres", empleado.NombresEmpleado);
                        cmd.Parameters.AddWithValue("@apellidos", empleado.ApellidosEmpleado);
                        cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                        cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
                        cmd.Parameters.AddWithValue("@estado", empleado.Estado);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado.\n" + ex.Message);
                return false;
            }
        }

        public DataTable ListarEmpleados()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"SELECT
    id_empleado AS 'ID',
    nombres_empleado AS 'Nombres',
    apellidos_empleado AS 'Apellidos',
    telefono AS 'Teléfono',
    correo AS 'Correo',
    puesto AS 'Puesto',
    estado AS 'Estado'
FROM Empleado
WHERE estado = 1;";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados.\n" + ex.Message);
            }

            return tabla;
        }

        public bool ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"UPDATE Empleado
                                SET
                                    nombres_empleado=@nombres,
                                    apellidos_empleado=@apellidos,
                                    telefono=@telefono,
                                    correo=@correo,
                                    puesto=@puesto,
                                    estado=@estado
                                WHERE id_empleado=@id";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", empleado.IdEmpleado);
                        cmd.Parameters.AddWithValue("@nombres", empleado.NombresEmpleado);
                        cmd.Parameters.AddWithValue("@apellidos", empleado.ApellidosEmpleado);
                        cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                        cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
                        cmd.Parameters.AddWithValue("@estado", empleado.Estado);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EliminarEmpleado(int id)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"UPDATE Empleado
                                SET estado = false
                                WHERE id_empleado=@id";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable BuscarEmpleado(string nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"SELECT
                                    id_empleado AS 'ID',
                                    nombres_empleado AS 'Nombres',
                                    apellidos_empleado AS 'Apellidos',
                                    telefono AS 'Teléfono',
                                    correo AS 'Correo',
                                    puesto AS 'Puesto',
                                    estado AS 'Estado'
                                FROM Empleado
                                WHERE nombres_empleado LIKE @nombre";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tabla;
        }
    }
}