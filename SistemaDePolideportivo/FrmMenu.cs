using SistemaDePolideportivo;
using System;
using System.Windows.Forms;

namespace ProyectoASIS22K26___Polideportivo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnReglas_Click(object sender, EventArgs e)
        {
            var reglamento = new FrmReglamento { Owner = this };
            reglamento.Show();
            Hide();
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            FrmCampeonato nuevoForm = new FrmCampeonato { Owner = this };
            nuevoForm.Show();
            Hide();
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            FrmModuloSeguridad modulo = new FrmModuloSeguridad();
            modulo.Show();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes nuevoForm = new FrmReportes();
            nuevoForm.Show();
            Hide();
        }

        private void BtnEquipos_Click(object sender, EventArgs e)
        {
            FrmModuloEquipos nuevoForm = new FrmModuloEquipos { Owner = this };
            nuevoForm.Show();
            Hide();
        }

        private void BtnCompetencias_Click(object sender, EventArgs e)
        {
            FrmCompeticiones nuevoForm = new FrmCompeticiones();
            nuevoForm.Show();
            Hide();
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadistica nuevoform = new FrmEstadistica();
            nuevoform.Show();
            Hide();
        }

        private void BtnRRHH_Click(object sender, EventArgs e)
        {
            FrmEmpleado nuevoform = new FrmEmpleado();
            nuevoform.Show();
            Hide();
        }
    }
}
