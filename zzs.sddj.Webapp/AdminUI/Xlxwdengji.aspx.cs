using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Xlxwdengji : System.Web.UI.Page
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
            string xlxwren = Context.Request.Form["xlxwren"];
            string xlxwsp2 = "主管部门已登记···";
            string xlxwsp1 = "";
            //string username = HttpContext.Current.Request.Cookies["userloginame"].Value;
            //string username = HttpContext.Current.Session["userloginname"].ToString();
            Xlxwbll xlxwbll = new Xlxwbll();
            zzs.sddj.Model.Xuelixuewei xlxwmodel = new Model.Xuelixuewei();

            UserInfo_all userinfoall = new UserInfo_all();
            UserInfo_allBll userinfoallbll = new UserInfo_allBll();
            userinfoall = userinfoallbll.CheckBumenidFromUserInfo_all(xlxwren);
            if (userinfoall==null)
            {
                Response.Write("<script language=javascript>alert('不存在此用户，请核实用户姓名');</" + "script>");
            }
            else
            {
                xlxwmodel.Bumenid = 1;
                xlxwmodel.Leibie1 = xlxwleibie;
                xlxwmodel.Scool = xlxwscool;
                xlxwmodel.Major = xlxwmajor;
                xlxwmodel.Starttime = xlxwstart;
                xlxwmodel.Endtime = xlxwend;
                xlxwmodel.Didian = xlxwdidian;
                xlxwmodel.Peixunren = xlxwren;
                xlxwmodel.Spzhuangtai = xlxwsp1;
                xlxwmodel.Spzhuangtai2 = xlxwsp2;
                xlxwbll.InsertModel(xlxwmodel);
                Response.Write("<script language=javascript>alert('提交成功');</" + "script>");
            }
           
        }
    }
}