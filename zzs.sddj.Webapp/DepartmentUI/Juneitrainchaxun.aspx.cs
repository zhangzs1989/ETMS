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

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Juneitrainchaxun : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        JuneiTrainBll juneitrainbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                DepartmentInfo departloginname = null;
                departloginname = (DepartmentInfo)Session["departmentinfo"];
                int pagecount = pagelist.GetdepartmentPageCount(pagesize, departloginname.Departmentloginname);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                juneitrainbll = new JuneiTrainBll();
                //List<JuneiTrain> list = juneitrainbll.Getjnuserinfoall(departloginname.Departmentloginname);
                List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无通知');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    int iicount = 1;
                    foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showjndetail.aspx?id={6}'>查看详情</a></td><tr>", iicount, jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
                        iicount++;
                    }
                    StrHtml = sb.ToString();
                }
            //}

            //else
            //{
            //    string name = Session["jnchaxunren"].ToString();
            //    PageList pagelist = new PageList();
            //    int pageindex;
            //    if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            //    {
            //        pageindex = 1;
            //    }
            //    int pagesize = 10;//每页记录
            //    DepartmentInfo departloginname = null;
            //    departloginname = (DepartmentInfo)Session["departmentinfo"];
            //    int pagecount = pagelist.GetdepartmentPageCount(pagesize, departloginname.Departmentloginname, jnchaxun.Value);//获得总页数
            //    Pagecounts = pagecount;
            //    pageindex = pageindex < 1 ? 1 : pageindex;
            //    pageindex = pageindex > pagecount ? pagecount : pageindex;
            //    Pageindex = pageindex;
            //    juneitrainbll = new JuneiTrainBll();
            //    List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname, jnchaxun.Value);
            //    StringBuilder sb = new StringBuilder();
            //    if (list == null)
            //    {
            //        Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            //    }
            //    else
            //    {
            //        ///可以增加查看、删除、编辑等操作，后续完善
            //        foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
            //        {
            //            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showjndetail.aspx?id={6}'>查看详情</a></td><tr>", jntrain.Id, jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
            //        }
            //        StrHtml = sb.ToString();
            //    }

            //}
           

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.ContentType = "text/html";
        //    Session["jnchaxunren"] = jnchaxun.Value;
        //    PageList pagelist = new PageList();
        //    int pageindex;
        //    if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
        //    {
        //        pageindex = 1;
        //    }
        //    int pagesize = 10;//每页记录
        //    DepartmentInfo departloginname = null;
        //    departloginname = (DepartmentInfo)Session["departmentinfo"];
        //    int pagecount = pagelist.GetdepartmentPageCount(pagesize, departloginname.Departmentloginname,jnchaxun.Value);//获得总页数
        //    Pagecounts = pagecount;
        //    pageindex = pageindex < 1 ? 1 : pageindex;
        //    pageindex = pageindex > pagecount ? pagecount : pageindex;
        //    Pageindex = pageindex;
        //    juneitrainbll = new JuneiTrainBll();
        //    //List<JuneiTrain> list = juneitrainbll.Getjnuserinfoall(departloginname.Departmentloginname);
        //    List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname,jnchaxun.Value);
        //    StringBuilder sb = new StringBuilder();
        //    if (list == null)
        //    {
        //        Response.Write("<script language=javascript>alert('无通知');</" + "script>");
        //    }
        //    else
        //    {
        //        ///可以增加查看、删除、编辑等操作，后续完善
        //        foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
        //        {
        //            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showjndetail.aspx?id={6}'>查看详情</a></td><tr>", jntrain.Id, jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
        //        }
        //        StrHtml = sb.ToString();
        //    }
        //}
    }
}