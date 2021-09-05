using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona=Persona.crear_persona();//creo una nueva persona sin usar el new de forma explicita


            Console.WriteLine("Ingrese cualquier tecla para poder finalizar con la ejecución del programa");

            Console.ReadKey();
        }
    }
}
