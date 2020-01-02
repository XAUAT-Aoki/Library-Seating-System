using System;
using System.Collections.Generic;

namespace LSS.Data
{
    public partial class Student
    {
        public Student()
        {
            Order = new HashSet<Order>();
        }

        public string Sid { get; set; }
        public string Sname { get; set; }
        public string Spassword { get; set; }
        public string Semail { get; set; }
        public string Ssex { get; set; }
        public int? Svalue { get; set; }
        public string Slock { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
