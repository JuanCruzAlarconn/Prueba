using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Desarrollo_de_clases
{
    class Estado_de_orden
    {
       public int codigo_orden { get; set; }

        public string estado { get; set; }

        public static Estado_de_orden crear()
        {
            var orden = new Estado_de_orden();
            orden.codigo_orden = asignar_codigo_orden();
            orden.estado = asignar_estado();

            return orden;
        }

        private static string asignar_estado()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo_orden()
        {
            throw new NotImplementedException();
        }
        public void modificar_estado (string nuevo_estado)
        {
            this.estado = nuevo_estado;

        }

        public static List<Estado_de_orden> abrir_archivo()
        {
            var lista = new List<Estado_de_orden>();

            string estadosordenJson = File.ReadAllText("Estado de ordenes.Json");

            lista = JsonConvert.DeserializeObject<List<Estado_de_orden>>(estadosordenJson);

            return lista;
        }

        
    }
}
