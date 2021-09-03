using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Integrales
{
    class Alumno
    {
        public int numero_registro { get; set; }

        public string nombre_completo { get; set; }

        public List<Curso> cursos_asignados { get; set; }
    }
}
