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
    public partial class FrmCampeonato : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Guarda el ID del campeonato seleccionado
        private int idCampeonato = 0;

        public FrmCampeonato()
        {
            InitializeComponent();

            // El Dgv1 no tiene el evento CellClick enlazado en el diseñador,
            // así que lo conectamos aquí.
            Dgv1.CellClick += Dgv1_CellClick;
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
        }

        private void Lbl4_Click(object sender, EventArgs e)
        {
        }

        private void Lbl5_Click(object sender, EventArgs e)
        {
        }

        private void Lbl7_Click(object sender, EventArgs e)
        {
        }

        private void Lbl8_Click(object sender, EventArgs e)
        {
        }

        private void DtpDateInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void CmbComboBoxtipoCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void FrmCampeonato_Load(object sender, EventArgs e)
        {
            Dgv1.Enabled = true;
            Dgv1.ReadOnly = true;
            Dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv1.MultiSelect = false;

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
                    CmbComboBoxDeporte.DataSource = dtDeporte;
                    CmbComboBoxDeporte.DisplayMember = "nombre_deporte";
                    CmbComboBoxDeporte.ValueMember = "id_deporte";
                    CmbComboBoxDeporte.SelectedIndex = -1;

                    // Tipos de campeonato
                    MySqlDataAdapter daTipo = new MySqlDataAdapter(
                        "SELECT id_tipo, nombre_tipoCampeonato FROM Tipo_Campeonato", conexion);
                    DataTable dtTipo = new DataTable();
                    daTipo.Fill(dtTipo);
                    CmbComboBoxtipoCampeonato.DataSource = dtTipo;
                    CmbComboBoxtipoCampeonato.DisplayMember = "nombre_tipoCampeonato";
                    CmbComboBoxtipoCampeonato.ValueMember = "id_tipo";
                    CmbComboBoxtipoCampeonato.SelectedIndex = -1;

                    // Estados de campeonato
                    MySqlDataAdapter daEstado = new MySqlDataAdapter(
                        "SELECT id_estado_campeonato, nombre_estado FROM Estado_Campeonato", conexion);
                    DataTable dtEstado = new DataTable();
                    daEstado.Fill(dtEstado);
                    Cmb2.DataSource = dtEstado;
                    Cmb2.DisplayMember = "nombre_estado";
                    Cmb2.ValueMember = "id_estado_campeonato";
                    Cmb2.SelectedIndex = -1;
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
            if (string.IsNullOrWhiteSpace(Txt1.Text) || Txt1.Text == "Ingrese nombre del campeonato")
            {
                MessageBox.Show("Debe completar el campo Nombre del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt1.Focus();
                return;
            }

            if (CmbComboBoxDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbComboBoxDeporte.Focus();
                return;
            }

            if (CmbComboBoxtipoCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbComboBoxtipoCampeonato.Focus();
                return;
            }

            if (Cmb2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb2.Focus();
                return;
            }

            if (Dtp1.Value.Date < DtpDateInicio.Value.Date)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.",
                    "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dtp1.Focus();
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
                        cmd.Parameters.AddWithValue("@nombre", Txt1.Text.Trim());
                        cmd.Parameters.AddWithValue("@fechaInicio", DtpDateInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@fechaFin", Dtp1.Value.Date);
                        cmd.Parameters.AddWithValue("@idDeporte", CmbComboBoxDeporte.SelectedValue);
                        cmd.Parameters.AddWithValue("@idTipo", CmbComboBoxtipoCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@idEstado", Cmb2.SelectedValue);
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
                    Dgv1.DataSource = dt;
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
        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv1.Rows[e.RowIndex];

                idCampeonato = Convert.ToInt32(fila.Cells["id_campeonato"].Value);
                Txt1.Text = fila.Cells["nombre_campeonato"].Value.ToString();
                DtpDateInicio.Value = Convert.ToDateTime(fila.Cells["fecha_inicio"].Value);
                Dtp1.Value = Convert.ToDateTime(fila.Cells["fecha_fin"].Value);
                CmbComboBoxDeporte.SelectedValue = Convert.ToInt32(fila.Cells["id_deporte"].Value);
                CmbComboBoxtipoCampeonato.SelectedValue = Convert.ToInt32(fila.Cells["id_tipo"].Value);
                Cmb2.SelectedValue = Convert.ToInt32(fila.Cells["id_estado_campeonato"].Value);
            }
        }

        //==========================
        // NUEVO
        //==========================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Txt1.Focus();
        }

        //==========================
        // EDITAR
        //==========================
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idCampeonato == 0)
            {
                MessageBox.Show("Por favor, seleccione un campeonato de la lista para editar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt1.Text))
            {
                MessageBox.Show("Debe completar el campo Nombre del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt1.Focus();
                return;
            }

            if (CmbComboBoxDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un deporte.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbComboBoxDeporte.Focus();
                return;
            }

            if (CmbComboBoxtipoCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbComboBoxtipoCampeonato.Focus();
                return;
            }

            if (Cmb2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado del campeonato.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb2.Focus();
                return;
            }

            if (Dtp1.Value.Date < DtpDateInicio.Value.Date)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.",
                    "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dtp1.Focus();
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
                        cmd.Parameters.AddWithValue("@nombre", Txt1.Text.Trim());
                        cmd.Parameters.AddWithValue("@fechaInicio", DtpDateInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@fechaFin", Dtp1.Value.Date);
                        cmd.Parameters.AddWithValue("@idDeporte", CmbComboBoxDeporte.SelectedValue);
                        cmd.Parameters.AddWithValue("@idTipo", CmbComboBoxtipoCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@idEstado", Cmb2.SelectedValue);
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
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idCampeonato == 0)
            {
                MessageBox.Show("Por favor, seleccione un campeonato de la lista para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el campeonato '{Txt1.Text}'?",
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
            Txt1.Clear();
            DtpDateInicio.Value = DateTime.Today;
            Dtp1.Value = DateTime.Today;
            CmbComboBoxDeporte.SelectedIndex = -1;
            CmbComboBoxtipoCampeonato.SelectedIndex = -1;
            Cmb2.SelectedIndex = -1;

            if (Dgv1.DataSource != null)
            {
                Dgv1.ClearSelection();
            }
        }

        //==========================
        // NAVEGACIÓN A OTROS FORMULARIOS
        //==========================
        private void BtnDeportes_Click(object sender, EventArgs e)
        {
            FrmDeportes nuevoForm = new FrmDeportes();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            FrmEstadoCampeonato nuevoForm = new FrmEstadoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnTipoCampeonato_Click(object sender, EventArgs e)
        {
            FrmTipoCampeonato nuevoForm = new FrmTipoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void Pnl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu newform = new FrmMenu();
            newform.Show();
            this.Hide();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}