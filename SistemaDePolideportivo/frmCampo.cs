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
    public partial class FrmCampo : Form
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
        public FrmCampo()
        {
            InitializeComponent();
        }


        // ============================================================
        // LOAD
        // ============================================================
        private void FrmCampo_Load(object sender, EventArgs e)
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

            CmbTipoCampo.DataSource = null;

            if (tabla.Rows.Count > 0)
            {
                CmbTipoCampo.DataSource = tabla;

                CmbTipoCampo.DisplayMember =
                    "nombre_tipo";

                CmbTipoCampo.ValueMember =
                    "id_tipo_campo";

                CmbTipoCampo.SelectedIndex = -1;
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
            DgvCampos.DataSource =
                new CCampo().Listado_Campos(filtro);

            if (DgvCampos.Columns.Count >= 6)
            {
                // ID
                DgvCampos.Columns[0].Width = 70;
                DgvCampos.Columns[0].HeaderText =
                    "ID CAMPO";

                // Nombre
                DgvCampos.Columns[1].Width = 180;
                DgvCampos.Columns[1].HeaderText =
                    "NOMBRE DEL CAMPO";

                // Ubicación
                DgvCampos.Columns[2].Width = 150;
                DgvCampos.Columns[2].HeaderText =
                    "UBICACIÓN";

                // Capacidad
                DgvCampos.Columns[3].Width = 100;
                DgvCampos.Columns[3].HeaderText =
                    "CAPACIDAD";

                // ID Tipo
                DgvCampos.Columns[4].Visible = false;

                // Nombre Tipo
                DgvCampos.Columns[5].Width = 180;
                DgvCampos.Columns[5].HeaderText =
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

            TxtNombreCampo.Clear();
            TxtUbicacion.Clear();
            TxtCapacidad.Clear();

            CmbTipoCampo.SelectedIndex = -1;

            TxtNombreCampo.Enabled = false;
            TxtUbicacion.Enabled = false;
            TxtCapacidad.Enabled = false;

            CmbTipoCampo.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }


        // ============================================================
        // NUEVO
        // ============================================================
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _idCampo = 0;
            _modoGuardado = ModoNuevo;

            TxtNombreCampo.Clear();
            TxtUbicacion.Clear();
            TxtCapacidad.Clear();

            CmbTipoCampo.SelectedIndex = -1;

            TxtNombreCampo.Enabled = true;
            TxtUbicacion.Enabled = true;
            TxtCapacidad.Enabled = true;

            CmbTipoCampo.Enabled = true;

            BtnGuardar.Enabled = true;

            TxtNombreCampo.Focus();
        }


        // ============================================================
        // GUARDAR
        // ============================================================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // --------------------------------------------------------
            // VALIDAR NOMBRE
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(TxtNombreCampo.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombreCampo.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR UBICACIÓN
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(TxtUbicacion.Text))
            {
                MessageBox.Show(
                    "Ingrese la ubicación del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtUbicacion.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR CAPACIDAD
            // --------------------------------------------------------
            if (string.IsNullOrWhiteSpace(TxtCapacidad.Text))
            {
                MessageBox.Show(
                    "Ingrese la capacidad del campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCapacidad.Focus();
                return;
            }


            int capacidad;

            if (!int.TryParse(
                TxtCapacidad.Text.Trim(),
                out capacidad))
            {
                MessageBox.Show(
                    "La capacidad debe ser un número entero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCapacidad.Focus();
                return;
            }


            if (capacidad <= 0)
            {
                MessageBox.Show(
                    "La capacidad debe ser mayor que cero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCapacidad.Focus();
                return;
            }


            // --------------------------------------------------------
            // VALIDAR TIPO DE CAMPO
            // --------------------------------------------------------
            if (CmbTipoCampo.SelectedIndex == -1 ||
                CmbTipoCampo.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione el tipo de campo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbTipoCampo.Focus();
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
                        CmbTipoCampo.SelectedValue);
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
                    TxtNombreCampo.Text.Trim(),
                    TxtUbicacion.Text.Trim(),
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
            if (DgvCampos.CurrentRow == null ||
                DgvCampos.CurrentRow.IsNewRow)
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
                    DgvCampos.CurrentRow.Cells[0].Value);

            _modoGuardado = ModoActualizar;


            // --------------------------------------------------------
            // NOMBRE
            // --------------------------------------------------------
            TxtNombreCampo.Text =
                DgvCampos.CurrentRow.Cells[1]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // UBICACIÓN
            // --------------------------------------------------------
            TxtUbicacion.Text =
                DgvCampos.CurrentRow.Cells[2]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // CAPACIDAD
            // --------------------------------------------------------
            TxtCapacidad.Text =
                DgvCampos.CurrentRow.Cells[3]
                .Value?.ToString() ?? "";


            // --------------------------------------------------------
            // ID TIPO DE CAMPO
            // --------------------------------------------------------
            if (DgvCampos.CurrentRow.Cells[4].Value != null)
            {
                int idTipoCampo =
                    Convert.ToInt32(
                        DgvCampos.CurrentRow.Cells[4].Value);

                CmbTipoCampo.SelectedValue =
                    idTipoCampo;
            }


            // --------------------------------------------------------
            // HABILITAR CONTROLES
            // --------------------------------------------------------
            TxtNombreCampo.Enabled = true;
            TxtUbicacion.Enabled = true;
            TxtCapacidad.Enabled = true;

            CmbTipoCampo.Enabled = true;

            BtnGuardar.Enabled = true;

            TxtNombreCampo.Focus();
        }


      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }



        private void DgvCampos_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }




        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmCompeticiones nuevoform =
               new FrmCompeticiones();

            nuevoform.Show();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DgvCampos.CurrentRow == null ||
                            DgvCampos.CurrentRow.IsNewRow)
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
                    DgvCampos.CurrentRow.Cells[0].Value);


            string nombreCampo =
                DgvCampos.CurrentRow.Cells[1]
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