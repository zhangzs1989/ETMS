using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;
namespace zzs.sddj.Dal
{
    public class AdminLoginInfoDal
    {
        public List<AdminLoginInfo> GetEntityList()
        {
            string sql = "select *from AdminLoginInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<AdminLoginInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<AdminLoginInfo>();
                foreach (DataRow row in da.Rows)
                {
                    AdminLoginInfo adminlogininfo = new AdminLoginInfo();
                    LoadEntity(row, adminlogininfo);
                }
            }
            return list;
        }

        public AdminLoginInfo GetEntityModel(int id)
        {
            string sql = "select *from AdminLoginInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("ID", id));
            AdminLoginInfo adminlogininfo = null;
            if (da.Rows.Count > 0)
            {
                adminlogininfo = new AdminLoginInfo();
                LoadEntity(da.Rows[0], adminlogininfo);
            }
            return adminlogininfo;
        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from AdminLoginInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(AdminLoginInfo adminlogininfo)
        {
            string sql = "update AdminLoginInfo set AdminName=@AdminName,AdminPwd=@AdminPwd where ID=@ID";

            SqlParameter[] pars = { 
                                    new SqlParameter("@AdminName",adminlogininfo.Username),
                                    new SqlParameter("@AdminPwd",adminlogininfo.Userpass),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment),
                                    new SqlParameter("@ID",adminlogininfo.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(AdminLoginInfo adminlogininfo)
        {
            string sql = "insert into AdminLoginInfo(AdminName,AdminPwd)values(@AdminName,@AdminPwd)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@AdminName",adminlogininfo.Username),
                                    new SqlParameter("@AdminPwd",adminlogininfo.Userpass),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);

        }

        public AdminLoginInfo GetAdminInfoModel(string username, string userpwd)
        {
            string sql = "select *from AdminLoginInfo where AdminName=@AdminName and AdminPwd=@AdminPwd";
            SqlParameter[] pars = { 
                                    new SqlParameter("@AdminName",username),
                                    new SqlParameter("@AdminPwd",userpwd)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            AdminLoginInfo adminlogininfo = null;
            if (da.Rows.Count > 0)
            {
                adminlogininfo = new AdminLoginInfo();
                LoadEntity(da.Rows[0], adminlogininfo);
            }
            return adminlogininfo;
        }

        public void LoadEntity(DataRow row, AdminLoginInfo adminlogininfo)
        {
            adminlogininfo.Id = Convert.ToInt32(row["ID"]);
            adminlogininfo.Username = row["AdminName"] != DBNull.Value ? row["AdminName"].ToString() : string.Empty;
            adminlogininfo.Userpass = row["AdminPwd"] != DBNull.Value ? row["AdminPwd"].ToString() : string.Empty;

        }

       
    }
}
