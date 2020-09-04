using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using System.IO;
using System.Configuration;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class AdminzhiduAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void btnupfile_Click(object sender, EventArgs e)
        {

            string fileName = Path.GetFileName(this.homeworkFile.FileName);
            if (fileName == "")
            {
                Response.Write("<script language=javascript>alert('请添加材料');</" + "script>");
            }
            else
            {
                string newFileName = fileName.Substring(0, fileName.IndexOf('.')) + DateTime.Now.ToString("yyyyMMddhhmmss");
                newFileName += fileName.Substring(fileName.IndexOf('.'), fileName.Length - fileName.IndexOf('.'));
                string zhidutitle = Context.Request.Form["zhiduname"];
                string shangchuanzhe = Context.Request.Form["shangchuanzhe"];
                ZhiduInfo zhiduinfo = new ZhiduInfo();
                zhiduinfo.Title = zhidutitle;
                zhiduinfo.Shangchuanzhe = shangchuanzhe;
                zhiduinfo.Regtime = DateTime.Now;
                zhiduinfo.Zhiducailiao = newFileName;
                string Url = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"] + @"\" + newFileName;
                if (this.IsFileSizeLessMax())
                {

                    if (this.isTypeOk(Url))
                    {
                        string pathStr = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"];
                        if (!Directory.Exists(pathStr))  //如果不存在路径
                        {
                            Directory.CreateDirectory(pathStr);    //创建路径
                        }
                        if (!Url.Equals(""))    //如果有上传文件
                        {
                            //FileUpload fileUpLoad = new FileUpload();
                            //1.存放文件 
                            // fileUpLoad.SaveAs(Url);
                            homeworkFile.PostedFile.SaveAs(@Url);

                        }
                    }
                }
                Zhidubll zhidubll = new Zhidubll();
                zhidubll.InsertModel(zhiduinfo);
                Response.Write("<script language=javascript>alert('提交成功');</" + "script>");
            }
        }
        private bool IsFileSizeLessMax()
        {
            //返回值
            bool result = false;
            if (this.homeworkFile.HasFile)    //如果上传了文件
            {
                //获取上传文件的允许最大值
                long fileMaxSize = 1024 * 1024;
                try
                {
                    fileMaxSize *= int.Parse(ConfigurationManager.AppSettings["FileUploadMaxSize"].Substring(0, ConfigurationManager.AppSettings["FileUploadMaxSize"].Length - 1));
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //this.WriteException("UserPotal:Homework", ex);
                }
                if (this.homeworkFile.PostedFile.ContentLength > int.Parse(fileMaxSize.ToString()))    //如果文件大小超过规定的最大值
                {
                    //this.ShowMessage("文件超过规定大小。");
                }
                else
                {
                    result = true;
                }
            }
            else    //如果没有上传的文件
            {
                result = true;
            }
            return result;
        }
        private bool isTypeOk(string fileName)
        {
            //返回结果
            bool endResult = false;
            //验证结果
            int result = 0;
            if (!fileName.Equals(""))    //如果有上传文件
            {
                //允许的文件类型
                string[] fileType = null;
                try
                {
                    fileType = ConfigurationManager.AppSettings["FileType"].Split(',');
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //this.ShowMessage("获取配置文件信息出错");
                    //this.WriteException("AdminProtal:Homework", ex);
                }
                fileName = fileName.Substring(fileName.LastIndexOf('.'), fileName.Length - fileName.LastIndexOf('.'));
                for (int i = 0; i < fileType.Length; i++)
                {
                    if (fileType[i].Equals(fileName))    //如果是合法文件类型
                    {
                        result++;
                    }
                }
                if (result > 0)
                {
                    endResult = true;
                }
            }
            else    //如果没有上传文件
            {
                endResult = true;
            }
            return endResult;
        }
    }
}