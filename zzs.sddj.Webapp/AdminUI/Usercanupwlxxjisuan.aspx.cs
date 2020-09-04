using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Usercanupwlxxjisuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                bindlistbox();
            }
            
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 把数组中的数据绑定到listbox上
        /// </summary>
        public void bindlistbox()
        {
            string dirPath = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"] + "//" + "Network";
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            //获得目录文件列表
            FileInfo[] files = dir.GetFiles("*.*");
            string[] fileNames = new string[files.Length];
            int i = 0;
            foreach (FileInfo fileInfo in files)
            {
                fileNames[i] = fileInfo.Name;
                i++;
            }

            for (int j = 0; j < fileNames.Length; j++)
            {
                ListBox1.Items.Add(fileNames[j].ToString());
            }
        }
    }
}