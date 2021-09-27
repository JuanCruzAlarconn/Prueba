using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Bulto
    {
        public decimal peso { get; set; }
        public decimal cantidad { get; set; }

        public Dimension dimension { get; set; }

        public decimal volumen
        {
            get
            {
                return dimension.alto * dimension.ancho * dimension.profundidad;
            }
        }

        public static Bulto Crear()
        {
            Bulto bulto = new Bulto();

            bulto.peso = asignar("peso");
            bulto.cantidad = asignar("cantidad");

            bulto.dimension = Dimension.Crear();

            return bulto;
        }

        private static decimal asignar(string campo)
        {
            string ingreso;
            decimal numerico;

            do
            {
                Console.WriteLine("\nIngrese le campo {0} del bulto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permanecer vacio");
                    continue;
                }
                if (!decimal.TryParse(ingreso, out numerico))
                {
                    Console.WriteLine("\nEl campo {0} debe de ser numérico decimal", campo);
                    continue;
                }

                if (numerico < 0)
                {
                    Console.WriteLine("\nEl campo {0} debe de ser mayor que cero");
                    continue;
                }

                break;

            } while (true);

            return numerico;
        }
    }
}
