using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_8
{
    class Carta_Porte
    {
        public Remitente remitente { get; set; }
        public Destinatario destinatario { get; set; }
        public Origen origen { get; set; }
        public Destino destino { get; set; }
        public Transporte transporte { get; set; }
        public Bulto bulto { get; set; }
    }
}
