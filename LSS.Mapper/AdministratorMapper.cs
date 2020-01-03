using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSS.Data;


namespace LSS.Mapper
{
    public class AdministratorMapper
    {

         #region 1.查询管理员密码 已完成
        /// <summary> 
        /// 
        /// 查询密码
        /// </summary>
        /// <param name="user">工号</param>
        /// <returns>密文密码</returns>
        public string GetPassword(string user)
        {
            using (var context = new LSSDataContext())
            {
                return context.Administor.Single(b => b.Aid == user).Apassword;
            }
        }
        #endregion
        #region 2.向管理员表中写入该管理员的新密码 已完成 
        /// <summary>
        /// 向管理员表中写入该管理员的新密码
        /// </summary>
        /// <param name="username">管理员名</param>
        /// <param name="newpassword">新密码</param>
        public bool ChangePassword(string userId, string newpassword)
        {
            //直接写密码（管理员表）
            bool flag = false;
            using (var dbContext = new LSSDataContext())
            {
                Administor adminstor = new Administor();
                //修改数据库信息最好有一些事务操作
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        adminstor = dbContext.Administor.Where(x => x.Aid == userId).FirstOrDefault();
                        adminstor.Apassword = newpassword;
                        dbContext.Administor.Update(adminstor);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                return flag;
            }
        }
        #endregion
        #region 3.按座位号查询座位封装为对象 已完成
        /// <summary>
        /// 按座位号查询座位封装为对象
        /// </summary>
        /// <param name="seatid">座位号</param>
        /// <returns>返回座位对象</returns>

        public Seat ReferSeatById(string seatid)
        {
            //直接在表中进行座位查询
            Seat seat = null;
            using (var dbContext = new LSSDataContext())
            {
                seat = dbContext.Seat.Where(x => x.Tid == seatid).FirstOrDefault();
            }
            return seat;
        }
        #endregion
        #region 4.查询所有的符合条件的座位 已完成
        /// <summary>
        /// 查询所有的符合条件的座位
        /// </summary>
        /// <param name="libraryname"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public List<Seat> ReferSeatViewModel(string libraryname, int floor)
        {
            using (var dbContext = new LSSDataContext())
            {
                int lid = dbContext.Library.Where(x => x.Lname == libraryname).FirstOrDefault().Lid;
                List<Seat> seat = new List<Seat>();
                var seats = (from list in dbContext.Seat
                             where list.Lid == lid && list.Tfloor == floor
                             select list).GetEnumerator();
                while (seats.MoveNext()) seat.Add(seats.Current);
                return seat;
            }
        }
        #endregion
        #region 5.设置座位状态  已完成 
        public bool SetSeatState(string id, string operation)
        {
            bool flag = false;
            using (var dbContext = new LSSDataContext())
            {
                Seat seat = new Seat();
                //修改数据库信息最好有一些事务操作
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        seat = dbContext.Seat.Where(x => x.Tid == id).FirstOrDefault();
                        seat.Tstate = operation;
                        dbContext.Seat.Update(seat);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                return flag;
            }
        }
        #endregion
        #region 6.根据座位号查询目前未使用的订单对应的学号 已完成
        public List<string> GetSIdByOrder(string seatid)
        {
            //根据座位号查询目前未使用的订单对应的学号
            using (var dbContext = new LSSDataContext())
            {
                List<string> str = new List<string>();
                var stringList = (from list in dbContext.Order
                                  where list.Tid == seatid && list.Ostate == "未用"
                                  select list.Sid).GetEnumerator();
                while (stringList.MoveNext()) str.Add(stringList.Current);
                return str;
            }
        }
        #endregion
        #region 7.修改座位状态 【operation 类型应该为string】已完成  传入为1或0,48为全为1或0
        /// <summary>
        /// 修改座位状态 【operation 类型应该为string】
        /// </summary>
        /// <param name="seatid">座位id</param>
        /// <param name="operation">目标值</param>
        public bool SeatInfor(string seatid, int operation)
        {
            //将座位所有时间的状态修改为operation
            Seat seat = new Seat();
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        seat = context.Seat.FirstOrDefault(x => x.Tid == seatid);
                        char[] a= new char[48];
                        for (int i = 0; i < 48; i++) a[i] = char.Parse(operation.ToString()); 
                        string str = new string(a);
                        seat.Tstate = str;
                        context.Seat.Update(seat);
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
        #region 8.根据订单id查询订单 已完成
        /// <summary>
        /// 根据订单id查询订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>返回一个订单</returns>
        public Order GetOrderById(string orderid)
        {
            Order order = new Order();
            using (var context = new LSSDataContext())
            {
                order = context.Order.FirstOrDefault(x => x.Oid == orderid);
            }
            return order;
        }
        #endregion
        #region 9.修改该学生的积分 已完成
        /// <summary>
        /// 修改该学生的积分
        /// </summary>
        /// <param name="studentid">学生id</param>
        public bool AddGlory(string studentid)
        {
            //给该学生的信誉积分加1
            Student student = new Student();
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        student = context.Student.FirstOrDefault(x => x.Sid == studentid);
                        student.Svalue += student.Svalue;
                        context.Student.Update(student);
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
        #region 10.获取所有的图书馆名称【未测试】
        /// <summary>
        /// 获取所有的图书馆名称
        /// </summary>
        /// <returns>返回所有的图书馆名称集</returns>
        public List<string> GetAllLibraryName()
        {
            List<string> libraryname = new List<string>();
            Library library = new Library();
            using (var context = new LSSDataContext())
            {
                libraryname = (from l in context.Library
                               select l.Lname).ToList();
            }
            return libraryname;
        }
        #endregion
        #region 11.添加图书馆 已完成 
        /// <summary>
        /// 添加图书馆
        /// </summary>
        /// <param name="library">图书馆对象</param>
        public bool AddLibrary(Library library)
        {
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Add(library);
                        context.SaveChanges();
                        transaction.Commit();
                        flag = true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    return false;
                }
            }


            //将除id之外的字段添加进图书馆表中
        }
        #endregion
        #region 12.获取该楼层的起始和结束楼层【未测试】
        /// <summary>
        /// 获取该楼层的起始和结束楼层
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <returns>返回list</returns>
        public List<int> GetFloor(string libraryname)
        {
            List<int> list = new List<int>();
            Library library = new Library();
            using (var context = new LSSDataContext())
            {
                library = context.Library.FirstOrDefault(x => x.Lname == libraryname);
            }
            list[0] = (int)library.Lsfloor;
            list[1] = (int)library.Lefloor;
            //将图书馆的起始楼层和结束楼层分别放在list的0、1空间中
            return list;
        }
        #endregion
        #region 13.修改该图书馆的起始楼层和结束楼层【未测试】
        /// <summary>
        /// 修改该图书馆的起始楼层和结束楼层
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <param name="startfloor">起始楼层</param>
        /// <param name="endfloor">结束楼层</param>
        public bool AddFloor(string libraryname, int startfloor, int endfloor)
        {
            //修改该图书馆的起始楼层和结束楼层
            Library library = new Library();
            bool flag = false;
            using (var context = new LSSDataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        library = context.Library.FirstOrDefault(x => x.Lname == libraryname);
                        library.Lsfloor = startfloor;
                        library.Lefloor = endfloor;
                        context.Library.Update(library);
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
    }



}
