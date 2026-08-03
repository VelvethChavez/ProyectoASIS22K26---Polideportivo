using SistemaDePolideportivo.DAO;
using SistemaDePolideportivo.Modelos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FormEstadistica : Form
    {
        private readonly EstadisticaDAO estadisticaDAO;
        private int idEstadisticaSeleccionada;

        public FormEstadistica()
        {
            InitializeComponent();

            estadisticaDAO = new EstadisticaDAO();
            idEstadisticaSeleccionada = 0;
        }

        //=========================================================
        // CARGAR FORMULARIO
        //=========================================================

        private void FormEstadistica_Load(object sender, EventArgs e)
        {
            try
            {
                CargarJugadores();
                CargarPartidos();
                CargarDeportes();
                ConfigurarCampos();
                CargarEstadisticas();
                AplicarEstiloFormulario();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        //=========================================================
        // CARGAR COMBOBOX
        //=========================================================

        private void CargarJugadores()
        {
            DataTable tablaJugadores = estadisticaDAO.CargarJugadores();

            cmbJugador.DataSource = tablaJugadores;
            cmbJugador.DisplayMember = "jugador";
            cmbJugador.ValueMember = "id_jugador";
            cmbJugador.SelectedIndex = -1;
        }

        private void CargarPartidos()
        {
            DataTable tablaPartidos = estadisticaDAO.CargarPartidos();

            cmbPartido.DataSource = tablaPartidos;
            cmbPartido.DisplayMember = "partido";
            cmbPartido.ValueMember = "id_partido";
            cmbPartido.SelectedIndex = -1;
        }

        private void CargarDeportes()
        {
            cmbDeporte.Items.Clear();

            cmbDeporte.Items.Add("Fútbol");
            cmbDeporte.Items.Add("Baloncesto");
            cmbDeporte.Items.Add("Voleibol");
            cmbDeporte.Items.Add("Tenis");

            cmbDeporte.SelectedIndex = 0;
        }

        //=========================================================
        // CONFIGURAR CAMPOS SEGÚN EL DEPORTE
        //=========================================================

        private void ConfigurarCampos()
        {
            string deporte = cmbDeporte.Text;

            MostrarCampo(lblCampo1, nudCampo1, true);
            MostrarCampo(lblCampo2, nudCampo2, true);
            MostrarCampo(lblCampo3, nudCampo3, true);
            MostrarCampo(lblCampo4, nudCampo4, true);

            switch (deporte)
            {
                case "Fútbol":
                    lblCampo1.Text = "Goles";
                    lblCampo2.Text = "Asistencias";
                    lblCampo3.Text = "Tarjetas Amarillas";
                    lblCampo4.Text = "Tarjetas Rojas";
                    break;

                case "Baloncesto":
                    lblCampo1.Text = "Puntos";
                    lblCampo2.Text = "Asistencias";
                    lblCampo3.Text = "Canastas";

                    MostrarCampo(lblCampo4, nudCampo4, false);
                    break;

                case "Voleibol":
                    lblCampo1.Text = "Puntos";
                    lblCampo2.Text = "Sets Ganados";

                    MostrarCampo(lblCampo3, nudCampo3, false);
                    MostrarCampo(lblCampo4, nudCampo4, false);
                    break;

                case "Tenis":
                    lblCampo1.Text = "Puntos";
                    lblCampo2.Text = "Sets Ganados";

                    MostrarCampo(lblCampo3, nudCampo3, false);
                    MostrarCampo(lblCampo4, nudCampo4, false);
                    break;
            }

            LimpiarCamposEstadisticos();
        }

        private void MostrarCampo(
            Label etiqueta,
            NumericUpDown control,
            bool visible)
        {
            etiqueta.Visible = visible;
            control.Visible = visible;
        }

        // Este es el evento que Visual Studio creó originalmente
        // para el ComboBox de deporte.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarCampos();
        }

        //=========================================================
        // CREAR OBJETO DESDE EL FORMULARIO
        //=========================================================

        private EstadisticaJugador ObtenerDatosFormulario()
        {
            EstadisticaJugador estadistica = new EstadisticaJugador
            {
                IdEstadistica = idEstadisticaSeleccionada,
                IdJugador = Convert.ToInt32(cmbJugador.SelectedValue),
                IdPartido = Convert.ToInt32(cmbPartido.SelectedValue),
                Deporte = cmbDeporte.Text,
                Observaciones = txtObservaciones.Text.Trim()
            };

            switch (estadistica.Deporte)
            {
                case "Fútbol":
                    estadistica.Goles = Convert.ToInt32(nudCampo1.Value);
                    estadistica.AsistenciasFutbol =
                        Convert.ToInt32(nudCampo2.Value);
                    estadistica.TarjetasAmarillas =
                        Convert.ToInt32(nudCampo3.Value);
                    estadistica.TarjetasRojas =
                        Convert.ToInt32(nudCampo4.Value);
                    break;

                case "Baloncesto":
                    estadistica.PuntosBaloncesto =
                        Convert.ToInt32(nudCampo1.Value);
                    estadistica.AsistenciasBaloncesto =
                        Convert.ToInt32(nudCampo2.Value);
                    estadistica.Canastas =
                        Convert.ToInt32(nudCampo3.Value);
                    break;

                case "Voleibol":
                    estadistica.PuntosVoleibol =
                        Convert.ToInt32(nudCampo1.Value);
                    estadistica.SetsGanadosVoleibol =
                        Convert.ToInt32(nudCampo2.Value);
                    break;

                case "Tenis":
                    estadistica.PuntosTenis =
                        Convert.ToInt32(nudCampo1.Value);
                    estadistica.SetsGanadosTenis =
                        Convert.ToInt32(nudCampo2.Value);
                    break;
            }

            return estadistica;
        }

        //=========================================================
        // VALIDACIONES
        //=========================================================

        private bool ValidarFormulario()
        {
            if (cmbJugador.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbJugador.Focus();
                return false;
            }

            if (cmbPartido.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un partido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPartido.Focus();
                return false;
            }

            if (cmbDeporte.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un deporte.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDeporte.Focus();
                return false;
            }

            return true;
        }

        //=========================================================
        // BOTÓN NUEVO
        //=========================================================

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //=========================================================
        // BOTÓN GUARDAR
        //=========================================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                EstadisticaJugador estadistica = ObtenerDatosFormulario();

                bool resultado = estadisticaDAO.Insertar(estadistica);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estadística registrada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarEstadisticas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        //=========================================================
        // BOTÓN EDITAR
        //=========================================================

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idEstadisticaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una estadística en la tabla.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!ValidarFormulario())
                    return;

                EstadisticaJugador estadistica = ObtenerDatosFormulario();

                bool resultado = estadisticaDAO.Actualizar(estadistica);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estadística actualizada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarEstadisticas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        //=========================================================
        // BOTÓN ELIMINAR
        //=========================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idEstadisticaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una estadística en la tabla.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta estadística?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                bool resultado =
                    estadisticaDAO.Eliminar(idEstadisticaSeleccionada);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estadística eliminada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarEstadisticas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        //=========================================================
        // BOTÓN BUSCAR
        //=========================================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    CargarEstadisticas();
                    return;
                }

                dgvEstadisticas.DataSource =
                    estadisticaDAO.Buscar(texto);

                ConfigurarColumnasDataGridView();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarEstadisticas();
            }
        }

        //=========================================================
        // CARGAR DATAGRIDVIEW
        //=========================================================

        private void CargarEstadisticas()
        {
            dgvEstadisticas.DataSource = null;
            dgvEstadisticas.DataSource = estadisticaDAO.Listar();

            ConfigurarColumnasDataGridView();
        }

        private void ConfigurarColumnasDataGridView()
        {
            if (dgvEstadisticas.Columns.Count == 0)
                return;

            OcultarColumna("id_jugador");
            OcultarColumna("id_partido");

            OcultarColumna("goles");
            OcultarColumna("asistencias");
            OcultarColumna("tarjetas_amarillas");
            OcultarColumna("tarjetas_rojas");

            OcultarColumna("puntos_baloncesto");
            OcultarColumna("asistencias_baloncesto");
            OcultarColumna("canastas");

            OcultarColumna("puntos_voleibol");
            OcultarColumna("sets_voleibol");

            OcultarColumna("puntos_tenis");
            OcultarColumna("sets_tenis");

            if (dgvEstadisticas.Columns.Contains("id_estadistica"))
            {
                dgvEstadisticas.Columns["id_estadistica"].HeaderText = "ID";
                dgvEstadisticas.Columns["id_estadistica"].Width = 55;
            }

            if (dgvEstadisticas.Columns.Contains("observaciones"))
            {
                dgvEstadisticas.Columns["observaciones"].HeaderText =
                    "Observaciones";
            }
        }

        private void OcultarColumna(string nombre)
        {
            if (dgvEstadisticas.Columns.Contains(nombre))
            {
                dgvEstadisticas.Columns[nombre].Visible = false;
            }
        }

        //=========================================================
        // SELECCIONAR REGISTRO DEL DATAGRIDVIEW
        //=========================================================

        private void dgvEstadisticas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    dgvEstadisticas.Rows[e.RowIndex];

                if (!fila.DataGridView.Columns.Contains(
                        "id_estadistica"))
                {
                    return;
                }

                idEstadisticaSeleccionada =
                    Convert.ToInt32(
                        fila.Cells["id_estadistica"].Value);

                CargarEstadisticaSeleccionada();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void CargarEstadisticaSeleccionada()
        {
            EstadisticaJugador estadistica =
                estadisticaDAO.BuscarPorId(
                    idEstadisticaSeleccionada);

            if (estadistica == null)
            {
                MessageBox.Show(
                    "No se encontró la estadística seleccionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            cmbJugador.SelectedValue = estadistica.IdJugador;
            cmbPartido.SelectedValue = estadistica.IdPartido;
            cmbDeporte.SelectedItem = estadistica.Deporte;
            txtObservaciones.Text = estadistica.Observaciones;

            ConfigurarCampos();

            switch (estadistica.Deporte)
            {
                case "Fútbol":
                    nudCampo1.Value = estadistica.Goles;
                    nudCampo2.Value = estadistica.AsistenciasFutbol;
                    nudCampo3.Value = estadistica.TarjetasAmarillas;
                    nudCampo4.Value = estadistica.TarjetasRojas;
                    break;

                case "Baloncesto":
                    nudCampo1.Value = estadistica.PuntosBaloncesto;
                    nudCampo2.Value =
                        estadistica.AsistenciasBaloncesto;
                    nudCampo3.Value = estadistica.Canastas;
                    break;

                case "Voleibol":
                    nudCampo1.Value = estadistica.PuntosVoleibol;
                    nudCampo2.Value =
                        estadistica.SetsGanadosVoleibol;
                    break;

                case "Tenis":
                    nudCampo1.Value = estadistica.PuntosTenis;
                    nudCampo2.Value =
                        estadistica.SetsGanadosTenis;
                    break;
            }

            // Evita cambiar el deporte de una estadística existente.
            cmbDeporte.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        //=========================================================
        // LIMPIAR FORMULARIO
        //=========================================================

        private void LimpiarCampos()
        {
            idEstadisticaSeleccionada = 0;

            cmbJugador.SelectedIndex = -1;
            cmbPartido.SelectedIndex = -1;

            if (cmbDeporte.Items.Count > 0)
            {
                cmbDeporte.SelectedIndex = 0;
            }

            cmbDeporte.Enabled = true;

            txtObservaciones.Clear();
            txtBuscar.Clear();

            LimpiarCamposEstadisticos();
            ConfigurarCampos();

            dgvEstadisticas.ClearSelection();

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            cmbJugador.Focus();
        }

        private void LimpiarCamposEstadisticos()
        {
            nudCampo1.Value = 0;
            nudCampo2.Value = 0;
            nudCampo3.Value = 0;
            nudCampo4.Value = 0;
        }

        //=========================================================
        // ESTILO VERDE DEL FORMULARIO
        //=========================================================

        private void AplicarEstiloFormulario()
        {
            BackColor = Color.FromArgb(241, 248, 233);

            lblTitulo.ForeColor = Color.FromArgb(27, 94, 32);
            lblTitulo.Font =
                new Font("Segoe UI", 18, FontStyle.Bold);

            grpEstadisticas.ForeColor =
                Color.FromArgb(46, 125, 50);

            AplicarEstiloBoton(btnNuevo);
            AplicarEstiloBoton(btnGuardar);
            AplicarEstiloBoton(btnEditar);
            AplicarEstiloBoton(btnEliminar);
            AplicarEstiloBoton(btnBuscar);

            AplicarEstiloDataGridView();
        }

        private void AplicarEstiloBoton(Button boton)
        {
            boton.BackColor = Color.FromArgb(56, 142, 60);
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
        }

        private void AplicarEstiloDataGridView()
        {
            dgvEstadisticas.BackgroundColor = Color.White;
            dgvEstadisticas.BorderStyle = BorderStyle.None;

            dgvEstadisticas.EnableHeadersVisualStyles = false;

            dgvEstadisticas.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);

            dgvEstadisticas.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEstadisticas.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvEstadisticas.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvEstadisticas.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);

            dgvEstadisticas.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEstadisticas.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            dgvEstadisticas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEstadisticas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEstadisticas.MultiSelect = false;
            dgvEstadisticas.ReadOnly = true;
            dgvEstadisticas.AllowUserToAddRows = false;
            dgvEstadisticas.AllowUserToDeleteRows = false;
            dgvEstadisticas.RowHeadersVisible = false;
            dgvEstadisticas.ColumnHeadersHeight = 38;
        }

        //=========================================================
        // MENSAJES DE ERROR
        //=========================================================

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(
                "Ocurrió un error:\n\n" + ex.Message,
                "Sistema Polideportivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}