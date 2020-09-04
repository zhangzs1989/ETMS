using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;

namespace zzs.sddj.Bll
{
    public class TrainBll
    {
        TrainInfoDal traininfodal = new TrainInfoDal();
        public List<TrainInfo> GetEntityList()
        {
            return traininfodal.GetEntityList();
        }

        public TrainInfo GetModel(int id)
        {
            return traininfodal.GetEntityModel(id);
        }

        public int DeleteModel(int id)
        {
            return traininfodal.DeleteEntityModel(id);
        }
        public DataTable GetDataTable(int niandu)
        {
            return traininfodal.GetDataTable(niandu);
        }
        public int InsertModel(TrainInfo traininfo)
        {
            return traininfodal.InsertEntityModel(traininfo);
        }

        public int UpdataModel(TrainInfo traininfo)
        {
            return traininfodal.UpdataEntityModel(traininfo);
        }

        public int Getxuefentol(string username,int niandu)
        {
            return traininfodal.Getxuefentol(username,niandu);
        }

        public int Getxuefentol(string username)
        {
            return traininfodal.Getxuefentol(username);
        }

        public DataTable GetDataTable(string name)
        {
            return traininfodal.GetDataTable(name);
        }
        public DataTable GetDataTable(string name, int year)
        {
            return traininfodal.GetDataTable(name, year);
        }
    }
}
