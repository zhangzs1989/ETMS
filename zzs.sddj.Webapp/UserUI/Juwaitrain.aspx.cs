using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp.UserUI
{
    public partial class Juwaitrain : System.Web.UI.Page
    {
        public string xueshimsg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnupfile_Click(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/html";
            string fileName = Path.GetFileName(this.homeworkFile.FileName);
            if (fileName == "")
            {
                Response.Write("<script language=javascript>alert('请添加材料');</" + "script>");
            }
            else
            {
                string newFileName = fileName.Substring(0, fileName.IndexOf('.')) + DateTime.Now.ToString("yyyyMMddhhmmss");
                newFileName += fileName.Substring(fileName.IndexOf('.'), fileName.Length - fileName.IndexOf('.'));

                string trainname = Context.Request.Form["peixunname"];
                string trainfs = Context.Request.Form["peixunfangshi"];
                string trainzhuban = Context.Request.Form["peixunzhuban"];
                string trainchengban = Context.Request.Form["peixunchengban"];
                string traintime = Context.Request.Form["peixunshijian"];
                int issucess = 0;
                Int32.TryParse(Context.Request.Form["peixunxueshi"], out issucess);
                if (issucess==0)
                {
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('输入学时有误，请输入正整数');", true);
                    xueshimsg = "输入值为正整数，请重新输入";
                   // Response.Redirect("Juwaitrain.aspx");
                }
               else
                {
                    int trainxueshi = Convert.ToInt32(Context.Request.Form["peixunxueshi"]);
                    string traindidian = Context.Request.Form["peixundidian"];
                    string trainneirong = Context.Request.Form["peixunneirong"];
                    TrainInfo traininfo = new TrainInfo();

                    traininfo.Username1 = HttpContext.Current.Request.Cookies["userloginame"].Value;
                    traininfo.Username1 = Session["userloginname"].ToString();

                    UserInfo_all userinfoall = new UserInfo_all();
                    UserInfo_allBll userinfoallbll = new UserInfo_allBll();
                    userinfoall = userinfoallbll.GetEntityModel(Session["userloginname"].ToString());
                    //DanweiInfo danweiinfo = new DanweiInfo();
                    DanweiInfoBll danweiinfobll = new DanweiInfoBll();
                    int danweiid = danweiinfobll.GetIDDanwei(userinfoall.Danwei.ToString());
                    traininfo.Bumenid1 = userinfoall.Danwei.ToString();
                    traininfo.Trainname = trainname;
                    traininfo.Trainfangshi = trainfs;
                    traininfo.Trainzhuban = trainzhuban;
                    traininfo.Trainchengban = trainchengban;
                    traininfo.Traintime = traintime;
                    traininfo.Trainxueshi = trainxueshi;
                    traininfo.Traindidian = traindidian;
                    traininfo.Trainneirong = trainneirong;
                    traininfo.Traincailiao = newFileName;
                    string Url = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"] + @"\" + newFileName;
                    if (this.IsFileSizeLessMax())
                    {

                        if (this.isTypeOk(Url))
                        {
                            string pathStr = ConfigurationManager.AppSettings["ResoursePath"] + ConfigurationManager.AppSettings["RESHomeworkContentPath"];
                            if (!Directory.Exists(pathStr))  //如果不存在路径
                            {
                                Directory.CreateDirectory(pathStr);    //创建路径
                            }
                            if (!Url.Equals(""))    //如果有上传文件
                            {
                                FileUpload fileUpLoad = new FileUpload();
                                //1.存放文件 
                                // fileUpLoad.SaveAs(Url);
                                homeworkFile.PostedFile.SaveAs(Url);

                            }
                        }
                    }
                    TrainBll trainbll = new TrainBll();
                    trainbll.InsertModel(traininfo);
                    Response.Write("<script language=javascript>alert('提交成功');</" + "script>");
                }
                    
                
                
            }
        }


        private bool IsFileSizeLessMax()
        {
            //返回值
            bool result = false;
            if (this.homeworkFile.HasFile)    //如果上传了文件
            {
                //获取上传文件的允许最大值
                long fileMaxSize = 1024 * 1024;
                try
                {
                    fileMaxSize *= int.Parse(ConfigurationManager.AppSettings["FileUploadMaxSize"].Substring(0, ConfigurationManager.AppSettings["FileUploadMaxSize"].Length - 1));
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                if (this.homeworkFile.PostedFile.ContentLength > int.Parse(fileMaxSize.ToString()))    //如果文件大小超过规定的最大值
                {
                    //this.ShowMessage("文件超过规定大小。");
                }
                else
                {
                    result = true;
                }
            }
            else    //如果没有上传的文件
            {
                result = true;
            }
            return result;
        }

        private bool isTypeOk(string fileName)
        {
            //返回结果
            bool endResult = false;
            //验证结果
            int result = 0;
            if (!fileName.Equals(""))    //如果有上传文件
            {
                //允许的文件类型
                string[] fileType = null;
                try
                {
                    fileType = ConfigurationManager.AppSettings["FileType"].Split(',');
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //Response.Write("<script language=javascript>alert('获取配置文件信息出错');</" + "script>");
                    //this.ShowMessage("获取配置文件信息出错");
                    //this.WriteException("AdminProtal:Homework", ex);
                }
                fileName = fileName.Substring(fileName.LastIndexOf('.'), fileName.Length - fileName.LastIndexOf('.'));
                for (int i = 0; i < fileType.Length; i++)
                {
                    if (fileType[i].Equals(fileName))    //如果是合法文件类型
                    {
                        result++;
                    }
                }
                if (result > 0)
                {
                    endResult = true;
                }
            }
            else    //如果没有上传文件
            {
                endResult = true;
            }
            return endResult;
        }
    }
}