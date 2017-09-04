using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class SkinType
    {
        public SkinType()
        {
            CostJournal = new HashSet<CostJournal>();
            Pallet = new HashSet<Pallet>();
            SchemeType = new HashSet<SchemeType>();
            Skin = new HashSet<Skin>();
            Configuration = new HashSet<Configuration>();
        }

        public int IdTypeSkin { get; set; }
        public string TypeSkinLabel { get; set; }
        public decimal? MinimumWeight { get; set; }
        public decimal? MaximumWeight { get; set; }
        public int? MaximumCountSkin { get; set; }
        public int? IdConfiguration { get; set; }

        public virtual ICollection<CostJournal> CostJournal { get; set; }
        public virtual ICollection<Pallet> Pallet { get; set; }
        public virtual ICollection<SchemeType> SchemeType { get; set; }
        public virtual ICollection<Skin> Skin { get; set; }
        public virtual ICollection<Configuration> Configuration { get; set; }
    }
}
