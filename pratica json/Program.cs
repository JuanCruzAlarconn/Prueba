using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace pratica_json
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            do
            {
                Console.WriteLine("\nIngrese S para agregar una nueva persona y N para detener la carga");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    personas.Add(Persona.Crear());
                    Console.WriteLine("\nSe ha añadido satisfactoriamente un nuevo telefono");
                    continue;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido finalizar la carga de elementos");
                    break;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.N && Console.ReadKey(true).Key != ConsoleKey.S)
                {
                    Console.WriteLine("\nEl ingreso no se corresponde con ninguna de las opciones disponibles");
                    continue;
                }

                break;

            } while (true);

            string personasJson = JsonConvert.SerializeObject(personas);

            File.WriteAllText("Personas.json", personasJson);

            Console.WriteLine("\nSE HA GENERADO EL ARCHIVO JSON SATISFACTORIAMENTE");

            Console.WriteLine(personasJson);
            Console.WriteLine("\n");

            string leer_personas = File.ReadAllText("Personas.json");

            var person_json = JsonConvert.DeserializeObject<List<Persona>>(leer_personas);

            foreach (var person in person_json)
            {
                Console.WriteLine(person.ccv());
            }

            Console.WriteLine("\nIngrese una tecla para finalizar con la ejecución");
            Console.ReadKey();

        }
    }
}
