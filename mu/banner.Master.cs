using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.mu
{
    public partial class banner : System.Web.UI.MasterPage
    {
        private static Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_id"] == null)
            {
                login_state_user.Visible = false;
                login_state_btn.Visible = true;
            }
            else
            {
                login_state_user.Visible = true;
                login_state_btn.Visible = false;
                username.Text = task.GetUserName(int.Parse(Session["_id"].ToString()));
                userimg.Src = task.GetUserImg(int.Parse(Session["_id"].ToString()),"_img", "/img/avatar3.png");
            }
        }
    }
}