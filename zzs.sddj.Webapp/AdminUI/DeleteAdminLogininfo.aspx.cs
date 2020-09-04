using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class DeleteAdminLogininfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bll.AdminLoginInfoBll adminloginfobll = new Bll.AdminLoginInfoBll();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            adminloginfobll.DeleteEntityModel(id);
            Response.Write("<script>alert('删除成功!')</script>");
            Response.Redirect("AdminLoginInfo.aspx");
        }
    }
}