using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Deletewlxs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            wlxsbll wbll = new wlxsbll();
            wbll.DeleteEntityModel(id);
            Response.Write("<script language=javascript>alert('删除成功！');</" + "script>");
            Response.Redirect("WlxsManager.aspx");

        }
    }
}