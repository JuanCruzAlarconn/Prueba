using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Ejercicios
    {
        Dictionary<int, decimal> lista_producto = new Dictionary<int, decimal>();
        Dictionary<int, decimal> lista_precio = new Dictionary<int, decimal>();
        public void ejercicio46()
        {
            cargar_precios();

            generar_pedido();

            Console.WriteLine("\nA Continuación se mostraran por pantalla el contenido de las diferentes listas que formaron parte del programa y corrieron en paralelo");

            Console.WriteLine("\nLista de precios");

            foreach (KeyValuePair<int, decimal> x in lista_precio )
            {
                Console.WriteLine("\nCodigo de producto: {0} Precio del producto: {1}", x.Key,x.Value);
            }

            Console.WriteLine("\nLista de compras ingresadas");

            foreach(KeyValuePair<int, decimal> x in lista_producto)
            {
                Console.WriteLine("\nCodigo de producto: {0} Precio del producto: {1}", x.Key,x.Value);
            }

            Console.WriteLine("\n*****************EL PROGRAMA HA FINALIZADO SATISFACTORIAMENTE***********************");
        }

        public void generar_pedido()
        {
            int producto = 0;
            decimal precio = 0;
            decimal acumulador = 0;

            do
            {
                Console.WriteLine("\nIngrese el código de producto para poder genera el pedido");
                producto = ingreso_producto(lista_producto);

                if(producto==0)
                {
                    Console.WriteLine("\nHa ingresado un código de producto igual a cero por lo que finalizara la carga de la lista correspondiente");

                }
                else if (!lista_precio.TryGetValue(producto, out precio))
                {
                    Console.WriteLine("\nEl código de producto ingresado no se corresponde con la lista de elementos que se halla previamente cargada");
                }
                else
                {
                    acumulador = acumulador + precio;
                    lista_producto.Add(producto, precio);//agrego el segmento correpondiente a la lista de compras por fuera de la lista de precios que corre en paralelo

                    Console.WriteLine("\nSe ha ingresado correctamente el producto dentro de la lisa de compras");
                }

            } while (producto != 0);//cuando cargo un código de producto en cero el programa deja de cargar la lista de productos

            Console.WriteLine("\nEl monto total de la compra es de: {0}", acumulador);
        }

        public void cargar_precios()
        {
            int producto;
            decimal precio;
           
            do
            {
                producto = ingreso_producto(lista_precio);

                precio = ingreso_precio(producto);

                if (precio != 0)
                {
                    lista_precio.Add(producto, precio);
                    Console.WriteLine("\nSe ha cargado el precio del producto correctamente");
                }


            } while (precio != 0);
        }
        

        public decimal ingreso_precio(int producto)
        {

            decimal precio = 0;
            string ingreso = "";
            bool flag = true;

            do
            {
                Console.WriteLine("Ingrese el precio del producto {0}", producto);
                ingreso = Console.ReadLine();
                flag = validar_precio(ingreso, ref precio);

            } while (flag);

            precio = Convert.ToDecimal(ingreso); //para mayor seguridad le agrego un punto de conversión adicional

            return precio;

        }

        public bool validar_precio(string ingreso, ref decimal precio)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo puede dejar el campo de carga de precio vacio");
            }
            else if (!decimal.TryParse(ingreso, out precio))
            {
                Console.WriteLine("\nDebe de imgresar un tipo numerico válido");
            }
            else if (precio==0)
            {
                Console.WriteLine("\nHa decidido finalizar con la carga de precios");
            }
            else if (precio<0)
            {
                Console.WriteLine("\nEl precio debe de ser positivo");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public int ingreso_producto(Dictionary<int,decimal> lista)
        {
            int producto=0;
            bool flag = true;

            do
            {
                Console.WriteLine("Ingrese el código de producto");
                string ingreso = Console.ReadLine();
                flag = validar_ingreso_producto(ingreso, ref producto, lista);
            } while (flag);



            return producto;
           




        }

        public bool validar_ingreso_producto(string ingreso, ref int producto, Dictionary<int,decimal> lista)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("Debe de completar el espacio de ingreso");
            }
            else if (!Int32.TryParse(ingreso, out producto))
            {
                Console.WriteLine("Debe de ingresar un tipo numérico válido");
            }
            else if (producto<0)
            {
                Console.WriteLine("Debe de ingresar un codigo de producto positivo en numeros");
            }
            else if (lista.ContainsKey(producto)==true)
            {
                Console.WriteLine("El código de producto ingresado ya forma parte del diccionario, por lo que no puede volver a ingresar el mismo");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

       
    }
}
