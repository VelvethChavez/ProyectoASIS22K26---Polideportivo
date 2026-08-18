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
    public partial class FrmJornada : Form
    {
        // ============================================================
        // MODOS
        // ============================================================
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;


        // ============================================================
        // VARIABLES
        // ============================================================
        private int _idJornada = 0;
        private int _modoGuardado = 0;


        // ============================================================
        // OBJETO CJornada
        // ============================================================
        private readonly CJornada jornada =
            new CJornada();


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public FrmJornada()
        {
            InitializeComponent();
        }


     


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarGrid()
        {
            DgvJornadas.Enabled = true;

            DgvJornadas.ReadOnly = true;

            DgvJornadas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DgvJornadas.MultiSelect = false;

            DgvJornadas.AllowUserToAddRows = false;
        }


        // ============================================================
        // CARGAR CAMPEONATOS
        // ============================================================
        private void CargarCampeonatos()
        {
            try
            {
                DataTable campeonatos =
                    jornada.Listado_Campeonatos();


                CmbComboBoxCampeonato.DataSource =
                    campeonatos;

                CmbComboBoxCampeonato.DisplayMember =
                    "nombre_campeonato";

                CmbComboBoxCampeonato.ValueMember =
                    "id_campeonato";

                CmbComboBoxCampeonato.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los campeonatos: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // CARGAR JORNADAS
        // ============================================================
        private void CargarJornadas(string filtro)
        {
            try
            {
                DgvJornadas.DataSource =
                    jornada.Listado_Jornadas(filtro);


                if (DgvJornadas.Columns.Count >= 6)
                {
                    // ID Jornada
                    DgvJornadas.Columns[0].Width = 70;
                    DgvJornadas.Columns[0].HeaderText =
                        "ID JORNADA";


                    // Nombre
                    DgvJornadas.Columns[1].Width = 150;
                    DgvJornadas.Columns[1].HeaderText =
                        "NOMBRE JORNADA";


                    // Número
                    DgvJornadas.Columns[2].Width = 70;
                    DgvJornadas.Columns[2].HeaderText =
                        "NÚMERO";


                    // Fecha
                    DgvJornadas.Columns[3].Width = 100;
                    DgvJornadas.Columns[3].HeaderText =
                        "FECHA";


                    // Campeonato
                    DgvJornadas.Columns[4].Width = 180;
                    DgvJornadas.Columns[4].HeaderText =
                        "CAMPEONATO";


                    // ID Campeonato
                    // Lo necesitamos internamente,
                    // pero no necesitamos mostrarlo.
                    DgvJornadas.Columns[5].Visible =
                        false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las jornadas: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // RESTABLECER VISTA
        // ============================================================
        private void RestablecerVista()
        {
            _idJornada = 0;

            _modoGuardado = 0;


            CmbComboBoxCampeonato.SelectedIndex = -1;

            TxtNombreJornada.Clear();

            NudNumNumeroJornada.Value = 1;

            DtpFechaJornada.Value =
                DateTime.Today;


            CmbComboBoxCampeonato.Enabled = false;

            TxtNombreJornada.Enabled = false;

            NudNumNumeroJornada.Enabled = false;

            DtpFechaJornada.Enabled = false;


            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;

            BtnEditar.Enabled = true;

            BtnEliminar.Enabled = true;


            if (DgvJornadas.DataSource != null)
            {
                DgvJornadas.ClearSelection();
            }
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void BtnNuevo_Click(
            object sender,
            EventArgs e)
        {
            _idJornada = 0;

            _modoGuardado = ModoNuevo;


            CmbComboBoxCampeonato.SelectedIndex =
                -1;

            TxtNombreJornada.Clear();

            NudNumNumeroJornada.Value = 1;

            DtpFechaJornada.Value =
                DateTime.Today;


            CmbComboBoxCampeonato.Enabled = true;

            TxtNombreJornada.Enabled = true;

            NudNumNumeroJornada.Enabled = true;

            DtpFechaJornada.Enabled = true;


            BtnGuardar.Enabled = true;


            CmbComboBoxCampeonato.Focus();
        }


        // ============================================================
        // GUARDAR
        // ============================================================
        private void BtnGuardar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }


            int idCampeonato =
                Convert.ToInt32(
                    CmbComboBoxCampeonato.SelectedValue);


            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }


            string respuesta =
                jornada.Guardar_Jornada(
                    _modoGuardado,
                    idCampeonato,
                    TxtNombreJornada.Text.Trim(),
                    Convert.ToInt32(
                        NudNumNumeroJornada.Value),
                    DtpFechaJornada.Value,
                    _idJornada);


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "La jornada se guardó correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                CargarJornadas("%");

                RestablecerVista();
            }
            else
            {
                MessageBox.Show(
                    respuesta,
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
            if (CmbComboBoxCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un campeonato.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbComboBoxCampeonato.Focus();

                return false;
            }


            if (string.IsNullOrWhiteSpace(
                TxtNombreJornada.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre de la jornada.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombreJornada.Focus();

                return false;
            }


            if (NudNumNumeroJornada.Value <= 0)
            {
                MessageBox.Show(
                    "El número de jornada debe ser mayor que cero.",
                    "Campo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                NudNumNumeroJornada.Focus();

                return false;
            }


            return true;
        }


        // ============================================================
        // EDITAR
        // ============================================================
        private void BtnEditar_Click(
            object sender,
            EventArgs e)
        {
            if (DgvJornadas.CurrentRow == null ||
                DgvJornadas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione una jornada de la tabla.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DataGridViewRow fila =
                DgvJornadas.CurrentRow;


            // ID de la jornada
            _idJornada =
                Convert.ToInt32(
                    fila.Cells[0].Value);


            _modoGuardado =
                ModoActualizar;


            // Nombre
            TxtNombreJornada.Text =
                fila.Cells[1].Value?.ToString()
                ?? string.Empty;


            // Número
            if (int.TryParse(
                fila.Cells[2].Value?.ToString(),
                out int numero))
            {
                NudNumNumeroJornada.Value =
                    numero;
            }


            // Fecha
            if (DateTime.TryParse(
                fila.Cells[3].Value?.ToString(),
                out DateTime fecha))
            {
                DtpFechaJornada.Value =
                    fecha;
            }


            // ID Campeonato
            if (fila.Cells[5].Value != null &&
                fila.Cells[5].Value != DBNull.Value)
            {
                CmbComboBoxCampeonato.SelectedValue =
                    Convert.ToInt32(
                        fila.Cells[5].Value);
            }
            else
            {
                CmbComboBoxCampeonato.SelectedIndex =
                    -1;
            }


            // Activar controles
            CmbComboBoxCampeonato.Enabled = true;

            TxtNombreJornada.Enabled = true;

            NudNumNumeroJornada.Enabled = true;

            DtpFechaJornada.Enabled = true;

            BtnGuardar.Enabled = true;


            CmbComboBoxCampeonato.Focus();
        }


        // ============================================================
        // ELIMINAR
        // ============================================================
        private void BtnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (DgvJornadas.CurrentRow == null ||
                DgvJornadas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione una jornada de la tabla.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            int id =
                Convert.ToInt32(
                    DgvJornadas.CurrentRow.Cells[0].Value);


            string nombre =
                DgvJornadas.CurrentRow.Cells[1]
                    .Value?.ToString()
                ?? string.Empty;


            DialogResult confirmacion =
                MessageBox.Show(
                    "¿Desea eliminar la jornada \"" +
                    nombre +
                    "\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (confirmacion != DialogResult.Yes)
            {
                return;
            }


            string respuesta =
                jornada.Eliminar_Jornada(id);


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "La jornada se eliminó correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                CargarJornadas("%");

                RestablecerVista();
            }
            else
            {
                MessageBox.Show(
                    respuesta,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            RestablecerVista();
        }


        // ============================================================
        // CLICK EN DATAGRID
        // ============================================================
        private void DgvJornadas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        // ============================================================
        // REGRESAR
        // ============================================================
        private void BtnRegresarMenuCompeticiones_Click(
            object sender,
            EventArgs e)
        {
            FrmCompeticiones nuevoform =
                new FrmCompeticiones();

            nuevoform.Show();

            Hide();
        }


       
        private void FrmJornada_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarGrid();

            CargarCampeonatos();

            CargarJornadas("%");

            RestablecerVista();
        }

        private void CmbComboBoxCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}