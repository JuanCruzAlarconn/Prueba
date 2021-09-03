using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_clase_02_09
{
    class Practica
    {
        //1. 2 campos para poder generar un lista
        //2. la clave no se repite es única y con ella puedo tener acceso al campo correspondiente al diccionario

        public void ejercicio1()
        {
            Dictionary<int, string> personas = new Dictionary<int, string>();

            personas.Add(38456910, "Juan Cruz Alarcón");
            personas.Add(45645681, "Juan Perez");

            //más suma de datos

            string nombre = personas[38456910];// busco por el nombre de la clave que debo de tener identificada y es única

            foreach(string name in personas.Values)
            {
                //estoy recorriendo todos los valores del diccionario

                Console.WriteLine(name);


            }

            foreach(KeyValuePair<int,string> x in personas)
            {
                if(x.Value=="Juan Cruz Alarcón")
                {
                    Console.WriteLine("El DNI de {0} es: {1}",x.Value,x.Key);
                }
            }
        }

        public void ejercicio2()
        {
            List<string> lista_almacen = new List<string>();

            lista_almacen.Add("queso");
            lista_almacen.Add("salame");
            lista_almacen.Add("aceituna");

            string primero = lista_almacen[0];

            Console.WriteLine("El primer elemento de la lista es {0}", primero);


            //inicializar una matriz

            int[,] matriz = new int[3, 3];//tres filas y tres columnas

        }

        

        public void ejercicio3()
        {
            Dictionary<char, List<Persona>> agenda = new Dictionary<char, List<Persona>>();

            agenda.Add('A', new List<Persona> ());//cuando inicializo una clase hay que ponerla en vacio para luego poder cargar elementos dentro del contexto
            agenda.Add('B', new List<Persona>());
            agenda.Add('C', new List<Persona>());
            agenda.Add('D', new List<Persona>());
            agenda.Add('E', new List<Persona>());

        }

        public void ejercicio4()
        {
            Facultad.direccion = "Av. Cordoba 2550";
            //statico es un elemento que cualquiera puede acceder pero es única e irrepetible dentro del sistema
            //STATIC UNO SOLO DE ...
        }
    }
}
