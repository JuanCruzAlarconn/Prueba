using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_clase_02_09
{
    class Practica
    {
        //1. 2 campos para poder generar un lista
        //2. la clave no se repite es única y con ella puedo tener acceso al campo correspondiente al diccionario

        public void ejercicio1()
        {
            Dictionary<int, string> personas = new Dictionary<int, string>();

            personas.Add(38456910, "Juan Cruz Alarcón");
            personas.Add(45645681, "Juan Perez");

            //más suma de datos

            string nombre = personas[38456910];// busco por el nombre de la clave que debo de tener identificada y es única

            foreach(string name in personas.Values)
            {
                //estoy recorriendo todos los valores del diccionario

                Console.WriteLine(name);


            }

        }
    }
}
