using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Estructura_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carta_Porte> lista_carta_porte = new List<Carta_Porte>();

            do
            {
                Console.WriteLine("\nIngrese S para agregar una nueva carta de porte y N para dentener la carga de carga de porte");

                if(Console.ReadKey(true).Key==ConsoleKey.S)
                {
                    Console.WriteLine("\nSE HA SELECCIONADO EL COMANDO PARA GENERAR UNA CARTA DE PORTE");
                    var carta = Carta_Porte.Crear();

                    using (var escribir= new StreamWriter("carta de porte.txt"))
                    {
                        escribir.WriteLine()
                    }

                }

            } while (true);
        }
    }
}
