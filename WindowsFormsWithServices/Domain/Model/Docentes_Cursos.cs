using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal class Docentes_Cursos
    {
        public int IdDictado { get; set; }
        public Curso IdCurso { get; set; }
        public Persona Docente { get; set; }
        public int Cargo { get; set; }
    }
}
