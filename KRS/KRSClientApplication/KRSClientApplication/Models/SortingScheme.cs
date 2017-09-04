using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class SortingScheme
    {
        public SortingScheme()
        {
            Batch = new HashSet<Batch>();
            SchemeType = new HashSet<SchemeType>();
        }

        public int IdScheme { get; set; }
        public string SchemeLabel { get; set; }

        public virtual ICollection<Batch> Batch { get; set; }
        public virtual ICollection<SchemeType> SchemeType { get; set; }
    }
}
