using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
namespace zzs.sddj.Bll
{
    public class AdminLoginInfoBll
    {
        AdminLoginInfoDal adminlogininfodal = new AdminLoginInfoDal();
        public List<AdminLoginInfo> GetEntityList()
        {
            return adminlogininfodal.GetEntityList();
        }

        public AdminLoginInfo GetModel(int id)
        {
            return adminlogininfodal.GetEntityModel(id);
        }

        public int InsertEntity(AdminLoginInfo adminlogininfo)
        {
            return adminlogininfodal.InsertEntityModel(adminlogininfo);
        }

        public int UpdataEntity(AdminLoginInfo adminlogininfo)
        {
            return adminlogininfodal.UpdataEntityModel(adminlogininfo);
        }

        public AdminLoginInfo GetAdminInfoModel(string username, string userpwd)
        {
            return adminlogininfodal.GetAdminInfoModel(username, userpwd);
        }
        public int DeleteEntityModel(int id)
        {
            return adminlogininfodal.DeleteEntityModel(id);
        }
        /// <summary>
        /// 检查管理员用户名和密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <param name="admininfo"></param>
        /// <returns></returns>
        public bool CheckAdminInfo(string username, string userpwd, out AdminLoginInfo adminlogininfo)
        {
            bool issucess = false;

            adminlogininfo = adminlogininfodal.GetAdminInfoModel(username, userpwd);
            if (adminlogininfo != null)
            {
                if (adminlogininfo.Userpass == userpwd)
                {

                    issucess = true;
                }

            }
            return issucess;
        }
    }
}
