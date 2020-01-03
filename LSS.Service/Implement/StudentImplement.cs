using System;
using System.Collections.Generic;
using System.Text;
using LSS.Mapper;
using LSS.Infrastructure.Utility;
using LSS.Data;
using System.Timers;

namespace LSS.Service
{
    public class StudentImplement : IStudent
    {

        /// <summary>
        /// 登录接口实现，调用mapper具体实现
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        StudentMapper sm = new StudentMapper();
        public bool Login(string user, string password)
        {
            #region
            //明文密码加密
            string md5Pwd = OperateMD5.GetMD5(password);
            //调用MApper中的方法
            string pwd = sm.GetPassword(user);
            if (pwd == md5Pwd)
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
        /// 用户修改密码
        /// </summary>
        /// <param name="oldpassword">旧密码</param>
        /// <param name="newpassword">新密码</param>
        /// <param name="cookie">用户名</param>
        /// <returns></returns>
        public bool ChangePassword(string oldpassword, string newpassword, string cookie)
        {
            #region
            //旧密码加密，
            //新密码加密
            //获取cookie中的用户名
            string md5OldPwd = OperateMD5.GetMD5(oldpassword);
            string dbPwd = sm.GetPassword(cookie);
            if (md5OldPwd == dbPwd)
            {
                string md5NewPwd = OperateMD5.GetMD5(newpassword);
                if (sm.ChangePassword(cookie, md5NewPwd))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
            #endregion
        }

        /// <summary>
        /// 查询学生个人信息
        /// <paramref name="cookie">用户名</paramref>
        /// </summary>
        /// <returns>学生对象返回给控制层</returns>
        public Student StudentInformation(string cookie)
        {
            #region
            //从cookie中获取用户名
            return sm.StudentInformation(cookie);
            #endregion
        }
        /// <summary>
        /// 进行空闲座位查询
        /// </summary>
        /// <param name="condition">查询条件封装对象</param>
        /// <returns>座位结果集</returns>
        public List<Seat> Leisure(Condition condition)
        {
            #region
            //在Mapper层中进行查询
            List<Seat> seatList = sm.Leisure(condition);
            return seatList;
            #endregion
        }

        /// <summary>
        /// 使用视图接受数据，进行预定座位
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="seatid">座位号</param>
        /// <param name="nowtime">开始预定时间</param>
        /// <param name="duration">时间块</param>
        /// <param name="cookie">用户名</param>
        /// <returns>返回是否预定成功</returns>
        public bool ReserveSeat(int date, string seatid, DateTime nowtime, int duration, string cookie)
        {
            #region
            //从cookie中获取用户名

            //由mapper层返回lock字段
            string datetime = DateTime.Now.ToString("yyy-MM-dd");// 2008-09-04


            //根据date判断预定哪天的（第一天则>>1,第二天则<<7）

            //移位之后的结果是否>0(大于0不可定，否则可定)



            //不可定则直接返回false

            //根据座位号查座位的状态

            //根据date截取当天的状态字符
            string str = sm.SeatState(date, seatid);

            //取出时间中的小时，此字符串从该小时开始是否满足连续的时间块（duration）



            //不满足则直接false

            //满足上述所有条件，修改个人订单锁，座位状态，插入一条订单记录到订单表


            //sm.ModifyInfor(1,date,学号,lock字段);修改个人订单锁


            //修改座位状态
            int num = 0;
            sm.SeatInfor(
                date,
                str,//座位状态信息
                seatid,//座位id
                num,//处理后需要修改的状态的开始坐标
                duration,//时长
                1);//1表示状态变为1


            //插入一条订单记录到订单表（id,学号,座位号，订单开始时间，结束时间，打卡时间，订单状态）
            //订单id（图书馆号+层号+座位号+系统时间）

            //使用座位seatid查询订单id所需的数据，构造Order对象

            Seat seat = sm.GetSeat(seatid);


            sm.SetOrder(new Order());

            return true;
            #endregion
        }



        public DateTime ClockIn(Clock clock)//?
        {
            //1. 先匹配是否是本人扫码打卡

            //邮箱查询学号  使用 ServiceUnit.getIdByEmail  方法  
            string studentId = StudentImplement.getIdByEmail(clock.username);
            //学号查询正在使用中的订单  使用 sm.GetUsingOrder() 方法
            List<Order> orderList = sm.GetUsingOrder();
            //orderList.Find(o => o.Oid == clock.seatid);  ？？ seatid 和Tid
            //从订单集中查询是否有clock.seatid 
            Order order = new Order();
            //foreach（var temp in List<Order>）
            //{
            //    if(temp.seatid==clock.seatid)
            //    {
            //        order = temp;
            //    }
            //}
            if (order == null)
            {
                //没有关于这张桌子的订单，返回 0
            }
            else
            {
                //继续向下判断
            }

            //2. 是否在指定时间内打卡

            //将回传的 clock.clocktime 与 对应订单中的打卡时间比对，判断是否在指定的时间范围内，
            //实际打卡时间与预定打卡时间比对

            //3. 是否在指定地点打卡

            //根据座位号查询图书馆号，使用 sm.GetLIdBySId（） 方法，传入座位 ID，返回图书馆ID
            //根据图书馆号查询对应的经纬度信息与误差 使用 sm.GetLibraryById() 获取图书馆对象
            //将回传的定位信息与查询到的位置信息对比，判断是否在指定误差内


            //4. 打卡成功后刷新下次打卡时间，并返回下次打卡时间
            //int seconds = (Int64)(开始时间 - 结束时间).totalmillseconds / 1000;
            //if (seconds < 14400)
            //{//中间不再打卡

            //    //返回0
            //}
            //else if (seconds > 14400 && seconds < 28800)
            //{ //中间打1次的卡


            //}
            //else {//中间打2次卡 

            //}


            //打卡失败，返回0.

            return new DateTime(0);
        }



        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>是否取消成功</returns>
        public bool CancleOrder(string orderid)
        {
            #region
            //根据订单ID查找订单
            Order order = sm.GetOrder(orderid);


            //判断是否可以退订单（判断依据：订单在此时此刻是否已经开始使用）开始使用的标志是什么。

            //不可退则直接返回false

            //根据order.studentID修改个人lock锁

            //判断此订单是哪一天，确定date
            //获取当前个人lock锁字段
            //sm.getLock(学号);
            //sm.ModifyInfor(0,date,学号,lock字段);



            //根据座位idorder.seatid及订单开始结束时间修改座位状态修改

            //根据order。seatid获取座位的状态字段，num为处理过的开始下标，duration为时长，operation为0

            //sm.SeatInfor(date,座位状态（24位）,num,duration,operation);


            //修改此订单的状态为违规

            //sm.(orderid,目标值);

            return true;
            #endregion
        }



        /// <summary>
        /// 修改邮箱
        /// </summary>
        /// <param name="newemail">新的邮箱</param>
        /// <param name="cookie">用户名</param>
        /// <returns>返回true</returns>
        public bool ChangeEmail(string newemail, string cookie)
        {
            #region
            //从cookie中获取用户名username
            if (sm.ChangeEmail(cookie, newemail))
            {
                return true;
            }
            else
            {
                return false;
            }

            //if (!flag) { 

            //    //修改cookie值为newemail

            //}
            #endregion
        }


        /// <summary>
        /// 根据邮箱查询学号
        /// </summary>
        /// <param name="str">邮箱名</param>
        /// <returns>用户ID</returns>
        public static string getIdByEmail(string str)
        {
            #region
            StudentMapper mapper = new StudentMapper();
            Student student = mapper.StudentInformation(str);
            return student.Sid;
            #endregion
        }

        /// <summary>
        /// 通过学号取邮箱
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string getEmailById(string str)
        {
            #region
            StudentMapper mapper = new StudentMapper();
            Student student = mapper.StudentInformation(str);
            return student.Semail;
            #endregion
        }

    }
}
