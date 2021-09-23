using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Estructura_7
{
    class Producto
    {
        public decimal cantidad { get; set; }

        public int codigo { get; set; }

        public decimal peso { get; set; }


        public static Producto Crear()
        {
           
            

            Producto producto = new Producto();

            producto.cantidad = asignar("cantidad");
            producto.peso = asignar("peso");
            producto.codigo = asignar_codigo();

            return producto;

        }

        private static decimal asignar(string campo)
        {
            decimal salida;
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el campo {0} del producto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} del producto no puede permanecer vacio");
                    continue;
                }

                if (!decimal.TryParse(ingreso, out salida))
                {
                    Console.WriteLine("\nEl campo {0} del producto debe de ser del tipo numérico decimal");
                    continue;
                }

                if (salida < 0)
                {
                    Console.WriteLine("\nEl campo {0} del producto debe ser positivo");
                    continue;
                }
                break;
            } while (true);

            return salida;
        }

        private static int asignar_codigo()
        {
            //Tomo los elementos del archivo del punto 5, por lo que voy directo al archivo y ejecuto una validación para poder ver si el código de producto se corresponde con alguno de los generados y aprobados por el programa

            List<int> codigo_producto = new List<int>();

            string ruta = "archivo5.txt";

            FileInfo archivo = new FileInfo(ruta);

            if (!archivo.Exists)
            {
                Console.WriteLine("\nEl archivo de donde debo de validar los códigos de productos no es accesible para poder operar");

            }
            else
            {
                StreamReader leer = archivo.OpenText();

                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();

                    string[] arreglo = linea.Split('|');

                    codigo_producto.Add(Convert.ToInt32(arreglo[4]));

                    //Hay una lectura dentro de la linea para poder acceder a los códigos de los productos
                }

                leer.Close();

            }

            int codigo;
            string ingreso;
            do
            {
                Console.WriteLine("\nIngrese el código de producto");
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nNo puede dejar vacio el código de producto");
                    continue;
                }

                if (!Int32.TryParse(ingreso, out codigo))
                {
                    Console.WriteLine("\nEl código de producto debe de ser numérico");
                    continue;
                }

                bool flag = false;

                foreach (var elemento in codigo_producto)
                {
                    if (elemento == codigo)
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    Console.WriteLine("\nEl código de producto no se corresponde con ninguno de los productos habilitados");
                    continue;
                }

                break;
            } while (true);

            return codigo;
        }
    }
}
