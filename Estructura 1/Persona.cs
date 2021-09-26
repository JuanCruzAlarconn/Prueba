using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Estructura_1
{
    class Persona
    {
        public static readonly List<Persona> lista_persona = new List<Persona>();

        public int documento { get; private set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public DateTime fecha_nacimiento { get; set; }

        public string datos()
        {
            return documento + "-" + nombre + "-" + apellido + "-" + fecha_nacimiento;
        }

        public static Persona Crear()
        {
            Persona persona = new Persona();

            persona.documento = asignar_dni();
            persona.nombre = asignar_campo("Nombre");
            persona.apellido = asignar_campo("Apellido");
            persona.fecha_nacimiento = asignar_fecha();

            lista_persona.Add(persona);

            Console.WriteLine("\nSe ha creado satisfactoriamente una nueva instancia de persona");

            //apartado de guardado dentro de un archivo de texto
            string ruta = "I:\\CAI\\Estructura 1\\Personas estructura1.txt";

            StreamWriter escribir = new StreamWriter(ruta);

            escribir.WriteLine(persona.datos());

            escribir.Close();



            return persona;
        }

        private static DateTime asignar_fecha()
        {
            string ingreso;
            DateTime fecha_nacimiento;

            do
            {
                Console.WriteLine("\nIngrese su fecha de nacimiento");
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nNo ingreso caracter alguno dentro de la fecha de nacimiento");
                    continue;
                }

                if (!DateTime.TryParse(ingreso, out fecha_nacimiento))
                {
                    Console.WriteLine("\nDebe de ingresar un tipo de fecha de nacimiento válido para poder continuar con el programa");
                    continue;
                }

                if (fecha_nacimiento > DateTime.Now)
                {
                    Console.WriteLine("\nLa fecha de nacimiento no debe de ser mayor a la fecha actual de ejecución del programa");
                    continue;
                }

                break;
            } while (true);

            return fecha_nacimiento;
        }

        private static string asignar_campo(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0} de la persona a ingresar", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl {0} no puede permanecer vacio", campo);
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl {0} no puede contener caracteres numéricos dentro de su estructura", campo);
                    continue;
                }

                if (ingreso.Length > 30)
                {
                    Console.WriteLine("\nEl {0} no puede contener más de de 30 caracteres dentro de su estructura", campo);
                    continue;
                }



                break;


            } while (true);

            return ingreso;
        }

        private static int asignar_dni()
        {
            string ingreso;
            int dni;

            do
            {
                Console.WriteLine("\nIngrese el dni de la persona a crear");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl dni no puede estar vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out dni))
                {
                    Console.WriteLine("\nEl dni debe ser un valor numérico");
                    continue;
                }

                if (dni < 0)
                {
                    Console.WriteLine("\nEl dni debe de ser positivo");
                    continue;
                }

                if (ingreso.Length < 8)
                {
                    Console.WriteLine("\nEl dni no puede tener menos de 8 digitos");
                    continue;

                }

                Persona persona = lista_persona.Find(P => P.documento == dni);

                if (persona != null)
                {
                    Console.WriteLine("\nYa exite otra persona cargada con el mismo número de dni");
                    continue;

                }


                break;


            } while (true);

            return dni;
        }
    }
}
