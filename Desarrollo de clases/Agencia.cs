using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Desarrollo_de_clases
{
    class Agencia
    {
        public Punto_geografico ubicacion { get; set; }
        public int codigo { get; set; }

        public static Agencia crear()
        {
            Agencia agencia = new Agencia();

            agencia.ubicacion = asignar_ubicacion();
            agencia.codigo = asignar_codigo();

            return agencia;
        }

        private static int asignar_codigo()
        {
            throw new NotImplementedException();
        }

        private static Punto_geografico asignar_ubicacion()
        {
            throw new NotImplementedException();
        }

        public static List<Agencia> abrir_archivo()
        {
            string agenciasJson = File.ReadAllText("Agencia.json");
            List<Agencia> lista_agencia = JsonConvert.DeserializeObject<List<Agencia>>(agenciasJson);

            return lista_agencia;
        }
    }
}
