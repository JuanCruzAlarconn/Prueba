using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoria_2
{
    class Persona
    {
        public string nombre { get; set; }

        public string apellido { get; set; }


        public int dni { get; private set; }


        public void modificar()
        {
            bool flag = true;
            do
            {
                
                char opcion = ingreso_opcion();

                switch(opcion)
                {
                    case 'A':
                        nombre = modificar_nombre();
                        break;
                    case 'B':
                        apellido = modificar_apellido();
                        break;
                    case 'C':
                        dni = modificar_dni();
                        break;
                    case 'D':
                        Console.WriteLine("\nHa decidido no hacer modificación alguna");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nLa opción ingresada no se corresponde con ninguna de las disponibles");
                        break;

                }

            } while (flag);

            Console.WriteLine("\nOperación finalizada");
        }

        public int modificar_dni()
        {
            throw new NotImplementedException();
        }

        public string modificar_apellido()
        {
            throw new NotImplementedException();
        }

        public string modificar_nombre()
        {
            throw new NotImplementedException();
        }

        public char ingreso_opcion()
        {
            char salida=' ';
            string ingreso = "";

            do
            {
                mostra_menu();
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl ingreso no puede ser vacio");
                    continue;
                }

                if (ingreso.Length != 1)
                {
                    Console.WriteLine("\nDebe de ingresar unicamente un caracter dentro del campo");
                    continue;
                }

                salida = Convert.ToChar(ingreso);



            } while (salida ==' ');


            return salida;


          
        }

        public void mostra_menu()
        {
            Console.WriteLine("***********Menú de modificaciones**************");
            Console.WriteLine("A. Modificar nombre");
            Console.WriteLine("B. Modificar apellido");
            Console.WriteLine("C. Modificar Dni");
            Console.WriteLine("D. No modificar");
        }

        public static Persona crear_persona()
        {
            Persona persona = new Persona();

            string ingreso_nombre = ingreso(" Nombre ");
            string ingreso_apellido = ingreso(" Apellido ");
            string ingreso_dni = ingreso(" DNI ", numerico:true);

            int dni = Convert.ToInt32(ingreso_dni);

            persona.apellido = ingreso_apellido;
            persona.nombre = ingreso_nombre;
            persona.dni = dni;


            Console.WriteLine("\nSe ha creado satisfactoriamente una nueva persona");

            return persona;

        }
        public static string ingreso(string campo, bool numerico = false) //Los métodos estaticos solo se pueden comunicar con otros métodos estáticos
         {
            string salida = "";
            string ingreso="";

            do
            {
                Console.WriteLine("Ingrese el {0} de la persona a ingresar", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("\nEl campo {0} no puede estar vacio", campo);
                    continue;
                }

                if (numerico == false && ingreso.Any(Char.IsDigit))
                {
                    //tomo un campo que no puede haber número y evaluo si hay números
                    Console.WriteLine("\nEl campo {0} no puede contener elementos numéricos ", campo);
                    continue;
                }

                bool flag = true;

                if (numerico == true)
                {
                    if (!int.TryParse(ingreso, out int num))
                    {
                        Console.WriteLine("\nDebe de ingresar un tipo númerico dentro del campo {0}", campo);
                        flag = false;
                        break;
                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("\nEl campo {0} debe de ser positivo", campo);
                        flag = false;
                        break;
                    }
                }

                if (flag == false)
                {
                    continue;
                }

                salida = ingreso;



            } while (string.IsNullOrEmpty(salida));


            return ingreso;

        }
    }
}
