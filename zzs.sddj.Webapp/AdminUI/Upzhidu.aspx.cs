using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Upzhidu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void BtnUp_Click(object sender, EventArgs e)
        //{
        //    if (homeworkFile.HasFile)
        //    {
        //        string fullFileName = this.homeworkFile.PostedFile.FileName;
        //        //从路径中截取出文件名  
        //        string fileName = fullFileName.Substring(fullFileName.LastIndexOf("\\") + 1);
        //        //限定上传文件的格式  
        //        string type = fullFileName.Substring(fullFileName.LastIndexOf(".") + 1);
        //        if (type == "doc" || type == "docx" || type == "xls" || type == "xlsx" || type == "ppt" || type == "pptx" || type == "pdf" || type == "jpg" || type == "bmp" || type == "gif" || type == "png" || type == "txt" || type == "zip" || type == "rar")
        //        {

        //            string saveFileName = Server.MapPath("/files") + "\\" + fileName;
        //            homeworkFile.PostedFile.SaveAs(saveFileName);
        //            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件上传成功！');</script>");
        //            string zhidutitle = Context.Request.Form["zhiduname"];
        //            string shangchuanzhe = Context.Request.Form["shangchuanzhe"];
        //            ZhiduInfo zhiduinfo = new ZhiduInfo();
        //            zhiduinfo.Title = zhidutitle;
        //            zhiduinfo.Shangchuanzhe = shangchuanzhe;
        //            zhiduinfo.Regtime = DateTime.Now;
        //            zhiduinfo.Zhiducailiao = homeworkFile.FileName;
        //            Zhidubll zhidubll = new Zhidubll();
        //            zhidubll.InsertModel(zhiduinfo);
        //        }
        //        else
        //        {
        //            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('请选择正确的格式');</script>");
        //        }


        //    }

        //    //protected void BtnUp_Click(object sender, EventArgs e)
        //    //{
        //    //    if (homeworkFile.HasFile)
        //    //    {
        //    //        string savePath = Server.MapPath("~/");//指定上传文件在服务器上的保存路径
        //    //        //检查服务器上是否存在这个物理路径，如果不存在则创建
        //    //        if (!System.IO.Directory.Exists(savePath))
        //    //        {
        //    //            System.IO.Directory.CreateDirectory(savePath);
        //    //        }
        //    //        savePath = savePath + "\\" + homeworkFile.FileName;
        //    //        homeworkFile.SaveAs(savePath);
        //    //        LabMsg.Text = string.Format("<a href='upload/{0}'>upload/{0}</a>", homeworkFile.FileName);
        //    //    }
        //    //    else
        //    //    {
        //    //        LabMsg.Text = "你还没有选择上传文件!";
        //    //    }
        //    //}
        //}

        protected void btnupfile_Click_Click(object sender, EventArgs e)
        {
            //if (homeworkFile.HasFile)
            //{
            
            
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

                    string saveFileName = Server.MapPath("/zhidufiles") + "\\" + fileName;
                    homeworkFile.PostedFile.SaveAs(saveFileName);
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件上传成功！');</script>");
                    string zhidutitle = Context.Request.Form["zhiduname"];
                    string shangchuanzhe = Context.Request.Form["shangchuanzhe"];
                    ZhiduInfo zhiduinfo = new ZhiduInfo();
                    zhiduinfo.Title = zhidutitle;
                    zhiduinfo.Shangchuanzhe = shangchuanzhe;
                    zhiduinfo.Regtime = DateTime.Now;
                zhiduinfo.Zhiducailiao = newFileName;
                    Zhidubll zhidubll = new Zhidubll();
                    zhidubll.InsertModel(zhiduinfo);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('请选择正确的格式');</script>");
                }


            //}
        }
    }
}