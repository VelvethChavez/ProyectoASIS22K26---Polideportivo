using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class TipoCampeonato : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Guarda el ID del tipo de campeonato seleccionado
        private int idTipo = 0;

        public TipoCampeonato()
        {
            InitializeComponent();
        }

        /* cargar formulario */
        private void TipoCampeonato_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CargarDatos();
        }

        /* BOTON GUARDAR - REALIZADO POR VELVETH CHAVEZ */
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrWhiteSpace(NomTipoCampeonato.Text) || NomTipoCampeonato.Text == "Ingrese el tipo de campeonato")
            {
                MessageBox.Show("Por favor, ingrese el nombre del tipo de campeonato.",
                                "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"INSERT INTO Tipo_Campeonato
                                   (nombre_tipoCampeonato, descripcion)
                                   VALUES
                                   (@nombre, @descripcion)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", NomTipoCampeonato.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tipo de campeonato guardado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "SELECT * FROM Tipo_Campeonato";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* BOTON EDITAR VELVETH CHAVEZ */
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un registro previamente
            if (idTipo == 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de campeonato de la lista para editar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(NomTipoCampeonato.Text) || string.IsNullOrWhiteSpace(Descripcion.Text))
            {
                MessageBox.Show("Los campos de Nombre y Descripción no pueden estar vacíos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Sentencia SQL para actualizar los campos basándose en el ID del tipo de campeonato
                    string sql = @"UPDATE Tipo_Campeonato 
                           SET nombre_tipoCampeonato = @nombre, 
                               descripcion = @descripcion 
                           WHERE id_tipo = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", NomTipoCampeonato.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idTipo);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Tipo de campeonato actualizado correctamente.",
                                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarDatos(); // Recargar la tabla con la información actualizada
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Metodo para seleccionar el registro VELVETH CHAVEZ */
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Obtener datos por el nombre exacto de la columna en la BD
                idTipo = Convert.ToInt32(fila.Cells["id_tipo"].Value);
                NomTipoCampeonato.Text = fila.Cells["nombre_tipoCampeonato"].Value.ToString();
                Descripcion.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }


        /*BOTON DE ELIMINAR VELVETH CHAVEZ */
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idTipo == 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de campeonato de la lista para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el tipo de campeonato '{NomTipoCampeonato.Text}'?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                    {
                        conexion.Open();

                        string sql = "DELETE FROM Tipo_Campeonato WHERE id_tipo = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idTipo);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Tipo de campeonato eliminado correctamente.",
                                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimpiarCampos();
                                CargarDatos();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para eliminar.",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /* METODO PARA LIMPIAR CAMPOS */
        private void LimpiarCampos()
        {
            idTipo = 0;
            NomTipoCampeonato.Clear();
            Descripcion.Clear();
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        /* EVENTOS VACIOS */
        private void label4_Click(object sender, EventArgs e)
        {
            // Evento no utilizado
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento no utilizado
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /* BOTON DE ELIMINAR VELVETH CHAVEZ  */
        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {// 1. Validar que se haya seleccionado un registro de tipo de campeonato
            if (idTipo == 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de campeonato de la lista para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pedir confirmación al usuario
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el tipo de campeonato '{NomTipoCampeonato.Text}'?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                    {
                        conexion.Open();

                        // Sentencia SQL para eliminar por id_tipo
                        string sql = "DELETE FROM Tipo_Campeonato WHERE id_tipo = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idTipo);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Tipo de campeonato eliminado correctamente.",
                                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimpiarCampos();
                                CargarDatos(); // Recargar la lista en el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para eliminar.",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si el tipo de campeonato está referenciado en otra tabla (Llave Foránea FK), saltará esta excepción
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            // Limpia las cajas de texto y resetea el ID a 0
            LimpiarCampos();

            // Coloca el cursor directamente en el campo de texto del nombre
            NomTipoCampeonato.Focus();
        }
    }
}