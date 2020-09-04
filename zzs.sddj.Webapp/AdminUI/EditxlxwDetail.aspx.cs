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
    public partial class EditxlxwDetail : System.Web.UI.Page
    {
        Xlxwbll xlxwbll = null;
        zzs.sddj.Model.Xuelixuewei xlxwmodel = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xlxwbll = new Xlxwbll();
                xlxwmodel = new Model.Xuelixuewei();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Session["xlxwid"] = id;
                xlxwmodel = xlxwbll.GetModel(id);
                peixunren.Value = xlxwmodel.Peixunren.ToString();
                xlxwscool.Value = xlxwmodel.Scool;
                xlxwmajor.Value = xlxwmodel.Major;
                xlxwstart.Value = xlxwmodel.Starttime;
                xlxwend.Value = xlxwmodel.Endtime;
                xlxwdidian.Value = xlxwmodel.Didian;
                xlxwleibie.Value = xlxwmodel.Leibie1;
            }
            
          
        }

        protected void xlxw_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["xlxwid"]);
            zzs.sddj.Model.Xuelixuewei xlxwmodel = new zzs.sddj.Model.Xuelixuewei();
            UserInfo_all userinfoall = new UserInfo_all();
            UserInfo_allBll userinfoallbll = new UserInfo_allBll();
            xlxwmodel.Id = id;
            xlxwmodel.Peixunren = peixunren.Value;
            userinfoall = userinfoallbll.CheckBumenidFromUserInfo_all(peixunren.Value);
            if (userinfoall == null)
            {
                Response.Write("<script language=javascript>alert('不存在此用户，请核实用户姓名');</" + "script>");
                xlxwbll = new Xlxwbll();
                xlxwmodel = new Model.Xuelixuewei();
                //int id = Convert.ToInt32(Request.QueryString["id"]);
                //Session["xlxwid"] = id;
                xlxwmodel = xlxwbll.GetModel(id);
                peixunren.Value = xlxwmodel.Peixunren.ToString();
                xlxwscool.Value = xlxwmodel.Scool;
                xlxwmajor.Value = xlxwmodel.Major;
                xlxwstart.Value = xlxwmodel.Starttime;
                xlxwend.Value = xlxwmodel.Endtime;
                xlxwdidian.Value = xlxwmodel.Didian;
                xlxwleibie.Value = xlxwmodel.Leibie1;

            }
            else
            {
                xlxwmodel.Scool = xlxwscool.Value;
                xlxwmodel.Major = xlxwmajor.Value;
                xlxwmodel.Starttime = xlxwstart.Value;
                xlxwmodel.Endtime = xlxwend.Value;
                xlxwmodel.Didian = xlxwdidian.Value;
                xlxwmodel.Leibie1 = xlxwleibie.Value;
                xlxwbll = new Xlxwbll();
                xlxwbll.UpdataModel(xlxwmodel);
                Response.Redirect("XlxwManager.aspx");
            }

                
        }
    }
}