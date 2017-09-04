using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Sorts
    {
        public Sorts()
        {
            CostJournal = new HashSet<CostJournal>();
            Skin = new HashSet<Skin>();
        }

        public int IdSort { get; set; }
        public string Sort { get; set; }

        public virtual ICollection<CostJournal> CostJournal { get; set; }
        public virtual ICollection<Skin> Skin { get; set; }
    }
}
