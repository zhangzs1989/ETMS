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
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Context.Response.Redirect("Addjntrainrenyuan.aspx");
        }

        /// <summary>
        /// 提交信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            
            string qitarenyuan = Context.Request.Form["qitarenyuan"];
            if (qitarenyuan == string.Empty)
            {
                qitarenyuan = "无";
            }
            string trainjianjie = Context.Request.Form["peixunjianjie"];
            if (trainjianjie==string.Empty)
            {
                trainjianjie = "略";
            }
            string trainbeizhu = Context.Request.Form["jnbeizhu"];
            if (trainbeizhu==string.Empty)
            {
                trainbeizhu = "无";
            }
            string trainniandu = Context.Request.Form["peixunniandu"];
            
            //if (trainname == string.Empty)
            //{
            //    Response.Write("<script>alert('请添加培训班名称!')</script>");
            //    peixunname.Value = trainname;
            //}
            //if (traindidian == string.Empty)
            //{
            //    Response.Write("<script>alert('请添加培训班地点!')</script>");
            //    peixundidian.Value = traindidian;
            //}
            //if (traintime == string.Empty)
            //{
            //    Response.Write("<script>alert('请添加培训班名称,格式为20160101!')</script>");
            //    peixuntime.Value = traintime;
            //}
            //if (string.IsNullOrEmpty(trainxueshi))
            //{
               
            //    {
            //        Response.Write("<script>alert('请添加学时,填写纯数字，例如32!')</script>");
            //    }
                
            //}

            //if (trainjianjie == string.Empty)
            //{
            //    Response.Write("<script>alert('请添加培训班简介（200字以内）!')</script>");
            //    peixunjianjie.Value = trainjianjie;
            //}
            

            ArrayList juneirenyuan = (ArrayList)Application["juneirenyuan"];
            if (juneirenyuan == null)
            {
                ArrayList juneirenyuannew = new ArrayList();
                juneirenyuannew.Add("无局内人员");
                
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
                    juneitrain.Trainniandu = Convert.ToInt32(trainniandu);
                    juneitrain.trainjianjie = trainjianjie;
                    juneitrain.Trainrenyuan = juneirenyuannew[i].ToString();
                    juneitrain.Trainzhuban = danweiinfo.Danwei;
                    juneitrain.Trainbeizhu = trainbeizhu;
                    juneitrain.Qitarenyuan = qitarenyuan;
                    
                    juneitrainbll.InsertEntityModel(juneitrain);
                    tolrenyuan += (juneirenyuannew[i].ToString() + "、");
                }
                //tolrenyuan = tolrenyuan + qitarenyuan;
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
                juneitraininfo.Qitarenyuan = qitarenyuan;
                juneitraininfo.Trainniandu = Convert.ToInt32(trainniandu);
                juneitraininfobll.InsertEntityModel(juneitraininfo);
                Application.Clear();
                this.peixunname.Value = "";
                this.peixundidian.Value = "";
                this.peixunjianjie.Value = "";
                this.peixuntime.Value = "";
                this.peixunxueshi.Value = "";
                this.jnbeizhu.Value = "";
                this.peixunniandu.Value = "";
                this.qitarenyuan.Value = "";
                Response.Write("<script>alert('提交本次培训情况成功!')</script>");

            }
            else
            {
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
                    juneitrain.Trainniandu = Convert.ToInt32(trainniandu);
                    juneitrainbll.InsertEntityModel(juneitrain);
                    tolrenyuan += (juneirenyuan[i].ToString() + "、");
                }
                //tolrenyuan = tolrenyuan + qitarenyuan;
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
                juneitraininfo.Qitarenyuan = qitarenyuan;
                juneitraininfo.Trainniandu = Convert.ToInt32(trainniandu);
                juneitraininfobll.InsertEntityModel(juneitraininfo);
                Application.Clear();
                this.peixunname.Value = "";
                this.peixundidian.Value = "";
                this.peixunjianjie.Value = "";
                this.peixuntime.Value = "";
                this.peixunxueshi.Value = "";
                this.jnbeizhu.Value = "";
                this.peixunniandu.Value = "";
                this.qitarenyuan.Value = "";
                Response.Write("<script>alert('提交本次培训情况成功!')</script>");

            }
        }
    }
   
}