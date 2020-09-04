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
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.Util;
using NPOI.POIFS;
using NPOI.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.UserModel;

namespace zzs.sddj.Webapp.UserUI
{
    public partial class Usercanxunjw : System.Web.UI.Page
    {
        public int jwxf { get; set; }
        TrainBll jwtrainbll = null;
        DataTable da = null;
        UserInfo_all userinfoall = null;
        UserInfo_allBll userinfoallbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            jwtrainbll = new TrainBll();
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            jwxf =jwtrainbll.Getxuefentol(userloginame);
            da = new DataTable();
            //获得登录人员的所有局内培训信息，装入DataTable
            da = jwtrainbll.GetDataTable(userloginame);
            userinfoall = new UserInfo_all();
            userinfoallbll = new UserInfo_allBll();
            //在导出excel时需要人员的信息，增加了GetEntityModel，获得人员的信息类
            userinfoall = userinfoallbll.GetEntityModel(userloginame);
        }

        
        protected void bttoexcel_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["userloginname"].ToString()==string.Empty)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string userloginame = HttpContext.Current.Session["userloginname"].ToString();
                jwxf = jwtrainbll.Getxuefentol(userloginame);
                getExcel(da, userloginame);
            }
            

        }
        protected void getExcel(DataTable dt,string username)
        {
            
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            IWorkbook workbook = new HSSFWorkbook();
            ICellStyle style = workbook.CreateCellStyle();
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Red.Index;
            style.FillPattern = FillPattern.SolidForeground;
            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("局外脱产培训表");
            IRow rowhead = sheet.CreateRow(0);
            //sheet.SetColumnWidth(0, 100 * 256);
            rowhead.HeightInPoints = 30;
            rowhead.CreateCell(0).SetCellValue("山东省地震局教育培训个人档案表（2016年度）");
            SetCellRangeAddress(sheet, 0, 0, 0, 7);

            NPOI.SS.UserModel.IRow row1 = sheet.CreateRow(1);
            row1.CreateCell(0).SetCellValue("姓名");
            row1.CreateCell(1).SetCellValue(username.ToString());
            row1.CreateCell(2).SetCellValue("所在单位");
            row1.CreateCell(3).SetCellValue(userinfoall.Danwei.ToString());
            row1.CreateCell(4).SetCellValue("职称");
            row1.CreateCell(5).SetCellValue(userinfoall.Zhuanji.ToString());

            IRow row2 = sheet.CreateRow(2);
            row2.CreateCell(0).SetCellValue("行政级别");
            row2.CreateCell(1).SetCellValue(userinfoall.Xzjb.ToString());

            IRow row3 = sheet.CreateRow(3);
            row3.CreateCell(0).SetCellValue("序号");
            row3.CreateCell(1).SetCellValue("培训方式");
            row3.CreateCell(2).SetCellValue("培训活动名称");
            row3.CreateCell(3).SetCellValue("培训时间");
            row3.CreateCell(4).SetCellValue("培训学时");
            row3.CreateCell(5).SetCellValue("培训主办");
            row3.CreateCell(6).SetCellValue("培训地点");
            row3.CreateCell(7).SetCellValue("培训内容");
            int itemp =0;
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
            IRow row5 = sheet.CreateRow(itemp+1+4);
            row5.CreateCell(0).SetCellValue("局外脱产培训学时");
            row5.CreateCell(1).SetCellValue(jwxf.ToString());
            IRow row6 = sheet.CreateRow(itemp + 1 + 5);
            row6.CreateCell(0).SetCellValue("网络学时总计");
            row6.CreateCell(1).SetCellValue("60");
            IRow row7 = sheet.CreateRow(itemp + 1 + 7);
            row7.CreateCell(0).SetCellValue("参加教育培训情况年度鉴定（主管部门意见）");
            //IRow row8 = sheet.CreateRow(itemp + 1 + 8);
            SetCellRangeAddress(sheet, itemp + 1 + 7, itemp + 1 + 7, 1, 7);
            //写入到客户端  
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename=JuwaiTrain{0}.xls",DateTime.Now.ToString("yyyyMMddHHmmssfff")));
            Response.BinaryWrite(ms.ToArray());
            book = null;
            ms.Close();
            ms.Dispose();

        }

        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="sheet">要合并单元格所在的sheet</param>
        /// <param name="rowstart">开始行的索引</param>
        /// <param name="rowend">结束行的索引</param>
        /// <param name="colstart">开始列的索引</param>
        /// <param name="colend">结束列的索引</param>
        public static void SetCellRangeAddress(ISheet sheet, int rowstart, int rowend, int colstart, int colend)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(rowstart, rowend, colstart, colend);
            sheet.AddMergedRegion(cellRangeAddress);
            
        }
        
    }
}