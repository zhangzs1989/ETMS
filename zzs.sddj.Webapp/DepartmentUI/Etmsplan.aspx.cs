using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Etmsplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupfile_Click(object sender, EventArgs e)
        {
            string fileName = this.homeworkFile.PostedFile.FileName;
            string newFileName = fileName.Substring(0, fileName.IndexOf('.')) + DateTime.Now.ToString("yyyyMMddhhmmss");
            newFileName += fileName.Substring(fileName.IndexOf('.'), fileName.Length - fileName.IndexOf('.'));
            fileName = newFileName;
            //从路径中截取出文件名  
            /*string fileName = fullFileName.Substring(fullFileName.IndexOf(".")) + DateTime.Now.ToString("yyyyMMddhhmmss");*/
            //限定上传文件的格式  
            string type = fileName.Substring(fileName.LastIndexOf(".") + 1);
            if (type == "doc" || type == "docx" || type == "xls" || type == "xlsx" || type == "ppt" || type == "pptx" || type == "pdf" || type == "jpg" || type == "bmp" || type == "gif" || type == "png" || type == "txt" || type == "zip" || type == "rar")
            {

                string saveFileName = Server.MapPath("/niandutrianplan") + "\\" + fileName;

                homeworkFile.PostedFile.SaveAs(saveFileName);
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件上传成功！');</script>");
                string niandu = Context.Request.Form["niandu"];

                string userloginame = HttpContext.Current.Session["userloginname"].ToString();
                DanweiInfo danweiinfo = new DanweiInfo();
                DanweiInfoBll danweiinfobll = new DanweiInfoBll();
                danweiinfo = danweiinfobll.GetEntityModel(userloginame);
               
                Etmsplas plan = new Etmsplas();
                plan.Niandu = Convert.ToInt32(niandu);
                plan.Filepath = newFileName;
                plan.Bumen = danweiinfo.Danwei;
                EtmsplalBLL planbll = new EtmsplalBLL();
                planbll.InsertEntityModel(plan);
                
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('请选择正确的格式');</script>");
            }
        }
    }
}