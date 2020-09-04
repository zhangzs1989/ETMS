using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using zzs.sddj.Common;
using System.Text;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class AdminLoginInfo : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/html";
            PageList pagelist = new PageList();
            int pageindex;
            if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            {
                pageindex = 1;
            }
            int pagesize = 10;//每页记录
            int pagecount = pagelist.GetAdminLoginInfoPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<zzs.sddj.Model.AdminLoginInfo> list = pagelist.GetPageAdminlogininfoList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无此部门');</" + "script>");
            }
            else
            {
                foreach (zzs.sddj.Model.AdminLoginInfo userinfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='EditAdminLogininfo.aspx?id={3}'>编辑</a> | <a href='DeleteAdminLogininfo.aspx?id={3}'>删除</a></td></tr>", userinfo.Id, userinfo.Username, userinfo.Userpass, userinfo.Id);
                }
                StrHtml = sb.ToString();
                //string filepath = Request.MapPath("UserNewnotice.html");
                //string filecontent = File.ReadAllText(filepath);
                //filecontent = filecontent.Replace("$body", sb.ToString());
                //context.Response.Write(filecontent);
            }
        }

        protected void addbumen_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAdminLoginInfo.aspx");
            
        }
    }
}