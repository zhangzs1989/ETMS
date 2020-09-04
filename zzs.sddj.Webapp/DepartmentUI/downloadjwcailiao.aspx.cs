using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
using System.Configuration;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class downloadjwcailiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TrainInfo traininfo = new TrainInfo();
            TrainBll jwtrain = new TrainBll();
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);
            traininfo = jwtrain.GetModel(id);
            string newFileName = traininfo.Traincailiao;
            string path = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"] + @"\" + newFileName;
            //string path = Server.MapPath("E:\\上传\\Data\\1_标准报表20160627044709.xls");
            System.IO.FileInfo fi = new System.IO.FileInfo(path);
            Response.Clear();
            Response.ClearHeaders();
            Response.Buffer = false;
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + newFileName);
            //Response.AppendHeader("Content-Disposition", "attachment;filename=Applicant1.png");
            //Response.AppendHeader("Content-Length", fi.Length.ToString());
            Response.WriteFile(path);
            Response.Flush();
            Response.End();
        }
    }
}