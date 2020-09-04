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
    public partial class AdduserInfo : System.Web.UI.Page
    {
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userinfoall = new UserInfo_all();
            string name = xingming.Value;

            //int isornotexist=userinfoallbll.isexistuser(name);
           
                string bumen2 = bumen.Value;
                string sex2 = sex.Value;
                string minzu2 = minzu.Value;
                string zzmm2 = zzmm.Value;
                string leibie2 = leibie.Value;
                //string zhiwu2 = zhiwu.Value;
                //string xzjb2 = xzjb.Value;
                //string zyjs = zhuangyejishu.Value;
                //string whsp2 = whsp.Value;
                //string sfzh2 = sfzh.Value;
                userinfoall.Name = name;
                userinfoall.Danwei = bumen2;
                userinfoall.Sex = sex2;
                userinfoall.Minzu = minzu2;
                userinfoall.Zzmm = zzmm2;
                userinfoall.Leibie = leibie2;
                userinfoall.Zhiwu = "";
                userinfoall.Xzjb = "";
                userinfoall.Zhuanji = "";
                userinfoall.Whsp = "";
                userinfoall.Personid = "";
                userinfoallbll = new UserInfo_allBll();
                userinfoallbll.InsertEntityModel(userinfoall);
                Response.Write("<script>alert('添加新用户信息成功!')</script>");
                Response.Redirect("UserInfoManager.aspx");
            
        }
    }
}