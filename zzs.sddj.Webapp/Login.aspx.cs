using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp
{
    public partial class Login : System.Web.UI.Page
    {
        UserInfoService userinfoservice = new UserInfoService();
        DepartmentInfoBll departmentinfobll = new DepartmentInfoBll();
        AdminLoginInfoBll adminlogininfobll = new AdminLoginInfoBll();
        private string Msg;

        public string msg
        {
            get { return Msg; }
            set { Msg = value; }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            //服务端校验
            if (IsPostBack)
            {
                
                if (CheckValidataCode())
                {
                    string username = Context.Request.Form["txtName"];
                    HttpCookie usernamecookies = Response.Cookies["userloginame"];
                    usernamecookies.Value = username;
                    Session["userloginname"] = username;
                    
                    string userpwd = Context.Request.Form["txtPwd"];
                    
                    Response.Cookies["userloginpwd"].Value = userpwd;
                    Session["userloginpwd"] = userpwd;
                    string userradio = Context.Request.Form["check1"];
                    string msg=string.Empty;
                    //管理员
                    if (userradio == "admin")
                    {
                        AdminLoginInfo adminlogininfo=null;
                        if (username == string.Empty && userpwd == string.Empty)
                        {
                            
                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名和密码不能为空');</script>");
                            
                        }
                        else
                        {
                            //bool b = userinfoservice.CheckAdminInfo(username, userpwd, out admininfo);
                            bool b = adminlogininfobll.CheckAdminInfo(username, userpwd, out adminlogininfo); 
                            if (b)
                            {
                                Session["adminlogininfo"] = adminlogininfo;
                                Response.Redirect("~/AdminUI/AdminMain.html");
                            }
                            else

                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('密码错误，请重新输入');</script>");
                            }
                        }
                        
                    }
                        //职工
                    else if (userradio == "zhigong")
                    {
                        UserInfo userinfo = null;
                        if (username == string.Empty && userpwd == string.Empty)
                        {

                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名和密码不能为空');</script>");

                        }
                        else
                        {
                            bool b = userinfoservice.CheckUserInfo(username, userpwd, out userinfo);
                            if (b)
                            {
                                Session["userinfo"] = userinfo;
                                Response.Redirect("~/UserUI/Usermain.html");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('密码错误，请重新输入');</script>");
                            }
                        }
                    }
                    else
                    {
                        //部门登陆
                        DepartmentInfo departmentinfo = null;
                        if (username == string.Empty && userpwd == string.Empty)
                        {

                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名和密码不能为空');</script>");

                        }
                        else
                        {
                            //bool b = userinfoservice.CheckUserInfo(username, userpwd, out departmentinfo);
                            bool b = departmentinfobll.CheckDepartmentInfo(username, userpwd, out departmentinfo);
                            if (b)
                            {
                                Session["departmentinfo"] = departmentinfo;
                                Response.Redirect("~/DepartmentUI/DepartmentMain.html");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('密码错误，请重新输入');</script>");
                            }
                        }
                    }
                }
                else
                {
                    msg = "验证码错误";
                }
            }

            

        }

        //private void UserLoginIn()
        //{
        //    string username = Context.Request.Form["txtName"];
        //    string userpwd = Context.Request.Form["txtPwd"];
        //    string userradio = Context.Request.Form["check1"];
        //}

        private bool CheckValidataCode()
        {
            bool isSuccess = false;
            if (Context.Request.Cookies["code"].Value != null)
            {
                //string sysCode = Session["code"].ToString();
                string txtcode = Context.Request.Form["txtcode"];
                string sysCode = Context.Request.Cookies["code"].Value;
                
                if (sysCode.Equals(txtcode, StringComparison.InvariantCultureIgnoreCase))
                {
                    Session.Remove("code");
                    isSuccess = true;
                }
            }
            return isSuccess;
        }
    }
}