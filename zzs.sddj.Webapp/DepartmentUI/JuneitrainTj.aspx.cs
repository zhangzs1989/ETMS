using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using System.Data;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class JuneitrainTj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            DanweiInfo danweiinfo = new DanweiInfo();
            DanweiInfoBll danweiinfobll = new DanweiInfoBll();
            danweiinfo = danweiinfobll.GetEntityModel(userloginame);

            string trainname = Context.Request.Form["peixunname"];
            string traindidian = Context.Request.Form["peixundidian"];
            string traintime = Context.Request.Form["peixuntime"];
            string trainxueshi = Context.Request.Form["peixunxueshi"];
            string trainjianjie = Context.Request.Form["peixunjianjie"];
            string qitarenyuan = Context.Request.Form["qitarenyuan"];
            string trainbeizhu = Context.Request.Form["jnbeizhu"];
            if (trainname == string.Empty)
            {
                Response.Write("<script>alert('请添加培训班名称!')</script>");
            }
            if (traindidian == string.Empty)
            {
                Response.Write("<script>alert('请添加培训班地点!')</script>");
            }
            if (traintime == string.Empty)
            {
                Response.Write("<script>alert('请添加培训班名称,格式为20160101!')</script>");
            }
            if (string.IsNullOrEmpty(trainxueshi))
            {

                {
                    Response.Write("<script>alert('请添加学时,填写纯数字，例如32!')</script>");
                }

            }

            if (trainjianjie == string.Empty)
            {
                Response.Write("<script>alert('请添加培训班简介（200字以内）!')</script>");
            }

            ArrayList juneirenyuan = (ArrayList)Application["juneirenyuan"];
            ArrayList juneirenyuannew = new ArrayList();
            for (int i = 0; i < juneirenyuan.Count; i++)
            {
                if (!juneirenyuannew.Contains(juneirenyuan[i]))
                {
                    juneirenyuannew.Add(juneirenyuan[i]);

                }
            }
            JuneiTrainBll juneitrainbll = new JuneiTrainBll();
            JuneiTrainInfoBll juneitraininfobll = new JuneiTrainInfoBll();
            string tolrenyuan = null;
            for (int i = 0; i < juneirenyuannew.Count; i++)
            {
                zzs.sddj.Model.JuneiTrain juneitrain = new zzs.sddj.Model.JuneiTrain();

                juneitrain.Trainname = trainname;
                juneitrain.Traindidian = traindidian;
                juneitrain.Traintime = traintime;
                juneitrain.Trainxueshi = Convert.ToInt32(trainxueshi);
                juneitrain.trainjianjie = trainjianjie;
                juneitrain.Trainrenyuan = juneirenyuannew[i].ToString();
                juneitrain.Trainzhuban = danweiinfo.Danwei;
                juneitrain.Trainbeizhu = trainbeizhu;
                juneitrain.Qitarenyuan = qitarenyuan;
                juneitrainbll.InsertEntityModel(juneitrain);
                tolrenyuan += (juneirenyuan[i].ToString() + "、");
            }
            tolrenyuan = tolrenyuan + qitarenyuan;
            zzs.sddj.Model.JuneiTrainInfo juneitraininfo = new zzs.sddj.Model.JuneiTrainInfo();
            juneitraininfo.Trainname = trainname;
            juneitraininfo.Traindidian = traindidian;
            juneitraininfo.Traintime = traintime;
            juneitraininfo.Trainxueshi = Convert.ToInt32(trainxueshi);
            juneitraininfo.trainjianjie = trainjianjie;
            juneitraininfo.Trainzhuban = danweiinfo.Danwei;
            juneitraininfo.trainjianjie = trainjianjie;
            juneitraininfo.Trainbeizhu = trainbeizhu;
            juneitraininfo.Trainrenyuan = tolrenyuan;
            juneitraininfobll.InsertEntityModel(juneitraininfo);
            Application.Clear();
            this.peixunname.Value = "";
            this.peixundidian.Value = "";
            this.peixunjianjie.Value = "";
            this.peixuntime.Value = "";
            this.peixunxueshi.Value = "";
            this.jnbeizhu.Value = "";
            Response.Write("<script>alert('提交本次培训情况成功!')</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Context.Response.Redirect("Juneiaddrenyuan.aspx");
        }
    }
}