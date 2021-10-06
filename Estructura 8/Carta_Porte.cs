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

        public static Carta_Porte Crear()
        {
            Carta_Porte carta_porte = new Carta_Porte();

            carta_porte.remitente = Remitente.Crear();
            carta_porte.destinatario = Destinatario.Crear();
            carta_porte.origen = Origen.Crear();
            carta_porte.destino = Destino.Crear();
            carta_porte.transporte = Transporte.Crear();
            carta_porte.bulto = Bulto.Crear();

            Console.WriteLine("\nSe ha creado satisfactoriamente una nueva instancia de la carta de porte dentro del sistema");

            return carta_porte;
        }

        public string información()
        {
            string linea="";
            //Hay que poder definir una elemento que permita convertir a texto mucho de los aspectos de la estrucutra de la clase en si, para que dentro del menú principal unicamente se llame al método y se autocomplete la información en consecuencia

            return linea;
        }
    }
}
