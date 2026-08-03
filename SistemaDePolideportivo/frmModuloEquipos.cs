using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class frmModuloEquipos : Form
    {
        public frmModuloEquipos()
        {
            InitializeComponent();

            btnEquipos.Click += btnEquipos_Click;
            btnEntrenadores.Click += btnEntrenadores_Click;
            btnJugadores.Click += btnJugadores_Click;
            btnPosiciones.Click += btnPosiciones_Click;
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.FormClosed += FormularioSecundario_FormClosed;
            formulario.Show();
            Hide();
        }

        private void FormularioSecundario_FormClosed(
            object? sender,
            FormClosedEventArgs e)
        {
            Show();
        }

        private void btnEquipos_Click(object? sender, EventArgs e)
        {
            AbrirFormulario(new frmEquipos());
        }

        private void btnEntrenadores_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "El formulario de entrenadores todavía no ha sido creado.",
                "Módulo de equipos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnJugadores_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "El formulario de jugadores todavía no ha sido creado.",
                "Módulo de equipos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPosiciones_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "El formulario de posiciones todavía no ha sido creado.",
                "Módulo de equipos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}