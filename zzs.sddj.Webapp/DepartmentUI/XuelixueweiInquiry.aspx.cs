using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class XuelixueweiInquiry : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        DanweiInfoBll danweiinfobll = null;
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

            DanweiInfo danweiinfo = new DanweiInfo();
            DepartmentInfo departmentinfo = new DepartmentInfo();
            departmentinfo =(DepartmentInfo)Session["departmentinfo"];
            danweiinfobll = new DanweiInfoBll();
            danweiinfo = danweiinfobll.GetEntityModel(departmentinfo.Departmentloginname);

            List<zzs.sddj.Model.Xuelixuewei> list = pagelist.GetPagexlxwList(pageindex, pagesize, danweiinfo.Id, "所在部门通过审批","所在部门不通过审批");
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
                    sb.AppendFormat("<tr><td>{0}</td><td>{7}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", xlxw.Id, xlxw.Leibie1, xlxw.Scool, xlxw.Major, xlxw.Starttime, xlxw.Endtime, xlxw.Spzhuangtai,xlxw.Peixunren);
                }
                StrHtml = sb.ToString();
            }
        }
    }
}