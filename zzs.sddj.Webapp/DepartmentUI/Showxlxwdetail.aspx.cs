using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Showxlxwdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Xuelixuewei xlxw = new Xuelixuewei();
            Xlxwbll xlxwbll = new Xlxwbll();
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            xlxw = xlxwbll.GetModel(id);
            leixing.Value = xlxw.Leibie1.ToString();
            major.Value = xlxw.Major.ToString();
            scool.Value = xlxw.Scool.ToString();
            kaishitime.Value = xlxw.Starttime.ToString();
            jieshutime.Value = xlxw.Endtime.ToString();
            didian.Value = xlxw.Didian.ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Xuelixuewei xlxw = new Xuelixuewei();
            Xuelixuewei xlxw2 = new Xuelixuewei();
            Xlxwbll xlxwbll = new Xlxwbll();
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            xlxw2 = xlxwbll.GetModel(id);
            string dplvalue = DropDownList1.SelectedItem.Text;
            xlxw2.Spzhuangtai = dplvalue;
            //xlxw2.Spzhuangtai2 = "主管部门未审批";
            //xlxw2.Id = xlxw.Id;
            //xlxw2.Leibie1 = xlxw.Leibie1;
            //xlxw2.Major = xlxw.Major;
            //xlxw2.Peixunren = xlxw.Peixunren;
            //xlxw2.Scool = xlxw.Scool;
            //xlxw2.Spzhuangtai = dplvalue;
            //xlxw2.Starttime = xlxw.Starttime.ToString();
            //xlxw2.Didian = xlxw.Didian;
            //xlxw2.Bumenid = xlxw.Bumenid;
            //xlxw2.Endtime = xlxw.Didian;
            xlxwbll.UpdataModel(xlxw2);
            Context.Response.Redirect("XuelixueweiSp.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Xuelixuewei xlxw = new Xuelixuewei();
            //Xlxwbll xlxwbll = new Xlxwbll();
            //Context.Response.ContentType = "text/html";
            //int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            //xlxw = xlxwbll.GetModel(id);
            //leixing.Value = xlxw.Leibie1.ToString();
            //major.Value = xlxw.Major.ToString();
            //scool.Value = xlxw.Scool.ToString();
            //kaishitime.Value = xlxw.Starttime.ToString();
            //jieshutime.Value = xlxw.Endtime.ToString();
            //didian.Value = xlxw.Didian.ToString();
            
        }
    }
}