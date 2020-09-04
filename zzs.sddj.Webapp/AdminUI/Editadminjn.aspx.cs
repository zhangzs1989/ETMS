using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Editadminjn : System.Web.UI.Page
    {
        zzs.sddj.Model.JuneiTrain jntrain = null;
        zzs.sddj.Model.JuneiTrainInfo jntraininfo = null;
        JuneiTrainBll jntrainbll = new JuneiTrainBll();
        JuneiTrainInfoBll jntraininfobll = new JuneiTrainInfoBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                jntrain = new JuneiTrain();


                //jntrainbll = new JuneiTrainBll();
                string id = Request.QueryString["id"].ToString();
                jntraininfo = jntraininfobll.GetEntityModel(Convert.ToInt32(id));
                Session["jnid"] = id;
                jntrain = jntrainbll.GetEntityModel(Convert.ToInt32(id));

                //peixunren.Value = jntraininfo.Qitarenyuan;
                peixunniandu.Value = jntraininfo.Trainniandu.ToString();
                peixunname.Value = jntraininfo.Trainname;
                peixunzhuban.Value = jntraininfo.Trainzhuban;
                peixundidian.Value = jntraininfo.Traindidian;
                peixuntime.Value = jntraininfo.Traintime;
                peixunxueshi.Value = jntraininfo.Trainxueshi.ToString();
                peixunjianjie.Value = jntraininfo.trainjianjie;
                peixunbeizhu.Value = jntraininfo.Trainbeizhu;
                peixunrenyuan.Value = jntraininfo.Trainrenyuan;
                jwrenyuan.Value = jntraininfo.Qitarenyuan;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["jnid"]);
            JuneiTrainBll jntbll = new JuneiTrainBll();
            JuneiTrainInfoBll jntinfobll = new JuneiTrainInfoBll();
            List<JuneiTrain> list = new List<JuneiTrain>();
            JuneiTrainInfo jninfomodel = new JuneiTrainInfo();
            JuneiTrain jnmodel = new JuneiTrain();
            ArrayList idnum = new ArrayList();
            jninfomodel = jntinfobll.GetEntityModel(id);
            idnum = jntbll.GetEntityModelid(jninfomodel.Trainname, jninfomodel.Traintime);
            if (addname.Value.Trim()==string.Empty)//更新原有JuneiTrain，JuneiTrainInfo信息，
            {
                
                
                string[] sArray1 = jninfomodel.Trainrenyuan.Split(Convert.ToChar("、"));
                //idnum = jntbll.GetEntityModelid(jninfomodel.Trainname, jninfomodel.Traintime);
                jninfomodel.Trainname = peixunname.Value;
                jninfomodel.Trainniandu = Convert.ToInt32(peixunniandu.Value);
                jninfomodel.Trainrenyuan = jninfomodel.Trainrenyuan;
                jninfomodel.Traindidian = peixundidian.Value;
                jninfomodel.Traintime = peixuntime.Value;
                jninfomodel.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
                jninfomodel.trainjianjie = peixunjianjie.Value;
                jninfomodel.Trainzhuban = peixunzhuban.Value;
                jninfomodel.Trainbeizhu = peixunbeizhu.Value;
                jninfomodel.Qitarenyuan = jwrenyuan.Value;
                jninfomodel.Id = id;
                jntinfobll.UpdataEntityModel(jninfomodel);
                //jntbll.GetEntityModelid(jninfomodel.Trainname, jninfomodel.Traintime);
                for (int i = 0; i < idnum.Count; i++)
                {
                    jnmodel.Id = Convert.ToInt32(idnum[i]);
                    jnmodel.Trainname = peixunname.Value;
                    jnmodel.Traindidian = peixundidian.Value;
                    jnmodel.Traintime = peixuntime.Value;
                    jnmodel.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
                    jnmodel.trainjianjie = peixunjianjie.Value;
                    jnmodel.Trainrenyuan = jntbll.getnamefromid(Convert.ToInt32(idnum[i]));
                    jnmodel.Trainzhuban = peixunzhuban.Value;
                    jnmodel.Trainniandu = Convert.ToInt32(peixunniandu.Value);
                    jnmodel.Qitarenyuan = "";
                    jnmodel.Trainbeizhu = peixunbeizhu.Value;
                    jntbll.UpdataEntityModel(jnmodel);
                }
                
            }
            else
            {
                idnum = jntbll.GetEntityModelid(jninfomodel.Trainname, jninfomodel.Traintime);
                string toljnname = null;
                jninfomodel = jntinfobll.GetEntityModel(id);
                string currentrenyuan = addname.Value + "、";//新添加人员
                string trainrenyuan2 = jninfomodel.Trainrenyuan;//数据库中已加入人员
                string[] sArray2 = trainrenyuan2.Split(Convert.ToChar("、"));//分割数据库人员
                string[] sArray = currentrenyuan.Split(Convert.ToChar("、"));//分割新增人员
                string newrenyuan = currentrenyuan + jninfomodel.Trainrenyuan;//合并人员

                jninfomodel.Trainname = peixunname.Value;
                jninfomodel.Trainniandu = Convert.ToInt32(peixunniandu.Value);
                jninfomodel.Trainrenyuan = newrenyuan;
                jninfomodel.Traindidian = peixundidian.Value;
                jninfomodel.Traintime = peixuntime.Value;
                jninfomodel.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
                jninfomodel.trainjianjie = peixunjianjie.Value;
                jninfomodel.Trainzhuban = peixunzhuban.Value;
                jninfomodel.Trainbeizhu = peixunbeizhu.Value;
                jninfomodel.Qitarenyuan = jwrenyuan.Value;//其他人员
                jninfomodel.Id = id;
                for (int j = 0; j < idnum.Count; j++)
                {
                    jnmodel.Id = Convert.ToInt32(idnum[j]);
                    jnmodel.Trainname = peixunname.Value;
                    jnmodel.Traindidian = peixundidian.Value;
                    jnmodel.Traintime = peixuntime.Value;
                    jnmodel.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
                    jnmodel.trainjianjie = peixunjianjie.Value;
                    jnmodel.Trainrenyuan = jntbll.getnamefromid(Convert.ToInt32(idnum[j]));
                    jnmodel.Trainzhuban = peixunzhuban.Value;
                    jnmodel.Trainniandu = Convert.ToInt32(peixunniandu.Value);
                    jnmodel.Qitarenyuan = jwrenyuan.Value;
                    jnmodel.Trainbeizhu = peixunbeizhu.Value;
                    jntbll.UpdataEntityModel(jnmodel);
                }

                for (int i = 0; i < sArray.Length; i++)
                {
                    jnmodel.Trainname = peixunname.Value;
                    jnmodel.Traindidian = peixundidian.Value;
                    jnmodel.Traintime = peixuntime.Value;
                    jnmodel.Trainxueshi = Convert.ToInt32(peixunxueshi.Value);
                    jnmodel.trainjianjie = peixunjianjie.Value;
                    jnmodel.Trainrenyuan = sArray[i].ToString();
                    jnmodel.Trainzhuban = peixunzhuban.Value;
                    jnmodel.Trainniandu = Convert.ToInt32(peixunniandu.Value);
                    jnmodel.Qitarenyuan = jwrenyuan.Value;
                    jnmodel.Trainbeizhu = peixunbeizhu.Value;
                    //toljnname += (sArray[i].ToString()+"、");
                    jntbll.InsertEntityModel(jnmodel);
                }
                jninfomodel.Trainrenyuan = newrenyuan;
                jntinfobll.UpdataEntityModel(jninfomodel);

            }
            Response.Write("<script>alter('更新成功！')</script>");
        }
    }
}