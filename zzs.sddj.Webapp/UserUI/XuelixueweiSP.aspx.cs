using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Text;

namespace zzs.sddj.Webapp.UserUI
{
    public partial class XuelixueweiSP : System.Web.UI.Page
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
            int pagecount = pagelist.GetUserxlxwPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            //string userloginame = HttpContext.Current.Request.Cookies["userloginame"].Value;
            ///返回当前用户的学历学位申请信息
            List<zzs.sddj.Model.Xuelixuewei> list = pagelist.GetPagexlxwList(pageindex, pagesize, userloginame);

            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                foreach (zzs.sddj.Model.Xuelixuewei xlxw in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",xlxw.Id,xlxw.Leibie1,xlxw.Scool,xlxw.Major,xlxw.Spzhuangtai);
                }
                StrHtml = sb.ToString();
            }
        }
    }
}