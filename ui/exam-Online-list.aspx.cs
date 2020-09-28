using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class exam_Online_list : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["_teid"] != "5789202840")
            {
                task.RestrictAccess(false);
            }
            else
                simbit_q.ServerClick += Simbit_q_ServerClick;
        }

        private void Simbit_q_ServerClick(object sender, EventArgs e)
        {
            if (q_1.SelectedItem.Selected == false || q_2.SelectedItem.Selected == false)
            {
                task.Alert(Page,"非法提交");
                return;
            }
            else
            {
                if (q_1.SelectedIndex == 0)
                    q_1_c.InnerHtml = "<p style='color:forestgreen;background-color:#f3f3f3;font-size:16px;'>你答对了！</p>";
                else
                    q_1_c.InnerHtml = "<p style='color:red;background-color:#f3f3f3;font-size:16px;'>你答错了，正确答案是A。</p>";
                if (q_2.SelectedIndex == 1)
                    q_2_c.InnerHtml = "<p style='color:forestgreen;background-color:#f3f3f3;font-size:16px;'>你答对了！</p>";
                else
                    q_2_c.InnerHtml = "<p style='color:red;background-color:#f3f3f3;font-size:16px;'>你答错了，正确答案是B。</p>";
                simbit_q.Visible = false;
            }
        }
    }
}