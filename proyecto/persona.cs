using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class persona
    {
        public string nombre { get; set; }


        public void saludar()
        {
           Console.WriteLine("Hola yo soy  {0}", nombre);
        }
    }
}
