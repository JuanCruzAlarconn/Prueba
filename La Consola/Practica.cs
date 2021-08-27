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
    }
}
