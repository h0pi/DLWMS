using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220240
{
    public class StudentiUvjerenja
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
