using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Numero_Telefono
    {
        public string tipo { get; set; }
        public int codigo_pais { get; set; }
        public int codigo_area { get; set; }
        public int numero_telefono { get; set; }


        public static Numero_Telefono Crear()
        {
            Numero_Telefono numero = new Numero_Telefono();

            numero.tipo = asignar_tipo();
            numero.codigo_area = asignar_codigo("area");
            numero.codigo_pais = asignar_codigo("pais");
            numero.numero_telefono = asignar_telefono();

            Console.WriteLine("\nSe ha creado un teléfono satisfactoriamente");

            return numero;

        }

        private static int asignar_telefono()
        {
            string ingreso;
            int telefono;

            do
            {
                Console.WriteLine("\nIngrese el número de teléfono");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl número de teléfono no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out telefono))
                {
                    Console.WriteLine("\nEl numero de telefono debe de ser numérico");
                    continue;
                }

                if (ingreso.Length < 6 || ingreso.Length > 8)
                {
                    Console.WriteLine("\nEl número de teléfono debe tener entre 6 a 8 dígitos");
                    continue;

                }
                break;
            } while (true);

            return telefono;
        }

        private static int asignar_codigo(string codigo)
        {
            string ingreso;
            int cod;

            do
            {
                Console.WriteLine("\nIngrese el código de {0} del telefono", codigo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl código de {0} no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out cod))
                {
                    Console.WriteLine("\nEl código de {0} debe de ser numérico");
                    continue;
                }

                if (ingreso.Length != 2)
                {
                    Console.WriteLine("\nEl código de área debe de contener unicamente 2 dígitos");
                    continue;
                }

                break;

            } while (true);

            return cod;
        }

        private static string asignar_tipo()
        {
            throw new NotImplementedException();
        }
    }
}
