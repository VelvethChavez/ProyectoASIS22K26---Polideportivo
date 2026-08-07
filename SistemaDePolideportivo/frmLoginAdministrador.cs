using ProyectoASIS22K26___Polideportivo;
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
    public partial class frmLoginAdministrador : Form
    {
        public frmLoginAdministrador()
        {
            InitializeComponent();
        }

        private void frmLoginAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegrear_Click(object sender, EventArgs e)
        {
            frmLogin nuevoform = new frmLogin();
            nuevoform.Show();
            Hide();
        }

        private void LblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmMenú nuevoform = new frmMenú();
            nuevoform.Show();
            Hide();
        }
    }
}
