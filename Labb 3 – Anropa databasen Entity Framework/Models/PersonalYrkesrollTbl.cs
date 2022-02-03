using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb_3___Anropa_databasen_Entity_Framework.Models
{
    public partial class PersonalYrkesrollTbl
    {
        public PersonalYrkesrollTbl()
        {
            PersonalTbl = new HashSet<PersonalTbl>();
        }

        public int PersonalYrkesrollId { get; set; }
        public string PersonalYrkesrollNamn { get; set; }

        public virtual ICollection<PersonalTbl> PersonalTbl { get; set; }
    }
}
