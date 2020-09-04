using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;
namespace zzs.sddj.Bll
{
    public class JuneiTrainInfoBll
    {
        JuneiTrainInfoDal jntraininfodal = new JuneiTrainInfoDal();
        public List<JuneiTrainInfo> GetEntityList()
        {
            return jntraininfodal.GetEntityList();
        }

        public JuneiTrainInfo GetEntityModel(int id)
        {
            return jntraininfodal.GetEntityModel(id);
        }
        public DataTable Getjninfo(int niandu)
        {
            return jntraininfodal.Getjninfo(niandu);
        }
        public DataTable GetEntityModel(string zhubanname)
        {
            return jntraininfodal.GetEntityModel(zhubanname);
        }
        public int InsertEntityModel(JuneiTrainInfo traininfo)
        {
            return jntraininfodal.InsertEntityModel(traininfo);
        }
        
        public int UpdataEntityModel(JuneiTrainInfo traininfo)
        {
            return jntraininfodal.UpdataEntityModel(traininfo);
        }

        public int deletejninfo(int id)
        {
            return jntraininfodal.deletejninfo(id);
        }
    }
}
