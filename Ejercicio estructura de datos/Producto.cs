using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Producto
    {
        public string codigo { get; set; }
        public string nombre_corto { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }
        public List<int> lista_componentes { get; set; }

        public static readonly List<Producto> lista_producto = new List<Producto>();

        public static Producto Crear()
        {
            Producto producto = new Producto();

            producto.codigo = asignar_codigo();
            producto.nombre_corto = asignar("nombre corto");
            producto.descripcion = asignar("descripción");
            producto.costo = asignar_numerico("costo");
            producto.precio = asignar_numerico("precio");
            producto.lista_componentes = asignar_componenetes();


            Console.WriteLine("\nSe ha creado una nueva instancia de producto");
            return producto;
        }

        private static List<int> asignar_componenetes()
        {
            List<int> componentes = new List<int>();
            
            int numero;

            do
            {
                Console.WriteLine("\nIngrese S para agregar un nuevo componente y N para finanlizar con la carga de componentes");

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nHa decidido finanlizar con la carga de componentes de productos");
                    break;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    numero = asignar_numero();
                    if (numero >0)
                    {
                        agregar_lista(componentes, numero);
                    }
                    continue;
                }

                else
                {
                    Console.WriteLine("\nNo se han ingresado opciones validas dentro de las disponibles");
                    continue;
                }
            } while (true);

            return componentes;
        }

        private static void agregar_lista(List<int> componentes, int numero)
        {
            bool flag = true;
            foreach(var num  in componentes)
            {
                if(num==numero)
                {
                    flag = false;
                }
            }

            if(flag==false)
            {
                Console.WriteLine("\nEl numero de componente ingresado ya se halla dentro de la lista de componenes del producto, por lo que no se agregara nuevamente");

            }
            else
            {
                componentes.Add(numero);
                Console.WriteLine("\nSe ha agregado exitosamente un nuevo componente propio del producto");
            }

        }

        private static int asignar_numero()
        {
            string ingreso;
            int numero = -1;

            do
            {
                Console.WriteLine("\nIngrese el número de componenete del producto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl código de componente no puede permanecer vacio");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out numero))
                {
                    Console.WriteLine("\nLos componentes son identificados por tipos numéricos");
                    continue;
                }

                if (numero < 0)
                {
                    Console.WriteLine("\nEl codigo de componente debe de ser un número positivo");
                    continue;
                }

                break;
            } while (true);




            return numero;
        }

        private static decimal asignar_numerico(string campo)
        {
            decimal numero;
            string ingreso;
            do
            {
                Console.WriteLine("\nIngrese el {0}", campo);
                ingreso = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede permancer vacio",campo);
                    continue;          
                }
                if(!decimal.TryParse(ingreso, out numero))
                {
                    Console.WriteLine("\nEl campo {0} debe de ser numérico", campo);
                    continue;
                }

                if(numero<=0)
                {
                    Console.WriteLine("\nEl campo {0} debe de ser un número positivo");
                    continue;
                }

                break;


            } while (true);

            return numero;
        }

        private static string asignar(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0} del producto", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede quedar vacio");
                    continue;
                }

                else if (campo == "nombre corto" && ingreso.Length > 15)
                {
                    Console.WriteLine("\nEl {0} del producto no puede contener más de 15 caracteres en su estructura", campo);
                    continue;

                }

                else if (campo == "descripción" && ingreso.Length > 200)
                {
                    Console.WriteLine("\nLa {0} del producto no puede exceder los 200 caracteres", campo);
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }

        private static string asignar_codigo()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el código de 6 caracteres del producto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl código de producto no puede permanecer vacio");
                    continue;
                }

                if(ingreso.Length!=6)
                {
                    Console.WriteLine("\nEl Código de producto debe de contar exactamente con 6 caracteres alfanuméricos");
                    continue;
                }

                Producto p = lista_producto.Find(a => a.codigo == ingreso);

                if(p!=null)
                {
                    Console.WriteLine("\nEl código de producto que intenta ingresar se corresponde con el código de otro producto existente dentro de la lista");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
