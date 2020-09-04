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
    public partial class ShowjwtrainDetail : System.Web.UI.Page
    {
        TrainInfo traininfo = null;
        TrainBll traininfobll = new TrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            traininfo = new TrainInfo();
            string id = Request.QueryString["id"].ToString();
            Session["jwid"] = id;
            traininfo = traininfobll.GetModel(Convert.ToInt32(id));
            peixunniandu.Value = traininfo.Trainniandu.ToString();
            peixunfangshi.Value = traininfo.Trainfangshi;
            peixunren.Value = traininfo.Username1;
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
            Response.Redirect("JwManager.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditJwtrain.aspx");
        }
    }
}