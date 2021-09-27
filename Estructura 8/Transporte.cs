using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Transporte
    {
        public decimal peso_maximo { get; set;}
        public decimal volumen_maximo { get; set; }


        public static Transporte Crear()
        {
            Transporte transporte = new Transporte();

            transporte.peso_maximo = asignar("peso máximo");
            transporte.volumen_maximo = asignar("volumen máximo");

            return transporte;
        }

        private static decimal asignar(string campo)
        {
            string ingreso;
            decimal salida;

            do
            {
                Console.WriteLine("\nIngrese el {0} del transporte");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permanecer vacio");
                    continue;
                }

                if (!decimal.TryParse(ingreso, out salida))
                {
                    Console.WriteLine("\nEl campo {0} debe de ser númerico decimal");
                    continue;
                }

                break;
            } while (true);
            return salida;
        }
    }
}
