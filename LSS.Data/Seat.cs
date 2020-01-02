using System;
using System.Collections.Generic;

namespace LSS.Data
{
    public partial class Seat
    {
        public Seat()
        {
            Order = new HashSet<Order>();
        }

        public string Tid { get; set; }
        public int? Tfloor { get; set; }
        public string Tstate { get; set; }
        public int Lid { get; set; }

        public virtual Library L { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
