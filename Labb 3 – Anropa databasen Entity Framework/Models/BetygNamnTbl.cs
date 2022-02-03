﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class BetygNamnTbl
    {
        public BetygNamnTbl()
        {
            BetygTbl = new HashSet<BetygTbl>();
        }

        public int BetygNamnId { get; set; }
        public string BetygNamnBokstav { get; set; }

        public virtual ICollection<BetygTbl> BetygTbl { get; set; }
    }
}
