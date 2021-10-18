using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Desarrollo_de_clases
{
    class Sucursal
    {
        public Punto_geografico ubicacion { get; set; }
        public int codigo { get; set; }

        public List<Orden_de_servicio> ordenes_asignadas {get; set;} //A medida que le van llegando los pedidos los almancenan en una lista 
       
        public List<Estado_de_orden> estado_ordenes// definido por el código de la orden más el estado de la misma definido por el tipo string

        public static Sucursal crear()
        {
            Sucursal sucursal = new Sucursal();

            sucursal.ubicacion = asignar_ubicacion();
            sucursal.codigo = asignar_codigo();

            return sucursal;
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }

        private static Punto_geografico asignar_ubicacion()
        {
            throw new NotImplementedException();
        }

        public static List<Sucursal> abrir_archivo()
        {
            string sucursalJson = File.ReadAllText("Sucursales.Json");

            List<Sucursal> lista_surcursal = JsonConvert.DeserializeObject<List<Sucursal>>(sucursalJson);

            return lista_surcursal;

        }

        public static Sucursal hallar(int codigo)
        {
            var lista = abrir_archivo();
            var sucursal = new Sucursal();//envío una copia de la información

            foreach(var s  in lista)
            {
                if(s.codigo==codigo)
                {
                    sucursal = s;
                    break;
                }
            }

            return sucursal;
        }

     
    }
}
