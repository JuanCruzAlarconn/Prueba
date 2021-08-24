using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nueva solución");

            persona p = new persona();

            p.nombre = "Juan Cruz";

            p.saludar();

            Console.WriteLine("Ingrese una tecla para finalizar con la ejecución del programa");
            Console.ReadKey();
        }
    }
}
