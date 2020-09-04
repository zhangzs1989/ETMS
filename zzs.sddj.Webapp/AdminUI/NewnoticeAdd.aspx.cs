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
    public partial class NewnoticeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupfile_Click(object sender, EventArgs e)
        {
            Notice notice = new Notice();

            string noticetitle = Context.Request.Form["noticetitle"];
            //string fu = Context.Request.Form["noticefutitle"];
            string faburen=Context.Request.Form["faburen"];
            string editData = FreeTextBox1.Text;
            //string editData = Context.Request.Form["myEditor"];
            //string editData = Context.Request.Params["editorValue"];
            //string editData=Context.Request.Form["editorValue"];
            //€string editData=
            //string editData = Server.HtmlDecode(myEditor.InnerHtml);
            //string editData = myEditor.InnerHtml;
            notice.Title = noticetitle;
            notice.Issuer = faburen;
            notice.Regtime1 = DateTime.Now;
            notice.Content = editData;

            NoticeBll noticebll = new NoticeBll();
            noticebll.InsertEntity(notice);
           
            //this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('" + editData + "');</script>"); 
            //string ss = HiddenField1.Value;
            //string sss = myEditor.Value;
            //Context.Response.Write(editData);

        }
    }
}