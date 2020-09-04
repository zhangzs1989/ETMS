using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;

namespace zzs.sddj.Dal
{
    public class NoticeDal
    {
        public List<Notice> GetNoticelist()
        {
            string sql = "select *from Notice";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<Notice> list = null;
            Notice notice = null;
            if (da.Rows.Count>0)
            {
                list = new List<Notice>();
                foreach (DataRow row in da.Rows)
                {
                    notice = new Notice();
                    Loadnotice(row, notice);
                    list.Add(notice);
                }
            }

            return list;
        }

        public Notice GetEntityModel(int id)
        {
            string sql = "select *from Notice where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            Notice notice = null;
            if (da.Rows.Count > 0)
            {
                notice = new Notice();
                Loadnotice(da.Rows[0], notice);
            }
            return notice;
        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from Notice where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(Notice notice)
        {
            string sql = "update Notice set Title=@title,Regtime=@Regtime,issuer=@issuer content=@content,where ID=@ID";

            SqlParameter[] pars = { 
                                    new SqlParameter("@title",notice.Title),
                                    new SqlParameter("@Regtime",notice.Regtime1),
                                    new SqlParameter("@issuer",notice.Issuer),
                                    new SqlParameter("content",notice.Content),
                                    new SqlParameter("@ID",notice.Id)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(Notice notice)
        {
            string sql = "insert into Notice(Title,Regtime,issuer,content)values(@Title,@Regtime,@issuer,@content)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Title",notice.Title),
                                    new SqlParameter("@Regtime",notice.Regtime1),
                                    new SqlParameter("@issuer",notice.Issuer),
                                    new SqlParameter("@content",notice.Content)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);

        }



        public void Loadnotice(DataRow row, Notice notice)
        {
            notice.Id = Convert.ToInt32(row["ID"]);
            notice.Title = row["title"] != DBNull.Value ? row["title"].ToString() : string.Empty;
            notice.Regtime1 = Convert.ToDateTime(row["Regtime"]);
            notice.Issuer = row["issuer"] != DBNull.Value ? row["issuer"].ToString() : string.Empty;
            notice.Content = row["content"] != DBNull.Value ? row["content"].ToString() : string.Empty;
        }
    }
}
