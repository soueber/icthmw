using MySql.Data.MySqlClient;


namespace DAL
{
    public class IpStat
    {
        private static Common.MysqlHelp MysqlHelp = new Common.MysqlHelp();
        /// <summary>
        /// 插入访客记录
        /// </summary>
        /// <param name="ipStat"></param>
        /// <returns></returns>
        public int InsertIpStat(Model.IpStat ipStat)
        {
            string sql = "insert into t_ipsta (_ip,_city,_ipsrc)values(@ip,@city,@ipsrc)";
            MySqlParameter[] par = {
                new MySqlParameter("@ip",MySqlDbType.VarChar,20),
                new MySqlParameter("@city",MySqlDbType.VarChar,20),
                new MySqlParameter("@ipsrc",MySqlDbType.VarChar,50),
            };
            par[0].Value = ipStat.Ip;
            par[1].Value = ipStat.City;
            par[2].Value = ipStat.Ipsrc;
            return MysqlHelp.Run_Sql(sql.ToString(), par);
        }
    }
}