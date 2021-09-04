using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Integrales
{
    class Practica
    {
        List<Alumno> lista_alumnos = new List<Alumno>(); //como estan por fuera de los metodos se puede acceder sin tener que hacer referencias de algún tipo dentro de los subprogramas
        List<Curso> lista_curso = new List<Curso>();
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
                    desasignar_alumno();//Paso al alumno y al curso al que quiero desasignar
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

        public void ver_cursos_asignados()
        {
            string ingreso_registro = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el numero de registro del alumno del cual quiera conocer los cursos que tiene asignados");
                ingreso_registro = Console.ReadLine();
                flag = validar_asignacion(ingreso_registro);

            } while (flag);

            int registro = Convert.ToInt32(ingreso_registro);

            Alumno alumno = lista_alumnos.Find(A => A.numero_registro == registro);

            Console.WriteLine("\nListado de cursos que tiene asignado el alumno {0}", alumno.nombre_completo);

            foreach(Curso curso in alumno.cursos_asignados)
            {
                Console.WriteLine("Código de curso: {0}", curso.codigo_curso);
            }

            Console.WriteLine("\nSe han mostrado satisfactoriamente todos los cursos que le fueron asignados a el alumno");

        }


        public void ver_alumnos_asignados()
        {
            string ingreso_curso = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el código de curso al que quiera ver los alumnos asignados");
                ingreso_curso = Console.ReadLine();
                flag = validar_asignacion_curso(ingreso_curso);//evalua si el curso ingresado se corresponde con alguno de la lsita
            } while (flag);

            int codigo_curso = Convert.ToInt32(ingreso_curso);

            Curso curso = lista_curso.Find(C => C.codigo_curso == codigo_curso);


            Console.WriteLine("\nAlumnos que componen al curso {0}",curso.codigo_curso);

            foreach(Alumno alumno in curso.lista_curso)
            {
                Console.WriteLine("Nombre: {0} Registro: {1}", alumno.nombre_completo,alumno.numero_registro);
            }

            Console.WriteLine("\nSe han mostrado satisfactoriamente cada uno de los diferente alumnos que integran el curso mencionado");

        }


        public void desasignar_alumno()
        {
            string ingreso_registro = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el número de registro del alumno que desea desasignar");
                ingreso_registro = Console.ReadLine();
                flag = validar_asignacion(ingreso_registro);

            } while (flag);

            //hasta aca tenogo el registro del alumno que quiero desasignar a los cursos

            int registro = Convert.ToInt32(ingreso_registro);

            Alumno alumno = lista_alumnos.Find(A => A.numero_registro == registro);

            flag = true;

            string ingreso_curso = "";

            do
            {
                Console.WriteLine("Ingrese el código del curso al que quiere desasignar al alumno {0}", alumno.nombre_completo);
                ingreso_curso = Console.ReadLine();
                flag = validar_desasignacion(ingreso_curso, alumno);

            } while (flag);

            int codigo_curso = Convert.ToInt32(ingreso_curso);

            Curso curso = lista_curso.Find(C => C.codigo_curso == codigo_curso);

            alumno.cursos_asignados.Remove(curso);
            curso.lista_curso.Remove(alumno);

            Console.WriteLine("\nSe ha removido satisfactoriamente al alumno del curso seleccionado");


        }

        public bool validar_desasignacion(string ingreso, Alumno alumno)
        {
            bool flag = true;

           
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nEl numero de curso no puede ser vacio");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("\nDebe de ingresar un tipo numérico dentro del numero de curso");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("\nEl número de curso debe de ser un número positivo");
            }
            else if (lista_curso.Find(C => C.codigo_curso == salida) == null)
            {
                Console.WriteLine("\nEl curso introducido no se corresponde con ninguno de los cursos disponibles dentro de la base del sistema");
            }
             
            else
            {
              Alumno hallado=  lista_curso.Find(C => C.codigo_curso == salida).lista_curso.Find(A => A.numero_registro == alumno.numero_registro);

                if(hallado==alumno)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("El alumno indicado no esta cursando este curso por lo que no es posible deasginar de un curso al que no esta asignado");
                }
            }

            return flag;


        }

        public void asignar_alumno()
        {
            string ingreso_registro = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el número de registro del alumno que desea asignar");
                ingreso_registro = Console.ReadLine();
                flag = validar_asignacion(ingreso_registro);
            } while (flag);

            int registro = Convert.ToInt32(ingreso_registro);

            Alumno a = lista_alumnos.Find(A => A.numero_registro == registro);

            string ingreso_curso = "";
            flag = true;
            do
            {
                Console.WriteLine("\nIngrese el código del curso al cual desea asignar al alumno: ");
                Console.WriteLine("NOMBRE: {0} REGISTRO: {1}", a.nombre_completo, a.numero_registro);

                ingreso_curso = Console.ReadLine();
                flag = validar_asignacion_curso(ingreso_curso);
            } while (flag);

            int codigo_curso = Convert.ToInt32(ingreso_curso);

            Curso c = lista_curso.Find(C => C.codigo_curso == codigo_curso);//Se genera un enlace sobre el objeto por lo que puedo modificar sus propiedades

            //a es el alumno que quiro asignar dentro del curos c

            a.cursos_asignados.Add(c);
            c.lista_curso.Add(a);

            Console.WriteLine("\nSe llevo a cabo la asignación del curso correspondiente");

           

        }

        public bool validar_asignacion_curso(string ingreso)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nEl numero de curso no puede ser vacio");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("\nDebe de ingresar un tipo numérico dentro del numero de curso");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("\nEl número de curso debe de ser un número positivo");
            }
            else if (lista_curso.Find(C=>C.codigo_curso==salida)==null)
            {
                Console.WriteLine("\nEl curso introducido no se corresponde con ninguno de los cursos disponibles dentro de la base del sistema");
            }
            else
            {
                flag = false;
            }

            return flag;

        }

        public bool validar_asignacion(string ingreso)
        {
            bool flag = true;

            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo puede ingresar un registro vacio");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("\nDebe de ingresar un registro numérico");
            }
            else if (salida<=0)
            {
                Console.WriteLine("\nEl número de registro debe de ser un número positivo");
            }
            else if (lista_alumnos.Find(A=>A.numero_registro==salida)==null)
            {
                Console.WriteLine("\nEl número de registro completado no se correponde con ninguno de los alumnos dentro de la lista del sistema");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public void alta_curso()
        {
            string ingreso = "";
            bool flag = true;


            do
            {
                Console.WriteLine("\nIngrese el código de curso que desea dar de alta");
                ingreso = Console.ReadLine();
                flag = validar_curso(ingreso);
            } while (flag);

            int numero_curso = Convert.ToInt32(ingreso);

            Curso c = new Curso();

            c.codigo_curso = numero_curso;
            c.lista_curso = new List<Alumno>();

            lista_curso.Add(c);

            Console.WriteLine("\nSe ha agregado satisfactoriamente un nuevo curso dentro de la lista del programa en ejecución");
        }

        public bool validar_curso(string ingreso)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nEl numero de curso no puede ser vacio");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("\nDebe de ingresar un tipo numérico dentro del numero de curso");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("\nEl número de curso debe de ser un número positivo");
            }
            else if (!(lista_curso.Find(A => A.codigo_curso == salida) == null))
            {
                Console.WriteLine("\nEl número de curso que intenta ingresar ya se halla cargado dentro del sistema por lo que no puede cargar 2 numeros de curso iguales");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public void alta_alumno()
        {
            string ingreso_registro = "";
            string ingreso_nombre = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el número de registro del alumno que quiere ingresar dentro del sistema");
                ingreso_registro = Console.ReadLine();
                flag = validar_registro(ingreso_registro);
            } while (flag);

            flag = true;

            do
            {
                Console.WriteLine("\nIngrese el nombre del alumno correspondiente al registro {0}", ingreso_registro);
                ingreso_nombre = Console.ReadLine();
                flag = validar_nombre(ingreso_nombre);
            } while (flag);

            int registro = Convert.ToInt32(ingreso_registro);
            string nombre = ingreso_nombre;

            Alumno A = new Alumno();

            A.numero_registro = registro;
            A.nombre_completo = nombre;
            A.cursos_asignados = new List<Curso>(); //Unicamente hago la declaración que inicializa la listam, esta aún permanece vacia

            lista_alumnos.Add(A);
            Console.WriteLine("\nSe ha agregado satisfactoriamente un nuevo alumno dentro de la lista de alumnos del sistema");

           
        }

        public bool validar_nombre(string ingreso)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nEl campo de nombre no puede permanecer vacio para la carga");
            }
            else if (ingreso.Length<2)
            {
                Console.WriteLine("\nDebe de incluir en nombre y apellido completo del alumno dentro del campo");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public bool validar_registro(string ingreso)
        {
            bool flag = true;
            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nEl numero de registro no puede ser vacio");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("\nDebe de ingresar un tipo numérico dentro del registro");
            }
            else if (salida<=0)
            {
                Console.WriteLine("\nEl registro debe de ser un número positivo");
            }
            else if (!(lista_alumnos.Find(A=>A.numero_registro==salida)==null))
            {
                Console.WriteLine("\nEl número de registro que intenta ingresar ya se halla cargado dentro del sistema por lo que no puede cargar 2 numeros de registros iguales");
            }
            else
            {
                flag = false;
            }

            return flag;
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
