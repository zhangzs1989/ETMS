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
    public partial class JuneitrainManager : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        JuneiTrainBll juneitrainbll = null;
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
                int pagecount = pagelist.GetUserjwtrainPageCount(pagesize);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;

                juneitrainbll = new JuneiTrainBll();
                //List<JuneiTrain> list = juneitrainbll.Getjnuserinfoall(departloginname.Departmentloginname);
                List<JuneiTrain> list = pagelist.GetPagejnList(pageindex, pagesize);
                //List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showjndetail.aspx?jnid={6}'>查看详情</a> | <a href='Editjntrain.aspx?jnid={6}'>编辑</a> | <a href='Deletejntrain.aspx?jnid={6}'>删除</a></td><tr>", jntrain.Id, jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
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
            int pagecount = pagelist.GetUserjwtrainPageCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;

            juneitrainbll = new JuneiTrainBll();
            //List<JuneiTrain> list = juneitrainbll.Getjnuserinfoall(departloginname.Departmentloginname);
            List<JuneiTrain> list = pagelist.GetPagejnList(pageindex, pagesize,jnchaxun.Value);
            //List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td><a href='Showjndetail.aspx?jnid={6}'>查看详情</a></td><tr>", jntrain.Id, jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id);
                }
                StrHtml = sb.ToString();
            }
        }
    }
}