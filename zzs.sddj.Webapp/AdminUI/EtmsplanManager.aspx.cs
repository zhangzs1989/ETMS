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
    public partial class EtmsplanManager : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    Session["nianduvalue"] = niandu.Value;
            //}
            //else
            
                //int year = Convert.ToInt32(Session["nianduvalue"]);//当session=null,return 0
                EtmsplalBLL planbll = new EtmsplalBLL();
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录
                int pagecount = pagelist.GetetmsplanCount(pagesize);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                List<Etmsplas> list = pagelist.GetetmsplanList(pageindex, pagesize);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    int iicount = 1;
                    foreach (zzs.sddj.Model.Etmsplas plan in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='DownloadEtmsplan.aspx?id={3}'>下载</a>    |    <a href='DeleteEtmsplan.aspx?id={3}'>删除</a></td><tr>", iicount, plan.Niandu, plan.Bumen, plan.Id);
                        iicount++;
                    }
                    StrHtml = sb.ToString();
                }
            
            

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //int year = Convert.ToInt32(niandu.Value);
            int year = Convert.ToInt32(niandu.Value);
            EtmsplalBLL planbll = new EtmsplalBLL();

            Response.ContentType = "text/html";
            PageList pagelist = new PageList();
            int pageindex;
            if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            {
                pageindex = 1;
            }
            int pagesize = 10;//每页记录
            int pagecount = pagelist.GetetmsplanCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<Etmsplas> list = pagelist.GetetmsplanList(pageindex, pagesize, year);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无教育培训计划提交');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                int iicount = 1;
                foreach (zzs.sddj.Model.Etmsplas plan in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='DownloadEtmsplan.aspx?id={3}'>下载</a>    |    <a href='DeleteEtmsplan.aspx?id={3}'>删除</a></td><tr>", iicount, plan.Niandu, plan.Bumen, plan.Id);
                    iicount++;
                }
                StrHtml = sb.ToString();
            }
        }
    }

}

   
