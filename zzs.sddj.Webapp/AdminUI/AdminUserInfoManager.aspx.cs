using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    
    public partial class AdminUserInfoManager : System.Web.UI.Page
    {
        
        string selectdpval = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private bool gridViewBind()
        {
            zzs.sddj.Bll.UserInfo_allBll userinfoallbll = new Bll.UserInfo_allBll();

            DataSet ds = userinfoallbll.GetEntityds();
            this.GridView1.DataSource = ds;
            this.GridView1.DataBind();
            return true;
        }

        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectdpval = this.DropDownList1.SelectedValue;
            Session["danweiname"] = selectdpval;
            gridViewBind(selectdpval);
            
            
        }

        protected void gridViewBind(string danweiname)
        {
            zzs.sddj.Bll.UserInfo_allBll userinfoallbll = new Bll.UserInfo_allBll();

            DataSet ds = userinfoallbll.GetEntityds(danweiname);
            this.GridView1.DataSource = ds;
            this.GridView1.DataBind();
            
            
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType==DataControlRowType.Header)
            {
                TableCellCollection tcHeader = e.Row.Cells;
                tcHeader.Clear();

                // 第1行表头
                
                tcHeader.Add(new TableHeaderCell());
                tcHeader[0].Text = "操作";

                tcHeader.Add(new TableHeaderCell());
                tcHeader[1].Text = "编号";

                tcHeader.Add(new TableHeaderCell());
                tcHeader[2].Text = "单位";

                tcHeader.Add(new TableHeaderCell());
                tcHeader[3].Text = "姓名";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[4].Text = "性别";

                tcHeader.Add(new TableHeaderCell());
                tcHeader[5].Text = "出生日期";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[6].Text = "性别";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[7].Text = "政治面貌";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[8].Text = "类别";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[9].Text = "职务";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[10].Text = "行政级别";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[11].Text = "文化水平";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[12].Text = "专业技术";
                tcHeader.Add(new TableHeaderCell());
                tcHeader[13].Text = "身份证号";
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string danweiname = HttpContext.Current.Session["danweiname"].ToString();
            GridView1.PageIndex = e.NewPageIndex;
            gridViewBind(danweiname);
            
        }

        

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String Strcon = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection con = new SqlConnection(Strcon);
            int iii = e.RowIndex;
            int jjj = Convert.ToInt32(GridView1.DataKeys[iii].Value);
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);/*获取主键，需要设置 DataKeyNames，这里设为 id */
            String sql = "delete from UserInfo_all where ID='" + id + "'";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            string danweiname = HttpContext.Current.Session["danweiname"].ToString();
            gridViewBind(danweiname);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            string danweiname = HttpContext.Current.Session["danweiname"].ToString();
            gridViewBind(danweiname);
            DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String Strcon = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection con = new SqlConnection(Strcon);
            String name = (GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text.ToString();    /*获取要更新的数据*/
            String sex = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text.ToString();
            String birthday = (GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text.ToString();
            String minzu = (GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text.ToString();    /*获取要更新的数据*/
            String zzmm = (GridView1.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox).Text.ToString();
            String leibie = (GridView1.Rows[e.RowIndex].Cells[7].Controls[0] as TextBox).Text.ToString();
            String zhiwu = (GridView1.Rows[e.RowIndex].Cells[8].Controls[0] as TextBox).Text.ToString();    /*获取要更新的数据*/
            String xzjb = (GridView1.Rows[e.RowIndex].Cells[9].Controls[0] as TextBox).Text.ToString();
            String whsp = (GridView1.Rows[e.RowIndex].Cells[10].Controls[0] as TextBox).Text.ToString();
            String zhuanji = (GridView1.Rows[e.RowIndex].Cells[11].Controls[0] as TextBox).Text.ToString();    /*获取要更新的数据*/
            String personid = (GridView1.Rows[e.RowIndex].Cells[12].Controls[0] as TextBox).Text.ToString();
            

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);/*获取主键，需要设置 DataKeyNames，这里设为 id */

            String sql = "update UserInfo_all set name='" + name + "',sex='" + sex + "',birthday='" + birthday + "',minzu='"+minzu+"',zzmm='"+zzmm+"',leibie='"+leibie+"',zhiwu='"+zhiwu+"',xzjb='"+xzjb+"',whsp='"+whsp+"',zhuanji='"+zhuanji+"',personid='"+personid+"'  where ID='" + id + "'";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            //GridView1.EditIndex = -1;
            string danweiname = HttpContext.Current.Session["danweiname"].ToString();
            gridViewBind(danweiname);
            
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;                 /*编辑索引赋值为-1，变回正常显示状态*/
            string danweiname = HttpContext.Current.Session["danweiname"].ToString();
            gridViewBind(danweiname);
        }
    }
}