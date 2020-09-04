using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace zzs.sddj.Webapp.AdminUI
{
    /// <summary>
    /// AdminXiuGaiMiMa1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class AdminXiuGaiMiMa1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string IsCorrectPass(string username, string password)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            string word = "";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(string.Format("select password from AdminInfo where UserName='{0}'", username), conn))
                {
                    conn.Open();
                    word = cmd.ExecuteScalar().ToString();
                    if (word == password)
                    {
                        return "密码正确";
                    }
                    else
                    {
                        return "密码错误";
                    }
                }
            }
        }
    }
}
