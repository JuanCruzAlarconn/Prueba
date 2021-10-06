using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_01_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona {Nombre= "Juan", Apellido="Alarcón", Documento= 38456910,Fecha_nacimiento= new DateTime(12/07/200), lista_telefono = { new Telefono {Tipo="Casa", Numero=1145788956 } } });
            personas.Add(new Persona { Nombre = "Juan", Apellido = "Alarcón", Documento = 38456912, Fecha_nacimiento = new DateTime(12 / 07 / 200), lista_telefono = { new Telefono { Tipo = "Casa", Numero = 1145788956 } } });



            //CARGAR DATOS DE LA LISTA DIRECTAMENTE SOBRE UN ARCHIVO, que como se genera no necesito de validación alguna

            using (var archivo = new StreamWriter("personas.txt"))
            {
                foreach(var p in personas)
                {
                    archivo.WriteLine(p.escribir());
                }
            }

            //Leer datos directamente de un archivo, no hay que cargarlos directamente sobre una lista para poder trabajar de forma más amena

            List<Persona> auxiliar = new List<Persona>();
            if (File.Exists("personas.txt"))
            {
                using (var leer = new StreamReader("personas.txt"))
                {
                    while (!leer.EndOfStream)
                    {
                        string linea = leer.ReadLine();
                        auxiliar.Add(Persona.Crear(linea));
                        //No hay que hacer validaciones sobre el código, dado que si algo falla es culpa de quien lo cargo
                    }
                }
            }
            else
            {
                Console.WriteLine("\nSe ha detectado un error en el momento de querer procesar los patrones presentes dentro del archivo señalado");
            }

            Console.WriteLine("\nCantida de personas dentro del archivo trabajado {0}", auxiliar.Count());

            Console.WriteLine("\nContenido del archivo");

            foreach(var p in auxiliar)
            {
                Console.WriteLine(p.escribir());
            }


            //Alternativa para guardar

            string ruta_persona = "Persona2.txt";
            string ruta_teléfono = "telefono 2.txt";

            using (var escribir_persona= new StreamWriter(ruta_persona))
            using (var escrbir_telefono= new StreamWriter(ruta_teléfono))
            {
                foreach(var p in personas)
                {
                    p.grabar(escribir_persona, escrbir_telefono);
                }
            }

                Console.WriteLine("\nIngrese una tecla para finalizar con la ejecución del programa");
            Console.ReadKey();
        }
    }
}
