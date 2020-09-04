using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Dal;
using zzs.sddj.Model;
namespace zzs.sddj.Bll
{
    public class JibieBll
    {
        JibieDal jibiedal = new JibieDal();
        public List<Jiebie> GetJibielist()
        {
            return jibiedal.GetJibielist();
        }
        public Jiebie GetEntityModel(int id)
        {
            return jibiedal.GetEntityModel(id);
        }
        public Jiebie GetEntityModel(string name)
        {
            return jibiedal.GetEntityModel(name);
        }
        public int DeleteEntityModel(int id)
        {
            return jibiedal.DeleteEntityModel(id);
        }
        public int UpdataEntityModel(Jiebie jibie)
        {
            return jibiedal.UpdataEntityModel(jibie);
        }
        public int InsertEntityModel(Jiebie jibie)
        {
            return jibiedal.InsertEntityModel(jibie);
        }
    }
}
