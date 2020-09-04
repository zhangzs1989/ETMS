using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using zzs.sddj.Model;

namespace zzs.sddj.Dal
{
    public class DanweiInfoDal
    {
        public List<DanweiInfo>GetDanweiInfolist()
        {
            string sql = "select *from DanweiInfo";
            DataTable da = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            List<DanweiInfo> list = null;
            DanweiInfo danweiinfo = null;
            if (da.Rows.Count>0)
            {
                list = new List<DanweiInfo>();
                foreach (DataRow row in da.Rows)
                {
                    danweiinfo = new DanweiInfo();
                    LoadDanweiInfo(row, danweiinfo);
                    list.Add(danweiinfo);
                }
            }
            return list;
        }

        public DanweiInfo GetEntityModel(int id)
        {
            string sql = "select *from DanweiInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID",id));
            DanweiInfo danweiinfo = null;
            if (da.Rows.Count>0)
            {
                danweiinfo = new DanweiInfo();
                LoadDanweiInfo(da.Rows[0], danweiinfo);
            }
            return danweiinfo;
        }

        

        public DanweiInfo GetEntityModel(string name)
        {
            string sql = "select *from DanweiInfo where DanweiID=@name";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@name", name));
            DanweiInfo danweiinfo = null;
            if (da.Rows.Count > 0)
            {
                danweiinfo = new DanweiInfo();
                LoadDanweiInfo(da.Rows[0], danweiinfo);
            }
            return danweiinfo;
        }

        public int GetIDDanwei(string name)
        {
            string sql = "select *from DanweiInfo where Danwei=@name";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@name", name));
            DanweiInfo danweiinfo = null;
            if (da.Rows.Count > 0)
            {
                danweiinfo = new DanweiInfo();
                LoadDanweiInfo(da.Rows[0], danweiinfo);
            }
            return danweiinfo.Id;
        }
        public int DeleteEntityModel(int id)
        {
            string sql = "delete from DanweiInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text,new System.Data.SqlClient.SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(DanweiInfo danweiinfo)
        {
            string sql = "updata DanweiInfo set Danwei=@Danwei,DanweiID=@DanweID where ID=@ID";
            SqlParameter[] pars =
            {
                new SqlParameter("@Danwei",danweiinfo.Danwei),
                new SqlParameter("@Danweiid",danweiinfo.Danweiid)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(DanweiInfo danweiinfo)
        {
            string sql = "insert into DanweiInfo(Danwei,DanweiID)values(@Danwei,@DanweiID)";
            SqlParameter[] pars =
            {
                new SqlParameter("@Danwei",danweiinfo.Danwei),
                new SqlParameter("DanweiID",danweiinfo.Danweiid)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public string GetDanweiInfoID(string danwei)
        {
            string sql = "select *from DanweiInfo where Danwei=@Danwei";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@Danwei", danwei));
            DanweiInfo danweiinfo = null;
            if (da.Rows.Count > 0)
            {
                danweiinfo = new DanweiInfo();
                LoadDanweiInfo(da.Rows[0], danweiinfo);

            }
            return danweiinfo.Danweiid;
            
        }
        public DataTable GetDanweiRows()
        {
            string sql = "select Danwei from DanweiInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            return da;
        }
        private void LoadDanweiInfo(DataRow row, DanweiInfo danweiinfo)
        {
            danweiinfo.Id = Convert.ToInt32(row["ID"]);
            danweiinfo.Danwei = row["Danwei"] != DBNull.Value ? row["Danwei"].ToString() : string.Empty;
            danweiinfo.Danweiid = row["DanweiID"] != DBNull.Value ? row["DanweiID"].ToString() : string.Empty;
        }
    }
}
