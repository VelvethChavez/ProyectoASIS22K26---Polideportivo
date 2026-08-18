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
    public partial class FrmCompeticiones : Form
    {
        public FrmCompeticiones()
        {
            InitializeComponent();
        }

        private void LblUSUARIOS_Click(object sender, EventArgs e)
        {

        }

        private void Lbl4_Click(object sender, EventArgs e)
        {

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            FrmEstadoPartido nuevoForm = new FrmEstadoPartido();
            nuevoForm.Show();
            Hide();
        }

        private void BtnCompetencias_Click(object sender, EventArgs e)
        {
            FrmCampo nuevoForm = new FrmCampo();
            nuevoForm.Show();
            Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {

            FrmArbitro nuevoForm = new FrmArbitro();
            nuevoForm.Show();
            Hide();

        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            FrmJornada nuevoForm = new FrmJornada();
            nuevoForm.Show();
            Hide();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            FrmProgramarPartido nuevoForm = new FrmProgramarPartido();
            nuevoForm.Show();
            Hide();


        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            FrmMenu newform = new FrmMenu();
            newform.Show();
            this.Hide();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoForm = new FrmMenu();
            nuevoForm.Show();
            this.Hide();

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            FrmRegistrarResultado nuevoForm = new FrmRegistrarResultado();
            nuevoForm.Show();
            this.Hide();
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            FrmTablaPosiciones nuevoForm = new FrmTablaPosiciones();
            nuevoForm.Show();
            this.Hide();
        }

        private void FrmCompeticiones_Load(object sender, EventArgs e)
        {

        }
    }
}
