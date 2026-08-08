using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmLoginAdministrador : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public frmLoginAdministrador()
        {
            InitializeComponent();
        }


        // CARGA DEL FORMULARIO
 

        private void frmLoginAdministrador_Load(object sender, EventArgs e)
        {
            TxtUsuario.Focus();
        }

        // BOTÓN REGRESAR
        
        private void BtnRegrear_Click(object sender, EventArgs e)
        {
            frmLogin nuevoform = new frmLogin();

            nuevoform.Show();

            Hide();
        }

        // LABEL CONTRASEÑA
  
        private void LblContraseña_Click(object sender, EventArgs e)
        {

        }

        // ============================================================
        // BOTÓN INICIAR SESIÓN
        // ============================================================

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // ----------------------------------------------------
                // VALIDAR CAMPOS VACÍOS
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
                    // Verifica:
                    // 1. Usuario
                    // 2. Contraseña
                    // 3. Estado activo
                    // 4. Rol Administracion
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
                            AND r.nombre_rol = 'Administracion'
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
                            if (reader.Read())
                            {
                                // ------------------------------------
                                // LOGIN CORRECTO
                                // ------------------------------------

                                string nombreUsuario =
                                    reader["nombre_usuario"].ToString();

                                MessageBox.Show(
                                    "Bienvenido, " + nombreUsuario + ".",
                                    "Inicio de sesión exitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                // Abrir menú
                                frmMenú nuevoform = new frmMenú();

                                nuevoform.Show();

                                Hide();
                            }
                            else
                            {
                                // ------------------------------------
                                // LOGIN INCORRECTO
                                // ------------------------------------

                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos,\n" +
                                    "o el usuario no tiene permisos de Administración.",
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