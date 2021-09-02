using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_clase_02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Practica ejercicio = new Practica();

            ejercicio.ejercicio1();

            Console.WriteLine("\nIngrese una tecla para finalizar con la ejecución del programa");

            Console.ReadKey();
        }
    }
}
