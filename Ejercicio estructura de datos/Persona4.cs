using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Persona4
    {
        public int documento { get; private set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public List<Numero_Telefono> numeros { get; set; }

        public static Persona4 Crear()
        {
            Persona4 persona = new Persona4();

            persona.nombre = asignar_campo("nombre");
            persona.apellido = asignar_campo("apellido");
            persona.documento = asignar_dni();

            persona.numeros = asignar_numeros();

            Console.WriteLine("\nSe ha generado satisfactoriamente una nueva instancia de persona");

            return persona;
        }

        private static List<Numero_Telefono> asignar_numeros()
        {
            Numero_Telefono num = new Numero_Telefono();
            List<Numero_Telefono> numeros = new List<Numero_Telefono>();
            do
            {
                Console.WriteLine("\nIngrese s para ingresar y n para dejar de ingresar números");
                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido dejar de agregar nuevos campos telefónicos");
                    break;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    num = Numero_Telefono.Crear();
                    numeros.Add(num);
                    Console.WriteLine("\nSe ha agregado un nuevo número telefónico");
                    continue;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.N || Console.ReadKey(true).Key != ConsoleKey.S)
                {
                    Console.WriteLine("\nNinguna de las opciones ingresadas concuerda con las disponibles");
                    continue;
                }
            } while (true);

            return numeros;
        }

        private static int asignar_dni()
        {
            string ingreso;
            int dni;

            do
            {
                Console.WriteLine("\nIngrese el dni de la persona");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl dni no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out dni))
                {
                    Console.WriteLine("\nEl dni debe de ser numérico");
                    continue;
                }


                if (ingreso.Length > 8 || ingreso.Length < 7)
                {
                    Console.WriteLine("\nEl dni debe de contar con 7 u 8 dígitos dentro de su estructura");
                    continue;
                }

                break;
            } while (true);

            return dni;
        }

        private static string asignar_campo(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0} de la persona");
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl {0} no puede permanecer vacio");
                    continue;
                }

                if (ingreso.Length > 30)
                {
                    Console.WriteLine("\nEl {0} no puede tener más de 30 caracteres dentro de su estructura");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
