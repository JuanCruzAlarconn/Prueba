using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_01_10
{
    class Telefono
    {
        public string Tipo { get; set; }

        public int Numero { get; set; }

        public static Telefono Crear(string linea)
        {
            Telefono tel = new Telefono();

            string[] arreglo = linea.Split(';');

            tel.Tipo = arreglo[0];
            tel.Numero = Convert.ToInt32(arreglo[1]);

            return tel;
        }

        public void grabar(StreamWriter escribir, int dni)
        {
            escribir.WriteLine(dni + ";" + Tipo + ";" + Numero);
        }
    }
}
