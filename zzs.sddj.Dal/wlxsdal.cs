using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
namespace zzs.sddj.Dal
{
    public class wlxsdal
    {
        public int InsertEntityModel(wlxs wlxsmodel)
        {
            string sql = "insert into Wlxs(Niandu,Filename)values(@niandu,@filename)";
            SqlParameter[] pars = {
                                    new SqlParameter("@niandu",wlxsmodel.Niandu),
                                    new SqlParameter("@filename",wlxsmodel.Filepath),
                                    
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }
        public wlxs GetEntityModel(int id)
        {
            string sql = "select *from Wlxs where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            wlxs wlxsmodel = null;
            if (da.Rows.Count > 0)
            {
                wlxsmodel = new wlxs();
                LoadEntity(da.Rows[0], wlxsmodel);
            }

            return wlxsmodel;

        }

        public wlxs GetModel(int year)
        {
            string sql = "select *from Wlxs where Niandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@niandu", year));
            wlxs wlxsmodel = null;
            if (da.Rows.Count > 0)
            {
                wlxsmodel = new wlxs();
                LoadEntity(da.Rows[0], wlxsmodel);
            }

            return wlxsmodel;

        }


        public List<wlxs> Getwlxslist()
        {
            string sql = "select *from Wlxs";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<wlxs> list = null;
            wlxs wlxsmodel = null;
            if (da.Rows.Count > 0)
            {
                list = new List<wlxs>();
                foreach (DataRow row in da.Rows)
                {
                    wlxsmodel = new wlxs();
                    
                    LoadEntity(row, wlxsmodel);
                    list.Add(wlxsmodel);
                }
            }

            return list;
        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from Wlxs where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public DataTable GetDataTable(int niandu)
        {
            string sql = "select *from Wlxs where Niandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@niandu", niandu));
            return da;
        }



        public void LoadEntity(DataRow row, wlxs wlxsmodel)
        {
            wlxsmodel.Id = Convert.ToInt32(row["ID"]);
            wlxsmodel.Niandu = Convert.ToInt32(row["Niandu"]);
           
            wlxsmodel.Filepath = row["Filename"] != DBNull.Value ? row["Filename"].ToString() : string.Empty;
        }
    }
}
