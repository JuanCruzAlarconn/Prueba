using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio53
{
    class Program
    {
        static void Main(string[] args)
        {
            ingresar_opcion();
        }

        public static void ingresar_opcion()
        {
            string ingreso;
            char opcion='F';

            do
            {
                mostrar_menu();
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nOpcion vacia invalida");
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nNo hay opciones numéricas");
                    continue;
                }

                if (ingreso.Length != 1)
                {
                    Console.WriteLine("\nSolo debe de ingresar un caracter para poder operar");
                    continue;
                }


                if (!char.TryParse(ingreso, out  opcion))
                {
                    Console.WriteLine("\nDebe de ingresar un caracter válido");
                    continue;
                }

                opcion = Convert.ToChar(ingreso);

                accion(opcion);


            } while (opcion!='F');
        }

        public static void accion(char opcion)
        {
            switch(opcion)
            {
                case 'A':
                    Alumno.crear();
                    break;
                case 'B':
                    Agenda.buscar_por_apellido();
                    break;
                case 'C':
                    Agenda.buscar_por_nombre();
                    break;
                case 'D':
                    Agenda.grabar_datos();
                    break;
                case 'E':
                    Agenda.leer_datos();
                    break;
                case 'F':
                    Console.WriteLine("\nHa ingresado la opción de poder finalizar la ejecución del programa");
                    break;
                default:
                    Console.WriteLine("\nLa opción ingresada no se corresponde con ninguna de las opciones disponibles");
                    break;
            }
        }

        public static void mostrar_menu()
        {
            Console.WriteLine("**********MENU DE OPCIONES*********");
            Console.WriteLine("A. Ingreso de nuevo alumno");
            Console.WriteLine("B. Buscar por apellido");
            Console.WriteLine("C. Buscar por nombre");
            Console.WriteLine("D. Grabar");
            Console.WriteLine("E. Leer");
            Console.WriteLine("F. Finalizar el programa");
            Console.WriteLine("************************************\n");
        }
    }
}
