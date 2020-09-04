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
    public partial class AddDepartLoginInfo : System.Web.UI.Page
    {
        DepartmentInfo departmentinfo = null;
        DepartmentInfoBll departmentinfobll = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adduserlogin_Click(object sender, EventArgs e)
        {
            departmentinfo = new DepartmentInfo();
            departmentinfobll = new DepartmentInfoBll();
            departmentinfo.Departmentloginname = xingming.Value;
            departmentinfo.Departmentpwd = mima.Value;
            departmentinfobll.InsertEntity(departmentinfo);
            Response.Write("<script>alert('添加新部门登录账号成功!')</script>");
        }
    }
}