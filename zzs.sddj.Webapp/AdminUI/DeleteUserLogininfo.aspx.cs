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
    public partial class DeleteUserLogininfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            UserInfoService userinfobll = new UserInfoService();
            userinfobll.DeleteEntity(id);
            Response.Write("<script>alert('删除信息成功!')</script>");
            //Response.Redirect("UserLoginInfo.aspx");
        }
    }
}