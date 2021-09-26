using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_estructura_de_datos
{
    class Empleado
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public Nullable<DateTime> fecha_egreso { get; set; }//podría no existir dentro del contexto, podría tener situaciones en donde halla elementos que quiero devolver un value type más el null
        //al no verse asignado se puede trabajar de forma conjunta teniendo en cuenta que si no fue asignado quda en null el atributo

      //  public DateTime? fecha_egreso { get; set; } forma resumida de poder generar un value type que tome null como posibilidad en caso de no haber asignado

        public TimeSpan? antiguedad { get

            {
                var diferencia=0;
                if(fecha_egreso==null)
                {
                   diferencia= DateTime.Now.Year - fecha_ingreso.Year);

                    if(DateTime.Now.Month<fecha_ingreso.Month || DateTime.Now.Month== fecha_ingreso.Month &&DateTime.Now.Day<fecha_ingreso.Day)
                    {
                        diferencia--;
                    }
                }
                else
                {
                    diferencia=fecha_egreso.Value.Year-fecha_ingreso.Year);
                    //cuidado la fecha de egreso es nullable hay que agregar value para poder operar

                    if(DateTime.Now.Month < fecha_ingreso.Month || DateTime.Now.Month == fecha_ingreso.Month && DateTime.Now.Day < fecha_ingreso.Day)
                }
                return diferencia;
            } }//puede ser nulo hay posibilidad que uno de los factores de la resta sea nulo


        public static Empleado Crear()
        {
            Empleado empleado = new Empleado();

            empleado.nombre = asignar_campo("Nombre");
            empleado.legajo = asignar_legajo();
            empleado.apellido = asignar_campo("Apellido");
            empleado.fecha_ingreso = asignar_fecha("Ingreso");
            empleado.fecha_egreso = asignar_fecha("Egreso");
            empleado.antiguedad = asignar_antiguedad(empleado.fecha_ingreso, empleado.fecha_egreso);

            Console.WriteLine("\nSe ha generado una nueva instancia de la clase empleado");

            return empleado;

        }

        private static TimeSpan asignar_antiguedad(DateTime fecha_ingreso, DateTime fecha_egreso)
        {
            return fecha_egreso - fecha_ingreso;
        }

        private static DateTime asignar_fecha(string fecha)
        {
            string ingreso;

            DateTime f;
            do
            {
                Console.WriteLine("\nIngrese la fecha de {0}", fecha);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nNo puede dejar la fecha de {0} vacia", fecha);
                    continue;
                }

                if (!DateTime.TryParse(ingreso, out f))
                {
                    Console.WriteLine("\nDebe de ingresar una fecha con un formato válido");
                    continue;
                }
                
                if(fecha=="ingreso" && f>DateTime.Now)
                    {
                        Console.WriteLine("\nLa fecha de ingreso no debe de ser superior a la fecha actual");
                        continue;
                    }

                if(fecha=="egreso" && f>DateTime.Now)
                {
                    Console.WriteLine("\nLa fecha de egreso de debe de ser superior a la fecha actual");
                    continue;
                }
                

                break;
            } while (true);

            return f;


        }

        private static int asignar_legajo()
        {
            string ingreso;
            int legajo;

            do
            {
                Console.WriteLine("\nIngrese el numero de legajo del empleado");
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl numero de legajo no puede permanecer vacio");
                    continue;
                }

                if (!int.TryParse(ingreso, out legajo))
                {
                    Console.WriteLine("\nEl número de legajo debe de ser numérico");
                    continue;
                }

                if (ingreso.Length != 6)
                {
                    Console.WriteLine("\nEl legajo debe de contar con 6 digitos exactamente");
                    continue;
                }
                break;
            } while (true);

            return legajo;
        }

        private static string asignar_campo(string campo)
        {
            string ingreso;

            do
            {
                Console.WriteLine("\nIngrese el {0} del empleado", campo);
                ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("\nEl {0} no puede permanecer vacio", campo);
                    continue;
                }

                if (ingreso.Any(char.IsDigit))
                {
                    Console.WriteLine("\nEl {0} no puede tener elementos numéricos", campo);
                    continue;
                }

                if(ingreso.Length>30)
                {
                    Console.WriteLine("\nEl {0} no puede tener más de 30 caracteres dentro de su composición");
                    continue;
                }

                break;
            } while (true);

            return ingreso;
        }
    }
}
