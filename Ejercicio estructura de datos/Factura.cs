using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Factura
    {
        public static readonly List<Factura> lista_factura = new List<Factura>();

        public Cliente6 cliente { get; set; }

        public List<Producto6> lista_producto { get; set; }

        public decimal neto { get
            {
                decimal total = 0;
                foreach (var elemento in lista_producto)
                {
                    total = total + elemento.total;
                }
                return total;
            } }

        public decimal iva { get; set; }

        public decimal total_iva { get; set; }

        public decimal total_general { get; set; }



    }
}
