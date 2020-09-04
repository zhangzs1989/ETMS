using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;

namespace zzs.sddj.Dal
{
    public class UserInfoDal
    {
        /// <summary>
        /// 返回列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetEntityList()
        {
            string sql = "select *from UserInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<UserInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                foreach (DataRow row in da.Rows)
                {
                    UserInfo userinfo = new UserInfo();
                    LoadEntity(row, userinfo);

                }
            }
            return list;
        }

        /// <summary>
        /// 返回一行
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetEntityModel(int id)
        {
            string sql = "select *from UserInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            UserInfo userinfo = null;
            if (da.Rows.Count > 0)
            {
                userinfo = new UserInfo();
                LoadEntity(da.Rows[0], userinfo);
            }
            return userinfo;
        }

        public UserInfo GetEntityModel(string name)
        {
            string sql = "select *from UserInfo where UserName=@UserName";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@UserName", name));
            UserInfo userinfo = null;
            if (da.Rows.Count > 0)
            {
                userinfo = new UserInfo();
                LoadEntity(da.Rows[0], userinfo);
            }
            return userinfo;
        }

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEntityModel(int id)
        {
            string sql = "delete from UserInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int UpdataEntityModel(UserInfo userinfo)
        {
            string sql = "update UserInfo set UserName=@UserName,UserPass=@UserPass where ID=@ID";

            SqlParameter[] pars = { 
                                    new SqlParameter("@UserName",userinfo.Username),
                                    new SqlParameter("@UserPass",userinfo.Userpass),
                                    new SqlParameter("@ID",userinfo.Id)
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment),
                                    //new SqlParameter("@ID",userinfo.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int UpdataEntityModel(DepartmentInfo userinfo)
        {
            string sql = "update DepartmentLoginInfo set Departmentloginname=@UserName,Departmentpwd=@UserPass where ID=@ID";

            SqlParameter[] pars = {
                                    new SqlParameter("@UserName",userinfo.Departmentloginname),
                                    new SqlParameter("@UserPass",userinfo.Departmentpwd),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment),
                                    new SqlParameter("@ID",userinfo.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int UpdataEntityModel(AdminLoginInfo userinfo)
        {
            string sql = "update AdminLoginInfo set AdminName=@UserName,AdminPwd=@UserPass where ID=@ID";

            SqlParameter[] pars = {
                                    new SqlParameter("@UserName",userinfo.Username),
                                    new SqlParameter("@UserPass",userinfo.Userpass),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment),
                                    new SqlParameter("@ID",userinfo.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int InsertEntityModel(UserInfo userinfo)
        {
            string sql = "insert into UserInfo(UserName,UserPass)values(@UserName,@UserPass)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@UserName",userinfo.Username),
                                    new SqlParameter("@UserPass",userinfo.Userpass),
                                    //new SqlParameter("@UserPartMent",userinfo.Userpartment)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);

        }


        /// <summary>
        /// 把一行数据赋给UserInfo对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="userinfo"></param>
        public void LoadEntity(DataRow row, UserInfo userinfo)
        {
            //userinfo.Id = Convert.ToInt32(row["ID"]);
            userinfo.Id = Convert.ToInt32(row["ID"]);
            userinfo.Username = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;
            userinfo.Userpass = row["UserPass"] != DBNull.Value ? row["UserPass"].ToString() : string.Empty;
            //userinfo.Userpartment = row["UserPartMent"] != DBNull.Value ? row["UserPartMent"].ToString() : string.Empty;

        }
        private void LoadEntity(DataRow row, AdminLoginInfo admininfo)
        {
            //userinfo.Id = Convert.ToInt32(row["ID"]);
            admininfo.Id = Convert.ToInt32(row["ID"]);
            admininfo.Username = row["AdminName"] != DBNull.Value ? row["AdminName"].ToString() : string.Empty;
            admininfo.Userpass = row["AdminPwd"] != DBNull.Value ? row["AdminPwd"].ToString() : string.Empty;
            //admininfo.Userpartment = row["UserPartMent"] != DBNull.Value ? row["UserPartMent"].ToString() : string.Empty;

        }

        private void LoadEntity(DataRow row,DepartmentInfo admininfo)
        {
            //userinfo.Id = Convert.ToInt32(row["ID"]);
            admininfo.Id = Convert.ToInt32(row["ID"]);
            admininfo.Departmentloginname = row["Departmentloginname"] != DBNull.Value ? row["Departmentloginname"].ToString() : string.Empty;
            admininfo.Departmentpwd = row["Departmentpwd"] != DBNull.Value ? row["Departmentpwd"].ToString() : string.Empty;
            
        }


        /// <summary>
        /// 普通用户
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoModel(string username, string userpwd)
        {
            string sql = "select *from UserInfo where UserName=@UserName and UserPass=@UserPass";
            SqlParameter[] pars = { 
                                    new SqlParameter("@UserName",username),
                                    new SqlParameter("@UserPass",userpwd)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo userinfo = null;
            if (da.Rows.Count > 0)
            {
                userinfo = new UserInfo();
                LoadEntity(da.Rows[0], userinfo);
            }
            return userinfo;
        }

        /// <summary>
        /// 单位登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <returns></returns>
        public DepartmentInfo GetdepartmentModel(string username, string userpwd)
        {
            string sql = "select *from DepartmentLoginInfo where Departmentloginname=@UserName and Departmentpwd=@UserPass";
            SqlParameter[] pars = {
                                    new SqlParameter("@UserName",username),
                                    new SqlParameter("@UserPass",userpwd)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            DepartmentInfo userinfo = null;
            if (da.Rows.Count > 0)
            {
                userinfo = new DepartmentInfo();
                LoadEntity(da.Rows[0], userinfo);
            }
            return userinfo;
        }

        /// <summary>
        /// 管理员
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpwd"></param>
        /// <returns></returns>
        public AdminLoginInfo GetAdminInfoModel(string username, string userpwd)
        {
            string sql = "select *from AdminLoginInfo where AdminName=@UserName and AdminPwd=@UserPass";
            SqlParameter[] pars = { 
                                    new SqlParameter("@UserName",username),
                                    new SqlParameter("@UserPass",userpwd)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            AdminLoginInfo admininfo = null;
            if (da.Rows.Count > 0)
            {
                admininfo = new AdminLoginInfo();
                LoadEntity(da.Rows[0], admininfo);
            }
            return admininfo;
        }  
    }
}
