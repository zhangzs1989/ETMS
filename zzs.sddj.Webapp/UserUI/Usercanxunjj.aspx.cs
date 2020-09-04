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
namespace zzs.sddj.Webapp.UserUI
{
    public partial class Usercanxun : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        public int juwaicounts { get; set; }
        public int juwaixuefen { get; set; }
        public int juwaibugou { get; set; }
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
            int pagecount = pagelist.GetTraininfoPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<TrainInfo> list = pagelist.GetPageTrainList(pageindex, pagesize);
            string userloginame = HttpContext.Current.Request.Cookies["userloginame"].Value;
            juwaicounts = pagelist.Getjuwaicounts(userloginame);
            juwaixuefen = 100;
            juwaibugou = 100;
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                foreach (TrainInfo traininfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='ShowJuwaicanxunDetail.aspx?id={6}'>详细</a></td></tr>", traininfo.Id, traininfo.Trainname, traininfo.Trainfangshi, traininfo.Trainxueshi, traininfo.Traintime, "审批中...",traininfo.Id);
                }
                StrHtml = sb.ToString();
            }
        }
    }
}