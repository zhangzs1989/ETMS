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
    public partial class ShowjnpersontrainDetail : System.Web.UI.Page
    {
        JuneiTrain jntrain=new JuneiTrain();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                JuneiTrainBll jntbll = new JuneiTrainBll();
                jntrain = jntbll.GetEntityModel(id);
                peixunname.Value = jntrain.Trainname;
                peixuntime.Value = jntrain.Traintime;
                peixundidian.Value = jntrain.Traindidian;
                peixunzhuban.Value = jntrain.Trainzhuban;
                peixunjianjie.InnerText = jntrain.trainjianjie;
                renyuan.InnerText = jntrain.Trainrenyuan;
                
                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Juneitrainperson.aspx");
        }
    }
}