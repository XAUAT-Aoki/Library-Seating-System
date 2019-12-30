using System;
using LSS.Data;
using System.Collections.Generic;
using LSS.Infrastructure.Utility;


namespace LSS.Service
{
    interface IStudent
    {

        /// <summary>
        /// 登录服务
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回是否验证成功</returns>
        bool Login(string user,string password);


        bool ChangePassword(string oldpassword,string newpassword);


        Student StudentInformation();


        List<Seat> Leisure(Condition condition);

        bool ReserveSeat(int date, string seatid, DateTime nowtime, int duration);

    }
}
