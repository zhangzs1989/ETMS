using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.SessionState;
namespace zzs.sddj.Webapp.UserUI
{
    /// <summary>
    /// top 的摘要说明
    /// </summary>
    public class top : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string filepath = context.Request.MapPath("top.html");
            string filecontent = File.ReadAllText(filepath);
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            filecontent = filecontent.Replace("$user", userloginame);
            context.Response.Write(filecontent);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}