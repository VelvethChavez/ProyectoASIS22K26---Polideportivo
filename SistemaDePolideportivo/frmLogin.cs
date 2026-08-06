using SistemaDePolideportivo;
using System;
using System.Windows.Forms;

namespace ProyectoASIS22K26___Polideportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void PicAdmin_Click(object sender, EventArgs e)
        {
            frmLoginAdministrador nuevoForm = new frmLoginAdministrador();
            nuevoForm.Show();
            Hide();

        }

        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            frmLoginAdministrador nuevoForm = new frmLoginAdministrador();
            nuevoForm.Show();
            Hide();
        }

        private void BtnLoginArbitro_Click(object sender, EventArgs e)
        {
            frmLoginAdministrador nuevoForm = new frmLoginAdministrador();
            nuevoForm.Show();
            Hide();
        }

        private void PicArbitro_Click(object sender, EventArgs e)
        {
            frmloginarbitro nuevoform = new frmloginarbitro();
            nuevoform.Show();
            Hide();
        }

        private void PicEquipo_Click(object sender, EventArgs e)
        {
            frmLoginEquipo nuevoform = new frmLoginEquipo();
            nuevoform.Show();
            Hide();
        }

        private void BtnLoginEquipo_Click(object sender, EventArgs e)
        {
            frmLoginEquipo nuevoform = new frmLoginEquipo();
            nuevoform.Show();
            Hide();
        }

        private void PicGerente_Click(object sender, EventArgs e)
        {
            frmlogingerente nuevoform = new frmlogingerente();
            nuevoform.Show();
            Hide();
        }

        private void BtnLoginGerente_Click(object sender, EventArgs e)
        {
            frmlogingerente nuevoform = new frmlogingerente();
            nuevoform.Show();
            Hide();
        }
    }
}
