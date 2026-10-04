using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.AirCompressorMonitorSystem.Utils;

namespace Zhaoxi.AirCompressorMonitorSystem.DAL
{
    public class UserDAL
    {
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginSystem(string username, string password)
        {
            string sql = "select count(1) from UserInfos where UserName=@userName and UserPwd=@userPwd and UserState=1";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@userName",username),
                new SQLiteParameter("@userPwd",password)
            };
            object oCount = SQLiteHelper.ExecuteScalar(sql, paras);
            if (oCount != null && oCount.ToString() != "")
            {
                return Convert.ToInt32(oCount) > 0;
            }
            return false;
        }
    }
}
