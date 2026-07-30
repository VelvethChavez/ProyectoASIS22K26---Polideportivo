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
    public partial class frmCampo : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _modoGuardado;
        private int _idCampo;

        public frmCampo()
        {
            InitializeComponent();
        }

        private void frmCampo_Load(object sender, EventArgs e)
        {
            dgvCampos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCampos.MultiSelect = false;
            dgvCampos.ReadOnly = true;

            CargarCampos("%");
            RestablecerVista();
        }

        private void frmCampo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
            else
            {
                new frmMenú().Show();
            }
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCampos.CurrentRow == null || dgvCampos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idCampo = Convert.ToInt32(dgvCampos.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtNombreCampo.Text = dgvCampos.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtTipoCampo.Text = dgvCampos.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            txtNombreCampo.Enabled = true;
            txtTipoCampo.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombreCampo.Focus();
        }

      


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreCampo.Text))
            {
                MessageBox.Show("Ingrese el nombre del campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int.TryParse(txtCapacidad.Text, out int capacidad);

            int idTipoCampo = int.TryParse(txtTipoCampo.Text, out int parsedTipo) ? parsedTipo : 1;


            var campo = new CCampo();
            string respuesta = campo.Guardar_Campo(
                _modoGuardado,
                txtNombreCampo.Text.Trim(),
               txtTipoCampo.Text.Trim(),
                capacidad,
                idTipoCampo,
                _idCampo
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCampos("%");
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

        private void CargarCampos(string filtro)
        {
            dgvCampos.DataSource = new CCampo().Listado_Campos(filtro);

            if (dgvCampos.Columns.Count >= 3)
            {
                dgvCampos.Columns[0].Width = 70;
                dgvCampos.Columns[0].HeaderText = "ID CAMPO";
                dgvCampos.Columns[1].Width = 200;
                dgvCampos.Columns[1].HeaderText = "NOMBRE CAMPO";
                dgvCampos.Columns[2].Width = 200;
                dgvCampos.Columns[2].HeaderText = "TIPO / DESCRIPCIÓN";
            }
        }

        private void RestablecerVista()
        {
            _idCampo = 0;
            _modoGuardado = 0;

            txtNombreCampo.Clear();
            txtTipoCampo.Clear();

            txtNombreCampo.Enabled = false;
            txtTipoCampo.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCampos.CurrentRow == null || dgvCampos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idCampo = Convert.ToInt32(dgvCampos.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtNombreCampo.Text = dgvCampos.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtTipoCampo.Text = dgvCampos.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            txtNombreCampo.Enabled = true;
            txtTipoCampo.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombreCampo.Focus();
        }

     
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            _idCampo = 0;
            _modoGuardado = ModoNuevo;

            txtNombreCampo.Clear();
            txtTipoCampo.Clear();

            txtNombreCampo.Enabled = true;
            txtTipoCampo.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombreCampo.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCampos.CurrentRow == null || dgvCampos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvCampos.CurrentRow.Cells[0].Value);
            string nombre = dgvCampos.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea eliminar el campo \"" + nombre + "\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CCampo().Eliminar_Campo(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("El campo ha sido eliminado correctamente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCampos("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
