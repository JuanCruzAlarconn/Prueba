using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio_de_propiedades_de_una_lista
{
    class Practica
    {
        List<Persona> personas = new List<Persona>();
        public void ejercicio()
        {
            Persona p1 = new Persona();
            p1.altura = 2;
            p1.peso = 100;

            Persona p2 = new Persona();
            p2.altura = 4;
            p2.peso = 200;

            personas.Add(p1);
            personas.Add(p2);

            Console.WriteLine("\nPERSONAS SIN MODIFICAR");

            foreach (var p in personas)
            {
                Console.WriteLine("PESO: {0} ALTURA: {1}", p.peso, p.altura);
            }

            //ojo el select me modifica toda la lista

            personas = personas.Select(p => { p.altura = 100; return p; }).ToList();

            Console.WriteLine("\nPERSONAS MODIFICADAS");

            foreach (var p in personas)
            {
                Console.WriteLine("PESO: {0} ALTURA: {1}", p.peso, p.altura);
            }

            Persona aux = personas.Find(p => p.peso == 100); // No es una copia es una referencia a el mismo objeto dentro de la lista, hay que tener mucho cuidado lo que puedo modificar dentro del mismo dado que estoy tocando una referencia al mismo objeto

            aux.peso = 99699;
            aux.altura = 999999999;

            Console.WriteLine("\nNueva modificación");

            foreach (var p in personas)
            {
                Console.WriteLine("PESO: {0} ALTURA: {1}", p.peso, p.altura);
            }


        }
    }
}
