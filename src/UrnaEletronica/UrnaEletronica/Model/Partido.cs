﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Partido
    {
        public string Sigla {  get; set; }

        public Partido(string sigla)
        {
            Sigla = sigla;
        }
    }
}
