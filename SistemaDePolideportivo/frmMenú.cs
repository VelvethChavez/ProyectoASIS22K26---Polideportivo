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
            frmDeportes nuevoForm = new frmDeportes { Owner = this };
            nuevoForm.Show();
            Hide();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {

        }
    }
}
