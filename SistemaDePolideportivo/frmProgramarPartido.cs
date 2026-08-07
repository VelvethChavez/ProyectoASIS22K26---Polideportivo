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

    public partial class frmProgramarPartido : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idPartido = 0;
        private int _modoGuardado = 0;

        public frmProgramarPartido()
        {
            InitializeComponent();
        }

        private void frmProgramarPartido_Load(object sender, EventArgs e)
        {
            CargarPartidos("%");
            RestablecerVista();
        }

        private void CargarPartidos(string filtro)
        {
            dgvPartidos.DataSource = new CPartido().Listado_Partidos(filtro);

            if (dgvPartidos.Columns.Count >= 9)
            {
                dgvPartidos.Columns[0].Width = 60;
                dgvPartidos.Columns[0].HeaderText = "ID";

                dgvPartidos.Columns[1].Width = 120;
                dgvPartidos.Columns[1].HeaderText = "JORNADA";

                dgvPartidos.Columns[2].Width = 130;
                dgvPartidos.Columns[2].HeaderText = "LOCAL";

                dgvPartidos.Columns[3].Width = 130;
                dgvPartidos.Columns[3].HeaderText = "VISITANTE";

                dgvPartidos.Columns[4].Width = 120;
                dgvPartidos.Columns[4].HeaderText = "CAMPO";

                dgvPartidos.Columns[5].Width = 130;
                dgvPartidos.Columns[5].HeaderText = "ÁRBITRO";

                dgvPartidos.Columns[6].Width = 90;
                dgvPartidos.Columns[6].HeaderText = "FECHA";

                dgvPartidos.Columns[7].Width = 80;
                dgvPartidos.Columns[7].HeaderText = "HORA";

                dgvPartidos.Columns[8].Width = 100;
                dgvPartidos.Columns[8].HeaderText = "ESTADO";
            }
        }

        private void RestablecerVista()
        {
            _idPartido = 0;
            _modoGuardado = 0;

            txtJornada.Clear();
            txtEquipoLocal.Clear();
            txtEquipoVisitante.Clear();
            txtCampo.Clear();
            txtArbitro.Clear();
            txtEstado.Clear();
            dtpFechaPartido.Value = DateTime.Now;
            dtpHoraPartido.Value = DateTime.Now;

            txtJornada.Enabled = false;
            txtEquipoLocal.Enabled = false;
            txtEquipoVisitante.Enabled = false;
            txtCampo.Enabled = false;
            txtArbitro.Enabled = false;
            txtEstado.Enabled = false;
            dtpFechaPartido.Enabled = false;
            dtpHoraPartido.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }







        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvPartidos.CurrentRow == null || dgvPartidos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvPartidos.CurrentRow.Cells[0].Value);
            string local = dgvPartidos.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            string visitante = dgvPartidos.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Desea eliminar el partido \"{local} vs {visitante}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CPartido().Eliminar_Partido(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("El partido ha sido eliminado correctamente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidos("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJornada.Text))
            {
                MessageBox.Show("Ingrese el ID o Nombre de la Jornada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJornada.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEquipoLocal.Text))
            {
                MessageBox.Show("Ingrese el Equipo Local.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEquipoLocal.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEquipoVisitante.Text))
            {
                MessageBox.Show("Ingrese el Equipo Visitante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEquipoVisitante.Focus();
                return;
            }

            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }

            var partido = new CPartido();
            string respuesta = partido.Guardar_Partido(
                _modoGuardado,
                txtJornada.Text.Trim(),
                txtEquipoLocal.Text.Trim(),
                txtEquipoVisitante.Text.Trim(),
                txtCampo.Text.Trim(),
                txtArbitro.Text.Trim(),
                txtEstado.Text.Trim(),
                dtpFechaPartido.Value,
                dtpHoraPartido.Value.TimeOfDay,
                _idPartido
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Partido guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidos("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _idPartido = 0;
            _modoGuardado = ModoNuevo;

            txtJornada.Clear();
            txtEquipoLocal.Clear();
            txtEquipoVisitante.Clear();
            txtCampo.Clear();
            txtArbitro.Clear();
            txtEstado.Clear();
            dtpFechaPartido.Value = DateTime.Now;
            dtpHoraPartido.Value = DateTime.Now;

            txtJornada.Enabled = true;
            txtEquipoLocal.Enabled = true;
            txtEquipoVisitante.Enabled = true;
            txtCampo.Enabled = true;
            txtArbitro.Enabled = true;
            txtEstado.Enabled = true;
            dtpFechaPartido.Enabled = true;
            dtpHoraPartido.Enabled = true;

            btnGuardar.Enabled = true;

            txtJornada.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPartidos.CurrentRow == null || dgvPartidos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idPartido = Convert.ToInt32(dgvPartidos.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtJornada.Text = dgvPartidos.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtEquipoLocal.Text = dgvPartidos.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtEquipoVisitante.Text = dgvPartidos.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
            txtCampo.Text = dgvPartidos.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;
            txtArbitro.Text = dgvPartidos.CurrentRow.Cells[5].Value?.ToString() ?? string.Empty;

            if (DateTime.TryParse(dgvPartidos.CurrentRow.Cells[6].Value?.ToString(), out DateTime fecha))
            {
                dtpFechaPartido.Value = fecha;
            }

            if (TimeSpan.TryParse(dgvPartidos.CurrentRow.Cells[7].Value?.ToString(), out TimeSpan hora))
            {
                dtpHoraPartido.Value = DateTime.Today.Add(hora);
            }

            txtEstado.Text = dgvPartidos.CurrentRow.Cells[8].Value?.ToString() ?? string.Empty;

            txtJornada.Enabled = true;
            txtEquipoLocal.Enabled = true;
            txtEquipoVisitante.Enabled = true;
            txtCampo.Enabled = true;
            txtArbitro.Enabled = true;
            txtEstado.Enabled = true;
            dtpFechaPartido.Enabled = true;
            dtpHoraPartido.Enabled = true;

            btnGuardar.Enabled = true;

            txtJornada.Focus();
        }

        private void BtnRegresarMenu_Click(object sender, EventArgs e)
        {
            frmCompeticiones nuevoform = new frmCompeticiones();
            nuevoform.Show();
            Hide();
        }
    }
}
