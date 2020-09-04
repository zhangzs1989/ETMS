using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
using zzs.sddj.Model;
using System.Text;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class Userzhidulist : System.Web.UI.Page
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
            int pagecount = pagelist.GetZhiduPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<ZhiduInfo> list = pagelist.GetPagezhiduList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                int iicount = 1;
                foreach (ZhiduInfo zhiduinfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='downloadzhidu.aspx?idzhidu={4}'>下载</a></td></tr>", iicount, zhiduinfo.Title, zhiduinfo.Regtime, zhiduinfo.Shangchuanzhe, zhiduinfo.Id);
                    iicount++;
                }
                StrHtml = sb.ToString();
            }
        }
    }
}