using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmLoginArbitro : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public FrmLoginArbitro()
        {
            InitializeComponent();
        }

        private void FrmLoginArbitro_Load(object sender, EventArgs e)
        {
            Txt1.Focus();
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            FrmLogin nuevoform = new FrmLogin();

            nuevoform.Show();

            Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt1.Text))
                {
                    MessageBox.Show(
                        "Ingrese su nombre de usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Txt1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txt2.Text))
                {
                    MessageBox.Show(
                        "Ingrese su contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Txt2.Focus();
                    return;
                }

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
                            AND r.nombre_rol = 'Arbitro'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            Txt1.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@contrasena",
                            Txt2.Text
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

                                FrmRegistrarResultado nuevoform =
                                    new FrmRegistrarResultado();

                                nuevoform.Show();

                                Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos,\n" +
                                    "o el usuario no tiene permisos de Árbitro.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                Txt2.Clear();
                                Txt2.Focus();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error de MySQL:\n\n" + ex.Message,
                    "Error de MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}