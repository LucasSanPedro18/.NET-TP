using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal class Comision
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int AñoEspecialidad { get; set; }
        public Plan IdPlan { get; set; }
    }
}
