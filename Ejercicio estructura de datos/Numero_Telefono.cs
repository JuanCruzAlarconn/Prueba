using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Numero_Telefono
    {
        public string tipo { get; set; }
        public int codigo_pais { get; set; }
        public int codigo_area { get; set; }
        public int numero_telefono { get; set; }


        public static Numero_Telefono Crear()
        {
            Numero_Telefono numero = new Numero_Telefono();

            numero.tipo = asignar_tipo();
            numero.codigo_area = asignar_codigo("area");
            numero.codigo_pais = asignar_codigo("pais");
            numero.numero_telefono = asignar_telefono();

            Console.WriteLine("\nSe ha creado un teléfono satisfactoriamente");

            return numero;

        }

        private static int asignar_telefono()
        {
            throw new NotImplementedException();
        }

        private static int asignar_codigo(string v)
        {
            throw new NotImplementedException();
        }

        private static string asignar_tipo()
        {
            throw new NotImplementedException();
        }
    }
}
