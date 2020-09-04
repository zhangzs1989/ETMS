using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;
namespace zzs.sddj.Dal
{
    public class DepartmentIdIndexDal
    {
        public List<DepartmentIdIndex> GetDepartmentidindexList()
        {
            string sql = "select *from DepartmentIdIndex";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<DepartmentIdIndex> list = null;
            DepartmentIdIndex departmentidindex = null;
            if (da.Rows.Count>0)
            {
                list = new List<DepartmentIdIndex>();
                foreach (DataRow row in da.Rows)
                {
                    departmentidindex = new DepartmentIdIndex();
                    LoadDepartmentIdIndex(row, departmentidindex);
                }
            }

            return list;
        }

        public DepartmentIdIndex GetEntityModel(int id)
        {
            string sql = "select *from DepartmentIdIndex where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            DepartmentIdIndex departmentidindex=null;
            if (da.Rows.Count>0)
	        {
		        departmentidindex=new DepartmentIdIndex();
                LoadDepartmentIdIndex(da.Rows[0],departmentidindex);
	        }
            return departmentidindex;
        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from DepartmentIdIndex where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdateEntityModel(DepartmentIdIndex departmentidindex)
        {
            string sql="update DepartmentIdIndex set DepartmentID=@DepartmentID,DepartmentLoginname=@DepartmentLoginname,where ID=@ID";
            SqlParameter[] pars={
                                    new SqlParameter("@DepartmentID",departmentidindex.Departmentid),
                                    new SqlParameter("@DepartmentLoginname",departmentidindex.Departmentloginname),
                                    new SqlParameter("@ID",departmentidindex.Id)
                                };
            return SqlHelper.ExecuteNonQuery(sql,CommandType.Text,pars);
        }

        public int InsertEntityModel(DepartmentIdIndex departmentidindex)
        {
            string sql = "insert into DepartmentIdIndex(DepartmentID,DepartmentLoginname)values(@DepartmentID,@DepartmentLoginname)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@DepartmentID",departmentidindex.Departmentid),
                                    new SqlParameter("@DepartmentLoginname",departmentidindex.Departmentloginname)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }
        /// <summary>
        /// 将row中的数据转成DepartmenIdIndex类，在分页的时候还用到这个函数，于是写成public
        /// </summary>
        /// <param name="row"></param>
        /// <param name="departmentidindex"></param>
        public  void LoadDepartmentIdIndex(DataRow row, DepartmentIdIndex departmentidindex)
        {
            departmentidindex.Id = Convert.ToInt32(row["ID"]);
            departmentidindex.Departmentid = Convert.ToInt32(row["DepartmentID"]);
            departmentidindex.Departmentloginname = row["DepartmentLoginname"] != DBNull.Value ? row["DepartmentID"].ToString() : string.Empty;

        }
    }
}
