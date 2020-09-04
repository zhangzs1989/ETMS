using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;
namespace zzs.sddj.Bll
{
    public class EtmsplalBLL
    {
        EtmsplasDal etmsplandal = new EtmsplasDal();
        public List<Etmsplas> Getplanlist()
        {
            return etmsplandal.Getzhidulist();
        }

        public List<Etmsplas> Getzhidulist(int niandu)
        {
            return etmsplandal.Getzhidulist(niandu);
        }
        public Etmsplas GetEntityModel(int id)
        {
            return etmsplandal.GetEntityModel(id);
        }

        public int DeleteEntityModel(int id)
        {
            return etmsplandal.DeleteEntityModel(id);
        }

        public int UpdataEntityModel(Etmsplas plan)
        {
            return etmsplandal.UpdataEntityModel(plan);
        }
        public int InsertEntityModel(Etmsplas plan)
        {
            return etmsplandal.InsertEntityModel(plan);
        }
    }
}
