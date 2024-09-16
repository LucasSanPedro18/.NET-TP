﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Materia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales { get; set; }
        public int HsTotales { get; set; }
        public Plan IdPlan { get; set; }
    }
}
