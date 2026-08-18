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
    public partial class FrmEstadoPartido : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _modoGuardado;
        private int _idEstadoPartido;

        public FrmEstadoPartido()
        {
            InitializeComponent();
        }

        private void frmEstado_Partido_Load(object sender, EventArgs e)
        {
            DgvEstados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEstados.MultiSelect = false;
            DgvEstados.ReadOnly = true;

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
                new FrmMenu().Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEstados("%" + TxtBuscar.Text.Trim() + "%");
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _idEstadoPartido = 0;
            _modoGuardado = ModoNuevo;

            TxtNombreEstado.Clear();
            RtbTxtDescripcion.Clear();

            TxtNombreEstado.Enabled = true;
            RtbTxtDescripcion.Enabled = true;
            BtnGuardar.Enabled = true;

            TxtNombreEstado.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (DgvEstados.CurrentRow == null || DgvEstados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idEstadoPartido = Convert.ToInt32(DgvEstados.CurrentRow.Cells[0].Value);
            _modoGuardado = 0;

            TxtNombreEstado.Text = DgvEstados.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            RtbTxtDescripcion.Text = DgvEstados.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            TxtNombreEstado.Enabled = false;
            RtbTxtDescripcion.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvEstados.CurrentRow == null || DgvEstados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idEstadoPartido = Convert.ToInt32(DgvEstados.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            TxtNombreEstado.Text = DgvEstados.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            RtbTxtDescripcion.Text = DgvEstados.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            TxtNombreEstado.Enabled = true;
            RtbTxtDescripcion.Enabled = true;
            BtnGuardar.Enabled = true;

            TxtNombreEstado.Focus();
        }






        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void CargarEstados(string filtro)
        {
            DgvEstados.DataSource = new CEstadoPartido().Listado_Estados(filtro);

            if (DgvEstados.Columns.Count >= 3)
            {
                DgvEstados.Columns[0].Width = 70;
                DgvEstados.Columns[0].HeaderText = "ID ESTADO";
                DgvEstados.Columns[1].Width = 200;
                DgvEstados.Columns[1].HeaderText = "NOMBRE ESTADO";
                DgvEstados.Columns[2].Width = 345;
                DgvEstados.Columns[2].HeaderText = "DESCRIPCIÓN";
            }
        }

        private void RestablecerVista()
        {
            _idEstadoPartido = 0;
            _modoGuardado = 0;

            TxtNombreEstado.Clear();
            RtbTxtDescripcion.Clear();

            TxtNombreEstado.Enabled = false;
            RtbTxtDescripcion.Enabled = false;

            BtnGuardar.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            _idEstadoPartido = 0;
            _modoGuardado = ModoNuevo;

            TxtNombreEstado.Clear();
            RtbTxtDescripcion.Clear();

            TxtNombreEstado.Enabled = true;
            RtbTxtDescripcion.Enabled = true;

            BtnGuardar.Enabled = true;

            TxtNombreEstado.Focus();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreEstado.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombreEstado.Focus();
                return;
            }

            string respuesta = new CEstadoPartido().Guardar_Estado(
                _modoGuardado,
                TxtNombreEstado.Text.Trim(),
                RtbTxtDescripcion.Text.Trim(),
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
            var grid = DgvEstados;

            if (grid.CurrentRow == null || grid.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _idEstadoPartido = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);


            _modoGuardado = ModoActualizar;

            TxtNombreEstado.Text = grid.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            RtbTxtDescripcion.Text = grid.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            TxtNombreEstado.Enabled = true;
            RtbTxtDescripcion.Enabled = true;
            BtnGuardar.Enabled = true;

            TxtNombreEstado.Focus();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            var grid = DgvEstados;

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
            FrmCompeticiones nuevoForm =new FrmCompeticiones();
            nuevoForm.Show();
            this.Hide();
        }
    }
}