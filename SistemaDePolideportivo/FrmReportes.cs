using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmReportes : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Vista actual mostrada en el DataGridView (permite aplicar el
        // buscador en vivo con RowFilter sin volver a consultar la BD).
        private DataView? vistaActual;

        public FrmReportes()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario de FrmReportes: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CARGA DEL FORMULARIO
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                Dgv1.ReadOnly = true;
                Dgv1.AllowUserToAddRows = false;

                CmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbReportes.Items.Clear();
                CmbReportes.Items.AddRange(new object[]
                {
                    "Equipos",
                    "Jugadores",
                    "Partidos",
                    "Tabla de Posiciones",
                    "Estadisticas (Futbol)",
                    "Sanciones"
                });

                // Rango de fechas por defecto: último mes hasta hoy
                DtpDesde.Value = DateTime.Now.AddMonths(-1);
                DtpHasta.Value = DateTime.Now;

                CargarCampeonatos();

                if (CmbReportes.Items.Count > 0)
                {
                    CmbReportes.SelectedIndex = 0; // Dispara SelectedIndexChanged -> carga el reporte
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CARGAR LISTA DE CAMPEONATOS (para el filtro)
        private void CargarCampeonatos()
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "SELECT id_campeonato, nombre_campeonato FROM Campeonato ORDER BY fecha_inicio DESC";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Fila "Todos los campeonatos" al inicio (id = 0)
                    DataRow filaTodos = dt.NewRow();
                    filaTodos["id_campeonato"] = 0;
                    filaTodos["nombre_campeonato"] = "-- Todos los campeonatos --";
                    dt.Rows.InsertAt(filaTodos, 0);

                    CmbCampeonato.DataSource = dt;
                    CmbCampeonato.DisplayMember = "nombre_campeonato";
                    CmbCampeonato.ValueMember = "id_campeonato";
                    CmbCampeonato.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de campeonatos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // CAMBIO DE REPORTE
        private void CmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbReportes.SelectedItem == null) return;

                string reporteSeleccionado = CmbReportes.SelectedItem.ToString() ?? string.Empty;

                TxtBuscar.Text = string.Empty; // limpiar búsqueda al cambiar de reporte
                ActualizarControlesFiltro(reporteSeleccionado);
                CargarReporte(reporteSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MOSTRAR/OCULTAR FILTROS SEGÚN EL REPORTE
        private void ActualizarControlesFiltro(string nombreReporte)
        {
            try
            {
                bool usaCampeonato = nombreReporte == "Partidos" || nombreReporte == "Tabla de Posiciones";
                bool usaEstado = nombreReporte == "Equipos" || nombreReporte == "Jugadores" || nombreReporte == "Sanciones";
                bool usaFecha = nombreReporte == "Partidos" || nombreReporte == "Sanciones";

                LblCampeonato.Visible = usaCampeonato;
                CmbCampeonato.Visible = usaCampeonato;

                LblEstado.Visible = usaEstado;
                CmbEstado.Visible = usaEstado;

                LblDesde.Visible = usaFecha;
                DtpDesde.Visible = usaFecha;
                LblHasta.Visible = usaFecha;
                DtpHasta.Visible = usaFecha;
                ChkFiltrarFecha.Visible = usaFecha;
                ChkFiltrarFecha.Checked = false;

                // El combo de Estado tiene opciones distintas según el reporte
                CmbEstado.Items.Clear();
                if (nombreReporte == "Sanciones")
                {
                    CmbEstado.Items.AddRange(new object[] { "Todos", "ACTIVA", "CUMPLIDA" });
                }
                else
                {
                    CmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
                }
                if (CmbEstado.Items.Count > 0) CmbEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los filtros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN "APLICAR FILTROS"
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbReportes.SelectedItem != null)
                {
                    CargarReporte(CmbReportes.SelectedItem.ToString() ?? string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar los filtros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CARGAR REPORTE (con filtros aplicados)

        private void CargarReporte(string nombreReporte)
        {
            try
            {
                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    MySqlCommand? cmd = ConstruirConsulta(nombreReporte, conexion);
                    if (cmd == null) return;

                    using (cmd)
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        vistaActual = dt.DefaultView;
                        Dgv1.DataSource = vistaActual;
                        Dgv1.AutoResizeColumns();

                        AplicarFiltroBusqueda(); // por si ya había texto en el buscador

                        LblResultados.Text = $"{dt.Rows.Count} resultado(s)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // CONSTRUIR LA CONSULTA SQL SEGÚN EL REPORTE Y LOS FILTROS ACTIVOS
        private MySqlCommand? ConstruirConsulta(string nombreReporte, MySqlConnection conexion)
        {
            string sql;
            List<string> condiciones = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;

            switch (nombreReporte)
            {
                case "Equipos":
                    sql = @"SELECT 
                                eq.nombre_equipo AS Equipo,
                                CONCAT(en.nombres_entrenador, ' ', en.apellidos_entrenador) AS Entrenador,
                                CASE WHEN eq.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                            FROM Equipo eq
                            LEFT JOIN Entrenador en ON eq.id_entrenador = en.id_entrenador";

                    if (CmbEstado.SelectedItem?.ToString() is string estadoEq && estadoEq != "Todos")
                    {
                        condiciones.Add("eq.estado = @estado");
                        cmd.Parameters.AddWithValue("@estado", estadoEq == "Activo" ? 1 : 0);
                    }

                    sql += ArmarWhere(condiciones) + " ORDER BY eq.nombre_equipo";
                    break;

                case "Jugadores":
                    sql = @"SELECT 
                                CONCAT(j.nombres_jugador, ' ', j.apellidos_jugador) AS Jugador,
                                eq.nombre_equipo AS Equipo,
                                p.nombre_posicion AS Posicion,
                                CASE WHEN j.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                            FROM Jugador j
                            JOIN Equipo eq ON j.id_equipo = eq.id_equipo
                            JOIN Posicion p ON j.id_posicion = p.id_posicion";

                    if (CmbEstado.SelectedItem?.ToString() is string estadoJug && estadoJug != "Todos")
                    {
                        condiciones.Add("j.estado = @estado");
                        cmd.Parameters.AddWithValue("@estado", estadoJug == "Activo" ? 1 : 0);
                    }

                    sql += ArmarWhere(condiciones) + " ORDER BY eq.nombre_equipo, j.apellidos_jugador";
                    break;

                case "Partidos":
                    sql = @"SELECT 
                                el.nombre_equipo AS Local,
                                ev.nombre_equipo AS Visitante,
                                CONCAT(pa.marcador_local, ' - ', pa.marcador_visitante) AS Marcador,
                                CONCAT(ar.nombres_arbitro, ' ', ar.apellidos_arbitro) AS Arbitro,
                                ca.nombre_campo AS Campo,
                                pa.fecha_partido AS Fecha,
                                pa.hora_partido AS Hora
                            FROM Partido pa
                            JOIN Jornada jor ON pa.id_jornada = jor.id_jornada
                            JOIN Equipo el ON pa.id_equipo_local = el.id_equipo
                            JOIN Equipo ev ON pa.id_equipo_visitante = ev.id_equipo
                            LEFT JOIN Arbitro ar ON pa.id_arbitro = ar.id_arbitro
                            JOIN Campo ca ON pa.id_campo = ca.id_campo";

                    if (CmbCampeonato.SelectedValue is int idCampPartido && idCampPartido != 0)
                    {
                        condiciones.Add("jor.id_campeonato = @idCampeonato");
                        cmd.Parameters.AddWithValue("@idCampeonato", idCampPartido);
                    }

                    if (ChkFiltrarFecha.Checked)
                    {
                        condiciones.Add("pa.fecha_partido BETWEEN @desde AND @hasta");
                        cmd.Parameters.AddWithValue("@desde", DtpDesde.Value.Date);
                        cmd.Parameters.AddWithValue("@hasta", DtpHasta.Value.Date);
                    }

                    sql += ArmarWhere(condiciones) + " ORDER BY pa.fecha_partido DESC, pa.hora_partido DESC";
                    break;

                case "Tabla de Posiciones":
                    sql = @"SELECT 
                                eq.nombre_equipo AS Equipo,
                                pc.ganados AS Ganados,
                                pc.empatados AS Empatados,
                                pc.perdidos AS Perdidos,
                                pc.puntos AS Puntos
                            FROM Posicion_Campeonato pc
                            JOIN Equipo eq ON pc.id_equipo = eq.id_equipo";

                    if (CmbCampeonato.SelectedValue is int idCampTabla && idCampTabla != 0)
                    {
                        condiciones.Add("pc.id_campeonato = @idCampeonato");
                        cmd.Parameters.AddWithValue("@idCampeonato", idCampTabla);
                    }

                    sql += ArmarWhere(condiciones) + " ORDER BY pc.puntos DESC, pc.ganados DESC";
                    break;

                case "Estadisticas (Futbol)":
                    // Nota: goles, asistencias y tarjetas solo existen en Estadistica_Futbol.
                    // Si se necesitan estadísticas de otros deportes, se puede duplicar
                    // este reporte con las columnas propias de cada uno.
                    sql = @"SELECT 
                                CONCAT(j.nombres_jugador, ' ', j.apellidos_jugador) AS Jugador,
                                SUM(ef.goles) AS Goles,
                                SUM(ef.asistencias) AS Asistencias,
                                SUM(ef.tarjetas_amarillas + ef.tarjetas_rojas) AS Tarjetas
                            FROM Estadistica_Futbol ef
                            JOIN Estadistica_Jugador ej ON ef.id_estadistica = ej.id_estadistica
                            JOIN Jugador j ON ej.id_jugador = j.id_jugador
                            GROUP BY j.id_jugador
                            ORDER BY Goles DESC";
                    break;

                case "Sanciones":
                    sql = @"SELECT 
                                CONCAT(j.nombres_jugador, ' ', j.apellidos_jugador) AS Jugador,
                                CONCAT(el.nombre_equipo, ' vs ', ev.nombre_equipo) AS Partido,
                                ts.nombre_tipo AS Tipo,
                                s.descripcion AS Descripcion,
                                s.partidos_suspension AS Suspension
                            FROM Sancion s
                            JOIN Jugador j ON s.id_jugador = j.id_jugador
                            JOIN Partido pa ON s.id_partido = pa.id_partido
                            JOIN Equipo el ON pa.id_equipo_local = el.id_equipo
                            JOIN Equipo ev ON pa.id_equipo_visitante = ev.id_equipo
                            JOIN Tipo_Sancion ts ON s.id_tipo_sancion = ts.id_tipo_sancion";

                    if (CmbEstado.SelectedItem?.ToString() is string estadoSancion && estadoSancion != "Todos")
                    {
                        condiciones.Add("s.estado = @estado");
                        cmd.Parameters.AddWithValue("@estado", estadoSancion);
                    }

                    if (ChkFiltrarFecha.Checked)
                    {
                        condiciones.Add("s.fecha_sancion BETWEEN @desde AND @hasta");
                        cmd.Parameters.AddWithValue("@desde", DtpDesde.Value.Date);
                        cmd.Parameters.AddWithValue("@hasta", DtpHasta.Value.Date);
                    }

                    sql += ArmarWhere(condiciones) + " ORDER BY s.fecha_sancion DESC";
                    break;

                default:
                    return null;
            }

            cmd.CommandText = sql;
            return cmd;
        }
        
        // ARMAR CLÁUSULA WHERE
        private string ArmarWhere(List<string> condiciones)
        {
            if (condiciones.Count == 0) return string.Empty;
            return " WHERE " + string.Join(" AND ", condiciones);
        }

        // BUSCADOR EN VIVO (filtra la tabla ya cargada, sin ir a la BD)
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AplicarFiltroBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la tabla: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltroBusqueda()
        {
            if (vistaActual == null) return;

            string texto = TxtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                vistaActual.RowFilter = string.Empty;
                return;
            }

            string textoEscapado = texto.Replace("'", "''");
            List<string> condiciones = new List<string>();

            foreach (DataColumn columna in vistaActual.Table.Columns)
            {
                // El filtro LIKE de DataView solo aplica de forma segura a columnas de texto
                if (columna.DataType == typeof(string))
                {
                    condiciones.Add($"[{columna.ColumnName}] LIKE '%{textoEscapado}%'");
                }
            }

            vistaActual.RowFilter = condiciones.Count > 0 ? string.Join(" OR ", condiciones) : string.Empty;
        }

        // ACTUALIZAR

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbReportes.SelectedItem != null)
                {
                    CargarReporte(CmbReportes.SelectedItem.ToString() ?? string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // EXPORTAR A PDF (sin librerías externas)

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv1.Rows.Count == 0 || Dgv1.DataSource == null)
                {
                    MessageBox.Show("No hay datos para exportar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool existeImpresoraPDF = false;
                foreach (string impresora in PrinterSettings.InstalledPrinters)
                {
                    if (impresora.Equals("Microsoft Print to PDF", StringComparison.OrdinalIgnoreCase))
                    {
                        existeImpresoraPDF = true;
                        break;
                    }
                }

                if (!existeImpresoraPDF)
                {
                    MessageBox.Show(
                        "No se encontró la impresora virtual \"Microsoft Print to PDF\" en este equipo.\n\n" +
                        "Actívala desde: Panel de control > Programas > Activar o desactivar características de Windows > Microsoft Print to PDF.",
                        "Impresora PDF no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreReporte = CmbReportes.SelectedItem?.ToString() ?? "Reporte";

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"{nombreReporte}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    try
                    {
                        ExportarDataGridViewAPDF(sfd.FileName, nombreReporte);

                        DialogResult abrir = MessageBox.Show(
                            "Reporte exportado correctamente. ¿Desea abrirlo?",
                            "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (abrir == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = sfd.FileName,
                                    UseShellExecute = true
                                });
                            }
                            catch (Exception exAbrir)
                            {
                                MessageBox.Show("El PDF se generó, pero no se pudo abrir automáticamente: " + exAbrir.Message,
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception exExportar)
                    {
                        MessageBox.Show("Error al exportar: " + exExportar.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al exportar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // DIBUJAR Y GENERAR EL PDF
        // (usa la impresora virtual "Microsoft Print to PDF" de Windows,

        private void ExportarDataGridViewAPDF(string rutaArchivo, string tituloReporte)
        {
            List<string> encabezados = new List<string>();
            foreach (DataGridViewColumn col in Dgv1.Columns)
            {
                encabezados.Add(col.HeaderText);
            }

            List<string[]> filas = new List<string[]>();
            foreach (DataGridViewRow fila in Dgv1.Rows)
            {
                if (fila.IsNewRow) continue;

                string[] valores = new string[Dgv1.Columns.Count];
                for (int i = 0; i < Dgv1.Columns.Count; i++)
                {
                    valores[i] = fila.Cells[i].Value?.ToString() ?? "";
                }
                filas.Add(valores);
            }

            int filaActual = 0;

            using (Font fuenteTitulo = new Font("Segoe UI", 14, FontStyle.Bold))
            using (Font fuenteSubtitulo = new Font("Segoe UI", 8, FontStyle.Regular))
            using (Font fuenteEncabezado = new Font("Segoe UI", 9, FontStyle.Bold))
            using (Font fuenteCelda = new Font("Segoe UI", 8, FontStyle.Regular))
            using (Pen lapiz = new Pen(Color.Black))
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                pd.PrinterSettings.PrintToFile = true;
                pd.PrinterSettings.PrintFileName = rutaArchivo;
                pd.DefaultPageSettings.Landscape = true;

                pd.PrintPage += (object s, PrintPageEventArgs e) =>
                {
                    if (e.Graphics == null)
                    {
                        e.HasMorePages = false;
                        return;
                    }
                    Graphics g = e.Graphics;

                    float x = e.MarginBounds.Left;
                    float y = e.MarginBounds.Top;
                    float anchoDisponible = e.MarginBounds.Width;

                    bool esPrimeraPagina = (filaActual == 0);

                    if (esPrimeraPagina)
                    {
                        g.DrawString(tituloReporte, fuenteTitulo, Brushes.Black, x, y);
                        y += 30;
                        g.DrawString($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}",
                                     fuenteSubtitulo, Brushes.Gray, x, y);
                        y += 22;
                    }

                    int numColumnas = Math.Max(encabezados.Count, 1);
                    float anchoColumna = anchoDisponible / numColumnas;
                    float altoFila = 22f;

                    float xTemp = x;
                    for (int c = 0; c < encabezados.Count; c++)
                    {
                        g.DrawString(encabezados[c], fuenteEncabezado, Brushes.Black,
                            new RectangleF(xTemp, y, anchoColumna, altoFila));
                        xTemp += anchoColumna;
                    }
                    y += altoFila;
                    g.DrawLine(lapiz, x, y, x + anchoDisponible, y);
                    y += 4;

                    while (filaActual < filas.Count)
                    {
                        if (y + altoFila > e.MarginBounds.Bottom)
                        {
                            e.HasMorePages = true;
                            return;
                        }

                        xTemp = x;
                        for (int c = 0; c < encabezados.Count; c++)
                        {
                            g.DrawString(filas[filaActual][c], fuenteCelda, Brushes.Black,
                                new RectangleF(xTemp, y, anchoColumna, altoFila));
                            xTemp += anchoColumna;
                        }

                        y += altoFila;
                        filaActual++;
                    }

                    e.HasMorePages = false;
                };

                pd.Print();
            }
        }

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
