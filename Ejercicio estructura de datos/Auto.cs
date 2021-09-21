using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Auto
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int año { get; set; }

        public decimal precio { get; set; }

        public static Auto Crear()
        {
            Auto auto = new Auto();

            auto.marca = asignar_campo("Marca");
            auto.modelo = asignar_campo("Modelo");
            auto.año = asignar_año();
            auto.precio = asignar_precio();


            Console.WriteLine("\nSe ha creado satisfactoriamente una nueva instancia de la clase auto");

            return auto;
        }

        private static string asignar_campo(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0}", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl {0} no puede permanecer vacio", campo);
                    continue;
                }

                if(ingreso.Length>30)
                {
                    Console.WriteLine("\nEl {0} no puede tener más de 30 caracteres dentro de su estructura", campo);
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }

        private static int asignar_año()
        {
            string ingreso;
            int año;

            do
            {
                Console.WriteLine("\nIngrese el año del auto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl año no puede permancer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out año))
                {
                    Console.WriteLine("\nEl año debe de ser un tipo numérico");
                    continue;
                }

                if (año < 0)
                {
                    Console.WriteLine("\nEl año debe de ser positivo");
                    continue;
                }

                if (año > DateTime.Now.Year)
                {
                    Console.WriteLine("\nEl auto no puede ser del futuro");
                    continue;
                }
                break;
            } while (true);

            return año;
        }

        private static decimal asignar_precio()
        {
            string ingreso;
            decimal precio;

            do
            {
                Console.WriteLine("\nIngrese del precio del auto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl precio no puede permancer vacio");
                    continue;
                }

                if (!decimal.TryParse(ingreso, out precio))
                {
                    Console.WriteLine("\nEl precio debe de ser un tipo numerico decimal válido");
                    continue;
                }

                if (precio < 0)
                {
                    Console.WriteLine("\nEl precio de un auto no puede ser negativo");
                    continue;
                }

                break;
            } while (true);

            return precio;
        }
    }
}
