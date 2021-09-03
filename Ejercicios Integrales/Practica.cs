using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Integrales
{
    class Practica
    {
        public void ejercicio54()
        {
            ingreso();

        }

        public void ingreso()
        {
            char opcion=' ';
            string ingreso = " ";
            bool flag = true;
            do
            {
                mostrar_menu();
                ingreso = Console.ReadLine();
                flag = validar_ingreso(ingreso, ref opcion);

                if (flag == true)
                {
                    asignar_opcion(opcion);
                }

            } while (ingreso != "i");//La única forma de parar el ciclo es cuando el usuario quiere para el ciclo sino siguen avanzando
        }

        public void asignar_opcion(char opcion)
        {
            switch(opcion)
            {
                case 'a':
                    alta_alumno();// Se da de alta un alumno dentro del sistema con todos sus datos, pero se deja sus asignaciones pendientes
                    break;
                case 'b':
                    alta_curso();//doy de alta un curso con sus datos, pero no le asigno ningun alumno solo referencio la lista correspondiente
                    break;
                case 'c':
                    asignar_alumno();//Tomo un alumno y un curso hago la asignación cruzada correspondiente
                    break;
                case 'd':
                    desasignar_alumno();//Tomo un alumno me arroja una cantidad de cursos y elijo a cual me quiero dar de baja
                    break;
                case 'e':
                    ver_alumnos_asignados(); // Toma un curso y devuelve la lista de alumnos que tiene asignados
                    break;
                case 'f':
                    ver_cursos_asignados();//Toma un alumno y da a cuantos cursos se halla asignado
                    break;
                case 'g':
                    cantida_alumnos_por_curso();//devulve la cantida de alumnos que tienen todos los cursos que se dieron de alta dentro del programa
                    break;
                case 'h':
                    cantidad_cursos_por_alumno();//devulve una lista de todos los alumnos en donde se indica cuantos cursos asginados tiene cada uno de ello
                    break;
                case 'i':
                    Console.WriteLine("\nHa seleccionado finalizar con la ejecución del programa");
                    break;
                default:
                    Console.WriteLine("\nLa opcion ingresada no se corresponde con ninguna de las opciones disponibles");
                    break;



            }
        }

        public  bool validar_ingreso(string ingreso, ref char opcion)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo puede ingresar caracteres nulos como una de las opciones disponibles");
                flag = false;
            }
            else if (!char.TryParse(ingreso, out opcion))
            {
                Console.WriteLine("\nDebe de ingresar unicamente un solo caracter en el campo de ingreso");
                flag = false;
            }

            return flag;
        }


        public void mostrar_menu()
        {
            Console.WriteLine("\nSeleccione alguna de las siguientes opciones\n");
            Console.WriteLine("a.   Dar de alta un alumno (Número de registro y nombre completo)");
            Console.WriteLine("b.	Dar de alta un curso (se ingresa el código del curso)");
            Console.WriteLine("c.	Asignar un alumno a un curso");
            Console.WriteLine("d.	Desasignar un alumno de un curso");
            Console.WriteLine("e.	Ver la lista de alumnos asignados a un curso.");
            Console.WriteLine("f.	Ver los cursos a los que está asignado un alumno.");
            Console.WriteLine("g.	Ver la cantidad de alumnos en cada curso");
            Console.WriteLine("h.	Ver la cantidad de cursos de cada alumno.");
            Console.WriteLine("i.   Finalizar con la ejecución del programa como tal");
            Console.WriteLine("\n**************************************************************************\n");
            
        }
    }
}
