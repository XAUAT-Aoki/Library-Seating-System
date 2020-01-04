
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace LSS.Infrastructure.Utility
{
    public class ServiceUnit
    {


        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="str">收件人邮箱地址</param>
        /// <param name="text">邮件正文</param>
        public static void SendEmail(string str, string text)
        {


            //创建一个邮件对像
            MailMessage mail = new MailMessage();
            //发件人邮箱,就是之前准备的邮箱
            mail.From = new MailAddress("csharp1606020212@126.com");
            //收件人邮箱，可以添加多个
            mail.To.Add(new MailAddress(str));
            //设置邮件主题和正文
            mail.SubjectEncoding = Encoding.UTF8;//编码
            mail.Subject = "提示邮件";
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = text;
            //创建一个发送邮件的对像 服务地址和端口（这里使用的是QQ的服务器）
            SmtpClient smtpClient = new SmtpClient("smtp.126.com", 25);
            //发件人帐号和授权码
            smtpClient.Credentials = new NetworkCredential("csharp1606020212@126.com", "wangben1234");
            try
            {
                smtpClient.Send(mail);
                //Console.WriteLine("邮件发送成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine("邮件发送失败！异常信息：" + ex.Message);
            }


            //给str邮箱发送一份内容为text的邮件

        }


    }
}
