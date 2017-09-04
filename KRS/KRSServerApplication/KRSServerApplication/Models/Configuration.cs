using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Configuration
    {
        public Configuration()
        {
            Skin = new HashSet<Skin>();
        }

        public int IdConfiguration { get; set; }
        public string ConfigurationLabel { get; set; }
        public string HotKey { get; set; }

        public virtual ICollection<Skin> Skin { get; set; }
        public virtual SkinType IdTypeSkinNavigation { get; set; }
    }
}
