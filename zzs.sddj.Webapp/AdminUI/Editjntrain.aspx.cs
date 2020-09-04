using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Editjntrain : System.Web.UI.Page
    {
        zzs.sddj.Model.JuneiTrain jntrain = null;
        zzs.sddj.Bll.JuneiTrainBll jntrainbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                jntrain = new Model.JuneiTrain();
                jntrainbll = new Bll.JuneiTrainBll();
                int id = Convert.ToInt32(Request.QueryString["jnid"]);
                Session["jnid"] = id;
                jntrain = jntrainbll.GetEntityModel(id);
                peixunname.Value = jntrain.Trainname;
                peixunzhuban.Value = jntrain.Trainzhuban;
                peixundidian.Value = jntrain.Traindidian;
                peixunjianjie.Value = jntrain.trainjianjie;
                peixunbeizhu.Value = jntrain.Trainbeizhu;
                peixunxueshi.Value = jntrain.Trainxueshi.ToString();
                peixuntime.Value = jntrain.Traintime;
                peixunchengban.Value = jntrain.Trainrenyuan;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["jnid"]);
            zzs.sddj.Model.JuneiTrain jutrain = new Model.JuneiTrain();
            //Model.JuneiTrain jutrain2 = new Model.JuneiTrain();
            Bll.JuneiTrainBll jutrainbll = new Bll.JuneiTrainBll();
            //jutrain2 = jutrainbll.GetEntityModel(id);
            jutrain.Id = id;
            jutrain.trainjianjie = peixunjianjie.Value;
            jutrain.Trainname = peixunname.Value;
            jutrain.Trainzhuban = peixunzhuban.Value;
            jutrain.Trainrenyuan = peixunchengban.Value;
            jutrain.Traindidian = peixundidian.Value;
            jutrain.Traintime = peixuntime.Value;
            jutrain.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
            jutrain.Trainzhuban = peixunzhuban.Value;
            jutrain.Trainbeizhu = peixunbeizhu.Value;
            jutrainbll.UpdataEntityModel(jutrain);

        }
    }
}