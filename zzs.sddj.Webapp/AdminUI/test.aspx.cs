using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeTextBoxControls.Design;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string f = FreeTextBox1.Text;
            Context.Response.Write(f);
        }
    }
}