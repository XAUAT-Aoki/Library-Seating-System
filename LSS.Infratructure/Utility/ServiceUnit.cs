using LSS.Data;
using LSS.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSS.Infrastructure.Utility
{
    public class ServiceUnit
    {


        /// <summary>
        /// 根据邮箱查询学号
        /// </summary>
        /// <param name="str">邮箱名</param>
        /// <returns>用户ID</returns>
        public static string getIdByEmail(string str)
        {
            StudentMapper mapper = new StudentMapper();
            Student student = mapper.StudentInformation(str);
            return student.Sid;
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="str">收件人邮箱地址</param>
        /// <param name="text">邮件正文</param>
        public static void SendEmail(string str,string text) { 
        
            //给str邮箱发送一份内容为text的邮件


        }
        /// <summary>
        /// 通过学号取邮箱
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string getEmailById(string str) 
        {
            StudentMapper mapper = new StudentMapper();
            Student student = mapper.StudentInformation(str);
            return student.Semail;
        }

    }
}
