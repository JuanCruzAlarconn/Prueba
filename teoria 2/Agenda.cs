using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoria_2
{
    static class Agenda
    {
        static public Dictionary<int, Persona> agenda_personal = new Dictionary<int, Persona>();
        //Es mucho más simple el manejo a partir del uso del diccionario dado que puedo traer un objeto unicamente empleando su dni para poder hace referencia con el mismo campo
        //El campo DNI debería de ser inmutable dado que puede generar falla en caso de modificarse hasta poder perder la vinculación con el diccionario de la clase estatica quien guarda toda la infon de las instancias de objetos como tal


        public static void agregar_agenda(Persona persona)
        {
            //Le tengo que pasar una persona por parametro para que la misma pueda ser integrada frente al diccionario de la clase estatica
            agenda_personal.Add(persona.dni, persona);//

            Console.WriteLine("\nSe ha incorporado satisfactoriamente a la persona dentro del diccionario como tal");
            
        }

        public static void bajar_persona(int dni)
        {
            agenda_personal.Remove(dni); //le estoy pasando a la funcion la key value en donde directamente lo busca por unvalor inmutable ty con ello procede al borrado dentro del diccionario de la clase estatica

        }
    }
}
