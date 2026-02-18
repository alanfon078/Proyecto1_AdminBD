using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conection.Conexion;

namespace Proyecto1_AdminBD.DAO
{
    internal class dao
    {
        private MySqlConnection cn = new cnxn().ObtenerConexion();


        /// <summary>
        /// Asegura que la conexión a la base de datos esté abierta.
        /// </summary>
        /// <returns>Ninguno</returns>
        private void AsegurarConexion()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
            


    }
}
