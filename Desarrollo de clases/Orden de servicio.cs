using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_de_clases
{
    class Orden_de_servicio
    {
        public string estado { get; set; }
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public Paquete paquete { get; set; }
        public int codigo_transporte_asignado { get; set; }
        public int codigo_seguro { get; set; }
        public decimal precio { get; set; }
        public Punto_geografico origen { get; set; }
        public Punto_geografico destino { get; set; }
        public string modo_retiro { get; set; }
        public string modo_entrega { get; set; }
        public bool urgente { get; set; }

        public static Orden_de_servicio Crear()
        {
            Orden_de_servicio orden_de_servicio = new Orden_de_servicio();
            orden_de_servicio.codigo = asignar_codigo();
            orden_de_servicio.fecha = asignar_fecha();
            orden_de_servicio.codigo_transporte_asignado = asignar_transporte();
            orden_de_servicio.codigo_seguro = asignar_seguro();
            orden_de_servicio.origen = Punto_geografico.crear();
            orden_de_servicio.destino = Punto_geografico.crear();
            orden_de_servicio.modo_entrega = asignar_modo_entrega();
            orden_de_servicio.modo_retiro = asignar_modo_retiro();
            orden_de_servicio.urgente = asignar_urgencia();

            return orden_de_servicio;





        }

        private static bool asignar_urgencia()
        {
            throw new NotImplementedException();
        }

        private static string asignar_modo_retiro()
        {
            throw new NotImplementedException();
        }

        private static string asignar_modo_entrega()
        {
            throw new NotImplementedException();
        }

        private static int asignar_seguro()
        {
            throw new NotImplementedException();
        }

        private static int asignar_transporte()
        {
            throw new NotImplementedException();
        }

        private static DateTime asignar_fecha()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }
    }
}
