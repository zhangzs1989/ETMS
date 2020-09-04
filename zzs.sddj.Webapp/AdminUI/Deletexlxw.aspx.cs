using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Deletexlxw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            Bll.Xlxwbll xlxwbll = new Bll.Xlxwbll();
            xlxwbll.DeleteModel(id);
            //Bll.NoticeBll noticebll = new Bll.NoticeBll();
            //noticebll.DeleteEntity(id);
            Response.Write("<script>alert('删除成功!')</script>");
            Response.Redirect("XlxwManager.aspx");
        }
    }
}