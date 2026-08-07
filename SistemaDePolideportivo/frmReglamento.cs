using System;
using System.Windows.Forms;

namespace ProyectoASIS22K26___Polideportivo
{
    public partial class frmReglamento : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _modoGuardado;
        private int _idRegla;

        public frmReglamento()
        {
            InitializeComponent();
        }

        private void frmReglamento_Load(object sender, EventArgs e)
        {
              dgvReglas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReglas.MultiSelect = false;
            dgvReglas.ReadOnly = true;

            CargarReglas("%");
            cboDeporte.Items.Insert(0, "Eliga un deporte ...");
            cboDeporte.SelectedIndex = 0;
            ConfigurarBotonesCrud(false);
        }

        private void frmReglamento_FormClosed(object sender, FormClosedEventArgs e)
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
            CargarReglas("%" + txtBuscar.Text.Trim() + "%");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idRegla = 0;
            _modoGuardado = ModoNuevo;
            LimpiarCampos();
            ConfigurarCampos(true);
            ConfigurarBotonesEdicion(true);
            ConfigurarBotonesCrud(false);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (!TryObtenerRegistroSeleccionado(out int id, out string nombre, out string descripcion))
            {
                return;
            }

            _idRegla = id;
            _modoGuardado = 0;
            txtNombreRegla.Text = nombre;
            txtDescripcion.Text = descripcion;
            ConfigurarCampos(false);
            ConfigurarBotonesEdicion(false);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!TryObtenerRegistroSeleccionado(out int id, out string nombre, out string descripcion))
            {
                return;
            }

            _idRegla = id;
            _modoGuardado = ModoActualizar;
            txtNombreRegla.Text = nombre;
            txtDescripcion.Text = descripcion;
            ConfigurarCampos(true);
            ConfigurarBotonesEdicion(true);
            ConfigurarBotonesCrud(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!TryObtenerRegistroSeleccionado(out int id, out string nombre, out _))
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea eliminar la sanción \"" + nombre + "\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            string respuesta = new CReglas().Eliminar_Regla(id);

            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "El registro ha sido eliminado correctamente.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarReglas("%");
                RestablecerFormulario();
            }
            else
            {
                MessageBox.Show(
                    respuesta,
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Guía rápida del módulo de Reglamento:\n\n" +
                "1. Deporte: seleccione un deporte para habilitar las opciones.\n" +
                "2. Nuevo: limpia los campos para registrar una sanción nueva.\n" +
                "3. Leer: muestra en pantalla la sanción seleccionada en la tabla.\n" +
                "4. Actualizar: carga la sanción seleccionada para modificarla.\n" +
                "5. Eliminar: borra la sanción seleccionada (pide confirmación).\n" +
                "6. Buscar: filtra las sanciones por nombre.\n" +
                "7. Guardar: confirma un registro nuevo o los cambios de una actualización.\n" +
                "8. Cancelar: descarta los cambios y restaura el formulario.\n\n" +
                "Tip: haga clic en una fila de la tabla antes de usar Leer, Actualizar o Eliminar.",
                "Ayuda - Reglamento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRegla.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre de la sanción.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string respuesta = new CReglas().Guardar_Reglas(
                _modoGuardado,
                txtNombreRegla.Text.Trim(),
                txtDescripcion.Text.Trim(),
                _idRegla);

            if (respuesta == "OK")
            {
                string mensaje = _modoGuardado == ModoActualizar
                    ? "Los datos han sido actualizados correctamente."
                    : "Los datos han sido guardados correctamente.";

                MessageBox.Show(
                    mensaje,
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarReglas("%");
                RestablecerFormulario();
            }
            else
            {
                MessageBox.Show(
                    respuesta,
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarBotonesCrud(cboDeporte.SelectedIndex > 0);
        }

        private bool TryObtenerRegistroSeleccionado(out int id, out string nombre, out string descripcion)
        {
            id = 0;
            nombre = string.Empty;
            descripcion = string.Empty;

            if (dgvReglas.CurrentRow == null || dgvReglas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            id = Convert.ToInt32(dgvReglas.CurrentRow.Cells[0].Value);
            nombre = dgvReglas.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            descripcion = dgvReglas.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            return true;
        }

        private void CargarReglas(string filtro)
        {
            dgvReglas.DataSource = new CReglas().Listado_Reglas(filtro);
            FormatearGrid();
        }

        private void FormatearGrid()
        {
            if (dgvReglas.Columns.Count < 3)
            {
                return;
            }

            dgvReglas.Columns[0].Width = 50;
            dgvReglas.Columns[0].HeaderText = "ID SANCIÓN";
            dgvReglas.Columns[1].Width = 200;
            dgvReglas.Columns[1].HeaderText = "NOMBRE SANCIÓN";
            dgvReglas.Columns[2].Width = 365;
            dgvReglas.Columns[2].HeaderText = "DESCRIPCIÓN";
        }

        private void ConfigurarCampos(bool habilitados)
        {
            txtNombreRegla.Enabled = habilitados;
            txtDescripcion.Enabled = habilitados;
        }

        private void ConfigurarBotonesEdicion(bool habilitados)
        {
            btnGuardar.Enabled = habilitados;
            btnCancelar.Enabled = habilitados;
        }

        private void ConfigurarBotonesCrud(bool habilitados)
        {
            btnNuevo.Enabled = habilitados;
            btnEliminar.Enabled = habilitados;
            btnLeer.Enabled = habilitados;
            btnActualizar.Enabled = habilitados;
        }

        private void LimpiarCampos()
        {
            txtNombreRegla.Clear();
            txtDescripcion.Clear();
        }

        private void RestablecerFormulario()
        {
            _idRegla = 0;
            _modoGuardado = 0;
            LimpiarCampos();
            ConfigurarCampos(false);
            ConfigurarBotonesEdicion(false);
            ConfigurarBotonesCrud(cboDeporte.SelectedIndex > 0);
        }
    }
}
