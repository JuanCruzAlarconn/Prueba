using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preuba_06_10
{
    class Telefono
    {
        public string tipo { get; set; }

        public int telefono { get; set; }

        public string escribir()
        {
            string linea = tipo + ";" + telefono;

            return linea;
        }

        public static Telefono Crear()
        {
            Telefono tel = new Telefono();

            tel.tipo = asignar_tipo();
            tel.telefono = asignar_telefono();

            return tel;

        }

        private static int asignar_telefono()
        {
            string ingreso;
            int tel;

            do
            {
                Console.WriteLine("\nIngrese el número de telefono");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nNo puede dejar el campo telefonico vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out tel))
                {
                    Console.WriteLine("\nEl teléfono debe de ser del tipo numérico");
                    continue;
                }

                if (ingreso.Length != 8)
                {
                    Console.WriteLine("\nEl teléfono debe de contar con 8 caracteres numéricos");
                    continue;
                }
                break;
            } while (true);

            return tel;
        }

        private static string asignar_tipo()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el tipo de teléfono");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campor de tipo de telefono no debe de permanecer vacio");
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl tipo de teléfono no debe de contener caracteres alfanuméricos");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
