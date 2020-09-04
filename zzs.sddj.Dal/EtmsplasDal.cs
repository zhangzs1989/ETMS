using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
namespace zzs.sddj.Dal
{
    public class EtmsplasDal
    {
        public List<Etmsplas> Getzhidulist()
        {
            string sql = "select *from Etmsplan";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<Etmsplas> list = null;
            Etmsplas plan = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Etmsplas>();
                foreach (DataRow row in da.Rows)
                {
                    plan = new Etmsplas();
                    LoadEntity(row, plan);
                    list.Add(plan);
                }
            }

            return list;
        }

        public List<Etmsplas> Getzhidulist(int niandu)
        {
            string sql = "select *from Etmsplan where Niandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text,new SqlParameter("@niandu",niandu));
            List<Etmsplas> list = null;
            Etmsplas plan = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Etmsplas>();
                foreach (DataRow row in da.Rows)
                {
                    plan = new Etmsplas();
                    LoadEntity(row, plan);
                    list.Add(plan);
                }
            }

            return list;
        }

        public Etmsplas GetEntityModel(int id)
        {
            string sql = "select *from Etmsplan where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            Etmsplas plan = null;
            if (da.Rows.Count > 0)
            {
                plan = new Etmsplas();
                LoadEntity(da.Rows[0], plan);
            }

            return plan;

        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete from Etmsplan where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(Etmsplas plan)
        {
            string sql = "update Etmsplan set Niandu=@niandu,Filepath=@filepath,Bumen=@bumen where ID=@ID";
            SqlParameter[] pars = {
                                    new SqlParameter("@niandu",plan.Niandu),
                                    new SqlParameter("@filepath",plan.Filepath),
                                    new SqlParameter("@bumen",plan.Bumen)
                                  };

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(Etmsplas plan)
        {
            string sql = "insert into Etmsplan(Niandu,Filepath,Bumen)values(@niandu,@filepath,@bumen)";
            SqlParameter[] pars = {
                                    new SqlParameter("@niandu",plan.Niandu),
                                    new SqlParameter("@filepath",plan.Filepath),
                                    new SqlParameter("@bumen",plan.Bumen)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }


        public void LoadEntity(DataRow row, Etmsplas plan)
        {
            plan.Id = Convert.ToInt32(row["ID"]);
            plan.Niandu = Convert.ToInt32(row["Niandu"]);
            plan.Filepath = row["Filepath"] != DBNull.Value ? row["Filepath"].ToString() : string.Empty;
            plan.Bumen = row["Bumen"] != DBNull.Value ? row["Bumen"].ToString() : string.Empty;    
        }
    }
}
