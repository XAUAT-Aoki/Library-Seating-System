using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LSS.Infrastructure.Utility
{
    public class OperateMD5
    {
        /// <summary>
        /// 字符串加密MD5算法
        /// </summary>
        /// <param name="user">字符串</param>
        /// <returns>加密后密文字符串</returns>
        public static string GetMD5(string user) {
            MD5 md5 = MD5.Create();
            byte[] originStr = Encoding.UTF8.GetBytes(user);
            byte[] hashStr = md5.ComputeHash(originStr);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashStr)
            {
                sb.Append(b.ToString("x4"));//x4代表64位
            }
            return sb.ToString();
        }
    }
}
