using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Batch = new HashSet<Batch>();
        }

        public int IdProvider { get; set; }
        public string ProviderLabel { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public decimal? Discount { get; set; }

        public virtual ICollection<Batch> Batch { get; set; }
    }
}
