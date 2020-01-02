using System;
using System.Collections.Generic;
using LSS.Mapper;
using LSS.Infrastructure.Utility;
using LSS.Data;
using LSS.Service.Implement;
using Microsoft.AspNetCore.Http;
using RestSharp;

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
            string adminPwd=administrator.GetPassword(username);
            if (str == adminPwd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="oldpassword">旧密码</param>
        /// <param name="newpassword">新密码</param>
        /// <returns></returns>
        public bool ChangePassword(string oldpassword, string newpassword,string cookie)
        {
            #region
            string oldPwd = OperateMD5.GetMD5(oldpassword);
            string newPwd = OperateMD5.GetMD5(newpassword);
            string dbOldPwd=administrator.GetPassword(cookie);
            if(dbOldPwd==oldPwd&& administrator.ChangePassword(cookie, newPwd))
            {
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }

        /// <summary>
        /// 根据id查询座位
        /// </summary>
        /// <param name="seatId">座位id</param>
        /// <returns>返回座位对象或空对象</returns>

        public Seat ReferSeatById(string seatId)
        {
            Seat seat=administrator.referSeatById(seatId);
            return seat;
        }
        /// <summary>
        /// 查询座位
        /// </summary>
        /// <param name="libraryname"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public List<Seat> ReferSeatByFloor(string libraryname, int floor)
        {
            List<Seat> seatList = new List<Seat>();
            seatList = administrator.ReferSeatByFloor(libraryname, floor);
            return seatList;
        }

        /// <summary>
        /// 修改座位状态
        /// </summary>
        /// <param name="list">座位集合</param>
        /// <param name="operation">目标值</param>
        public void SetBatchSeatState(List<string> list, int operation)
        {
            SystemTask systemTask = new SystemTask();
            systemTask.SeatStateLock(list, operation);
        }

        /// <summary>
        /// 修改信誉积分基准值
        /// </summary>
        /// <param name="glory">信誉积分基准值</param>
        public void SetAllGlory(int glory)
        {
            SystemTask.standard = glory;
        }

        /// <summary>
        /// 按照订单id查询订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>一个订单</returns>
        public Order GetOrderById(string orderid)
        {
            Order order = administrator.GetOrderById(orderid);

            return order;
        }



        /// <summary>
        /// 修改违规订单学生的积分
        /// </summary>
        /// <param name="studentid">学生的id</param>
        public void AddGlory(string studentid)
        {
            administrator.AddGlory(studentid);
        }


        /// <summary>
        /// 判断该图书馆名称是否存在
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <returns>是否存在</returns>
        public bool IsExist(string libraryname)
        {

            List<string> list = administrator.GetAllLibraryName();

            //判断list中是否存在libraryname

            return true;
        }

        /// <summary>
        /// 添加图书馆
        /// </summary>
        /// <param name="library">图书馆对象</param>
        public void AddLibrary(Library library)
        {
            administrator.AddLibrary(library);
        }


        /// <summary>
        /// 查找图书馆的起始和结束楼层
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <returns>返回list</returns>
        public List<int> GetFloor(string libraryname)
        {

            //获取起始楼层和结束楼层
            List<int> list = administrator.GetFloor(libraryname);



            return list;
        }

        /// <summary>
        /// 修改该图书馆的起始楼层和结束楼层
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <param name="startfloor">起始楼层</param>
        /// <param name="endfloor">结束楼层</param>
        public void AddFloor(string libraryname, int startfloor, int endfloor)
        {
            administrator.AddFloor(libraryname,startfloor,endfloor);
        }
    }
}
