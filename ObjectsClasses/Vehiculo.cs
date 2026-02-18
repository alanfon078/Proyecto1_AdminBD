using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AdminBD.ObjectsClasses
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroSerie { get; set; }
        public string Placas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public int Kilometraje { get; set; }
        public string TipoVehiculo { get; set; }
        public bool Activo { get; set; }

        public string EstadoTexto => Activo ? "Activo" : "Inactivo";
    }
}
