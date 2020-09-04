using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Data;
namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Juneitrain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //在dropdownlist中显示数据库中的省
                DataTable da = new DataTable();
                DanweiInfoBll danweiinfobll = new DanweiInfoBll();
                da = danweiinfobll.GetDanweiRows();
                DropDownList1.DataSource = da;
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}