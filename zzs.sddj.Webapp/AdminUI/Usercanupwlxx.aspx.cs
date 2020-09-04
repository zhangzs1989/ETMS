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

namespace zzs.sddj.Webapp.UserUI
{
    public partial class Usercanupwlxx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string savePath = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"];
            string filepath = "D:\\上传\\Data\\Data\\Network\\201701.xlsx";
            string str = @"Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties=Excel 8.0;";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from [sheet1$]", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        public DataSet ExcelDataSource(string filepath, string sheetname)
        {
            string strConn;
        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sheetname + "$]", strConn);
        DataSet ds = new DataSet();
        oada.Fill ( ds );
            return ds ;
        }

        protected void BtnUp_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string savePath = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"];
                //string savePath = Server.MapPath("~/upload/");//指定上传文件在服务器上的保存路径
                //检查服务器上是否存在这个物理路径，如果不存在则创建
                if (!System.IO.Directory.Exists(savePath))
                {
                    System.IO.Directory.CreateDirectory(savePath);
                }
                savePath = savePath + "\\" + "Network"+"\\"+ FileUpload1.FileName;
                FileUpload1.SaveAs(savePath);
                LabMsg.Text = string.Format("<a href='upload/{0}'>upload/{0}{1}</a>", FileUpload1.FileName,"上传成功！");
            }
            else
            {
                LabMsg.Text = "你还没有选择上传文件!";
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
    }
}