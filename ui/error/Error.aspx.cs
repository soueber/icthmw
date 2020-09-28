using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Icthmw.ui.error
{
    public partial class _Error : System.Web.UI.Page
    {
        private Method.Event task = new Method.Event();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetErrorType();
            GetErrorMessage();  
        }


        private void GetErrorType()
        {
            if (Request.QueryString["type"] != null)
            {
                title.InnerText = Request.QueryString["type"] + " " + task.HTTPServerErrorType(Request.QueryString["type"]);
            }
            else
            {
                title.InnerText = "500 Internal Server Error";
            }
            Page.Title = title.InnerText;
        }
        private void GetErrorMessage()
        {
            if (task.ReturnIpAdress() == Request.ServerVariables.Get("Local_Addr").ToString())
            {
                conten.InnerHtml = "错误信息：<br/>&emsp;" + Request.QueryString["message"];
            }
        }
    }
}
