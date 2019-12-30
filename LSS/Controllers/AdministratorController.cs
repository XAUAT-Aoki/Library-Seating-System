using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LSS.UI.ViewModels;
using LSS.Service;

namespace LSS.UI.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="administrator">管理员视图对象</param>
        /// <returns>返回成功与否的视图页面</returns>
        public IActionResult Login(AdministratorViewModel administrator)
        {
            AdministratorImplement admin = new AdministratorImplement();

            admin.Login(administrator.username, administrator.password);




            return View();
        }
    }
}