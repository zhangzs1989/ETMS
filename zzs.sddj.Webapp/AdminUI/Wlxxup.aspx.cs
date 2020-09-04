using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Wlxxup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string filepath = "D:\\上传\\Data\\Data\\Network\\2017.xlsx";
            //string str = @"Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties=Excel 8.0;";
            //OleDbConnection con = new OleDbConnection(str);
            //con.Open();
            //OleDbDataAdapter ada = new OleDbDataAdapter("select * from [sheet1$]", con);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            
        }

        
        protected void btnupfile_Click_Click(object sender, EventArgs e)
        {
            string fileName = this.homeworkFile.PostedFile.FileName;
            string newFileName = fileName.Substring(0, fileName.IndexOf('.')) + DateTime.Now.ToString("yyyyMMddhhmmss");
            newFileName += fileName.Substring(fileName.IndexOf('.'), fileName.Length - fileName.IndexOf('.'));
            fileName = newFileName;
            string type = fileName.Substring(fileName.LastIndexOf(".") + 1);
            if (type == "xls" || type == "xlsx")
            {

                string saveFileName = Server.MapPath("/wlxsfiles") + "\\" + fileName;
                homeworkFile.PostedFile.SaveAs(saveFileName);
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件上传成功！');</script>");

               
                wlxs wlxsmodel = new wlxs();
                int niandu = Convert.ToInt32(Context.Request.Form["wlxstext"]);
                wlxsmodel.Niandu = niandu;
                wlxsmodel.Filepath = fileName;
                wlxsbll wlxsb = new wlxsbll();
                wlxsb.InsertEntityModel(wlxsmodel);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('请选择正确的格式');</script>");
            }
        }
    }
}