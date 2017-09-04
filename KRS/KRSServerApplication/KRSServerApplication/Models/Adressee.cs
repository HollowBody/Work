using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Adressee
    {
        public Adressee()
        {
            Send = new HashSet<Send>();
        }

        public int IdAdressee { get; set; }
        public string AdresseeLabel { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Send> Send { get; set; }
    }
}
