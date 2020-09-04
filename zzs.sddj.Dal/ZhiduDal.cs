using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;
namespace zzs.sddj.Dal
{
    public class ZhiduDal
    {
        public List<ZhiduInfo> Getzhidulist()
        {
            string sql = "select *from ZhiDu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<ZhiduInfo> list = null;
            ZhiduInfo zhiduinfo = null;
            if (da.Rows.Count > 0)
            {
                list = new List<ZhiduInfo>();
                foreach (DataRow row in da.Rows)
                {
                    zhiduinfo = new ZhiduInfo();
                    LoadEntity(row, zhiduinfo);
                    list.Add(zhiduinfo);
                }
            }

            return list;
        }

        public ZhiduInfo GetEntityModel(int id)
        {
            string sql = "select *from ZhiDu where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            ZhiduInfo zhiduinfo = null;
            if (da.Rows.Count > 0)
            {
                zhiduinfo = new ZhiduInfo();
                LoadEntity(da.Rows[0], zhiduinfo);
            }

            return zhiduinfo;

        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from ZhiDu where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(ZhiduInfo zhiduinfo)
        {
            string sql = "update ZhiDu set Title=@Title,Regtime=@Regtime,Shangchuanzhe=@Shangchuanzhe,Zhiducailiao=@Zhiducailiao where ID=@ID";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Title",zhiduinfo.Title),
                                    new SqlParameter("@Regtime",zhiduinfo.Regtime),
                                    new SqlParameter("@Shangchuanzhe",zhiduinfo.Shangchuanzhe),
                                    new SqlParameter("@Zhiducailiao",zhiduinfo.Zhiducailiao)
                                  };

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(ZhiduInfo zhiduinfo)
        {
            string sql = "insert into ZhiDu(Title,Regtime,Shangchuanzhe,Zhiducailiao)values(@Title,@Regtime,@Shangchuanzhe,@Zhiducailiao)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Title",zhiduinfo.Title),
                                    new SqlParameter("@Regtime",zhiduinfo.Regtime),
                                    new SqlParameter("@Shangchuanzhe",zhiduinfo.Shangchuanzhe),
                                    new SqlParameter("@Zhiducailiao",zhiduinfo.Zhiducailiao)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }


        public void LoadEntity(DataRow row, ZhiduInfo zhiduinfo)
        {
            zhiduinfo.Id = Convert.ToInt32(row["ID"]);
            zhiduinfo.Title = row["Title"] != DBNull.Value ? row["Title"].ToString() : string.Empty;
            zhiduinfo.Regtime = Convert.ToDateTime(row["Regtime"]);
            zhiduinfo.Shangchuanzhe = row["Shangchuanzhe"] != DBNull.Value ? row["Shangchuanzhe"].ToString() : string.Empty;
            zhiduinfo.Zhiducailiao = row["Zhiducailiao"] != DBNull.Value ? row["Zhiducailiao"].ToString() : string.Empty;
        }
    }
}
