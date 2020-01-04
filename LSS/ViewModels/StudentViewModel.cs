using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LSS.UI.ViewModels
{
    public class StudentViewModel
    {

        [Required, MaxLength(20)]
        public string username { get; set; }

        [Required, MaxLength(16)]
        public string password { get; set; }

    }

    public class PasswordViewModel {
       
        [Required, MaxLength(16)]
        public string oldpassword { get; set; }

        [Required, MaxLength(16)]
        public string newpassword { get; set; }



    }

    public class ReserveSeatViewModel {


        public string seatid { get; set; }
        public int date { get; set; }
        public DateTime nowtime { get; set; }

        public int duration { get; set; }

    }


    public class QuerySeatView
    {
        public string Libraryname { get; set; }

        public int Floor { get; set; }

        public int timeSelect1 { get; set; } //开始时间

        public int timeSelect { get; set; } //结束时间

        public int dateSelect { get; set; } //日期
    }



}
