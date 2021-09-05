using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona=new Persona();//creo una nueva persona sin usar el new de forma explicita

          
            Console.WriteLine("Ingrese cualquier tecla para poder finalizar con la ejecución del programa");

            Console.ReadKey();
        }

        public static void dar_de_alta_persona()
        {
            //Alta de persona
            //Doy de alta un objeto persona desde la instancia de metodo de clase
            //Luego voy hasta la clase agenda que es estática dado que es una sola y le agrego la persona correspondiente que recien fue creada

            var persona=Persona.alta_persona();
            Agenda.agregar_persona(persona);

        }

        public static void baja_persona()
        {
            var persona = Persona.seleccionar_persona();

            Agenda.dar_baja(persona);
        }

        public static void modificar_persona()
        {
            var persona = Persona.seleccionar_persona(); //uso un método estatico
            persona.modificar();//Es simplemente un metodo de instanciación común y corriente
            Agenda.actualizar();

        }

        //sintaxis de continue vuelve a la primera linea del bloque por lo que repite el ciclo
        //Es mucho más eficiente para el manejo de errores que el do con las validaciones aparte

    }
}
