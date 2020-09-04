using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using zzs.sddj.Dal;
using zzs.sddj.Model;
namespace zzs.sddj.Bll
{
    public class wlxsbll
    {
        wlxsdal wlxsdal = new wlxsdal();
        public int InsertEntityModel(wlxs wlxsmodel)
        {
            return wlxsdal.InsertEntityModel(wlxsmodel);
        }
        public List<wlxs> Getwlxslist()
        {
            return wlxsdal.Getwlxslist();
        }
        public wlxs GetEntityModel(int id)
        {
            return wlxsdal.GetEntityModel(id);
        }
        public int DeleteEntityModel(int id)
        {
            return wlxsdal.DeleteEntityModel(id);
        }
        public DataTable GetDataTable(int niandu)
        {
            return wlxsdal.GetDataTable(niandu);
        }
        public wlxs GetModel(int year)
        {
            return wlxsdal.GetModel(year);
        }
    }
}
