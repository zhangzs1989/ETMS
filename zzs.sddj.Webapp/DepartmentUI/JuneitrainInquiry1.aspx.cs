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
    public partial class JuneitrainInquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string droplistvalue = this.DropDownList1.SelectedValue.ToString();
                //UserInfo_all userinfoall = null;
                
                switch (droplistvalue)
                {

                    case "山东省地震局":
                        for (int i = 0; i < leftListBox.Items.Count; i++)
                        {
                            leftListBox.Items.RemoveAt(i);
                            
                        }
                        UserInfo_allBll userinfoallbll = new UserInfo_allBll();
                        List<UserInfo_all> list = userinfoallbll.GetSanmeDanweiPerson(droplistvalue);
                        if (list.Count>0)
                        {
                            UserInfo_all userinfoall = new UserInfo_all();
                            for (int j=0;j<list.Count;j++)
                            {
                                
                                userinfoall = list[j];
                                leftListBox.Items.Add(userinfoall.Name);
                            }
                        }
                        break;
                    case "办公室":
                        for (int i = 0; i < leftListBox.Items.Count; i++)
                        {
                            leftListBox.Items.RemoveAt(i);
                        }
                        UserInfo_allBll userinfoallbll2 = new UserInfo_allBll();
                        List<UserInfo_all> list2 = userinfoallbll2.GetSanmeDanweiPerson(droplistvalue);
                        if (list2.Count > 0)
                        {
                            UserInfo_all userinfoall2 = new UserInfo_all();
                            for (int j = 0; j < list2.Count; j++)
                            {
                               
                                userinfoall2 = list2[j];
                                leftListBox.Items.Add(userinfoall2.Name);
                            }
                        }
                        break;
                }

            }


        }
    }
}