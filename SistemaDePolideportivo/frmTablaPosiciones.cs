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

        private void frmTablaPosiciones_Load(object sender, EventArgs e)
        {
            CargarPosiciones("%");
        }

        private void CargarPosiciones(string filtroCampeonato)
        {
            dgvPosiciones.DataSource = new CTablaPosiciones().ObtenerTablaPosiciones(filtroCampeonato);

            // Formato visual de la tabla
            if (dgvPosiciones.Columns.Count >= 10)
            {
                dgvPosiciones.Columns["POS"].Width = 50;
                dgvPosiciones.Columns["EQUIPO"].Width = 180;
                dgvPosiciones.Columns["PJ"].Width = 50;
                dgvPosiciones.Columns["PG"].Width = 50;
                dgvPosiciones.Columns["PE"].Width = 50;
                dgvPosiciones.Columns["PP"].Width = 50;
                dgvPosiciones.Columns["GF"].Width = 50;
                dgvPosiciones.Columns["GC"].Width = 50;
                dgvPosiciones.Columns["DG"].Width = 60;
                dgvPosiciones.Columns["PTS"].Width = 60;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtCampeonato.Text.Trim();
            CargarPosiciones(string.IsNullOrEmpty(filtro) ? "%" : filtro);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtCampeonato.Clear();
            CargarPosiciones("%");
        }
    }
}
