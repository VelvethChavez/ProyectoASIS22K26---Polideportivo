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
    public partial class frmlogingerente : Form
    {
        public frmlogingerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes nuevoform = new Reportes();
            nuevoform.Show();
            Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin nuevoform = new frmLogin();
            nuevoform.Show();
            Hide();
        }
    }
}
