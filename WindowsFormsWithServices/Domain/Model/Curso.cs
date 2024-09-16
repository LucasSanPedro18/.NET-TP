using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal class Curso
    {
        public int Id { get; set; }
        public Materia IdMateria { get; set; }
        public Comision IdComision { get; set; }
        public int AñoCalendario { get; set; }
        public int Cupo { get; set; }

    }
}
