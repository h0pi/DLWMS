using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220240
{
    public class StipendijeGodine
    {
        public int Id { get; set; }
        public int Godina { get; set; }
        public int StipendijaId { get; set; }
        public Stipendije Stipendija { get; set; }
        public int Iznos { get; set; }
    }
}
