using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using zzs.sddj.Model;
using System.Data.SqlClient;
namespace zzs.sddj.Dal
{
    public class UserInfo_allDal
    {
        public List<zzs.sddj.Model.UserInfo_all> GetEntitylist()
        {
            string sql = "select *from UserInfo_all";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<zzs.sddj.Model.UserInfo_all> list = null;
            zzs.sddj.Model.UserInfo_all userinfoall = null;
            if (da.Rows.Count > 0)
            {
                list = new List<zzs.sddj.Model.UserInfo_all>();
                foreach (DataRow row in da.Rows)
                {
                    userinfoall = new zzs.sddj.Model.UserInfo_all();
                    LoadUserinfoall(row, userinfoall);
                    list.Add(userinfoall);
                }
            }

            return list;
        }

        public DataSet GetEntityds(string danweiname)
        {
            string sql = "select * from [dbo].[UserInfo_all] where danWei=@danwei";
            DataSet da = SqlHelper.GetDataSet(sql, CommandType.Text, new SqlParameter("@danwei", danweiname));
            return da;
            
        }

        public DataSet GetEntityds()
        {
            string sql = "select * from [dbo].[UserInfo_all]"; 
            DataSet da = SqlHelper.GetDataSet(sql, CommandType.Text);
            return da;

        }

        public zzs.sddj.Model.UserInfo_all GetEntityModel(int id)
        {
            string sql = "select *from UserInfo_all where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            zzs.sddj.Model.UserInfo_all userinfoall = null;
            if (da.Rows.Count > 0)
            {
                userinfoall = new zzs.sddj.Model.UserInfo_all();
                LoadUserinfoall(da.Rows[0], userinfoall);
            }
            return userinfoall;

        }

