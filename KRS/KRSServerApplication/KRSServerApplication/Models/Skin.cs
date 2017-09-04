using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Skin
    {
        public int IdSkin { get; set; }
        public int? IdSort { get; set; }
        public float? Brutto { get; set; }
        public float? Netto { get; set; }
        public float? Discount { get; set; }
        public int? IdBatch { get; set; }
        public int? IdTypeSkin { get; set; }
        public int? IdConfiguration { get; set; }
        public int? IdPallet { get; set; }

        public virtual Batch IdBatchNavigation { get; set; }
        public virtual Configuration IdConfigurationNavigation { get; set; }
        public virtual Pallet IdPalletNavigation { get; set; }
        public virtual Sorts IdSortNavigation { get; set; }
        public virtual SkinType IdTypeSkinNavigation { get; set; }
    }
}
