using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;

namespace zzs.sddj.Webapp.UserUI
{
    public partial class personxlxw : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                int pagecount = pagelist.GetUserxlxwPageCount(pagesize);
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                string name = HttpContext.Current.Session["userloginname"].ToString();

                List<zzs.sddj.Model.Xuelixuewei> list = pagelist.GetPagexlxwList(pageindex, pagesize, name);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    foreach (zzs.sddj.Model.Xuelixuewei xlxw in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>",
                           xlxw.Id,xlxw.Peixunren, xlxw.Leibie1,xlxw.Starttime,xlxw.Endtime,xlxw.Scool,xlxw.Major);
                    }
                    StrHtml = sb.ToString();
                }

                
            }
        }
    }
}