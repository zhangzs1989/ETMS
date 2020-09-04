using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Common;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class AddJwTrain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnupfile_Click(object sender, EventArgs e)
        {
            string trainname = Context.Request.Form["peixunname"];
            string peixunren = Context.Request.Form["peixunren"];
            string trainfs = Context.Request.Form["peixunfangshi"];
            string trainzhuban = Context.Request.Form["peixunzhuban"];
            string trainchengban = Context.Request.Form["peixunchengban"];
            string traintime = Context.Request.Form["peixunshijian"];
            int trainniandu = Convert.ToInt32(Context.Request.Form["peixunniandu"]);
            int trainxueshi = Convert.ToInt32(Context.Request.Form["peixunxueshi"]);
            string traindidian = Context.Request.Form["peixundidian"];
            string trainneirong = Context.Request.Form["peixunneirong"];
            if (trainneirong==string.Empty)
            {
                trainneirong = "略";
            }
            TrainInfo traininfo = new TrainInfo();
            traininfo.Username1 = peixunren;
            //traininfo.Username1 = HttpContext.Current.Request.Cookies["userloginame"].Value;
            //traininfo.Username1 = Session["userloginname"].ToString();

            UserInfo_all userinfoall = new UserInfo_all();
            UserInfo_allBll userinfoallbll = new UserInfo_allBll();
            userinfoall = userinfoallbll.GetEntityModel(peixunren);
            //DanweiInfo danweiinfo = new DanweiInfo();
            DanweiInfoBll danweiinfobll = new DanweiInfoBll();
            int danweiid = danweiinfobll.GetIDDanwei(userinfoall.Danwei.ToString());
            traininfo.Bumenid1 = userinfoall.Danwei.ToString();
            traininfo.Trainname = trainname;
            traininfo.Trainfangshi = trainfs;
            traininfo.Trainzhuban = trainzhuban;
            traininfo.Trainchengban = trainchengban;
            traininfo.Traintime = traintime;
            traininfo.Trainxueshi = trainxueshi;
            traininfo.Traindidian = traindidian;
            traininfo.Trainneirong = trainneirong;
            traininfo.Traincailiao = "";
            traininfo.Trainniandu = trainniandu;
            TrainBll trainbll = new TrainBll();
            trainbll.InsertModel(traininfo);
            Response.Write("<script language=javascript>alert('提交成功');</" + "script>");
            Response.Redirect("JwManager.aspx");
        }
    }
}