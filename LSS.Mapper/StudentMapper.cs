using System;
using LSS.Data;
using Microsoft.EntityFrameworkCore;
using LSS.Infrastructure.Utility;
using System.Collections.Generic;

namespace LSS.Mapper
{
    public class StudentMapper
    {
        /// <summary>
        /// 
        /// 查询密码
        /// </summary>
        /// <param name="user">邮箱或学号</param>
        /// <returns>密文密码</returns>
        public string GetPassword(string user)
        {
            //正则匹配（区分邮箱和学号）IsStudentId（）
            //根据对应的数据查询密码
            return "";
        }
        /// <summary>
        /// 修改数据库中的对应密码
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public void ChangePassword(string user, string password) {

            //使用工具方法判断学号/邮箱IsStudentId（）
            //修改对应密码
        }

        public Student StudentInformation(string username)
        {
            //使用工具方法判断学号/邮箱IsStudentId（）
            //使用username查询出学生对象；使用框架查询
            return new Student();
        }
        /// <summary>
        /// 空闲座位查询
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Seat> Leisure(Condition condition)
        {
            Condition StartCondition = LeisureDeal(condition);

            //判断是否是当天的日期
            //如果开始时间和结束时间为null，则查询开始时间不小于6点，结束时间不大于23点
            //如果输入condition.TimeBulk是0，则使用“111111111111111”
            //对condition.data进行日期判断

            return new List<Seat>();
        }


        /// <summary>
        /// 处理含有空字符的数据
        /// </summary>
        /// <param name="condition">返回处理结果用于可直接拼装sql的对象</param>
        /// <returns>返回处理过的对象</returns>
        public Condition LeisureDeal(Condition condition) {

            //使用try{]catch(){}语句处理转换异常
            return new Condition();
        }

        public string SeatState(int date, string seatid)
        {

            //查询状态字段，



            //判断是否是当天的状态

            //截取所需当天的24位字符并返回

            return "";
        }

        /// <summary>
        /// 修改个人的lock锁
        /// </summary>
        /// <param name="operation">状态修改的目标值</param>
        /// <param name="date">日期</param>
        /// <param name="username">座位ID</param>
        /// <param name="">lock字段</param>
        public void ModifyInfor(int operation,int date,string username,byte ad)
        {

        }


        /// <summary>
        /// 查询lock字段，返回byte[0]
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public byte getLock(string username) {

            //调用正则匹配，进行查询lock字段

            return 1;
        }
        /// <summary>
        /// 修改座位状态
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="str">座位状态信息</param>
        /// <param name="seatid">座位id</param>
        /// <param name="num">处理后需要修改的状态的开始坐标</param>
        /// <param name="duration">时长</param>
        /// <param name="operation">目标值</param>
        public void SeatInfor(int date,string str, string seatid, int num, int duration,int operation)
        {
            //将字符串修改之后直接插入座位表
        }


        /// <summary>
        /// 在订单表中插入一条记录
        /// </summary>
        /// <param name="order"></param>
        public void SetOrder(Order order)
        {
            //插入一条订单记录到订单表（id,学号,座位号，订单开始时间，结束时间，打卡时间，订单状态）
            //订单id（图书馆号+层号+座位号+系统时间）
        }



        /// <summary>
        /// 根据seatid获取该seat对象
        /// </summary>
        /// <param name="seatid"></param>
        /// <returns>一个seat对象</returns>
        public Seat GetSeat(string seatid)
        {
            return new Seat();
        }
        //获取所有正在使用的订单
        public List<Order> GetUsingOrder()
        {
            return new List<Order>();
        }
        /// <summary>
        /// 根据ID直接改变订单状态
        /// </summary>
        /// <param name="oid">订单ID</param>
        public void ChangeOrderState(object oid,int operation)
        {
            //根据ID直接改变订单状态
        }

        /// <summary>
        /// 返回打卡时间是否在指定时间范围内
        /// </summary>
        /// <param name="now">实际打卡时间</param>
        /// <param name="predict">预计打卡时间</param>
        /// <returns></returns>
        public bool IsTrueTime(DateTime now,DateTime predict)
        {
            //实际打卡时间必须在预定打卡时间开始后半小时之内
            return true;
        }

        /// <summary>
        /// 根据座位 ID 在座位表内查询对应的图书馆号
        /// </summary>
        /// <param name="seatId">座位 ID</param>
        /// <returns>返回图书馆 ID</returns>
        public string GetLIdBySId(string seatId)
        {
            return "";
        }

        /// <summary>
        /// 根据图书馆 ID 返回一个图书馆对象
        /// </summary>
        /// <param name="libraryId">图书馆 ID</param>
        /// <returns>图书馆对象</returns>
        public Library GetLibraryById(string libraryId)
        {
            return new Library();
        }

        /// <summary>
        /// 根据id查询订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>返回订单对象</returns>
        public Order GetOrder(string orderid)
        {
            //根据id查询一个订单记录，并返回Order对象

            return new Order();
        }

        public bool ChangeEmail(string username, string newemail)
        {
            //正则表达匹配用户名，学号true
            bool flag = MapperUnit.IsStudentId(username);

            if (flag)
            {

                //修改对应邮箱，返回true

                return true;

            }
            else {

                //修改邮箱，返回false
                return false;
            }

        }
        /// <summary>
        /// 修改学生的积分
        /// </summary>
        /// <param name="a">目标值</param>
        public void ResetGlory(int a)
        {
            //将所有学生的积分值都修改为a
        }

        /// <summary>
        /// 根据学号获取学生的信誉积分
        /// </summary>
        /// <param name="stuId">学号</param>
        /// <returns>信誉积分</returns>
        public int GetGlory( string stuId)
        {
            return 0;
        }

        /// <summary>
        /// 根据学生学号以及传入的代表第二天的参数 data（1），获取第二天的订单
        /// </summary>
        /// <param name="stuId">学号</param>
        /// <param name="data">代表第二天的参数</param>
        /// <returns>第二天的订单（如果不存在，返回 null）</returns>
        public Order GetSecondOrder(string  stuId, int data=1)
        {
            Order order = null;

            //查询并封装为order对象

            return order;
        }
    }
}
