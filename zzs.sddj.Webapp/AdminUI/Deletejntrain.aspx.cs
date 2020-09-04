using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Deletejntrain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["jnid"]);
            zzs.sddj.Bll.JuneiTrainBll jntrainbll = new Bll.JuneiTrainBll();
            jntrainbll.DeleteEntityModel(id);
            Response.Write("<script>alert('删除信息成功!')</script>");
        }
    }
}