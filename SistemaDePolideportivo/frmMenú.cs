using SistemaDePolideportivo;
using System;
using System.Windows.Forms;

namespace ProyectoASIS22K26___Polideportivo
{
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
        }

        private void btnReglamento_Click(object sender, EventArgs e)
        {
            var reglamento = new frmReglamento { Owner = this };
            reglamento.Show();
            Hide();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            frmCampeonato nuevoForm = new frmCampeonato { Owner = this };
            nuevoForm.Show();
            Hide();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ModuloSeguridad modulo = new ModuloSeguridad();
            modulo.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes nuevoForm = new Reportes();
            nuevoForm.Show();
            Hide();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {

        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            frmCompeticiones nuevoForm = new frmCompeticiones();
            nuevoForm.Show();
            Hide();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadistica nuevoform = new FormEstadistica();
            nuevoform.Show();
            Hide();
        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            FormEmpleado nuevoform = new FormEmpleado();
            nuevoform.Show();
            Hide();
        }
    }
}
