using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_7
{
    class Remito
    {
        public Cliente clinte { get; set; }

        public Producto producto { get; set; }

        public decimal peso_total { get
            {
                return producto.cantidad * producto.peso;
            } }
    }
}
