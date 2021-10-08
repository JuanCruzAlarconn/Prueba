using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace CLASE_07_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Json es un tipo de notación, viene de java scrip
             * una forma de escribir que se uso dentro de java scrip y se hizo popular
             * Un objeto es una colección de elementos pares entre llaves
             * un obj defino por llaves y el medio separados por coma pares de elementos y valor
             * nobre de la propiedad va entre comillas dobles
             * El valor en caso de ser string va entre comillas
             * valor numérico va directamente
             * numérico con decimales
             * Tipo de datos-> stringm, numéricos, bool
             * No hay una forma de definir una fecha pero por convención se usa, 
             * array va entre corchetes 
             * fecha tomo "2020-05-25T03:40:25"
             * para la notación un array es un conjunto de elementos que pueden ser de diferente tipo
             * Con esta notación puedo representar objetos dentro de otros objetos
             * Permite describir la estrucura de los objetos, no unicamente los valores como pasa con el formato ccv
             * Lo que no queda definido es el nombre de la clase al que pertenece
             * Puedo inclusive describir un arreglo de persona al momento de poder encerrar en conjunto de datos, dentro de otro conjunto de llaves
             * Tengo un array con 2 elementos
             * Lo bajo con Newtonsoft.Json, y lo tengo disponible desde el proyecto abierto
             * 
             */
            /*
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona
            {
                nombre = "juan",
                apellido = "alarcon",
                dni = 38456910,
                fecha_nacimiento=new DateTime(1994,07,12),

            });


            string personaJson = JsonConvert.SerializeObject(personas);//toma como parametro cualquier objeto y me devuelve un string
                                                                       //Nos muestra la representación de json de la cadena que la impremi dentro de la función

            File.WriteAllText("personas.json", personaJson);

            Console.WriteLine(personaJson);

            */

            //Con toda esta estructura puedo recrear todo el contenido del objeto persona para poder usar dentro de la ejecución del programa

            string personasJson = File.ReadAllText("personas.json");

            List<Persona> personas = JsonConvert.DeserializeObject<List<Persona>>(personasJson);

            //Con todo esto  puedo pasar el contenido del archivo frente a la lista que corresponde con los elementos que se hallan cargados dentro del archivo al que estoy manipulando

            foreach(var person in personas)
            {
                Console.WriteLine(person.getInfo());
            }

            Console.WriteLine("\nIngrese una tecla para finalizar con la ejecución del programa");

            Console.ReadKey();
        }
    }
}
