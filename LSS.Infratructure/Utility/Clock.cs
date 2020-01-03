using System;
using System.Collections.Generic;
using System.Text;

namespace LSS.Infrastructure.Utility
{
    public class Clock
    {
        public string username { get; set; }

        public string seatid { get; set; }

        public DateTime clocktime { get; set; }
        //经度
        public float Longitude { get; set; }
        //维度
        public float Latitude { get; set; }

    }
}
