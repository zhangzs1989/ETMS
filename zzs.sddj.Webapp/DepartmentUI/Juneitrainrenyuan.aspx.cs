using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using zzs.sddj.Bll;
using zzs.sddj.Model;

namespace zzs.sddj.Webapp.DepartmentUI
{
    public partial class Juneitrainrenyuan : System.Web.UI.Page
    {
        static ArrayList arrRight = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                binddroplistdata();
            }

            //selectname();



        }

        private void binddroplistdata()
        {
            SqlConnection conn = new SqlConnection("uid=sa;pwd=zhangzs;database=mydb");
            SqlCommand cmd = new SqlCommand("select * from DanweiInfo", conn);
            //建立数据适配器、数据表并填充
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adpt.Fill(dtable);
            //★★与表的数据绑定★★
            DropDownList1.DataSource = dtable;//设置数据源
            DropDownList1.DataTextField = "Danwei";//设置所要读取的数据表里的列名
            DropDownList1.DataValueField = "Danwei";
            DropDownList1.DataBind();//数据绑定
        }

        //private void selectname()
        //{

        //    int[] leftlistboxselectitem;
        //    for (int i = 0; i < leftlistbox.Items.Count; i++)
        //    {
        //        if (leftlistbox.Items[i].Selected)
        //        {
        //            leftlistboxselectitem[j] = leftlistbox.Items;
        //        }
        //    }

        //    List<DanweiInfo> listdanwei = new List<DanweiInfo>();
        //    DanweiInfoBll danweiinfobll = new DanweiInfoBll();
        //    listdanwei = danweiinfobll.GetDanweiInfolist();
        //    DanweiInfo dw = null;
        //    string[] danweiname = null;
        //    int[] danweiid = null;

        //    string droplistvalue = null;
        //    if (DropDownList1.Items.Count - 1 < 0)
        //    {
        //        droplistvalue = "";
        //    }
        //    else
        //    {
        //        droplistvalue = DropDownList1.Items[DropDownList1.SelectedIndex].Text;
        //    }
        //    #region
        //    switch (droplistvalue)
        //    {

        //        case "山东省地震局":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll = new UserInfo_allBll();
        //            List<UserInfo_all> list = userinfoallbll.GetSanmeDanweiPerson(droplistvalue);
        //            if (list.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list.Count; j++)
        //                {

        //                    userinfoall = list[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }



        //            break;
        //        case "办公室":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll2 = new UserInfo_allBll();
        //            List<UserInfo_all> list2 = userinfoallbll2.GetSanmeDanweiPerson(droplistvalue);
        //            if (list2.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list2.Count; j++)
        //                {

        //                    userinfoall = list2[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
                   
        //            break;
        //        case "人事教育处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll3 = new UserInfo_allBll();
        //            List<UserInfo_all> list3 = userinfoallbll3.GetSanmeDanweiPerson(droplistvalue);
        //            if (list3.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list3.Count; j++)
        //                {

        //                    userinfoall = list3[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
                            
        //                }
        //            }

        //            break;
        //        case "发展与财务处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll4 = new UserInfo_allBll();
        //            List<UserInfo_all> list4 = userinfoallbll4.GetSanmeDanweiPerson(droplistvalue);
        //            if (list4.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list4.Count; j++)
        //                {

        //                    userinfoall = list4[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "科学技术处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll5 = new UserInfo_allBll();
        //            List<UserInfo_all> list5 = userinfoallbll5.GetSanmeDanweiPerson(droplistvalue);
        //            if (list5.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list5.Count; j++)
        //                {

        //                    userinfoall = list5[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "监测预报处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll6 = new UserInfo_allBll();
        //            List<UserInfo_all> list6 = userinfoallbll6.GetSanmeDanweiPerson(droplistvalue);
        //            if (list6.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list6.Count; j++)
        //                {

        //                    userinfoall = list6[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "震害防御处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll7 = new UserInfo_allBll();
        //            List<UserInfo_all> list7 = userinfoallbll7.GetSanmeDanweiPerson(droplistvalue);
        //            if (list7.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list7.Count; j++)
        //                {

        //                    userinfoall = list7[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "应急救援处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll8 = new UserInfo_allBll();
        //            List<UserInfo_all> list8 = userinfoallbll8.GetSanmeDanweiPerson(droplistvalue);
        //            if (list8.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list8.Count; j++)
        //                {

        //                    userinfoall = list8[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "纪检监察审计处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll9 = new UserInfo_allBll();
        //            List<UserInfo_all> list9 = userinfoallbll9.GetSanmeDanweiPerson(droplistvalue);
        //            if (list9.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list9.Count; j++)
        //                {

        //                    userinfoall = list9[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "机关党委":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll10 = new UserInfo_allBll();
        //            List<UserInfo_all> list10 = userinfoallbll10.GetSanmeDanweiPerson(droplistvalue);
        //            if (list10.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list10.Count; j++)
        //                {

        //                    userinfoall = list10[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "离退休干部处":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll11 = new UserInfo_allBll();
        //            List<UserInfo_all> list11 = userinfoallbll11.GetSanmeDanweiPerson(droplistvalue);
        //            if (list11.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list11.Count; j++)
        //                {

        //                    userinfoall = list11[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "财务室":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll12 = new UserInfo_allBll();
        //            List<UserInfo_all> list12 = userinfoallbll12.GetSanmeDanweiPerson(droplistvalue);
        //            if (list12.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list12.Count; j++)
        //                {

        //                    userinfoall = list12[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "宣传教育中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll13 = new UserInfo_allBll();
        //            List<UserInfo_all> list13 = userinfoallbll13.GetSanmeDanweiPerson(droplistvalue);
        //            if (list13.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list13.Count; j++)
        //                {

        //                    userinfoall = list13[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "地震预报研究中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll14 = new UserInfo_allBll();
        //            List<UserInfo_all> list14 = userinfoallbll14.GetSanmeDanweiPerson(droplistvalue);
        //            if (list14.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list14.Count; j++)
        //                {

        //                    userinfoall = list14[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "地震台网中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll15 = new UserInfo_allBll();
        //            List<UserInfo_all> list15 = userinfoallbll15.GetSanmeDanweiPerson(droplistvalue);
        //            if (list15.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list15.Count; j++)
        //                {

        //                    userinfoall = list15[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;
        //        case "地震监测中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll16 = new UserInfo_allBll();
        //            List<UserInfo_all> list16 = userinfoallbll16.GetSanmeDanweiPerson(droplistvalue);
        //            if (list16.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list16.Count; j++)
        //                {

        //                    userinfoall = list16[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "工程地震研究中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll17 = new UserInfo_allBll();
        //            List<UserInfo_all> list17 = userinfoallbll17.GetSanmeDanweiPerson(droplistvalue);
        //            if (list17.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list17.Count; j++)
        //                {

        //                    userinfoall = list17[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "地震应急保障中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll18 = new UserInfo_allBll();
        //            List<UserInfo_all> list18 = userinfoallbll18.GetSanmeDanweiPerson(droplistvalue);
        //            if (list18.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list18.Count; j++)
        //                {

        //                    userinfoall = list18[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "基建办":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll19 = new UserInfo_allBll();
        //            List<UserInfo_all> list19 = userinfoallbll19.GetSanmeDanweiPerson(droplistvalue);
        //            if (list19.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list19.Count; j++)
        //                {

        //                    userinfoall = list19[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "地震应急搜救中心":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll20 = new UserInfo_allBll();
        //            List<UserInfo_all> list20 = userinfoallbll20.GetSanmeDanweiPerson(droplistvalue);
        //            if (list20.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list20.Count; j++)
        //                {

        //                    userinfoall = list20[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "值班室":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll21 = new UserInfo_allBll();
        //            List<UserInfo_all> list21 = userinfoallbll21.GetSanmeDanweiPerson(droplistvalue);
        //            if (list21.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list21.Count; j++)
        //                {

        //                    userinfoall = list21[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "泰安基准地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll22 = new UserInfo_allBll();
        //            List<UserInfo_all> list22 = userinfoallbll22.GetSanmeDanweiPerson(droplistvalue);
        //            if (list22.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list22.Count; j++)
        //                {

        //                    userinfoall = list22[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "聊城地震水化试验站":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll23 = new UserInfo_allBll();
        //            List<UserInfo_all> list23 = userinfoallbll23.GetSanmeDanweiPerson(droplistvalue);
        //            if (list23.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list23.Count; j++)
        //                {

        //                    userinfoall = list23[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "青岛地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll24 = new UserInfo_allBll();
        //            List<UserInfo_all> list24 = userinfoallbll24.GetSanmeDanweiPerson(droplistvalue);
        //            if (list24.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list24.Count; j++)
        //                {

        //                    userinfoall = list24[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "烟台地震监测中心台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll25 = new UserInfo_allBll();
        //            List<UserInfo_all> list25 = userinfoallbll25.GetSanmeDanweiPerson(droplistvalue);
        //            if (list25.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list25.Count; j++)
        //                {

        //                    userinfoall = list25[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "长岛地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll26 = new UserInfo_allBll();
        //            List<UserInfo_all> list26 = userinfoallbll26.GetSanmeDanweiPerson(droplistvalue);
        //            if (list26.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list26.Count; j++)
        //                {

        //                    userinfoall = list26[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "莱阳地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll27 = new UserInfo_allBll();
        //            List<UserInfo_all> list27 = userinfoallbll27.GetSanmeDanweiPerson(droplistvalue);
        //            if (list27.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list27.Count; j++)
        //                {

        //                    userinfoall = list27[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "潍坊地震监测中心台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll28 = new UserInfo_allBll();
        //            List<UserInfo_all> list28 = userinfoallbll28.GetSanmeDanweiPerson(droplistvalue);
        //            if (list28.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list28.Count; j++)
        //                {

        //                    userinfoall = list28[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "昌邑地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll29 = new UserInfo_allBll();
        //            List<UserInfo_all> list29 = userinfoallbll29.GetSanmeDanweiPerson(droplistvalue);
        //            if (list29.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list29.Count; j++)
        //                {

        //                    userinfoall = list29[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "安丘地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll30 = new UserInfo_allBll();
        //            List<UserInfo_all> list30 = userinfoallbll30.GetSanmeDanweiPerson(droplistvalue);
        //            if (list30.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list30.Count; j++)
        //                {

        //                    userinfoall = list30[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "临沂地震监测中心台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll31 = new UserInfo_allBll();
        //            List<UserInfo_all> list31 = userinfoallbll31.GetSanmeDanweiPerson(droplistvalue);
        //            if (list31.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list31.Count; j++)
        //                {

        //                    userinfoall = list31[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "郯城马陵山地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll32 = new UserInfo_allBll();
        //            List<UserInfo_all> list32 = userinfoallbll32.GetSanmeDanweiPerson(droplistvalue);
        //            if (list32.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list32.Count; j++)
        //                {

        //                    userinfoall = list32[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "苍山地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll33 = new UserInfo_allBll();
        //            List<UserInfo_all> list33 = userinfoallbll33.GetSanmeDanweiPerson(droplistvalue);
        //            if (list33.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list33.Count; j++)
        //                {

        //                    userinfoall = list33[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "相公庄地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll34 = new UserInfo_allBll();
        //            List<UserInfo_all> list34 = userinfoallbll34.GetSanmeDanweiPerson(droplistvalue);
        //            if (list34.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list34.Count; j++)
        //                {

        //                    userinfoall = list34[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "沂水地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll35 = new UserInfo_allBll();
        //            List<UserInfo_all> list35 = userinfoallbll35.GetSanmeDanweiPerson(droplistvalue);
        //            if (list35.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list35.Count; j++)
        //                {

        //                    userinfoall = list35[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "菏泽地震监测中心台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll36 = new UserInfo_allBll();
        //            List<UserInfo_all> list36 = userinfoallbll36.GetSanmeDanweiPerson(droplistvalue);
        //            if (list36.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list36.Count; j++)
        //                {

        //                    userinfoall = list36[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "嘉祥地震监测中心台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll37 = new UserInfo_allBll();
        //            List<UserInfo_all> list37 = userinfoallbll37.GetSanmeDanweiPerson(droplistvalue);
        //            if (list37.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list37.Count; j++)
        //                {

        //                    userinfoall = list37[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "邹城地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll38 = new UserInfo_allBll();
        //            List<UserInfo_all> list38 = userinfoallbll38.GetSanmeDanweiPerson(droplistvalue);
        //            if (list38.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list38.Count; j++)
        //                {

        //                    userinfoall = list38[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "德州地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll39 = new UserInfo_allBll();
        //            List<UserInfo_all> list39 = userinfoallbll39.GetSanmeDanweiPerson(droplistvalue);
        //            if (list39.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list39.Count; j++)
        //                {

        //                    userinfoall = list39[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "五莲地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll40 = new UserInfo_allBll();
        //            List<UserInfo_all> list40 = userinfoallbll40.GetSanmeDanweiPerson(droplistvalue);
        //            if (list40.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list40.Count; j++)
        //                {

        //                    userinfoall = list40[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "陵阳地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll41 = new UserInfo_allBll();
        //            List<UserInfo_all> list41 = userinfoallbll41.GetSanmeDanweiPerson(droplistvalue);
        //            if (list41.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list41.Count; j++)
        //                {

        //                    userinfoall = list41[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "大山地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll42 = new UserInfo_allBll();
        //            List<UserInfo_all> list42 = userinfoallbll42.GetSanmeDanweiPerson(droplistvalue);
        //            if (list42.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list42.Count; j++)
        //                {

        //                    userinfoall = list42[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //        case "荣成地震台":
        //            IterationRemoveItem(leftlistbox);
        //            UserInfo_allBll userinfoallbll43 = new UserInfo_allBll();
        //            List<UserInfo_all> list43 = userinfoallbll43.GetSanmeDanweiPerson(droplistvalue);
        //            if (list43.Count > 0)
        //            {
        //                UserInfo_all userinfoall = new UserInfo_all();
        //                for (int j = 0; j < list43.Count; j++)
        //                {

        //                    userinfoall = list43[j];
        //                    leftlistbox.Items.Add(userinfoall.Name);
        //                }
        //            }
        //            break;

        //    }
            
        //    #endregion
        //}
        protected void add_Click(object sender, EventArgs e)
        {
            
            ArrayList arrRight = new ArrayList();
            //读取左边listbox的item的选中项    
            
            foreach (ListItem item in leftlistbox.Items)
            {
                if (item.Selected)
                {
                    arrRight.Add(item);
                }
            }
            //执行右移操作    
            foreach (ListItem item in arrRight)
            {
                this.rightlistbox.Items.Add(item);
                this.leftlistbox.Items.Remove(item);
            }

        }

        protected void remove_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        private void IterationRemoveItem(ListBox listbox)
        {
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                listbox.Items.RemoveAt(i);

            }

            for (int j = 0; j < listbox.Items.Count; j++)
            {
                IterationRemoveItem(listbox);
            }
        }
    }
    
}




