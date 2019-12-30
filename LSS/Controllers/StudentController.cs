using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LSS.UI.ViewModels;
using LSS.Service;
using Newtonsoft.Json;
using LSS.Data;
using LSS.Infrastructure.Utility;
using System.Collections;


namespace LSS.UI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 功能：登录
        /// 参数：一个视图模型对象
        /// </summary>
        /// 
        /// <returns>返回一个视图页面（成功、失败）</returns>

        StudentImplement studentimpl = new StudentImplement();

        public IActionResult Login(StudentViewModel student) {

            //判断是否是第一次登录，并返回相应的页面



            studentimpl.Login(student.username,student.password);

            //判断是否登录成功
            //成功之后将账号（学号或邮箱）写入cookie


            return View();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="passwordviewmodel">密码试图</param>
        /// <returns>返回修改成功与否的页面</returns>
        public IActionResult ChangePassword(PasswordViewModel passwordviewmodel) {

            //判断新密码是否与旧密码和初始密码（123456）相同
            //相同则修改失败
            studentimpl.ChangePassword(passwordviewmodel.oldpassword, passwordviewmodel.newpassword);
            //如果密码修改成功之后，发送提示邮件

            return View();
        
        }
      
        /// <summary>
        /// 查询学生个人信息
        /// </summary>
        /// <returns>返回查询出来的个人信息(学生对象)</returns>
        public IActionResult StudentInformation() {

            
            Student student = studentimpl.StudentInformation();
            //对学生对象进行视图封装
            return View();
        }

        
        public IActionResult Leisure() {

           
            //str前端传入的查询条件信息
            var str=HttpContext.Request.Form["msg"];
            //将str反序列化为Condition对象（工具类中）


            //进行service处理
            List<Seat> list = studentimpl.Leisure(new Condition());

            return View();
        }



    }
}