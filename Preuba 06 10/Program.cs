using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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
                            Console.WriteLine("\nLista telefónica correspondiente al contacto");
                            if (arreglo[0]==array[0])
                            {
                                
                                Console.WriteLine("Tipo: "+array[1]+" Teléfono: "+array[2]);
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

            //Manejo de archivos Json

            string personaJson = JsonConvert.SerializeObject(lista_persona);
            //Tomo una lista de obejetos y la convierto de manera estricta al formato json, eso si debo de contar con las librerias para poder alojar todo el contenido dentro de la estructura json

            File.WriteAllText("persona.json", personaJson);//paso directamente el objeto serializado al archivo json para poder tenerlo a modo de base de datos

            //Tomo el contenido json y lo paso a un archivo mediante una sintaxis de escritura simplificada, en donde paso el contenido serializado y el nombre del archivo que funcionará a modo de base de datos

            Console.WriteLine("\nContenido del archivo json");

            //Cuando quiero ver el contenido de la instancia del archivo, me doy cuenta que el mismo estará en formato json, en donde se especifican los campos de cada uno de los objetos y de forma conjunta los valores asignados a cada uno de los diferentes objetos que componen la lista en su totalidad


            Console.WriteLine(personaJson);

            //Lectura de archivo json

            string leer_persona_json = File.ReadAllText("persona.json");
            //Dentro de una cadena le paso el archivo bruto de formato json, no hay instancias de validación para este parámetro en particular

            var lista_auxiliar = JsonConvert.DeserializeObject<List<Persona>>(leer_persona_json);

            //genero una lista auxiliar en donde voy a cargar el contenido del archivo json, con este me puedo mover de manera simple dentro del archivo
            //Hago el pasaje descerilizado hacia el auxiliar aclarando que el contenido de la lista se corresponde con un tipo de formato de lista es específico para que el contenido pueda ser transferido al formato correspondiente dentro de la dimensión del objeto trabajado


            Console.WriteLine("\nHa finalizado la ejecución del programa");
            Console.ReadKey();

        }



    }
}
