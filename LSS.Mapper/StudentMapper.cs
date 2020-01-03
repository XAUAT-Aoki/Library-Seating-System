using System;
using LSS.Data;
using Microsoft.EntityFrameworkCore;
using LSS.Infrastructure.Utility;
using System.Collections.Generic;

namespace LSS.Mapper
{
    public class StudentMapper
    {
          #region 正式测试
        #region 1.查询密码  已完成
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
            var student = "";
            using (var context = new LSSDataContext())
            {
                MapperUnit h = new MapperUnit();
                if (h.IsStudentId(user)) student = context.Student.Single(b => b.Sid == user).Spassword;
                else student = context.Student.Single(b => b.Semail == user).Spassword;
            }
            return student;
        }
        #endregion
        #region 2.修改密码 这里修改了返回类型 已完成
        /// <summary>
        /// 修改数据库中的对应密码
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public bool ChangePassword(string user, string password)
        {
            //使用工具方法判断学号/邮箱IsStudentId（）
            //修改对应密码
            Student student = null;
            bool flag = false;
            MapperUnit h = new MapperUnit();
            using (var dbContext = new LSSDataContext())
            {
                //修改数据库信息最好有一些事务操作
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {//学号
                        if (h.IsStudentId(user)) student = dbContext.Student.Where(x => x.Sid == user).ToList().First();
                        else student = dbContext.Student.Where(x => x.Semail == user).ToList().First();
                        student.Spassword = password;
                        dbContext.Student.Update(student);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    return flag;
                }
            }
        }
        #endregion
        #region 3.根据邮箱或学号，姓名返回学生 已完成
        public Student StudentInformation(string username)
        {
            //使用工具方法判断学号/邮箱IsStudentId（）
            //使用username查询出学生对象；使用框架查询
            Student student = null;
            using (var dbContext = new LSSDataContext())
            {
                MapperUnit h = new MapperUnit();
                if (h.IsStudentId(username)) student = dbContext.Student.Where(x => x.Sid == username).ToList().First();
                else student = dbContext.Student.Where(x => x.Semail == username).ToList().First();
            }
            return student;
        }
        #endregion

        #region 4.空闲座位查询 未完成
        /// <summary>
        /// 空闲座位查询
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /* public List<Seat> Leisure(Condition condition)
         {
             Condition StartCondition = LeisureDeal(condition);
             //判断是否是当天的日期
             //如果开始时间和结束时间为null，则查询开始时间不小于6点，结束时间不大于23点
             //如果输入condition.TimeBulk是0，则使用“111111111111111”
             //对condition.data进行日期判断
             return new List<Seat>();
         }*/
        #endregion
        #region 5.不懂  未完成
        /*  /// <summary>
          /// 处理含有空字符的数据
          /// </summary>
          /// <param name="condition">返回处理结果用于可直接拼装sql的对象</param>
          /// <returns>返回处理过的对象</returns>
          public Condition LeisureDeal(Condition condition)
          {
              //使用try{]catch(){}语句处理转换异常
              return new Condition();
          }*/
        #endregion

