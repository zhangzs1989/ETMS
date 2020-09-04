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

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Juneitrainperson : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //TrainBll jwbll = new TrainBll();
            JuneiTrainBll jnbll = new JuneiTrainBll();
            Response.ContentType = "text/html";
            PageList pagelist = new PageList();
            int pageindex;
            if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            {
                pageindex = 1;
            }
            int pagesize = 10;//每页记录
            int pagecount = pagelist.GetjntrainCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<JuneiTrain> list = pagelist.GetjntrainList(pageindex, pagesize);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                int iicount = 1;
                foreach (zzs.sddj.Model.JuneiTrain jntrain in list)
                {
                    sb.AppendFormat("<tr><td style='style=word-break:break-all;word-wrap:break-all;'>{0}</td><td style='style=word-break:break-all;word-wrap:break-all;'>{8}</td><td>{1}</td><td>{2}</td><td>{4}</td><td>{5}</td><td><a href='ShowjnpersontrainDetail.aspx?id={7}'>查看详情</a> | <a href='EditjnpersontrainDetail.aspx?id={7}'>修改</a> | <a href='Deletejnpersontrain.aspx?id={7}'>删除</a></td><tr>", iicount,  jntrain.Trainrenyuan, jntrain.Trainname, jntrain.Traindidian, jntrain.Traintime, jntrain.Trainxueshi, jntrain.Trainzhuban, jntrain.Id, jntrain.Trainniandu);
                    iicount++;
                }
                StrHtml = sb.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string chaxunname = jnchaxun.Value;
            JuneiTrain jntrain = new JuneiTrain();
            JuneiTrainBll jnbll = new JuneiTrainBll();
            //jnbll.GetEntityModeltoJnt(chaxunname);
            Response.ContentType = "text/html";
            PageList pagelist = new PageList();
            int pageindex;
            if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
            {
                pageindex = 1;
            }
            int pagesize = 10;//每页记录
            int pagecount = pagelist.GetjntrainCount(pagesize);//获得总页数
            Pagecounts = pagecount;
            pageindex = pageindex < 1 ? 1 : pageindex;
            pageindex = pageindex > pagecount ? pagecount : pageindex;
            Pageindex = pageindex;
            List<JuneiTrain> list = pagelist.GetjntrainList(pageindex, pagesize,chaxunname);
            StringBuilder sb = new StringBuilder();
            if (list == null)
            {
                Response.Write("<script language=javascript>alert('无培训信息');</" + "script>");
            }
            else
            {
                ///可以增加查看、删除、编辑等操作，后续完善
                int iicount = 1;
                foreach (zzs.sddj.Model.JuneiTrain jntrain2 in list)
                {
                    sb.AppendFormat("<tr><td style='style=word-break:break-all;word-wrap:break-all;'>{0}</td><td style='style=word-break:break-all;word-wrap:break-all;'>{8}</td><td>{1}</td><td>{2}</td><td>{4}</td><td>{5}</td><td><a href='ShowjnpersontrainDetail.aspx?id={7}'>查看详情</a> | <a href='EditjnpersontrainDetail.aspx?id={7}'>修改</a> | <a href='Deletejnpersontrain.aspx?id={7}'>删除</a></td><tr>", iicount, jntrain2.Trainrenyuan, jntrain2.Trainname, jntrain2.Traindidian, jntrain2.Traintime, jntrain2.Trainxueshi, jntrain2.Trainzhuban, jntrain2.Id, jntrain2.Trainniandu);
                    iicount++;
                }
                StrHtml = sb.ToString();
            }

        }
    }
}