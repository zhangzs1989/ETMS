using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Text;
using System.IO;
namespace zzs.sddj.Webapp.UserUI
{
    /// <summary>
    /// Userzhidulist1 的摘要说明
    /// </summary>
    public class Userzhidulist1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            Bll.Zhidubll zhidubll = new Bll.Zhidubll();
            List<ZhiduInfo> list = zhidubll.GetZhiduEntityList();
            
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                context.Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                foreach (ZhiduInfo zhiduinfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='downloadzhidu.aspx?idzhidu={4}'>下载</a></td></tr>", zhiduinfo.Id, zhiduinfo.Title, zhiduinfo.Regtime, zhiduinfo.Shangchuanzhe, zhiduinfo.Id);
                }
                string filepath = context.Request.MapPath("Userzhidulist.html");
                string filecontent = File.ReadAllText(filepath);
                filecontent = filecontent.Replace("$body", sb.ToString());
                context.Response.Write(filecontent);
            }
            
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