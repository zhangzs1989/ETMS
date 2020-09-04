using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using zzs.sddj.Common;
using System.Text;

namespace zzs.sddj.Webapp.UserUI
{
    public partial class personjw : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        public int jwxf { get; set; }
        public int jnxf { get; set; }
        public int tolxf { get; set; }
        public int wlxf2 { get; set; }
        zzs.sddj.Model.Jiebie jibie = null;
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
                string name = HttpContext.Current.Session["userloginname"].ToString();
                List<zzs.sddj.Model.TrainInfo> list = pagelist.GetPageTrainList(pageindex, pagesize,name);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    foreach (zzs.sddj.Model.TrainInfo xlxw in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowjwDetail.aspx?id={0}'>查看详情</a></td></tr>",
                            xlxw.Id, xlxw.Username1, xlxw.Trainname, xlxw.Traintime, xlxw.Trainxueshi);
                    }
                    StrHtml = sb.ToString();
                }

                TrainBll trainbll = new TrainBll();
                jwxf = trainbll.Getxuefentol(name);
                JuneiTrainBll jntrainbll = new JuneiTrainBll();
                jnxf = jntrainbll.Getxuefentol(name);
                UserInfo_allBll userinfoallbll = new UserInfo_allBll();
                UserInfo_all userinfoall = new UserInfo_all();
                userinfoall = userinfoallbll.GetEntityModel(name);
                JibieBll jibiebll = new JibieBll();
                jibie = new zzs.sddj.Model.Jiebie();
                jibie = jibiebll.GetEntityModel(userinfoall.Leibie.Trim());
                tolxf = jibie.Jibiezhibiao;
                wlxf2 = jibie.Wangluoxueshi;

            }
        }
    }
}