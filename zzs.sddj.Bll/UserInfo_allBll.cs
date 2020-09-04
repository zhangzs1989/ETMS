using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;

namespace zzs.sddj.Bll
{
    public class UserInfo_allBll
    {
        UserInfo_allDal userinfoalldal = new UserInfo_allDal();
        public List<zzs.sddj.Model.UserInfo_all> GetEntitylist()
        {
            return userinfoalldal.GetEntitylist();
        }

        public zzs.sddj.Model.UserInfo_all GetEntityModel(int id)
        {
            return userinfoalldal.GetEntityModel(id);
        }

        public int DeleteEntityModel(int id)
        {
            return userinfoalldal.DeleteEntityModel(id);
        }

        public int UpdateEntityModel(UserInfo_all userinfoall)
        {
            return userinfoalldal.UpdateEntityModel(userinfoall);
        }

        public int InsertEntityModel(UserInfo_all userinfoall)
        {
            return userinfoalldal.InsertEntityModel(userinfoall);
        }

        public UserInfo_all CheckBumenidFromUserInfo_all(string username)
        {
            return userinfoalldal.CheckBumenidFromUserInfo_all(username);
        }
        public List<UserInfo_all> GetSanmeDanweiPerson(string danwei)
        {
            return userinfoalldal.GetSanmeDanweiPerson(danwei);
        }
        public zzs.sddj.Model.UserInfo_all GetEntityModel(string name)
        {
            return userinfoalldal.GetEntityModel(name);
        }

        public DataSet GetEntityds(string danweiname)
        {
            return userinfoalldal.GetEntityds(danweiname);
        }
        public DataSet GetEntityds()
        {
            return userinfoalldal.GetEntityds();
        }
        public int isexistuser(string name)
        {
            return userinfoalldal.isexistuser(name);
        }
    }
}
