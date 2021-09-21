using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16_09_21
{
    class Program
    {
        static void Main(string[] args)//el punto de entrada de todo proyecto, puede estar en cualquier clase
        {
            //Los objetos son estructuras de datos
            //El código se puede ir creando con mimso detalle de la doc
            //Una clase venta otra de cliente y otra de sistema pueden ser diferentes instancias de la realidad
            //Cada clase debe de estar en su archivo
            //Hay que definir una clase para todo lo que necesite más de un dato básico
            //No deben usarce los datos más simples, sino que son solo los bloque con los que genero los objetos del sistema
            //Hay que generar clases para cada una de las diferentes instancias que debo de usar dentro del modelo
            List<Venta> ventas = new List<Venta>();
            do
            {
                Console.WriteLine("Ingresar una venta S/N");
                if (Console.ReadKey(true).Key != ConsoleKey.S)
                {
                    //Con el true no se muestar la letra que ingrese dentro de la consola
                    break; // Cuando no quiero ingresar venta salgo del ciclo
                }

                var nueva_venta = Venta.ingresar();

                ventas.Add(nueva_venta);

               

            } while (true);

            Console.WriteLine("\nLista resultate del accionar del programa");

            foreach (var venta in ventas)
            {
                venta.Mostrar_linea_consola();//los metodos son ordenes que le doy a los objetos instanciados u estaticos

            }

            Console.WriteLine("\nHa ingresado {0} ventas", ventas.Count);
            //El sistema a este nivel esta terminado

            Console.ReadKey();

        }
    }
}
