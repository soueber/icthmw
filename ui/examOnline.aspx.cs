using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class examOnline : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Session["_id"] == null)
            {
                task.AlertLocation(Page, "alert('你没有登陆无法记录学习数据，请先登录！');location.href='login.aspx'");
                Session["glog"] = "1";
            }
            else
            {
                Response.Redirect("exam-Online-list.aspx?_uid=" + Session["id"] + "&_coid=1001201910101&_clid=1&_teid=5789202840&_g=" + Guid.NewGuid().ToString("N"));
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            task.Alert(Page, "教师暂未开放试题，不可作答！");
        }
    }
}