using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.DAO;
using SistemaDePolideportivo.Modelos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmEstadistica : Form
    {
        private readonly EstadisticaDAO estadisticaDAO;
        private int idEstadisticaSeleccionada;

        public FrmEstadistica()
        {
            InitializeComponent();

            estadisticaDAO = new EstadisticaDAO();
            idEstadisticaSeleccionada = 0;
        }

        //=========================================================
        // CARGAR FORMULARIO
        //=========================================================

        private void FrmEstadistica_Load(object sender, EventArgs e)
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

            CmbJugador.DataSource = tablaJugadores;
            CmbJugador.DisplayMember = "jugador";
            CmbJugador.ValueMember = "id_jugador";
            CmbJugador.SelectedIndex = -1;
        }

        private void CargarPartidos()
        {
            DataTable tablaPartidos = estadisticaDAO.CargarPartidos();

            CmbPartido.DataSource = tablaPartidos;
            CmbPartido.DisplayMember = "partido";
            CmbPartido.ValueMember = "id_partido";
            CmbPartido.SelectedIndex = -1;
        }

        private void CargarDeportes()
        {
            CmbDeporte.Items.Clear();

            CmbDeporte.Items.Add("Fútbol");
            CmbDeporte.Items.Add("Baloncesto");
            CmbDeporte.Items.Add("Voleibol");
            CmbDeporte.Items.Add("Tenis");

            CmbDeporte.SelectedIndex = 0;
        }

        //=========================================================
        // CONFIGURAR CAMPOS SEGÚN EL DEPORTE
        //=========================================================

        private void ConfigurarCampos()
        {
            string deporte = CmbDeporte.Text;

            MostrarCampo(LblCampo1, NudCampo1, true);
            MostrarCampo(LblCampo2, NudCampo2, true);
            MostrarCampo(LblCampo3, NudCampo3, true);
            MostrarCampo(LblCampo4, NudCampo4, true);

            switch (deporte)
            {
                case "Fútbol":
                    LblCampo1.Text = "Goles";
                    LblCampo2.Text = "Asistencias";
                    LblCampo3.Text = "Tarjetas Amarillas";
                    LblCampo4.Text = "Tarjetas Rojas";
                    break;

                case "Baloncesto":
                    LblCampo1.Text = "Puntos";
                    LblCampo2.Text = "Asistencias";
                    LblCampo3.Text = "Canastas";

                    MostrarCampo(LblCampo4, NudCampo4, false);
                    break;

                case "Voleibol":
                    LblCampo1.Text = "Puntos";
                    LblCampo2.Text = "Sets Ganados";

                    MostrarCampo(LblCampo3, NudCampo3, false);
                    MostrarCampo(LblCampo4, NudCampo4, false);
                    break;

                case "Tenis":
                    LblCampo1.Text = "Puntos";
                    LblCampo2.Text = "Sets Ganados";

                    MostrarCampo(LblCampo3, NudCampo3, false);
                    MostrarCampo(LblCampo4, NudCampo4, false);
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
        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
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
                IdJugador = Convert.ToInt32(CmbJugador.SelectedValue),
                IdPartido = Convert.ToInt32(CmbPartido.SelectedValue),
                Deporte = CmbDeporte.Text,
                Observaciones = TxtObservaciones.Text.Trim()
            };

            switch (estadistica.Deporte)
            {
                case "Fútbol":
                    estadistica.Goles = Convert.ToInt32(NudCampo1.Value);
                    estadistica.AsistenciasFutbol =
                        Convert.ToInt32(NudCampo2.Value);
                    estadistica.TarjetasAmarillas =
                        Convert.ToInt32(NudCampo3.Value);
                    estadistica.TarjetasRojas =
                        Convert.ToInt32(NudCampo4.Value);
                    break;

                case "Baloncesto":
                    estadistica.PuntosBaloncesto =
                        Convert.ToInt32(NudCampo1.Value);
                    estadistica.AsistenciasBaloncesto =
                        Convert.ToInt32(NudCampo2.Value);
                    estadistica.Canastas =
                        Convert.ToInt32(NudCampo3.Value);
                    break;

                case "Voleibol":
                    estadistica.PuntosVoleibol =
                        Convert.ToInt32(NudCampo1.Value);
                    estadistica.SetsGanadosVoleibol =
                        Convert.ToInt32(NudCampo2.Value);
                    break;

                case "Tenis":
                    estadistica.PuntosTenis =
                        Convert.ToInt32(NudCampo1.Value);
                    estadistica.SetsGanadosTenis =
                        Convert.ToInt32(NudCampo2.Value);
                    break;
            }

            return estadistica;
        }

        //=========================================================
        // VALIDACIONES
        //=========================================================

        private bool ValidarFormulario()
        {
            if (CmbJugador.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un jugador.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbJugador.Focus();
                return false;
            }

            if (CmbPartido.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un partido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbPartido.Focus();
                return false;
            }

            if (CmbDeporte.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un deporte.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CmbDeporte.Focus();
                return false;
            }

            return true;
        }

        //=========================================================
        // BOTÓN NUEVO
        //=========================================================

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //=========================================================
        // BOTÓN GUARDAR
        //=========================================================

        private void BtnGuardar_Click(object sender, EventArgs e)
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

        private void BtnEditar_Click(object sender, EventArgs e)
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

        private void BtnEliminar_Click(object sender, EventArgs e)
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = TxtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    CargarEstadisticas();
                    return;
                }

                DgvEstadisticas.DataSource =
                    estadisticaDAO.Buscar(texto);

                ConfigurarColumnasDataGridView();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                CargarEstadisticas();
            }
        }

        //=========================================================
        // CARGAR DATAGRIDVIEW
        //=========================================================

        private void CargarEstadisticas()
        {
            DgvEstadisticas.DataSource = null;
            DgvEstadisticas.DataSource = estadisticaDAO.Listar();

            ConfigurarColumnasDataGridView();
        }

        private void ConfigurarColumnasDataGridView()
        {
            if (DgvEstadisticas.Columns.Count == 0)
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

            if (DgvEstadisticas.Columns.Contains("id_estadistica"))
            {
                DgvEstadisticas.Columns["id_estadistica"].HeaderText = "ID";
                DgvEstadisticas.Columns["id_estadistica"].Width = 55;
            }

            if (DgvEstadisticas.Columns.Contains("observaciones"))
            {
                DgvEstadisticas.Columns["observaciones"].HeaderText =
                    "Observaciones";
            }
        }

        private void OcultarColumna(string nombre)
        {
            if (DgvEstadisticas.Columns.Contains(nombre))
            {
                DgvEstadisticas.Columns[nombre].Visible = false;
            }
        }

        //=========================================================
        // SELECCIONAR REGISTRO DEL DATAGRIDVIEW
        //=========================================================

        private void DgvEstadisticas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    DgvEstadisticas.Rows[e.RowIndex];

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

            CmbJugador.SelectedValue = estadistica.IdJugador;
            CmbPartido.SelectedValue = estadistica.IdPartido;
            CmbDeporte.SelectedItem = estadistica.Deporte;
            TxtObservaciones.Text = estadistica.Observaciones;

            ConfigurarCampos();

            switch (estadistica.Deporte)
            {
                case "Fútbol":
                    NudCampo1.Value = estadistica.Goles;
                    NudCampo2.Value = estadistica.AsistenciasFutbol;
                    NudCampo3.Value = estadistica.TarjetasAmarillas;
                    NudCampo4.Value = estadistica.TarjetasRojas;
                    break;

                case "Baloncesto":
                    NudCampo1.Value = estadistica.PuntosBaloncesto;
                    NudCampo2.Value =
                        estadistica.AsistenciasBaloncesto;
                    NudCampo3.Value = estadistica.Canastas;
                    break;

                case "Voleibol":
                    NudCampo1.Value = estadistica.PuntosVoleibol;
                    NudCampo2.Value =
                        estadistica.SetsGanadosVoleibol;
                    break;

                case "Tenis":
                    NudCampo1.Value = estadistica.PuntosTenis;
                    NudCampo2.Value =
                        estadistica.SetsGanadosTenis;
                    break;
            }

            // Evita cambiar el deporte de una estadística existente.
            CmbDeporte.Enabled = false;
            BtnGuardar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        //=========================================================
        // LIMPIAR FORMULARIO
        //=========================================================

        private void LimpiarCampos()
        {
            idEstadisticaSeleccionada = 0;

            CmbJugador.SelectedIndex = -1;
            CmbPartido.SelectedIndex = -1;

            if (CmbDeporte.Items.Count > 0)
            {
                CmbDeporte.SelectedIndex = 0;
            }

            CmbDeporte.Enabled = true;

            TxtObservaciones.Clear();
            TxtBuscar.Clear();

            LimpiarCamposEstadisticos();
            ConfigurarCampos();

            DgvEstadisticas.ClearSelection();

            BtnGuardar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            CmbJugador.Focus();
        }

        private void LimpiarCamposEstadisticos()
        {
            NudCampo1.Value = 0;
            NudCampo2.Value = 0;
            NudCampo3.Value = 0;
            NudCampo4.Value = 0;
        }

        //=========================================================
        // ESTILO VERDE DEL FORMULARIO
        //=========================================================

        private void AplicarEstiloFormulario()
        {
            BackColor = Color.FromArgb(241, 248, 233);

            LblTitulo.ForeColor = Color.FromArgb(27, 94, 32);
            LblTitulo.Font =
                new Font("Segoe UI", 18, FontStyle.Bold);

            GrpEstadisticas.ForeColor =
                Color.FromArgb(46, 125, 50);

            AplicarEstiloBoton(BtnNuevo);
            AplicarEstiloBoton(BtnGuardar);
            AplicarEstiloBoton(BtnEditar);
            AplicarEstiloBoton(BtnEliminar);
            AplicarEstiloBoton(BtnBuscar);

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
            DgvEstadisticas.BackgroundColor = Color.White;
            DgvEstadisticas.BorderStyle = BorderStyle.None;

            DgvEstadisticas.EnableHeadersVisualStyles = false;

            DgvEstadisticas.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 125, 50);

            DgvEstadisticas.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            DgvEstadisticas.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            DgvEstadisticas.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            DgvEstadisticas.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(165, 214, 167);

            DgvEstadisticas.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            DgvEstadisticas.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(241, 248, 233);

            DgvEstadisticas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DgvEstadisticas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DgvEstadisticas.MultiSelect = false;
            DgvEstadisticas.ReadOnly = true;
            DgvEstadisticas.AllowUserToAddRows = false;
            DgvEstadisticas.AllowUserToDeleteRows = false;
            DgvEstadisticas.RowHeadersVisible = false;
            DgvEstadisticas.ColumnHeadersHeight = 38;
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoform = new FrmMenu();
            nuevoform.Show();
            Hide();
        }
    }
}