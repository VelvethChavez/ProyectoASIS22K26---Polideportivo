using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo;
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
    public partial class frmProgramarPartido : Form
    {
        // ============================================================
        // OBJETO DE LA CLASE CPartido
        // ============================================================
        private readonly CPartido partido = new CPartido();

        // ID del partido seleccionado
        private int idPartido = 0;


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public frmProgramarPartido()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }


       


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarGrid()
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.AllowUserToAddRows = false;
        }


        // ============================================================
        // CARGAR COMBOBOX
        // ============================================================
        private void CargarComboBoxes()
        {
            try
            {
                // ----------------------------------------------------
                // JORNADA
                // ----------------------------------------------------
                DataTable jornadas = partido.Listado_Jornadas();

                comboBoxJornada.DataSource = jornadas;
                comboBoxJornada.DisplayMember = "nombre_jornada";
                comboBoxJornada.ValueMember = "id_jornada";
                comboBoxJornada.SelectedIndex = -1;


                // ----------------------------------------------------
                // EQUIPOS
                // ----------------------------------------------------
                DataTable equipos = partido.Listado_Equipos();

                comboBoxEquipoLocal.DataSource = equipos.Copy();
                comboBoxEquipoLocal.DisplayMember = "nombre_equipo";
                comboBoxEquipoLocal.ValueMember = "id_equipo";
                comboBoxEquipoLocal.SelectedIndex = -1;

                comboBoxEquipoVisitante.DataSource = equipos;
                comboBoxEquipoVisitante.DisplayMember = "nombre_equipo";
                comboBoxEquipoVisitante.ValueMember = "id_equipo";
                comboBoxEquipoVisitante.SelectedIndex = -1;


                // ----------------------------------------------------
                // CAMPOS
                // ----------------------------------------------------
                DataTable campos = partido.Listado_Campos();

                comboBoxCampo.DataSource = campos;
                comboBoxCampo.DisplayMember = "nombre_campo";
                comboBoxCampo.ValueMember = "id_campo";
                comboBoxCampo.SelectedIndex = -1;


                // ----------------------------------------------------
                // ÁRBITROS
                // ----------------------------------------------------
                DataTable arbitros = partido.Listado_Arbitros();

                comboBoxArbitro.DataSource = arbitros;
                comboBoxArbitro.DisplayMember = "nombre_arbitro";
                comboBoxArbitro.ValueMember = "id_arbitro";
                comboBoxArbitro.SelectedIndex = -1;


                // ----------------------------------------------------
                // ESTADOS
                // ----------------------------------------------------
                DataTable estados = partido.Listado_Estados();

                comboBoxEstado.DataSource = estados;
                comboBoxEstado.DisplayMember = "nombre_estado";
                comboBoxEstado.ValueMember = "id_estado_partido";
                comboBoxEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los ComboBox: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // CARGAR PARTIDOS
        // ============================================================
        private void CargarDatos()
        {
            try
            {
                dataGridView1.DataSource =
                    partido.Listado_Partidos("");
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los partidos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        // ============================================================
        // VALIDAR CAMPOS
        // ============================================================
        private bool ValidarCampos()
        {
            if (comboBoxJornada.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una jornada.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxJornada.Focus();
                return false;
            }


            if (comboBoxEquipoLocal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el equipo local.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxEquipoLocal.Focus();
                return false;
            }


            if (comboBoxEquipoVisitante.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el equipo visitante.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxEquipoVisitante.Focus();
                return false;
            }


            if (Convert.ToInt32(comboBoxEquipoLocal.SelectedValue) ==
                Convert.ToInt32(comboBoxEquipoVisitante.SelectedValue))
            {
                MessageBox.Show(
                    "El equipo local y visitante no pueden ser el mismo.",
                    "Equipos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            if (comboBoxCampo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un campo.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxCampo.Focus();
                return false;
            }


            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un estado.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxEstado.Focus();
                return false;
            }


            return true;
        }


        // ============================================================
        // SELECCIONAR PARTIDO DEL GRID
        // ============================================================
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow fila =
                dataGridView1.Rows[e.RowIndex];


            idPartido =
                Convert.ToInt32(
                    fila.Cells["id_partido"].Value);


            // Fecha
            dateTimePickerFecha.Value =
                Convert.ToDateTime(
                    fila.Cells["fecha_partido"].Value);


            // Hora
            TimeSpan hora =
                (TimeSpan)fila.Cells["hora_partido"].Value;

            dateTimePickerHora.Value =
                DateTime.Today.Add(hora);


            // Jornada
            comboBoxJornada.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_jornada"].Value);


            // Equipo local
            comboBoxEquipoLocal.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_equipo_local"].Value);


            // Equipo visitante
            comboBoxEquipoVisitante.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_equipo_visitante"].Value);


            // Campo
            comboBoxCampo.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_campo"].Value);


            // Árbitro
            if (fila.Cells["id_arbitro"].Value != DBNull.Value)
            {
                comboBoxArbitro.SelectedValue =
                    Convert.ToInt32(
                        fila.Cells["id_arbitro"].Value);
            }
            else
            {
                comboBoxArbitro.SelectedIndex = -1;
            }


            // Estado
            comboBoxEstado.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_estado_partido"].Value);
        }




        // ============================================================
        // LIMPIAR
        // ============================================================
        private void LimpiarCampos()
        {
            idPartido = 0;


            comboBoxJornada.SelectedIndex = -1;
            comboBoxEquipoLocal.SelectedIndex = -1;
            comboBoxEquipoVisitante.SelectedIndex = -1;
            comboBoxCampo.SelectedIndex = -1;
            comboBoxArbitro.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;


            dateTimePickerFecha.Value =
                DateTime.Today;

            dateTimePickerHora.Value =
                DateTime.Now;


            if (dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection();
            }
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;


            int idJornada =
                Convert.ToInt32(comboBoxJornada.SelectedValue);

            int idLocal =
                Convert.ToInt32(comboBoxEquipoLocal.SelectedValue);

            int idVisitante =
                Convert.ToInt32(comboBoxEquipoVisitante.SelectedValue);

            int idCampo =
                Convert.ToInt32(comboBoxCampo.SelectedValue);

            int idEstado =
                Convert.ToInt32(comboBoxEstado.SelectedValue);


            int? idArbitro = null;

            if (comboBoxArbitro.SelectedIndex != -1)
            {
                idArbitro =
                    Convert.ToInt32(comboBoxArbitro.SelectedValue);
            }


            string resultado = partido.Guardar_Partido(
                1,
                idJornada,
                idLocal,
                idVisitante,
                idCampo,
                idArbitro,
                idEstado,
                dateTimePickerFecha.Value,
                dateTimePickerHora.Value.TimeOfDay);


            if (resultado == "OK")
            {
                MessageBox.Show(
                    "Partido programado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
                CargarDatos();
            }
            else
            {
                MessageBox.Show(
                    resultado,
                    "No se pudo guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            comboBoxJornada.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idPartido == 0)
            {
                MessageBox.Show(
                    "Seleccione un partido para editar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!ValidarCampos())
                return;


            int idJornada =
                Convert.ToInt32(comboBoxJornada.SelectedValue);

            int idLocal =
                Convert.ToInt32(comboBoxEquipoLocal.SelectedValue);

            int idVisitante =
                Convert.ToInt32(comboBoxEquipoVisitante.SelectedValue);

            int idCampo =
                Convert.ToInt32(comboBoxCampo.SelectedValue);

            int idEstado =
                Convert.ToInt32(comboBoxEstado.SelectedValue);


            int? idArbitro = null;

            if (comboBoxArbitro.SelectedIndex != -1)
            {
                idArbitro =
                    Convert.ToInt32(comboBoxArbitro.SelectedValue);
            }


            string resultado = partido.Guardar_Partido(
                2,
                idJornada,
                idLocal,
                idVisitante,
                idCampo,
                idArbitro,
                idEstado,
                dateTimePickerFecha.Value,
                dateTimePickerHora.Value.TimeOfDay,
                idPartido);


            if (resultado == "OK")
            {
                MessageBox.Show(
                    "Partido actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
                CargarDatos();
            }
            else
            {
                MessageBox.Show(
                    resultado,
                    "No se pudo actualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPartido == 0)
            {
                MessageBox.Show(
                    "Seleccione un partido para eliminar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro de que desea eliminar el partido seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (respuesta != DialogResult.Yes)
                return;


            string resultado =
                partido.Eliminar_Partido(idPartido);


            if (resultado == "OK")
            {
                MessageBox.Show(
                    "Partido eliminado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
                CargarDatos();
            }
            else
            {
                MessageBox.Show(
                    resultado,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnRegresarMenu_Click(object sender, EventArgs e)
        {
            frmCompeticiones nuevoform =
                           new frmCompeticiones();

            nuevoform.Show();
        }

        private void frmProgramarPartido_Load_1(object sender, EventArgs e)
        {
            ConfigurarGrid();

            CargarComboBoxes();

            CargarDatos();
        }
    }
}