using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmCampeonato : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Guarda el ID del campeonato seleccionado
        private int idCampeonato = 0;

        public frmCampeonato()
        {
            InitializeComponent();

            // El dataGridView1 no tiene el evento CellClick enlazado en el diseñador,
            // así que lo conectamos aquí.
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void frmCampeonato_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CargarComboBoxes();
            CargarDatos();
        }

        //==========================
        // CARGAR DEPORTES, TIPOS Y ESTADOS EN LOS COMBOS
        //==========================
        private void CargarComboBoxes()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Deportes
                    MySqlDataAdapter daDeporte = new MySqlDataAdapter(
                        "SELECT id_deporte, nombre_deporte FROM Deporte", conexion);
                    DataTable dtDeporte = new DataTable();
                    daDeporte.Fill(dtDeporte);
                    ComboBoxDeporte.DataSource = dtDeporte;
                    ComboBoxDeporte.DisplayMember = "nombre_deporte";
                    ComboBoxDeporte.ValueMember = "id_deporte";
                    ComboBoxDeporte.SelectedIndex = -1;

                    // Tipos de campeonato
                    MySqlDataAdapter daTipo = new MySqlDataAdapter(
                        "SELECT id_tipo, nombre_tipoCampeonato FROM Tipo_Campeonato", conexion);
                    DataTable dtTipo = new DataTable();
                    daTipo.Fill(dtTipo);
                    comboBoxtipoCampeonato.DataSource = dtTipo;
                    comboBoxtipoCampeonato.DisplayMember = "nombre_tipoCampeonato";
                    comboBoxtipoCampeonato.ValueMember = "id_tipo";
                    comboBoxtipoCampeonato.SelectedIndex = -1;

                    // Estados de campeonato
                    MySqlDataAdapter daEstado = new MySqlDataAdapter(
                        "SELECT id_estado_campeonato, nombre_estado FROM Estado_Campeonato", conexion);
                    DataTable dtEstado = new DataTable();
                    daEstado.Fill(dtEstado);
                    comboBox2.DataSource = dtEstado;
                    comboBox2.DisplayMember = "nombre_estado";
                    comboBox2.ValueMember = "id_estado_campeonato";
                    comboBox2.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // GUARDAR
        //==========================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Ingrese nombre del campeonato")
            {
                MessageBox.Show("Debe completar el campo Nombre del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (ComboBoxDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBoxDeporte.Focus();
                return;
            }

            if (comboBoxtipoCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxtipoCampeonato.Focus();
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Focus();
                return;
            }

            if (dateTimePicker1.Value.Date < dateInicio.Value.Date)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.",
                    "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Campeonato
                        (nombre_campeonato, fecha_inicio, fecha_fin, id_deporte, id_tipo, id_estado_campeonato)
                        VALUES
                        (@nombre, @fechaInicio, @fechaFin, @idDeporte, @idTipo, @idEstado)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@fechaInicio", dateInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@fechaFin", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@idDeporte", ComboBoxDeporte.SelectedValue);
                        cmd.Parameters.AddWithValue("@idTipo", comboBoxtipoCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@idEstado", comboBox2.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Campeonato guardado correctamente.",
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

        //==========================
        // CARGAR DATOS EN EL DATAGRIDVIEW
        //==========================
        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string sql = @"SELECT c.id_campeonato, c.nombre_campeonato, c.fecha_inicio, c.fecha_fin,
                               c.id_deporte, d.nombre_deporte,
                               c.id_tipo, t.nombre_tipoCampeonato,
                               c.id_estado_campeonato, e.nombre_estado
                        FROM Campeonato c
                        INNER JOIN Deporte d ON c.id_deporte = d.id_deporte
                        INNER JOIN Tipo_Campeonato t ON c.id_tipo = t.id_tipo
                        INNER JOIN Estado_Campeonato e ON c.id_estado_campeonato = e.id_estado_campeonato";

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
        // SELECCIONAR REGISTRO
        //==========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idCampeonato = Convert.ToInt32(fila.Cells["id_campeonato"].Value);
                textBox1.Text = fila.Cells["nombre_campeonato"].Value.ToString();
                dateInicio.Value = Convert.ToDateTime(fila.Cells["fecha_inicio"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(fila.Cells["fecha_fin"].Value);
                ComboBoxDeporte.SelectedValue = Convert.ToInt32(fila.Cells["id_deporte"].Value);
                comboBoxtipoCampeonato.SelectedValue = Convert.ToInt32(fila.Cells["id_tipo"].Value);
                comboBox2.SelectedValue = Convert.ToInt32(fila.Cells["id_estado_campeonato"].Value);
            }
        }

        //==========================
        // NUEVO
        //==========================
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            textBox1.Focus();
        }

        //==========================
        // EDITAR
        //==========================
        private void button2_Click(object sender, EventArgs e)
        {
            if (idCampeonato == 0)
            {
                MessageBox.Show("Por favor, seleccione un campeonato de la lista para editar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Debe completar el campo Nombre del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (ComboBoxDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBoxDeporte.Focus();
                return;
            }

            if (comboBoxtipoCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxtipoCampeonato.Focus();
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Focus();
                return;
            }

            if (dateTimePicker1.Value.Date < dateInicio.Value.Date)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.",
                    "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string sql = @"UPDATE Campeonato
                        SET nombre_campeonato = @nombre,
                            fecha_inicio = @fechaInicio,
                            fecha_fin = @fechaFin,
                            id_deporte = @idDeporte,
                            id_tipo = @idTipo,
                            id_estado_campeonato = @idEstado
                        WHERE id_campeonato = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@fechaInicio", dateInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@fechaFin", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@idDeporte", ComboBoxDeporte.SelectedValue);
                        cmd.Parameters.AddWithValue("@idTipo", comboBoxtipoCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@idEstado", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@id", idCampeonato);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Campeonato actualizado correctamente.",
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
        // ELIMINAR
        //==========================
        private void button3_Click(object sender, EventArgs e)
        {
            if (idCampeonato == 0)
            {
                MessageBox.Show("Por favor, seleccione un campeonato de la lista para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el campeonato '{textBox1.Text}'?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                    {
                        conexion.Open();
                        string sql = "DELETE FROM Campeonato WHERE id_campeonato = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idCampeonato);
                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Campeonato eliminado correctamente.",
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

        //==========================
        // LIMPIAR CAMPOS
        //==========================
        private void LimpiarCampos()
        {
            idCampeonato = 0;
            textBox1.Clear();
            dateInicio.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            ComboBoxDeporte.SelectedIndex = -1;
            comboBoxtipoCampeonato.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        //==========================
        // NAVEGACIÓN A OTROS FORMULARIOS
        //==========================
        private void BtnDeportes_Click(object sender, EventArgs e)
        {
            frmDeportes nuevoForm = new frmDeportes();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            frmEstadoCampeonato nuevoForm = new frmEstadoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnTipoCampeonato_Click(object sender, EventArgs e)
        {
            TipoCampeonato nuevoForm = new TipoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmMenú newform = new frmMenú();
            newform.Show();
            this.Hide();
        }
    }
}