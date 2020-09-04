using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zzs.sddj.Common;
namespace zzs.sddj.Webapp
{
    /// <summary>
    /// Validatecode 的摘要说明
    /// </summary>
    public class Validatecode : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            ValidateCode validatacode = new ValidateCode();
            string code = validatacode.CreateValidateCode(4);
            //context.Session["code"] = code;
            HttpCookie cookiecode = context.Response.Cookies["code"];
            cookiecode.Value = code;
            validatacode.CreateValidateGraphic(code, context);
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