using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_json
{
    class Persona
    {
        public int dni { get; set; }

        public List<Telefono> telefonos { get; set; }


        public string ccv()
        {
            string linea="";

            foreach(var tel in telefonos)
            {
                linea += $"Tipo: {tel.tipo} Número: {tel.numero} \n";
            }

            return $"DNI: {dni} \n LISTADO DE TELÉFONOS \n {linea}";

        }


        public static Persona Crear()
        {
            Persona persona = new Persona();

            persona.dni = asignar_dni();
            persona.telefonos = asignar_telefonos();

            return persona;

        }

        private static List<Telefono> asignar_telefonos()
        {
            List<Telefono> telefonos = new List<Telefono>();
            do
            {
                Console.WriteLine("\nIngrese S para agregar un nuevo teléfono y N para detener la carga");

                if(Console.ReadKey(true).Key==ConsoleKey.S)
                {
                    telefonos.Add(Telefono.Crear());
                    Console.WriteLine("\nSe ha añadido satisfactoriamente un nuevo telefono");
                    continue;
                }

                if(Console.ReadKey(true).Key ==ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido finalizar la carga de elementos");
                    break;
                }

                if(Console.ReadKey(true).Key != ConsoleKey.N && Console.ReadKey(true).Key != ConsoleKey.S)
                {
                    Console.WriteLine("\nEl ingreso no se corresponde con ninguna de las opciones disponibles");
                    continue;
                }

                break;

            } while (true);

            return telefonos;
        }

        private static int asignar_dni()
        {
            string ingreso;
            int salida;

            do
            {
                Console.WriteLine("\nIngrese el número DNI");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out salida))
                {
                    Console.WriteLine("\nEl número de DNI debe de ser numérico");
                    continue;
                }

                if (salida < 0)
                {
                    Console.WriteLine("\nEL número de DNI debe ser positivo");
                    continue;
                }

                if (ingreso.Length != 8)
                {
                    Console.WriteLine("\nEl número debe de contar con 8 cifras exactamente");
                    continue;
                }
                break;
            } while (true);

            return salida;
        }
    }
}
