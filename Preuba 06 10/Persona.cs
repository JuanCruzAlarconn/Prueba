using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Preuba_06_10
{
    class Persona
    {
        public string nombre { get; set; }

        public int dni { get; set; }

        public List<Telefono> lista_telefono { get; set; }

        


        public static Persona Crear()
        {
            Persona persona = new Persona();

            persona.dni = asignar_dni();
            persona.nombre = asignar_nombre(persona.dni);
            persona.lista_telefono = asignar_lista(persona.nombre);

            Console.WriteLine("\nSe ha creado satisfactoriamente una nueva persona");

            return persona;



        }

        public void escribir_texto(StreamWriter escribir_persona, StreamWriter escribir_telefono)
        {
            string linea = dni+";"+nombre;
            escribir_persona.WriteLine(linea);

            foreach(var tel in lista_telefono)
            {
                escribir_telefono.WriteLine(dni + ";" + tel.escribir());
            }
        }

        private static int asignar_dni()
        {
            string ingreso;
            int dni;

            do
            {
                Console.WriteLine("\nIngrese el DNI");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo de dni se compone de 8 elementos numéricos");
                    continue;
                }
                if (!Int32.TryParse(ingreso, out dni))
                {
                    Console.WriteLine("\nEl dni debe de ser completamente numérico");
                    continue;
                }

                if (ingreso.Length != 8)
                {
                    Console.WriteLine("\nEl dni debe de contener 8 elementos numéricos");
                    continue;
                }

                break;

            }
            while (true);

                return dni;


        }

        private static string asignar_nombre(int dni)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el nombre que se corresponde con el dni {0}", dni);
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl campo de nombre no puede permanecer vacio");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }

        private static List<Telefono> asignar_lista(string nombre)
        {
            List<Telefono> lista = new List<Telefono>();

            do
            {
                Console.WriteLine("\nIngrese S para cargar un nuevo telefono  a la persona {0}", nombre);

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    lista.Add(Telefono.Crear());
                    continue;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.S && Console.ReadKey(true).Key != ConsoleKey.N)
                {
                    Console.WriteLine("\nHa ingresado una opción que no se corresponde con ninguna de las opciones disponibles dentro del menu");
                    continue;
                }

                if(Console.ReadKey(true).Key==ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decisido finanlizar con la carga de teléfonos");
                    break;
                }
            } while (true);

            return lista;
        }
    }
}
