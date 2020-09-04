using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Common;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Text;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class UserInfoManager : System.Web.UI.Page
    {
        public int Pagecounts { get; set; }
        public string StrHtml { get; set; }
        public int Pageindex { get; set; }
        UserInfo_allBll userinfoallbll = null;
        UserInfo_all userinfoall = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.ContentType = "text/html";
                PageList pagelist = new PageList();
                int pageindex;
                if (!int.TryParse(Request.QueryString["pageindex"], out pageindex))
                {
                    pageindex = 1;
                }
                int pagesize = 10;//每页记录

                //UserInfo_all userinfoall = null;
                UserInfo_allBll userinfoallbll = new UserInfo_allBll();

                int pagecount = pagelist.GetUserInfoallPageCount(pagesize);
                //departloginname = (DepartmentInfo)Session["departmentinfo"];
                //int pagecount = pagelist.GetdepartmentPageCount(pagesize, departloginname.Departmentloginname);//获得总页数
                Pagecounts = pagecount;
                pageindex = pageindex < 1 ? 1 : pageindex;
                pageindex = pageindex > pagecount ? pagecount : pageindex;
                Pageindex = pageindex;
                userinfoallbll = new UserInfo_allBll();
                List<UserInfo_all> list = pagelist.GetPageUserInfoallList(pageindex, pagesize);
                //juneitrainbll = new JuneiTrainBll();
                //List<JuneiTrain> list = juneitrainbll.Getjnuserinfoall(departloginname.Departmentloginname);
                //List<JuneiTrain> list = pagelist.GetPagejntraininfoList(pageindex, pagesize, departloginname.Departmentloginname);
                StringBuilder sb = new StringBuilder();
                if (list == null)
                {
                    Response.Write("<script language=javascript>alert('无信息');</" + "script>");
                }
                else
                {
                    ///可以增加查看、删除、编辑等操作，后续完善
                    foreach (zzs.sddj.Model.UserInfo_all userinfoall in list)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{5}</td><td>{6}</td><td><a href='ShowUserInfodetail.aspx?id={12}'>查看</a>  | <a href='EditUserInfo.aspx?id={12}'>编辑</a> | <a href='DeleteUserInfo.aspx?id={12}'>删除</a></td><tr>", userinfoall.Id, userinfoall.Name, userinfoall.Danwei, userinfoall.Sex, userinfoall.Minzu, userinfoall.Zzmm, userinfoall.Leibie, userinfoall.Zhiwu, userinfoall.Xzjb, userinfoall.Zhuanji, userinfoall.Whsp, userinfoall.Personid, userinfoall.Id);
                    }
                    StrHtml = sb.ToString();
                }
            }
                
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userinfoall = new UserInfo_all();
            userinfoallbll = new UserInfo_allBll();
            string chaxunname = jnchaxun.Value;
            StringBuilder sb = new StringBuilder();
            userinfoall = userinfoallbll.GetEntityModel(chaxunname);
            if (userinfoall==null)
            {
                Response.Write("<script language=javascript>alert('无此用户');</" + "script>");
            }
            else
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{5}</td><td>{6}</td><td><a href='ShowUserInfodetail.aspx?id={12}'>查看</a>  | <a href='EditUserInfo.aspx?id={12}'>编辑</a> | <a href='DeleteUserInfo.aspx?id={12}'>删除</a></td><tr>", userinfoall.Id, userinfoall.Name, userinfoall.Danwei, userinfoall.Sex, userinfoall.Minzu, userinfoall.Zzmm, userinfoall.Leibie, userinfoall.Zhiwu, userinfoall.Xzjb, userinfoall.Zhuanji, userinfoall.Whsp, userinfoall.Personid, userinfoall.Id);
            }
            StrHtml = sb.ToString();

        }

        protected void adduser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdduserInfo.aspx");
        }
    }
}