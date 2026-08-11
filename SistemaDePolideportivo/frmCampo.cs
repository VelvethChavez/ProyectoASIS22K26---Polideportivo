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
        // ============================================================
        // MODOS
        // ============================================================
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        // ============================================================
        // VARIABLES
        // ============================================================
        private int _idCampo = 0;
        private int _modoGuardado = 0;


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public frmCampo()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void frmCampo_Load(object sender, EventArgs e)
        {
            CargarTiposCampo();

            CargarCampos("%");

            RestablecerVista();
        }


        // ============================================================
        // CARGAR TIPOS DE CAMPO EN COMBOBOX
        // ============================================================
        private void CargarTiposCampo()
        {
            DataTable tabla =
                new CCampo().Listado_TiposCampo();

            cmbTipoCampo.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                cmbTipoCampo.DataSource = tabla;

                cmbTipoCampo.DisplayMember =
                    "nombre_tipo";

                cmbTipoCampo.ValueMember =
                    "id_tipo_campo";

                cmbTipoCampo.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(
                    "No existen tipos de campo registrados en la base de datos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // ============================================================
        // CARGAR CAMPOS EN DATAGRIDVIEW
        // ============================================================
        private void CargarCampos(string filtro)
        {
            dgvCampos.DataSource =
                new CCampo().Listado_Campos(filtro);

            if (dgvCampos.Columns.Count >= 6)
            {
                // ID
                dgvCampos.Columns[0].Width = 70;
                dgvCampos.Columns[0].HeaderText =
                    "ID CAMPO";

                // Nombre
                dgvCampos.Columns[1].Width = 180;
                dgvCampos.Columns[1].HeaderText =
                    "NOMBRE DEL CAMPO";

                // Ubicación
                dgvCampos.Columns[2].Width = 150;
                dgvCampos.Columns[2].HeaderText =
                    "UBICACIÓN";

                // Capacidad
                dgvCampos.Columns[3].Width = 100;
                dgvCampos.Columns[3].HeaderText =
                    "CAPACIDAD";

                // ID Tipo
                dgvCampos.Columns[4].Visible = false;

                // Nombre Tipo
                dgvCampos.Columns[5].Width = 180;
                dgvCampos.Columns[5].HeaderText =
                    "TIPO DE CAMPO";
            }
        }


        // ============================================================
        // RESTABLECER VISTA
        // ============================================================
        private void RestablecerVista()
        {
            _idCampo = 0;
            _modoGuardado = 0;

            txtNombreCampo.Clear();
            txtUbicacion.Clear();
            txtCapacidad.Clear();

            cmbTipoCampo.SelectedIndex = -1;

            txtNombreCampo.Enabled = false;
            txtUbicacion.Enabled = false;
            txtCapacidad.Enabled = false;

            cmbTipoCampo.Enabled = false;

            btnGuardar.Enabled = false;

            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idCampo = 0;
            _modoGuardado = ModoNuevo;

            txtNombreCampo.Clear();
            txtUbicacion.Clear();
            txtCapacidad.Clear();

            cmbTipoCampo.SelectedIndex = -1;

            txtNombreCampo.Enabled = true;
            txtUbicacion.Enabled = true;
            txtCapacidad.Enabled = true;

            cmbTipoCampo.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombreCampo.Focus();
        }


        // ============================================================
        // GUARDAR
        // ============================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // --------------------------------------------------------
            // VALIDAR NOMBRE
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtNombreCampo.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreCampo.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR UBICACIÓN
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show(
                    "Ingrese la ubicación del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR CAPACIDAD
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show(
                    "Ingrese la capacidad del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCapacidad.Focus();
                return;
            }


            int capacidad;

            if (!int.TryParse(
                txtCapacidad.Text.Trim(),
                out capacidad))
            {
                MessageBox.Show(
                    "La capacidad debe ser un número entero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCapacidad.Focus();
                return;
            }


            if (capacidad <= 0)
            {
                MessageBox.Show(
                    "La capacidad debe ser mayor que cero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCapacidad.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR TIPO DE CAMPO
            // --------------------------------------------------------
            if (cmbTipoCampo.SelectedIndex == -1 ||
                cmbTipoCampo.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el tipo de campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTipoCampo.Focus();
                return;
            }


            // --------------------------------------------------------
            // OBTENER ID DEL TIPO DE CAMPO
            // --------------------------------------------------------
            int idTipoCampo;

            try
            {
                idTipoCampo =
                    Convert.ToInt32(
                        cmbTipoCampo.SelectedValue);
            }
            catch
            {
                MessageBox.Show(
                    "No se pudo obtener el tipo de campo seleccionado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            // --------------------------------------------------------
            // ASEGURAR MODO
            // --------------------------------------------------------
            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }


            // --------------------------------------------------------
            // GUARDAR
            // --------------------------------------------------------
            CCampo campo = new CCampo();

            string respuesta =
                campo.Guardar_Campo(
                    _modoGuardado,
                    txtNombreCampo.Text.Trim(),
                    txtUbicacion.Text.Trim(),
                    capacidad,
                    idTipoCampo,
                    _idCampo
                );


            // --------------------------------------------------------
            // RESPUESTA
            // --------------------------------------------------------
            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "Campo guardado con éxito.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCampos("%");

                RestablecerVista();
            }
            else
            {
                MessageBox.Show(
                    "Error: " + respuesta,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCampos.CurrentRow == null ||
                dgvCampos.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            _idCampo =
                Convert.ToInt32(
                    dgvCampos.CurrentRow.Cells[0].Value);

            _modoGuardado = ModoActualizar;


            // --------------------------------------------------------
            // NOMBRE
            // --------------------------------------------------------
            txtNombreCampo.Text =
                dgvCampos.CurrentRow.Cells[1]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // UBICACIÓN
            // --------------------------------------------------------
            txtUbicacion.Text =
                dgvCampos.CurrentRow.Cells[2]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // CAPACIDAD
            // --------------------------------------------------------
            txtCapacidad.Text =
                dgvCampos.CurrentRow.Cells[3]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // ID TIPO DE CAMPO
            // --------------------------------------------------------
            if (dgvCampos.CurrentRow.Cells[4].Value != null)
            {
                int idTipoCampo =
                    Convert.ToInt32(
                        dgvCampos.CurrentRow.Cells[4].Value);

                cmbTipoCampo.SelectedValue =
                    idTipoCampo;
            }


            // --------------------------------------------------------
            // HABILITAR CONTROLES
            // --------------------------------------------------------
            txtNombreCampo.Enabled = true;
            txtUbicacion.Enabled = true;
            txtCapacidad.Enabled = true;

            cmbTipoCampo.Enabled = true;

            btnGuardar.Enabled = true;

            txtNombreCampo.Focus();
        }


      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }



        private void dgvCampos_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }




        private void BtnMenu_Click(object sender, EventArgs e)
        {
            frmCompeticiones nuevoform =
               new frmCompeticiones();

            nuevoform.Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCampos.CurrentRow == null ||
                            dgvCampos.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            int idCampo =
                Convert.ToInt32(
                    dgvCampos.CurrentRow.Cells[0].Value);


            string nombreCampo =
                dgvCampos.CurrentRow.Cells[1]
                .Value?.ToString() ?? "";


            DialogResult confirmacion =
                MessageBox.Show(
                    "¿Desea eliminar el campo \"" +
                    nombreCampo +
                    "\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (confirmacion != DialogResult.Yes)
            {
                return;
            }


            string respuesta =
                new CCampo().Eliminar_Campo(idCampo);


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "El campo ha sido eliminado correctamente.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCampos("%");

                RestablecerVista();
            }
            else
            {
                MessageBox.Show(
                    respuesta,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}