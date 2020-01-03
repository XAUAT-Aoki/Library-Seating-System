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
    public class LibraryToShow
    {
        //图书馆名
        public string libraryName { get; set; }
        /// <summary>
        ///开始楼层
        /// </summary>
        public int startFloor { get; set; }
        //结束楼层
        public int endFloor { get; set; }

    }


   
}
