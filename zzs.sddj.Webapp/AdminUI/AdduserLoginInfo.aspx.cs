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
    public partial class AdduserLoginInfo : System.Web.UI.Page
    {
        UserInfo userinfo = null;
        UserInfoService userinfobll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void adduserlogin_Click(object sender, EventArgs e)
        {
            string name = xingming.Value;
            string pwd = mima.Value;
            userinfo = new UserInfo();
            userinfobll = new UserInfoService();
            userinfo.Username = name;
            userinfo.Userpass = pwd;
            userinfobll.InsertEntity(userinfo);
            Response.Write("<script>alert('添加新用户登录账号成功!')</script>");
        }
    }
}