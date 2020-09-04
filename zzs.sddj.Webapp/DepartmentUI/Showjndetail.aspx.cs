using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Showjndetail : System.Web.UI.Page
    {
        JuneiTrain jntrain = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                jntrain = new JuneiTrain();
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                JuneiTrainBll jntrainbll = new JuneiTrainBll();
                jntrain = jntrainbll.GetEntityModel(id);
                peixunname.Value = jntrain.Trainname;
                peixunrenyuan.Value = jntrain.Trainrenyuan;
                peixundidian.Value = jntrain.Traindidian;
                peixuntime.Value = jntrain.Traintime;
                peixunxueshi.Value = jntrain.Trainxueshi.ToString();
                peixunzhuban.Value = jntrain.Trainzhuban;
                peixunjianjie.InnerText = jntrain.trainjianjie;
                jnbeizhu.InnerText = jntrain.Trainbeizhu;
                qitarenyuan.InnerText = jntrain.Qitarenyuan;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Juneitrainchaxun.aspx");
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Context.Response.Redirect("Juneitrainchaxun.aspx");
        //    jntrain = new JuneiTrain();
        //    int id = Convert.ToInt32(Context.Request.QueryString["id"]);
        //    JuneiTrainBll jntrainbll = new JuneiTrainBll();
        //    jntrain = jntrainbll.GetEntityModel(id);
        //    peixunname.Value = jntrain.Trainname;
        //    peixunrenyuan.Value = jntrain.Trainrenyuan;
        //    peixundidian.Value = jntrain.Traindidian;
        //    peixuntime.Value = jntrain.Traintime;
        //    peixunxueshi.Value = jntrain.Trainxueshi.ToString();
        //    peixunzhuban.Value = jntrain.Trainzhuban;
        //    peixunjianjie.InnerText = jntrain.trainjianjie;
        //    jnbeizhu.InnerText = jntrain.Trainbeizhu;
        //}
    }
}