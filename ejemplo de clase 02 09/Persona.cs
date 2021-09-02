using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_clase_02_09
{
    class Persona
    {

        public static int cantidad { get; private set; }//no pertece a una instancia en particular sino que pertenece a la clase

        public string nombre { get; set; }   //nombre y apellido son propiedades de instancias

        public string apellido { get; set; }

        public Persona()
        {
            cantidad++;//en el momento de crear un objeto persona aumenta el contador
        }
    }
}
