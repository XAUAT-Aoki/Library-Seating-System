using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LSS.UI.ViewModels;
using LSS.Service;
using LSS.Data;
using LSS.Infrastructure.Utility;
using LSS.ViewModels;
using LSS.Controllers;

namespace LSS.UI.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult ReferSeatByIdView()
        {
            return View();
        }

        AdministratorImplement administrator = new AdministratorImplement();

        CookieController cookie = new CookieController();


        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="administrator">管理员对象</param>
        /// <returns>返回成功与否的视图页面</returns>
        [HttpPost]
        public IActionResult Login(AdministratorViewModel admin)
        {          
            bool isValid=administrator.Login(admin.username,admin.password);
            if(isValid)
            {
                cookie.setCookie("Ano", admin.username);
                return RedirectToAction("Index", "Administrator");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }          
        }
        [HttpPost]
        public IActionResult ChangePassword(PasswordViewModel passwordViewModel)
        {
            //从 Cookie 中获取当前登录用户用户名
            string Ano=cookie.getCookie("Ano");
            var flag=administrator.ChangePassword(passwordViewModel.oldpassword,passwordViewModel.newpassword,Ano);
            if(flag)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return RedirectToAction("ChangePasswordView", "Administrator");
            }
            
        }

        /// <summary>
        /// 根据座位号查询特定座位
        /// </summary>
        /// <param name="seatid">座位号</param>
        /// <returns></returns>
        public IActionResult ReferSeatById(string seatid)
        {

            Seat seat = administrator.ReferSeatById(seatid);
            if(seat!=null)
            {
                return View();
            }
            else
            {
                return View();
            }

            
        }


        /// <summary>
        /// 根据图书馆和图书馆号查询座位集
        /// </summary>
        /// <param name="referSeatViewModel">图书馆及楼层视图</param>
        /// <returns>查询出的座位页面</returns>
        public IActionResult ReferSeatByFloor(ReferSeatViewModel referSeatViewModel)
        {

            List<Seat> list = administrator.ReferSeatByFloor(referSeatViewModel.libraryname, referSeatViewModel.floor);


            return View();
        }

        /// <summary>
        /// 批量修改座位状态
        /// </summary>
        /// <param name="batchSeatStateViewModel">座位集及目标值视图</param>
        /// <returns>是否修改成功</returns>
        public IActionResult SetBatchSeatState(BatchSeatStateViewModel batchSeatStateViewModel)
        {


            administrator.SetBatchSeatState(batchSeatStateViewModel.list, batchSeatStateViewModel.operation);

            return View();
        }

        /// <summary>
        /// 修改信誉积分的基准值
        /// </summary>
        /// <param name="glory"></param>
        /// <returns></returns>
        public IActionResult SetAllGlory(int glory)
        {

            administrator.SetAllGlory(glory);

            return View();
        }


        public IActionResult GetOrderById()
        {
            return View();
        }
        /// <summary>
        /// 根据订单id查询订单
        /// </summary>
        /// <param name="orderid">订单id</param>
        /// <returns>返回查询到的订单</returns>
        [HttpPost]
        public IActionResult GetOrderById(string orderid)
        {
            Order order = administrator.GetOrderById(orderid);
            GetOrderByIdViewModel orderVM = new GetOrderByIdViewModel();
            orderVM.OrderId = order.Oid;
            orderVM.startTime = order.Ostime;
            orderVM.endTime = order.Oetime;
            orderVM.orderState = order.Ostate;
            StudentImplement stu = new StudentImplement();
            Student student = stu.StudentInformation(order.Sid);
            orderVM.sudentName = student.Sname;
            orderVM.studentId = student.Sid;
            if (orderVM != null)
            {
                return Json(orderVM);
            }
            else
            {
                return Json("未查找到订单，请重新输入订单号！");
            }
        }


        /// <summary>
        /// 修改违规订单，学生积分恢复加1
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <returns>修改成功页面</returns>
        [HttpPost]
        public IActionResult AddGlory(string studentid)
        {

            administrator.AddGlory(studentid);
            return View();
        }
        #region 添加图书馆，检查图书馆名是否重复
        /// <summary>
        /// 检查图书馆名是否重复
        /// </summary>
        /// <param name="libraryname"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult IsExist(string libraryname)
        {
            bool flag = administrator.IsExist(libraryname);
            return Json(flag);
        }


        /// <summary>
        /// 添加图书馆
        /// </summary>
        /// <returns></returns>
        public IActionResult AddLibrary()
        {
            return View();
        }
       
        /// <summary>
        /// 添加图书馆
        /// </summary>
        /// <param name="administratorViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddLibrary(LibraryViewModel libraryViewModel)
        {

            Library library = new Library();
            library.Lname = libraryViewModel.libraryname;
            library.Lerror = libraryViewModel.Error;
            library.Llatitute = libraryViewModel.latitude;
            library.Llongitude = libraryViewModel.longititude;
            library.Lsfloor = libraryViewModel.StartFloor;
            library.Lefloor = libraryViewModel.EndFloor;
            if (administrator.AddLibrary(library))
            {
                ViewBag.message = "添加成功！";

            }
            else
            {
                ViewBag.message = "添加失败！";
            }
            return View();
            //将ViewModel中的对于属性都赋值给library

        }
        #endregion

        /// <summary>
        /// 获取所有图书馆名
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllLibraryName()
        {
            
            //return (libraryNameList);
            return View();
        }


        /// <summary>
        /// 查询图书馆的起始楼层和终止楼层
        /// </summary>
        /// <param name="libraryname">图书馆名称</param>
        /// <returns>返回修改成功页面</returns>
        public IActionResult GetFloor(string libraryname)
        {
            List<int> list = administrator.GetFloor(libraryname);
            return View();
        }
        /// <summary>
        /// 删除图书馆   二期工程
        /// </summary>
        /// <param name="libraryName"></param>
        /// <returns></returns>
        #region
        [HttpPost]
        public IActionResult DeleteLibrary(string libraryName)
        {
            return View();
        }
        #endregion

        #region 添加楼层
        [HttpPost]
        public IActionResult AddFloor(string libraryname,int startfloor,int endfloor)
        {
            if(administrator.AddFloor(libraryname, startfloor, endfloor))
            {
                return Json("修改成功");
            }
            else
            {
                return Json("修改失败");
            }
            //return View();
        }
        /// <summary>
        /// 添加图书馆的楼层
        /// </summary>
        /// <param name="addFloorViewModel">楼层视图</param>
        /// <returns>添加成功页面</returns>
        public IActionResult AddFloor()
        {
            LibraryImplement library = new LibraryImplement();
            List<LibraryToShow> libraryList = library.GetAllLibraryToShows();
            return View(libraryList);
        }

        #endregion

    }
}