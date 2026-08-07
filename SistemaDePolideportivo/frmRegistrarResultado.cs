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
    public partial class frmRegistrarResultado : Form
    {
        private const int ModoNuevo = 1;
        private const int ModoActualizar = 2;

        private int _idPartido = 0;
        private int _modoGuardado = 0;

        public frmRegistrarResultado()
        {
            InitializeComponent();
        }

        private void frmRegistrarResultado_Load(object sender, EventArgs e)
        {
            CargarResultados("%");
            RestablecerVista();
        }

        private void CargarResultados(string filtro)
        {
            dgvResultados.DataSource = new CResultado().Listado_Resultados(filtro);

            if (dgvResultados.Columns.Count >= 8)
            {
                dgvResultados.Columns[0].Width = 60;
                dgvResultados.Columns[0].HeaderText = "ID";

                dgvResultados.Columns[1].Width = 120;
                dgvResultados.Columns[1].HeaderText = "JORNADA";

                dgvResultados.Columns[2].Width = 130;
                dgvResultados.Columns[2].HeaderText = "EQUIPO LOCAL";

                dgvResultados.Columns[3].Width = 70;
                dgvResultados.Columns[3].HeaderText = "MARC. L";

                dgvResultados.Columns[4].Width = 130;
                dgvResultados.Columns[4].HeaderText = "EQUIPO VISITANTE";

                dgvResultados.Columns[5].Width = 70;
                dgvResultados.Columns[5].HeaderText = "MARC. V";

                dgvResultados.Columns[6].Width = 100;
                dgvResultados.Columns[6].HeaderText = "ESTADO";

                dgvResultados.Columns[7].Width = 90;
                dgvResultados.Columns[7].HeaderText = "FECHA";
            }
        }

        private void RestablecerVista()
        {
            _idPartido = 0;
            _modoGuardado = 0;

            txtPartido.Clear();
            numMarcadorLocal.Value = 0;
            numMarcadorVisitante.Value = 0;
            txtEstado.Text = "Finalizado";

            txtPartido.Enabled = false;
            numMarcadorLocal.Enabled = false;
            numMarcadorVisitante.Enabled = false;
            txtEstado.Enabled = false;

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentRow == null || dgvResultados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvResultados.CurrentRow.Cells[0].Value);
            string local = dgvResultados.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            string visitante = dgvResultados.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Desea eliminar el resultado del partido \"{local} vs {visitante}\" y volverlo a estado Programado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string respuesta = new CResultado().Eliminar_Resultado(id);

            if (respuesta == "OK")
            {
                MessageBox.Show("El resultado ha sido eliminado y el partido regresó a estado Programado.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarResultados("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPartido.Text))
            {
                MessageBox.Show("Ingrese el ID o nombre del Partido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartido.Focus();
                return;
            }

            var resultadoObj = new CResultado();
            string respuesta = resultadoObj.Guardar_Resultado(
                txtPartido.Text.Trim(),
                Convert.ToInt32(numMarcadorLocal.Value),
                Convert.ToInt32(numMarcadorVisitante.Value),
                txtEstado.Text.Trim(),
                _idPartido
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Resultado registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarResultados("%");
                RestablecerVista();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentRow == null || dgvResultados.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro de la tabla.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idPartido = Convert.ToInt32(dgvResultados.CurrentRow.Cells[0].Value);
            _modoGuardado = ModoActualizar;

            string local = dgvResultados.CurrentRow.Cells[2].Value?.ToString() ?? "";
            string visitante = dgvResultados.CurrentRow.Cells[4].Value?.ToString() ?? "";
            txtPartido.Text = $"{_idPartido} - {local} vs {visitante}";

            if (int.TryParse(dgvResultados.CurrentRow.Cells[3].Value?.ToString(), out int marcL))
                numMarcadorLocal.Value = marcL;

            if (int.TryParse(dgvResultados.CurrentRow.Cells[5].Value?.ToString(), out int marcV))
                numMarcadorVisitante.Value = marcV;

            txtEstado.Text = dgvResultados.CurrentRow.Cells[6].Value?.ToString() ?? "Finalizado";

            txtPartido.Enabled = true;
            numMarcadorLocal.Enabled = true;
            numMarcadorVisitante.Enabled = true;
            txtEstado.Enabled = true;

            btnGuardar.Enabled = true;
            numMarcadorLocal.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idPartido = 0;
            _modoGuardado = ModoNuevo;

            txtPartido.Clear();
            numMarcadorLocal.Value = 0;
            numMarcadorVisitante.Value = 0;
            txtEstado.Text = "Finalizado";

            txtPartido.Enabled = true;
            numMarcadorLocal.Enabled = true;
            numMarcadorVisitante.Enabled = true;
            txtEstado.Enabled = true;

            btnGuardar.Enabled = true;
            txtPartido.Focus();
        }
    }
}
