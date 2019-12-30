using System;
using System.Collections.Generic;
using System.Text;
using LSS.Mapper;
using LSS.Infrastructure.Utility;

namespace LSS.Service
{
    public class AdministratorImplement
    {
        /// <summary>
        /// 登录服务实现
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>返回是否登录成功</returns>
        public bool Login(string username, string password)
        {

            //明文密码加密
            string str = OperateMD5.GetMD5(password);
            AdministratorMapper adminmapper = new AdministratorMapper();

            adminmapper.GetPassword(username);

            return true;
        }
    }
}
