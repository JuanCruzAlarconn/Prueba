using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_c
{
    class Persona
    {
        //internal-> solo lo que esta dentro del proyecto puede acceder a la propiedad DNI
        //private solo la clase persona puede acceder a la propiedad no desde otras clases

        public int DNI { get; set; } //El atributo se puede leer y escribir, y como es público puede ser accedido desde cualquier caso o sistema

        public string nombre { get; private set; } //desde este punto de vista unicamente puedo leer el atributo más no lo puedo modificar

        public string pass { private get; set; } //la contraseña la puedo introducir más nunca debe de poder ser leida dado que corresponde a un parametro de seguridad para el sistema en conjunto

        //Hay que intentar abstraernos de la estructura interna del objeto e intentar usarlo como si se tratase de una unidad
        //El problema surje a la hora de que quiero modifcar algunos de los atributos de la persona y eso seguro me tira un grave error
        //Hay que intentar modularizar y que la clase persona haga todo a partir de sus propios métodos de clase como talç

        private Persona()
        {
            //sorpresa un constructor privado para la persona, no puedo generar una nueva persona simplemente con el new

        }

        public static Persona crear_persona()
        {
            return new Persona();
        }

    }
}
