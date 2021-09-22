using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio_estructura_de_datos


{
    public class Cliente6
    {
        public int cuil { get; set; }

        public string razon_social { get; set; }

        public static Cliente6 Crear()
        {
            Cliente6 cliente = new Cliente6();

            cliente.cuil = asignar_cuil();
            cliente.razon_social = asignar_razon();

            return cliente;
        }

        private static string asignar_razon()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese la razón social del cliente");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nLa razón social del cliente no debe de permanecer vacia");
                    continue;
                }

                if(ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nLa razón social no puede contener elementos numéricos");
                    continue;
                }

                if (ingreso.Length > 30)
                {
                    Console.WriteLine("\nLa cantidad de elementos de la razón social no debe de exceder los 30 caracteres");
                    continue;
                }

                break;
            } while (true);

            return ingreso;

        }

        private static int asignar_cuil()
        {
            string ingreso;
            int cuil;

            do
            {
                Console.WriteLine("\nIngrese el número de cuil del cliente");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl número de cuil no puede permanecer en vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out cuil))
                {
                    Console.WriteLine("\nEl cuil debe de ser numérico");
                    continue;
                }

                if (cuil <= 0)
                {
                    Console.WriteLine("\nEl número de cuil debe de ser positivo");
                    continue;
                }

                if (ingreso.Length != 11)
                {
                    Console.WriteLine("\nEl número de cuil debe de contener exactamente 11 caracteres numéricos");
                    continue;
                }

                break;
            } while (true);

            return cuil;
        }
    }
}