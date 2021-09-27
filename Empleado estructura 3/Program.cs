using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Empleado_estructura_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> lista_empleados = new List<Empleado>();

            Console.WriteLine("\nBienvenido al programa de carga de empleados");
            string ruta = "I:\\CAI\\Empleado estructura 3\\Empleado estructura 3.txt";
            StreamWriter escribir = new StreamWriter(ruta);

            do
            {
                Console.WriteLine("\nIngrese S para cargar un nuevo empleado y N para detener la carga de empleados");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    Empleado empleado = Empleado.Crear();
                    lista_empleados.Add(empleado);

                   

                    escribir.WriteLine(empleado.datos());

                    Console.WriteLine("\nSe ha cargada satisfactoriamente un nuevo empleado dentro de la base de datos");

                  

                    continue;

                }

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido detener la carga de empleados");
                    break;
                }

                if (Console.ReadKey(true).Key != ConsoleKey.N && Console.ReadKey(true).Key != ConsoleKey.S)
                {
                    Console.WriteLine("\nNinguna de las opciones ingresadas se corresponde con las opciones disponibles dentro del menú");
                    continue;
                }

            } while (true);

            escribir.Close();

            Console.WriteLine("\nIngrese cualquier tecla para finalizar con la ejecución del programa");
            Console.ReadKey();
        }
    }
}
