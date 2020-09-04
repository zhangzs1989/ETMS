using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace zzs.sddj.Webapp.DepartmentUI
{
    /// <summary>
    /// Departmenttop 的摘要说明
    /// </summary>
    public class Departmenttop : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string filepath = context.Request.MapPath("Departmenttop.html");
            string filecontent = File.ReadAllText(filepath);
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            filecontent = filecontent.Replace("$department", userloginame);
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