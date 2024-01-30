using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArbolesBinarios00
{
    public class Nodo
    {
        public string ApellidosNombres { get; set; }  // PK

        public string Cedula { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }

        public override string ToString()
        {
            return $"{ApellidosNombres} - {Cedula} - {Telefono} - {Email} - {Direccion} - {FechaNacimiento.ToString()}";
        }

        public Nodo(string apellidosNombres, string telefono, string email)
        {
            ApellidosNombres = apellidosNombres;
            Telefono = telefono;
            Email = email;
            Izq = null;
            Der = null;
        }
    }
}
