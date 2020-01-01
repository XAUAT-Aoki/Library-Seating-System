using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using LSS.Data;
using LSS.Mapper;
using LSS.Infrastructure.Utility;


namespace LSS.Service.Implement
{
    /// <summary>
    /// 系统定时任务
    /// </summary>
    public class SystemTest
    {

        private List<string> list = null;
        private int operation = -1;

        public static int standard = 2;
        StudentMapper sm = new StudentMapper();
        StudentImplement studentimplement = new StudentImplement();
        AdministratorMapper administratorMapper = new AdministratorMapper();

        /// <summary>
        /// 订单自动过期定时查询查询
        /// </summary>
        public void TimeOut()
        {
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
                List<Order> list = sm.GetUsingOrder();

                foreach (Order order in list)
                {


                    //并且过期时间<=当前系统时间
                    //if (date.CompareTo(order.结束时间)) {

                    //    sm.ChangeOrderState(order.Oid,目标值);

                    //根据orderid获取username，根据username获取lock
                    //sm.ModifyInfor(0,0,username,ad);

                    //修改座位状态

                    //sn.SeatInfor(0，处理过的状态,座位ID,开始时间坐标，时长,0);

                    //}


                    //同时判断订单开始时间是否小于等于当前时间，如果是，则将符合要求的订单的状态置为正在使用
                    //使用  sm.ChangeOrderState(order.Oid,目标值);
                }
            }
        }

        //===============================================================================

        /// <summary>
        /// 定时重置信誉积分
        /// </summary>
        public void ResetGlory()
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1800000;//执行间隔时间,单位为毫秒;此时时间间隔为30分钟
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(test1);


        }
        private void test1(object source, ElapsedEventArgs e)
        {

            if ((int)DateTime.Now.DayOfWeek == 0 && DateTime.Now.Hour == 23)  //如果当前时间是10点30分
            {
                //直接更新所有学生的积分字段
                sm.ResetGlory(standard);
            }
        }


        //===============================================================================

            /// <summary>
            /// 定时检测违规
            /// </summary>
        public void MisInfor()
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 6000;//执行间隔时间,单位为毫秒;此时时间间隔为1分钟  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(test2);

        }
        //将该订单状态置为违规，并扣除该订单对应的学生的信誉积分，同时将订单对应的座位的状态改变，
        private void test2(object source, ElapsedEventArgs e)
        {
            List<Order> orders = sm.GetUsingOrder();
            DateTime currenttime = DateTime.Now;
            //foreach(var temp in orders)
            //{
            //    if((currenttime-订单打卡时间)>30 min)
            //        {



            //        // 订单置为违规使用   sm.ChangeOrderState(order.Oid,目标值);
            //        // 扣除学生信誉积分  sm.DuctGlory(string stuId);
            //        //同时判断扣除后的信誉积分是否大于 0，如果大于 0 ，不做处理。否则，判断是否有第二天的订单，如果有，则取消第二天订单。
            //        if(sm.GetGlory(string stuId)<=0)
            //        {
            //            //查询第二天是否有订单
            //            var result=sm.GetSecondOrder(stuId,1);
            //            if(result!=null)
            //            {
            //                //取消第二天的订单
            //                 studentimplement.CancleOrder(result.Oid);

            //            }
            //        }
           //          sm.SeatState(0, result.Sid);  获取座位的状态字段
            //        //修改第一天订单对应的座位的状态
            //        sm.SeatInfor(0, //代表第一天
            //                   state,//座位的状态字段
            //                   result.Sid, //订单中的座位 ID
            //                   num,//处理后的订单开始下标
            //                   endtime - starttime,//订单时长
            //                   0);//目标值
            //    }
            
             
        }



        //===============================================================================

        /// <summary>
        /// 座位状态锁定
        /// </summary>
        public void SeatStateLock(List<string> list,int operation)
        {
            this.list = list;
            this.operation = operation;

            if (operation==0) {

                foreach (string seatid in list) {

                    administratorMapper.SeatInfor(seatid, operation);
                }
                return;
            }
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 360000;//执行间隔时间,单位为毫秒;此时时间间隔为 1 小时  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(test3);

        }
        //将该订单状态置为违规，并扣除该订单对应的学生的信誉积分，同时将订单对应的座位的状态改变，
        private void test3(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now.Hour>=23) {

                foreach (string seatid in list) {
                    List<string> usernamelist = administratorMapper.GetSIdByOrder(seatid);
                    foreach (string str in usernamelist) {

                        string email=ServiceUnit.getEmailById(str);

                        ServiceUnit.SendEmail(email,"邮件正文");
                    }

                    //administratorMapper.SeatInfor(seat.id,operation);

                }
            
            }

        }
    }
}
