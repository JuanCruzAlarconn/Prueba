using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Ejercicio
    {
        public void ejercicio13()
        {
            Console.WriteLine("ingrese una primer cadena");
            string cadena1 = Console.ReadLine();
            Console.WriteLine(  "\nIngrese una segunda cadena\n");
            string cadena2 = Console.ReadLine();

            int longitud1 = cadena1.Length;
            int longitud2 = cadena2.Length;

            if(longitud1==longitud2)
            {
                Console.WriteLine("\n Ambas cadenas cuentan con la misma longitud");
            }
        }

        public void ejercicio14()
        {
            Console.WriteLine("ingrese una cadena");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("\nIngrese una segunda cadena\n");
            string cadena2 = Console.ReadLine();

            cadena1 = cadena1.ToUpper();
            cadena2 = cadena2.ToUpper();

            if(cadena1==cadena2)
            {
                Console.WriteLine("Ambas cadenas cuentan con el mismo contenido descartando las variaciones entre mayusculas y minusculas");
            }

        }
    }
}
