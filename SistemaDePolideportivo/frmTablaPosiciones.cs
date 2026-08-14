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
    public partial class frmTablaPosiciones : Form
    {
        public frmTablaPosiciones()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void frmTablaPosiciones_Load(object sender, EventArgs e)
        {
            CargarCampeonatos();

            dgvPosiciones.DataSource = null;
        }


        // ============================================================
        // CARGAR CAMPEONATOS EN COMBOBOX
        // ============================================================
        private void CargarCampeonatos()
        {
            try
            {
                DataTable tabla =
                    new CPosiciones().Listado_Campeonatos();

                cboCampeonato.DataSource = tabla;

                cboCampeonato.DisplayMember =
                    "nombre_campeonato";

                cboCampeonato.ValueMember =
                    "id_campeonato";

                cboCampeonato.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los campeonatos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // CUANDO CAMBIA EL CAMPEONATO
        // ============================================================
        private void cboCampeonato_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboCampeonato.SelectedIndex < 0)
                return;

            if (cboCampeonato.SelectedValue == null)
                return;

            if (cboCampeonato.SelectedValue is DataRowView)
                return;

            int idCampeonato;

            if (!int.TryParse(
                cboCampeonato.SelectedValue.ToString(),
                out idCampeonato))
            {
                return;
            }

            CargarTablaPosiciones(idCampeonato);
        }


        // ============================================================
        // CARGAR TABLA DE POSICIONES
        // ============================================================
        private void CargarTablaPosiciones(int idCampeonato)
        {
            DataTable tabla =
                new CPosiciones()
                .ObtenerTablaPosiciones(idCampeonato);

            dgvPosiciones.DataSource = tabla;

            ConfigurarTabla();
        }


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarTabla()
        {
            if (dgvPosiciones.Columns.Count == 0)
                return;

            // POS
            if (dgvPosiciones.Columns.Contains("POS"))
            {
                dgvPosiciones.Columns["POS"].HeaderText = "POS";
                dgvPosiciones.Columns["POS"].Width = 50;
            }

            // EQUIPO
            if (dgvPosiciones.Columns.Contains("equipo"))
            {
                dgvPosiciones.Columns["equipo"].HeaderText = "EQUIPO";
                dgvPosiciones.Columns["equipo"].Width = 180;
            }

            // PJ
            if (dgvPosiciones.Columns.Contains("PJ"))
            {
                dgvPosiciones.Columns["PJ"].HeaderText = "PJ";
                dgvPosiciones.Columns["PJ"].Width = 50;
            }

            // PG
            if (dgvPosiciones.Columns.Contains("PG"))
            {
                dgvPosiciones.Columns["PG"].HeaderText = "PG";
                dgvPosiciones.Columns["PG"].Width = 50;
            }

            // PE
            if (dgvPosiciones.Columns.Contains("PE"))
            {
                dgvPosiciones.Columns["PE"].HeaderText = "PE";
                dgvPosiciones.Columns["PE"].Width = 50;
            }

            // PP
            if (dgvPosiciones.Columns.Contains("PP"))
            {
                dgvPosiciones.Columns["PP"].HeaderText = "PP";
                dgvPosiciones.Columns["PP"].Width = 50;
            }

            // GF
            if (dgvPosiciones.Columns.Contains("GF"))
            {
                dgvPosiciones.Columns["GF"].HeaderText = "GF";
                dgvPosiciones.Columns["GF"].Width = 50;
            }

            // GC
            if (dgvPosiciones.Columns.Contains("GC"))
            {
                dgvPosiciones.Columns["GC"].HeaderText = "GC";
                dgvPosiciones.Columns["GC"].Width = 50;
            }

            // DG
            if (dgvPosiciones.Columns.Contains("DG"))
            {
                dgvPosiciones.Columns["DG"].HeaderText = "DG";
                dgvPosiciones.Columns["DG"].Width = 55;
            }

            // PTS
            if (dgvPosiciones.Columns.Contains("PTS"))
            {
                dgvPosiciones.Columns["PTS"].HeaderText = "PTS";
                dgvPosiciones.Columns["PTS"].Width = 60;
            }

            dgvPosiciones.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvPosiciones.AllowUserToAddRows = false;
            dgvPosiciones.ReadOnly = true;
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

        private void cboCampeonato_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCampeonato.SelectedIndex < 0)
                return;

            if (cboCampeonato.SelectedValue == null)
                return;

            if (cboCampeonato.SelectedValue is DataRowView)
                return;

            int idCampeonato;

            if (!int.TryParse(
                cboCampeonato.SelectedValue.ToString(),
                out idCampeonato))
            {
                return;
            }

            CargarTablaPosiciones(idCampeonato);
        }

        private void dgvPosiciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}