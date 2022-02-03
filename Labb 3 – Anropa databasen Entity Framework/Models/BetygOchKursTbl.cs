using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class BetygOchKursTbl
    {
        public int BetygOchKursId { get; set; }
        public int BetygOchKursBetygFk { get; set; }
        public int BetygOchKursKursFk { get; set; }

        public virtual BetygTbl BetygOchKursBetygFkNavigation { get; set; }
        public virtual KursTbl BetygOchKursKursFkNavigation { get; set; }
    }
}
