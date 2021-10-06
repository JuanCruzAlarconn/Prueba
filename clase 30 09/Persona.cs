using System;
using System.Collections.Generic;
using System.Text;

namespace clase_30_09
{
    class Persona
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido{ get; set; }
        public DateTime fecha_nacimientos { get; set; }

        //Si yo genero un constructor y no defino la instancia nula cuando invoque la creación de instacia va a estar sujeta a el único constructor disponible.
        //Ña mejor forma de operar es grabando todo de vuelta pisando el contenido que ya estaba escrito dentro del archivo
        //Lo mejor es manejar todo con listas y poder grabarlo todo al final
        //Se lee todo al comienzo y luego de tocar todo se hace el guardado final cuando ejecuto el comando de guardar.
        //Puedo hacer que la persona reciba la línea la descomponga y genere la clase persona para poder dar de alta dentro de la lista



    }
}
