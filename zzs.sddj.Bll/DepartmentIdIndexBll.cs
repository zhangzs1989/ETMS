using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
namespace zzs.sddj.Bll
{
    public class DepartmentIdIndexBll
    {
        DepartmentIdIndexDal departmentidindexdal = new DepartmentIdIndexDal();
        public List<DepartmentIdIndex> GetDepartmentidindexList()
        {
            return departmentidindexdal.GetDepartmentidindexList();
        }

        public DepartmentIdIndex GetEntityModel(int id)
        {
            return departmentidindexdal.GetEntityModel(id);
        }

        public int DeleteEntityModel(int id)
        {
            return departmentidindexdal.DeleteEntityModel(id);
        }

        public int UpdateEntityModel(DepartmentIdIndex departmentidindex)
        {
            return departmentidindexdal.UpdateEntityModel(departmentidindex);
        }
    }
}
