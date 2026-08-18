using ProyectoASIS22K26___Polideportivo;
using System;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmModuloEquipos : Form
    {
        public FrmModuloEquipos()
        {
            InitializeComponent();

            BtnEquipos.Click += BtnEquipos_Click;
            BtnEntrenadores.Click += BtnEntrenadores_Click;
            BtnJugadores.Click += BtnJugadores_Click;
            BtnPosiciones.Click += BtnPosiciones_Click;
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

        private void BtnEquipos_Click(object? sender, EventArgs e)
        {
            AbrirFormulario(new FrmEquipos());
        }

        private void BtnEntrenadores_Click(object? sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntrenadores());
        }

        private void BtnJugadores_Click(object? sender, EventArgs e)
        {
            AbrirFormulario(new FrmJugadores());
        }

        private void BtnPosiciones_Click(object? sender, EventArgs e)
        {
            AbrirFormulario(new FrmPosiciones());
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
        }

        private void BtnEquipos_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnJugadores_Click_1(object sender, EventArgs e)
        {
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoform = new FrmMenu();
            nuevoform.Show();
            Hide();
        }
    }
}