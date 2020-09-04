using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class EditXlxwInfo : System.Web.UI.Page
    {
        zzs.sddj.Model.Xuelixuewei xlxw = null;
        Xlxwbll xlxwbll = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xlxwbll = new Xlxwbll();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                //int id = Convert.ToInt32(Session["id"]);
                Session["id"] = id;
                
                xlxw = new Model.Xuelixuewei();
                xlxw = xlxwbll.GetModel(id);
                Session["bumenid"] = xlxw.Bumenid;
                xingming.Value = xlxw.Peixunren;
                bumen.Value = xlxw.Leibie1;
                sex.Value = xlxw.Scool;
                didian.Value = xlxw.Didian;
                minzu.Value = xlxw.Major;
                zzmm.Value = xlxw.Starttime;
                leibie.Value = xlxw.Endtime;
                zhiwu.Value = xlxw.Spzhuangtai;

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            xlxwbll = new Xlxwbll();
            int id = Convert.ToInt32(Session["id"]);
            Model.Xuelixuewei xlxw2 = new Model.Xuelixuewei();
            //xlxw = new Model.Xuelixuewei();
            xlxw2.Bumenid =Convert.ToInt32( Session["bumenid"]);
            xlxw2.Peixunren = xingming.Value;
            xlxw2.Leibie1 = bumen.Value;
            xlxw2.Scool = sex.Value;
            xlxw2.Major = minzu.Value;
            xlxw2.Didian = didian.Value;
            xlxw2.Starttime = zzmm.Value;
            xlxw2.Endtime = leibie.Value;
            xlxw2.Spzhuangtai = zhiwu.Value;
            xlxw2.Id = id;
            xlxwbll.UpdataModel(xlxw2);
        }
    }
}