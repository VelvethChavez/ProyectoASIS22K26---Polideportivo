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

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenú newform = new frmMenú();
            newform.Show();
            this.Hide();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmMenú nuevoForm = new frmMenú();
            nuevoForm.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRegistrarResultado nuevoForm = new frmRegistrarResultado();
            nuevoForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmTablaPosiciones nuevoForm = new frmTablaPosiciones();
            nuevoForm.Show();
            this.Hide();
        }

        private void frmCompeticiones_Load(object sender, EventArgs e)
        {

        }
    }
}
