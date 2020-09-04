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
    public partial class JuwaitrainManager : System.Web.UI.Page
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
                int pagecount = pagelist.GetUserjwtrainPageCount(pagesize);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;

                //DanweiInfo danweiinfo = new DanweiInfo();
                //DepartmentInfo departmentinfo = new DepartmentInfo();
                //departmentinfo = (DepartmentInfo)Session["departmentinfo"];
                //danweiinfobll = new DanweiInfoBll();
                //danweiinfo = danweiinfobll.GetEntityModel(departmentinfo.Departmentloginname);
                List<zzs.sddj.Model.TrainInfo> list = pagelist.GetPageTrainList(pageindex, pagesize);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无通知');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    foreach (zzs.sddj.Model.TrainInfo xlxw in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowjwtrainDetail.aspx?id={0}'>查看详情</a> | <a href='downloadjwcailiao.aspx?id={0}'>下载</a> | <a href='DeleteJwtrain.aspx?id={0}'>删除</a></td></tr>",
                            xlxw.Id, xlxw.Username1, xlxw.Trainname, xlxw.Traintime, xlxw.Trainxueshi);
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

            
            string name = chaxunname.Value;
            List<zzs.sddj.Model.TrainInfo> list = pagelist.GetPagetraininfoList(pageindex, pagesize,name);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无通知');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                foreach (zzs.sddj.Model.TrainInfo xlxw in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='downloadjwcailiao.aspx?id={0}'>下载</a></td></tr>",
                        xlxw.Id, xlxw.Username1, xlxw.Trainname, xlxw.Traintime, xlxw.Trainxueshi);
                }
                StrHtml = sb.ToString();
            }

        }
    }
}