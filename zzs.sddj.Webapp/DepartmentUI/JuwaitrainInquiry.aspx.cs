using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Common;
using zzs.sddj.Bll;
using System.Text;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class JuwaitrainInquiry : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        DanweiInfoBll danweiinfobll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                DanweiInfo danweiinfo = new DanweiInfo();
                DepartmentInfo departmentinfo = new DepartmentInfo();
                departmentinfo = (DepartmentInfo)Session["departmentinfo"];
                danweiinfobll = new DanweiInfoBll();
                danweiinfo = danweiinfobll.GetEntityModel(departmentinfo.Departmentloginname);
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                int pagecount = pagelist.GetUserjwtrainPageCount(pagesize,danweiinfo.Danwei);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                List<zzs.sddj.Model.TrainInfo> list = pagelist.GetPagetraininfoList(pageindex, pagesize, danweiinfo.Danwei, "获取本部门人员局外培训");
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无通知');</" + "script>");
                }
                else
                {
                ///可以增加查看、删除、编辑等操作，后续完善
                /// 
                int iicount = 1;
                    foreach (zzs.sddj.Model.TrainInfo jntrain in list)
                    {
                        sb.AppendFormat("<tr><td style='style=word-break:break-all;word-wrap:break-all;'>{0}</td><td style='style=word-break:break-all;word-wrap:break-all;'>{8}</td><td>{1}</td><td>{2}</td><td>{4}</td><td>{5}</td><td><a href='ShowjwtrainDetail.aspx?id={7}'>查看详情</a></td><tr>", iicount, jntrain.Trainname, jntrain.Username1, jntrain.Traindidian, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id, jntrain.Trainniandu);
                    iicount++;
                }
                    StrHtml = sb.ToString();
                }
            //}
            
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    Response.ContentType = "text/html";
        //    PageList pagelist = new PageList();
        //    int pageindex;
        //    if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
        //    {
        //        pageindex = 1;
        //    }
        //    int pagesize = 10;//每页记录
        //    int pagecount = pagelist.GetUserxlxwPageCount(pagesize);//获得总页数
        //    Pagecounts = pagecount;
        //    pageindex = pageindex < 1 ? 1 : pageindex;
        //    pageindex = pageindex > pagecount ? pagecount : pageindex;
        //    Pageindex = pageindex;

        //    DanweiInfo danweiinfo = new DanweiInfo();
        //    DepartmentInfo departmentinfo = new DepartmentInfo();
        //    departmentinfo = (DepartmentInfo)Session["departmentinfo"];
        //    danweiinfobll = new DanweiInfoBll();
        //    danweiinfo = danweiinfobll.GetEntityModel(departmentinfo.Departmentloginname);
        //    string name = chaxunname.Value;
        //    List<zzs.sddj.Model.TrainInfo> list = pagelist.GetPagetraininfoList(pageindex, pagesize, name, danweiinfo.Id);
        //    StringBuilder sb = new StringBuilder();
        //    if (list == null)
        //    {
        //        Response.Write("<script language=javascript>alert('无通知');</" + "script>");
        //    }
        //    else
        //    {
        //        / 可以增加查看、删除、编辑等操作，后续完善
        //        foreach (zzs.sddj.Model.TrainInfo xlxw in list)
        //        {
        //            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='downloadjwcailiao.aspx?id={0}'>下载</a></td></tr>",
        //                xlxw.Id, xlxw.Username1, xlxw.Trainname, xlxw.Traintime, xlxw.Trainxueshi);
        //        }
        //        StrHtml = sb.ToString();
        //    }

        //}
    }
}