        public zzs.sddj.Model.UserInfo_all GetEntityModel(string name)
        {
            string sql = "select *from UserInfo_all where name=@name";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@name", name));
            zzs.sddj.Model.UserInfo_all userinfoall = null;
            if (da.Rows.Count > 0)
            {
                userinfoall = new zzs.sddj.Model.UserInfo_all();
                LoadUserinfoall(da.Rows[0], userinfoall);
            }
            return userinfoall;

        }

        
        public int DeleteEntityModel(int id)
        {
            string sql = "delete from UserInfo_all where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdateEntityModel(UserInfo_all userinfoall)
        {
            string sql = "update UserInfo_all set name=@name,sex=@sex,minzu=@minzu,zzmm=@zzmm,danWei=@danWei,leibie=@leibie,zhiwu=@zhiwu,xzjb=@xzjb,whsp=@whsp,zhuanji=@zhuanji,personid=@personid where ID=@ID";

            SqlParameter[] pars ={
                                     
                                     new SqlParameter("@danWei",userinfoall.Danwei),
                                     new SqlParameter("@name",userinfoall.Name),
                                     new SqlParameter("@sex",userinfoall.Sex),
                                     new SqlParameter("@minzu",userinfoall.Minzu),
                                     new SqlParameter("@leibie",userinfoall.Leibie),
                                     new SqlParameter("@zzmm",userinfoall.Zzmm),
                                     new SqlParameter("@zhiwu",userinfoall.Zhiwu),
                                     new SqlParameter("@xzjb",userinfoall.Xzjb),
                                     new SqlParameter("@whsp",userinfoall.Whsp),
                                     new SqlParameter("@zhuanji",userinfoall.Zhuanji),
                                     new SqlParameter("@personid",userinfoall.Personid),
                                     new SqlParameter("@ID",userinfoall.Id)
                                    
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }


        public int InsertEntityModel(UserInfo_all userinfoall)
        {
            string sql = "insert into UserInfo_all(danwei,name,sex,minzu,zzmm,leibie,zhiwu,xzjb,whsp,zhuanji,personid)values(@danwei,@name,@sex,@minzu,@zzmm,@leibie,@zhiwu,@xzjb,@whsp,@zhuanji,@personid)";
            SqlParameter[] pars = {
                                    new SqlParameter("@danWei",userinfoall.Danwei),
                                     new SqlParameter("@name",userinfoall.Name),
                                     new SqlParameter("@sex",userinfoall.Sex),
                                     new SqlParameter("@minzu",userinfoall.Minzu),
                                     new SqlParameter("@zzmm",userinfoall.Zzmm),
                                     new SqlParameter("@leibie",userinfoall.Leibie),
                                     new SqlParameter("@zhiwu",userinfoall.Zhiwu),
                                     new SqlParameter("@xzjb",userinfoall.Xzjb),
                                     new SqlParameter("@whsp",userinfoall.Whsp),
                                     new SqlParameter("@zhuanji",userinfoall.Zhuanji),
                                     new SqlParameter("@personid",userinfoall.Personid)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }
        
        /// <summary>
        /// 找出用户名对应的部门ID
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserInfo_all CheckBumenidFromUserInfo_all(string username)
        {
            string sql = "select *from UserInfo_all where name=@name";
            SqlParameter[] pars = {
                                      new SqlParameter("@name",username)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo_all userinfoall = null;
            if (da.Rows.Count > 0)
            {
                userinfoall = new UserInfo_all();
                LoadUserinfoall(da.Rows[0], userinfoall);
            }
            return userinfoall;
        }

        public List<UserInfo_all> GetSanmeDanweiPerson(string danwei)
        {
            string sql = "select *from UserInfo_all where Danwei=@Danwei";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@Danwei", danwei));
            List<zzs.sddj.Model.UserInfo_all> list = null;
            zzs.sddj.Model.UserInfo_all userinfoall = null;
            if (da.Rows.Count > 0)
            {
                list = new List<zzs.sddj.Model.UserInfo_all>();
                foreach (DataRow row in da.Rows)
                {
                    userinfoall = new zzs.sddj.Model.UserInfo_all();
                    LoadUserinfoall(row, userinfoall);
                    list.Add(userinfoall);
                }
            }

            return list;

        }
        
        public int isexistuser(string name)
        {
            string sql = "select name from UserInfo_all where name=@name";
            SqlParameter[] pars = {
                                      new SqlParameter("@name",name)
                                  };

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            
            if (da.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public  void LoadUserinfoall(DataRow row, zzs.sddj.Model.UserInfo_all userinfoall)
        {
            userinfoall.Id = Convert.ToInt32(row["ID"]);
            userinfoall.Danwei = row["danWei"] != DBNull.Value ? row["danWei"].ToString() : string.Empty;
            userinfoall.Name = row["name"] != DBNull.Value ? row["name"].ToString() : string.Empty;
            userinfoall.Sex = row["sex"] != DBNull.Value ? row["sex"].ToString() : string.Empty;
            userinfoall.Minzu = row["minzu"] != DBNull.Value ? row["minzu"].ToString() : string.Empty;
            userinfoall.Zzmm = row["zzmm"] != DBNull.Value ? row["zzmm"].ToString() : string.Empty;
            userinfoall.Leibie = row["leibie"] != DBNull.Value ? row["leibie"].ToString() : string.Empty;
            userinfoall.Zhiwu = row["zhiwu"] != DBNull.Value ? row["zhiwu"].ToString() : string.Empty;
            userinfoall.Xzjb = row["xzjb"] != DBNull.Value ? row["xzjb"].ToString() : string.Empty;
            userinfoall.Whsp = row["whsp"] != DBNull.Value ? row["whsp"].ToString() : string.Empty;
            userinfoall.Zhuanji = row["zhuanji"] != DBNull.Value ? row["zhuanji"].ToString() : string.Empty;
            userinfoall.Personid = row["personid"] != DBNull.Value ? row["personid"].ToString() : string.Empty;
        }
    }
}
