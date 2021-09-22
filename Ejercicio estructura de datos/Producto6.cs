using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Producto6
    {
        public decimal cantidad { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal total { get
            {
                return cantidad * precio;
            
            } }

        public static Producto6 Crear()
        {
            Producto6 producto = new Producto6();

            producto.cantidad = asignar_numerico("cantidad");
            producto.precio = asignar_numerico("precio");
            producto.nombre = asignar_nombre();

            Console.WriteLine("\nSe ha generado satisfactoriamente un nuevo producto con todos sus campos correspondientes");
            return producto;
        }

        private static string asignar_nombre()
        {
            throw new NotImplementedException();
        }

        private static decimal asignar_numerico(string v)
        {
            throw new NotImplementedException();
        }
    }
}
