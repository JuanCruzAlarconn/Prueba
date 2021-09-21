using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_y_Pilas
{
    class Alumno
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int registro { get; set; }

        public static Alumno agregar_alumno()
        {
            Alumno alumno = new Alumno();

            alumno.nombre = ingreso("nombre");
            alumno.registro = Convert.ToInt32(ingreso("registro", numero: true));
            alumno.apellido = ingreso("apellido");

            return alumno;

        }


        public static string ingreso(string campo, bool numero=false)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el campo {0} del alumno a generar", campo);
                ingreso = Console.ReadLine();

                if (numero == false)
                {

                    if (string.IsNullOrWhiteSpace(ingreso))
                    {
                        Console.WriteLine("\nEl campo {0} no puede permanecer vacio", campo);
                        continue;
                    }

                    if (ingreso.Length < 2)
                    {
                        Console.WriteLine("\nEl campo  {0} debe de contener al menos 2 caracteres", campo);
                        continue;
                    }

                    if (ingreso.Any(char.IsDigit))
                    {
                        Console.WriteLine("\nEl campo {0} no puede contener elementos numéricos", campo);
                        continue;
                    }
                }

                bool flag = true;

                if(numero==true)
                {
                    if(!Int32.TryParse(ingreso, out int salida))
                    {
                        Console.WriteLine("\nEl campo {0} debe de ser numerico");
                        flag = false;
                        break;
                       
                    }

                    if(salida<=0)
                    {
                        Console.WriteLine("\nEl campo {0} debe de ser positivo");
                        flag = false;
                        break;
                    }
                }

                if(flag==false)
                {
                    continue;
                }

                break;

            } while (true);

            return ingreso;

        }

        public void modificar()
        {
            throw new NotImplementedException(); //queda pendiente
        }


    }
}
