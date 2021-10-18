using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Desarrollo_de_clases
{
    class Transporte
    {
        public int codigo { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; } //habla del estado de la unidad si puede seguir prestando servicio o debe de remitirse a mentenimiento
        public int? codigo_orden_asignada { get; set; }
        public decimal kilometros_recorridos_viaje { get; set; }//Debería de verse actualizado periodicamente a partir de una función que cumpla con ciertos ciclos de tiempo
        public bool fin_de_viaje { get; set; }//campo que unicamente lo puede decir el conductor una vez que se llego a destino es decir a la sucursal mencionada
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
            //Abre el archivo de transporte y lo pasa a formato lista para poder operar

            string transporteJson=File.ReadAllText("Transporte.json");
            List<Transporte> lista = JsonConvert.DeserializeObject<List<Transporte>>(transporteJson);

            return lista;
        }

        public static int? ver_disponibilidad(int codigo_servicio,Punto_geografico origen, Punto_geografico destino, Paquete paquete)
        {
            //Evaluar si puede mandar un paquete de ese peso desde el punto de origen hacia el destino marcado
            List<Transporte> lista_transporte = Transporte.abrir_archivo();  //Debe de haber una apertura de un archivo donde lo paso hacia una lista para poder trabajar el contenido
            int? codigo = null;
            foreach(var transporte in lista_transporte)
            {
                if(transporte.codigo_orden_asignada==null && transporte.soportar_peso(paquete))
                {
                    transporte.codigo_orden_asignada = codigo_servicio;
                    transporte.fin_de_viaje = false;
                    transporte.kilometros_recorridos_viaje = 0;
                    codigo = transporte.codigo;
                    break;
                }
            }


            return codigo;
        }

        private bool soportar_peso(Paquete paquete)
        {
            //A partie de las caracteristicas del mismo objeto que la invoca debe de cotejar si resiste la carga de un paquete de las propiedades del objeto paquete
            throw new NotImplementedException();
        }

        public static void Modificar_archivo(List<Transporte> lista_transporte)
        {
            //Ingreso de una lista modificada que sobreescribe la lista preexistente dentro del archivo


            throw new NotImplementedException();

        }

        public static Transporte hallar(int codigo)
        {
            var lista = Transporte.abrir_archivo();
            var transporte = new Transporte();//envío una copia de la información

            foreach(var t in lista)
            {
                if(t.codigo==codigo)
                {
                    transporte = t;
                    break;
                }
            }

            return transporte;
        }

        public string estado_viaje()
        {
            string estado = "";

            if(kilometros_recorridos_viaje==0)
            {
                estado = "asignado, pero aun no inicio el viaje";
            }

            if(kilometros_recorridos_viaje!=0 && fin_de_viaje==false)
            {
                estado = "en curso";
            }

            if(kilometros_recorridos_viaje!=0 && fin_de_viaje==true)
            {
                estado = "fin";
            }

            return estado;



            

        }
       
    }
}
