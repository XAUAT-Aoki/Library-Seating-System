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


            //如果开始时间和结束时间为null，则查询开始时间不小于6点，结束时间不大于23点


            return new List<Seat>();
        }


        /// <summary>
        /// 处理含有空字符的数据
        /// </summary>
        /// <param name="condition">返回处理结果用于可直接拼装sql的对象</param>
        /// <returns></returns>
        public Condition LeisureDeal(Condition condition) {


            return new Condition();
        }
    }
}
