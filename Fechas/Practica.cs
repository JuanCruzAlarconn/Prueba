using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Practica
    {
        public void ejercicio27()
        {
            DateTime fecha;
            string ingreso;
            bool flag = true;
            do
            {
                Console.WriteLine("ingrese una fecha por teclado");
                ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out  fecha))
                {
                    Console.WriteLine("El elemento ingresado no se corresponde con un elemento del tipo fecha");
                }
                else
                {
                    flag = false;
                }
            } while (flag);

            Console.WriteLine("{0} es la fecha 30 días posteriores a la fecha ingresada", fecha.AddDays(30));
            Console.WriteLine("{0} es la fecha 60 días posteriores a la fecha ingresada", fecha.AddDays(60));
            Console.WriteLine("{0} es la fecha 90 días posteriores a la fecha ingresada", fecha.AddDays(90));
            Console.WriteLine("{0} es la fecha 120 días posteriores a la fecha ingresada", fecha.AddDays(120));
        }
    }
}
