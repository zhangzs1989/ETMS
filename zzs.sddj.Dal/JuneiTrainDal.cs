using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
namespace zzs.sddj.Dal
{
    public class JuneiTrainDal
    {
        public List<JuneiTrain> GetEntityList()
        {
            string sql = "select *from JuneiTrain";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                foreach (DataRow row in da.Rows)
                {
                    JuneiTrain traininfo = new JuneiTrain();
                    LoadEntity(row,traininfo);
                }
            }
            return list;
        }

        public JuneiTrain GetEntityModel(int id)
        {
            string sql = "select *from JuneiTrain where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            JuneiTrain traininfo = null;
            if (da.Rows.Count > 0)
            {
                traininfo = new JuneiTrain();
                LoadEntity(da.Rows[0], traininfo);
            }

            return traininfo;

        }

        public DataTable Getjn(int niandu)
        {
            string sql = "select *from JuneiTrain where Trainniandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@niandu", niandu));
            return da;

        }

        public string getnamefromid(int id)
        {
            string sql = "select Trainrenyuan from JuneiTrain where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            //JuneiTrain traininfo = null;
            //if (da.Rows.Count > 0)
            //{
            //    traininfo = new JuneiTrain();
            //    LoadEntity(da.Rows[0], traininfo);
            //}
            return Convert.ToString(da.Rows[0]["Trainrenyuan"]);
        }

        public DataTable GetEntityModel(string name,int year)
        {
            string sql = "select *from JuneiTrain where Trainrenyuan=@name and Trainniandu=@Trainniandu";
            SqlParameter[] pars =
            {
                new SqlParameter("@name",name),
                new SqlParameter("@Trainniandu",year)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            
            return da;

        }

        public ArrayList GetEntityModelid(string trainname,string time)
        {
            string sql = "select ID from JuneiTrain where Trainname=@name and Traintime=@time";
            SqlParameter[] pars =
            {
                new SqlParameter("@name",trainname),
                new SqlParameter("@time",time)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            ArrayList idnum = new ArrayList();
            for (int i = 0; i < da.Rows.Count; i++)
            {
                idnum.Add(Convert.ToInt32(da.Rows[i]["ID"]));
            }
            return idnum;

        }


        public DataTable GetEntityModel(string name)
        {
            string sql = "select *from JuneiTrain where Trainrenyuan=@name";
            SqlParameter[] pars =
            {
                new SqlParameter("@name",name)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);

            return da;

        }

        public JuneiTrain GetEntityModeltoJnt(string name)
        {
            string sql = "select *from JuneiTrain where Trainrenyuan=@name";
            SqlParameter[] pars =
            {
                new SqlParameter("@name",name)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            JuneiTrain traininfo = null;
            if (da.Rows.Count > 0)
            {
                traininfo = new JuneiTrain();
                LoadEntity(da.Rows[0], traininfo);
            }

            return traininfo;


        }

        public int DeleteEntityModel(int id)
        {
            string sql = "delete  from JuneiTrain where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        public int UpdataEntityModel(JuneiTrain traininfo)
        {
            string sql = "update JuneiTrain set  Trainname=@Trainname,Traindidian=@Traindidian,Traintime=@Traintime,Trainxueshi=@Trainxueshi,Trainjianjie=@Trainjianjie,Trainrenyuan=@Trainrenyuan,Trainzhuban=@Trainzhuban,Trainbeizhu=@Trainbeizhu,Trainniandu=@Trainniandu where ID=@ID";
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
                                    new SqlParameter("@ID",traininfo.Id)
                                  };

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int InsertEntityModel(JuneiTrain traininfo)
        {
            string sql = "insert into JuneiTrain(Trainname,Traindidian,Traintime,Trainxueshi,Trainjianjie,Trainrenyuan,Trainzhuban,Trainbeizhu,Qitarenyuan,Trainniandu)values(@Trainname,@Traindidian,@Traintime,@Trainxueshi,@Trainjianjie,@Trainrenyuan,@Trainzhuban,@Trainbeizhu,@Qitarenyuan,@Trainniandu)";
            SqlParameter[] pars = {
                                    new SqlParameter("@Trainname",traininfo.Trainname),
                                    new SqlParameter("@Traindidian",traininfo.Traindidian),
                                    new SqlParameter("@Traintime",traininfo.Traintime),
                                    new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
                                    new SqlParameter("@Trainjianjie",traininfo.trainjianjie),
                                    new SqlParameter("@Trainrenyuan",traininfo.Trainrenyuan),
                                    new SqlParameter("@Trainzhuban",traininfo.Trainzhuban),
                                    new SqlParameter("@Trainbeizhu",traininfo.Trainbeizhu),
                                    new SqlParameter("@Qitarenyuan",traininfo.Qitarenyuan),
                                    new SqlParameter("@Trainniandu",traininfo.Trainniandu)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        public int Getxuefentol(string username,int niandu)
        {
            int xuefentol = 0;
            string sql = "select Trainxueshi from JuneiTrain where Trainrenyuan=@Username and Trainniandu=@Trainniandu";
            SqlParameter[] pars =
            {
                new SqlParameter("@Username",username),
                new SqlParameter("@Trainniandu",niandu)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {
                foreach (DataRow row in da.Rows)
                {
                    xuefentol += int.Parse(row["Trainxueshi"].ToString());
                }
            }
            else
            {
                xuefentol = 0;
            }

            return xuefentol;
        }

        public int Getxuefentol(string username)
        {
            int xuefentol = 0;
            string sql = "select Trainxueshi from JuneiTrain where Trainrenyuan=@Username";
            SqlParameter[] pars =
            {
                new SqlParameter("@Username",username)
                
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {
                foreach (DataRow row in da.Rows)
                {
                    xuefentol += int.Parse(row["Trainxueshi"].ToString());
                }
            }
            else
            {
                xuefentol = 0;
            }

            return xuefentol;
        }



        public List<JuneiTrain> Getjnuserinfoall(string danweiid)
        {
            string sql = "select *from JuneiTrain where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid))";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@danweiid", danweiid));
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                foreach (DataRow row in da.Rows)
                {
                    JuneiTrain traininfo = new JuneiTrain();
                    LoadEntity(row, traininfo);
                }
            }
            return list;
        }

        public void LoadEntity(DataRow row, JuneiTrain traininfo)
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
            traininfo.Qitarenyuan = row["Qitarenyuan"] != DBNull.Value ? row["Qitarenyuan"].ToString() : string.Empty;
            traininfo.Trainniandu = Convert.ToInt32(row["Trainniandu"]);
        }
    }
}
