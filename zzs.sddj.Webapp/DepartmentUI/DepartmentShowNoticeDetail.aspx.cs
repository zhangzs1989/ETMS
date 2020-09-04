using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class DepartmentShowNoticeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            Bll.NoticeBll noticebll = new Bll.NoticeBll();
            Notice notice = noticebll.GetModel(id);
            FreeTextBox3.Text = notice.Content;
        }
    }
}