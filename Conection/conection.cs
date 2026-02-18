using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text;

namespace Conection.Conexion
{
    internal class Conection
    {
        /// <summary>
        /// Obtiene una conexión a la base de datos MySQL.
        /// </summary
        /// <returns> Objeto MySqlConnection abierto.</returns>
        public MySqlConnection ObtenerConexion()
        {
            string connectionString = "server=20.124.88.140; port=3306; database=TallerMecanicoDB; uid=admi; pwd=Blackops078.; SslMode=Required;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir conexión: " + ex.Message);
                return null; // Retornamos null para indicar fallo
            }
            return conexion;
        }

    }
}
