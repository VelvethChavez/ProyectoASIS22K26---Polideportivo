using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
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
    public partial class frmCampeonato : Form
    {
        public frmCampeonato()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmCampeonato_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón "Nuevo"
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void BtnDeportes_Click(object sender, EventArgs e)
        {
            frmDeportes nuevoForm = new frmDeportes();
            nuevoForm.Show();
            this.Hide();
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            frmEstadoCampeonato nuevoForm = new frmEstadoCampeonato();
            nuevoForm.Show();
            this.Hide();

        }

        private void BtnTipoCampeonato_Click(object sender, EventArgs e)
        {
            TipoCampeonato nuevoForm = new TipoCampeonato();
            nuevoForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmMenú newform = new frmMenú();
            newform.Show();
            this.Hide();
        }
    }
}