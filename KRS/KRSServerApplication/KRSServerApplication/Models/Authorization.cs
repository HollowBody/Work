using System;
using System.Collections.Generic;

namespace KRSServerApplication.Models
{
    public partial class Authorization
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
