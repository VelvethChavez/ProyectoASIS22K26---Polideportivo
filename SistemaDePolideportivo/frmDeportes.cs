using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmDeportes : Form
    {
        CConexion conexionBD = new CConexion();

        // Guarda el ID del deporte seleccionado
        private int idDeporte = 0;

        public FrmDeportes()
        {
            InitializeComponent();
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void Deportes_Load(object sender, EventArgs e)
        {
            Dgv1.Enabled = true;
            Dgv1.ReadOnly = false;
            Dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv1.MultiSelect = false;

            CargarDatos();
        }

        //==========================
        // GUARDAR
        //==========================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campo Nombre del deporte
            if (string.IsNullOrWhiteSpace(TxtNombreDeporte.Text) || TxtNombreDeporte.Text == "Ingrese nombre del deporte")
            {
                MessageBox.Show("Debe completar el campo Nombre del deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombreDeporte.Focus();
                return;
            }

            // Validar campo Descripción
            if (string.IsNullOrWhiteSpace(RtbDescripcion.Text) || RtbDescripcion.Text == "Ingresa descripción")
            {
                MessageBox.Show("Debe completar el campo Descripción.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RtbDescripcion.Focus();
                return;
            }

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
                    cmd.Parameters.AddWithValue("@nombre", TxtNombreDeporte.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", RtbDescripcion.Text.Trim());
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

                    Dgv1.DataSource = dt;
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
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un registro previamente
            if (idDeporte == 0)
            {
                MessageBox.Show("Por favor, seleccione un deporte de la lista para editar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo Nombre del deporte
            if (string.IsNullOrWhiteSpace(TxtNombreDeporte.Text))
            {
                MessageBox.Show("Debe completar el campo Nombre del deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombreDeporte.Focus();
                return;
            }

            // Validar campo Descripción
            if (string.IsNullOrWhiteSpace(RtbDescripcion.Text))
            {
                MessageBox.Show("Debe completar el campo Descripción.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RtbDescripcion.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string sql = @"UPDATE Deporte 
                SET nombre_deporte = @nombre, 
                    descripcion = @descripcion 
                WHERE id_deporte = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", TxtNombreDeporte.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", RtbDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idDeporte);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Deporte actualizado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarDatos();
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
        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv1.Rows[e.RowIndex];

                // Obtener datos por el nombre exacto de la columna en la BD
                idDeporte = Convert.ToInt32(fila.Cells["id_deporte"].Value);
                TxtNombreDeporte.Text = fila.Cells["nombre_deporte"].Value.ToString();
                RtbDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        //==========================
        // NUEVO
        //==========================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            TxtNombreDeporte.Focus();
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

            TxtNombreDeporte.Clear();

            RtbDescripcion.Clear();

            Dgv1.ClearSelection();
        }

        //==========================
        // EVENTOS VACÍOS
        //==========================
        private void Lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl4_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl5_Click(object sender, EventArgs e)
        {

        }

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el deporte '{TxtNombreDeporte.Text}'?",
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
                new FrmMenu().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dirige al formulario de Tipo de Campeonato
            FrmTipoCampeonato nuevoForm = new FrmTipoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            // Limpia las cajas de texto y resetea el ID a 0
            LimpiarCampos();

            // Coloca el cursor directamente en el campo de texto del nombre
            TxtNombreDeporte.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEstadoCampeonato nuevoForm = new FrmEstadoCampeonato();

            // 2. Muestras el nuevo formulario
            nuevoForm.Show();

            // 3. (Opcional) Ocultas el formulario actual para que no se queden ventanas acumuladas
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCampeonato nuevoForm = new FrmCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmCampeonato nuevoForm = new FrmCampeonato();
            nuevoForm.Show();
            Hide();
        }
    }
}