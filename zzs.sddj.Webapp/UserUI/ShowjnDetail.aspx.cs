using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class ShowjnDetail : System.Web.UI.Page
    {
        JuneiTrain traininfo = null;
        JuneiTrainBll traininfobll = new JuneiTrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            traininfo = traininfobll.GetEntityModel(Convert.ToInt32(id));
            peixunname.Value = traininfo.Trainname;
            peixunzhuban.Value = traininfo.Trainzhuban;
            
            peixundidian.Value = traininfo.Traindidian;
            peixuntime.Value = traininfo.Traintime;
            peixunxueshi.Value = traininfo.Trainxueshi.ToString();
            peixunjianjie.Value = traininfo.trainjianjie;
            peixunbeizhu.Value = traininfo.Trainbeizhu;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("personjn.aspx");
        }
    }
}