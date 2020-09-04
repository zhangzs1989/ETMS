using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.SessionState;
using zzs.sddj.Model;
namespace zzs.sddj.Webapp
{
    /// <summary>
    /// UserIndex 的摘要说明
    /// </summary>
    public class UserIndex : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            string filepath = context.Request.MapPath("Userindex.html");
            string filecontent = File.ReadAllText(filepath);
            HttpBrowserCapabilities bc = HttpContext.Current.Request.Browser;
            string userloginame = HttpContext.Current.Session["userloginname"].ToString();
            //string userloginame = HttpContext.Current.Request.Cookies["userloginame"].Value;
            //UserInfo userinfo = HttpContext.Current.Session["userinfo"] as new UserInfo();
            filecontent = filecontent.Replace("$browertype", bc.Browser).Replace("$browerversion", bc.Version).Replace("$UserDomainName", GetOSVersion()).Replace("$clientip", GetIPAddress).Replace("$loginlastertime", DateTime.Now.ToLocalTime().ToString()).Replace("$admin",userloginame.ToString());
            
            context.Response.Write(filecontent);
            
        }
        /// <summary>
        /// 系统版本号
        /// </summary>
        /// <returns></returns>
        public static string GetOSVersion()
        {
            //UserAgent   
            var userAgent = HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"];

            var osVersion = "未知";

            if (userAgent.Contains("NT 6.1"))
            {
                osVersion = "Windows 7";
            }
            else if (userAgent.Contains("NT 6.0"))
            {
                osVersion = "Windows Vista/Server 2008";
            }
            else if (userAgent.Contains("NT 5.2"))
            {
                osVersion = "Windows Server 2003";
            }
            else if (userAgent.Contains("NT 5.1"))
            {
                osVersion = "Windows XP";
            }
            else if (userAgent.Contains("NT 5"))
            {
                osVersion = "Windows 2000";
            }
            else if (userAgent.Contains("NT 4"))
            {
                osVersion = "Windows NT4";
            }
            else if (userAgent.Contains("Me"))
            {
                osVersion = "Windows Me";
            }
            else if (userAgent.Contains("98"))
            {
                osVersion = "Windows 98";
            }
            else if (userAgent.Contains("95"))
            {
                osVersion = "Windows 95";
            }
            else if (userAgent.Contains("Mac"))
            {
                osVersion = "Mac";
            }
            else if (userAgent.Contains("Unix"))
            {
                osVersion = "UNIX";
            }
            else if (userAgent.Contains("Linux"))
            {
                osVersion = "Linux";
            }
            else if (userAgent.Contains("SunOS"))
            {
                osVersion = "SunOS";
            }
            return osVersion;
        }  
        /// <summary>
        /// 客户端IP
        /// </summary>
        /// <returns></returns>
        public static string GetIP()
        {
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            if (string.IsNullOrEmpty(result))
            {
                return "0.0.0.0";
            }
            return result;
        }

        public static bool IsIPAddress(string str1)
        {
            if (string.IsNullOrEmpty(str1) || str1.Length < 7 || str1.Length > 15) return false;

            const string regFormat = @"^d{1,3}[.]d{1,3}[.]d{1,3}[.]d{1,3}$";

            var regex = new Regex(regFormat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str1);
        }  

        /// <summary>
        /// 客户端真实IP
        /// </summary>
        public static string GetIPAddress
        {
            get
            {
                var result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(result))
                {
                    //可能有代理    
                    if (result.IndexOf(".") == -1)        //没有“.”肯定是非IPv4格式    
                        result = null;
                    else
                    {
                        if (result.IndexOf(",") != -1)
                        {
                            //有“,”，估计多个代理。取第一个不是内网的IP。    
                            result = result.Replace("  ", "").Replace("'", "");
                            string[] temparyip = result.Split(",;".ToCharArray());
                            for (int i = 0; i < temparyip.Length; i++)
                            {
                                if (IsIPAddress(temparyip[i])
                                        && temparyip[i].Substring(0, 3) != "10."
                                        && temparyip[i].Substring(0, 7) != "192.168"
                                        && temparyip[i].Substring(0, 7) != "172.16.")
                                {
                                    return temparyip[i];        //找到不是内网的地址    
                                }
                            }
                        }
                        else if (IsIPAddress(result))  //代理即是IP格式    
                            return result;
                        else
                            result = null;        //代理中的内容  非IP，取IP    
                    }

                }

                string IpAddress = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["HTTP_X_REAL_IP"];

                if (string.IsNullOrEmpty(result))
                    result = HttpContext.Current.Request.ServerVariables["HTTP_X_REAL_IP"];

                if (string.IsNullOrEmpty(result))
                    result = HttpContext.Current.Request.UserHostAddress;

                return result;
            }
        }

        /// <summary>
        /// 公网IP
        /// </summary>
        /// <returns></returns>
        public static string GetNetIP()  
       {  
           string tempIP = "";  
           try  
           {  
               System.Net.WebRequest wr = System.Net.WebRequest.Create("http://city.ip138.com/ip2city.asp");  
               System.IO.Stream s = wr.GetResponse().GetResponseStream();  
               System.IO.StreamReader sr = new System.IO.StreamReader(s, System.Text.Encoding.GetEncoding("gb2312"));  
               string all = sr.ReadToEnd(); //读取网站的数据  
  
               int start = all.IndexOf("[") + 1;  
               int end = all.IndexOf("]", start);  
               tempIP = all.Substring(start, end - start);  
               sr.Close();  
               s.Close();  
           }  
           catch  
           {  
               if (System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.Length > 1)  
                   tempIP = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[1].ToString();  
               if (string.IsNullOrEmpty(tempIP))  
                   return GetIP();  
           }  
           return tempIP;  
       }  
       


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
     
}