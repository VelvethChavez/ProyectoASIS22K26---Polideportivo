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
    public partial class frmCompeticiones : Form
    {
        public frmCompeticiones()
        {
            InitializeComponent();
        }

        private void USUARIOS_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEstadoPartido nuevoForm = new frmEstadoPartido();
            nuevoForm.Show();
            Hide();
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            frmCampo nuevoForm = new frmCampo();
            nuevoForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmArbitro nuevoForm = new frmArbitro();
            nuevoForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJornada nuevoForm = new frmJornada();
            nuevoForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmProgramarPartido nuevoForm = new frmProgramarPartido();
            nuevoForm.Show();
            Hide();
        }
    }
}
