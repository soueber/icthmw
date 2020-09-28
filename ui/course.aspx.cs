using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class course : System.Web.UI.Page
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
                Session["glog"] = "0";
            }
            else
            {
                Response.Redirect("course-learn.aspx?_uid=" + Session["id"] + "&_coid=1001201910101&_clid=1&_g=" + Guid.NewGuid().ToString("N"));
            }
        }
    }
}