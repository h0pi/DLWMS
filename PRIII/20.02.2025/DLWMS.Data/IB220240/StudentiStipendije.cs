using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220240
{
    public class StudentiStipendije
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int StipendijeGodineId { get; set; }
        public StipendijeGodine StipendijeGodine { get; set; }
    }
}
