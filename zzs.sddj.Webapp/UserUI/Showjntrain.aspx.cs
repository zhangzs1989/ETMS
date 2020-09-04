using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;

namespace zzs.sddj.Webapp.UserUI
{
    public partial class Showjntrain : System.Web.UI.Page
    {
        JuneiTrainBll jntrainbll = new JuneiTrainBll();
        JuneiTrain jntrain = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            jntrain = new JuneiTrain();
            string id = Request.QueryString["ID"].ToString();
            jntrain = jntrainbll.GetEntityModel(Convert.ToInt32(id));
            peixunname.Value = jntrain.Trainname;
            peixundidian.Value = jntrain.Traindidian;
            peixuntime.Value = jntrain.Traintime;
            peixunxueshi.Value = jntrain.Trainxueshi.ToString();
            peixunjianjie.Value = jntrain.trainjianjie;
            peixunbeizhu.Value = jntrain.Trainbeizhu;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usercanxunjn.aspx");
        }
    }
}