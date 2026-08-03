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
    public partial class frmArbitro : Form
    {

        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idArbitro = 0;
        private int _modoGuardado = 0;

        public frmArbitro()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("Ingrese los nombres del árbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Ingrese los apellidos del árbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }

            var arbitro = new CArbitro();
            string respuesta = arbitro.Guardar_Arbitro(
                _modoGuardado,
                txtNombres.Text.Trim(),
                txtApellidos.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtDeporte.Text.Trim(),
                _idArbitro
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarArbitros("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void CargarArbitros(string filtro)
        {
            dgvArbitros.DataSource = new CArbitro().Listado_Arbitros(filtro);

            if (dgvArbitros.Columns.Count >= 5)
            {
                dgvArbitros.Columns[0].Width = 70;
                dgvArbitros.Columns[0].HeaderText = "ID ÁRBITRO";

                dgvArbitros.Columns[1].Width = 150;
                dgvArbitros.Columns[1].HeaderText = "NOMBRES";

                dgvArbitros.Columns[2].Width = 150;
                dgvArbitros.Columns[2].HeaderText = "APELLIDOS";

                dgvArbitros.Columns[3].Width = 100;
                dgvArbitros.Columns[3].HeaderText = "TELÉFONO";

                dgvArbitros.Columns[4].Width = 120;
                dgvArbitros.Columns[4].HeaderText = "DEPORTE / ESPECIALIDAD";
            }
        }

        private void RestablecerVista()
        {
            _idArbitro = 0;
            _modoGuardado = 0;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDeporte.Clear();

            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDeporte.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }






        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("Ingrese el nombre del árbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }

            var arbitro = new CArbitro();
            string respuesta = arbitro.Guardar_Arbitro(
                _modoGuardado,
                txtNombres.Text.Trim(),
                txtApellidos.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtDeporte.Text.Trim(),
                _idArbitro
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarArbitros("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvArbitros.CurrentRow == null || dgvArbitros.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvArbitros.CurrentRow.Cells[0].Value);
            string nombreCompleto = (dgvArbitros.CurrentRow.Cells[1].Value?.ToString() + " " + dgvArbitros.CurrentRow.Cells[2].Value?.ToString()).Trim();

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea eliminar al árbitro \"" + nombreCompleto + "\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CArbitro().Eliminar_Arbitro(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("El árbitro ha sido eliminado correctamente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarArbitros("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvArbitros.CurrentRow == null || dgvArbitros.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idArbitro = Convert.ToInt32(dgvArbitros.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtNombres.Text = dgvArbitros.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtApellidos.Text = dgvArbitros.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtTelefono.Text = dgvArbitros.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
            txtDeporte.Text = dgvArbitros.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;

            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtDeporte.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombres.Focus();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _idArbitro = 0;
            _modoGuardado = ModoNuevo;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDeporte.Clear();

            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtDeporte.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombres.Focus();
        }

        private void frmArbitro_Load_1(object sender, EventArgs e)
        {
            CargarArbitros("%");
            RestablecerVista();
        }

        private void dgvArbitros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}