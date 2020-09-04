using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class DeleteEtmsplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            zzs.sddj.Bll.EtmsplalBLL planbll = new Bll.EtmsplalBLL();
            planbll.DeleteEntityModel(id);
            Response.Redirect("EtmsplanManager.aspx");
        }
    }
}