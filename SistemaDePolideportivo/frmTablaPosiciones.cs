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
    public partial class FrmTablaPosiciones : Form
    {
        public FrmTablaPosiciones()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void FrmTablaPosiciones_Load(object sender, EventArgs e)
        {
            CargarCampeonatos();

            DgvPosiciones.DataSource = null;
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

                CmbCboCampeonato.DataSource = tabla;

                CmbCboCampeonato.DisplayMember =
                    "nombre_campeonato";

                CmbCboCampeonato.ValueMember =
                    "id_campeonato";

                CmbCboCampeonato.SelectedIndex = -1;
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
        private void CmbCboCampeonato_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (CmbCboCampeonato.SelectedIndex < 0)
                return;

            if (CmbCboCampeonato.SelectedValue == null)
                return;

            if (CmbCboCampeonato.SelectedValue is DataRowView)
                return;

            int idCampeonato;

            if (!int.TryParse(
                CmbCboCampeonato.SelectedValue.ToString(),
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

            DgvPosiciones.DataSource = tabla;

            ConfigurarTabla();
        }


        // ============================================================
        // CONFIGURAR DATAGRIDVIEW
        // ============================================================
        private void ConfigurarTabla()
        {
            if (DgvPosiciones.Columns.Count == 0)
                return;

            // POS
            if (DgvPosiciones.Columns.Contains("POS"))
            {
                DgvPosiciones.Columns["POS"].HeaderText = "POS";
                DgvPosiciones.Columns["POS"].Width = 50;
            }

            // EQUIPO
            if (DgvPosiciones.Columns.Contains("equipo"))
            {
                DgvPosiciones.Columns["equipo"].HeaderText = "EQUIPO";
                DgvPosiciones.Columns["equipo"].Width = 180;
            }

            // PJ
            if (DgvPosiciones.Columns.Contains("PJ"))
            {
                DgvPosiciones.Columns["PJ"].HeaderText = "PJ";
                DgvPosiciones.Columns["PJ"].Width = 50;
            }

            // PG
            if (DgvPosiciones.Columns.Contains("PG"))
            {
                DgvPosiciones.Columns["PG"].HeaderText = "PG";
                DgvPosiciones.Columns["PG"].Width = 50;
            }

            // PE
            if (DgvPosiciones.Columns.Contains("PE"))
            {
                DgvPosiciones.Columns["PE"].HeaderText = "PE";
                DgvPosiciones.Columns["PE"].Width = 50;
            }

            // PP
            if (DgvPosiciones.Columns.Contains("PP"))
            {
                DgvPosiciones.Columns["PP"].HeaderText = "PP";
                DgvPosiciones.Columns["PP"].Width = 50;
            }

            // GF
            if (DgvPosiciones.Columns.Contains("GF"))
            {
                DgvPosiciones.Columns["GF"].HeaderText = "GF";
                DgvPosiciones.Columns["GF"].Width = 50;
            }

            // GC
            if (DgvPosiciones.Columns.Contains("GC"))
            {
                DgvPosiciones.Columns["GC"].HeaderText = "GC";
                DgvPosiciones.Columns["GC"].Width = 50;
            }

            // DG
            if (DgvPosiciones.Columns.Contains("DG"))
            {
                DgvPosiciones.Columns["DG"].HeaderText = "DG";
                DgvPosiciones.Columns["DG"].Width = 55;
            }

            // PTS
            if (DgvPosiciones.Columns.Contains("PTS"))
            {
                DgvPosiciones.Columns["PTS"].HeaderText = "PTS";
                DgvPosiciones.Columns["PTS"].Width = 60;
            }

            DgvPosiciones.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            DgvPosiciones.AllowUserToAddRows = false;
            DgvPosiciones.ReadOnly = true;
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

        private void CmbCboCampeonato_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CmbCboCampeonato.SelectedIndex < 0)
                return;

            if (CmbCboCampeonato.SelectedValue == null)
                return;

            if (CmbCboCampeonato.SelectedValue is DataRowView)
                return;

            int idCampeonato;

            if (!int.TryParse(
                CmbCboCampeonato.SelectedValue.ToString(),
                out idCampeonato))
            {
                return;
            }

            CargarTablaPosiciones(idCampeonato);
        }

        private void DgvPosiciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}