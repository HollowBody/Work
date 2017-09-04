using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class CostJournal
    {
        public int IdCost { get; set; }
        public DateTime? CostDate { get; set; }
        public decimal? SkinPrice { get; set; }
        public int? IdTypeSkin { get; set; }
        public int? IdSort { get; set; }

        public virtual Sorts IdSortNavigation { get; set; }
        public virtual SkinType IdTypeSkinNavigation { get; set; }
    }
}
