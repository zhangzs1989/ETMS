using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Common;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class EditUserInfo : System.Web.UI.Page
    {
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                userinfoallbll = new UserInfo_allBll();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Session["id"] = id;
                //int id = Convert.ToInt32(Session["id"]);
                userinfoall = new UserInfo_all();
                userinfoall = userinfoallbll.GetEntityModel(id);
                xingming.Value = userinfoall.Name;
                sex.Value = userinfoall.Sex;
                //bumen.Value = userinfoall.Danwei;
                zzmm.Value = userinfoall.Zzmm;
                minzu.Value = userinfoall.Minzu;
                leibie.Value = userinfoall.Leibie;
                //zhiwu.Value = userinfoall.Zhiwu;
                //xzjb.Value = userinfoall.Xzjb;
                //whsp.Value = userinfoall.Whsp;
                //zhuangyejishu.Value = userinfoall.Zhuanji;
                //sfzh.Value = userinfoall.Personid.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userinfoallbll = new UserInfo_allBll();
            int id = Convert.ToInt32(Session["id"]);
            userinfoall = new UserInfo_all();
            //userinfoall = userinfoallbll.GetEntityModel(id);
            string name = xingming.Value;
            string sex2 = sex.Value;
            string bumen2 = bumen.Value;
            string zzmm2 = zzmm.Value;
            string minzu2 = minzu.Value;
            string leibie2 = leibie.Value;
            string zhiwu2 = leibie.Value;
            string xzjb2 = "";
            string whsp2 = "";
            string zyjs = "";
            string sfzh2 = "";
            UserInfo_all userinfoall2 = new UserInfo_all();
            userinfoall2.Id = id;
            userinfoall2.Name = name;
            userinfoall2.Sex = sex2;
            userinfoall2.Danwei = bumen2;
            userinfoall2.Zzmm = zzmm2;
            userinfoall2.Minzu = minzu2;
            userinfoall2.Leibie = leibie2;
            userinfoall2.Zhiwu = zhiwu2;
            userinfoall2.Xzjb = xzjb2;
            userinfoall2.Whsp = whsp2;
            userinfoall2.Zhuanji = zyjs;
            userinfoall2.Personid = sfzh2;
            userinfoallbll.UpdateEntityModel(userinfoall2);
            Response.Write("<script>alert('更新信息成功!')</script>");
        }
    }
}