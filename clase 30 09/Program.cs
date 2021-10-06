using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace clase_30_09
{
    class Program
    {
       static List<Persona> personas = new List<Persona>();
        static void Main(string[] args)
        {
            //Leer lista de personas dentro de un archivo


            //Pedir al user el ingreso de objetos

        /*    personas.Add(new Persona { nombre = "Juan", apellido = "Perez", dni = 38456910, fecha_nacimientos = new DateTime(12, 07, 1994) });
            personas.Add(new Persona { nombre = "Juana", apellido = "Torres", dni = 38456911, fecha_nacimientos = new DateTime(12, 07, 1995) });
            personas.Add(new Persona { nombre = "Lucas", apellido = "Gonzalez", dni = 38456912, fecha_nacimientos = new DateTime(12, 07, 1996) });
            personas.Add(new Persona { nombre = "Marcos", apellido = "Salas", dni = 38456913, fecha_nacimientos = new DateTime(12, 07, 1997) });
        */
           FileStream archivo = File.OpenWrite("personas.txt");//el tipo de dato que va a grabar el contenido del archivo
            var escribir = new StreamWriter(archivo);
            escribir.WriteLine("HOLA");
            escribir.WriteLine("COMO TE VA");
            escribir.Close();
            archivo.Close();//cada vez que se abra un archivo hay que cerrar todas las instancias.
            //El sistema supone que el archivo esta bien grabado lo que si pongo en duda es el ingreso del usuario en una forma inválida
            //Puede haber un gran problema en el momento de introducir un nombre con ; dentro del contexto dado que esa separación puede funcionar mal en cuanto a los separadores
            //El separados del cvv no puede forma parte de los datos que ingreso
            Console.WriteLine("\nEL archivo fue generado de forma satisfactoria");

            //El archivo se guardo en la ruta I:\CAI\clase 30 09\bin\Debug\netcoreapp3.1

            //puede pasar que si se genera un error no logro cerrar de forma definitiva el archivo

            using (var escribir2= new StreamWriter("Personas.txt"))
            {
                escribir.WriteLine("HOLA");
                escribir.WriteLine("otra vez");
                //con esto me estoy asegurando que el archivo se va a cerrar indististanmente de que se genere un error dentro del procediiento o tratamiento


            }
                Console.ReadKey();

        }
    }
}
