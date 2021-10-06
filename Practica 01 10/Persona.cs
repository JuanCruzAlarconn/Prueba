using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_01_10
{
    class Persona
    { 
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Documento { get; set; }
        public DateTime Fecha_nacimiento { get; set; }

        public List<Telefono> lista_telefono { get; set; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int documento, DateTime fecha_nacimiento)
        {
            Nombre = nombre;
            Documento = documento;
            Apellido = apellido;
            Fecha_nacimiento = fecha_nacimiento;
            
        }

       public string escribir()
        {
            string cadena = Nombre + ";" + Apellido + ";" + Documento + ";" + Fecha_nacimiento;

            return cadena;
        }


        public static Persona Crear(string linea)
        {
            string[] arreglo = linea.Split(';');

            Persona persona = new Persona();
            persona.Nombre = arreglo[0];
            persona.Apellido = arreglo[1];
            persona.Documento = Convert.ToInt32(arreglo[2]);
            persona.Fecha_nacimiento = Convert.ToDateTime(arreglo[3]);

            return persona;

        }

        public void grabar(StreamWriter escribir_persona, StreamWriter escribir_telefono)
        {
            escribir_persona.WriteLine($"({ Nombre}; {Apellido}; {Documento}; {Fecha_nacimiento})");

           

            foreach(var t in lista_telefono)
            {
                t.grabar(escribir_telefono, Documento);
            }

            Console.WriteLine("\nLa intancia persona fue guardada satisfactoriamente dentro de la base de datos del programa");

        }
          
        }
}
