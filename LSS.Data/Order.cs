using System;
using System.Collections.Generic;

namespace LSS.Data
{
    public partial class Order
    {
        public string Oid { get; set; }
        public DateTime? Ostime { get; set; }
        public DateTime? Octime { get; set; }
        public DateTime? Oetime { get; set; }
        public string Ostate { get; set; }
        public string Sid { get; set; }
        public string Tid { get; set; }

        public virtual Student S { get; set; }
        public virtual Seat T { get; set; }
    }
}
