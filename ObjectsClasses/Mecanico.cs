using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AdminBD.ObjectsClasses
{
    public class Mecanico
    {
        public int IdMecanico { get; set; }
        public string NoEmpleado { get; set; }
        public string Rfc { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }
        public int AniosExperiencia { get; set; }
        public string Especialidades { get; set; }
        public bool Activo { get; set; }

        // Propiedad de solo lectura para mostrar el estado como texto en el grid
        public string EstadoTexto => Activo ? "Activo" : "Inactivo";
    }
}
