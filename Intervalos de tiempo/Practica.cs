using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos_de_tiempo
{
    class Practica
    {
        public void ejercicio33()
        {
            Console.WriteLine("Ingrese una fecha por teclado");
            string ingreso = Console.ReadLine();
            DateTime fecha = Convert.ToDateTime(ingreso);

            DateTime fin_año = Convert.ToDateTime("31/12/2021");

            TimeSpan rango = fin_año - fecha;

            Console.WriteLine("La cantida de días que faltan hasta el próximo fin de año es de {0}", rango.Days);
        }

        public void ejercicio32()
        {
            Console.WriteLine("Ingrese la primer fecha por teclado");
            string ingreso1 = Console.ReadLine();
            DateTime fecha1 = Convert.ToDateTime(ingreso1);

            Console.WriteLine("\nIngrese la segunda fecha por teclado");
            string ingreso2 = Console.ReadLine();
            DateTime fecha2 = Convert.ToDateTime(ingreso2);
            TimeSpan intervalo;

            if (fecha1 > fecha2)
            {

                intervalo = fecha1 - fecha2;
            }
            else
            {
                intervalo = fecha2 - fecha1;
            }

            Console.WriteLine("\n INTERVALOS");
            Console.WriteLine("{0} DÍAS", intervalo.TotalDays);
            Console.WriteLine("{0} MESES", intervalo.TotalDays/30 );
            Console.WriteLine("{0} AÑOS", intervalo.TotalDays / 360);
        }
    }
}
