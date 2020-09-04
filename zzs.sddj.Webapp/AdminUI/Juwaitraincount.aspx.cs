using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Juwaitraincount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //List<zzs.sddj.Model.TrainInfo> jwlist = new List<Model.TrainInfo>();
                //zzs.sddj.Bll.TrainBll jwtrainbll = new Bll.TrainBll();
                //jwlist = jwtrainbll.GetEntityList();
                //int jwc = jwlist.Count();
                PageList pagelist = new PageList();

                int jwc = pagelist.Getjwtraininfocounts_jwtrain();
                string jwcountcontent = string.Format("截止目前，山东省地震局职工参与局外培训已共计{0}人次。",jwc);
                jwcount.Value = jwcountcontent.ToString();
            }
            //zzs.sddj.Model.TrainInfo tt;
            //zzs.sddj.Bll.TrainBll tb = new Bll.TrainBll();
            //tt = tb.GetModel(1);
            
        }
    }
}