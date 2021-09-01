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
            escribir.WriteLine("Hola mundo como estas en este día "+ DateTime.Now);

            Console.WriteLine("\nSe ha generado el archivo con el texto solicitado satisfactoriamente");

            escribir.Close();//Todo archivo que se abre debe de cerrarce dentro de la misma interacción por función especificada

        }

        public void ejercicio50()
        {
            //Leer el contenido de un archivo
            string ruta = "I:\\CAI\\Manejo de archivos\\base de datos.txt";

            FileInfo abrir = new FileInfo(ruta);

            if(!abrir.Exists)
            {
                Console.WriteLine("\nEl archivo en cuestión no se pudo abrir, por falla en la localización");
            }
            else
            {
                StreamReader leer = abrir.OpenText();//no le tengo que pasar la ruta del archivo dado que ya estaba abierto de antemano

                while(!leer.EndOfStream)
                {
                    //voy a llevar a cabo los ciclos hasta que llegue al último salto de linea que es cuando se detiene la lectura de los contenidos dado que por debajo de esta linea no hay más elementos que pudiere administrar como tal

                    string cadena = leer.ReadLine();

                    Console.WriteLine(cadena);//muestro el contenido de la cadena especificada dentro del archivo de texto

                    var arreglo = cadena.Split(' ');//genero un vector de string a partir del pasaje de otra cadena más generalizada y con ello muestro el contenido de las cadenas separadas por el caracter espacio

                    Console.WriteLine("\nA continuación se pasan a mostrar las cadenasd que componen la linea separadas por un espacio");
                    foreach(var a in arreglo)
                    {
                        Console.WriteLine(a+"\n");
                    }
                }

                leer.Close();
            }

        }
    }
}
