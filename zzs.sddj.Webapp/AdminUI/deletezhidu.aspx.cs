using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class deletezhidu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Zhidubll zhibubll = new Zhidubll();
            int id = Convert.ToInt32(Request.QueryString["idzhidu"]);
            zhibubll.DeleteModel(id);
            Response.Write("<script language=javascript>alert('制度删除成功！');</" + "script>");
            Response.Redirect("AdminzhiduManager.aspx");
        }
    }
}