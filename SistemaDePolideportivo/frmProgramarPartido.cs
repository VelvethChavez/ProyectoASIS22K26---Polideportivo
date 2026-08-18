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
    public partial class FrmProgramarPartido : Form
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
        public FrmProgramarPartido()
        {
            InitializeComponent();

            Dgv1.CellClick += Dgv1_CellClick;
        }


       


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarGrid()
        {
            Dgv1.Enabled = true;
            Dgv1.ReadOnly = true;
            Dgv1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Dgv1.MultiSelect = false;

            Dgv1.AllowUserToAddRows = false;
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

                CmbComboBoxJornada.DataSource = jornadas;
                CmbComboBoxJornada.DisplayMember = "nombre_jornada";
                CmbComboBoxJornada.ValueMember = "id_jornada";
                CmbComboBoxJornada.SelectedIndex = -1;


                // ----------------------------------------------------
                // EQUIPOS
                // ----------------------------------------------------
                DataTable equipos = partido.Listado_Equipos();

                CmbComboBoxEquipoLocal.DataSource = equipos.Copy();
                CmbComboBoxEquipoLocal.DisplayMember = "nombre_equipo";
                CmbComboBoxEquipoLocal.ValueMember = "id_equipo";
                CmbComboBoxEquipoLocal.SelectedIndex = -1;

                CmbComboBoxEquipoVisitante.DataSource = equipos;
                CmbComboBoxEquipoVisitante.DisplayMember = "nombre_equipo";
                CmbComboBoxEquipoVisitante.ValueMember = "id_equipo";
                CmbComboBoxEquipoVisitante.SelectedIndex = -1;


                // ----------------------------------------------------
                // CAMPOS
                // ----------------------------------------------------
                DataTable campos = partido.Listado_Campos();

                CmbComboBoxCampo.DataSource = campos;
                CmbComboBoxCampo.DisplayMember = "nombre_campo";
                CmbComboBoxCampo.ValueMember = "id_campo";
                CmbComboBoxCampo.SelectedIndex = -1;


                // ----------------------------------------------------
                // ÁRBITROS
                // ----------------------------------------------------
                DataTable arbitros = partido.Listado_Arbitros();

                CmbComboBoxArbitro.DataSource = arbitros;
                CmbComboBoxArbitro.DisplayMember = "nombre_arbitro";
                CmbComboBoxArbitro.ValueMember = "id_arbitro";
                CmbComboBoxArbitro.SelectedIndex = -1;


                // ----------------------------------------------------
                // ESTADOS
                // ----------------------------------------------------
                DataTable estados = partido.Listado_Estados();

                CmbComboBoxEstado.DataSource = estados;
                CmbComboBoxEstado.DisplayMember = "nombre_estado";
                CmbComboBoxEstado.ValueMember = "id_estado_partido";
                CmbComboBoxEstado.SelectedIndex = -1;
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
                Dgv1.DataSource =
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
            if (CmbComboBoxJornada.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una jornada.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxJornada.Focus();
                return false;
            }


            if (CmbComboBoxEquipoLocal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el equipo local.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxEquipoLocal.Focus();
                return false;
            }


            if (CmbComboBoxEquipoVisitante.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el equipo visitante.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxEquipoVisitante.Focus();
                return false;
            }


            if (Convert.ToInt32(CmbComboBoxEquipoLocal.SelectedValue) ==
                Convert.ToInt32(CmbComboBoxEquipoVisitante.SelectedValue))
            {
                MessageBox.Show(
                    "El equipo local y visitante no pueden ser el mismo.",
                    "Equipos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            if (CmbComboBoxCampo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un campo.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxCampo.Focus();
                return false;
            }


            if (CmbComboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un estado.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxEstado.Focus();
                return false;
            }


            return true;
        }


        // ============================================================
        // SELECCIONAR PARTIDO DEL GRID
        // ============================================================
        private void Dgv1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow fila =
                Dgv1.Rows[e.RowIndex];


            idPartido =
                Convert.ToInt32(
                    fila.Cells["id_partido"].Value);


            // Fecha
            DtpDateTimePickerFecha.Value =
                Convert.ToDateTime(
                    fila.Cells["fecha_partido"].Value);


            // Hora
            TimeSpan hora =
                (TimeSpan)fila.Cells["hora_partido"].Value;

            DtpDateTimePickerHora.Value =
                DateTime.Today.Add(hora);


            // Jornada
            CmbComboBoxJornada.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_jornada"].Value);


            // Equipo local
            CmbComboBoxEquipoLocal.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_equipo_local"].Value);


            // Equipo visitante
            CmbComboBoxEquipoVisitante.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_equipo_visitante"].Value);


            // Campo
            CmbComboBoxCampo.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_campo"].Value);


            // Árbitro
            if (fila.Cells["id_arbitro"].Value != DBNull.Value)
            {
                CmbComboBoxArbitro.SelectedValue =
                    Convert.ToInt32(
                        fila.Cells["id_arbitro"].Value);
            }
            else
            {
                CmbComboBoxArbitro.SelectedIndex = -1;
            }


            // Estado
            CmbComboBoxEstado.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_estado_partido"].Value);
        }




        // ============================================================
        // LIMPIAR
        // ============================================================
        private void LimpiarCampos()
        {
            idPartido = 0;


            CmbComboBoxJornada.SelectedIndex = -1;
            CmbComboBoxEquipoLocal.SelectedIndex = -1;
            CmbComboBoxEquipoVisitante.SelectedIndex = -1;
            CmbComboBoxCampo.SelectedIndex = -1;
            CmbComboBoxArbitro.SelectedIndex = -1;
            CmbComboBoxEstado.SelectedIndex = -1;


            DtpDateTimePickerFecha.Value =
                DateTime.Today;

            DtpDateTimePickerHora.Value =
                DateTime.Now;


            if (Dgv1.DataSource != null)
            {
                Dgv1.ClearSelection();
            }
        }



        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;


            int idJornada =
                Convert.ToInt32(CmbComboBoxJornada.SelectedValue);

            int idLocal =
                Convert.ToInt32(CmbComboBoxEquipoLocal.SelectedValue);

            int idVisitante =
                Convert.ToInt32(CmbComboBoxEquipoVisitante.SelectedValue);

            int idCampo =
                Convert.ToInt32(CmbComboBoxCampo.SelectedValue);

            int idEstado =
                Convert.ToInt32(CmbComboBoxEstado.SelectedValue);


            int? idArbitro = null;

            if (CmbComboBoxArbitro.SelectedIndex != -1)
            {
                idArbitro =
                    Convert.ToInt32(CmbComboBoxArbitro.SelectedValue);
            }


            string resultado = partido.Guardar_Partido(
                1,
                idJornada,
                idLocal,
                idVisitante,
                idCampo,
                idArbitro,
                idEstado,
                DtpDateTimePickerFecha.Value,
                DtpDateTimePickerHora.Value.TimeOfDay);


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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            CmbComboBoxJornada.Focus();
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
                Convert.ToInt32(CmbComboBoxJornada.SelectedValue);

            int idLocal =
                Convert.ToInt32(CmbComboBoxEquipoLocal.SelectedValue);

            int idVisitante =
                Convert.ToInt32(CmbComboBoxEquipoVisitante.SelectedValue);

            int idCampo =
                Convert.ToInt32(CmbComboBoxCampo.SelectedValue);

            int idEstado =
                Convert.ToInt32(CmbComboBoxEstado.SelectedValue);


            int? idArbitro = null;

            if (CmbComboBoxArbitro.SelectedIndex != -1)
            {
                idArbitro =
                    Convert.ToInt32(CmbComboBoxArbitro.SelectedValue);
            }


            string resultado = partido.Guardar_Partido(
                2,
                idJornada,
                idLocal,
                idVisitante,
                idCampo,
                idArbitro,
                idEstado,
                DtpDateTimePickerFecha.Value,
                DtpDateTimePickerHora.Value.TimeOfDay,
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

        private void BtnEliminar_Click(object sender, EventArgs e)
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
            FrmCompeticiones nuevoform =
                           new FrmCompeticiones();

            nuevoform.Show();
        }

        private void FrmProgramarPartido_Load_1(object sender, EventArgs e)
        {
            ConfigurarGrid();

            CargarComboBoxes();

            CargarDatos();
        }
    }
}