using System;
using System.Collections.Generic;
using System.Text;
using LSS.Mapper;
using LSS.Infrastructure.Utility;
using LSS.Data;

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
    }
}
