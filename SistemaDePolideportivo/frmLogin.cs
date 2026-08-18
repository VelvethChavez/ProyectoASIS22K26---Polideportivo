using SistemaDePolideportivo;
using System;
using System.Windows.Forms;

namespace ProyectoASIS22K26___Polideportivo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void PicAdmin_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin nuevoForm = new FrmLoginAdmin();
            nuevoForm.Show();
            Hide();

        }

        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin nuevoForm = new FrmLoginAdmin();
            nuevoForm.Show();
            Hide();
        }

        private void BtnLoginArbitro_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin nuevoForm = new FrmLoginAdmin();
            nuevoForm.Show();
            Hide();
        }

        private void PicArbitro_Click(object sender, EventArgs e)
        {
            FrmLoginArbitro nuevoform = new FrmLoginArbitro();
            nuevoform.Show();
            Hide();
        }

        private void PicEquipo_Click(object sender, EventArgs e)
        {
            FrmLoginEquipo nuevoform = new FrmLoginEquipo();
            nuevoform.Show();
            Hide();
        }

        private void BtnLoginEquipo_Click(object sender, EventArgs e)
        {
            FrmLoginEquipo nuevoform = new FrmLoginEquipo();
            nuevoform.Show();
            Hide();
        }

        private void PicGerente_Click(object sender, EventArgs e)
        {
            FrmLoginGerente nuevoform = new FrmLoginGerente();
            nuevoform.Show();
            Hide();
        }

        private void BtnLoginGerente_Click(object sender, EventArgs e)
        {
            FrmLoginGerente nuevoform = new FrmLoginGerente();
            nuevoform.Show();
            Hide();
        }
    }
}
