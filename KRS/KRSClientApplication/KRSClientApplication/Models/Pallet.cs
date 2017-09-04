using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Pallet
    {
        public Pallet()
        {
            Send = new HashSet<Send>();
            Skin = new HashSet<Skin>();
        }

        public int IdPallet { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? SendingDate { get; set; }
        public string Status { get; set; }
        public int? CurrentCountSkins { get; set; }
        public int? IdTypeSkin { get; set; }

        public virtual ICollection<Send> Send { get; set; }
        public virtual ICollection<Skin> Skin { get; set; }
        public virtual SkinType IdTypeSkinNavigation { get; set; }
    }
}
