using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDePolideportivo
{
    public partial class frmEstadoPartido : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _modoGuardado;
        private int _idEstadoPartido;

        public frmEstadoPartido()
        {
            InitializeComponent();
        }

        private void frmEstado_Partido_Load(object sender, EventArgs e)
        {
            dgvEstados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstados.MultiSelect = false;
            dgvEstados.ReadOnly = true;

            CargarEstados("%");
            RestablecerVista();
        }

        private void frmEstado_Partido_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEstados("%" + txtBuscar.Text.Trim() + "%");
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idEstadoPartido = 0;
            _modoGuardado = ModoNuevo;

            txtNombreEstado.Clear();
            txtDescripcion.Clear();

            txtNombreEstado.Enabled = true;
            txtDescripcion.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombreEstado.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (dgvEstados.CurrentRow == null || dgvEstados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idEstadoPartido = Convert.ToInt32(dgvEstados.CurrentRow.Cells[0].Value);
            _modoGuardado = 0;

            txtNombreEstado.Text = dgvEstados.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtDescripcion.Text = dgvEstados.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            txtNombreEstado.Enabled = false;
            txtDescripcion.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstados.CurrentRow == null || dgvEstados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idEstadoPartido = Convert.ToInt32(dgvEstados.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            txtNombreEstado.Text = dgvEstados.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtDescripcion.Text = dgvEstados.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            txtNombreEstado.Enabled = true;
            txtDescripcion.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombreEstado.Focus();
        }






        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void CargarEstados(string filtro)
        {
            dgvEstados.DataSource = new CEstadoPartido().Listado_Estados(filtro);

            if (dgvEstados.Columns.Count >= 3)
            {
                dgvEstados.Columns[0].Width = 70;
                dgvEstados.Columns[0].HeaderText = "ID ESTADO";
                dgvEstados.Columns[1].Width = 200;
                dgvEstados.Columns[1].HeaderText = "NOMBRE ESTADO";
                dgvEstados.Columns[2].Width = 345;
                dgvEstados.Columns[2].HeaderText = "DESCRIPCIÓN";
            }
        }

        private void RestablecerVista()
        {
            _idEstadoPartido = 0;
            _modoGuardado = 0;

            txtNombreEstado.Clear();
            txtDescripcion.Clear();

            txtNombreEstado.Enabled = false;
            txtDescripcion.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _idEstadoPartido = 0;
            _modoGuardado = ModoNuevo;

            txtNombreEstado.Clear();
            txtDescripcion.Clear();

            txtNombreEstado.Enabled = true;
            txtDescripcion.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombreEstado.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEstado.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreEstado.Focus();
                return;
            }

            string respuesta = new CEstadoPartido().Guardar_Estado(
                _modoGuardado,
                txtNombreEstado.Text.Trim(),
                txtDescripcion.Text.Trim(),
                _idEstadoPartido);

            if (respuesta == "OK")
            {
                string mensaje = _modoGuardado == ModoActualizar
                    ? "El estado ha sido actualizado correctamente."
                    : "El estado ha sido guardado correctamente.";

                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstados("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var grid = dgvEstados;

            if (grid.CurrentRow == null || grid.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _idEstadoPartido = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);


            _modoGuardado = ModoActualizar;

            txtNombreEstado.Text = grid.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtDescripcion.Text = grid.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            txtNombreEstado.Enabled = true;
            txtDescripcion.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombreEstado.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var grid = dgvEstados;

            if (grid.CurrentRow == null || grid.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);
            string nombre = grid.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea eliminar el estado \"" + nombre + "\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CEstadoPartido().Eliminar_Estado(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("El estado ha sido eliminado correctamente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstados("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmCompeticiones nuevoForm =new frmCompeticiones();
            nuevoForm.Show();
            this.Hide();
        }
    }
}