﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLudo
{
    abstract class Celda
    {
        public  bool estado { get; set; }
        public Pieza[] ocupado_por { get; set; }
        

    }
}
