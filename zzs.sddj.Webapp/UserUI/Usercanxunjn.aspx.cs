using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class Usercanxunjn : System.Web.UI.Page
    {
        public int jnxf { get; set; }
        JuneiTrainBll jntrainbll = null;
        DataTable da = null;
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            jntrainbll = new JuneiTrainBll();
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            jnxf = jntrainbll.Getxuefentol(userloginame);
            da = new DataTable();
            da = jntrainbll.GetEntityModel(userloginame);
            userinfoall = new UserInfo_all();
            userinfoallbll = new UserInfo_allBll();
            userinfoall = userinfoallbll.GetEntityModel(userloginame);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void bttoexcel_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["userloginname"].ToString() == string.Empty)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string userloginame = HttpContext.Current.Session["userloginname"].ToString();
                jnxf = jntrainbll.Getxuefentol(userloginame);
                getExcel(da, userloginame);
            }
        }

        protected void getExcel(DataTable dt, string username)
        {

            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            IWorkbook workbook = new HSSFWorkbook();
            ICellStyle style = workbook.CreateCellStyle();
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Red.Index;
            style.FillPattern = FillPattern.SolidForeground;
            style.WrapText = true;
            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("局内培训情况表");

            NPOI.SS.UserModel.IRow row0 = sheet.CreateRow(0);


            row0.CreateCell(0).SetCellValue("姓名");
            row0.CreateCell(1).SetCellValue(username.ToString());
            row0.CreateCell(2).SetCellValue("所在单位");
            row0.CreateCell(3).SetCellValue(userinfoall.Danwei.ToString());
            row0.CreateCell(4).SetCellValue("职称");
            row0.CreateCell(5).SetCellValue(userinfoall.Zhuanji.ToString());

            IRow row1 = sheet.CreateRow(1);
            row1.CreateCell(0).SetCellValue("行政级别");
            row1.CreateCell(1).SetCellValue(userinfoall.Xzjb.ToString());

            IRow row2 = sheet.CreateRow(3);
            row2.CreateCell(0).SetCellValue("序号");
            row2.CreateCell(1).SetCellValue("培训名称");
            row2.CreateCell(2).SetCellValue("培训时间");
            row2.CreateCell(3).SetCellValue("培训学时");
            row2.CreateCell(4).SetCellValue("培训地点");
            row2.CreateCell(5).SetCellValue("培训主办");
            row2.CreateCell(6).SetCellValue("培训简介");
            row2.CreateCell(7).SetCellValue("培训备注");
            int itemp = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                NPOI.SS.UserModel.IRow rowtemp = sheet.CreateRow(i + 3);
                rowtemp.CreateCell(0).SetCellValue((i + 1).ToString());
                rowtemp.CreateCell(1).SetCellValue(dt.Rows[i]["Trainname"].ToString());
                rowtemp.CreateCell(2).SetCellValue(dt.Rows[i]["Traintime"].ToString());
                rowtemp.CreateCell(3).SetCellValue(dt.Rows[i]["Trainxueshi"].ToString());
                rowtemp.CreateCell(4).SetCellValue(dt.Rows[i]["Traindidian"].ToString());
                rowtemp.CreateCell(5).SetCellValue(dt.Rows[i]["Trainzhuban"].ToString());
                rowtemp.CreateCell(6).SetCellValue(dt.Rows[i]["Trainjianjie"].ToString());
                rowtemp.CreateCell(7).SetCellValue(dt.Rows[i]["Trainbeizhu"].ToString());
                itemp = i;
            }
            IRow row3 = sheet.CreateRow(itemp + 1 + 4);
            row3.CreateCell(0).SetCellValue("局内培训学时");
            row3.CreateCell(1).SetCellValue(jnxf.ToString());

            //写入到客户端  
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename=JuwaiTrain{0}.xls", DateTime.Now.ToString("yyyyMMddHHmmssfff")));
            Response.BinaryWrite(ms.ToArray());
            book = null;
            ms.Close();
            ms.Dispose();

        }
    }
}