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
    public partial class FrmRegistrarResultado : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idPartido = 0;
        private int _modoGuardado = 0;


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public FrmRegistrarResultado()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void FrmRegistrarResultado_Load(object sender, EventArgs e)
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

            CmbPartido.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                CmbPartido.DataSource = tabla;

                CmbPartido.DisplayMember =
                    "partido";

                CmbPartido.ValueMember =
                    "id_partido";

                CmbPartido.SelectedIndex = -1;
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

            CmbEstado.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                CmbEstado.DataSource = tabla;

                CmbEstado.DisplayMember =
                    "nombre_estado";

                CmbEstado.ValueMember =
                    "id_estado_partido";

                CmbEstado.SelectedIndex = -1;
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
            DgvResultados.DataSource =
                new CResultado().Listado_Resultados(filtro);

            if (DgvResultados.Columns.Count >= 9)
            {
                DgvResultados.Columns[0].Width = 60;
                DgvResultados.Columns[0].HeaderText = "ID";

                DgvResultados.Columns[1].Width = 120;
                DgvResultados.Columns[1].HeaderText = "JORNADA";

                DgvResultados.Columns[2].Width = 130;
                DgvResultados.Columns[2].HeaderText = "EQUIPO LOCAL";

                DgvResultados.Columns[3].Width = 70;
                DgvResultados.Columns[3].HeaderText = "MARC. L";

                DgvResultados.Columns[4].Width = 130;
                DgvResultados.Columns[4].HeaderText = "EQUIPO VISITANTE";

                DgvResultados.Columns[5].Width = 70;
                DgvResultados.Columns[5].HeaderText = "MARC. V";

                DgvResultados.Columns[6].Width = 100;
                DgvResultados.Columns[6].HeaderText = "ESTADO";

                DgvResultados.Columns[7].Width = 90;
                DgvResultados.Columns[7].HeaderText = "FECHA";

                // Ocultamos el ID del estado.
                DgvResultados.Columns[8].Visible = false;
            }
        }


        // ============================================================
        // RESTABLECER VISTA
        // ============================================================
        private void RestablecerVista()
        {
            _idPartido = 0;
            _modoGuardado = 0;

            CmbPartido.SelectedIndex = -1;

            NudNumMarcadorLocal.Value = 0;
            NudNumMarcadorVisitante.Value = 0;

            CmbEstado.SelectedIndex = -1;

            CmbPartido.Enabled = false;
            NudNumMarcadorLocal.Enabled = false;
            NudNumMarcadorVisitante.Enabled = false;
            CmbEstado.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _idPartido = 0;
            _modoGuardado = ModoNuevo;

            CmbPartido.SelectedIndex = -1;

            NudNumMarcadorLocal.Value = 0;
            NudNumMarcadorVisitante.Value = 0;

            CmbEstado.SelectedIndex = -1;

            CmbPartido.Enabled = true;
            NudNumMarcadorLocal.Enabled = true;
            NudNumMarcadorVisitante.Enabled = true;
            CmbEstado.Enabled = true;

            BtnGuardar.Enabled = true;

            CmbPartido.Focus();
        }





        // ============================================================
        // ELIMINAR / RESTABLECER
        // ============================================================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvResultados.CurrentRow == null ||
                DgvResultados.CurrentRow.IsNewRow)
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
                    DgvResultados.CurrentRow.Cells[0].Value);


            string local =
                DgvResultados.CurrentRow.Cells[2]
                    .Value?.ToString() ?? "";


            string visitante =
                DgvResultados.CurrentRow.Cells[4]
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



        private void DgvResultados_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }



        private void BtnRegresarMenuCompeticiones_Click(
            object sender,
            EventArgs e)
        {
            FrmCompeticiones nuevoform =
                new FrmCompeticiones();

            nuevoform.Show();

            Hide();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

            if (CmbPartido.SelectedIndex == -1 ||
                CmbPartido.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el partido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbPartido.Focus();
                return;
            }



            if (CmbEstado.SelectedIndex == -1 ||
                CmbEstado.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el estado del partido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbEstado.Focus();
                return;
            }


            int idPartido;

            int idEstado;

            try
            {
                idPartido =
                    Convert.ToInt32(
                        CmbPartido.SelectedValue);

                idEstado =
                    Convert.ToInt32(
                        CmbEstado.SelectedValue);
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
                    NudNumMarcadorLocal.Value);

            int marcadorVisitante =
                Convert.ToInt32(
                    NudNumMarcadorVisitante.Value);


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
            if (DgvResultados.CurrentRow == null ||
                DgvResultados.CurrentRow.IsNewRow)
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
                    DgvResultados.CurrentRow.Cells[0].Value);

            _modoGuardado = ModoActualizar;


            // --------------------------------------------------------
            // SELECCIONAR PARTIDO EN COMBOBOX
            // --------------------------------------------------------
            CmbPartido.SelectedValue = _idPartido;


            // --------------------------------------------------------
            // MARCADOR LOCAL
            // --------------------------------------------------------
            if (int.TryParse(
                DgvResultados.CurrentRow.Cells[3]
                    .Value?.ToString(),
                out int marcadorLocal))
            {
                NudNumMarcadorLocal.Value =
                    marcadorLocal;
            }


            // --------------------------------------------------------
            // MARCADOR VISITANTE
            // --------------------------------------------------------
            if (int.TryParse(
                DgvResultados.CurrentRow.Cells[5]
                    .Value?.ToString(),
                out int marcadorVisitante))
            {
                NudNumMarcadorVisitante.Value =
                    marcadorVisitante;
            }


            // --------------------------------------------------------
            // ESTADO
            // --------------------------------------------------------
            if (DgvResultados.Columns.Count > 8 &&
                DgvResultados.CurrentRow.Cells[8].Value != null)
            {
                int idEstado =
                    Convert.ToInt32(
                        DgvResultados.CurrentRow.Cells[8].Value);

                CmbEstado.SelectedValue =
                    idEstado;
            }


            // --------------------------------------------------------
            // HABILITAR CONTROLES
            // --------------------------------------------------------
            CmbPartido.Enabled = true;
            NudNumMarcadorLocal.Enabled = true;
            NudNumMarcadorVisitante.Enabled = true;
            CmbEstado.Enabled = true;

            BtnGuardar.Enabled = true;

            NudNumMarcadorLocal.Focus();
        }

        private void BtnRegresarMenuCompeticiones_Click_1(object sender, EventArgs e)
        {
            FrmCompeticiones nuevoform =
                new FrmCompeticiones();

            nuevoform.Show();

            Hide();
        }
    }
}