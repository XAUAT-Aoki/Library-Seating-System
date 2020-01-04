using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSS.Controllers
{
    public class CookieController : Controller
    {
         
        /// <summary>
        /// 设置cookie
        /// </summary>
        /// <param name="cookie">要设置的cookie</param>
        /// <returns>设置成功返回true</returns>
        public void setCookie(string key, string value)
        {
            this.Response.Cookies.Append(key, value);
        }
        /// <summary>
        /// 获取cookie
        /// </summary>
        /// <param name="key">cookie的 key</param>
        /// <returns></returns>
        public string getCookie(string key)
        {
            string cookie = "";
            Request.Cookies.TryGetValue(key, out cookie);
            return cookie;
        }
        /// <summary>
        /// 修改cookie
        /// </summary>
        /// <param name="key">键名</param>
        /// <param name="value">键值</param>
        /// <returns></returns>
        public bool modifyCookie(string key, string value)
        {
            try
            {
                HttpContext.Response.Cookies.Append(key, value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
