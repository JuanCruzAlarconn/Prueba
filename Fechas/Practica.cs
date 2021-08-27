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


        public void ejercicio28()
        {
            //definir si un año ingresado es bisiesto

            string ingreso;
            int año;
            bool flag = true;

            do

            {
                Console.WriteLine("\nIngrese un año\n");
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("No puede dejar vacio el campo de ingreso");
                }
                else if (!int.TryParse(ingreso, out año))
                {
                    Console.WriteLine("Debe de ingresar un año numérico");
                }
                else
                {
                    flag = false;
                }

            } while (flag);

            año = Convert.ToInt32(ingreso);

            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("Es un año bisiesto el año ingresado");
            }
            else
            {
                Console.WriteLine("No es un año bisiesto");
            }
        }

        public void ejercicio29()
        {
            DateTime fecha;
            string ingreso;
            bool flag = true;
            do
            {
                Console.WriteLine("ingrese una fecha por teclado");
                ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out fecha))
                {
                    Console.WriteLine("El elemento ingresado no se corresponde con un elemento del tipo fecha");
                }
                else
                {
                    flag = false;
                }
            } while (flag);

            fecha = fecha.AddMonths(-1);

            string mes = fecha.ToString("MM");

            string anterior = "01/" + mes + "/"+fecha.ToString("yyyy");

            DateTime fecha_salida = Convert.ToDateTime(anterior);

            Console.WriteLine("La fecha del primero del mes anterior a la fecha ingresada es: {0}", fecha_salida);

        }

        public void ejercicio30()
        {
            DateTime fecha;
            string ingreso;
            bool flag = true;
            do
            {
                Console.WriteLine("ingrese una fecha por teclado");
                ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out fecha))
                {
                    Console.WriteLine("El elemento ingresado no se corresponde con un elemento del tipo fecha");
                }
                else
                {
                    flag = false;
                }
            } while (flag);

            Console.WriteLine("La hora ingresada es: {0}", fecha.Hour.ToString());


        }
    }
}
