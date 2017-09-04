using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Batch
    {
        public Batch()
        {
            Skin = new HashSet<Skin>();
        }

        public int IdBatch { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string BatchStatus { get; set; }
        public int? SortingCount { get; set; }
        public int? DebitCount { get; set; }
        public int? IdProvider { get; set; }
        public int? IdScheme { get; set; }

        public virtual ICollection<Skin> Skin { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
        public virtual SortingScheme IdSchemeNavigation { get; set; }
    }
}
