using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manejo_de_archivos
{
    class Practica
    {
        public void ejercicio49()
        {
            string ruta = "I:\\CAI\\Manejo de archivos\\base de datos.txt";

            StreamWriter escribir = new StreamWriter(ruta); //no hace falta tener que hacer comprobaciónes dado que si el archivo no esta disponible se generara uno con el mismo nombre dentro de la ruta de acceso

            escribir.WriteLine("Hola mundo");

            Console.WriteLine("\nSe ha generado el archivo con el texto solicitado satisfactoriamente");

            escribir.Close();//Todo archivo que se abre debe de cerrarce dentro de la misma interacción por función especificada

        }
    }
}
