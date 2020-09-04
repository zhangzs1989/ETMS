using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class restoresql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string SqlStr1 = "Server=ZHANGZS-PC;DataBase=mydb;Uid=sa;Pwd=zhangzs";
                    string SqlStr2 = "Exec sp_helpdb";
                    SqlConnection con = new SqlConnection(SqlStr1);
                    con.Open();
                    SqlCommand com = new SqlCommand(SqlStr2, con);
                    SqlDataReader dr = com.ExecuteReader();
                    this.DropDownList1.DataSource = dr;
                    this.DropDownList1.DataTextField = "name";
                    this.DropDownList1.DataBind();
                    dr.Close();
                    con.Close();
                    SqlStr1 = "Server=ZHANGZS-PC;DataBase=mydb;Uid=sa;Pwd=zhangzs";
                    SqlStr2 = "Exec sp_helpdb";
                    con = new SqlConnection(SqlStr1);
                    con.Open();
                    com = new SqlCommand(SqlStr2, con);
                    dr = com.ExecuteReader();
                    this.DropDownList1.DataSource = dr;
                    this.DropDownList1.DataTextField = "name";
                    this.DropDownList1.DataBind();
                    dr.Close();
                    con.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dbName = string.Empty;
            if (DropDownList1.Items.Count != 0)
            {
                dbName = DropDownList1.SelectedValue.Trim();
            }
            else
            {
                dbName = txtDbName.Text.Trim();
            }
            string SqlStr1 = "Data Source=ZHANGZS-PC;Initial Catalog=mydb;User ID=sa;Password=zhangzs";
            //string ppath = "D:\\SDDZETMS\\数据库备份\\beifen.bak";
            //string SqlStr2 = String.Format("backup database mydb to disk={0}", ppath);
            string SqlStr2 = "backup database mydb to disk='" + TextBox1.Text.Trim() + "\\" + TextBox1.Text.Trim() + ".bak'";
            SqlConnection con = new SqlConnection(SqlStr1);
            con.Open();
            try
            {
                if (File.Exists(this.TextBox1.Text.Trim()))
                {
                    Response.Write("<script language=javascript>alert('此文件已存在，请从新输入！');location='Default.aspx'</script>");
                    return;
                }
                SqlCommand com = new SqlCommand(SqlStr2, con);
                com.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('备份数据成功！');</script>");
            }
            catch (Exception error)
            {
                Response.Write(error.Message);
                Response.Write("<script language=javascript>alert('备份数据失败！')</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string path = this.FileUpload1.PostedFile.FileName; //获得备份路径及数据库名称
            string dbName = string.Empty;
            if (DropDownList1.Items.Count != 0)
            {
                dbName = DropDownList1.SelectedValue.Trim();
            }
            else
            {
                dbName = txtDbName.Text.Trim();
            }
            string SqlStr1 = "Data Source=ZHANGZS-PC;Initial Catalog=mydb;User ID=sa;Password=zhangzs";
            string SqlStr2 = @"use master restore database mydb from disk='" + path + "'";
            SqlConnection con = new SqlConnection(SqlStr1);
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(SqlStr2, con);
                com.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('还原数据成功！');</script>");
            }
            catch (Exception error)
            {
                Response.Write(error.Message);
                Response.Write("<script language=javascript>alert('还原数据失败！')</script>");
                txtDbName.Text = SqlStr2;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 恢复数据库，可选择是否可以强制还原（即在其他人在用的时候，依然可以还原）
        /// </summary>
        /// <param name="databasename">待还原的数据库名称</param>
        /// <param name="databasefile">带还原的备份文件的完全路径</param>
        /// <param name="errormessage">恢复数据库失败的信息</param>
        /// <param name="forceRestore">是否强制还原（恢复），如果为TRUE，则exec killspid '数据库名' 结束此数据库的进程，这样才能还原数据库</param>
        /// <returns></returns>
        public bool RestoreDataBase(string databasename, string databasefile, ref string returnMessage, bool forceRestore, SqlConnection conn)
        {
            bool success = true;
            string path = databasefile;
            string dbname = databasename;
            string restoreSql = "use master;";
            if (forceRestore)//如果强制回复
                restoreSql += string.Format("use master exec killspid '{0}';", databasename);
            restoreSql += "restore database @dbname from disk = @path;";
            SqlCommand myCommand = new SqlCommand(restoreSql, conn);
            myCommand.Parameters.Add("@dbname", SqlDbType.Char);
            myCommand.Parameters["@dbname"].Value = dbname;
            myCommand.Parameters.Add("@path", SqlDbType.Char);
            myCommand.Parameters["@path"].Value = path;
            Response.Write(restoreSql);
            try
            {
                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
                returnMessage = "还原成功";
            }
            catch (Exception ex)
            {
                returnMessage = ex.Message;
                success = false;
            }
            finally
            {
                myCommand.Connection.Close();
            }
            return success;
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            string path = this.FileUpload1.PostedFile.FileName; //获得备份路径及数据库名称
            string dbName = string.Empty;
            if (DropDownList1.Items.Count != 0)
            {
                dbName = DropDownList1.SelectedValue.Trim();
            }
            else
            {
                dbName = txtDbName.Text.Trim();
            }
            string returnMessage = string.Empty;
            string SqlStr1 = "Data Source=DADI-20120502QV;Initial Catalog='" + dbName + "';Integrated Security=True";
            SqlConnection con = new SqlConnection(SqlStr1);
            RestoreDataBase(txtDbName.Text, path, ref returnMessage, true, con);
            Response.Write(returnMessage);
        }
    }
}
       
    
