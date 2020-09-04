using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using zzs.sddj.Common;
using System.Text;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class NewnoticeManager : System.Web.UI.Page
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
            int pagecount = pagelist.GetNoticePageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<Notice> list = pagelist.GetPageNoticeList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                int iicount = 1;
                foreach (Notice notice in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='ShowNoticeDetail.aspx?id={4}'>查看详细</a> | <a href='DeleteNotice.aspx?id={4}'>删除</a></td></tr>", iicount, notice.Title, notice.Regtime1, notice.Issuer, notice.Id);
                    iicount++;
                }
                StrHtml = sb.ToString();
                //string filepath = Request.MapPath("UserNewnotice.html");
                //string filecontent = File.ReadAllText(filepath);
                //filecontent = filecontent.Replace("$body", sb.ToString());
                //context.Response.Write(filecontent);
            }
        }
    }
}