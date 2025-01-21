using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }
        public Profesor(string nombre, string apellido)
            :base(nombre,apellido) {
			
            Cursos = new List<Curso>();

        }
    }
}
