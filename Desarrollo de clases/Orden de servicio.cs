using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desarrollo_de_clases
{
    class Orden_de_servicio
    {
       
        public int codigo { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime? fecha_egreso { get; set; } // Cuando nace el objeto permanece en null hasta que lo damos por finalizado, la clase transporte le da la fecha de fin
        public Paquete paquete { get; set; }
        public int? codigo_transporte_asignado { get; set; }
        public int? codigo_cliente { get; set; }//si queda en null es porque se trata de un cliente eventual, en tal motivo no cuenta con un código de cliente dentro del sistema
        public int codigo_seguro { get; set; }
        public decimal precio { get; set; }
        public Punto_geografico origen { get; set; }
        public Punto_geografico destino { get; set; }
        public string modo_retiro { get; set; }
        public string modo_entrega { get; set; }
        public bool urgente { get; set; }
        public int? codigo_agencia { get; set; }
        

        public static Orden_de_servicio Crear()
        {
            Orden_de_servicio orden_de_servicio = new Orden_de_servicio();
            orden_de_servicio.codigo_cliente = asignar_cliente();
            orden_de_servicio.codigo = asignar_codigo();
            orden_de_servicio.fecha_ingreso = asignar_fecha();
            orden_de_servicio.codigo_seguro = asignar_seguro();
            orden_de_servicio.origen = Punto_geografico.crear();
            orden_de_servicio.destino = Punto_geografico.crear();
            orden_de_servicio.paquete = asignar_paquete();
            orden_de_servicio.codigo_transporte_asignado = asignar_transporte(orden_de_servicio.codigo, orden_de_servicio.origen, orden_de_servicio.destino,orden_de_servicio.paquete);
            orden_de_servicio.modo_entrega = asignar_modo_entrega();
            orden_de_servicio.modo_retiro = asignar_modo_retiro();
            orden_de_servicio.urgente = asignar_urgencia();
            orden_de_servicio.codigo_agencia = asignar_agencia();

            return orden_de_servicio;





        }

        private static int? asignar_agencia()
        {
            throw new NotImplementedException();
        }

        private static int? asignar_cliente()
        {
            throw new NotImplementedException();
        }

        private static Paquete asignar_paquete()
        {
            throw new NotImplementedException();
        }

        public string consultar_estado()
        {
            throw new NotImplementedException();

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

        private static int? asignar_transporte(int codigo_servicio, Punto_geografico origen, Punto_geografico destino,Paquete paquete)
        {
           

            int? codigo_transporte = Transporte.ver_disponibilidad(codigo_servicio, origen,destino,paquete);
            //si no hay posibilidad de poder asignarle un medio de transporte queda como null la asignación

            return codigo_transporte;
        }

        private static DateTime asignar_fecha()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }

        public List<Orden_de_servicio> abrir_archivo()
        {
            var lista = new List<Orden_de_servicio>();


            return lista;
        }

        public void modificar_archivo(List<Orden_de_servicio> lista)
        {
            throw new NotImplementedException();

        }

        public void finalizar()
        {
            throw new NotImplementedException();
        }
    }
}
