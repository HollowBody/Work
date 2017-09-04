using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class SchemeType
    {
        public int IdSchemeType { get; set; }
        public int? IdScheme { get; set; }
        public int? IdTypeSkin { get; set; }

        public virtual SortingScheme IdSchemeNavigation { get; set; }
        public virtual SkinType IdTypeSkinNavigation { get; set; }
    }
}
