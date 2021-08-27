using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Consola
{
    class Practica
    {
        public void ejercicio4()
        {
            string ingreso;

            do
            {
                Console.WriteLine("ingrese cadenas hasta que al ingresar la cadena fin se detendrá la ejecución del código");
                ingreso = Console.ReadLine();

                if (ingreso == "fin")
                {
                    Console.WriteLine("\n Ha ingresado la cadena fin por lo que finanlizará la ejecución del programa\n");

                }
            } while (ingreso != "fin");
        }

        public void ejercicio5()
        {
            ConsoleKeyInfo tecla;
            Console.TreatControlCAsInput = true;

            do
            {
                Console.WriteLine("\nIngrece una combinación de teclas, el programa finaliza cuando ingrese la combinación control+F\n");
                tecla = Console.ReadKey(true);

                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    Console.WriteLine("La combinación de teclas presionadas es: control+{0}", tecla.Key.ToString());
                }
                else if ((tecla.Modifiers & ConsoleModifiers.Alt) != 0)
                {

                    Console.WriteLine("La combinación de teclas presionadas es: Alt+{0}", tecla.Key.ToString());
                }
                else if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    Console.WriteLine("La combinación de teclas presionadas es: Shift+{0}", tecla.Key.ToString());
                }
                else
                {
                    Console.WriteLine("Ha presionado la tecla: {0}", tecla.Key.ToString());
                }
            } while (!(((tecla.Modifiers & ConsoleModifiers.Control) != 0) && tecla.Key == ConsoleKey.F));

            

        }
    }
}
