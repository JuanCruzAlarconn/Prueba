using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoria_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var persona = Persona.crear_persona();

            /*   Console.WriteLine("\nMostrar datos de persona");

               Console.WriteLine("Nombre: {0} Apellido: {1} DNI: {2}", persona.nombre, persona.apellido, persona.dni);
            */

           var x= ingreso("nombre");
            var z = ingreso("apellido");

            Console.WriteLine("\nElmentos de los campos generados como tal");

            Console.WriteLine("\n Nombre: {0} Apellido: {1}",x,z);



            Console.WriteLine( "\ningrese una tecla para finalizar con la ejecución del programa");
            Console.ReadKey();
        }

        public static string ingreso(string campo)
        {
            string ingreso;
            do
            {
                Console.WriteLine("\nIngrese su {0}",campo);

                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nNo puede dejar el campo vacio");
                    continue;// solo funciona dentro de un ciclo do o similar solo no puede andar

                }

                if (ingreso.Length < 2)
                {
                    Console.WriteLine("\nUn nombre debe de contener por lo menos 2 letras");
                    continue;

                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl nombre no puede contener elementos numéricos");
                    continue;
                }


                break;

            } while (true);


            return ingreso;

        }
    }
}
