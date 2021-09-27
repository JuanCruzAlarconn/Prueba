using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Destinatario
    {
        public string razon_social { get; set; }
        public int cuit { get; set; }
        public string dirección { get; set; }


        public Remitente Crear()
        {
            Remitente remitente = new Remitente();

            remitente.razon_social = asignar("razon social");
            remitente.cuit = asignar_cuit();
            remitente.dirección = asignar("dirección");

            return remitente;
        }

        private static string asignar(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el campo {0} del remitente",campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permanecer vacio", campo);
                    continue;
                }

                if (ingreso.Length > 30 && campo == "razon social")
                {
                    Console.WriteLine("\nLa razón social no puede tener mas de 30 elementos dentro de su estructura");
                    continue;

                }

                break;
            } while (true);

            return ingreso;
        }

        private static int asignar_cuit()
        {
            string ingreso;
            int cuit;

            do
            {
                Console.WriteLine("\nIngrese el número de cuit");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl número de cuit no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out cuit))
                {
                    Console.WriteLine("\nEl cuit debe de ser numérico");
                    continue;
                }

                if (ingreso.Length > 30)
                {
                    Console.WriteLine("\nEl número de cuit no puede contener más de 30 caracteres numéricos");
                    continue;
                }

                break;
            } while (true);

            return cuit;
        }
    }
}