//protected void Button1_Click(object sender, EventArgs e)
//{

//    ////string ceshi=leftlistbox.Items[0].Value;
//    ////string ceshi2 = leftlistbox.Items[1].Value;
//    //定义中间动态存储
//    //读取左边listbox的item的选中项    



//    //if (IsPostBack)
//    //{
//        //for (int i = 0; i < leftlistbox.Items.Count; i++)
//        //{
//        //    if (leftlistbox.Items[i].Selected)
//        //    {
//        //        rightlistbox.Items.Add(leftlistbox.Items[i].Value);
//        //        leftlistbox.Items.Remove(leftlistbox.Items[i].Value);
//        //        i--;
//        //    }
//        //}
//        //ArrayList arrRight = new ArrayList();
//        ////读取左边listbox的item的选中项    
//        //foreach (ListItem item in leftlistbox.Items)
//        //{
//        //    if (item.Selected)
//        //    {
//        //        arrRight.Add(item);
//        //    }
//        //}
//        ArrayList al2 = new ArrayList();
//        al2 = arrRight;
//        //执行右移操作    
//        foreach (ListItem item in arrRight)
//        {
//            this.rightlistbox.Items.Add(item);
//            this.leftlistbox.Items.Remove(item);
//        }
//    //}


//}
//private void AddItemFromSourceListBox(ListBox sourceBox, ListBox targetBox)
//{
//    foreach (ListItem item in sourceBox.Items)
//    {
//        if (item.Selected && !targetBox.Items.Contains(item))
//        {
//            targetBox.Items.Add(item);
//        }
//    }
//}
//protected void Button2_Click(object sender, EventArgs e)
//{
//    for (int i = 0; i < leftlistbox.Items.Count; i++)
//    {
//        if (leftlistbox.Items[i].Selected)
//        {
//            rightlistbox.Items.Add(leftlistbox.Items[i].Value);
//            leftlistbox.Items.Remove(leftlistbox.Items[i].Value);
//            i--;
//        }
//    }
//}

//protected void leftlistboxselect(object sender, EventArgs e)
//{
//    ArrayList arrRight = new ArrayList();
//    //读取左边listbox的item的选中项    
//    foreach (ListItem item in leftlistbox.Items)
//    {
//        if (item.Selected)
//        {
//            arrRight.Add(item);
//        }
//    }

//}

