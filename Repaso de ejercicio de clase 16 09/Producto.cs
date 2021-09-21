using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_de_ejercicio_de_clase_16_09
{
    class Producto
    {
        public string nombre { get; private set; }
        public decimal precio { get; private set; }

        public static Producto Crear()
        {
            Producto p = new Producto();

            p.nombre = asignar_nombre();
            p.precio = asignar_precio();

            return p;
        }

        private static decimal asignar_precio()
        {
            string ingreso;
            decimal precio;

            do
            {
                Console.WriteLine("\nIngrese el precio del producto ingresado");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl precio no puede ser vacio");
                    continue;
                }

                if (!decimal.TryParse(ingreso, out precio))
                {
                    Console.WriteLine("\nDebe de ingresar un precio numérico");
                    continue;
                }

                if (precio <= 0)
                {
                    Console.WriteLine("\nEl precio debe ser un elemento positivo");
                    continue;
                }

                break;
            } while (true);

            return precio;
        }


        private static string asignar_nombre()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el nombre del producto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl nombre del producto no puede ser vacio");
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl nombre del producto no puede contener elementos numéricos");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
