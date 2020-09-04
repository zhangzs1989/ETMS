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
    public partial class Showjwtrain : System.Web.UI.Page
    {
        TrainInfo traininfo = null;
        TrainBll traininfobll = new TrainBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            traininfo = new TrainInfo();
            string id = Request.QueryString["ID"].ToString();
            traininfo = traininfobll.GetModel(Convert.ToInt32(id));
            peixunname.Value = traininfo.Trainname;
            peixunzhuban.Value = traininfo.Trainzhuban;
            peixundidian.Value = traininfo.Traindidian;
            peixuntime.Value = traininfo.Traintime;
            peixunxueshi.Value = traininfo.Trainxueshi.ToString();
            peixunjianjie.Value = traininfo.Trainneirong;

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usercanxunjw.aspx");
        }
    }
}