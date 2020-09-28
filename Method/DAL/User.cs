using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class User
    {
        private static Common.MysqlHelp MysqlHelp = new Common.MysqlHelp();

        /// <summary>
        /// 返回用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="fieid"></param>
        /// <returns></returns>
        public string GetUserInfo(Model.User user,string fieid)
        {
            string sql = "select "+fieid+ " from t_stuinfo where _id=@id";
            MySqlParameter[] par = {
                new MySqlParameter("@id",MySqlDbType.Int32,2),
            };
            par[0].Value = user.Id;
            return MysqlHelp.Run_Select(sql.ToString(), par);
        }
    }
}