using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desarrollo_de_clases
{
    class Transporte
    {
        public int codigo { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; } //habla del estado de la unidad si puede seguir prestando servicio o debe de remitirse a mentenimiento
        public int? codigo_orden_asignada { get; set; }
        public decimal kilometros_recorridos_viaje { get; set; }

       

        public int? codigo_agencia { get; set; }//solo le es asignada en caso de que se necesite trasladar el paquete a domiciolio

        public bool? fin_de_viaje { get; set; }

        public static Transporte crear()
        {
            Transporte transporte = new Transporte();

            transporte.codigo = asignar_codigo();
            transporte.categoria = asignar_categoria();
            transporte.estado = asignar_estado();
            transporte.kilometros_recorridos_viaje = 0;
            transporte.codigo_agencia = asignar_agencia();

            return transporte;


        }

        private static int? asignar_agencia()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }

        private static string asignar_categoria()
        {
            throw new NotImplementedException();
        }

        private static string asignar_estado()
        {
            throw new NotImplementedException();
        }

        public void actualizar_estado()
        {
            throw new NotImplementedException();
        }

        public void ejecutar_mantemiento()
        {
            throw new NotImplementedException();
        }

        public void asignar_orden_de_servicio(int codigo_servicio)
        {
            throw new NotImplementedException();
        }

        public static List<Transporte> abrir_archivo()
        {
            throw new NotImplementedException();
        }

        public static int? ver_disponibilidad(int codigo_servicio,Punto_geografico origen, Punto_geografico destino, Paquete paquete)
        {
            //Evaluar si puede mandar un paquete de ese peso desde el punto de origen hacia el destino marcado
            List<Transporte> lista_transporte = Transporte.abrir_archivo();  //Debe de haber una apertura de un archivo donde lo paso hacia una lista para poder trabajar el contenido




            throw new NotImplementedException();
        }

        public static void Modificar_archivo(List<Transporte> lista_transporte)
        {
            //Ingreso de una lista modificada que sobreescribe la lista preexistente dentro del archivo


            throw new NotImplementedException();

        }
       
    }
}
