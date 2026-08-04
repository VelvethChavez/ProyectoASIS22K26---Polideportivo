using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmEstadoCampeonato : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Guarda el ID del estado de campeonato seleccionado
        private int idEstado = 0;

        public frmEstadoCampeonato()
        {
            InitializeComponent();

            // Estos botones no tienen el evento conectado en el diseñador,
            // así que los conectamos aquí para no tener que tocar el archivo Designer.
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void frmEstadoCampeonato_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            CargarDatos();
        }

        //==========================
        // GUARDAR
        //==========================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campo Nombre del estado
            if (string.IsNullOrWhiteSpace(NombreEstadoCampeonato.Text) || NombreEstadoCampeonato.Text == "Ingrese nombre del estado")
            {
                MessageBox.Show("Debe completar el campo Nombre del estado.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NombreEstadoCampeonato.Focus();
                return;
            }

            // Validar campo Descripción
            if (string.IsNullOrWhiteSpace(Descripcion.Text) || Descripcion.Text == "Ingresa descripción")
            {
                MessageBox.Show("Debe completar el campo Descripción.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Descripcion.Focus();
                return;
            }

            try
            {
                using MySqlConnection conexion = conexionBD.ObtenerConexion();
                conexion.Open();
                string sql = @"INSERT INTO Estado_Campeonato
                    (nombre_estado, descripcion)
                    VALUES
                    (@nombre, @descripcion)";
                using MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", NombreEstadoCampeonato.Text.Trim());
                cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Estado de campeonato guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // CARGAR DATOS
        //==========================
        private void CargarDatos()
        {
            try
            {
                using MySqlConnection conexion = conexionBD.ObtenerConexion();
                conexion.Open();
                string sql = "SELECT * FROM Estado_Campeonato";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
            if (idEstado == 0)
            {
                MessageBox.Show("Por favor, seleccione un estado de la lista para editar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(NombreEstadoCampeonato.Text))
            {
                MessageBox.Show("Debe completar el campo Nombre del estado.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NombreEstadoCampeonato.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Descripcion.Text))
            {
                MessageBox.Show("Debe completar el campo Descripción.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Descripcion.Focus();
                return;
            }

            try
            {
                using MySqlConnection conexion = conexionBD.ObtenerConexion();
                conexion.Open();
                string sql = @"UPDATE Estado_Campeonato 
                    SET nombre_estado = @nombre, 
                        descripcion = @descripcion 
                    WHERE id_estado_campeonato = @id";
                using MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", NombreEstadoCampeonato.Text.Trim());
                cmd.Parameters.AddWithValue("@descripcion", Descripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idEstado);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Estado de campeonato actualizado correctamente.",
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // ELIMINAR
        //==========================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idEstado == 0)
            {
                MessageBox.Show("Por favor, seleccione un estado de la lista para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el estado '{NombreEstadoCampeonato.Text}'?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using MySqlConnection conexion = conexionBD.ObtenerConexion();
                    conexion.Open();
                    string sql = "DELETE FROM Estado_Campeonato WHERE id_estado_campeonato = @id";
                    using MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", idEstado);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Estado de campeonato eliminado correctamente.",
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //==========================
        // NUEVO
        //==========================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            NombreEstadoCampeonato.Focus();
        }

        //==========================
        // SELECCIONAR REGISTRO
        //==========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idEstado = Convert.ToInt32(fila.Cells["id_estado_campeonato"].Value);
                NombreEstadoCampeonato.Text = fila.Cells["nombre_estado"].Value.ToString();
                Descripcion.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        //==========================
        // LIMPIAR CAMPOS
        //==========================
        private void LimpiarCampos()
        {
            idEstado = 0;
            NombreEstadoCampeonato.Clear();
            Descripcion.Clear();
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmCampeonato nuevoForm = new frmCampeonato();  
            nuevoForm.Show();
            this.Hide();

        }
    }
}