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

namespace zzs.sddj.Webapp.AdminUI
{
    public partial class Downloadjwtrain : System.Web.UI.Page
    {
        TrainBll trainbll = null;
        TrainBll jwtrainbll = null;
        DataTable jwda = null;
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

        protected void getExcel(DataTable dt, int year)
        {
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            NPOI.SS.UserModel.IWorkbook workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
            ICellStyle style = workbook.CreateCellStyle();
            IFont font = workbook.CreateFont();
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Red.Index;
            style.FillPattern = FillPattern.SolidForeground;
            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("局外培训情况汇总表");
            IRow rowhead = sheet.CreateRow(0);//创建一行

            //sheet.SetColumnWidth(0, 100 * 256);
            style.Alignment = HorizontalAlignment.Center;


            font.FontHeightInPoints = 20;
            font.FontHeight = 24;
            rowhead.CreateCell(0).CellStyle.Alignment = HorizontalAlignment.Center;
            rowhead.CreateCell(0).CellStyle.SetFont(font);
            rowhead.CreateCell(0).SetCellValue("山东省地震局局外培训情况汇总表");
            rowhead.HeightInPoints = 30;

            SetCellRangeAddress(sheet, 0, 0, 0, 7);
            NPOI.SS.UserModel.IRow row1 = sheet.CreateRow(1);
            row1.CreateCell(0).SetCellValue("序号");
            row1.CreateCell(1).SetCellValue("部门");
            row1.CreateCell(2).SetCellValue("培训名称");
            row1.CreateCell(3).SetCellValue("培训类别");
            row1.CreateCell(4).SetCellValue("培训人");
            row1.CreateCell(5).SetCellValue("培训主办");
            row1.CreateCell(6).SetCellValue("培训年度");
            row1.CreateCell(7).SetCellValue("培训时间");
            row1.CreateCell(8).SetCellValue("培训学时");

            int itemp = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                NPOI.SS.UserModel.IRow rowtemp = sheet.CreateRow(i + 2);
                rowtemp.CreateCell(0).SetCellValue((i + 1).ToString());
                rowtemp.CreateCell(1).SetCellValue(dt.Rows[i]["Bumenid"].ToString());
                rowtemp.CreateCell(2).SetCellValue(dt.Rows[i]["Trainname"].ToString());
                rowtemp.CreateCell(3).SetCellValue(dt.Rows[i]["Trainfangshi"].ToString());
                rowtemp.CreateCell(4).SetCellValue(dt.Rows[i]["Username"].ToString());
                rowtemp.CreateCell(5).SetCellValue(dt.Rows[i]["Trainzhuban"].ToString());
                rowtemp.CreateCell(6).SetCellValue(dt.Rows[i]["Trainniandu"].ToString());
                rowtemp.CreateCell(7).SetCellValue(dt.Rows[i]["Traintime"].ToString());
                rowtemp.CreateCell(8).SetCellValue(dt.Rows[i]["Trainxueshi"].ToString());
                itemp = i;
            }
            string saveFileName = Server.MapPath("/juwaitrain");
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                book.Write(ms);
                using (FileStream fs = new FileStream(saveFileName + "\\" + year.ToString() + "年局外教育培训汇总表" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xls", FileMode.Create,FileAccess.ReadWrite))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
                book = null;
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(niandu.Value);
            jwtrainbll = new TrainBll();
            DataTable dt = new DataTable();
            dt = jwtrainbll.GetDataTable(year);
            getExcel(dt, year);
            string serverPath = Server.MapPath("/");

            //创建临时文件夹
            string tempName = "juwaitemporaryfile";
            string tempFolder = Path.Combine(serverPath, tempName);
            Directory.CreateDirectory(tempFolder);

            string serverPath2 = Server.MapPath("/juwaitrain");
            DirectoryInfo folder = new DirectoryInfo(serverPath2);
            foreach (FileInfo file in folder.GetFiles())
            {
                string filename = file.Name;
                File.Copy(serverPath2 + "/" + filename, tempFolder + "/" + filename);
            }

            compressFiles(tempFolder, tempFolder + "\\\\" + tempName + ".rar");
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


    }
}