using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16_09_21
{
    class Venta
    {
        public string producto { get; private set; }//solamente dentro de la clase venta se puede definir el precio y el producto

        public decimal precio { get; private set; }

        public decimal cantidad { get; set; }

        public decimal total
        {
            get
            {
                return precio*cantidad;
            }
        }

        public  static Venta ingresar()
        {
            var nueva_venta = new Venta();
            string producto;
            do
            {
                Console.WriteLine("Ingrese el producto");
                producto = Console.ReadLine();

                if(string.IsNullOrEmpty(producto))
                {
                    Console.WriteLine("\nIngrese un producto válido");
                    continue;
                
                }

                if(producto.Length>15)
                {
                    Console.WriteLine("\nEl nombre del producto no puede contener más de 15 caracteres");
                    continue;
                }

                nueva_venta.producto = producto;
                break;


            } while (true);

           
            string ingreso;
            decimal precio;
            while(true)
            {
                Console.WriteLine("\nIngrese el precio del producto {0}", producto);
                ingreso = Console.ReadLine();

                if(!decimal.TryParse(ingreso, out precio))
                {
                    Console.WriteLine("El precio debe de ser numérico");
                    continue;
                }

                if(precio<=0)
                {
                    Console.WriteLine("\nEl precio no debe ser negativo");
                    continue;
                }
                nueva_venta.precio = precio;
                break;
            }

            return nueva_venta;

           // throw new NotImplementedException();
            //una excepción de que todavía no fue implementada la funcionalidad
            //Hay que llevarlo a este nivel de detalle para que la misma funcionen dentro del contexto aunque no se hallan desarrollado los procesos por separado
            //Luego de haber definido todo a este nivel hay que ser que los métodos sean consistentes
        }

        public void Mostrar_linea_consola()
        {
            //TODO: mostrar datos de la venta en una linea por consola

            //throw new NotImplementedException();
            //No es estático dado que es un método de instancia

            Console.WriteLine($"{producto, -20}{precio, 10}");

            //tengo el nombre del producto alineado a 20 caracteres a la izquierda mientras que el precio se halla a 10 caracteres a la derecha

        }
    }
}
