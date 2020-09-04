using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class DownloadEtmsplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(Context.Request.QueryString["id"]);
                EtmsplalBLL planbll = new EtmsplalBLL();
                Etmsplas plan = new Etmsplas();
                plan = planbll.GetEntityModel(id);

                string newFileName = plan.Filepath;
                string saveFileName = Server.MapPath("/niandutrianplan") + "\\" + newFileName;
                System.IO.FileInfo fi = new System.IO.FileInfo(saveFileName);
                string fileExt = fi.Extension.Trim().ToLower();
                Response.Clear();
                Response.ClearHeaders();
                Response.Buffer = false;
                Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(newFileName));
                Response.AddHeader("Content-Length", fi.Length.ToString());
                Response.AddHeader("Content-Transfer-Encoding", "binary");
                Response.ContentType = checktype(HttpUtility.UrlEncodeUnicode(fileExt));//"application/octet-stream";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.WriteFile(saveFileName);
                Response.Flush();
                Response.End();
         
       
    }
        public string checktype(string fileExt)
        {
            string ContentType;
            switch (fileExt)
            {
                case ".asf":
                    ContentType = "video/x-ms-asf"; break;
                case ".avi":
                    ContentType = "video/avi"; break;
                case ".doc":
                    ContentType = "application/msword"; break;
                case ".zip":
                    ContentType = "application/zip"; break;
                case ".rar":
                    ContentType = "application/x-zip-compressed"; break;
                case ".xls":
                    ContentType = "application/vnd.ms-excel"; break;
                case ".gif":
                    ContentType = "image/gif"; break;
                case ".jpg":
                    ContentType = "image/jpeg"; break;
                case "jpeg":
                    ContentType = "image/jpeg"; break;
                case ".wav":
                    ContentType = "audio/wav"; break;
                case ".mp3":
                    ContentType = "audio/mpeg3"; break;
                case ".mpg":
                    ContentType = "video/mpeg"; break;
                case ".mepg":
                    ContentType = "video/mpeg"; break;
                case ".rtf":
                    ContentType = "application/rtf"; break;
                case ".html":
                    ContentType = "text/html"; break;
                case ".htm":
                    ContentType = "text/html"; break;
                case ".txt":
                    ContentType = "text/plain"; break;
                default:
                    ContentType = "application/octet-stream";
                    break;
            }
            return ContentType;
        }
        
    }
}