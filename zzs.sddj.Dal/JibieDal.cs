using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using zzs.sddj.Model;

namespace zzs.sddj.Dal
{
    public class JibieDal
    {
        public List<Jiebie> GetJibielist()
        {
            string sql = "select *from Jibie";
            DataTable da = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            List<zzs.sddj.Model.Jiebie> list = null;
            zzs.sddj.Model.Jiebie jibie = null;
            if (da.Rows.Count>0)
            {
                list = new List<Jiebie>();
                foreach (DataRow row in da.Rows)
                {
                    jibie = new Jiebie();
                    LoadJibie(row, jibie);
                    list.Add(jibie);
                }
            }
            return list;
        }

        public Jiebie GetEntityModel(int id)
        {
            string sql = "select *from Jibie where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@ID", id));
            Jiebie jibie = null;
            if (da.Rows.Count>0)
            {
                jibie = new Jiebie();
                LoadJibie(da.Rows[0], jibie);
            }
            return jibie;
        }

        public Jiebie GetEntityModel(string name)
        {
            string sql = "select *from Jibie where leibie=@leibie";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@leibie",name));
            Jiebie jibie = null;
            if (da.Rows.Count > 0)
            {
                jibie = new Jiebie();
                LoadJibie(da.Rows[0], jibie);
            }
            return jibie;
        }

        public int DeleteEntityModel(int id)
        {
            string sql = "select *from Jibie where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(Jiebie jibie)
        {
            string sql = "update Jibie set leibie=@jibiename,Jibiefenshu=@jibiezhibiao,wlxs=@wlsx where ID=@ID";
            System.Data.SqlClient.SqlParameter[] pars =
            {
                new System.Data.SqlClient.SqlParameter("@jibiename",jibie.Name),
                new System.Data.SqlClient.SqlParameter("@jibiezhibiao",jibie.Jibiezhibiao),
                new System.Data.SqlClient.SqlParameter("@wlsx",jibie.Wangluoxueshi)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(Jiebie jibie)
        {
            string sql = "insert into Jibie(leibie,Jibiefengshu,wlxs)values(@Jibie,@jibiezhibiao,@wlxs)";
            System.Data.SqlClient.SqlParameter[] pars =
            {
                new System.Data.SqlClient.SqlParameter("@Jibie",jibie.Name),
                new System.Data.SqlClient.SqlParameter("@jibiezhibiao",jibie.Jibiezhibiao),
                new System.Data.SqlClient.SqlParameter("@wlxs",jibie.Wangluoxueshi)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);

        }
        public void LoadJibie(DataRow row, Jiebie jibie)
        {
            jibie.Id = Convert.ToInt32(row["ID"]);
            jibie.Name = row["leibie"] != DBNull.Value ? row["leibie"].ToString() : string.Empty;
            jibie.Jibiezhibiao = Convert.ToInt32(row["Jibiefengshu"]);
            jibie.Wangluoxueshi = Convert.ToInt32(row["wlxs"]);
        }
    }
}
