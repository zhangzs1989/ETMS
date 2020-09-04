using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using Ionic.Zip;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Diagnostics;
using ICSharpCode.SharpZipLib.Zip;
namespace zzs.sddj.Webapp.AdminUI
{
    public partial class DownloadAllcanxun : System.Web.UI.Page
    {
        public int jwxf { get; set; }
        public int jnxf { get; set; }
        TrainBll jwtrainbll = null;
        JuneiTrainBll jntrainbll = null;
        DataTable jwda = null;
        DataTable jnda = null;
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        List<UserInfo_all> list = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static void SetCellRangeAddress(NPOI.SS.UserModel.ISheet sheet, int rowstart, int rowend, int colstart, int colend)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(rowstart, rowend, colstart, colend);
            sheet.AddMergedRegion(cellRangeAddress);

        }

        protected void getExcel(DataTable dt, DataTable dt2, string username,double
            wlxf,int jnxf,int jwxf,double count)
        {
            

            //string filePath = Server.MapPath(@"D\Data\Data\SDDZETMS");//路径
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            NPOI.SS.UserModel.IWorkbook workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
            ICellStyle style = workbook.CreateCellStyle();
            IFont font = workbook.CreateFont();
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Red.Index;
            style.FillPattern = FillPattern.SolidForeground;
            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("教育培训档案表");
            IRow rowhead = sheet.CreateRow(0);//创建一行
            
            //sheet.SetColumnWidth(0, 100 * 256);
            style.Alignment = HorizontalAlignment.Center;


            font.FontHeightInPoints = 20;
            font.FontHeight = 24;
            rowhead.CreateCell(0).CellStyle.Alignment = HorizontalAlignment.Center;
            rowhead.CreateCell(0).CellStyle.SetFont(font);
            rowhead.CreateCell(0).SetCellValue("山东省地震局教育培训个人档案表");
            rowhead.HeightInPoints = 30;
            
            SetCellRangeAddress(sheet, 0, 0, 0, 7);
            

            NPOI.SS.UserModel.IRow row1 = sheet.CreateRow(1);
            row1.CreateCell(0).SetCellValue("姓名");
            row1.CreateCell(1).SetCellValue(username.ToString());
            row1.CreateCell(2).SetCellValue("所在单位");
            row1.CreateCell(3).SetCellValue(userinfoall.Danwei.ToString());
            row1.CreateCell(4).SetCellValue("政治面目");
            row1.CreateCell(5).SetCellValue(userinfoall.Zzmm.ToString());

            IRow row2 = sheet.CreateRow(2);
            row2.CreateCell(0).SetCellValue("类别");
            row2.CreateCell(1).SetCellValue(userinfoall.Leibie.ToString());

            IRow row3 = sheet.CreateRow(3);
            row3.CreateCell(0).SetCellValue("序号");
            row3.CreateCell(1).SetCellValue("培训方式");
            row3.CreateCell(2).SetCellValue("培训活动名称");
            row3.CreateCell(3).SetCellValue("培训时间");
            row3.CreateCell(4).SetCellValue("培训学时");
            row3.CreateCell(5).SetCellValue("培训主办");
            row3.CreateCell(6).SetCellValue("培训地点");
            row3.CreateCell(7).SetCellValue("培训内容");

            int itemp = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                NPOI.SS.UserModel.IRow rowtemp = sheet.CreateRow(i + 4);
                rowtemp.CreateCell(0).SetCellValue((i + 1).ToString());
                rowtemp.CreateCell(1).SetCellValue(dt.Rows[i]["Trainfangshi"].ToString());
                rowtemp.CreateCell(2).SetCellValue(dt.Rows[i]["Trainname"].ToString());
                rowtemp.CreateCell(3).SetCellValue(dt.Rows[i]["Traintime"].ToString());
                rowtemp.CreateCell(4).SetCellValue(dt.Rows[i]["Trainxueshi"].ToString());
                rowtemp.CreateCell(5).SetCellValue(dt.Rows[i]["Trainzhuban"].ToString());
                rowtemp.CreateCell(6).SetCellValue(dt.Rows[i]["Traindidian"].ToString());
                rowtemp.CreateCell(7).SetCellValue(dt.Rows[i]["Trainneirong"].ToString());

                itemp = i;
            }
            itemp = dt.Rows.Count;
            int temp2 = 0;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                NPOI.SS.UserModel.IRow rowtemp = sheet.CreateRow(i + 4 + itemp);
                rowtemp.CreateCell(0).SetCellValue((i + 1 + itemp).ToString());
                rowtemp.CreateCell(1).SetCellValue("省局内培训");
                rowtemp.CreateCell(2).SetCellValue(dt2.Rows[i]["Trainname"].ToString());
                rowtemp.CreateCell(3).SetCellValue(dt2.Rows[i]["Traintime"].ToString());
                rowtemp.CreateCell(4).SetCellValue(dt2.Rows[i]["Trainxueshi"].ToString());
                rowtemp.CreateCell(5).SetCellValue(dt2.Rows[i]["Trainzhuban"].ToString());
                rowtemp.CreateCell(6).SetCellValue(dt2.Rows[i]["Traindidian"].ToString());
                rowtemp.CreateCell(7).SetCellValue(dt2.Rows[i]["Trainjianjie"].ToString());
                temp2 = i;
            }

            IRow row5 = sheet.CreateRow(itemp + 1 + 4 + temp2);
            row5.CreateCell(0).SetCellValue("参训学时总计");
            row5.CreateCell(1).SetCellValue((jwxf + jnxf).ToString());
            IRow row6 = sheet.CreateRow(itemp + 1 + 5 + temp2);
            row6.CreateCell(0).SetCellValue("网络学时总计");
            row6.CreateCell(1).SetCellValue(wlxf.ToString());
            IRow row7 = sheet.CreateRow(itemp + 1 + 6 + temp2);
            row7.CreateCell(0).SetCellValue("教育培训量化分数");
            row7.CreateCell(1).SetCellValue((jwxf+jnxf+wlxf*count));
            IRow row8 = sheet.CreateRow(itemp + 1 + 8);
            //SetCellRangeAddress(sheet, itemp + 1 + 7 + temp2, itemp + 1 + 7 + temp2, 1, 7);

            string saveFileName = Server.MapPath("/persontrain");
            //string filePath = @"D\SDDZETMS";//路径
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                book.Write(ms);
                using (FileStream fs = new FileStream(saveFileName + "\\" + username +"个人年度教育培训档案.xls", FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
                book = null;
            }


            //写入到客户端  
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //book.Write(ms);
            //Response.BinaryWrite(ms.ToArray());
            
            ////FileInfo fileInfo = new FileInfo(filePath);
            //Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}.xls", HttpUtility.UrlEncode(username.ToString(), System.Text.Encoding.UTF8)));

            //ZipFile zip = new ZipFile(System.Text.Encoding.Default);//解决中文乱码问题  
            //zip.AddFile(username+".xls" );
            //zip.Save(Response.OutputStream);





            //Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(niandu.Value);
            list = new List<UserInfo_all>();
            userinfoallbll = new UserInfo_allBll();
            list = userinfoallbll.GetEntitylist();
            jwtrainbll = new TrainBll();
            jntrainbll = new JuneiTrainBll();
            wlxsbll wbll = new wlxsbll();
            wlxs wmodel = new wlxs();
            wmodel = wbll.GetModel(year);
            if (wmodel == null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    userinfoall = list[i];
                    string name = userinfoall.Name;
                    int issucess = userinfoallbll.isexistuser(name);
                    string userloginame = name;
                    if (issucess == 1)
                    {

                        jwxf = jwtrainbll.Getxuefentol(userloginame, year);
                        jwda = new DataTable();
                        //获得登录人员的所有局外培训信息，装入DataTable
                        jwda = jwtrainbll.GetDataTable(userloginame,year);

                        userinfoall = new UserInfo_all();
                        userinfoallbll = new UserInfo_allBll();
                        //在导出excel时需要人员的信息，增加了GetEntityModel，获得人员的信息类
                        userinfoall = userinfoallbll.GetEntityModel(userloginame);


                        //局内培训信息
                        jnxf = jntrainbll.Getxuefentol(userloginame,year);

                        jnda = new DataTable();
                        jnda = jntrainbll.GetEntityModel(userloginame, year);

                        //string userloginame = HttpContext.Current.Session ["userloginname"].ToString();
                        jwxf = jwtrainbll.Getxuefentol(userloginame, year);
                        //int wlxsxuefen = 0;
                        //if (dtwlxs.Rows.Count > 0)
                        //{

                        //    foreach (DataRow row in dtwlxs.Rows)
                        //    {
                        //        if (string.Equals(row[0], userloginame))
                        //        {
                        //            //wlxsxuefen = int.Parse(row[1].ToString());
                        //            getExcel(jwda, jnda, userloginame, 0, jnxf, jwxf);
                        //        }

                        //        else
                        //        {
                        //            //wlxsxuefen = 0;
                        //            getExcel(jwda, jnda, userloginame, 0, jnxf, jwxf);

                        //        }

                        //    }
                        //}
                        //else
                        //{ 
                            
                        //}
                        getExcel(jwda, jnda, userloginame, 0, jnxf, jwxf,0.4);
                        //con.Close();
                        //getExcel(jwda, jnda, userloginame, wlxsxuefen);
                        
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('没有可以下载内容');</" + "script>");
                    }
                }
                Response.Write("<script language=javascript>alert('下载完成');</" + "script>");
            }
            else
            {
                string filepath = Server.MapPath("/wlxsfiles") + "\\" + wmodel.Filepath;
                string str = @"Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties=Excel 8.0;";
                OleDbConnection con = new OleDbConnection(str);
                con.Open();
                DataTable schemaTable = con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string tableName = schemaTable.Rows[0][2].ToString().Trim();
                string excelstr = string.Format("select * from [{0}]", tableName);
                OleDbDataAdapter ada = new OleDbDataAdapter(excelstr, con);
                DataTable dtwlxs = new DataTable();
                ada.Fill(dtwlxs);
                for (int i = 0; i < list.Count; i++)
                {
                    userinfoall = list[i];
                    string name = userinfoall.Name;
                    int issucess = userinfoallbll.isexistuser(name);
                    string userloginame = name;
                    if (issucess == 1)
                    {

                        jwxf = jwtrainbll.Getxuefentol(userloginame, year);
                        jwda = new DataTable();
                        //获得登录人员的所有局外培训信息，装入DataTable
                        jwda = jwtrainbll.GetDataTable(userloginame);
                        userinfoall = new UserInfo_all();
                        userinfoallbll = new UserInfo_allBll();
                        //在导出excel时需要人员的信息，增加了GetEntityModel，获得人员的信息类
                        userinfoall = userinfoallbll.GetEntityModel(userloginame);

                        //局内培训信息
                        jnxf = jntrainbll.Getxuefentol(userloginame,year);

                        jnda = new DataTable();
                        jnda = jntrainbll.GetEntityModel(userloginame, year);

                        //string userloginame = HttpContext.Current.Session ["userloginname"].ToString();
                        jwxf = jwtrainbll.Getxuefentol(userloginame, year);
                        //wlxsxuefen = int.Parse(dtwlxs.Select("name=@name",@name= userloginame));
                        //dtwlxs.Select()
                        double wlxsxuefen = 0;
                        if (dtwlxs.Rows.Count > 0)
                        {

                            foreach (DataRow row in dtwlxs.Rows)
                            {
                                if (string.Equals(row[0], userloginame))
                                {
                                    wlxsxuefen = double.Parse(row[1].ToString());
                                    getExcel(jwda, jnda, userloginame, wlxsxuefen,jnxf,jwxf,0.4);
                                }

                                else
                                {
                                    //wlxsxuefen = 0;
                                    getExcel(jwda, jnda, userloginame, wlxsxuefen,jnxf,jwxf,0.4);

                                }

                            }
                        }
                        else
                        {
                            //getExcel(jwda, jnda, userloginame, wlxsxuefen);
                        }
                        con.Close();
                        //getExcel(jwda, jnda, userloginame, wlxsxuefen);
                        //Response.Write("<script language=javascript>alert('下载完成，请到D:\\SDDZETMS\\下查看');</" + "script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('没有可以下载内容');</" + "script>");
                    }
                }
                Response.Write("<script language=javascript>alert('下载完成');</" + "script>");
            }

            //string path = Server.MapPath("/persontrain");
                string serverPath = Server.MapPath("/");

                //创建临时文件夹
                string tempName = "persontemporaryfile";
                string tempFolder = Path.Combine(serverPath, tempName);
                Directory.CreateDirectory(tempFolder);

                string serverPath2 = Server.MapPath("/persontrain");
                DirectoryInfo folder = new DirectoryInfo(serverPath2);
                foreach (FileInfo file in folder.GetFiles())
                {
                    string filename = file.Name;
                    File.Copy(serverPath2 + "/" + filename, tempFolder + "/" + filename);
                }

            compressFiles(tempFolder, tempFolder + "\\\\" + tempName + ".rar");


            //ZKHelper.JSHelper.Alert("图片拷贝成功!");
            //产生RAR文件，及文件输出
            //RAR(tempFolder, tempName, @"D:\教育培训管理系统\zzs.sddj\zzs.sddj.Webapp\test");
            //RARSave(tempFolder, tempName);
            //DownloadRAR(tempFolder + "\\" + tempName + ".rar");
            DownloadRAR(tempFolder + "\\\\" + tempName + ".rar", tempName);

        }

        public static void compressFiles(string dir, string zipfilename)
        {
            if (!Directory.Exists(dir))
            {
                return;
            }
            try
            {
                string[] filenames = Directory.GetFiles(dir);
                using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream s = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(File.Create(zipfilename)))
                {

                    s.SetLevel(9); // 0 - store only to 9 - means best compression

                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {
                        ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);
                        using (FileStream fs = File.OpenRead(file))
                        {
                            int sourceBytes;
                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                s.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }
                    s.Finish();
                    s.Close();
                }
            }
            catch
            {

            }
        }
        private void DownloadRAR(string file, string name)
        {
            FileInfo fileInfo = new FileInfo(file);
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("Content-Disposition", "attachment;filename=" + name + ".rar");
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.AddHeader("Content-Transfer-Encoding", "binary");
            Response.ContentType = "application/octet-stream";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.WriteFile(fileInfo.FullName);
            Response.Flush();
            string tempPath = file.Substring(0, file.LastIndexOf("\\\\"));
            //删除临时目录下的所有文件
            DeleteFiles(tempPath);
            //删除空目录
            Directory.Delete(tempPath);
            Response.End();
        }
        private void DeleteFiles(string tempPath)
        {
            DirectoryInfo directory = new DirectoryInfo(tempPath);
            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (file.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    {
                        file.Attributes = FileAttributes.Normal;
                    }
                    File.Delete(file.FullName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected bool RAR(string DFilePath, string DRARName, string DRARPath)
        {
            String therar;
            RegistryKey theReg;
            Object theObj;
            String theInfo;
            ProcessStartInfo theStartInfo;
            Process theProcess;
            try
            {
                theReg = Registry.ClassesRoot.OpenSubKey(@"Applications\WinRAR.exe\Shell\Open\Command");
                theObj = theReg.GetValue("");
                therar = theObj.ToString();
                theReg.Close();
                therar = therar.Substring(1, therar.Length - 7);
                theInfo = " a    " + " " + DRARName + "  " + DFilePath + " -ep1"; //命令 + 压缩后文件名 + 被压缩的文件或者路径
                theStartInfo = new ProcessStartInfo();
                theStartInfo.FileName = therar;
                theStartInfo.Arguments = theInfo;
                theStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                theStartInfo.WorkingDirectory = DRARPath; //RaR文件的存放目录。
                theProcess = new Process();
                theProcess.StartInfo = theStartInfo;
                theProcess.Start();
                theProcess.WaitForExit();
                theProcess.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        private void RARSave(string rarPatch, string rarName)
        {
            string the_rar;
            RegistryKey the_Reg;
            Object the_Obj;
            string the_Info;
            ProcessStartInfo the_StartInfo;
            Process the_Process;
            try
            {
                the_Reg = Registry.ClassesRoot.OpenSubKey(@"WinRAR");
                the_Obj = the_Reg.GetValue("");
                the_rar = the_Obj.ToString();
                the_Reg.Close();
                the_rar = the_rar.Substring(1, the_rar.Length - 7);
                the_Info = " a " + rarName + " -r";
                the_StartInfo = new ProcessStartInfo();
                the_StartInfo.FileName = "WinRar";//the_rar;
                the_StartInfo.Arguments = the_Info;
                the_StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //打包文件存放目录
                the_StartInfo.WorkingDirectory = rarPatch;
                the_Process = new Process();
                the_Process.StartInfo = the_StartInfo;
                the_Process.Start();
                the_Process.WaitForExit();
                the_Process.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 下载生成的RAR文件
        /// </summary>
        private void DownloadRAR(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileInfo.Name);
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.AddHeader("Content-Transfer-Encoding", "binary");
            Response.ContentType = "application/octet-stream";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.WriteFile(fileInfo.FullName);
            Response.Flush();
            string tempPath = file.Substring(0, file.LastIndexOf("\\"));
            //删除临时目录下的所有文件
            DeleteFiles(tempPath);
            //删除空目录
            Directory.Delete(tempPath);
            Response.End();
        }
       
        
        //public static double getcount(string leibie)
        //{
        //    switch (leibie)
        //    {
        //        case "处级及以上干部":
        //            return 0.4;
        //            break;
        //        case "机关科级及以下干部":
        //            return 0.4;
        //            break;
        //        case "专业技术":
        //            return 0.4;
        //            break;
        //        case "工人":
        //            return 0.4;
        //            break;
        //    }
        //}
    }


    //Response.ContentEncoding= System.Text.Encoding.GetEncoding("GB2312");
    //        Response.ContentType = "application/msexcel";

    //        this.EnableViewState = false;

    //        Response.BinaryWrite(ms.ToArray());

    //        book = null;
    //        ms.Close();
    //        ms.Dispose();

}