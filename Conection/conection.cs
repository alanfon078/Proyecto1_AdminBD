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
            MySqlConnection conexion = new MySqlConnection("server=20.124.88.140; database=TallerMecanicoDB; user='admi'; pwd='Blackops078.';Allow User Variables=True;");
            conexion.Open();
            return conexion;
        }

    }
}
