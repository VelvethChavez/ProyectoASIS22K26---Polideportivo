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
    public partial class frmJornada : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idJornada = 0;
        private int _modoGuardado = 0;

        public frmJornada()
        {
            InitializeComponent();
        }

        private void frmJornada_Load_1(object sender, EventArgs e)
        {
            CargarJornadas("%");
            RestablecerVista();
        }

        private void CargarJornadas(string filtro)
        {
            dgvJornadas.DataSource = new CJornada().Listado_Jornadas(filtro);

            if (dgvJornadas.Columns.Count >= 5)
            {
                dgvJornadas.Columns[0].Width = 70;
                dgvJornadas.Columns[0].HeaderText = "ID JORNADA";

                dgvJornadas.Columns[1].Width = 150;
                dgvJornadas.Columns[1].HeaderText = "NOMBRE JORNADA";

                dgvJornadas.Columns[2].Width = 70;
                dgvJornadas.Columns[2].HeaderText = "NÚMERO";

                dgvJornadas.Columns[3].Width = 100;
                dgvJornadas.Columns[3].HeaderText = "FECHA";

                dgvJornadas.Columns[4].Width = 180;
                dgvJornadas.Columns[4].HeaderText = "CAMPEONATO";
            }
        }

        private void RestablecerVista()
        {
            _idJornada = 0;
            _modoGuardado = 0;

            txtCampeonato.Clear();
            txtNombreJornada.Clear();
            numNumeroJornada.Value = 1;
            dtpFechaJornada.Value = DateTime.Now;

            txtCampeonato.Enabled = false;
            txtNombreJornada.Enabled = false;
            numNumeroJornada.Enabled = false;
            dtpFechaJornada.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }







        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void dgvJornadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCampeonato.Text))
            {
                MessageBox.Show("Ingrese el ID o Nombre del Campeonato.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCampeonato.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreJornada.Text))
            {
                MessageBox.Show("Ingrese el nombre de la jornada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreJornada.Focus();
                return;
            }

            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }

            var jornada = new CJornada();
            string respuesta = jornada.Guardar_Jornada(
                _modoGuardado,
                txtCampeonato.Text.Trim(), // <--- Le pasas directamente el texto de tu TextBox
                txtNombreJornada.Text.Trim(),
                Convert.ToInt32(numNumeroJornada.Value),
                dtpFechaJornada.Value,
                _idJornada
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJornadas("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJornadas.CurrentRow == null || dgvJornadas.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvJornadas.CurrentRow.Cells[0].Value);
            string nombreJornada = dgvJornadas.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea eliminar la jornada \"" + nombreJornada + "\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CJornada().Eliminar_Jornada(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("La jornada ha sido eliminada correctamente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJornadas("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvJornadas.CurrentRow == null || dgvJornadas.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idJornada = Convert.ToInt32(dgvJornadas.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtNombreJornada.Text = dgvJornadas.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;

            if (int.TryParse(dgvJornadas.CurrentRow.Cells[2].Value?.ToString(), out int numJornada))
            {
                numNumeroJornada.Value = numJornada;
            }

            if (DateTime.TryParse(dgvJornadas.CurrentRow.Cells[3].Value?.ToString(), out DateTime fechaJornada))
            {
                dtpFechaJornada.Value = fechaJornada;
            }

            txtCampeonato.Text = dgvJornadas.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;

            txtCampeonato.Enabled = true;
            txtNombreJornada.Enabled = true;
            numNumeroJornada.Enabled = true;
            dtpFechaJornada.Enabled = true;

            btnGuardar.Enabled = true;

            txtCampeonato.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idJornada = 0;
            _modoGuardado = ModoNuevo;

            txtCampeonato.Clear();
            txtNombreJornada.Clear();
            numNumeroJornada.Value = 1;
            dtpFechaJornada.Value = DateTime.Now;

            txtCampeonato.Enabled = true;
            txtNombreJornada.Enabled = true;
            numNumeroJornada.Enabled = true;
            dtpFechaJornada.Enabled = true;

            btnGuardar.Enabled = true;

            txtCampeonato.Focus();
        }

        private void frmJornada_Load(object sender, EventArgs e)
        {

        }
    }
}