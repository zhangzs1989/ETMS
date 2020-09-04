using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Text;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class ShowNoticeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            Bll.NoticeBll noticebll = new Bll.NoticeBll();
            Notice notice = noticebll.GetModel(id);
            FreeTextBox2.Text = notice.Content;
            
            //myEditor.Value = notice.Content;
            //myEditor.InnerText = Server.HtmlDecode(notice.Content);
            //myEditor.InnerText = notice.Content;
            //myEditor.InnerHtml = notice.Content;
            
            //myEditor.InnerHtml = notice.Content;
            //myEditor.Value = myEditor.InnerHtml;
            //string tbody = Server.HtmlDecode(notice.Content);
            //Response.Write(tbody);
        }
    }
}