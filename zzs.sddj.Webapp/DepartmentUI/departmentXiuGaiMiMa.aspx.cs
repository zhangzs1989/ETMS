﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class departmentXiuGaiMiMa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            UserInfoService userinfoservice = new UserInfoService();

            DepartmentInfo userinfo = null;
            
            string username = HttpContext.Current.Session["userloginname"].ToString();
            string userpwd = HttpContext.Current.Session["userloginpwd"].ToString();
            
            userinfo = userinfoservice.GetdepartmentInfoModel(username, userpwd);
            string jiupwd = txtOldPass.Text;
            string newpwd = txtNewPass.Text;
            string ConfirmPass = txtConfirmPass.Text;
            //bool issucess = userinfoservice.CheckUserInfo(username, userpwd, out userinfo);
            if (jiupwd != userpwd)
            {
                Response.Write("<script language=javascript>alert('旧密码输入不正确，请确认后重新输入');</" + "script>");
            }
            else if (newpwd != ConfirmPass)
            {
                Response.Write("<script language=javascript>alert('两次新密码输入不一致');</" + "script>");
            }
            else
            {

                userinfo.Departmentpwd = newpwd;
                userinfo.Departmentloginname = username;
                userinfoservice.UpdataEntity(userinfo);
                Response.Write("<script language=javascript>alert('修改成功，请重新登陆');</" + "script>");
            }
        }
    }
}