using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
namespace zzs.sddj.Bll
{
    public class Xlxwbll
    {
        XuelixueweiDal xlxwdal = new XuelixueweiDal();
        public List<Xuelixuewei> GetEntityList()
        {
            return xlxwdal.GetEntitylist();
        }

        public Xuelixuewei GetModel(int id)
        {
            return xlxwdal.GetEntityModel(id);
        }

        public int DeleteModel(int id)
        {
            return xlxwdal.DeleteEntityModel(id);
        }

        public int UpdataModel(Xuelixuewei xlxw)
        {
            return xlxwdal.UpdateEntityModel(xlxw);
        }

        public int InsertModel(Xuelixuewei xlxw)
        {
            return xlxwdal.InsertEntityModel(xlxw);
        }
    }
}
