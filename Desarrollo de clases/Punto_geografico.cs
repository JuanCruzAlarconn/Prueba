using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desarrollo_de_clases
{
    class Punto_geografico
    {
        public string direccion { get; set; }
        public string localidad { get; set; }

        public string provincia { get; set; }

        public string region { get; set; }

        public string pais { get; set; }

        public static Punto_geografico crear()
        {
            Punto_geografico punto_geografico = new Punto_geografico();

            punto_geografico.pais = asignar("pais");

            if (punto_geografico.pais == "Argentina")
            {

                punto_geografico.direccion = asignar("dirección");
                punto_geografico.localidad = asignar("localidad");
                punto_geografico.provincia = asignar("provincia");
                punto_geografico.region = asignar("región");
            }
            else
            {
                punto_geografico.direccion = asingar_extranjero();
                punto_geografico.localidad = null;
                punto_geografico.provincia = null;
                punto_geografico.region = null;
            }

            return punto_geografico;

        }

        private static string asingar_extranjero()
        {
            throw new NotImplementedException();
        }

        private static string asignar(string campo)
        {
            throw new NotImplementedException();
        }

        public static string tipo_envio(Punto_geografico A, Punto_geografico B)
        {
            string tipo = "";

            if(A.localidad==B.localidad)
            {
                tipo = "local";

            }

            if(A.region==B.region)
            {
                tipo = "regional";
            }

            if(A.pais==B.pais)
            {
                tipo = "internacional";
            }

            return tipo;
        }
    }
}
