using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Destino
    {
        public string pais { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public int numero_calle { get; set; }
        public int numero_piso { get; set; }

        public static Destino Crear()
        {
            Destino destino= new Destino();

            destino.pais = asignar_pais();
            destino.localidad = asignar("localidad");
            destino.calle = asignar("calle");
            destino.numero_calle = asignar_numérico("número de calle");
            destino.numero_piso = asignar_numérico("número de piso");

            return destino;

        }

        private static string asignar_pais()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese dos letras en MAYUSCULA para poder identificar al pais");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl código de pais no puede permanecer en vacio");
                    continue;

                }

                if (ingreso.Length != 2)
                {
                    Console.WriteLine("\nEl código de pais debe de ser de 2 letras unicamente");
                    continue;
                }

                string validar = ingreso.ToUpper();

                if (validar != ingreso)
                {
                    Console.WriteLine("\nLas 2 letras que identifican al pais deben de estar en MAYÚSCULA");
                    continue;
                }


                break;
            } while (true);

            return ingreso;

        }

        private static string asignar(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el campo {0}", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no debe de permanecer vacio");
                    continue;
                }

                if (ingreso.Length > 120)
                {
                    Console.WriteLine("\nEl campo {0} no puede tener más de 120 caracteres");
                    continue;
                }
                break;
            } while (true);

            return ingreso;

        }

        private static int asignar_numérico(string campo)
        {
            string ingreso;
            int numero;

            do
            {
                Console.WriteLine("\nIngrese el campo {0}", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permanecer vacio", campo);
                    continue;
                }

                if (!Int32.TryParse(ingreso, out numero))
                {
                    Console.WriteLine("\nEl campo {0} debe de ser numérico", campo);
                    continue;
                }

                if (ingreso.Length > 10 && campo == "número de calle")
                {
                    Console.WriteLine("\nEl campo {0} no puede contener más de 10 caracteres", campo);
                    continue;
                }

                if (ingreso.Length > 5 && campo == "número de piso")
                {
                    Console.WriteLine("\nEl campo {0} no puede contener más de 5 caracteres", campo);
                    continue;
                }
                break;
            } while (true);

            return numero;
        }
    }
}
