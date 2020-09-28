using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class Login
    {
        private static Common.MysqlHelp MysqlHelp = new Common.MysqlHelp();
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public string UserLogin(Model.Login login)
        {
            string sql = "select _id from t_login where _email=@email and _pwd=@pwd and _root=@root";
            MySqlParameter[] par = {
                new MySqlParameter("@email",MySqlDbType.VarChar,20),
                new MySqlParameter("@pwd",MySqlDbType.VarChar,20),
                new MySqlParameter("@root",MySqlDbType.Int32,2),
            };
            par[0].Value = login.Email;
            par[1].Value = Common.DESEncrypt.Encrypt(login.Pwd);
            par[2].Value = login.Root;         
            return MysqlHelp.Run_Select(sql.ToString(), par);
        }
        public string SetLoginSession(Model.Login login)
        {
            string sql = "select _id from t_login where _email=@email";
            MySqlParameter[] par = {
                new MySqlParameter("@email",MySqlDbType.VarChar,20),
            };
            par[0].Value = login.Email;
            return MysqlHelp.Run_Select(sql.ToString(), par);
        }
        public string GetUserName(Model.Login login)
        {
            string sql = "select _name from t_login where _id=@id";
            MySqlParameter[] par = {
                new MySqlParameter("@id",MySqlDbType.Int32,2),
            };
            par[0].Value = login.Id;
            return MysqlHelp.Run_Select(sql.ToString(), par);
        }
        public string CheckRoot(Model.Login login)
        {
            string sql = "select _root from t_login where _email=@email";
            MySqlParameter[] par = {
                new MySqlParameter("@email",MySqlDbType.VarChar,20),
            };
            par[0].Value = login.Email;
            return MysqlHelp.Run_Select(sql.ToString(), par);
        }
        public int UpdateUserRoot(Model.Login login)
        {
            string sql = "update t_login set _root=@root where _email=@email";
            MySqlParameter[] par = {
                new MySqlParameter("@root",MySqlDbType.Int32,2),
                new MySqlParameter("@email",MySqlDbType.VarChar,20),
            };
            par[0].Value = login.Root;
            par[1].Value = login.Email;
            return MysqlHelp.Run_Sql(sql.ToString(), par);
        }
    }
}