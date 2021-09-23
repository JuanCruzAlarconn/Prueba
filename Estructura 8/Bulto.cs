using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Bulto
    {
        public decimal peso { get; set; }
        public decimal cantidad { get; set; }

        public Dimension dimension { get; set; }

        public decimal volumen
        {
            get
            {
                return dimension.alto * dimension.ancho * dimension.profundidad;
            }
        }
    }
}
