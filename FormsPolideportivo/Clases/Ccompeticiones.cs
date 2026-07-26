using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPolideportivo.Clases
{
    internal class Ccompeticiones
    {
        public void cargarComboCampeonatos(ComboBox combo)
        {
            try
            {
                cconexion objetoConexion = new cconexion();
                string query = "SELECT id_campeonato, nombre_campeonato FROM campeonato";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                combo.DataSource = dt;
                combo.DisplayMember = "nombre_campeonato";
                combo.ValueMember = "id_campeonato";
                combo.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de campeonatos: " + ex.Message);
            }
        }
        public void guardarDatos(ComboBox Campeonato, TextBox NombreJornada, NumericUpDown Numero, DateTimePicker FechaOficial)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Campeonato.Text))
                {
                    MessageBox.Show("Por favor seleccione un campeonato válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idCampeonato = 1;

                switch (Campeonato.Text.Trim())
                {
                    case "Junio":
                        idCampeonato = 1;
                        break;
                    case "Infantil":
                        idCampeonato = 2;
                        break;
                    case "Masculino":
                        idCampeonato = 3;
                        break;
                    default:
                        idCampeonato = 1;
                        break;
                }

                cconexion objetoConexion = new cconexion();

                String query = "insert into jornada (id_campeonato, nombre_jornada, numero_jornada, fecha_jornada)" +
                    "values(@idCampeonato, @nombreJornada, @numeroJornada, @fechaJornada)";

                MySqlCommand cmd = new(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idCampeonato", idCampeonato);
                cmd.Parameters.AddWithValue("@nombreJornada", NombreJornada.Text.Trim());
                cmd.Parameters.AddWithValue("@numeroJornada", Numero.Value);
                cmd.Parameters.AddWithValue("@fechaJornada", FechaOficial.Value.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();

                MessageBox.Show("¡Se guardó la jornada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudieron guardar los datos, error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void mostrarJornadas(DataGridView tablaJornadas)
        {
            try
            {
                cconexion objetoConexion = new cconexion();
                string query = @"SELECT 
                                    j.id_jornada AS 'ID',
                                    c.nombre_campeonato AS 'Campeonato',
                                    j.nombre_jornada AS 'Nombre Jornada',
                                    j.numero_jornada AS 'Número',
                                    j.fecha_jornada AS 'Fecha Programada'
                                 FROM jornada j
                                 LEFT JOIN campeonato c ON j.id_campeonato = c.id_campeonato
                                 ORDER BY j.id_jornada DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaJornadas.DataSource = null;
                tablaJornadas.DataSource = dt;

                tablaJornadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos. Error:" + ex.Message);
            }
        }
    }
}
