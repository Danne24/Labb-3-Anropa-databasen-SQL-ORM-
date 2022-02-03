using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class ElevTbl
    {
        public ElevTbl()
        {
            BetygOchElevTbl = new HashSet<BetygOchElevTbl>();
            ElevOchKursTbl = new HashSet<ElevOchKursTbl>();
        }

        public int ElevId { get; set; }
        public int? ElevPersonnummer { get; set; }
        public string ElevFörnamn { get; set; }
        public string ElevEfternamn { get; set; }
        public string ElevKön { get; set; }
        public string ElevKlass { get; set; }

        public virtual ICollection<BetygOchElevTbl> BetygOchElevTbl { get; set; }
        public virtual ICollection<ElevOchKursTbl> ElevOchKursTbl { get; set; }
    }
}
