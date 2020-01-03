using System;
using System.Collections.Generic;

namespace LSS.Data
{
    public partial class Order
    {
        public string Oid { get; set; }//订单ID
        public DateTime? Ostime { get; set; }//开始时间
        public DateTime? Octime { get; set; }//打卡时间
        public DateTime? Oetime { get; set; }//结束时间
        public string Ostate { get; set; }//订单状态  00违规  01 预约未开始 10使用结束 11 使用中
        public string Sid { get; set; }//学生学号
        public string Tid { get; set; }//座位号

        public virtual Student S { get; set; }
        public virtual Seat T { get; set; }
    }
}
