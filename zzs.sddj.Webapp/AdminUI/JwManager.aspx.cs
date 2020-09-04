using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Common;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class JwManager : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                TrainBll jwbll = new TrainBll();
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                int pagecount = pagelist.GetjwtraininfoCount(pagesize);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                List<TrainInfo> list = pagelist.GetjwtraininfoList(pageindex, pagesize);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    int iicount = 1;
                    foreach (zzs.sddj.Model.TrainInfo jntrain in list)
                    {
                        sb.AppendFormat("<tr><td style='style=word-break:break-all;word-wrap:break-all;'>{0}</td><td style='style=word-break:break-all;word-wrap:break-all;'>{8}</td><td>{1}</td><td>{2}</td><td>{4}</td><td>{5}</td><td><a href='ShowjwtrainDetail.aspx?id={7}'>查看详情</a> | <a href='EditjwtrainDetail.aspx?id={7}'>修改</a> | <a href='Deletejwtrain.aspx?id={7}'>删除</a></td><tr>", iicount, jntrain.Trainname, jntrain.Username1, jntrain.Traindidian, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id, jntrain.Trainniandu);
                        iicount++;
                    }
                    StrHtml = sb.ToString();
                }
            //}
            
            
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string username = name.Value;
        //    TrainBll jwbll = new TrainBll();
        //    Response.ContentType = "text/html";
        //    PageList pagelist = new PageList();
        //    int pageindex;
        //    if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
        //    {
        //        pageindex = 1;
        //    }
        //    int pagesize = 10;//每页记录
        //    int pagecount = pagelist.GetjwtraininfoCount(pagesize);//获得总页数
        //    Pagecounts = pagecount;
        //    pageindex = pageindex < 1 ? 1 : pageindex;
        //    pageindex = pageindex > pagecount ? pagecount : pageindex;
        //    Pageindex = pageindex;
        //    List<TrainInfo> list = pagelist.GetjwtraininfoList(pageindex, pagesize, username);
        //    StringBuilder sb = new StringBuilder();
        //    if (list == null)
        //    {
        //        Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
        //    }
        //    else
        //    {
        //        ///可以增加查看、删除、编辑等操作，后续完善
        //        int iicount = 1;
        //        foreach (zzs.sddj.Model.TrainInfo jntrain in list)
        //        {
        //            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td><a href='Showadminjndetail.aspx?id={7}'>查看详情</a></td><tr>", iicount, jntrain.Trainname,jntrain.Username1, jntrain.Traindidian, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
        //            iicount++;
        //        }
        //        StrHtml = sb.ToString();
        //    }
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    Context.Response.Redirect("AddJwTrain.aspx"); 
        //}
    }
}