        #region 6.查询座位状态 已完成
        public string SeatState(int date, string seatid)
        {
            using (var context = new LSSDataContext())
            {
                //查询状态字段，
                string str = context.Seat.FirstOrDefault(x => x.Tid == seatid).Tstate;
                char[] str2 = new char[24];
                //判断是否是当天的状态
                if (date == 0)
                {
                    str2 = str.Substring(0, 24).ToCharArray();
                }
                else
                {
                    str2 = str.Substring(24, 24).ToCharArray();
                }
                string str3 = new string(str2);
                return str3;
            }
        }
        #endregion
        #region 7.修改个人的lock锁 已完成 修改了传入参数operation为char类型，去掉ad(原来获取的锁的状态）
        /// <summary>
        /// 修改个人的lock锁
        /// </summary>
        /// <param name="operation">状态修改的目标值这里为char类型，只传一个字符就可以例如‘1’</param>
        /// <param name="date">日期</param>
        /// <param name="username">个人id</param>
        public bool ModifyInfor(char operation, int date, string username)
        {
            Student student = new Student();
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        student = context.Student.FirstOrDefault(x => x.Sid == username);
                        char[] old = { student.Slock.ElementAt(0), student.Slock.ElementAt(1) };
                        if (date == 0) old[0] = operation;//修改第一天的状态
                        else old[1] = operation;//修改第二天的状态
                        string str = new string(old);
                        student.Slock = str;
                        context.Update(student);
                        context.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    return flag;
                }
            }
        }
        #endregion
        #region 8.查询lock锁状态     已完成
        /// <summary>
        /// 查询lock字段，返回byte[0]
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string getLock(string username)
        {
            using (var dbContext = new LSSDataContext())
            {
                Student state = new Student();
                MapperUnit h = new MapperUnit();
                if (h.IsStudentId(username))
                    state = dbContext.Student.Where(x => x.Sid == username).FirstOrDefault();
                else
                    state = dbContext.Student.Where(x => x.Semail == username).FirstOrDefault();
                return state.Slock;
            }
            //调用正则匹配，进行查询lock字段
        }
        #endregion
        #region 9.修改座位状态【函数 返回值 有差异】 返回类型给为bool  已完成
        /// <summary>
        /// 修改座位状态
        /// </summary>
        /// <param name="date">第几天</param>
        /// <param name="str">座位状态信息</param>
        /// <param name="seatid">座位id</param>
        /// <param name="num">处理后需要修改的状态的开始坐标</param>
        /// <param name="duration">时长</param>
        /// <param name="operation">目标值</param>
        public bool SeatInfor(int date, string seatid, int num, int duration, char operation)
        {
            Seat seat = new Seat();
            using (var context = new LSSDataContext())
            {
                seat = context.Seat.FirstOrDefault(x => x.Tid == seatid);
                char[] c = new char[48];
                c = seat.Tstate.ToCharArray();
                if (date == 1)
                {
                    for (int i = 23 + num; i < 23 + num + duration; i++)
                        c[i] = operation;
                }
                else
                {
                    for (int i = num; i < num + duration; i++)
                        c[i] = operation;
                }
                string s = new string(c);
                seat.Tstate = s;
                context.Seat.Update(seat);
                context.SaveChanges();
            }
            return true;
            //将字符串修改之后直接插入座位表
        }
        #endregion
        #region 10.订单增加一条数据【已完成】
        /// <summary>
        /// 在订单表中插入一条记录
        /// </summary>
        /// <param name="order"></param>
        public bool SetOrder(Order order)
        {
            //插入一条订单记录到订单表（id,学号,座位号，订单开始时间，结束时间，打卡时间，订单状态）
            //订单id（图书馆号+层号+座位号+系统时间）
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                context.Order.Add(order);
                context.SaveChanges();
                flag = true;
            }
            return flag;
        }
        #endregion
        #region 11.根据Seat的ID获取Seat对象 已完成
        /// <summary>
        /// 根据seatid获取该seat对象
        /// </summary>
        /// <param name="seatid"></param>
        /// <returns>一个seat对象</returns>
        public Seat GetSeat(string seatid)
        {
            Seat seat = new Seat();
            using (var context = new LSSDataContext())
            {
                seat = (from s in context.Seat
                        where s.Tid == seatid
                        select s).ToList().FirstOrDefault();
            }
            return seat;
        }
        #endregion
        #region 12.获取所有正在使用的订单 已完成
        //获取所有正在使用的订单
        public List<Order> GetUsingOrder()
        {
            using (var dbContext = new LSSDataContext())
            {
                List<Order> Olist = new List<Order>();
                DateTime dtToday = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                var queryable = (from list in dbContext.Order
                                 where dtToday >= list.Ostime && dtToday <= list.Oetime
                                 select list).GetEnumerator();
                while (queryable.MoveNext()) Olist.Add(queryable.Current);
                return Olist;
            }
        }
        #endregion
        #region 13.根据订单改变订单状态【已完成】，修改传入参数传入状态为string,修改传入id为string，原来为object。修改返回类型为bool
        /// <summary>
        /// 根据ID直接改变订单状态
        /// </summary>
        /// <param name="oid">订单ID</param>
        public bool ChangeOrderState(string oid, string operation)
        {
            //根据ID直接改变订单状态
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var order = context.Order.Where(x => x.Oid == oid).FirstOrDefault();
                        order.Ostate = operation;
                        context.Order.Update(order);
                        context.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return flag;
        }
        #endregion
        #region 15.根据座位 ID 在座位表内查询对应的图书馆号 已完成
        /// <summary>
        /// 根据座位 ID 在座位表内查询对应的图书馆号
        /// </summary>
        /// <param name="seatId">座位 ID</param>
        /// <returns>返回图书馆 ID</returns>
        public int GetLIdBySId(string seatId)
        {
            Seat seat = new Seat();
            using (var context = new LSSDataContext())
            {
                seat = (from s in context.Seat
                        where s.Tid == seatId
                        select s).ToList().FirstOrDefault();
            }
            return seat.Lid;
        }
        #endregion
        #region 16.根据图书馆 ID 返回一个图书馆对象   已完成
        /// <summary>
        /// 根据图书馆 ID 返回一个图书馆对象
        /// </summary>
        /// <param name="libraryId">图书馆 ID</param>
        /// <returns>图书馆对象</returns>
        public Library GetLibraryById(int libraryId)
        {
            Library library = new Library();
            using (var context = new LSSDataContext())
            {
                library = (from s in context.Library
                           where s.Lid == libraryId
                           select s).ToList().FirstOrDefault();
            }
            return library;
        }
        #endregion
        #region 17.根据id查询订单 已完成
        /// <summary>
        /// 根据id查询订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>返回订单对象</returns>
        public Order GetOrder(string orderid)
        {
            //根据id查询一个订单记录，并返回Order对象
            using (var context = new LSSDataContext())
            {
                return context.Order.FirstOrDefault(x => x.Oid == orderid);
            }
        }
        #endregion
        #region 18.修改学生邮箱 已完成 
        /// <summary>
        /// 修改学生邮箱
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newemail"></param>
        /// <returns></returns>
        public bool ChangeEmail(string username, string newemail)
        {
            MapperUnit h = new MapperUnit();
            bool flags = false;
            //正则表达匹配用户名，学号true
            bool flag = h.IsStudentId(username);
            Student s = new Student();
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (!flag)
                        {
                            s = context.Student.FirstOrDefault(x => x.Sid == username);
                            s.Semail = newemail;
                            context.Student.Update(s);
                            context.SaveChanges();
                            transaction.Commit();
                            flags = true;
                            //修改对应邮箱，返回true
                        }
                        else
                        {
                            s = context.Student.FirstOrDefault(x => x.Semail == username);
                            s.Semail = newemail;
                            context.Student.Update(s);
                            context.SaveChanges();
                            transaction.Commit();
                            flags = true;
                            //修改邮箱，返回false
                        }
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    return flags;
                }
            }

        }
        #endregion
        #region 18.5修改学生的积分
        /// <summary>
        /// 修改学生的积分
        /// </summary>
        /// <param name="a">目标值</param>
        public bool ResetGlory(int a)
        {
            //将所有学生的积分值都修改为a
            List<Student> student = new List<Student>();
            using (var context = new LSSDataContext())
            {
                student = (from s in context.Student
                           select s
                         ).ToList();
                for (int i = 0; i < student.LongCount(); i++)
                {
                    student[i].Svalue = a;
                    context.Student.Update(student[i]);
                }
                context.SaveChanges();
            }
            return true;
        }
        #endregion
        #region 19.根据学号获取学生的信誉积分 已完成
        /// <summary>
        /// 根据学号获取学生的信誉积分
        /// </summary>
        /// <param name="stuId">学号</param>
        /// <returns>信誉积分</returns>
        public int GetGlory(string stuId)
        {
            using (var context = new LSSDataContext())
            {
                int level = (int)context.Student.FirstOrDefault(x => x.Sid == stuId).Svalue;
                return level;
            }
        }
        #endregion
        #region 20.根据学生学号以及传入的代表第二天的参数 data（1），获取第二天的订单 已完成
        /// <summary>
        /// 根据学生学号以及传入的代表第二天的参数 data（1），获取第二天的订单
        /// </summary>
        /// <param name="stuId">学号</param>
        /// <param name="data">代表第二天的参数</param>
        /// <returns>第二天的订单（如果不存在，返回 null）</returns>
        public Order GetSecondOrder(string stuId, int data = 1)
        {
            //查询并封装为order对象
            string s2 = DateTime.Now.AddDays(1).Date.ToString("yyyy-MM-dd") + " 00:00:00";
            DateTime day2 = Convert.ToDateTime(s2);
            string s1 = DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00";
            DateTime day1 = Convert.ToDateTime(s1);
            List<Order> orders = new List<Order>();
            using (var dbContext = new LSSDataContext())
            {
                if (data==0)
                {
                    var order = (from o in dbContext.Order
                                 where o.Sid == stuId && day1 <= o.Ostime && o.Oetime <= day2
                                 select o).GetEnumerator();
                    while (order.MoveNext()) orders.Add(order.Current);
                }
                else
                {
                    var order = (from o in dbContext.Order
                                 where o.Sid == stuId && day2 <= o.Ostime
                                 select o).GetEnumerator();
                    while (order.MoveNext()) orders.Add(order.Current);
                }
                return orders.Last();
            }
        }
        #endregion
        #endregion

        
    }
}
