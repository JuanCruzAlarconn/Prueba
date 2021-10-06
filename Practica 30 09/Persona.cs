using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_30_09
{
    class Persona
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int dni { get; set; }
        public DateTime fecha_nacimiento { get; set; }

        public static Persona Crear(string linea)
        {
            string[] elemento = linea.Split(';');

            var persona = new Persona();
            persona.nombre = elemento[0];
            persona.apellido = elemento[1];
            persona.dni = Convert.ToInt32(elemento[2]);
            persona.fecha_nacimiento = Convert.ToDateTime(elemento[3]);

            return persona;


        }

        public string Información()
        {
            return "Nombre: " +nombre+ "  Apellido: " +apellido+ " DNI: " +dni+ " Fecha de nacimiento:"+fecha_nacimiento;
        }
    }
}
