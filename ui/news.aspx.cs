using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui
{
    public partial class news : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_id"] == null)
            {
                task.RestrictAccess(false);
            }
        }
    }
}