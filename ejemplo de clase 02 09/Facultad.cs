using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_clase_02_09
{
    static class Facultad
    {
        //solamente hay un objeto no puedo generar otra facultad
        //como solo hay 1 no hace falta uar variables para poder acceder a la facultad

        public static string nombre { get; private set; } // como tengo el private solo internamente puedo cambiar el nombre de la clase


        //si quiero usar la clase objeto unicamente llamo a la clase por su nombre sin ningún tipo de instanciación

        public static string direccion { get; set; }
    }
}
