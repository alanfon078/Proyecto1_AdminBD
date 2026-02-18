using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Conection.Conexion;
using Proyecto1_AdminBD.ObjectsClasses;

namespace Proyecto1_AdminBD.DAO
{
    internal class dao
    {
        private cnxn conexion = new cnxn();

        public List<Mecanico> ObtenerMecanicos()
        {
            List<Mecanico> lista = new List<Mecanico>();

            // Consulta: Se unen los mecánicos con sus especialidades
            // Si tiene varias, se separan por comas.
            string query = @"
                SELECT 
                    m.ID_Mecanico, 
                    m.No_Empleado, 
                    m.RFC, 
                    m.Nombre_Completo, 
                    m.Telefono, 
                    m.Salario, 
                    m.Anios_Experiencia, 
                    m.Activo,
                    IFNULL(GROUP_CONCAT(e.Especialidad SEPARATOR ', '), 'Sin Especialidad') as Especialidades
                FROM Mecanicos m
                LEFT JOIN Especialidades_Mecanicos e ON m.ID_Mecanico = e.ID_Mecanico
                WHERE m.Activo = true
                GROUP BY m.ID_Mecanico, m.No_Empleado, m.RFC, m.Nombre_Completo, m.Telefono, m.Salario, m.Anios_Experiencia, m.Activo;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return lista; // Validación de conexión fallida

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Mecanico
                            {
                                IdMecanico = reader.GetInt32("ID_Mecanico"),
                                NoEmpleado = reader.GetString("No_Empleado"),
                                Rfc = reader.GetString("RFC"),
                                NombreCompleto = reader.GetString("Nombre_Completo"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono"),
                                Salario = reader.GetDecimal("Salario"),
                                AniosExperiencia = reader.GetInt32("Anios_Experiencia"),
                                Activo = reader.GetBoolean("Activo"),
                                Especialidades = reader.GetString("Especialidades")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio algo inesperado al obtener los mecánicos: " 
                        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            // Consulta: Unimos Vehiculos con Clientes para obtener el nombre del dueño
            string query = @"
                SELECT 
                    v.ID_Vehiculo, 
                    v.ID_Cliente,
                    CONCAT(c.Nombre, ' ', c.Ap_Paterno) AS NombreCliente,
                    v.Numero_Serie, 
                    v.Placas, 
                    v.Marca, 
                    v.Modelo, 
                    v.Anio, 
                    v.Color, 
                    v.Kilometraje, 
                    v.Tipo_Vehiculo,
                    v.Activo
                FROM Vehiculos v
                INNER JOIN Clientes c ON v.ID_Cliente = c.ID_Cliente
                WHERE v.Activo = true;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return lista;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Vehiculo
                            {
                                IdVehiculo = reader.GetInt32("ID_Vehiculo"),
                                IdCliente = reader.GetInt32("ID_Cliente"),
                                NombreCliente = reader.GetString("NombreCliente"),
                                NumeroSerie = reader.GetString("Numero_Serie"),
                                Placas = reader.GetString("Placas"),
                                Marca = reader.GetString("Marca"),
                                Modelo = reader.GetString("Modelo"),
                                Anio = reader.GetInt32("Anio"),
                                Color = reader.GetString("Color"),
                                Kilometraje = reader.GetInt32("Kilometraje"),
                                TipoVehiculo = reader.GetString("Tipo_Vehiculo"),
                                Activo = reader.GetBoolean("Activo")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio algo inesperado al obtener los vehículos: "
                        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }
    }
}