using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoria_2
{
    static class Agenda
    {
        static Dictionary<int, Persona> agenda_personal { get; set; }
        //Es mucho más simple el manejo a partir del uso del diccionario dado que puedo traer un objeto unicamente empleando su dni para poder hace referencia con el mismo campo
        //El campo DNI debería de ser inmutable dado que puede generar falla en caso de modificarse hasta poder perder la vinculación con el diccionario de la clase estatica quien guarda toda la infon de las instancias de objetos como tal
    }
}
