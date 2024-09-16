using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal class Alumnos_Inscripciones
    {
        public int Id { get; set; }
        public Persona IdAlumno { get; set; }
        public Curso IdCurso { get; set; }
        public string Condicion {  get; set; }
        public int Nota { get; set; }
    }
}
