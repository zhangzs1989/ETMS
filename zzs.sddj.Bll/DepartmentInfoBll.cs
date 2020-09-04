using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
namespace zzs.sddj.Bll
{
    public class DepartmentInfoBll
    {
        DepartmentLoginInfoDal departmentlogininfodal = new DepartmentLoginInfoDal();
        public List<DepartmentInfo> GetEntityList()
        {
            return departmentlogininfodal.GetEntityList();
        }

        public DepartmentInfo GetModel(int id)
        {
            return departmentlogininfodal.GetEntityModel(id);
        }

        public int InsertEntity(DepartmentInfo departmentinfo)
        {
            return departmentlogininfodal.InsertEntityModel(departmentinfo);
        }
        public int DeleteEntityModel(int id)
        {
            return departmentlogininfodal.DeleteEntityModel(id);
        }
        public int UpdataEntity(DepartmentInfo departmentinfo)
        {
            return departmentlogininfodal.UpdataEntityModel(departmentinfo);
        }

        
        public bool CheckDepartmentInfo(string username, string userpwd, out DepartmentInfo departmentinfo)
        {
            bool issucess = false;

            departmentinfo = departmentlogininfodal.GetDepartmentInfoModel(username, userpwd);

            if (departmentinfo != null)
            {
                if (departmentinfo.Departmentpwd == userpwd)
                {

                    issucess = true;
                }

            }
            return issucess;
        }
    }
}
