using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class DepartLoginInfo : System.Web.UI.Page
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
            int pagecount = pagelist.GetDepartLoginInfoPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<DepartmentInfo> list = pagelist.GetPageDepartlogininfoList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无此部门');</" + "script>");
            }
            else
            {
                int idcount = 1;
                foreach (DepartmentInfo userinfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='EditDepartLogininfo.aspx?id={3}'>编辑</a> | <a href='DeleteDepartLogininfo.aspx?id={3}'>删除</a></td></tr>", idcount++, userinfo.Departmentloginname, userinfo.Departmentpwd, userinfo.Id);
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
            Response.Redirect("AddDepartLoginInfo.aspx");
        }
    }
}