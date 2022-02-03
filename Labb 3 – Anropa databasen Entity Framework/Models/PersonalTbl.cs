using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class PersonalTbl
    {
        public PersonalTbl()
        {
            BetygOchPersonalTbl = new HashSet<BetygOchPersonalTbl>();
        }

        public int PersonalId { get; set; }
        public string PersonalFörnamn { get; set; }
        public string PersonalEfternamn { get; set; }
        public string PersonalKön { get; set; }
        public int? PersonalYrkesrollFk { get; set; }

        public virtual PersonalYrkesrollTbl PersonalYrkesrollFkNavigation { get; set; }
        public virtual ICollection<BetygOchPersonalTbl> BetygOchPersonalTbl { get; set; }
    }
}
