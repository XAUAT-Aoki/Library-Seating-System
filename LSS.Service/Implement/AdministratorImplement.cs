using System;
using System.Collections.Generic;
using System.Text;
using LSS.Mapper;
using LSS.Infrastructure.Utility;
using LSS.Data;
using LSS.Service.Implement;

namespace LSS.Service
{
    public class AdministratorImplement
    {


        AdministratorMapper administrator = new AdministratorMapper();

        /// <summary>
        /// 登录服务实现
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>返回是否登录成功</returns>
        public bool Login(string username, string password)
        {

            //明文密码加密
            string str = OperateMD5.GetMD5(password);
            AdministratorMapper adminmapper = new AdministratorMapper();

            adminmapper.GetPassword(username);

            return true;
        }

        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="oldpassword">旧密码</param>
        /// <param name="newpassword">新密码</param>
        /// <returns></returns>
        public bool ChangePassword(string oldpassword, string newpassword)
        {
            //旧密码加密，
            //新密码加密
            //获取cookie中的用户名

            //根据用户名查询密码
            //administrator.GetPassword();

            //判断查询到的密码是否与旧密码相同


            //向数据库中写入新密码
            //administrator.ChangePassword(用户名，新密码);

            return true;
        }

        /// <summary>
        /// 根据id查询座位
        /// </summary>
        /// <param name="seatid">座位id</param>
        /// <returns>返回座位对象或空对象</returns>

        public Seat ReferSeatById(string seatid)
        {

            administrator.eferSeatById(seatid);

            return new Seat();
        }
        /// <summary>
        /// 查询座位
        /// </summary>
        /// <param name="libraryname"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public List<Seat> ReferSeatViewModel(string libraryname, int floor)
        {

            List<Seat> list = new List<Seat>();

            list=administrator.ReferSeatViewModel(libraryname,floor);

            return list;
        }

        /// <summary>
        /// 修改座位状态
        /// </summary>
        /// <param name="list">座位集合</param>
        /// <param name="operation">目标值</param>
        public void SetBatchSeatState(List<string> list, int operation)
        {
            SystemTest systemTest = new SystemTest();
            systemTest.SeatStateLock(list,operation);

        }

        /// <summary>
        /// 修改信誉积分基准值
        /// </summary>
        /// <param name="glory">信誉积分基准值</param>
        public void SetAllGlory(int glory)
        {
            SystemTest.standard = glory;
        }
    }
}
