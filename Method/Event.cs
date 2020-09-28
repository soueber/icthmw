using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Method
{
    public class Event
    {
        private Model.CartIp Modcartip = new Model.CartIp();
        private Model.IpStat Modipstat = new Model.IpStat();
        private BLL.IpStat Bllipstat = new BLL.IpStat();
        private Model.Login Modlogin = new Model.Login();
        private BLL.Login Blllogin = new BLL.Login();
        private Model.User Moduser = new Model.User();
        private BLL.User Blluser = new BLL.User();
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool UserLogin(string email,string pwd,int root)
        {
            Modlogin.Email = email;
            Modlogin.Pwd = pwd;
            Modlogin.Root = root;
            if (Blllogin.UserLogin(Modlogin) != "")
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 检查登录权限
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckRoot(string email)
        {
            Modlogin.Email = email;
            if (Blllogin.CheckRoot(Modlogin) =="1")
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckUserExist(string email)
        {
            Modlogin.Email = email;
            if (Blllogin.CheckRoot(Modlogin) !="")
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 登录session
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string SetLoginSession(string email)
        {
            Modlogin.Email = email;
            return Blllogin.SetLoginSession(Modlogin);
        }

        /// <summary>
        /// 更新用户权限
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool UpdateUserRoot(string email,int root)
        {
            Modlogin.Email = email;
            Modlogin.Root = root;
            if (Blllogin.UpdateUserRoot(Modlogin) > 0)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 返回学生姓名
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserName(int id)
        {
            Modlogin.Id = id;
            return Blllogin.GetUserName(Modlogin);
        }

        /// <summary>
        /// 返回学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fieid">字段名</param>
        /// <returns></returns>
        public string GetUserInfo(int id, string fieid)
        {
            Moduser.Id = id;
            return Blluser.GetUserInfo(Moduser, fieid);
        }

        /// <summary>
        /// 返回学生图像信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fieid">图像字段名</param>
        /// <param name="defaultimg">默认图像信息</param>
        /// <returns></returns>
        public string GetUserImg(int id,string fieid,string defaultimg)
        {
            if (GetUserInfo(id, fieid) != "")
            {
                return GetUserInfo(id, fieid);
            }
            else
                return defaultimg;
        }

        /// <summary>
        /// 插入访客记录
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="city"></param>
        /// <param name="ipsrc"></param>
        /// <returns></returns>
        public bool InsertIpStat(string ip,string city,string ipsrc)
        {
            Modipstat.Ip = ip;
            Modipstat.City = city;
            Modipstat.Ipsrc = ipsrc;
            if (Bllipstat.InsertIpStat(Modipstat) > 0)
            {
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 限制IP访问
        /// </summary>
        /// <param name="checkip"></param>
        public void RestrictAccess(bool checkip)
        {
            if (checkip==true)
            {
               if(ReturnIpAdress().StartsWith(ReturnAppSettingInfo("", "IP_ADDRESS_BLACK")))
                {
                    RestrictAllAccess();
                }
            }
            else
            {
                RestrictAllAccess();
            }
        }

        /// <summary>
        /// 限制所有访问
        /// </summary>
        public void RestrictAllAccess()
        {
            if (RuturnIpSrc() != "")
            {
                HttpContext.Current.Response.ContentType = "text/html;charset=utf-8";
                HttpContext.Current.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
                HttpContext.Current.Response.Write("<script>alert(\"你的IP地址是：" + ReturnIpAdress() + " 不在允许范围内！\");history.back();</script>");
            }
            else
            {
                HttpContext.Current.Response.Redirect(HttpContext.Current.Server.HtmlEncode(HttpContext.Current.Request.ApplicationPath) + "ui/error/Error.aspx?type=403");
            }
        }







        public static string Substr(string str, int num)
        {
            string strs;
            if (str.Length > num)
            {
                strs = str.Substring(0, num) + "...";
            }
            else
            {
                strs = str;

            }
            return strs;
        }

        public static string Substr1(string str, int num)
        {
            string strs;
            if (str.Length > num)
            {
                strs = str.Substring(0, num);
            }
            else
            {
                strs = str;
            }
            return strs;
        }

        /// <summary>
        /// 返回弹窗消息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="page"></param>
        public void Alert(System.Web.UI.Page page, string msg)
        {

            page.ClientScript.RegisterStartupScript(page.GetType(), "msg", "<script>alert('" + msg + "');</script>");
        }

        /// <summary>
        /// 自定义脚本信息
        /// </summary>
        /// <param name="page"></param>
        /// <param name="msg"></param>
        public void AlertLocation(System.Web.UI.Page page, string msg)
        {

            page.ClientScript.RegisterStartupScript(page.GetType(), "msg", "<script>" + msg + "</script>");
        }

     


        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="num">位数</param>
        /// <returns></returns>
        public string CreateCode(int num)
        {
            var result = new StringBuilder();
            for (var i = 0; i < num; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }

        /// <summary>
        /// 发送邮件服务
        /// </summary>
        /// <param name="useremail">邮件接收方</param>
        /// <param name="title">邮件主题</param>
        /// <param name="body">邮件正文内容</param>
        /// <param name="alternate">是否添加附件发送</param>
        /// <param name="fileadress">附件地址</param>
        public void SendEmailCode(string useremail, string title, string body, bool alternate, string fileadress)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(ConfigurationManager.AppSettings["MailAddress"])
            };
            mailMessage.To.Add(new MailAddress(useremail));
            mailMessage.Subject = title;
            mailMessage.Body = body;
            mailMessage.Priority = MailPriority.Normal;
            mailMessage.IsBodyHtml = false;
            if (alternate == true)
            {
                mailMessage.AlternateViews.Add(new AlternateView(fileadress));
            }
            SmtpClient client = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["MailHost"],
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["MailAddress"], ConfigurationManager.AppSettings["Credentials"])
            };
            client.Send(mailMessage);
        }
        /// <summary>
        /// 有效期
        /// </summary>
        /// <param name="time">时间，单位毫秒</param>
        /// <param name="mission">事件有效期</param>
        /// <returns></returns>
        public string EffectiveTime(int time, string mission)
        {
            Timer timer = new Timer
            {
                Interval = time,
                Enabled = true
            };
            return mission;
        }
        /// <summary>
        /// 检查用户密码
        /// </summary>
        /// <param name="Path">密码本路径</param>
        /// <param name="psd">用户密码</param>
        /// <returns>是否通过</returns>
        public bool CheckOutPassword(string Path, string psd)
        {
            List<string> FilterPassword = new List<string>();
            System.IO.StreamReader ReadFile = new System.IO.StreamReader(Path, Encoding.GetEncoding(936), true);
            string line;
            while ((line = ReadFile.ReadLine()) != null)
            {
                FilterPassword.Add(line);
            }
            ReadFile.Close();
            if (FilterPassword.Contains(psd))
            {
                return false;
            }
            else
            {
                using (var WriterFile = new StreamWriter(Path, true))
                {
                    WriterFile.WriteLine(psd);
                    WriterFile.Close();
                }
                return true;
            }
        }

       

        

        /// <summary>
        /// 用户退出登录
        /// </summary>
        /// <param name="responde">是否重定向页面</param>
        /// <param name="url">返回页面地址</param>
        public void UserLogout(bool responde, string url)
        {
            if (responde == true && url != "")
            {
                HttpContext.Current.Response.Redirect(url);
            }
            HttpContext.Current.Session.Contents.RemoveAll();
        }

        /// <summary>
        /// 保存本地cookie信息
        /// </summary>
        /// <param name="CookieName">名称</param>
        /// <param name="CookieValue">值</param>
        /// <param name="CookieExpires">有效期</param>
        public void LoginCookie(string CookieName, string CookieValue, int CookieExpires)
        {
            if (HttpContext.Current.Request.Cookies[CookieName] != null)
            {
                HttpContext.Current.Request.Cookies[CookieName].Expires = DateTime.Now.AddSeconds(-1);
            }
            else
            {
                HttpCookie UsernameCookie = new HttpCookie(CookieName)
                {
                    Expires = DateTime.Now.AddDays(CookieExpires),
                    Value = CookieValue
                };
                HttpContext.Current.Response.Cookies.Add(UsernameCookie);
            }
        }

     
        /// <summary>
        ///禁止页面二次提交事件
        /// </summary>
        public void PreventSencondRefresh()
        {
            HttpContext.Current.Response.Write("<script>document.location=document.location</script>");
        }
        /// <summary>
        /// 返回特定日期在时间段内的周数
        /// </summary>
        /// <param name="start">时间段开始</param>
        /// <param name="end">结束时间段</param>
        /// <param name="today">特定日期</param>
        /// <returns>第几周</returns>
        public int GetWeekOfDay(DateTime start, DateTime end, DateTime today)
        {
            var weekCount = Math.Ceiling(Convert.ToDouble((end - start).Days / 7));
            var weekDict = new Dictionary<DateTime, int>();
            for (var i = 1; i < weekCount; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    weekDict.Add(start.AddDays(i * 7 + j), i + 1);
                }
            }
            return weekDict.ContainsKey(today) ? weekDict[today] : 1;
        }
        /// <summary>
        /// 返回特定日期是否在时间段内
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public bool GetTimeSpan(DateTime start, DateTime end, DateTime today)
        {
            if (today > start && today < end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 返回当前日期的星期序号
        /// </summary>
        /// <returns>int</returns>
        public int GetWeekNumber()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday: return 1;
                case DayOfWeek.Tuesday: return 2;
                case DayOfWeek.Wednesday: return 3;
                case DayOfWeek.Thursday: return 4;
                case DayOfWeek.Friday: return 5;
                case DayOfWeek.Saturday: return 6;
                case DayOfWeek.Sunday: return 7;
                default: return 0;
            }
        }
        /// <summary>
        /// 返回特定日期中文星期名称
        /// </summary>
        /// <param name="today">特定日期</param>
        /// <returns></returns>
        public string GetWeekCnName(DateTime today)
        {
            return today.ToString("dddd", new System.Globalization.CultureInfo("zh-cn"));
        }
        /// <summary>
        /// 返回两个时间差
        /// </summary>
        /// <param name="dateTimeStrat">开始时间</param>
        /// <param name="dateTimeEnd">结束时间</param>
        /// <returns>分钟</returns>
        public int ReturnTimeSpan(DateTime dateTimeStrat, DateTime dateTimeEnd)
        {
            TimeSpan timeSpan = dateTimeEnd.Subtract(dateTimeStrat);
            return timeSpan.Hours * 60 + timeSpan.Minutes;
        }
        
        /// <summary>
        /// 检查页面元素是否为空
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public bool CheckIsNull(Page page)
        {
            bool check = true;
            foreach (Control control in page.Controls)
            {
                foreach (Control find in control.Controls)
                {
                    if (find is HtmlForm)
                    {
                        foreach (Control found in find.Controls)
                        {
                            foreach (Control finding in found.Controls)
                            {
                                switch (finding.GetType().Name)
                                {
                                    case "TextBox":
                                        {
                                            TextBox textBox = finding as TextBox;
                                            if (textBox.Text.Trim() == "")
                                            {
                                                check = false;
                                                return false;
                                            }
                                            break;
                                        }
                                    case "Label":
                                        {
                                            Label label = finding as Label;
                                            if (label.Text == "")
                                            {
                                                check = false;
                                                return false;
                                            }
                                            break;
                                        }
                                    case "DropDownList":
                                        {
                                            DropDownList dropDownList = finding as DropDownList;
                                            if (dropDownList.SelectedValue == "")
                                            {
                                                check = false;
                                                return false;
                                            }
                                            break;
                                        }
                                }
                            }
                        }
                    }
                }
            }
            return check;
        }

       

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="LogFile">文件所在服务器路径</param>
        /// <returns></returns>
        public List<string> ReadFile(string LogFile)
        {
            List<string> list = new List<string>();
            if (File.Exists(LogFile))
            {
                string[] arry1 = File.ReadLines(LogFile).Last().Split(',');
                for (int i = 0; i < arry1.Length; i++)
                {
                    list.Add(arry1[i]);
                }
            }
            else
            {
                new FileStream(LogFile, FileMode.Create);
                ReadFile(LogFile);
            }
            return list;
        }

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="LogFile">文件所在服务器路径</param>
        /// <param name="data">写入数据；多个数据使用半角符号分隔</param>
        public void WriteFile(string LogFile, string data)
        {
            if (File.Exists(LogFile))
            {
                string[] Lines = File.ReadAllLines(LogFile);
                StreamWriter writer = new StreamWriter(new FileStream(LogFile, FileMode.Append, FileAccess.Write));
                writer.WriteLine(Lines.Length + 1 + "," + data, Encoding.Default, true);
                writer.Close();
            }
            else
            {
                new FileStream(LogFile, FileMode.Create);
                WriteFile(LogFile, data);
            }
        }

        /// <summary>
        /// 返回当前配置单个IP单位时间内最大访问量
        /// 未配置或配置错误默认当前单次最多量为10
        /// </summary>
        /// <param name="Setting">website配置名称</param>
        /// <returns></returns>
        public int RuturnMaxCountAndTime(string Setting)
        {
            int rowCount = 10;
            try
            {
                rowCount = Convert.ToInt32(ConfigurationManager.AppSettings[Setting]);
            }
            catch
            {
                throw;
            }
            return rowCount;
        }

        /// <summary>
        /// 限制IP单位时间内访问次数
        /// </summary>
        /// <param name="sender">事件参数，默认为sender</param>
        /// <param name="rowCount">访问次数</param>
        /// <param name="httpTime">访问时间</param>
        public void LimitRequest(object sender, int rowCount, int httpTime)
        {
            HttpApplication Application = (HttpApplication)sender;
            HttpContext ctx = Application.Context;
            string isIp = ctx.Request.UserHostAddress;
            if (ctx.Application["time"] == null)
            {
                ctx.Application["time"] = DateTime.Now;
            }
            else
            {
                DateTime isTime = (DateTime)ctx.Application["time"];
                int timeTract = Convert.ToInt32(DateTime.Now.Subtract(isTime).Minutes.ToString());
                if (timeTract > (httpTime - 1))
                {
                    ctx.Application["time"] = null;
                    ctx.Application["myip"] = null;
                }
            }
            if (ctx.Application["myip"] != null && ctx.Application["myip"] is Model.CartIp)
            {
                Model.CartIp cartIp = (Model.CartIp)ctx.Application["myip"];
                cartIp.Insert(isIp);
                ctx.Application["myip"] = cartIp;
                if (cartIp.GetCount(isIp) > rowCount)
                {
                    ctx.Response.Clear();
                    ctx.Response.Close();
                }
            }
            else
            {
                Modcartip.Insert(isIp);
                HttpContext.Current.Application["myip"] = Modcartip;
            }
        }

        /// <summary>
        /// isEmail
        /// </summary>
        /// <param name="emailString"></param>
        /// <returns></returns>
        public static bool IsEmail(string emailString)
        {
            return Regex.IsMatch(emailString, "['\\w_-]+(\\. ['\\w_-]+)*@['\\w_-]+(\\.['\\w_-]+)*\\.[a-zA-Z]{2,4}");
        }

        /// <summary>
        /// isInt
        /// </summary>
        /// <param name="intString"></param>
        /// <returns></returns>
        public static bool IsInt(string intString)
        {
            return Regex.IsMatch(intString, "^(\\d{5}-\\d{4})| (\\d{5})$");
        }

        /// <summary>
        /// isUSZip
        /// </summary>
        /// <param name="zipString"></param>
        /// <returns></returns>
        public static bool IsUSZip(string zipString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(zipString, "^-[0-9]+$|^[0-9]$");
        }

        /// <summary>
        /// 获取website配置信息
        /// </summary>
        /// <param name="SettingInfo">未配置提供默认配置信息</param>
        /// <param name="SettingKey">配置名称</param>
        /// <returns></returns>
        public string ReturnAppSettingInfo(string SettingInfo, string SettingKey)
        {
            string Info = string.Empty;
            try
            {
                Info = ConfigurationManager.AppSettings[SettingKey].ToString();
            }
            catch
            {
                Info = SettingInfo;
            }
            return Info;
        }

        /// <summary>
        /// 防止SQL注入攻击
        /// </summary>
        /// <param name="Parameters">配置字符串</param>
        /// <param name="errorpath">返回错误路径</param>
        public void SQLAttack(string Parameters, string errorpath)
        {
            String[] safeParameters = Parameters.Split(',');
            for (int i = 0; i < safeParameters.Length; i++)
            {
                IsValidParameter(safeParameters[i].Split('-')[0], safeParameters[i].Split('-')[1], errorpath);
            }
        }

        /// <summary>
        /// 攻击注入方式
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterType"></param>
        /// <param name="errorpath"></param>
        public void IsValidParameter(string parameterName, string parameterType, string errorpath)
        {
            string parameterValue = HttpContext.Current.Request.QueryString[parameterName];
            if (parameterValue == null) return;
            if (parameterType.Equals("int32"))
            {
                if (!IsInt(parameterValue))
                    HttpContext.Current.Response.Redirect(errorpath);
            }
            else if (parameterType.Equals("USzip"))
            {
                if (!IsUSZip(parameterValue))
                    HttpContext.Current.Response.Redirect(errorpath);
            }
            else if (parameterType.Equals("email"))
            {
                if (!IsEmail(parameterValue))
                    HttpContext.Current.Response.Redirect(errorpath);
            }
        }

        /// <summary>
        /// URL注入攻击
        /// </summary>
        /// <param name="url"></param>
        public void UrlAttack(string url)
        {
            string filterUrl = FilterUrl(url);
            if (HttpContext.Current.Request.Form.Count > 0)
            {
                if (!url.Equals(filterUrl))
                {
                    HttpContext.Current.Response.Redirect(filterUrl);
                }
            }
            if (HttpContext.Current.Request.QueryString.Count > 0)
            {
                if (!url.Equals(filterUrl))
                {
                    HttpContext.Current.Response.Redirect(filterUrl);
                }
            }
        }

        /// <summary>
        /// 过滤特殊字符
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string FilterUrl(string url)
        {
            string replaceStr = url;
            if (!string.IsNullOrEmpty(url))
            {
                replaceStr = replaceStr.ToLower();
                replaceStr = replaceStr.Replace("<", "");
                replaceStr = replaceStr.Replace(">", "");
                replaceStr = replaceStr.Replace("|", "");
                replaceStr = replaceStr.Replace("\"", "");
                replaceStr = replaceStr.Replace("'", "");
                replaceStr = replaceStr.Replace("%", "");
                replaceStr = replaceStr.Replace(";", "");
                replaceStr = replaceStr.Replace("(", "");
                replaceStr = replaceStr.Replace(")", "");
                replaceStr = replaceStr.Replace("+", "");
                replaceStr = replaceStr.Replace("script", "");
                replaceStr = replaceStr.Replace("alert", "");
                replaceStr = replaceStr.Replace("select", "");
                replaceStr = replaceStr.Replace("update", "");
                replaceStr = replaceStr.Replace("insert", "");
                replaceStr = replaceStr.Replace("like", "");
                replaceStr = replaceStr.Replace("applet", "");
                replaceStr = replaceStr.Replace("body", "");
                replaceStr = replaceStr.Replace("embed", "");
                replaceStr = replaceStr.Replace("frame", "");
                replaceStr = replaceStr.Replace("html", "");
                replaceStr = replaceStr.Replace("iframe", "");
                replaceStr = replaceStr.Replace("img", "");
                replaceStr = replaceStr.Replace("style", "");
                replaceStr = replaceStr.Replace("layer", "");
                replaceStr = replaceStr.Replace("link", "");
                replaceStr = replaceStr.Replace("ilayer", "");
                replaceStr = replaceStr.Replace("meta", "");
                replaceStr = replaceStr.Replace("object", "");
            }
            return replaceStr;
        }

        /// <summary>
        /// 过滤html,js,css代码
        /// </summary>
        /// <param name="html">参数传入</param>
        /// <returns></returns>
        public static string CheckStr(string html)
        {
            Regex regex1 = new Regex(@"<script[\s\S]+</script. *>", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@" href *= *[\s\S]*script. *:", RegexOptions.IgnoreCase);
            Regex regex3 = new Regex(@" no[\s\S]*=", RegexOptions.IgnoreCase);
            Regex regex4 = new Regex(@"<iframe[\s\S]+</iframe. *>", RegexOptions.IgnoreCase);
            Regex regex5 = new Regex(@"<frameset[\s\S]+</frameset *>", RegexOptions.IgnoreCase);
            Regex regex6 = new Regex(@"\<img[^\>]+\>", RegexOptions.IgnoreCase);
            Regex regex7 = new Regex(@"</p>", RegexOptions.IgnoreCase);
            Regex regex8 = new Regex(@"<p>", RegexOptions.IgnoreCase);
            Regex regex9 = new Regex(@"<[^>]*>", RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记
            html = regex2.Replace(html, ""); //过滤href=java script. (<A>) 属性
            html = regex3.Replace(html, " _disibledevent="); //过滤其它控件的on...事件
            html = regex4.Replace(html, ""); //过滤iframe
            html = regex5.Replace(html, ""); //过滤frameset
            html = regex6.Replace(html, ""); //过滤frameset
            html = regex7.Replace(html, ""); //过滤frameset
            html = regex8.Replace(html, ""); //过滤frameset
            html = regex9.Replace(html, "");
            html = html.Replace(" ", "");
            html = html.Replace("</strong>", "");
            html = html.Replace("<strong>", "");
            html = html.Replace("'", "＇");
            return html;
        }
        /// <summary>
        /// 传入用户输入判断是不是非法关键字
        /// </summary>
        /// <param name="sql_str">传入用户输入字符判断</param>
        /// <returns></returns>
        public static bool Sql_immit(String sql_str)
        {//用#分割关键字
            string model_str = "'#and#exec#insert#select#delete#update#count#*#%#chr#mid#master#truncate#char#declare#;#or#-#+#,";

            string[] model_split_str = model_str.Split('#');

            for (int i = 0; i < model_split_str.Length; i++)
            {
                if (sql_str.IndexOf(model_split_str[i]) >= 0)
                {
                    //>=0说明有关键字，否则说明没有关键字
                    return true;

                }
            }
            return false;
        }

        /// <summary>
        /// 返回访客来源
        /// </summary>
        /// <returns></returns>
        public string RuturnIpSrc()
        {
            if (HttpContext.Current.Request.UrlReferrer != null)
            {
                return HttpContext.Current.Request.UrlReferrer.ToString();
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 返回IP物理地址
        /// </summary>
        /// <param name="strIP"></param>
        /// <returns></returns>
        public string GetCityName(string strIP)
        {
            try
            {
                return ReturnIpInfo(strIP)["addr"].ToString();
            }
            catch
            {
                return "[未知]";
            }

        }
        /// <summary>
        /// 返回IP信息
        /// </summary>
        /// <param name="strIP"></param>
        /// <returns>"ip":Ip,"pro":省份,"proCode": 邮编,"city": 城市,"cityCode": 城市邮编,"region": "","regionCode": "0","addr": IP归属,"regionNames": "","err": ""</returns>
        public JObject ReturnIpInfo(string strIP)
        {
            try
            {
                string url = "http://whois.pconline.com.cn/ipJson.jsp?ip=" + strIP + "&json=true";
                string pagecode = GetPageCode(url, Encoding.GetEncoding("gb2312")).TrimStart().TrimEnd();
                JObject result = (JObject)JsonConvert.DeserializeObject(pagecode);
                return result;
            }
            catch
            {
                return new JObject();
            }
        }

        /// <summary>
        /// 获取网页源文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public string GetPageCode(string url, Encoding Encode)
        {
            string strHtml = string.Empty;
            HttpWebResponse wresp;
            try
            { 
                WebRequest wreq = WebRequest.Create(url);
                wresp = (HttpWebResponse)wreq.GetResponse();
            }
            catch (WebException ex)
            {
                wresp = (HttpWebResponse)ex.Response;
            } 
            StreamReader objReader = new StreamReader(wresp.GetResponseStream(), Encode);
            return strHtml = objReader.ReadToEnd();
        }


        /// <summary>
        /// 检验IP地址合法性
        /// </summary>
        /// <param name="str1"></param>
        /// <returns></returns>
        public static bool IsIPAddress(string str1)
        {
            if (str1 == null || str1 == string.Empty || str1.Length < 7 || str1.Length > 15) return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";
            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str1);
        }

        /// <summary>
        /// 返回访客IP地址
        /// </summary>
        /// <returns></returns>
        public string ReturnIpAdress()
        {

            string result = String.Empty;
            result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (result != null && result != String.Empty)
            {
                if (result.IndexOf(".") == -1) 
                    result = null;
                else
                {
                    if (result.IndexOf(",") != -1)
                    {
                        result = result.Replace(" ", "").Replace("", "");

                        string[] temparyip = result.Split(",;".ToCharArray());
                        for (int i = 0; i < temparyip.Length; i++)
                        {
                            if (IsIPAddress(temparyip[i])
                                && temparyip[i].Substring(0, 3) != "10."
                                && temparyip[i].Substring(0, 7) != "192.168"
                                && temparyip[i].Substring(0, 7) != "172.16.")
                            {
                                return temparyip[i];
                            }
                        }
                    }
                    else if (IsIPAddress(result)) 
                        return result;
                    else
                        result = null; 
                }
            }
            string IpAddress = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            if (null == result || result == String.Empty)
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            if (result == null || result == String.Empty)
                result = HttpContext.Current.Request.UserHostAddress;
            return result;
        }

        /// <summary>
        /// 返回异常登录用户IP列表
        /// </summary>
        /// <returns></returns>
        public List<string> ReturnAbnormalIpList()
        {
            DataSet dataSet =new  DataSet();
            List<string> ip = new List<string>();
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                ip.Add("");
            }
            else
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ip.Add(dataSet.Tables[0].Rows[i][0].ToString());
                }
            }
            return ip;
        }

        /// <summary>
        /// 限制异常IP访问
        /// </summary>
        /// <param name="redirct">是否重定向页面</param>
        /// <param name="url">路径</param>
        public void LimitIpLogin(bool redirct, string url)
        {
            if (redirct == true)
            {
                if (ReturnAbnormalIpList().Contains(ReturnIpAdress()))
                {
                    HttpContext.Current.Response.Redirect(url);
                }
            }
            else
            {
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.Close();
            }
        }

        /// <summary>
        /// 页面是否首页从加载
        /// </summary>
        /// <param name="indexurl"></param>
        /// <returns></returns>
        public bool IsIndexRequst(string indexurl)
        {
            if (RuturnIpSrc() == HttpContext.Current.Server.MapPath(indexurl))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 返回服务器错误类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string HTTPServerErrorType(string type)
        {
            switch (type)
            {
                case "100":return "Continue";
                case "101":return "Switching Protocols";
                case "200":return "OK";
                case "201":return "Created";
                case "202":return "Accepted";
                case "203":return "Non-Authoritative Information(for DNS)";
                case "204":return "No Content";
                case "205":return "Reset Content";
                case "206":return "Partial Content";
                case "300":return "Multiple Choices";
                case "301":return "Moved Permanently";
                case "302":return "Moved Temporarily";
                case "303":return "See Other";
                case "304":return "Not Modified";
                case "305":return "Use Proxy";
                case "307":return "Redirect Keep Verb";
                case "401":return "Unauthorized";
                case "402":return "Payment Required";
                case "403":return "Forbidden";
                case "404":return "Not Found";
                case "405":return "Bad Request";
                case "406":return "Not Acceptable";
                case "407":return "Proxy Authentication Required";
                case "408":return "Request Timed-Out";
                case "409":return "Conflict";
                case "410":return "Gone";
                case "411":return "Length Required";
                case "412":return "Precondition Failed";
                case "413":return "Request Entity Too Large";
                case "414":return "Request, URI Too Large";
                case "415":return "Unsupported Media Type";
                case "500":return "Internal Server Error";
                case "501":return "Not Implemented";
                case "502":return "Bad Gateway";
                case "503":return "Server Unavailable";
                case "504":return "Gateway Timed - Out";
                case "505":return "HTTP Version not supported";
                default:return "";
            }
        }
    }
}