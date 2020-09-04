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
    public partial class ShowUserInfodetail : System.Web.UI.Page
    {
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userinfoallbll = new UserInfo_allBll();
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                Session["id"] = id;
                userinfoall = new UserInfo_all();
                userinfoall = userinfoallbll.GetEntityModel(id);
                xingming.Value = userinfoall.Name;
                sex.Value = userinfoall.Sex;
                bumen.Value = userinfoall.Danwei;
                zzmm.Value = userinfoall.Zzmm;
                minzu.Value = userinfoall.Minzu;
                leibie.Value = userinfoall.Leibie;
                zhiwu.Value = userinfoall.Zhiwu;
                xzjb.Value = userinfoall.Xzjb;
                whsp.Value = userinfoall.Whsp;
                zhuangyejishu.Value = userinfoall.Zhuanji;
                sfzh.Value = userinfoall.Personid.ToString();
            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Context.Response.Redirect("UserinfoManager.aspx");
            
            //Context.Response.Redirect("ShowUserInfodetail.aspx");
        }
    }
}