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
    public partial class DeleteUserInfo : System.Web.UI.Page
    {
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            userinfoallbll = new UserInfo_allBll();
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            Response.Write("<script> var r=confirm('是否确定删除？');</script>");

            //ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('弹出对话框方法2')</script>");
            
            userinfoallbll.DeleteEntityModel(id);
            //Response.Write("<script>alert('删除该用户登录信息成功!')</script>");
            Response.Redirect("UserInfoManager.aspx");
        }
    }
}