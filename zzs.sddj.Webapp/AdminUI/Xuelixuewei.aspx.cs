using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Xuelixuewei : System.Web.UI.Page
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
                int pagecount = pagelist.GetUserxlxwPageCount(pagesize); //获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;

                
                List<zzs.sddj.Model.Xuelixuewei> list = pagelist.GetPagexlxwList(pageindex, pagesize);
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
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href='ShowXlxwInfodetail.aspx?id={0}'>查看详情</a>  | <a href='EditXlxwInfo.aspx?id={0}'>修改</a> | <a href='DeleteUserInfo.aspx?id={0}'>删除</a></td></tr>",
                            xlxw.Id, xlxw.Peixunren,xlxw.Leibie1, xlxw.Scool, xlxw.Major, xlxw.Starttime, xlxw.Endtime, xlxw.Spzhuangtai);
                    }
                    StrHtml = sb.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
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


            string name = chaxunname.Value;
            List<zzs.sddj.Model.Xuelixuewei> list = pagelist.GetPagexlxwList(pageindex, pagesize,name);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无学历学位申请');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                foreach (zzs.sddj.Model.Xuelixuewei xlxw in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href='ShowXlxwInfodetail.aspx?id={0}'>查看</a>  | <a href='#?id={0}'>删除</a></td></tr>",
                            xlxw.Id, xlxw.Peixunren, xlxw.Leibie1, xlxw.Scool, xlxw.Major, xlxw.Starttime, xlxw.Endtime, xlxw.Spzhuangtai);
                }
                StrHtml = sb.ToString();
            }
        }
    }
}