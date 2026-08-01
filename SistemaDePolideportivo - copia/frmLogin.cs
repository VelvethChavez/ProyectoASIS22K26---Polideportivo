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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var menu = new frmMenú();
            menu.FormClosed += (s, args) => Application.Exit();
            menu.Show();
            Hide();
        }
    }
}
