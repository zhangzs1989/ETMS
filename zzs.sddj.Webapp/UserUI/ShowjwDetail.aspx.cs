using System;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class ShowjwDetail : System.Web.UI.Page
    {
        TrainInfo traininfo = null;
        TrainBll traininfobll = new TrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            traininfo = traininfobll.GetModel(Convert.ToInt32(id));
            peixunname.Value = traininfo.Trainname;
            peixunzhuban.Value = traininfo.Trainzhuban;
            peixunchengban.Value = traininfo.Trainchengban;
            peixundidian.Value = traininfo.Traindidian;
            peixuntime.Value = traininfo.Traintime;
            peixunxueshi.Value = traininfo.Trainxueshi.ToString();
            peixunjianjie.Value = traininfo.Trainneirong;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("personjw.aspx");
        }
    }
}