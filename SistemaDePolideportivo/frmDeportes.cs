using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmDeportes : Form
    {
        CConexion conexionBD = new CConexion();

        // Guarda el ID del deporte seleccionado
        private int idDeporte = 0;

        public frmDeportes()
        {
            InitializeComponent();
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void Deportes_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CargarDatos();
        }



        //==========================
        // GUARDAR
        //==========================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = @"INSERT INTO Deporte
                                   (nombre_deporte, descripcion)
                                   VALUES
                                   (@nombre,@descripcion)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@nombre", NombreDeporte.Text);
                    cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deporte guardado correctamente.");

                    LimpiarCampos();

                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //==========================
        // CARGAR DATOS
        //==========================
        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "SELECT * FROM Deporte";

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


        //==========================
        // EDITAR
        //==========================
        //==========================
        // EDITAR
        //==========================
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un registro previamente
            if (idDeporte == 0)
            {
                MessageBox.Show("Por favor, seleccione un deporte de la lista para editar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(NombreDeporte.Text) || string.IsNullOrWhiteSpace(Descripcion.Text))
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

                    // Sentencia SQL para actualizar los campos basándose en el ID del deporte
                    string sql = @"UPDATE Deporte 
                           SET nombre_deporte = @nombre, 
                               descripcion = @descripcion 
                           WHERE id_deporte = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", NombreDeporte.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idDeporte);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Deporte actualizado correctamente.",
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

        //==========================
        // SELECCIONAR REGISTRO
        //==========================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Obtener datos por el nombre exacto de la columna en la BD
                idDeporte = Convert.ToInt32(fila.Cells["id_deporte"].Value);
                NombreDeporte.Text = fila.Cells["nombre_deporte"].Value.ToString();
                Descripcion.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }


        //==========================
        // NUEVO
        //==========================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            NombreDeporte.Focus();
        }



        //==========================
        // LIMPIAR
        //==========================
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



        //==========================
        // MÉTODO LIMPIAR CAMPOS
        //==========================
        private void LimpiarCampos()
        {
            idDeporte = 0;

            NombreDeporte.Clear();

            Descripcion.Clear();

            dataGridView1.ClearSelection();
        }



        //==========================
        // EVENTOS VACÍOS
        //==========================

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //==========================
        // ELIMINAR
        //==========================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un registro
            if (idDeporte == 0)
            {
                MessageBox.Show("Por favor, seleccione un deporte de la lista para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pedir confirmación al usuario
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el deporte '{NombreDeporte.Text}'?",
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

                        string sql = "DELETE FROM Deporte WHERE id_deporte = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idDeporte);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Deporte eliminado correctamente.",
                                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimpiarCampos();
                                CargarDatos(); // Recargar la lista
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
                    // Nota: Si el deporte está vinculado como Llave Foránea (FK) en otra tabla 
                    // (ej. Torneos o Equipos), MySQL lanzará una excepción aquí.
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Deportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
            else
            {
                new frmMenú().Show();
            }
        }
    }
}