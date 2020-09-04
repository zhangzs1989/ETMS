using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;
namespace zzs.sddj.Dal
{
    public class XuelixueweiDal
    {
        /// <summary>
        /// 返回list列表
        /// </summary>
        /// <returns></returns>
        public List<Xuelixuewei> GetEntitylist()
        {
            string sql = "select *from Xuelixuewei";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<Xuelixuewei> list = null;
            Xuelixuewei xuelixuewei = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                foreach (DataRow row in da.Rows)
                {
                    xuelixuewei = new Xuelixuewei();
                    Loadxuelixuewei(row, xuelixuewei);
                    list.Add(xuelixuewei);
                }
            }

            return list;
        }
        /// <summary>
        /// 返回一个学历学位申请的类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Xuelixuewei GetEntityModel(int id)
        {
            string sql = "select *from Xuelixuewei where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            Xuelixuewei xuelixuewei = null;
            if (da.Rows.Count > 0)
            {
                xuelixuewei = new Xuelixuewei();
                Loadxuelixuewei(da.Rows[0], xuelixuewei);
            }
            return xuelixuewei;
        
        }


        public int DeleteEntityModel(int id)
        {
            string sql = "delete from Xuelixuewei where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }


        public int UpdateEntityModel(Xuelixuewei xlxw)
        {
            string sql = "update Xuelixuewei set Peixunren=@Peixunren,Leibie=@Leibie,Scool=@Scool,Major=@Major, StartTime=@StartTime,EndTime=@EndTime,Didian=@Didian where ID=@ID";
            SqlParameter[] pars ={
                                    
                                    new SqlParameter("@Peixunren",xlxw.Peixunren),
                                    new SqlParameter("@Leibie",xlxw.Leibie1),
                                    new SqlParameter("@Scool",xlxw.Scool),
                                    new SqlParameter("@Major",xlxw.Major),
                                    new SqlParameter("@StartTime",xlxw.Starttime),
                                    new SqlParameter("@EndTime",xlxw.Endtime),
                                    new SqlParameter("@Didian",xlxw.Didian),
                                    new SqlParameter("@ID",xlxw.Id),
                                    
                                    //new SqlParameter("@Spzhuangtai",xlxw.Spzhuangtai2)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="traininfo"></param>
        /// <returns></returns>
        public int InsertEntityModel(Xuelixuewei xlxw)
        {
            string sql = "insert into Xuelixuewei(Bumenid,Peixunren,Leibie,Scool,Major,StartTime,EndTime,Didian,Spzhuangtai)values(@Bumenid,@Peixunren,@Leibie,@Scool,@Major,@StartTime,@EndTime,@Didian,@Spzhuangtai)";
            SqlParameter[] pars = {
                                    new SqlParameter("@Bumenid",xlxw.Bumenid),
                                    new SqlParameter("@Peixunren",xlxw.Peixunren),
                                    new SqlParameter("@Leibie",xlxw.Leibie1),
                                    new SqlParameter("@Scool",xlxw.Scool),
                                    new SqlParameter("@Major",xlxw.Major),
                                    new SqlParameter("@StartTime",xlxw.Starttime),
                                    new SqlParameter("@EndTime",xlxw.Endtime),
                                    new SqlParameter("@Didian",xlxw.Didian),
                                    new SqlParameter("@Spzhuangtai",xlxw.Spzhuangtai)
                                    //new SqlParameter("@Spzhuangtai2",xlxw.Spzhuangtai2)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

       

        public void Loadxuelixuewei(DataRow row, Xuelixuewei xuelixuewei)
        {
            xuelixuewei.Id = Convert.ToInt32(row["ID"]);
            xuelixuewei.Bumenid = Convert.ToInt32(row["Bumenid"]);
            xuelixuewei.Peixunren = row["Peixunren"] != DBNull.Value ? row["Peixunren"].ToString() : string.Empty;
            xuelixuewei.Leibie1 = row["Leibie"] != DBNull.Value ? row["Leibie"].ToString() : string.Empty;
            xuelixuewei.Scool = row["Scool"] != DBNull.Value ? row["Scool"].ToString() : string.Empty;
            xuelixuewei.Major = row["Major"] != DBNull.Value ? row["Major"].ToString() : string.Empty;
            xuelixuewei.Starttime = row["StartTime"] != DBNull.Value ? row["StartTime"].ToString() : string.Empty;
            xuelixuewei.Endtime = row["EndTime"] != DBNull.Value ? row["EndTime"].ToString() : string.Empty;
            xuelixuewei.Didian = row["Didian"] != DBNull.Value ? row["Didian"].ToString() : string.Empty;
            xuelixuewei.Spzhuangtai = row["Spzhuangtai"] != DBNull.Value ? row["Spzhuangtai"].ToString() : string.Empty;
            //xuelixuewei.Spzhuangtai2 = row["Spzhuangtai2"] != DBNull.Value ? row["Spzhuangtai2"].ToString() : string.Empty;
        }
    }
}
