using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LSS.UI.ViewModels;
using LSS.Service;
using LSS.Data;

namespace LSS.UI.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        AdministratorImplement administrator = new AdministratorImplement();


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

        public IActionResult ChangePassword(PasswordViewModel passwordViewModel) {


            //判断新密码是否与旧密码和初始密码（123456）相同
            //相同则修改失败

            administrator.ChangePassword(passwordViewModel.oldpassword,passwordViewModel.newpassword);

            return View();
        }

        /// <summary>
        /// 根据座位号查询特定座位
        /// </summary>
        /// <param name="seatid">座位号</param>
        /// <returns></returns>
        public IActionResult ReferSeatById(string seatid) {


            Seat seat = administrator.ReferSeatById(seatid);

            return View();
        }


        /// <summary>
        /// 根据图书馆和图书馆号查询座位集
        /// </summary>
        /// <param name="referSeatViewModel">图书馆及楼层视图</param>
        /// <returns>查询出的座位页面</returns>
        public IActionResult ReferSeatByFloor(ReferSeatViewModel referSeatViewModel) {

            List<Seat> list = administrator.ReferSeatViewModel(referSeatViewModel.libraryname, referSeatViewModel.floor);


            return View();
        }

        /// <summary>
        /// 批量修改座位状态
        /// </summary>
        /// <param name="batchSeatStateViewModel">座位集及目标值视图</param>
        /// <returns>是否修改成功</returns>
        public IActionResult SetBatchSeatState(BatchSeatStateViewModel batchSeatStateViewModel) {


            administrator.SetBatchSeatState(batchSeatStateViewModel.list,batchSeatStateViewModel.operation);

            return View();
        }

        /// <summary>
        /// 修改信誉积分的基准值
        /// </summary>
        /// <param name="glory"></param>
        /// <returns></returns>
        public IActionResult SetAllGlory(int glory) {

            administrator.SetAllGlory(glory);

            return View();
        }


    }
}