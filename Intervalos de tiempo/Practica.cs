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

            TimeSpan rango = fecha - fin_año;

            Console.WriteLine("La cantida de días que faltan hasta el próximo fin de año es de {0}", rango.Days);
        }
    }
}
