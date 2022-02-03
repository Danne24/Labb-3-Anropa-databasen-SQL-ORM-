﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class KursTbl
    {
        public KursTbl()
        {
            BetygOchKursTbl = new HashSet<BetygOchKursTbl>();
            ElevOchKursTbl = new HashSet<ElevOchKursTbl>();
        }

        public int KursId { get; set; }
        public string Kursnamn { get; set; }

        public virtual ICollection<BetygOchKursTbl> BetygOchKursTbl { get; set; }
        public virtual ICollection<ElevOchKursTbl> ElevOchKursTbl { get; set; }
    }
}
