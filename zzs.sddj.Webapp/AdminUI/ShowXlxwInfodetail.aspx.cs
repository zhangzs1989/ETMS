using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class ShowXlxwInfodetail : System.Web.UI.Page
    {
        zzs.sddj.Model.Xuelixuewei xlxw = null;
        zzs.sddj.Bll.Xlxwbll xlxwbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Session["id"] = id;
                xlxw = new Model.Xuelixuewei();
                xlxwbll = new Bll.Xlxwbll();
                xlxw = xlxwbll.GetModel(id);
                xingming.Value = xlxw.Peixunren;
                bumen.Value = xlxw.Leibie1;
                sex.Value = xlxw.Scool;
                minzu.Value = xlxw.Major;
                didian.Value = xlxw.Didian;
                zzmm.Value = xlxw.Starttime;
                leibie.Value = xlxw.Endtime;
                zhiwu.Value = xlxw.Spzhuangtai;
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Xuelixuewei.aspx");
        }
    }
}