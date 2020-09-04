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
    public partial class UserZhidu : System.Web.UI.Page
    {
        public string strhtml { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Bll.NoticeBll noticebll = new NoticeBll();
            List<Notice> list = noticebll.Getnoticelist();
            StringBuilder sb = new StringBuilder();
            foreach (Notice notice in list)
            {
                sb.AppendFormat("<li><span>{0}</span><a href='downloadzhidu.aspx?idzhidu={2}'>{1}</a></li>", notice.Regtime1, notice.Title, notice.Id);
            }
            strhtml = sb.ToString();
        }
    }
}