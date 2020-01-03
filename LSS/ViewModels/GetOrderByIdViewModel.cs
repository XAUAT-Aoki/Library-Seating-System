using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSS.ViewModels
{
    public class GetOrderByIdViewModel
    {
        //订单id
        public string OrderId { get; set; }
        //学生姓名
        public string sudentName { get; set; }
        //学生学号
        public string studentId { get; set; }
        //开始时间
        public DateTime? startTime { get; set; }
        //结束时间
        public DateTime? endTime { get; set; }
        public string orderState { get; set; }

    }
}
