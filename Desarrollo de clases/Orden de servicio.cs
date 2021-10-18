using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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
        
        public int codigo_sucursal { get; set; }
        

        public static Orden_de_servicio Crear()
        {
            Orden_de_servicio orden_de_servicio = new Orden_de_servicio();
            orden_de_servicio.codigo_cliente = asignar_cliente();
            orden_de_servicio.codigo = asignar_codigo();
            orden_de_servicio.fecha_ingreso = asignar_fecha_ingreso();
            orden_de_servicio.fecha_egreso = asignar_fecha_egreso();
            orden_de_servicio.codigo_seguro = asignar_seguro();
            orden_de_servicio.origen = Punto_geografico.crear();
            orden_de_servicio.destino = Punto_geografico.crear();
            orden_de_servicio.paquete = Paquete.crear();
            orden_de_servicio.codigo_transporte_asignado = asignar_transporte(orden_de_servicio.codigo, orden_de_servicio.origen, orden_de_servicio.destino,orden_de_servicio.paquete);
            orden_de_servicio.modo_entrega = asignar_modo_entrega();
            orden_de_servicio.modo_retiro = asignar_modo_retiro();
            orden_de_servicio.urgente = asignar_urgencia();
            orden_de_servicio.codigo_agencia = asignar_agencia();
            orden_de_servicio.codigo_sucursal = asignar_sucursal();

            return orden_de_servicio;





        }

        private static int asignar_sucursal()
        {
            //Se habre un archivo en donde se puede derivar a la sucursal que sea la que cubre la localidad en concreto
            throw new NotImplementedException();
        }

     

        private static int? asignar_cliente()
        {
            //Se pasa el código de cliente corportativo en caso de existir, dado que si permanece en null implica que estoy tratando con un cliente eventual, por lo que se operara unicamente con el código de servicio
            throw new NotImplementedException();
        }

       
        public string consultar_estado()
        {
            //FUNCIÓN PRINCIPAL

            var lista = Orden_de_servicio.abrir_archivo();
            string estado = "";

            foreach(var orden in lista)
            {
                if(orden.codigo==this.codigo)
                {
                    
                    
                        var transporte = Transporte.hallar(Convert.ToInt32(this.codigo_transporte_asignado));

                        if(transporte.estado_viaje()== "asignado, pero aun no inicio el viaje")
                        {
                            estado = "\nEl paquete fue asignado satisfactoriamente a una unidad de traslado, pero la misma aún no ha iniciado su viaje hacia la sucursal";
                        }

                        if(transporte.estado_viaje()=="en curso")
                        {
                            estado = "\nEl paquete se halla en curso dentro de su viaje para poder llegar a destino";
                        }

                        if(transporte.estado_viaje()=="fin")
                        {
                        var sucursal = Sucursal.hallar(codigo_sucursal);


                        }

                    
                }
            }

            throw new NotImplementedException();

        }

        private static bool asignar_urgencia()
        {
            //En caso de que sea urgente el envío debe de facturarse con una tarifa más elevada
            throw new NotImplementedException();
        }

        private static string asignar_modo_retiro()
        {
            //Como llega a las inmediaciones de la sucursal para que sea distribuido
            throw new NotImplementedException();
        }

        private static string asignar_modo_entrega()
        {
            //Como debe de llegar a destino, si unicamente debo de enviar a una sucursal o se lo debo de entregar a destino a domicilio
            throw new NotImplementedException();
        }

        private static int asignar_seguro()
        {
            //Código de seguro del envío
            throw new NotImplementedException();
        }

        private static int? asignar_transporte(int codigo_servicio, Punto_geografico origen, Punto_geografico destino,Paquete paquete)
        {
           

            int? codigo_transporte = Transporte.ver_disponibilidad(codigo_servicio, origen,destino,paquete);
            //si no hay posibilidad de poder asignarle un medio de transporte queda como null la asignación

            return codigo_transporte;
        }

        private static DateTime asignar_fecha_ingreso()
        {
            //Cuando fue que el pedido fue despachado
            throw new NotImplementedException();
        }
        private static DateTime? asignar_fecha_egreso()
        {
            //Todo depende si el pedido fue realmente entregado siguiendo con las condiciones pautadas como tal, si no llego el campo permanece en null
            throw new NotImplementedException();
        }

        private static int asignar_codigo()
        {
            //Le asigno el codigo a la orden de servicio
            throw new NotImplementedException();
        }

        public static List<Orden_de_servicio> abrir_archivo()
        {
            var lista = new List<Orden_de_servicio>();
            string ordendeservicioJson = File.ReadAllText("Ordenes de servicio.Json");

            lista = JsonConvert.DeserializeObject<List<Orden_de_servicio>>(ordendeservicioJson);

            return lista;
        }

        public void modificar_archivo(List<Orden_de_servicio> lista)
        {
            //Sobreescribe con información actualizada
            throw new NotImplementedException();

        }

        public void finalizar()
        {
            //Indico que una entrega finalizo satisfactoriamente
            throw new NotImplementedException();
        }
    }
}
