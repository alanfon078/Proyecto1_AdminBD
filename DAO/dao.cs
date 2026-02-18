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


        // CRUD MECÁNICOS

        public bool InsertarMecanico(Mecanico m)
        {
            // Nota: Las especialidades estan en otra tabla, aqui guardamos los datos base.
            string query = @"
        INSERT INTO Mecanicos (No_Empleado, RFC, Nombre_Completo, Telefono, Salario, Anios_Experiencia) 
        VALUES (@noEmp, @rfc, @nombre, @tel, @salario, @anios);";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@noEmp", m.NoEmpleado);
                    cmd.Parameters.AddWithValue("@rfc", m.Rfc);
                    cmd.Parameters.AddWithValue("@nombre", m.NombreCompleto);
                    cmd.Parameters.AddWithValue("@tel", m.Telefono);
                    cmd.Parameters.AddWithValue("@salario", m.Salario);
                    cmd.Parameters.AddWithValue("@anios", m.AniosExperiencia);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar mecánico: " + ex.Message);
                    return false;
                }
            }
        }

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

        public bool ActualizarMecanico(Mecanico m)
        {
            string query = @"
        UPDATE Mecanicos 
        SET No_Empleado = @noEmp, 
            RFC = @rfc, 
            Nombre_Completo = @nombre, 
            Telefono = @tel, 
            Salario = @salario, 
            Anios_Experiencia = @anios
        WHERE ID_Mecanico = @id;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@noEmp", m.NoEmpleado);
                    cmd.Parameters.AddWithValue("@rfc", m.Rfc);
                    cmd.Parameters.AddWithValue("@nombre", m.NombreCompleto);
                    cmd.Parameters.AddWithValue("@tel", m.Telefono);
                    cmd.Parameters.AddWithValue("@salario", m.Salario);
                    cmd.Parameters.AddWithValue("@anios", m.AniosExperiencia);
                    cmd.Parameters.AddWithValue("@id", m.IdMecanico);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar mecánico: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarMecanico(int idMecanico)
        {
            string query = "UPDATE Mecanicos SET Activo = false WHERE ID_Mecanico = @id;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idMecanico);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar mecánico: " + ex.Message);
                    return false;
                }
            }
        }



        // CRUD VEHICULOS

        public bool InsertarVehiculo(Vehiculo v)
        {
            string query = @"
        INSERT INTO Vehiculos (ID_Cliente, Numero_Serie, Placas, Marca, Modelo, Anio, Color, Kilometraje, Tipo_Vehiculo) 
        VALUES (@idCliente, @serie, @placas, @marca, @modelo, @anio, @color, @km, @tipo);";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idCliente", v.IdCliente);
                    cmd.Parameters.AddWithValue("@serie", v.NumeroSerie);
                    cmd.Parameters.AddWithValue("@placas", v.Placas);
                    cmd.Parameters.AddWithValue("@marca", v.Marca);
                    cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@anio", v.Anio);
                    cmd.Parameters.AddWithValue("@color", v.Color);
                    cmd.Parameters.AddWithValue("@km", v.Kilometraje);
                    cmd.Parameters.AddWithValue("@tipo", v.TipoVehiculo);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar vehículo: " + ex.Message);
                    return false;
                }
            }
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

        public bool ActualizarVehiculo(Vehiculo v)
        {
            string query = @"
        UPDATE Vehiculos 
        SET Placas = @placas, 
            Marca = @marca, 
            Modelo = @modelo, 
            Anio = @anio, 
            Color = @color, 
            Kilometraje = @km, 
            Tipo_Vehiculo = @tipo,
            ID_Cliente = @idCliente
        WHERE ID_Vehiculo = @id;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@placas", v.Placas);
                    cmd.Parameters.AddWithValue("@marca", v.Marca);
                    cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@anio", v.Anio);
                    cmd.Parameters.AddWithValue("@color", v.Color);
                    cmd.Parameters.AddWithValue("@km", v.Kilometraje);
                    cmd.Parameters.AddWithValue("@tipo", v.TipoVehiculo);
                    cmd.Parameters.AddWithValue("@idCliente", v.IdCliente);
                    cmd.Parameters.AddWithValue("@id", v.IdVehiculo);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar vehículo: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarVehiculo(int idVehiculo)
        {
            string query = "UPDATE Vehiculos SET Activo = false WHERE ID_Vehiculo = @id;";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idVehiculo);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar vehículo: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ObtenerClientesParaCombo()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ID_Cliente, CONCAT(Nombre, ' ', Ap_Paterno) AS NombreCompleto FROM Clientes WHERE Activo = true";

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                if (con == null) return dt;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener clientes: " + ex.Message);
                }
            }
            return dt;
        }

    }
}