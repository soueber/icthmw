using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Icthmw
{
    public class Global : System.Web.HttpApplication
    {
        private Method.Event task = new Method.Event();
        static int TotalCount, TotayCount, OnlineCount;
        static DateTime LastCleanUp;
        static object _obj = new object();
        static string LogFile = HttpContext.Current.Server.MapPath("~/FailedReqLogFiles/Log/VisitLog.txt");//日志文件     

        public void Init(HttpApplication application)
        {
            application.BeginRequest += (new EventHandler(this.Application_BeginRequest));
            application.EndRequest += (new EventHandler(this.Application_End));
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>(task.ReadFile(LogFile));
                int.TryParse(list[1], out TotalCount);
                int.TryParse(list[2], out TotayCount);
                DateTime.TryParse(list[3], out LastCleanUp);
            }
            catch
            {
                throw;
            }
            OnlineCount = 0;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            lock (_obj)
            {
                if (DateTime.Now.Day != LastCleanUp.Day)
                {
                    LastCleanUp = DateTime.Now;
                    TotayCount = 0;
                }
                TotayCount++;
                TotalCount++;
                OnlineCount++;
                task.InsertIpStat(task.ReturnIpAdress(), task.GetCityName(task.ReturnIpAdress()), task.RuturnIpSrc());
                task.WriteFile(LogFile, TotalCount.ToString() + "," + TotayCount.ToString() + "," + LastCleanUp.ToString());
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            task.UrlAttack(Request.Url.ToString());
            task.SQLAttack(task.ReturnAppSettingInfo("OrderID-int32,CustomerEmail-email,ShippingZipcode-USzip", "safeParameters"), Server.HtmlEncode(Request.ApplicationPath)+ "ui/error/Error.aspx?type=403");
            task.LimitRequest(sender, task.RuturnMaxCountAndTime("HttpRowCount"), task.RuturnMaxCountAndTime("HttpTime"));
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exp = Server.GetLastError().GetBaseException();
            if (exp.GetType().Name.Equals("HttpException"))
            {
                Response.Redirect(Server.HtmlEncode(Request.ApplicationPath) + "ui/error/Error.aspx?type=" + ((HttpException)exp).GetHttpCode()+"&message="+Server.GetLastError().Message);
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            lock (_obj)
            {
                OnlineCount--;
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            task.WriteFile(LogFile, TotalCount.ToString() + "," + TotayCount.ToString() + "," + LastCleanUp.ToString());
        }
    }
}