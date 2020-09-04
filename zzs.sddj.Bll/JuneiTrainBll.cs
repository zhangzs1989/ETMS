using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data;
using System.Collections;

namespace zzs.sddj.Bll
{
    public class JuneiTrainBll
    {
        JuneiTrainDal juneitraindal = new JuneiTrainDal();
        public List<JuneiTrain> GetEntityList()
        {
            return juneitraindal.GetEntityList();
        }
        public ArrayList GetEntityModelid(string trainname, string time)
        {
            return juneitraindal.GetEntityModelid(trainname, time);
        }
        public JuneiTrain GetEntityModel(int id)
        {
            return juneitraindal.GetEntityModel(id);
        }
        public int DeleteEntityModel(int id)
        {
            return juneitraindal.DeleteEntityModel(id);
        }
        public int UpdataEntityModel(JuneiTrain traininfo)
        {
            return juneitraindal.UpdataEntityModel(traininfo);
        }
        public int InsertEntityModel(JuneiTrain traininfo)
        {
            return juneitraindal.InsertEntityModel(traininfo);
        }

        public int Getxuefentol(string username,int niandu)
        {
            return juneitraindal.Getxuefentol(username,niandu);
        }

        public int Getxuefentol(string username)
        {
            return juneitraindal.Getxuefentol(username);
        }


        public DataTable GetEntityModel(string name)
        {
            return juneitraindal.GetEntityModel(name);
        }

        public JuneiTrain GetEntityModeltoJnt(string name)
        {
            return juneitraindal.GetEntityModeltoJnt(name);
        }

        public DataTable Getjn(int niandu)
        {
            return juneitraindal.Getjn(niandu);
        }
        public List<JuneiTrain> Getjnuserinfoall(string danweiid)
        {
            return juneitraindal.Getjnuserinfoall(danweiid);
        }
        public DataTable GetEntityModel(string name, int year)
        {
            return juneitraindal.GetEntityModel(name, year);
        }

        public string getnamefromid(int id)
        {
            return juneitraindal.getnamefromid(id);
        }
    }
}
