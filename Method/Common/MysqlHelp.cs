using System.Data;
using System;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Common
{
    public class MysqlHelp
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WebConnectionString"].ToString();
        private static MySqlConnection con = new MySqlConnection(conStr);
        private static void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (MySqlException err)
                {
                    throw new Exception(err.Message);
                }

            }
        }
        private static void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    con.Close();
                    con.Dispose();
                }
                catch (MySqlException err)
                {
                    throw new Exception(err.Message);
                }
            }
        }

        public bool Run_InsertAndDelectAndUpdate(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public MySqlDataReader Run_ReturnDataReader(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                OpenConnection();
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public string Run_ReturnSelectResult(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                OpenConnection();
                if (cmd.ExecuteScalar() != null)
                {
                    return cmd.ExecuteScalar().ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        #region SQL语句操作
        /// 执行SQL语句
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Runsql(string sql)
        {
            int i = -1;
            MySqlCommand com = new MySqlCommand(sql, con);
            con.Open();
            i = com.ExecuteNonQuery();
            con.Close();
            return i;
        }
        /// 执行带参数SQL语句
        /// <param name="sql"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public int Run_Sql(string sql, IDataParameter[] parms)
        {
            MySqlCommand com = new MySqlCommand(sql, con);
            foreach (MySqlParameter par in parms)
            {
                com.Parameters.Add(par);
            }
            OpenConnection();
            int i = com.ExecuteNonQuery();
            CloseConnection();
            return i;
        }
        public string Run_Select(string sql, IDataParameter[] parms)
        {
            string result=string.Empty;
            MySqlCommand com = new MySqlCommand(sql, con);
            foreach (MySqlParameter par in parms)
            {
                com.Parameters.Add(par);
            }
            OpenConnection();
            if (com.ExecuteScalar() != null)
            {
                result = com.ExecuteScalar().ToString();
            }
            CloseConnection();
            return result;
        }

        /// 执行SQL语句获得DATATABLE
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDatabysql(string sql)
        {
            DataSet ds = new DataSet();
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }

        /// 执行带参数SQL语句获得DATATABLE
        /// <param name="sql"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public DataTable GetDatabysql(string sql, IDataParameter[] parms)
        {
            DataSet ds = new DataSet();
            con.Open();
            MySqlCommand com = new MySqlCommand(sql, con);
            foreach (MySqlParameter par in parms)
            {
                com.Parameters.Add(par);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        #endregion

        #region 操作存储过程
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="prcname"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public int RunPrc(string prcname, IDataParameter[] parms)
        {
            int i = -1;
            MySqlCommand com = new MySqlCommand(prcname, con)
            {
                CommandType = CommandType.StoredProcedure
            };
            foreach (MySqlParameter par in parms)
            {
                com.Parameters.Add(par);
            }
            OpenConnection();
            i = com.ExecuteNonQuery();
            CloseConnection();
            return i;
        }

        /// <summary>
        /// 执行存储过程获得数据集
        /// </summary>
        /// <param name="prcname"></param>
        /// <returns></returns>
        public DataTable GetDataByPrc(string prcname)
        {
            DataSet ds = new DataSet();
            MySqlCommand com = new MySqlCommand(prcname, con)
            {
                CommandType = CommandType.StoredProcedure
            };
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        /// <summary>
        /// 执行存储过程获得数据集(带参数)
        /// </summary>
        /// <param name="prcname"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public DataTable GetDataByPrc(string prcname, IDataParameter[] parms)
        {
            DataSet ds = new DataSet();
            con.Open();
            MySqlCommand com = new MySqlCommand(prcname, con)
            {
                CommandType = CommandType.StoredProcedure
            };
            foreach (MySqlParameter par in parms)
            {
                com.Parameters.Add(par);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        #endregion
    }
}