using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Preuba_06_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista_persona = new List<Persona>();

           

            do
            {
                Console.WriteLine("\nIngrese S para agregar una nueva persona y N para dentener la carga de persona");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    var persona = Persona.Crear();

                    lista_persona.Add(persona);
                    continue;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido detener la carga de personas por lo que se detiene el proceso de carga");
                    break;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.S && Console.ReadKey(true).Key != ConsoleKey.N)
                {
                    Console.WriteLine("\nHa ingresado una opción que no se corresponde con ninguna de las opciones disponibles dentro del menu");
                    continue;
                }

            } while (true);

            using (var escribir_persona = new StreamWriter("Persona.txt"))
            using (var escribir_telefono = new StreamWriter("Teléfono.txt"))
            {
                foreach(var persona in lista_persona)
                {
                    persona.escribir_texto(escribir_persona, escribir_telefono);
                }
            }

            if (File.Exists("Persona.txt") && File.Exists("Teléfono.txt"))
            {
                using (var leer_persona = new StreamReader("Persona.txt"))
                using (var leer_telefono = new StreamReader("Teléfono.txt"))
                {
                    Console.WriteLine("\nSe procedera a mostrar el contenido del archivo de persona");

                    while (!leer_persona.EndOfStream)
                    {
                        string linea = leer_persona.ReadLine();
                        string[] arreglo = linea.Split(';');
                        Console.WriteLine(linea);

                        while(!leer_telefono.EndOfStream)
                        {
                            string line = leer_telefono.ReadLine();
                            string[] array = line.Split(';');

                            if(arreglo[0]==array[0])
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
            }
            else if(!File.Exists("Persona.txt"))
            {
                Console.WriteLine("\nEl archivo Persona.txt es inaccesible");
            }
            else if (!File.Exists("Teléfono.txt"))
            {
                Console.WriteLine("\nNo se pudo acceder al archivo Teléfono.txt");
            }
        }
    }
}
