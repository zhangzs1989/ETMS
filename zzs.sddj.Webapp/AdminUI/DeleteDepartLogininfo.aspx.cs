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
    public partial class DeleteDepartLogininfo : System.Web.UI.Page
    {
        //DepartmentInfo departmentinfo = null;
        DepartmentInfoBll departmentinfobll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //departmentinfo = new DepartmentInfo();
            departmentinfobll = new DepartmentInfoBll();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            departmentinfobll.DeleteEntityModel(id);
            Response.Write("<script>alert('删除该部门登录信息成功!')</script>");
        }
    }
}