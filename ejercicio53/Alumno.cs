using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio53
{
    class Alumno
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int telefono { get; set; }

        public int dni { get; private set; }


        public static Alumno crear()
        {
            Alumno alumno = new Alumno();

            alumno.nombre = ingreso("nombre");
            alumno.apellido = ingreso("apellido");
            alumno.telefono = ingreso_telefono();
            alumno.dni = ingreso_dni();

            return alumno;
        }

        public static int ingreso_dni()
        {
            string ingreso;
            int numero;

            do
            {
                Console.WriteLine("\nIngrese el dni del alumno a ingresar");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nDebe de ingresar un dni válido");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out numero))
                {
                    Console.WriteLine("\nEl dni debe de ser numérico");
                    continue;
                }

                if (ingreso.Length < 8)
                {
                    Console.WriteLine("\nEl número de dni debe de contar con 8 digitos");
                    continue;
                }

                if (numero < 1)
                {
                    Console.WriteLine("\nEl dni debe de ser positivo");
                    continue;
                }

                bool flag = Agenda.validar_dni(numero);

                if (flag == false)
                {
                    Console.WriteLine("\nYa hay un elemento dentro de la agenda con el mismo número de dni");
                    continue;
                }

                break;


            } while (true);

            return numero;

        }

        private static int ingreso_telefono()
        {
            string ingreso;
            int numero;

            do
            {
                Console.WriteLine("\nIngrese el telefono del alumno a ingresar");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nDebe de ingresar un teléfono válido");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out numero))
                {
                    Console.WriteLine("\nEl teléfono debe de ser numérico");
                    continue;
                }

                if (ingreso.Length < 10)
                {
                    Console.WriteLine("\nEl número de teléfono debe de contar con 10 digitos");
                    continue;
                }

                if (numero < 1)
                {
                    Console.WriteLine("\nEl teléfono debe de ser positivo");
                    continue;
                }

                bool flag = Agenda.validar_telefono(numero);

                if (flag == false)
                {
                    Console.WriteLine("\nYa hay un elemento dentro de la agenda con elk mismo numérico de telefono");
                    continue;
                }

                break;


            } while (true);

            return numero;

        }

        private static string ingreso(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0} del alumno a generar", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl {0} no puede ser vacio", campo);
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("El {0} no puede contener elementos numéricos", campo);
                    continue;
                }

                if(ingreso.Length<2)
                {
                    Console.WriteLine("\nNo puede ingresar un {0} tan corto", campo);
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
