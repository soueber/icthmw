using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class course_learn : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["_coid"] !="1001201910101")
            {
                task.RestrictAccess(false);
            }
        }
    }
}