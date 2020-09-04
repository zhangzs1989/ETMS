using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zzs.sddj.Webapp
{
    /// <summary>
    /// DownFile 的摘要说明
    /// </summary>
    public class DownFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            
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