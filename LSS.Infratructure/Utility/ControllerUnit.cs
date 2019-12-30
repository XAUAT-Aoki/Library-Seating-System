using System;
using System.Collections.Generic;
using System.Text;

namespace LSS.Infrastructure.Utility
{
    public class ControllerUnit
    {
    }

    public class Condition
    {
        public int date { get; set; }
        public string Place { get; set; }

        public int Floor { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        //时间块
        public int TimeBulk { get; set; }
    }

   
}
