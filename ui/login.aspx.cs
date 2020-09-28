using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class Login : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        private static int ErrorTime = 3;
        protected void Page_Load(object sender, EventArgs e)
        {
            btn.ServerClick += Btn_ServerClick;
        }

        private void Btn_ServerClick(object sender, EventArgs e)
        {
            ErrorTime--;
            if (ErrorTime < 0)
            {
                if (task.CheckUserExist(email.Value) == true)
                {
                    task.UpdateUserRoot(email.Value, 0);
                    task.Alert(Page, "你的账号已被限制登录");
                }
                else
                    task.Alert(Page, "非法请求");
            }
            else
            {
                if (task.UserLogin(email.Value, pwd.Value, 1) == true)
                {
                    if (task.CheckRoot(email.Value) == true)
                    {
                        Session["_id"] = task.SetLoginSession(email.Value);
                        if (Session["glog"] == null)
                        {
                            Response.Redirect("index.aspx?_uid=" + Session["_id"].ToString());
                        }
                        else
                        {
                            switch (Session["glog"])
                            {
                                case "0": Response.Redirect("course-learn.aspx?_uid=" + Session["id"] + "&_coid=1001201910101&_clid=1&_g=" + Guid.NewGuid().ToString("N"));break;
                                case "1": Response.Redirect("exam-Online-list.aspx?_uid=" + Session["id"] + "&_coid=1001201910101&_clid=1&_teid=5789202840&_g=" + Guid.NewGuid().ToString("N"));break;
                                default: Response.Redirect("index.aspx?_uid=" + Session["_id"].ToString());break;
                            }
                        }
                    }
                    else
                        task.Alert(Page, "你的账号已被限制登录");
                }
                else
                    task.Alert(Page, "用户名或密码错误");
            }
        }
    }
}