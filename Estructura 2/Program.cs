using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenido al sistema de carga de autos");

            do
            {
                Console.WriteLine("\nIngrese S para ingresar un auto y N para detener la carga de autos");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    Auto.Crear();
                    continue;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nSe ha detenido la carga de autos");
                    break;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.S && Console.ReadKey(true).Key != ConsoleKey.N)
                {
                    Console.WriteLine("\nLa opción ingresada no se corresponde con las disponible dentro del sistema");
                    continue;
                }
            } while (true);

            Console.WriteLine("\nHa finalizado la carga de autos, ingrese una tecla para poder finalizar la ejecución del programa");
            Console.ReadKey();
        }
    }
}
