using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Send
    {
        public int IdSend { get; set; }
        public int? IdAdressee { get; set; }
        public int? IdPallet { get; set; }
        public DateTime? SendDate { get; set; }

        public virtual Adressee IdAdresseeNavigation { get; set; }
        public virtual Pallet IdPalletNavigation { get; set; }
    }
}
