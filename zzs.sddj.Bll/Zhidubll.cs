using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
namespace zzs.sddj.Bll
{
    public class Zhidubll
    {
        ZhiduDal zhidudal = new ZhiduDal();
        public List<ZhiduInfo> GetZhiduEntityList()
        {
            return zhidudal.Getzhidulist();
        }

        public ZhiduInfo GetModel(int id)
        {
            return zhidudal.GetEntityModel(id);
        }

        public int DeleteModel(int id)
        {
            return zhidudal.DeleteEntityModel(id);
        }
        public int InsertModel(ZhiduInfo zhiduinfo)
        {
            return zhidudal.InsertEntityModel(zhiduinfo);
        }

        public int UpdataModel(ZhiduInfo zhiduinfo)
        {
            return zhidudal.UpdataEntityModel(zhiduinfo);
        }
    }
}
