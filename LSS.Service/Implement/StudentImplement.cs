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

            
            //明文密码加密
            string str = OperateMD5.GetMD5(password);

            //调用MApper中的方法

            //StudentMapper sm = new StudentMapper();
            //string pwd= sm.GetPasswordById(user);

            return true;
        }

        public bool ChangePassword(string oldpassword, string newpassword)
        {
            //旧密码加密，
            //新密码加密
            //获取cookie中的用户名

            //根据用户名查询密码
            //sm.GetPassword();

            //判断查询到的密码是否与旧密码相同


            //向数据库中写入新密码
            //sm.ChangePassword(用户名，新密码);

            return true;
        }

        /// <summary>
        /// 查询学生个人信息
        /// 
        /// </summary>
        /// <returns>学生对象返回给控制层</returns>
        public Student StudentInformation()
        {
            //从cookie中获取用户名

            return sm.StudentInformation("");
        }
        /// <summary>
        /// 进行空闲座位查询
        /// </summary>
        /// <param name="condition">查询条件封装对象</param>
        /// <returns>座位结果集</returns>
        public List<Seat> Leisure(Condition condition)
        {
            //在Mapper层中进行查询
            sm.Leisure(condition);


            return new List<Seat>();
        }

        /// <summary>
        /// 使用视图接受数据，进行预定座位
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="seatid">座位号</param>
        /// <param name="nowtime">开始预定时间</param>
        /// <param name="duration">时间块</param>
        /// <returns>返回是否预定成功</returns>
        public bool ReserveSeat(int date, string seatid, DateTime nowtime, int duration)
        {

            //从cookie中获取用户名

            //由mapper层返回lock字段


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
            int num =0;
            sm.SeatInfor(
                date,
                str,//座位状态信息
                seatid,//座位id
                num,//处理后需要修改的状态的开始坐标
                duration,//时长
                1 );//1表示状态变为1


            //插入一条订单记录到订单表（id,学号,座位号，订单开始时间，结束时间，打卡时间，订单状态）
            //订单id（图书馆号+层号+座位号+系统时间）

            //使用座位seatid查询订单id所需的数据，构造Order对象

            Seat seat = sm.GetSeat(seatid);


            sm.SetOrder(new Order());

            return true;
        }

       
        public void TimeOut() {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 60000;//执行间隔时间,单位为毫秒;此时时间间隔为1分钟  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(test);

            
        }

        private void test(object source, ElapsedEventArgs e)
        {

            if (DateTime.Now.Minute == 00)  //如果当前时间是10点30分
            {
                DateTime date = DateTime.Now;
                //查询订单中正在使用中且未过期，
                List<Order>list=sm.GetUsingOrder();

                foreach (Order order in list) {


                    //并且过期时间<=当前系统时间
                    //if (date.CompareTo(order.结束时间)) {

                    //    sm.ChangeOrderState(order.Oid);

                    //根据orderid获取username，根据username获取lock
                    //sm.ModifyInfor(0,0,username,ad);

                    //修改座位状态

                    //sn.SeatInfor(0，处理过的状态,座位ID,开始时间坐标，时长,0);

                    //}
                }
            }
        }
        public DateTime ClockIn(Clock clock)
        {
            //1. 先匹配是否是本人扫码打卡

            //邮箱查询学号  使用 ServiceUnit.getIdByEmail  方法   
            //学号查询正在使用中的订单  使用 sm.GetUsingOrder() 方法
            //从订单集中查询是否有clock.seatid 
            Order order=new Order();
            //foreach（var temp in List<Order>）
            //{
            //    if(temp.seatid==clock.seatid)
            //    {
            //        order = temp;
            //    }
            //}
            if(order==null)
            {
                //没有关于这张桌子的订单，返回 0
            }
            else
            {
                //继续向下判断
            }

            //2. 是否在指定时间内打卡

            //将回传的 clock.clocktime 与 对应订单中的打卡时间比对，判断是否在指定的时间范围内，
            // 使用 sm.IsTrueTime() 方法，传入实际打卡时间与预定打卡时间，返回 true/false

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

    }
}
