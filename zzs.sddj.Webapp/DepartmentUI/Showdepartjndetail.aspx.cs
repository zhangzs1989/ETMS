﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Showdepartjndetail : System.Web.UI.Page
    {
        JuneiTrainInfo jntraininfo = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                jntraininfo = new JuneiTrainInfo();
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                JuneiTrainInfoBll jntraininfobll = new JuneiTrainInfoBll();
                jntraininfo = jntraininfobll.GetEntityModel(id);
                peixunname.Value = jntraininfo.Trainname;
                peixundidian.Value = jntraininfo.Traindidian;
                peixuntime.Value = jntraininfo.Traintime;
                peixunxueshi.Value = jntraininfo.Trainxueshi.ToString();
                peixunzhuban.Value = jntraininfo.Trainzhuban;
                peixunjianjie.InnerText = jntraininfo.trainjianjie;
                jnbeizhu.InnerText = jntraininfo.Trainbeizhu;
                renyuan.InnerText = jntraininfo.Trainrenyuan;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepartmentTrain.aspx");
        }
    }
}