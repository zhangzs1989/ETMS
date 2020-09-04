using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Common;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.DepartmentUI
{

    public partial class DepartmentTrain : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userloginame = HttpContext.Current.Session["userloginname"].ToString();
                DanweiInfo danweiinfo = new DanweiInfo();
                DanweiInfoBll danweiinfobll = new DanweiInfoBll();
                danweiinfo = danweiinfobll.GetEntityModel(userloginame);
                JuneiTrainInfoBll jntraininfobll = new JuneiTrainInfoBll();
                //DataTable dt = jntraininfobll.GetEntityModel(danweiinfo.Danwei);
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                int pagecount = pagelist.GetjntraininfoCount(pagesize, danweiinfo.Danwei);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                List<JuneiTrainInfo> list = pagelist.GetjntraininfoList(pageindex, pagesize,danweiinfo.Danwei);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    int iicount = 1;
                    foreach (zzs.sddj.Model.JuneiTrainInfo jntrain in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showdepartjndetail.aspx?id={6}'>查看详情</a></td><tr>", iicount, jntrain.Trainname,jntrain.Traindidian,jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
                        iicount++;
                    }
                    StrHtml = sb.ToString();
                }
            }
           
        }
    }
}