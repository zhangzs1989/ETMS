using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using System.Data.SqlClient;
using System.Data;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class UserInfoAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["UserName"] = "UserName";
            ViewState["UserPass"] = "UserPass";
            gridViewBind();
            
        }
        protected void gridViewBind()
        {
            /*
             * 建立数据库连接
             * 首先在头部引入DATA包
             * using System.Data;
             * using System.Data.SqlClient;
             */
            SqlConnection dataBaseCon = new SqlConnection("server=DADI-20120502QV;database=mydb;UId=sa;password=zzs");
            //配置sql语句
            string sqlStr = "select * from UserInfo";
            //实例化SqlDataAdapter sql数据适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, dataBaseCon);
            //实例化 DataSet 数据集 这个数据集会绑定在gridview上
            DataSet data = new DataSet();
            //向数据集中fill（填入）数据 da填入data
            da.Fill(data, "UserInfo");
            //将填好数据的数据集data 绑定到gridView空间上
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
            
        }
    }
}