using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicio53
{
    static class Agenda
    {
        public static readonly Dictionary<int, Alumno> agenda_alumnos = new Dictionary<int, Alumno>();

        public static List<Alumno> buscar_por_apellido()
        {
            string ingreso = ingreso_apellido();

            List<Alumno> salida = new List<Alumno>();

            foreach(var alumno in agenda_alumnos.Values)
            {
                if (alumno.apellido == ingreso) 
                {
                    salida.Add(alumno);
                }
            }

            return salida; //si hay más de un alumno con el mismo apellido te lo tira por lista, ahora solo puede haber como minimo una coincidencia dado que se valido el ingreso previamente

        }

        public static List<Alumno> buscar_por_nombre()
        {
            string ingreso = ingreso_nombre();

            List<Alumno> salida = new List<Alumno>();

            foreach (var alumno in agenda_alumnos.Values)
            {
                if (alumno.nombre == ingreso) 
                {
                    salida.Add(alumno);
                }
            }

            return salida; //si hay más de un alumno con el mismo apellido te lo tira por lista, ahora solo puede haber como minimo una coincidencia dado que se valido el ingreso previamente

        }

        public static void grabar_datos()
        {
            string ruta = "AGENDA.txt";

            StreamWriter escribir = new StreamWriter(ruta);

            foreach(var alumno in agenda_alumnos.Values)
            {
                escribir.WriteLine("Nombre: {0} - Apellido: {1} - DNI: {2} - telefono: {3}", alumno.nombre, alumno.apellido, alumno.dni, alumno.telefono);
            }

            escribir.Close();
        }

        public static void leer_datos()
        {
            string ruta = "AGENDA.txt";

            FileInfo archivo = new FileInfo(ruta);

            if(!archivo.Exists)
            {
                Console.WriteLine("\nEl archivo al que se intenta acceder no es posible encontrarlo o abrirlo");
            }
            else
            {
                StreamReader leer = archivo.OpenText();

                while(!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();

                    Console.WriteLine(linea);
                }

                leer.Close();
            }

        }

        private static string ingreso_nombre()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el nombre del alumno que desea buscar dentro de la base del programa");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl nombre no puede ser vacio");
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl nombre no puede contener elementos numéricos");
                    continue;
                }

                List<Alumno> aux = new List<Alumno>();

                foreach (var alumno in agenda_alumnos.Values)
                {
                    if (alumno.nombre == ingreso)
                    {
                        aux.Add(alumno);
                    }
                }

                if (aux.Count < 1)
                {
                    Console.WriteLine("\nEl nombre ingresado no se corresponde con ninguno de la lista del sistema");
                    continue;
                }

                break;

            } while (true);


            return ingreso;
        }

        private static string ingreso_apellido()
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el apellido del alumno que desea buscar dentro de la base del programa");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl apellido no puede ser vacio");
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl apellido no puede contener elementos numéricos");
                    continue;
                }

                List<Alumno> aux = new List<Alumno>();

                foreach (var alumno in agenda_alumnos.Values)
                {
                    if (alumno.apellido == ingreso)
                    {
                        aux.Add(alumno);
                    }
                }

                if (aux.Count < 1)
                {
                    Console.WriteLine("\nEl apellido ingresado no se corresponde con ninguno de la lista del sistema");
                    continue;
                }

                break;

            } while (true);


            return ingreso;
        }

        public static bool validar_telefono(int telefono)
        {
            bool flag = true;



            foreach(var alumno in agenda_alumnos.Values)
            {
                if(alumno.telefono==telefono)
                {
                    flag = false; //si hay coincidencias avisa indicando que no es posible agregar otro elemento dentro del banco de datos del programa
                }
            
            }


            return flag;

        }

        public static bool validar_dni(int dni)
        {
            bool flag = true;



            foreach (var alumno in agenda_alumnos.Values)
            {
                if (alumno.dni == dni)
                {
                    flag = false; //si hay coincidencias avisa indicando que no es posible agregar otro elemento dentro del banco de datos del programa
                }

            }


            return flag;

        }

    }
}
