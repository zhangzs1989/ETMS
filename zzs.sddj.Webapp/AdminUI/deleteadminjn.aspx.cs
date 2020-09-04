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
    public partial class deleteadminjn : System.Web.UI.Page
    {
        JuneiTrainInfo jninfo = new JuneiTrainInfo();
        JuneiTrainInfoBll jninfobll = new JuneiTrainInfoBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            
            jninfobll.deletejninfo(id);
            Response.Write("<script>alert('删除信息成功!')</script>");
        }
    }
}