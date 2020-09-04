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
    public partial class EditJwtrain : System.Web.UI.Page
    {
        TrainInfo traininfo = null;
        TrainBll traininfobll = new TrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            traininfo = new TrainInfo();

            int id = Convert.ToInt32(Session["jwid"]);
            //string id = Request.QueryString["id"].ToString();
            //Session["jwid"] = id;
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
            int id = Convert.ToInt32(Session["jwid"]);
            traininfo = new TrainInfo();
            traininfo.Id = id;
            traininfo.Trainname = peixunname.Value;
            traininfo.Trainzhuban = peixunzhuban.Value;
            traininfo.Trainchengban = peixunchengban.Value;
            traininfo.Traindidian = peixundidian.Value;
            traininfo.Traintime = peixuntime.Value;
            traininfo.Trainxueshi = Convert.ToInt32( peixunxueshi.Value);
            traininfo.Trainneirong = peixunjianjie.Value;
            traininfobll = new TrainBll();
            traininfobll.UpdataModel(traininfo);
        }
    }
}