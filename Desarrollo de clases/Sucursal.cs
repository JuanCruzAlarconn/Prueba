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
    }
}
