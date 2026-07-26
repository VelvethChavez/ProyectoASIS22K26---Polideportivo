using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormsPolideportivo.Clases
{
    internal class cconexion
    {
        MySqlConnection conex = new MySqlConnection();
        static String servidor = "localhost";
        static String bd = "polideportivo";
        static String usuario = "root";
        static String password = "brian";
        static String puerto = "3306";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()  {

            try{
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Se conecto correctamente a la BD");


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto correctamente a la BD, error: " +ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion() {  
            conex.Close(); 
        }
    }
}
