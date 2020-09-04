using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class AddAdminLoginInfo : System.Web.UI.Page
    {
        zzs.sddj.Model.AdminLoginInfo admininfo = null;
        AdminLoginInfoBll admininfobll = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addadminlogin_Click(object sender, EventArgs e)
        {
            admininfo = new Model.AdminLoginInfo();
            admininfobll = new AdminLoginInfoBll();
            admininfo.Username = xingming.Value;
            admininfo.Userpass = mima.Value;
            admininfobll.InsertEntity(admininfo);
        }
    }
}