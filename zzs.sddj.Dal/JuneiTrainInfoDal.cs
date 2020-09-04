using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;

namespace zzs.sddj.Dal
{
    public class JuneiTrainInfoDal
    {
        public List<JuneiTrainInfo> GetEntityList()
        {
            string sql = "select *from JuneiTrainInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<JuneiTrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrainInfo>();
                foreach (DataRow row in da.Rows)
                {
                    JuneiTrainInfo traininfo = new JuneiTrainInfo();
                    LoadEntity(row, traininfo);
                }
            }
            return list;
        }

        public JuneiTrainInfo GetEntityModel(int id)
        {
            string sql = "select *from JuneiTrainInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            JuneiTrainInfo traininfo = null;
            if (da.Rows.Count > 0)
            {
                traininfo = new JuneiTrainInfo();
                LoadEntity(da.Rows[0], traininfo);
            }

            return traininfo;

        }



        public DataTable GetEntityModel(string zhubanname)
        {
            string sql = "select *from JuneiTrainInfo where Trainzhuban=@name";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@name", zhubanname));
            return da;

        }

        public int deletejninfo(int id)
        {
            string sql = "delete  from JuneiTrainInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));

        }

        public DataTable Getjninfo(int niandu)
        {
            string sql = "select *from JuneiTrainInfo where Trainniandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@niandu", niandu));
            return da;

        }


        public int InsertEntityModel(JuneiTrainInfo traininfo)
        {
            string sql = "insert into JuneiTrainInfo(Trainname,Traindidian,Traintime,Trainxueshi,Trainjianjie,Trainrenyuan,Trainzhuban,Trainbeizhu,Trainniandu)values(@Trainname,@Traindidian,@Traintime,@Trainxueshi,@Trainjianjie,@Trainrenyuan,@Trainzhuban,@Trainbeizhu,@Trainniandu)";
            SqlParameter[] pars = {
                                    new SqlParameter("@Trainname",traininfo.Trainname),
                                    new SqlParameter("@Traindidian",traininfo.Traindidian),
                                    new SqlParameter("@Traintime",traininfo.Traintime),
                                    new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
                                    new SqlParameter("@Trainjianjie",traininfo.trainjianjie),
                                    new SqlParameter("@Trainrenyuan",traininfo.Trainrenyuan),
                                    new SqlParameter("@Trainzhuban",traininfo.Trainzhuban),
                                    new SqlParameter("@Trainbeizhu",traininfo.Trainbeizhu),
                                    new SqlParameter("@Trainniandu",traininfo.Trainniandu)
                                    //new SqlParameter("@qitarenyuan",traininfo.Qitarenyuan)
                                    
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int UpdataEntityModel(JuneiTrainInfo traininfo)
        {
            string sql = "update JuneiTrainInfo set  Trainname=@Trainname,Traindidian=@Traindidian,Traintime=@Traintime,Trainxueshi=@Trainxueshi,Trainjianjie=@Trainjianjie,Trainrenyuan=@Trainrenyuan,Trainzhuban=@Trainzhuban,Trainbeizhu=@Trainbeizhu,Trainniandu=@Trainniandu where ID=@ID";
            SqlParameter[] pars = {
                                    new SqlParameter("@Trainname",traininfo.Trainname),
                                    new SqlParameter("@Traindidian",traininfo.Traindidian),
                                    new SqlParameter("@Traintime",traininfo.Traintime),
                                    new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
                                    new SqlParameter("@Trainjianjie",traininfo.trainjianjie),
                                    new SqlParameter("@Trainrenyuan",traininfo.Trainrenyuan),
                                    new SqlParameter("@Trainzhuban",traininfo.Trainzhuban),
                                    new SqlParameter("@Trainbeizhu",traininfo.Trainbeizhu),
                                    new SqlParameter("@Trainniandu",traininfo.Trainniandu),
                                    //new SqlParameter("@qitarenyuan",traininfo.Qitarenyuan),
                                    new SqlParameter("@ID",traininfo.Id)
                                  };

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }
        //public int DeleteEntityModel(int id)
        //{
        //    string sql = "delete *from JuneiTrainInfo where ID=@ID";
        //    return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        //}

        //public int UpdataEntityModel(JuneiTrainInfo traininfo)
        //{
        //    string sql = "update JuneiTrain set  Trainname=@Trainname,Traindidian=@Traindidian,Traintime=@Traintime,Trainxueshi=@Trainxueshi,Trainjianjie=@Trainjianjie,Trainrenyuan=@Trainrenyuan,Trainzhuban=@Trainzhuban,Trainbeizhu=@Trainbeizhu,Qitarenyuan=@Qitarenyuan where ID=@ID";
        //    SqlParameter[] pars = {
        //                            new SqlParameter("@Trainname",traininfo.Trainname),
        //                            new SqlParameter("@Traindidian",traininfo.Traindidian),
        //                            new SqlParameter("@Traintime",traininfo.Traintime),
        //                            new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
        //                            new SqlParameter("@Trainjianjie",traininfo.trainjianjie),
        //                            new SqlParameter("@Trainrenyuan",traininfo.Trainrenyuan),
        //                            new SqlParameter("@Trainzhuban",traininfo.Trainzhuban),
        //                            new SqlParameter("@Trainbeizhu",traininfo.Trainbeizhu),
        //                            new SqlParameter("@Qitarenyuan",traininfo.Qitarenyuan),
        //                            new SqlParameter("@ID",traininfo.Id)
        //                          };

        //    return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        //}

        //public int InsertEntityModel(JuneiTrainInfo traininfo)
        //{
        //    string sql = "insert into JuneiTrainInfo(Trainname,Traindidian,Traintime,Trainxueshi,Trainjianjie,Trainrenyuan,Trainzhuban,Trainbeizhu,Qitarenyuan)values(@Trainname,@Traindidian,@Traintime,@Trainxueshi,@Trainjianjie,@Trainrenyuan,@Trainzhuban,@Trainbeizhu,@Qitarenyuan)";
        //    SqlParameter[] pars = {
        //                            new SqlParameter("@Trainname",traininfo.Trainname),
        //                            new SqlParameter("@Traindidian",traininfo.Traindidian),
        //                            new SqlParameter("@Traintime",traininfo.Traintime),
        //                            new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
        //                            new SqlParameter("@Trainjianjie",traininfo.trainjianjie),
        //                            new SqlParameter("@Trainrenyuan",traininfo.Trainrenyuan),
        //                            new SqlParameter("@Trainzhuban",traininfo.Trainzhuban),
        //                            new SqlParameter("@Trainbeizhu",traininfo.Trainbeizhu),
        //                            new SqlParameter("@Qitarenyuan",traininfo.Qitarenyuan)
        //                          };
        //    return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        //}

        //public int Getxuefentol(string username)
        //{
        //    int xuefentol = 0;
        //    string sql = "select Trainxueshi from JuneiTrain where Trainrenyuan=@Username";
        //    DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@Username", username));
        //    if (da.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in da.Rows)
        //        {
        //            xuefentol += int.Parse(row["Trainxueshi"].ToString());
        //        }
        //    }
        //    else
        //    {
        //        xuefentol = 0;
        //    }

        //    return xuefentol;
        //}


        //public List<JuneiTrainInfo> Getjnuserinfoall(string danweiid)
        //{
        //    string sql = "select *from JuneiTrainInfo where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid))";
        //    DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@danweiid", danweiid));
        //    List<JuneiTrainInfo> list = null;
        //    if (da.Rows.Count > 0)
        //    {
        //        list = new List<JuneiTrainInfo>();
        //        foreach (DataRow row in da.Rows)
        //        {
        //            JuneiTrainInfo traininfo = new JuneiTrainInfo();
        //            LoadEntity(row, traininfo);
        //        }
        //    }
        //    return list;
        //}

        public void LoadEntity(DataRow row, JuneiTrainInfo traininfo)
        {
            traininfo.Id = Convert.ToInt32(row["ID"]);
            traininfo.Trainname = row["Trainname"] != DBNull.Value ? row["Trainname"].ToString() : string.Empty;
            traininfo.Traindidian = row["Traindidian"] != DBNull.Value ? row["Traindidian"].ToString() : string.Empty;
            traininfo.trainjianjie = row["Trainjianjie"] != DBNull.Value ? row["Trainjianjie"].ToString() : string.Empty;
            traininfo.Trainxueshi = Convert.ToInt32(row["Trainxueshi"]);
            traininfo.Trainrenyuan = row["Trainrenyuan"] != DBNull.Value ? row["Trainrenyuan"].ToString() : string.Empty;
            traininfo.Traintime = row["Traintime"] != DBNull.Value ? row["Traintime"].ToString() : string.Empty;
            traininfo.Trainzhuban = row["Trainzhuban"] != DBNull.Value ? row["Trainzhuban"].ToString() : string.Empty;
            traininfo.Trainbeizhu = row["Trainbeizhu"] != DBNull.Value ? row["Trainbeizhu"].ToString() : string.Empty;
            traininfo.Trainniandu = Convert.ToInt32(row["Trainniandu"]);
            //traininfo.Qitarenyuan = row["Trainqitarenyuan"] != DBNull.Value ? row["Trainqitarenyuan"].ToString() : string.Empty;
        }
    }
}
