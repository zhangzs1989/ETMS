using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Common;
using zzs.sddj.Model;
using System.Text;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class WlxsManager : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            wlxsbll wbll = new wlxsbll();
            Response.ContentType = "text/html";
            PageList pagelist = new PageList();
            int pageindex;
            if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            {
                pageindex = 1;
            }
            int pagesize = 10;//每页记录
            int pagecount = pagelist.GetWlxsCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<wlxs> list = pagelist.GetwlxsList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无网络学时信息');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                int iicount = 1;
                foreach (zzs.sddj.Model.wlxs wlxsmodel in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='Downloadwlxs.aspx?id={3}'>下载</a> | <a href='Deletewlxs.aspx?id={3}'>删除</a></td><tr>", iicount, wlxsmodel.Niandu,wlxsmodel.Filepath,wlxsmodel.Id);
                    iicount++;
                }
                StrHtml = sb.ToString();
            }
        }
    }
}