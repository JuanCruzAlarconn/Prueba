using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura9
{
    class Bulto
    {
        public int cantidad { get; set; }
        public decimal peso { get; set; }

        public Dimension dimension { get; set; }

        public decimal volumen { get
            {
                return dimension.alto * dimension.ancho * dimension.profundidad;
            } }
    }
}
