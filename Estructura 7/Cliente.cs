using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_7
{
    class Cliente
    {
        public string razon_social { get; set; }

        public string direccion { get; set; }

        public static Cliente Crear()
        {
            Cliente cliente = new Cliente();

            cliente.razon_social = asignar("razón social");
            cliente.direccion = asignar("dirección");

            return cliente;
        }

        private static string asignar(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el campo {0} del cliente", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permancer vacio");
                    continue;
                }

                if (campo == "razón social" && ingreso.Length > 30)
                {
                    Console.WriteLine("\nLa razón social debe de estar compuesta por a lo sumo 30 caracteres dentro de su estructura");
                    continue;
                }

                if (campo == "dirrección" && ingreso.Length > 120)
                {
                    Console.WriteLine("\nLa dirección del cliente puede contener 120 caractes como máximo en su estrucutura");
                    continue;
                }

                break;

            } while (true);

            return ingreso;
        }
    }
}
