using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_c
{
    class Persona
    {
        //internal-> solo lo que esta dentro del proyecto puede acceder a la propiedad DNI
        //private solo la clase persona puede acceder a la propiedad no desde otras clases

        public int DNI { get; set; } //El atributo se puede leer y escribir, y como es público puede ser accedido desde cualquier caso o sistema

        public string nombre { get; private set; } //desde este punto de vista unicamente puedo leer el atributo más no lo puedo modificar

      //  public string pass { private get; set; } //la contraseña la puedo introducir más nunca debe de poder ser leida dado que corresponde a un parametro de seguridad para el sistema en conjunto

        //Hay que intentar abstraernos de la estructura interna del objeto e intentar usarlo como si se tratase de una unidad
        //El problema surje a la hora de que quiero modifcar algunos de los atributos de la persona y eso seguro me tira un grave error
        //Hay que intentar modularizar y que la clase persona haga todo a partir de sus propios métodos de clase como talç

      /*  private Persona()
        {
            //sorpresa un constructor privado para la persona, no puedo generar una nueva persona simplemente con el new

        }

        public static Persona crear_persona()
        {
            return new Persona();
        }
      */

        public Persona()
        {
            //constructor por defecto
        }

        public Persona(int dni)
        {
            DNI = dni;//esta es la única forma de poder generar un objeto y poder cargar el campo dni dentro del objeto inicializadod
        }

        public static Persona alta_persona()
        {
            var persona = new Persona();

            //Dni

            string ingreso_dni = "";

            do
            {
                Console.WriteLine("Ingrese el Dni de la persona que quiere dar de alta");
                ingreso_dni = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso_dni))
                {
                    Console.WriteLine("\nNo puede dejar el campo de dni vacio");
                    break;// si ya se que ingreso vacio no tengo que hacer el resto de las comparaciones simplemente vuelvo hacer la consulta para poder cubrir el campo correspondiente
                }

                if (!Int32.TryParse(ingreso_dni, out int dni))
                {
                    Console.WriteLine("debe de ingresar un dni numérico");
                    continue;
                }

                if (dni > 60_000_000)
                {
                    Console.WriteLine("\nEl número de dni es demasiado grande y no se corresponde conun dni valido dentro del contexto demografico actual");
                    continue;
                }

                if(Agenda.existe_dni(dni))
                {
                    Console.WriteLine("\nEl dni ingresado ya forma parte de la agenda");
                }

                persona.DNI = dni;
            } while (persona.DNI == 0);


            //ingreso el nombre

            do
            {
                Console.WriteLine("ingrese el nombre de la persona cuyo dni es: {0}", persona.DNI);
                string ingreso_nombre = Console.ReadLine();

                if(string.IsNullOrEmpty(ingreso_nombre))
                {
                    Console.WriteLine("\nEl nombre de la persona no puede permacer en vacio");
                    continue;
                }

                bool flag = true;

            /*   for(int i=0; i<10;i++)
                {
                    if(ingreso_nombre.Contains(i.ToString()))
                    {
                        Console.WriteLine("\nEl nombre de una persona no puede contener elementos numéricos");
                        flag = false;
                        break; // para poder salir del for, si uno el continue se vuelve a repetir el ciclo for desde un comienzo
                    }
                }

                if(flag==false)
                {
                    continue;
                }

                */

                if (ingreso_nombre.Any(c=>char.IsDigit(c))
                  {
                    Console.WriteLine("\nEl nombre de la persona no puede contener elementos numéricos");
                    continue;
                }

            }
        }

        public static Persona seleccionar_persona()
        {
            throw new NotImplementedException();
        }

        public void modificar()
        {
            throw new NotImplementedException();
        }
    }
}
