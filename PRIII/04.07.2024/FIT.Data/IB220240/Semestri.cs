﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220240
{
    public class Semestri
    {
        public int Id { get; set; }
        public string Oznaka { get; set; }
        public string Opis { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return Oznaka;
        }
    }
}
