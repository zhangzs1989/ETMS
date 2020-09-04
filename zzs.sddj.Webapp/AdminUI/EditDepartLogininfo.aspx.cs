using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class EditDepartLogininfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Session["id"] = id;
                DepartmentInfo departmentinfo = new DepartmentInfo();
                DepartmentInfoBll departmentinfobll = new DepartmentInfoBll();
                departmentinfo = departmentinfobll.GetModel(id);
                xingming.Value = departmentinfo.Departmentloginname;
                mima.Value = departmentinfo.Departmentpwd;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            int id = Convert.ToInt32(Session["id"]);
            DepartmentInfo departmentinfo = new DepartmentInfo();
            DepartmentInfoBll departmentinfobll = new DepartmentInfoBll();
            departmentinfo.Id = id;
            departmentinfo.Departmentloginname = xingming.Value;
            departmentinfo.Departmentpwd = mima.Value;
            departmentinfobll.UpdataEntity(departmentinfo);
            Response.Write("<script>alert('更新部门登录信息成功!')</script>");
            Response.Redirect("DepartLogininfo.aspx");
        }
    }
}