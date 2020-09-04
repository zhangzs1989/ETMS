using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;

namespace zzs.sddj.Bll
{
    public class DanweiInfoBll
    {
        zzs.sddj.Dal.DanweiInfoDal danweiinfodal = new Dal.DanweiInfoDal();
        public List<DanweiInfo> GetDanweiInfolist()
        {
            return danweiinfodal.GetDanweiInfolist();
        }
        public DanweiInfo GetEntityModel(int id)
        {
            return danweiinfodal.GetEntityModel(id);
        }
        public int DeleteEntityModel(int id)
        {
            return danweiinfodal.DeleteEntityModel(id);
        }

        public int UpdataEntityModel(DanweiInfo danweiinfo)
        {
            return danweiinfodal.UpdataEntityModel(danweiinfo);
        }
        public int InsertEntityModel(DanweiInfo danweiinfo)
        {
            return danweiinfodal.InsertEntityModel(danweiinfo);
        }
        public string GetDanweiInfoID(string danwei)
        {
            return danweiinfodal.GetDanweiInfoID(danwei);
        }
        public DataTable GetDanweiRows()
        {
            return danweiinfodal.GetDanweiRows();
        }
        public DanweiInfo GetEntityModel(string name)
        {
            return danweiinfodal.GetEntityModel(name);
        }
        public int GetIDDanwei(string name)
        {
            return danweiinfodal.GetIDDanwei(name);
        }
    }
}
