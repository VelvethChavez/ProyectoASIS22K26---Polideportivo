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
    public partial class FrmArbitro : Form
    {

        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;


        private int _idArbitro = 0;
        private int _modoGuardado = 0;


        public FrmArbitro()
        {
            InitializeComponent();
        }


        private void FrmArbitro_Load_1(object sender, EventArgs e)
        {
            CargarDeportes();
            CargarArbitros("%");
            RestablecerVista();
        }


        private void CargarDeportes()
        {
            CmbDeporte.Items.Clear();

            CmbDeporte.Items.Add("Fútbol");
            CmbDeporte.Items.Add("Baloncesto");
            CmbDeporte.Items.Add("Voleibol");
            CmbDeporte.Items.Add("Tenis Individual");

            CmbDeporte.SelectedIndex = -1;
        }


        private void CargarArbitros(string filtro)
        {
            DgvArbitros.DataSource =
                new CArbitro().Listado_Arbitros(filtro);

            if (DgvArbitros.Columns.Count >= 5)
            {
                DgvArbitros.Columns[0].Width = 70;
                DgvArbitros.Columns[0].HeaderText = "ID ÁRBITRO";

                DgvArbitros.Columns[1].Width = 150;
                DgvArbitros.Columns[1].HeaderText = "NOMBRES";

                DgvArbitros.Columns[2].Width = 150;
                DgvArbitros.Columns[2].HeaderText = "APELLIDOS";

                DgvArbitros.Columns[3].Width = 100;
                DgvArbitros.Columns[3].HeaderText = "TELÉFONO";

                DgvArbitros.Columns[4].Width = 150;
                DgvArbitros.Columns[4].HeaderText = "DEPORTE";
            }
        }


        private void RestablecerVista()
        {
            _idArbitro = 0;
            _modoGuardado = 0;

            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();

            CmbDeporte.SelectedIndex = -1;

            TxtNombres.Enabled = false;
            TxtApellidos.Enabled = false;
            TxtTelefono.Enabled = false;
            CmbDeporte.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;

            if (DgvArbitros.DataSource != null)
            {
                DgvArbitros.ClearSelection();
            }
        }


        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            _idArbitro = 0;
            _modoGuardado = ModoNuevo;

            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();

            CmbDeporte.SelectedIndex = -1;

            TxtNombres.Enabled = true;
            TxtApellidos.Enabled = true;
            TxtTelefono.Enabled = true;
            CmbDeporte.Enabled = true;

            BtnGuardar.Enabled = true;

            TxtNombres.Focus();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtNombres.Text))
            {
                MessageBox.Show(
                    "Ingrese los nombres del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombres.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtApellidos.Text))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidos.Focus();
                return;
            }


            if (CmbDeporte.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el deporte del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbDeporte.Focus();
                return;
            }


            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }


            var arbitro = new CArbitro();

            string respuesta = arbitro.Guardar_Arbitro(
                _modoGuardado,
                TxtNombres.Text.Trim(),
                TxtApellidos.Text.Trim(),
                TxtTelefono.Text.Trim(),
                CmbDeporte.Text.Trim(),
                _idArbitro
            );


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "Registro guardado con éxito.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarArbitros("%");

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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }


        private void BtnEditar_Click_1(object sender, EventArgs e)
        {

            if (DgvArbitros.CurrentRow == null ||
                DgvArbitros.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            _idArbitro = Convert.ToInt32(
                DgvArbitros.CurrentRow.Cells[0].Value);

            _modoGuardado = ModoActualizar;


            TxtNombres.Text =
                DgvArbitros.CurrentRow.Cells[1]
                .Value?.ToString() ?? string.Empty;

            TxtApellidos.Text =
                DgvArbitros.CurrentRow.Cells[2]
                .Value?.ToString() ?? string.Empty;

            TxtTelefono.Text =
                DgvArbitros.CurrentRow.Cells[3]
                .Value?.ToString() ?? string.Empty;

            CmbDeporte.Text =
                DgvArbitros.CurrentRow.Cells[4]
                .Value?.ToString() ?? string.Empty;


            TxtNombres.Enabled = true;
            TxtApellidos.Enabled = true;
            TxtTelefono.Enabled = true;
            CmbDeporte.Enabled = true;

            BtnGuardar.Enabled = true;

            TxtNombres.Focus();
        }


        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {

            if (DgvArbitros.CurrentRow == null ||
                DgvArbitros.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro de la tabla.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            int id = Convert.ToInt32(
                DgvArbitros.CurrentRow.Cells[0].Value);


            string nombres =
                DgvArbitros.CurrentRow.Cells[1]
                .Value?.ToString() ?? string.Empty;

            string apellidos =
                DgvArbitros.CurrentRow.Cells[2]
                .Value?.ToString() ?? string.Empty;

            string nombreCompleto =
                (nombres + " " + apellidos).Trim();


            DialogResult confirmacion =
                MessageBox.Show(
                    "¿Desea eliminar al árbitro \"" +
                    nombreCompleto +
                    "\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }


            string respuesta =
                new CArbitro().Eliminar_Arbitro(id);

            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "El árbitro ha sido eliminado correctamente.",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarArbitros("%");

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


        private void DgvArbitros_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        private void BtnRegresarMenuCompeticiones_Click(
            object sender,
            EventArgs e)
        {
            FrmCompeticiones nuevoform =
                new FrmCompeticiones();

            nuevoform.Show();

            Hide();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombres.Text))
            {
                MessageBox.Show(
                    "Ingrese los nombres del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtNombres.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtApellidos.Text))
            {
                MessageBox.Show(
                    "Ingrese los apellidos del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtApellidos.Focus();
                return;
            }


            if (CmbDeporte.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el deporte del árbitro.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbDeporte.Focus();
                return;
            }


            if (_modoGuardado == 0)
            {
                _modoGuardado = ModoNuevo;
            }


            var arbitro = new CArbitro();

            string respuesta = arbitro.Guardar_Arbitro(
                _modoGuardado,
                TxtNombres.Text.Trim(),
                TxtApellidos.Text.Trim(),
                TxtTelefono.Text.Trim(),
                CmbDeporte.Text.Trim(),
                _idArbitro
            );


            if (respuesta == "OK")
            {
                MessageBox.Show(
                    "Registro guardado con éxito.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarArbitros("%");

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
    }
}