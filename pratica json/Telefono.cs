using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_json
{
    class Telefono
    {
        public string tipo { get; set; }
        public int numero { get; set; }

        public static Telefono Crear()
        {
            Telefono tel = new Telefono();

            tel.tipo = asignar_tipo();
            tel.numero = asignar_numero();

            return tel;


        }

        private static int asignar_numero()
        {
            string ingreso;
            int salida;

            do
            {
                Console.WriteLine("\nIngrese el número telefónico");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo no puede permanecer vacio");
                    continue;
                }

                if (Int32.TryParse(ingreso, out salida))
                {
                    Console.WriteLine("\nEl número de teléfono debe de ser numérico");
                    continue;
                }

                if (salida < 0)
                {
                    Console.WriteLine("\nEL número de teléfono debe ser positivo");
                    continue;
                }

                if (ingreso.Length != 8)
                {
                    Console.WriteLine("\nEl número debe de contar con 8 cifras exactamente");
                    continue;
                }
                break;
            } while (true);

            return salida;
        }

        private static string asignar_tipo()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el tipo de teléfono");
                ingreso = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl tipo de teléfono no puede estar vacio");
                    continue;
                }

                break;



            } while (true);

            return ingreso;
        }
    }
    }

