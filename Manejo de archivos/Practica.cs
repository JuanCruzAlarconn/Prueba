using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manejo_de_archivos
{
    class Practica
    {
        public void ejercicio49()
        {
            string ruta = "I:\\CAI\\Manejo de archivos\\base de datos.txt";

            StreamWriter escribir = new StreamWriter(ruta); //no hace falta tener que hacer comprobaciónes dado que si el archivo no esta disponible se generara uno con el mismo nombre dentro de la ruta de acceso

            escribir.WriteLine("Hola mundo");
            escribir.WriteLine("Hola mundo como estas en este día "+ DateTime.Now);

            Console.WriteLine("\nSe ha generado el archivo con el texto solicitado satisfactoriamente");

            escribir.Close();//Todo archivo que se abre debe de cerrarce dentro de la misma interacción por función especificada

        }

        public void ejercicio50()
        {
            //Leer el contenido de un archivo
            string ruta = "I:\\CAI\\Manejo de archivos\\base de datos.txt";

            FileInfo abrir = new FileInfo(ruta);

            if(!abrir.Exists)
            {
                Console.WriteLine("\nEl archivo en cuestión no se pudo abrir, por falla en la localización");
            }
            else
            {
                StreamReader leer = abrir.OpenText();//no le tengo que pasar la ruta del archivo dado que ya estaba abierto de antemano

                while(!leer.EndOfStream)
                {
                    //voy a llevar a cabo los ciclos hasta que llegue al último salto de linea que es cuando se detiene la lectura de los contenidos dado que por debajo de esta linea no hay más elementos que pudiere administrar como tal

                    string cadena = leer.ReadLine();

                    Console.WriteLine(cadena);//muestro el contenido de la cadena especificada dentro del archivo de texto

                    var arreglo = cadena.Split(' ');//genero un vector de string a partir del pasaje de otra cadena más generalizada y con ello muestro el contenido de las cadenas separadas por el caracter espacio

                    Console.WriteLine("\nA continuación se pasan a mostrar las cadenasd que componen la linea separadas por un espacio");
                    foreach(var a in arreglo)
                    {
                        Console.WriteLine(a+"\n");
                    }
                }

                leer.Close();
            }

        }

        Dictionary<int, string> alumnos = new Dictionary<int, string>(); 

        public void ejercicio52()
        {
            ingresar();
            
        }

        public void ingresar()
        {
            string ingreso = "";
            bool flag = true;

            do

            {
                mostrar_menu();
                ingreso = Console.ReadLine();
                flag = validar_ingreso(ingreso);
                procesar_comando(ingreso);

            } while (ingreso=="E");


            Console.WriteLine("\nHA FINALIZADO LA EJECUCIÓN DEL PROGRAMA DE ADMINISTRACIÓN DEL REGISTRO DEL ALUMNOS\n");

        }

        public void procesar_comando(string ingreso)
        {
           
                if(ingreso=="A")
                {
                ingreso_alumno();

                }
                else if (ingreso=="B")
                {
                borrar_alumno();

                }
                else if (ingreso=="C")
                {
                grabar_archivo();

                }
                else if (ingreso=="D")
                {
                leer_archivo();

                }
                else if (ingreso=="E")
            {
                Console.WriteLine("\nHa decidido finalizar con la ejecución del programa");
            }
                else
            {
                Console.WriteLine("\nEl comando ingresado no se corresponde con ninguno de los comandos disponibles");
            }
            
        }

        public void leer_archivo()
        {
            string ruta = "I:\\CAI\\Manejo de archivos\\repositorio de alumnos.txt";

            FileInfo archivo = new FileInfo(ruta);

            if (!archivo.Exists)
            {
                Console.WriteLine("\nNo se pudo hallar el archivo especificado por lo que la operación no se pudo concretar");
            }
            else
            {
                StreamReader leer = archivo.OpenText();

                while(!leer.EndOfStream)
                {
                    string cadena = leer.ReadLine();

                    Console.WriteLine(cadena);
                }

                leer.Close();
                Console.WriteLine("\nSe ha cerrado el archivo consultdo sin realizar cambio alguno dentro del entorno especificado");
            }


        }

        public void grabar_archivo()
        {
            string ruta = "I:\\CAI\\Manejo de archivos\\repositorio de alumnos.txt";

            StreamWriter escribir = new StreamWriter(ruta);

            foreach(var a in alumnos)
            {
                escribir.WriteLine("Nombre: {0} Nº de registro: {1}", a.Value, a.Value);
            }

            escribir.Close();

            Console.WriteLine("\nSe han añadido satisfactoriamente los nuevos campos a la base de datos correspondiente");
        }

        public void borrar_alumno()
        {
            string ingreso_registro = "";
            bool flag = true;

            do
            {
                Console.WriteLine("\nIngrese el legajo del alumno a eliminar");
                ingreso_registro = Console.ReadLine();
                flag = validar_borrado(ingreso_registro);

            } while (flag);

            //hasta aca tengo un registro válido para eliminar
            int registro = Convert.ToInt32(ingreso_registro);
            alumnos.Remove(registro);
            Console.WriteLine("\nSe ha eliminado satisfactoriamente el registro seleccionado");

        }

        public bool validar_borrado(string ingreso)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo se ha ingresado caracter alguno, vuelve a ingresar");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("Debe de ingresar un registro numérico");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("El registro debe de ser mayor a cero");

            }
            else if (alumnos.ContainsKey(salida)==false)
            {
                Console.WriteLine("El elemento que se intenta eliminar no se halla disponible dentro de la información de alumnos");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public void ingreso_alumno()
        {
            string ingreso_registro = "";
            string ingreso_nombre = "";
            bool flag = true;
            do
            {
                Console.WriteLine("Ingrese el legajo del alumno a ingresar");
                ingreso_registro = Console.ReadLine();
                flag = validar_numero(ingreso_registro);

                if (flag == false)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el nombre del alumno con registro: {0}", ingreso_registro);
                        ingreso_nombre = Console.ReadLine();
                        flag = validar_ingreso(ingreso_nombre);//si hay algo mal, debo de repetir el ciclo hasta ser correcto el ingreso
                    } while (flag);
                }

            } while (flag);

            //Hasta este punto cuento con el registro y el nombre a ingresar dentro del diccionario

            int registro = Convert.ToInt32(ingreso_registro);

            alumnos.Add(registro, ingreso_nombre);

            Console.WriteLine("\nSe ha añadido satisfactoriamente el nuevo alumno dentro del registro correspondiente");

        }

        public bool validar_numero(string ingreso)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo se ha ingresado caracter alguno, vuelve a ingresar");
            }
            else if (!Int32.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("Debe de ingresar un registro numérico");
            }
            else if (salida<=0)
            {
                Console.WriteLine("El registro debe de ser mayor a cero");

            }
            else if (alumnos.ContainsKey(salida)==true)
            {
                Console.WriteLine("El registro ingresado ya forma parte de la planilla");
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public bool validar_ingreso(string ingreso)
        {
            bool flag = true;

            if(string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("\nNo puede dejar el campo de ingreso vacio");
            }
          
            else
            {
                flag = false;
            }

            return flag;
        }

        public void mostrar_menu()
        {
            Console.WriteLine("\n*************MENÚ DE COMANDOS*************");
            Console.WriteLine("A. Alta de alumno");
            Console.WriteLine("B. Baja de alumno");
            Console.WriteLine("C. Grabar información en un archivo");
            Console.WriteLine("D. Mostrar información del archivo");
            Console.WriteLine("E. Finalizar con la ejecución del programa");
            Console.WriteLine("*********************************************\n");
        }
    }
}
