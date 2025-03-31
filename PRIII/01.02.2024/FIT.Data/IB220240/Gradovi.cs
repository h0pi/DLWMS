using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220240
{
    public class Gradovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
