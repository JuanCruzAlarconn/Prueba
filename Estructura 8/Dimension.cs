using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Dimension
    {
        public decimal alto { get; set; }
        public decimal ancho { get; set; }
        public decimal profundidad { get; set; }


        public static Dimension Crear()
        {
            Dimension dimension = new Dimension();

            dimension.alto = asignar("alto");
            dimension.ancho = asignar("ancho");
            dimension.profundidad=asignar("profundidad");



            return dimension;
        }

        private static decimal asignar(string campo)
        {
            string ingreso;
            decimal salida;

            do
            {
                Console.WriteLine("\nIngrese el campo {0} de la dimensión del bulto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permanecer vacio");
                    continue;
                }

                if (!decimal.TryParse(ingreso, out salida))
                {
                    Console.WriteLine("\nEl campo {0} debe de ser numérico");
                    continue;
                }

                if (salida < 0)
                {
                    Console.WriteLine("\nEl campo {0} debe de ser mayor a cero");
                    continue;
                }

                break;
            } while (true);

            return salida;
        }
    }
}
