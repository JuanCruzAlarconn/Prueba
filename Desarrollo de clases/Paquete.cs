using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desarrollo_de_clases
{
    class Paquete
    {
        public decimal peso { get; set; }
        public int codigo { get; set; }
        public string descripción { get; set; }


        public static Paquete crear()
        {
            var paquete = new Paquete();

            paquete.codigo = asignar_codigo();
            paquete.peso = asignar_peso();
            paquete.descripción = asignar_descripcion();

            return paquete;

        }

        private static decimal asignar_peso()
        {
            throw new NotImplementedException();
        }

        private static string asignar_descripcion()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }
    }
}
