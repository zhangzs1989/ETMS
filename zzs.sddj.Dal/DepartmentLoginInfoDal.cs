using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;

namespace zzs.sddj.Dal
{
    public class DepartmentLoginInfoDal
    {
        public List<DepartmentInfo> GetEntityList()
        {
            string sql = "select *from DepartmentLoginInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<DepartmentInfo> list = null;
            if (da.Rows.Count>0)
            {
                list = new List<DepartmentInfo>();
                foreach (DataRow row in da.Rows)
                {
                    DepartmentInfo departmentinfo = new DepartmentInfo();
                    LoadEntity(row, departmentinfo);
                }
            }
            return list;
        }

        public DepartmentInfo GetEntityModel(int id)
        {
            string sql = "select *from DepartmentLoginInfo where ID=@ID";
            DataTable da=SqlHelper.GetTable(sql,CommandType.Text,new SqlParameter("ID",id));
            DepartmentInfo departmentinfo=null;
            if (da.Rows.Count>0)
            {
                departmentinfo=new DepartmentInfo();
                LoadEntity(da.Rows[0], departmentinfo);
            }
	        return departmentinfo;
        }


        public int DeleteEntityModel(int id)
        {
            string sql = "delete from DepartmentLoginInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(DepartmentInfo departmentinfo)
        {
            string sql = "update DepartmentLoginInfo set Departmentloginname=@Departmentloginname,Departmentpwd=@Departmentpwd where ID=@ID";

            SqlParameter[] pars = { 
                                    new SqlParameter("@Departmentloginname",departmentinfo.Departmentloginname),
                                    new SqlParameter("@Departmentpwd",departmentinfo.Departmentpwd),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment),
                                    new SqlParameter("@ID",departmentinfo.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(DepartmentInfo departmentinfo)
        {
            string sql = "insert into DepartmentLoginInfo(Departmentloginname,Departmentpwd)values(@Departmentloginname,@Departmentpwd)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Departmentloginname",departmentinfo.Departmentloginname),
                                    new SqlParameter("@Departmentpwd",departmentinfo.Departmentpwd),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);

        }

        public DepartmentInfo GetDepartmentInfoModel(string username, string userpwd)
        {
            string sql = "select *from DepartmentLoginInfo where Departmentloginname=@Departmentloginname and Departmentpwd=@Departmentpwd";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Departmentloginname",username),
                                    new SqlParameter("@Departmentpwd",userpwd)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            DepartmentInfo departmentinfo = null;
            if (da.Rows.Count > 0)
            {
                departmentinfo = new DepartmentInfo();
                LoadEntity(da.Rows[0], departmentinfo);
            }
            return departmentinfo;
        }

        public void LoadEntity(DataRow row, DepartmentInfo departmentinfo)
        {
            departmentinfo.Id = Convert.ToInt32(row["ID"]);
            departmentinfo.Departmentloginname = row["Departmentloginname"] != DBNull.Value ? row["Departmentloginname"].ToString() : string.Empty;
            departmentinfo.Departmentpwd = row["Departmentpwd"] != DBNull.Value ? row["Departmentpwd"].ToString() : string.Empty;
        }
    }
}
