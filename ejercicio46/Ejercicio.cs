using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio46
{
    class Ejercicio
    {
        List<Producto> lista_productos = new List<Producto>();

        public void ejercicio46()
        {
            ingreso();
            lista_compra();



        }

        public void lista_compra()
        {
            int codigo;
            int cantidad;
            decimal acumulador = 0;

            do
            {
                Console.WriteLine("\nIngrese el producto de la lista");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngrese la cantidad del producto {0} que compra", codigo);
                cantidad = Convert.ToInt32(Console.ReadLine());

                if(codigo>0)
                {
                    Producto p = lista_productos.Find(a => a.codigo == codigo);

                    acumulador = acumulador + (p.precio * cantidad);

                }
                else
                {
                    Console.WriteLine("El código no se corresponde con ninguno de los parametros alojados en base de datos");
                }

            } while (codigo != 0);
        }

        public void ingreso()
        {
            string ingreso = "";
            decimal precio=0;
            int codigo_producto;
            do
            {
                Console.WriteLine("Ingrese el código del producto");
                ingreso = Console.ReadLine();
                codigo_producto = Convert.ToInt32(ingreso);

                Console.WriteLine("Ingrese el precio del producto");
                ingreso = Console.ReadLine();
                validar_precio(ref ingreso, ref precio);

                if (precio > 0 && codigo_producto > 0)
                {
                    Producto p = new Producto();
                    p.precio = precio;
                    p.codigo = codigo_producto;
                    lista_productos.Add(p);
                }

            } while (precio != 0);
        }

        public void validar_codigo_poducto(ref string ingreso, ref int codigo_producto)
        {
            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("Debe de ingresar un elemento");
            }
            else if(!Int32.TryParse(ingreso, out codigo_producto))
            {
                Console.WriteLine("Debe de ingresar un valor númerico");
            }
            else if (codigo_producto<=0)
            {
                Console.WriteLine("Debe de ingresar un valor positivo para el código del producto");
            }
            

        }

        public void validar_precio(ref string ingreso, ref decimal precio)
        {
            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("No puede estar vacio el espacio de ingreso");

            }
            else if (!decimal.TryParse(ingreso, out precio))
            {
                Console.WriteLine("\nDebe de ingresar un precio numérico");
            }
            else if (precio<0)
            {
                Console.WriteLine("Debe de ingresar un precio positivo mayor que cero");
            }
            else if (precio==0)
            {
                Console.WriteLine("Ha decidido finalizar con la carga de productos");
            }
           

        }
      }
}
