using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_y_Pilas
{
    class Ejercicios
    {
       string caja1,caja2,caja3="";
        Queue<string> espera = new Queue<string>();
        public  void ejercicio47()
        {
            //teoria
            //   Queue<int> cola_numeros = new Queue<int>(); //inicializar 

            /*   cola_numeros.Enqueue(1);//encolar elemento en la cola

                cola_numeros.Dequeue();//Descencola el numero y lo saca de la cola

                cola_numeros.Peek();//muestra el proximo elemento de la lista que se va a sacar pero no lo saca

                //el recorrido se puede hacer con foreach
                count para ver la cantidad de elementos

            */

            

            

            string ingreso = "";

            do
            {
                mostrar_menu();
                ingreso = Console.ReadLine();

                if(ingreso=="C" || ingreso=="c")
                {
                    Console.WriteLine("\nHa decidido finalizar la ejecución del programa");
                }
                else if (ingreso=="A"||ingreso=="a")
                {
                    ingreso_paciente();
                }
                else if (ingreso == "B" || ingreso == "b")
                {
                    habilitar_caja();
                }
                else
                {
                    Console.WriteLine("\nHa ingresado un comando que no corresponde con ninguno de los disponibles");
                }
            }while(!(ingreso=="C" || ingreso=="c"));


            Console.WriteLine("\nElementos en lista de espera {0}", espera.Count);

            if(string.IsNullOrEmpty(caja1))
            {
                Console.WriteLine("\nLa caja 1 se halla libre");
            }
            else
            {
                Console.WriteLine("\nDentro de la caja 1 el paciente {0} esta siendo atendido",caja1);
            }


            if (string.IsNullOrEmpty(caja2))
            {
                Console.WriteLine("\nLa caja 2 se halla libre");
            }
            else
            {
                Console.WriteLine("\nDentro de la caja 2 el paciente {0} esta siendo atendido", caja1);
            }


            if (string.IsNullOrEmpty(caja3))
            {
                Console.WriteLine("\nLa caja 3 se halla libre");
            }
            else
            {
                Console.WriteLine("\nDentro de la caja 3 el paciente {0} esta siendo atendido", caja1);
            }




        }

        public void habilitar_caja()
        {
            Console.WriteLine("\nIngrese el número de caja que se ha habilitado");
            int numero = Convert.ToInt32(Console.ReadLine());


            if(espera.Count==0)
            {
                if(numero==1)
                {
                    caja1 = "";
                }
                else if (numero==2)
                {
                    caja2 = "";
                }
                else if (numero==3)
                {
                    caja3 = "";
                }

            }
            else
            {
                if (numero == 1)
                {
                    caja1 = espera.Dequeue(); //asigno el elemento a la caja correspondiente y lo saco de la cola de espera
                }
                else if (numero == 2)
                {
                    caja2 = espera.Dequeue();
                }
                else if (numero == 3)
                {
                    caja3 = espera.Dequeue();
                }

            }
        }

        public  void ingreso_paciente()
        {
            string ingreso = "";

            Console.WriteLine("\nIngrese el nombre del paciente");
            ingreso = Console.ReadLine();

            if(string.IsNullOrEmpty(caja1))
            {
                caja1 = ingreso;
                Console.WriteLine("\nEl paciente fue derivado a la caja 1");
            }
            else if (string.IsNullOrEmpty(caja2))
            {
                caja2 = ingreso;
                Console.WriteLine("\nEl paciente fue derivado a la caja 2");
            }
            else if(string.IsNullOrEmpty(caja3))
            {
                caja3 = ingreso;
                Console.WriteLine("\nEl paciente fue derivado a la caja 3");
            }
            else
            {
                Console.WriteLine("\nNinguna de las cajas se halla disponible por lo que se derivara al paciente a la lista de espera");
                espera.Enqueue(ingreso);
            }

        }

        public void mostrar_menu()
        {
            Console.WriteLine("\nIngrese los siguientes comandos segun su necesidad");
            Console.WriteLine("\nA. Ingreso de nuevo paciente");
            Console.WriteLine("\nB.Liberar caja");
            Console.WriteLine("\nC.Finalizar la ejecución del programa\n");
        }
    }
}
