using System;
using System.Collections.Generic;
using System.Text;
using LSS.Data;


namespace LSS.Mapper
{
    public class AdministratorMapper
    {

        /// <summary>
        /// 
        /// 查询密码
        /// </summary>
        /// <param name="user">工号</param>
        /// <returns>密文密码</returns>
        public string GetPassword(string user)
        {

            //根据对应的数据查询密码
            return "";
        }
        /// <summary>
        /// 向管理员表中写入该管理员的新密码
        /// </summary>
        /// <param name="username">管理员名</param>
        /// <param name="newpassword">新密码</param>
        public void ChangePassword(string username,string newpassword) {

            //直接写密码（管理员表）

        }

        /// <summary>
        /// 按座位号查询座位封装为对象
        /// </summary>
        /// <param name="seatid">座位号</param>
        /// <returns>返回座位对象</returns>

        public Seat eferSeatById(string seatid)
        {
            //直接在表中进行座位查询

            return new Seat();
        }

        /// <summary>
        /// 查询所有的符合条件的座位
        /// </summary>
        /// <param name="libraryname"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public List<Seat> ReferSeatViewModel(string libraryname, int floor)
        {

            return new List<Seat>();
        }

        public void SetSeatState(object id, int operation)
        {
            throw new NotImplementedException();
        }

        public List<string> GetSIdByOrder(string seatid)
        {

            //根据座位号查询目前未使用的订单对应的学号

            return new List<string>();

        }

        /// <summary>
        /// 修改座位状态
        /// </summary>
        /// <param name="seatid">座位id</param>
        /// <param name="operation">目标值</param>
        public void SeatInfor( string seatid, int operation)
        {
            //将座位所有时间的状态修改为operation
        }
    }



}
