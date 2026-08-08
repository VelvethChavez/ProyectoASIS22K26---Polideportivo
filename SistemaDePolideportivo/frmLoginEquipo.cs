using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmLoginEquipo : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public frmLoginEquipo()
        {
            InitializeComponent();
        }

        // ============================================================
        // CARGA DEL FORMULARIO
        // ============================================================

        private void frmLoginEquipo_Load(object sender, EventArgs e)
        {
            TxtUsuario.Focus();
        }

        // ============================================================
        // BOTÓN REGRESAR
        // ============================================================

        private void BtnRegresarLogin_Click(object sender, EventArgs e)
        {
            frmLogin nuevoform = new frmLogin();

            nuevoform.Show();

            Hide();
        }

        // ============================================================
        // BOTÓN INICIAR SESIÓN
        // ============================================================

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ----------------------------------------------------
                // VALIDAR USUARIO
                // ----------------------------------------------------

                if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
                {
                    MessageBox.Show(
                        "Ingrese su nombre de usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    TxtUsuario.Focus();
                    return;
                }

                // ----------------------------------------------------
                // VALIDAR CONTRASEÑA
                // ----------------------------------------------------

                if (string.IsNullOrWhiteSpace(TxtContraseña.Text))
                {
                    MessageBox.Show(
                        "Ingrese su contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    TxtContraseña.Focus();
                    return;
                }

                // ----------------------------------------------------
                // CONEXIÓN A LA BASE DE DATOS
                // ----------------------------------------------------

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // ------------------------------------------------
                    // CONSULTA
                    // ------------------------------------------------
                    // Verificamos:
                    // 1. Usuario
                    // 2. Contraseña
                    // 3. Estado activo
                    // 4. Rol Equipo
                    // ------------------------------------------------

                    string sql = @"
                        SELECT
                            u.id_usuario,
                            u.nombre_usuario,
                            r.nombre_rol
                        FROM Usuario u
                        INNER JOIN Rol r
                            ON u.id_rol = r.id_rol
                        WHERE
                            u.nombre_usuario = @usuario
                            AND u.contrasena = @contrasena
                            AND u.estado = TRUE
                            AND r.nombre_rol = 'Equipo'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            TxtUsuario.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@contrasena",
                            TxtContraseña.Text
                        );

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // ------------------------------------------------
                            // LOGIN CORRECTO
                            // ------------------------------------------------

                            if (reader.Read())
                            {
                                string nombreUsuario =
                                    reader["nombre_usuario"].ToString();

                                MessageBox.Show(
                                    "Bienvenido, " + nombreUsuario + ".",
                                    "Inicio de sesión exitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                // ------------------------------------------------
                                // ABRIR FORMULARIO DE REPORTES
                                // ------------------------------------------------

                                Reportes nuevoform = new Reportes();

                                nuevoform.Show();

                                Hide();
                            }
                            else
                            {
                                // ------------------------------------------------
                                // LOGIN INCORRECTO
                                // ------------------------------------------------

                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos,\n" +
                                    "o el usuario no tiene permisos de Equipo.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                TxtContraseña.Clear();
                                TxtContraseña.Focus();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error de conexión con la base de datos:\n\n" +
                    ex.Message,
                    "Error de MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}