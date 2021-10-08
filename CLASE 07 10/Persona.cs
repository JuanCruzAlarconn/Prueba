using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_07_10
{
    class Persona
    {
        public string nombre {get; set;}
        public string apellido {get; set;}
        public int dni { get; set; }
        public DateTime fecha_nacimiento { get; set; }

      public string getInfo()
        {
            string linea;

            linea =$"Nombre: {nombre} Apellido: {apellido} Dni: {dni} Fecha de nacimiento: {fecha_nacimiento}";

            return linea;
        }
    }
}
