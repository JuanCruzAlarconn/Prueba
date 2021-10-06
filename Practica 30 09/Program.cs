using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_30_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "persona.txt";
            List<Persona> personas = new List<Persona>();

            using (var escribir= new StreamWriter(ruta))
            {
                escribir.WriteLine("Juan;Alarcón;38456910;12/07/1994");
                escribir.WriteLine("Leandro;Perez;38456789;25/08/1997");
            }

            Console.WriteLine("\nSe realizo de forma satisfactoria la generación de un nuevo archivo");

            using (var leer= new StreamReader(ruta))
            {
                while(!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();

                    personas.Add(Persona.Crear(linea));

                }
            }

            Console.WriteLine("\nSe ha abierto y cerrado el archivo {0}", ruta);

            foreach(var p in personas)
            {
                Console.WriteLine(p.Información());
            }

            Console.ReadKey();

        }
    }
}
