using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenido al progra de carga de personas");

            do
            {
                Console.WriteLine("\nIngrese S si quiere ingresar una nueva persona N para dentener al carga de personas");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    Persona persona = Persona.Crear();
                    continue;
                }

                if(Console.ReadKey(true).Key==ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido finalizar con al carga de personas");
                    break;
                }


            } while (true);


            Console.WriteLine("\nHa finalizado la ejecución del programa, ingrese una tecla para detener la ejecución de la consola");
            Console.ReadKey();
        }
    }
}
