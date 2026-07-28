using MySql.Data.MySqlClient;
using SistemaDePolideportivo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace SistemaDePolideportivo
{
    public partial class Reportes : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        // Diccionario: nombre visible del reporte -> consulta SQL
        private Dictionary<string, string> consultasReportes;

        public Reportes()
        {
            try
            {
                InitializeComponent();
                InicializarConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario de Reportes: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // CARGA DEL FORMULARIO
        //==========================
        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;

                cmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbReportes.Items.Clear();

                foreach (string nombre in consultasReportes.Keys)
                {
                    cmbReportes.Items.Add(nombre);
                }

                if (cmbReportes.Items.Count > 0)
                {
                    cmbReportes.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // DEFINICIÓN DE CONSULTAS
        //==========================
        private void InicializarConsultas()
        {
            try
            {
                consultasReportes = new Dictionary<string, string>();

                // --- Reporte de Equipos ---
                consultasReportes["Equipos"] = @"
                    SELECT 
                        eq.nombre_equipo AS Equipo,
                        CONCAT(en.nombres_entrenador, ' ', en.apellidos_entrenador) AS Entrenador,
                        CASE WHEN eq.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                    FROM Equipo eq
                    LEFT JOIN Entrenador en ON eq.id_entrenador = en.id_entrenador
                    ORDER BY eq.nombre_equipo";

                // --- Reporte de Jugadores ---
                consultasReportes["Jugadores"] = @"
                    SELECT 
                        CONCAT(j.nombres_jugador, ' ', j.apellidos_jugador) AS Jugador,
                        eq.nombre_equipo AS Equipo,
                        p.nombre_posicion AS Posicion,
                        CASE WHEN j.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                    FROM Jugador j
                    JOIN Equipo eq ON j.id_equipo = eq.id_equipo
                    JOIN Posicion p ON j.id_posicion = p.id_posicion
                    ORDER BY eq.nombre_equipo, j.apellidos_jugador";

                // --- Reporte de Partidos ---
                consultasReportes["Partidos"] = @"
                    SELECT 
                        el.nombre_equipo AS Local,
                        ev.nombre_equipo AS Visitante,
                        CONCAT(pa.marcador_local, ' - ', pa.marcador_visitante) AS Marcador,
                        CONCAT(ar.nombres_arbitro, ' ', ar.apellidos_arbitro) AS Arbitro,
                        ca.nombre_campo AS Campo,
                        pa.fecha_partido AS Fecha,
                        pa.hora_partido AS Hora
                    FROM Partido pa
                    JOIN Equipo el ON pa.id_equipo_local = el.id_equipo
                    JOIN Equipo ev ON pa.id_equipo_visitante = ev.id_equipo
                    LEFT JOIN Arbitro ar ON pa.id_arbitro = ar.id_arbitro
                    JOIN Campo ca ON pa.id_campo = ca.id_campo
                    ORDER BY pa.fecha_partido DESC, pa.hora_partido DESC";

                // --- Reporte de Tabla de Posiciones ---
                consultasReportes["Tabla de Posiciones"] = @"
                    SELECT 
                        eq.nombre_equipo AS Equipo,
                        pc.ganados AS Ganados,
                        pc.empatados AS Empatados,
                        pc.perdidos AS Perdidos,
                        pc.puntos AS Puntos
                    FROM Posicion_Campeonato pc
                    JOIN Equipo eq ON pc.id_equipo = eq.id_equipo
                    ORDER BY pc.puntos DESC, pc.ganados DESC";

                // --- Reporte de Estadísticas (Fútbol) ---
                // Nota: goles, asistencias y tarjetas solo existen en Estadistica_Futbol.
                // Si más adelante se necesitan estadísticas de otros deportes
                // (baloncesto, voleibol, tenis), se puede duplicar este reporte
                // con las columnas propias de cada deporte.
                consultasReportes["Estadisticas (Futbol)"] = @"
                    SELECT 
                        CONCAT(j.nombres_jugador, ' ', j.apellidos_jugador) AS Jugador,
                        SUM(ef.goles) AS Goles,
                        SUM(ef.asistencias) AS Asistencias,
                        SUM(ef.tarjetas_amarillas + ef.tarjetas_rojas) AS Tarjetas
                    FROM Estadistica_Futbol ef
                    JOIN Estadistica_Jugador ej ON ef.id_estadistica = ej.id_estadistica
                    JOIN Jugador j ON ej.id_jugador = j.id_jugador
                    GROUP BY j.id_jugador
                    ORDER BY Goles DESC";

                // --- Reporte de Sanciones ---
                consultasReportes["Sanciones"] = @"
                    SELECT 
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
                    JOIN Tipo_Sancion ts ON s.id_tipo_sancion = ts.id_tipo_sancion
                    ORDER BY s.fecha_sancion DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar las consultas de reportes: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // CAMBIO DE REPORTE
        //==========================
        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbReportes.SelectedItem == null) return;

                string reporteSeleccionado = cmbReportes.SelectedItem.ToString();
                CargarReporte(reporteSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // CARGAR REPORTE
        //==========================
        private void CargarReporte(string nombreReporte)
        {
            try
            {
                if (!consultasReportes.ContainsKey(nombreReporte)) return;

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = consultasReportes[nombreReporte];

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();

                    lblResultados.Text = $"{dt.Rows.Count} resultado(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // ACTUALIZAR
        //==========================
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReportes.SelectedItem != null)
                {
                    CargarReporte(cmbReportes.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================
        // EXPORTAR A PDF
        //==========================
        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0 || dataGridView1.DataSource == null)
                {
                    MessageBox.Show("No hay datos para exportar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreReporte = cmbReportes.SelectedItem?.ToString() ?? "Reporte";

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"{nombreReporte}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    try
                    {
                        using (PdfWriter writer = new PdfWriter(sfd.FileName))
                        using (PdfDocument pdfDoc = new PdfDocument(writer))
                        {
                            Document documento = new Document(pdfDoc, PageSize.A4.Rotate());
                            documento.SetMargins(20, 20, 20, 20);

                            documento.Add(new Paragraph("Sistema de Polideportivo")
                                .SetFontSize(10)
                                .SetTextAlignment(TextAlignment.CENTER));

                            documento.Add(new Paragraph($"Reporte: {nombreReporte}")
                                .SetFontSize(16)
                                .SetBold()
                                .SetTextAlignment(TextAlignment.CENTER));

                            documento.Add(new Paragraph($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .SetFontSize(9)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetMarginBottom(15));

                            int numColumnas = dataGridView1.Columns.Count;
                            Table tabla = new Table(numColumnas).UseAllAvailableWidth();

                            // Encabezados
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                tabla.AddHeaderCell(
                                    new Cell().Add(new Paragraph(col.HeaderText).SetBold())
                                );
                            }

                            // Filas
                            foreach (DataGridViewRow fila in dataGridView1.Rows)
                            {
                                if (fila.IsNewRow) continue;

                                foreach (DataGridViewCell celda in fila.Cells)
                                {
                                    tabla.AddCell(
                                        new Cell().Add(new Paragraph(celda.Value?.ToString() ?? ""))
                                    );
                                }
                            }

                            documento.Add(tabla);
                            documento.Close();
                        }

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
    }
}
