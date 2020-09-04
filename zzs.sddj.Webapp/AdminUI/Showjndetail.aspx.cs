using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Showjndetail : System.Web.UI.Page
    {
        zzs.sddj.Model.JuneiTrain jntrain = null;
        JuneiTrainBll jntrainbll = new JuneiTrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            jntrain = new JuneiTrain();
            //jntrainbll = new JuneiTrainBll();
            string id = Request.QueryString["id"].ToString();
            
            //Session["jnid"] = id;
            jntrain = jntrainbll.GetEntityModel(Convert.ToInt32(id));
            peixunniandu.Value = jntrain.Trainniandu.ToString();
            peixunname.Value = jntrain.Trainname;
            peixunzhuban.Value = jntrain.Trainzhuban;
            peixundidian.Value = jntrain.Traindidian;
            peixuntime.Value = jntrain.Traintime;
            peixunxueshi.Value = jntrain.Trainxueshi.ToString();
            peixunjianjie.Value = jntrain.trainjianjie;
            peixunbeizhu.Value = jntrain.Trainbeizhu;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("JuneitrainManager.aspx");
        }
    }
}