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
    public partial class frmRegistrarResultado : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idPartido = 0;
        private int _modoGuardado = 0;


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public frmRegistrarResultado()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void frmRegistrarResultado_Load(object sender, EventArgs e)
        {
            CargarPartidos();
            CargarEstados();
            CargarResultados("%");

            RestablecerVista();
        }


        // ============================================================
        // CARGAR PARTIDOS
        // ============================================================
        private void CargarPartidos()
        {
            DataTable tabla =
                new CResultado().Listado_Partidos();

            cmbPartido.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                cmbPartido.DataSource = tabla;

                cmbPartido.DisplayMember =
                    "partido";

                cmbPartido.ValueMember =
                    "id_partido";

                cmbPartido.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(
                    "No existen partidos registrados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // ============================================================
        // CARGAR ESTADOS
        // ============================================================
        private void CargarEstados()
        {
            DataTable tabla =
                new CResultado().Listado_Estados();

            cmbEstado.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                cmbEstado.DataSource = tabla;

                cmbEstado.DisplayMember =
                    "nombre_estado";

                cmbEstado.ValueMember =
                    "id_estado_partido";

                cmbEstado.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(
                    "No existen estados de partido registrados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // ============================================================
        // CARGAR RESULTADOS
        // ============================================================
        private void CargarResultados(string filtro)
        {
            dgvResultados.DataSource =
                new CResultado().Listado_Resultados(filtro);

            if (dgvResultados.Columns.Count >= 9)
            {
                dgvResultados.Columns[0].Width = 60;
                dgvResultados.Columns[0].HeaderText = "ID";

                dgvResultados.Columns[1].Width = 120;
                dgvResultados.Columns[1].HeaderText = "JORNADA";

                dgvResultados.Columns[2].Width = 130;
                dgvResultados.Columns[2].HeaderText = "EQUIPO LOCAL";

                dgvResultados.Columns[3].Width = 70;
                dgvResultados.Columns[3].HeaderText = "MARC. L";

                dgvResultados.Columns[4].Width = 130;
                dgvResultados.Columns[4].HeaderText = "EQUIPO VISITANTE";

                dgvResultados.Columns[5].Width = 70;
                dgvResultados.Columns[5].HeaderText = "MARC. V";

                dgvResultados.Columns[6].Width = 100;
                dgvResultados.Columns[6].HeaderText = "ESTADO";

                dgvResultados.Columns[7].Width = 90;
                dgvResultados.Columns[7].HeaderText = "FECHA";

                // Ocultamos el ID del estado.
                dgvResultados.Columns[8].Visible = false;
            }
        }


        // ============================================================
        // RESTABLECER VISTA
        // ============================================================
        private void RestablecerVista()
        {
            _idPartido = 0;
            _modoGuardado = 0;

            cmbPartido.SelectedIndex = -1;

            numMarcadorLocal.Value = 0;
            numMarcadorVisitante.Value = 0;

            cmbEstado.SelectedIndex = -1;

            cmbPartido.Enabled = false;
            numMarcadorLocal.Enabled = false;
            numMarcadorVisitante.Enabled = false;
            cmbEstado.Enabled = false;

            btnGuardar.Enabled = false;

            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idPartido = 0;
            _modoGuardado = ModoNuevo;

            cmbPartido.SelectedIndex = -1;

            numMarcadorLocal.Value = 0;
            numMarcadorVisitante.Value = 0;

            cmbEstado.SelectedIndex = -1;

            cmbPartido.Enabled = true;
            numMarcadorLocal.Enabled = true;
            numMarcadorVisitante.Enabled = true;
            cmbEstado.Enabled = true;

            btnGuardar.Enabled = true;

            cmbPartido.Focus();
        }





        // ============================================================
        // ELIMINAR / RESTABLECER
        // ============================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentRow == null ||
                dgvResultados.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un resultado de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            int id =
                Convert.ToInt32(
                    dgvResultados.CurrentRow.Cells[0].Value);


            string local =
                dgvResultados.CurrentRow.Cells[2]
                    .Value?.ToString() ?? "";


            string visitante =
                dgvResultados.CurrentRow.Cells[4]
                    .Value?.ToString() ?? "";


            DialogResult confirmacion =
                MessageBox.Show(
                    "¿Desea eliminar el resultado del partido \"" +
                    local +
                    " vs " +
                    visitante +
                    "\" y volverlo a estado Programado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (confirmacion != DialogResult.Yes)
            {
                return;
            }


            string respuesta =
                new CResultado()
                    .Eliminar_Resultado(id);


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "El resultado ha sido eliminado y el partido regresó a estado Programado.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarResultados("%");

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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }



        private void dgvResultados_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }



        private void BtnRegresarMenuCompeticiones_Click(
            object sender,
            EventArgs e)
        {
            frmCompeticiones nuevoform =
                new frmCompeticiones();

            nuevoform.Show();

            Hide();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (cmbPartido.SelectedIndex == -1 ||
                cmbPartido.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el partido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPartido.Focus();
                return;
            }



            if (cmbEstado.SelectedIndex == -1 ||
                cmbEstado.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el estado del partido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEstado.Focus();
                return;
            }


            int idPartido;

            int idEstado;

            try
            {
                idPartido =
                    Convert.ToInt32(
                        cmbPartido.SelectedValue);

                idEstado =
                    Convert.ToInt32(
                        cmbEstado.SelectedValue);
            }
            catch
            {
                MessageBox.Show(
                    "No se pudieron obtener los datos seleccionados.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            int marcadorLocal =
                Convert.ToInt32(
                    numMarcadorLocal.Value);

            int marcadorVisitante =
                Convert.ToInt32(
                    numMarcadorVisitante.Value);


            CResultado resultado =
                new CResultado();

            string respuesta =
                resultado.Guardar_Resultado(
                    idPartido,
                    marcadorLocal,
                    marcadorVisitante,
                    idEstado);


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "Resultado registrado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarResultados("%");

                RestablecerVista();
            }
            else
            {
                MessageBox.Show(
                    "Error: " + respuesta,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentRow == null ||
                dgvResultados.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un resultado de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // --------------------------------------------------------
            // OBTENER ID DEL PARTIDO
            // --------------------------------------------------------
            _idPartido =
                Convert.ToInt32(
                    dgvResultados.CurrentRow.Cells[0].Value);

            _modoGuardado = ModoActualizar;


            // --------------------------------------------------------
            // SELECCIONAR PARTIDO EN COMBOBOX
            // --------------------------------------------------------
            cmbPartido.SelectedValue = _idPartido;


            // --------------------------------------------------------
            // MARCADOR LOCAL
            // --------------------------------------------------------
            if (int.TryParse(
                dgvResultados.CurrentRow.Cells[3]
                    .Value?.ToString(),
                out int marcadorLocal))
            {
                numMarcadorLocal.Value =
                    marcadorLocal;
            }


            // --------------------------------------------------------
            // MARCADOR VISITANTE
            // --------------------------------------------------------
            if (int.TryParse(
                dgvResultados.CurrentRow.Cells[5]
                    .Value?.ToString(),
                out int marcadorVisitante))
            {
                numMarcadorVisitante.Value =
                    marcadorVisitante;
            }


            // --------------------------------------------------------
            // ESTADO
            // --------------------------------------------------------
            if (dgvResultados.Columns.Count > 8 &&
                dgvResultados.CurrentRow.Cells[8].Value != null)
            {
                int idEstado =
                    Convert.ToInt32(
                        dgvResultados.CurrentRow.Cells[8].Value);

                cmbEstado.SelectedValue =
                    idEstado;
            }


            // --------------------------------------------------------
            // HABILITAR CONTROLES
            // --------------------------------------------------------
            cmbPartido.Enabled = true;
            numMarcadorLocal.Enabled = true;
            numMarcadorVisitante.Enabled = true;
            cmbEstado.Enabled = true;

            btnGuardar.Enabled = true;

            numMarcadorLocal.Focus();
        }

        private void btnRegresarMenuCompeticiones_Click_1(object sender, EventArgs e)
        {
            frmCompeticiones nuevoform =
                new frmCompeticiones();

            nuevoform.Show();

            Hide();
        }
    }
}