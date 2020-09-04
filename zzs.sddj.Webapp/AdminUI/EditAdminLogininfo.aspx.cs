using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class EditAdminLogininfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                zzs.sddj.Model.AdminLoginInfo adminloginfo = new Model.AdminLoginInfo();
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                Session["id"] = id;
                zzs.sddj.Bll.AdminLoginInfoBll adminloginfobll = new Bll.AdminLoginInfoBll();
                //UserInfoService userinfobll = new UserInfoService();
                adminloginfo = adminloginfobll.GetModel(id);
                //userinfo = userinfobll.GetModel(id);
                xingming.Value = adminloginfo.Username;
                mima.Value = adminloginfo.Userpass;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( Session["id"]);
            Model.AdminLoginInfo adminloginfo2 = new Model.AdminLoginInfo();
            Bll.AdminLoginInfoBll adminloginfobll2 = new Bll.AdminLoginInfoBll();
            adminloginfo2.Id = id;
            adminloginfo2.Username = xingming.Value;
            adminloginfo2.Userpass = mima.Value;
            adminloginfobll2.UpdataEntity(adminloginfo2);
            Response.Write("<script>alert('修改信息成功!')</script>");
            Response.Redirect("AdminLoginInfo.aspx");
        }
    }
}