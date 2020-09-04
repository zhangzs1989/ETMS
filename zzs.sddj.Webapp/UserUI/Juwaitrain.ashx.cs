using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zzs.sddj.Model;
using zzs.sddj.Bll;
namespace zzs.sddj.Webapp
{
    /// <summary>
    /// Juwaitrain 的摘要说明
    /// </summary>
    public class Juwaitrain : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string trainname = context.Request.Form["peixunname"];
            string trainfs = context.Request.Form["peixunfangshi"];
            string trainzhuban=context.Request.Form["peixunzhuban"];
            string trainchengban=context.Request.Form["peixunchengban"];
            string traintime=context.Request.Form["peixunshijian"];
            int trainxueshi = Convert.ToInt32(context.Request.Form["peixunxueshi"]);
            string traindidian=context.Request.Form["peixundidian"];
            string trainneirong=context.Request.Form["peixunneirong"];
            TrainInfo traininfo = new TrainInfo();
            traininfo.Trainname = trainname;
            traininfo.Trainfangshi = trainfs;
            traininfo.Trainzhuban = trainzhuban;
            traininfo.Trainchengban = trainchengban;
            traininfo.Traintime = traintime;
            traininfo.Trainxueshi = trainxueshi;
            traininfo.Traindidian = traindidian;
            traininfo.Trainneirong = trainneirong;
            traininfo.Traincailiao = "@E:\\人事处工作-张正帅\\2016招聘\\已统计总和";
            //traininfo.Trainzhaopian = "@E:\\人事处工作-张正帅\\2016招聘\\已统计总和";
            
            //HttpPostedFile sn = context.Request.Files["shangchuanwenjian"];
            //string filename = System.IO.Path.GetFileName(sn.FileName);
            //if (filename!="")
            //{
            //    string fileextent = System.IO.Path.GetExtension(filename);
            //    string new_filename = DateTime.Now.ToString("yyyt-mm-dd") + fileextent;
                
            //}
            //string newsn = DateTime.Now.ToString("yyyy-MM-dd") + System.IO.Path.Combine(@"F:\周晨数据",sn.FileName);
            //context.Request.Files["shangchuanwenjian"].SaveAs(DateTime.Now.ToString("yyyy-MM-dd"));
            TrainBll trainbll = new TrainBll();
            trainbll.InsertModel(traininfo);
            context.Response.Write("<script language=javascript>alert('第一种弹出框');</" + "script>"); 
            //Context.Response.Write("<javascript>alert('提交成功');</javascript>");
            //context.Response.Write("<script>alert('alert('提交成功')');</script>");
            //context.Response.Redirect("Juwaitrain.htm");
            //context.Response.Write(sn);
            //context.Response.Write(trainname+trainfs+trainzhuban+trainchengban+traintime+trainxueshi+traindidian+trainneirong);
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