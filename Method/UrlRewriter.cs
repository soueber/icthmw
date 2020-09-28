using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
///UrlRewriter 伪静态Url重写
/// </summary>
public class UrlRewriter:IHttpHandler
{
    /// <summary>
    /// 自定义 HttpHandler
    /// </summary>
    /// <param name="context"></param>
    public void ProcessRequest(HttpContext context)
    {
        try
        {
            string url = context.Request.RawUrl;//获取用户请求的URL地址信息
            Regex Reg = new Regex(@"/ui-(\d+)-(\d+)\..+", RegexOptions.IgnoreCase);//建立正则表达式 
            Match m = Reg.Match(url, url.LastIndexOf("/"));//用正则表达式进行URL字符串
            if (m.Success)//匹配成功
            {
                string RealPath = @"~/ui/index.aspx?type=" + m.Groups[1] + "&id=" + m.Groups[2];//重定向真实的地址信息
                context.Server.Execute(RealPath);
            }
            else
            {
                context.Response.Redirect(context.Request.Url.ToString());
            }

        }
        catch (Exception ex)
        { 
            context.Response.Redirect(context.Request.Url.ToString());  
        }
    }

    /// <summary>  
    ///  如果 System.Web.IHttpHandler 实例可再次使用，则为 true；否则为 false。
    /// </summary>  
    public bool IsReusable
    {
        get { return false; }
    }
}