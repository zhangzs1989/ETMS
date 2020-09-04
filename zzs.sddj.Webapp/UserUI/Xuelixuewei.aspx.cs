using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class Xuelixuewei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void xlxw_Click(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            string xlxwscool = Context.Request.Form["xlxwscool"];
            string xlxwmajor = Context.Request.Form["xlxwmajor"];
            string xlxwstart = Context.Request.Form["xlxwstarttime"];
            string xlxwend = Context.Request.Form["xlxwendtime"];
            string xlxwdidian = Context.Request.Form["xlxwdidian"];
            string xlxwleibie = Context.Request.Form["xlxwleibie"];
            string xlxwsp = "已提交，审批中···";
            string xlxwsp2 = "主管部门未审批···";
            //string username = HttpContext.Current.Request.Cookies["userloginame"].Value;
            string username = HttpContext.Current.Session["userloginname"].ToString();
            Xlxwbll xlxwbll = new Xlxwbll();
            zzs.sddj.Model.Xuelixuewei xlxwmodel = new Model.Xuelixuewei();
            UserInfo_all userinfoall = new UserInfo_all();
            UserInfo_allBll userinfoallbll = new UserInfo_allBll();
            userinfoall = userinfoallbll.CheckBumenidFromUserInfo_all(username);
            xlxwmodel.Bumenid = 1;
            xlxwmodel.Leibie1 = xlxwleibie;
            xlxwmodel.Scool = xlxwscool;
            xlxwmodel.Major = xlxwmajor;
            xlxwmodel.Starttime = xlxwstart;
            xlxwmodel.Endtime = xlxwend;
            xlxwmodel.Didian = xlxwdidian;
            xlxwmodel.Peixunren = username;
            xlxwmodel.Spzhuangtai = xlxwsp;
            xlxwmodel.Spzhuangtai2 = xlxwsp2;
            xlxwbll.InsertModel(xlxwmodel);
            Response.Write("<script language=javascript>alert('提交成功');</" + "script>");
        }
    }
}