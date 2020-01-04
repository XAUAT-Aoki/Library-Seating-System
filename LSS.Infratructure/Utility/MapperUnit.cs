using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LSS.Infrastructure.Utility
{
    public class MapperUnit
    {
        /// <summary>
        /// 判断是否是学号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsStudentId(string str) 
        {
            //进行正则匹配
            Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");

           // Regex regex = new Regex("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\\.[a-zA-Z0-9_-]+)+$");
            Match m = RegEmail.Match(str);
            return !m.Success;
        }

    }
}
