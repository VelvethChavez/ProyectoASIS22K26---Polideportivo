using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmlogingerente : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public frmlogingerente()
        {
            InitializeComponent();
        }

        // ============================================================
        // CARGA DEL FORMULARIO
        // ============================================================

        private void frmlogingerente_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
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

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show(
                        "Ingrese su nombre de usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    textBox1.Focus();
                    return;
                }

                // ----------------------------------------------------
                // VALIDAR CONTRASEÑA
                // ----------------------------------------------------

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show(
                        "Ingrese su contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    textBox2.Focus();
                    return;
                }

                // ----------------------------------------------------
                // CONEXIÓN A LA BASE DE DATOS
                // ----------------------------------------------------

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

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
                            AND r.nombre_rol = 'Gerente'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            textBox1.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@contrasena",
                            textBox2.Text
                        );

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
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

                                // Abrir Reportes
                                Reportes nuevoform = new Reportes();

                                nuevoform.Show();

                                Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos,\n" +
                                    "o el usuario no tiene permisos de Gerente.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                textBox2.Clear();
                                textBox2.Focus();
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

        // ============================================================
        // BOTÓN REGRESAR
        // ============================================================

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin nuevoform = new frmLogin();

            nuevoform.Show();

            Hide();
        }
    }
}