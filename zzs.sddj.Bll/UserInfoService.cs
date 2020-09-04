using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Dal;
using zzs.sddj.Model;
using System.Web;
namespace zzs.sddj.Bll
{
    public class UserInfoService
    {
        /// <summary>
        /// 列表展示
        /// </summary>
        UserInfoDal UserInfoDal = new UserInfoDal();
        public List<UserInfo> GetEntityList()
        {
            return UserInfoDal.GetEntityList();
        }

        /// <summary>
        /// 返回一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetModel(int id)
        {
            return UserInfoDal.GetEntityModel(id);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEntity(int id)
        {
            return UserInfoDal.DeleteEntityModel(id);
        }
        public UserInfo GetEntityModel(string name)
        {
            return UserInfoDal.GetEntityModel(name);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int InsertEntity(UserInfo userinfo)
        {
            return UserInfoDal.InsertEntityModel(userinfo);
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int UpdataEntity(UserInfo userinfo)
        {
            return UserInfoDal.UpdataEntityModel(userinfo);
        }

        public int UpdataEntity(AdminLoginInfo userinfo)
        {
            return UserInfoDal.UpdataEntityModel(userinfo);
        }

        public int UpdataEntity(DepartmentInfo userinfo)
        {
            return UserInfoDal.UpdataEntityModel(userinfo);
        }


        public UserInfo GetUserInfoModel(string username,string userpwd)
        {
            return UserInfoDal.GetUserInfoModel(username,userpwd);
        }

        public DepartmentInfo GetdepartmentInfoModel(string username, string userpwd)
        {
            return UserInfoDal.GetdepartmentModel(username, userpwd);
        }

        public AdminLoginInfo GetAdminInfoModel(string username, string userpwd)
        {
            return UserInfoDal.GetAdminInfoModel(username, userpwd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool CheckUserInfo(string username, string userpwd,out UserInfo userinfo)
        {
            bool issucess = false;
            
            userinfo = UserInfoDal.GetUserInfoModel(username, userpwd);
            if (userinfo != null)
            {
                if (userinfo.Userpass == userpwd)
                {
                    
                    issucess = true;
                }
                
            }
            return issucess;
            //if (issucess)
            //{
            //    msg = "登陆成功";
            //}
            //else
            //{
            //    msg="用户名和密码不正确";
                
            //    //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(msg);</script>");
            //}
            //return issucess;
            
        }

        /// <summary>
        /// 检查管理员用户名和密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <param name="admininfo"></param>
        /// <returns></returns>
        public bool CheckAdminInfo(string username, string userpwd, out AdminLoginInfo admininfo)
        {
            bool issucess = false;

            admininfo = UserInfoDal.GetAdminInfoModel(username, userpwd);
            if (admininfo != null)
            {
                if (admininfo.Userpass == userpwd)
                {

                    issucess = true;
                }

            }
            return issucess;
        }

        public bool CheckDepartmentInfo(string username, string userpwd, DepartmentInfo userinfo)
        {
            bool issucess = false;

            
            userinfo = UserInfoDal.GetdepartmentModel(username, userpwd);
            if (userinfo != null)
            {
                if (userinfo.Departmentpwd == userpwd)
                {

                    issucess = true;
                }

            }
            return issucess;
        }

    }
}
