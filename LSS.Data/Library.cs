using System;
using System.Collections.Generic;

namespace LSS.Data
{
    public partial class Library
    {
        public Library()
        {
            Seat = new HashSet<Seat>();
        }

        public int Lid { get; set; }
        public string Llongitude { get; set; }
        public string Llatitute { get; set; }
        public string Lerror { get; set; }
        public string Lname { get; set; }
        public int? Lsfloor { get; set; }
        public int? Lefloor { get; set; }

        public virtual ICollection<Seat> Seat { get; set; }
    }
}
