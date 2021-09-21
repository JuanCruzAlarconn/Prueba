using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_de_ejercicio_de_clase_16_09
{
    class Venta
    {
        public static readonly List<Venta> ventas = new List<Venta>();

        public decimal total { get; private set; }

        public List<Producto> lista_producto = new List<Producto>();

        public int cliente { get; private set; }


        public static Venta Crear()
        {
            Venta v = new Venta();

            v.cliente = asignar_cliente();
            v.lista_producto = asignar_lista_productos();

            return v;
        }

        private static List<Producto> asignar_lista_productos()
        {
            List<Producto> lista_producto = new List<Producto>();

            do
            {
                Console.WriteLine("\nIngrese s para agregar un nuevo producto a la lista de compra");
                if (Console.ReadKey(true).Key != ConsoleKey.S)

                {
                    Console.WriteLine("\nComo no ha ingresado elemento similar a s se detiene la carga de elementos dentro de la lista de compra");
                    break;
                }
               var p = Producto.Crear();

                lista_producto.Add(p);

            } while (true);

            Console.WriteLine("\nSe ha completado la carga de elementos dentro de la lista de venta");

            return lista_producto;
        }

        private static int asignar_cliente()
        {
            string ingreso;
            int id;

            do
            {
                Console.WriteLine("\nIngrese el nombre del cliente");
                ingreso = Console.ReadLine();

                if(string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl nombre del cliente no puede ser vacio");
                    continue;
                }
                if(ingreso.Length<2)
                {
                    Console.WriteLine("\nEl nombre del cliente debe de contener por lo menos 2 elementos");
                    continue;
                }

                if(ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl nombre del clinte no puede contener elementos numéricos");
                    continue;
                }

                break;
            }
        }
    }
}
