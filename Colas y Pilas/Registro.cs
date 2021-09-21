using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_y_Pilas
{
   static class Registro
    {
        public static readonly Dictionary<int, Alumno> registro_alumnos = new Dictionary<int, Alumno>();

        public static void agregar_alumno(Alumno alumno)
        {
            registro_alumnos.Add(alumno.registro, alumno);
            Console.WriteLine("\nSe ha añadido satisfactoriamente un nuevo alumno dentro del diccionario del programa");
        }

        public static Alumno buscar_alumno(int registro)
        {

            return registro_alumnos[registro];
        }

        public static void eliminar_alumno(int registro)
        {
            registro_alumnos.Remove(registro);
            Console.WriteLine("\nSe ha eliminado satisfactoriamente al alumno del diccionario");
        }


    }
}
