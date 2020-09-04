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
    public partial class EditUserLogininfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserInfo userinfo = new UserInfo();
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                Session["id"] = id;
                UserInfoService userinfobll = new UserInfoService();
                userinfo = userinfobll.GetModel(id);
                xingming.Value = userinfo.Username;
                mima.Value = userinfo.Userpass;
            }
           
        }

        /// <summary>
        /// 编辑修改密码  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //UserInfo userinfo = new UserInfo();
            int id = Convert.ToInt32(Session["id"]);
            UserInfoService userinfobll = new UserInfoService();
            //userinfo = userinfobll.GetModel(id);
            //xingming.Value = userinfo.Username;
            //mima.Value = userinfo.Userpass;
            UserInfo userinfo2 = new UserInfo();
            userinfo2.Id = id;
            userinfo2.Username = xingming.Value;
            userinfo2.Userpass = mima.Value;
            userinfobll.UpdataEntity(userinfo2);
            
            Response.Write("<script>alert('修改信息成功!')</script>");
        }
    }
}