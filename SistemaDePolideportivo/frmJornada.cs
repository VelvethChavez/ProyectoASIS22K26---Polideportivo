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
    public partial class frmJornada : Form
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
        public frmJornada()
        {
            InitializeComponent();
        }


     


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarGrid()
        {
            dgvJornadas.Enabled = true;

            dgvJornadas.ReadOnly = true;

            dgvJornadas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvJornadas.MultiSelect = false;

            dgvJornadas.AllowUserToAddRows = false;
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


                comboBoxCampeonato.DataSource =
                    campeonatos;

                comboBoxCampeonato.DisplayMember =
                    "nombre_campeonato";

                comboBoxCampeonato.ValueMember =
                    "id_campeonato";

                comboBoxCampeonato.SelectedIndex =
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
                dgvJornadas.DataSource =
                    jornada.Listado_Jornadas(filtro);


                if (dgvJornadas.Columns.Count >= 6)
                {
                    // ID Jornada
                    dgvJornadas.Columns[0].Width = 70;
                    dgvJornadas.Columns[0].HeaderText =
                        "ID JORNADA";


                    // Nombre
                    dgvJornadas.Columns[1].Width = 150;
                    dgvJornadas.Columns[1].HeaderText =
                        "NOMBRE JORNADA";


                    // Número
                    dgvJornadas.Columns[2].Width = 70;
                    dgvJornadas.Columns[2].HeaderText =
                        "NÚMERO";


                    // Fecha
                    dgvJornadas.Columns[3].Width = 100;
                    dgvJornadas.Columns[3].HeaderText =
                        "FECHA";


                    // Campeonato
                    dgvJornadas.Columns[4].Width = 180;
                    dgvJornadas.Columns[4].HeaderText =
                        "CAMPEONATO";


                    // ID Campeonato
                    // Lo necesitamos internamente,
                    // pero no necesitamos mostrarlo.
                    dgvJornadas.Columns[5].Visible =
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


            comboBoxCampeonato.SelectedIndex = -1;

            txtNombreJornada.Clear();

            numNumeroJornada.Value = 1;

            dtpFechaJornada.Value =
                DateTime.Today;


            comboBoxCampeonato.Enabled = false;

            txtNombreJornada.Enabled = false;

            numNumeroJornada.Enabled = false;

            dtpFechaJornada.Enabled = false;


            btnGuardar.Enabled = false;

            btnNuevo.Enabled = true;

            BtnEditar.Enabled = true;

            btnEliminar.Enabled = true;


            if (dgvJornadas.DataSource != null)
            {
                dgvJornadas.ClearSelection();
            }
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            _idJornada = 0;

            _modoGuardado = ModoNuevo;


            comboBoxCampeonato.SelectedIndex =
                -1;

            txtNombreJornada.Clear();

            numNumeroJornada.Value = 1;

            dtpFechaJornada.Value =
                DateTime.Today;


            comboBoxCampeonato.Enabled = true;

            txtNombreJornada.Enabled = true;

            numNumeroJornada.Enabled = true;

            dtpFechaJornada.Enabled = true;


            btnGuardar.Enabled = true;


            comboBoxCampeonato.Focus();
        }


        // ============================================================
        // GUARDAR
        // ============================================================
        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }


            int idCampeonato =
                Convert.ToInt32(
                    comboBoxCampeonato.SelectedValue);


            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }


            string respuesta =
                jornada.Guardar_Jornada(
                    _modoGuardado,
                    idCampeonato,
                    txtNombreJornada.Text.Trim(),
                    Convert.ToInt32(
                        numNumeroJornada.Value),
                    dtpFechaJornada.Value,
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
            if (comboBoxCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un campeonato.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBoxCampeonato.Focus();

                return false;
            }


            if (string.IsNullOrWhiteSpace(
                txtNombreJornada.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre de la jornada.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreJornada.Focus();

                return false;
            }


            if (numNumeroJornada.Value <= 0)
            {
                MessageBox.Show(
                    "El número de jornada debe ser mayor que cero.",
                    "Campo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                numNumeroJornada.Focus();

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
            if (dgvJornadas.CurrentRow == null ||
                dgvJornadas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione una jornada de la tabla.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DataGridViewRow fila =
                dgvJornadas.CurrentRow;


            // ID de la jornada
            _idJornada =
                Convert.ToInt32(
                    fila.Cells[0].Value);


            _modoGuardado =
                ModoActualizar;


            // Nombre
            txtNombreJornada.Text =
                fila.Cells[1].Value?.ToString()
                ?? string.Empty;


            // Número
            if (int.TryParse(
                fila.Cells[2].Value?.ToString(),
                out int numero))
            {
                numNumeroJornada.Value =
                    numero;
            }


            // Fecha
            if (DateTime.TryParse(
                fila.Cells[3].Value?.ToString(),
                out DateTime fecha))
            {
                dtpFechaJornada.Value =
                    fecha;
            }


            // ID Campeonato
            if (fila.Cells[5].Value != null &&
                fila.Cells[5].Value != DBNull.Value)
            {
                comboBoxCampeonato.SelectedValue =
                    Convert.ToInt32(
                        fila.Cells[5].Value);
            }
            else
            {
                comboBoxCampeonato.SelectedIndex =
                    -1;
            }


            // Activar controles
            comboBoxCampeonato.Enabled = true;

            txtNombreJornada.Enabled = true;

            numNumeroJornada.Enabled = true;

            dtpFechaJornada.Enabled = true;

            btnGuardar.Enabled = true;


            comboBoxCampeonato.Focus();
        }


        // ============================================================
        // ELIMINAR
        // ============================================================
        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvJornadas.CurrentRow == null ||
                dgvJornadas.CurrentRow.IsNewRow)
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
                    dgvJornadas.CurrentRow.Cells[0].Value);


            string nombre =
                dgvJornadas.CurrentRow.Cells[1]
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
        private void dgvJornadas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        // ============================================================
        // REGRESAR
        // ============================================================
        private void btnRegresarMenuCompeticiones_Click(
            object sender,
            EventArgs e)
        {
            frmCompeticiones nuevoform =
                new frmCompeticiones();

            nuevoform.Show();

            Hide();
        }


       
        private void frmJornada_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarGrid();

            CargarCampeonatos();

            CargarJornadas("%");

            RestablecerVista();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}