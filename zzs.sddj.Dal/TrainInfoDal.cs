using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace zzs.sddj.Dal
{
    public class TrainInfoDal
    {

        /// <summary>
        /// 返回列表
        /// </summary>
        /// <returns></returns>
        public List<TrainInfo> GetEntityList()
        {
            string sql = "select * from TrainInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<TrainInfo> list = null;
            if (da.Rows.Count>0)
            {
                list = new List<TrainInfo>();
                foreach (DataRow row in da.Rows)
                {
                    TrainInfo traininfo = new TrainInfo();
                    LoadEntity(row,traininfo);
                }
            }
            return list;
        }

        /// <summary>
        /// 返回DataTable数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string name)
        {
            string sql = "select *from TrainInfo where Username=@name";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text,new SqlParameter("@name",name));
            return da;
        }

        public DataTable GetDataTable(int niandu)
        {
            string sql = "select *from TrainInfo where Trainniandu=@niandu";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@niandu", niandu));
            //将导出的局外培训情况表里面的bumenid改成部门
            //List<DanweiInfo> list = new List<DanweiInfo>();
            //DanweiInfoDal danweiinfodal = new DanweiInfoDal();
            //list = danweiinfodal.GetDanweiInfolist();
            //for (int i = 0; i < da.Rows.Count; i++)
            //{
            //    da.Rows[i][1]=
            //}
            return da;
        }


        public DataTable GetDataTable(string name,int year)
        {
            string sql = "select *from TrainInfo where Username=@name and Trainniandu=@Trainniandu";
            SqlParameter[] pars =
            {
                new SqlParameter("@name",name),
                new SqlParameter("Trainniandu",year)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            return da;
        }



        /// <summary>
        /// 返回一行数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TrainInfo GetEntityModel(int id)
        {
            string sql = "select *from TrainInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            TrainInfo traininfo = null;
            if (da.Rows.Count>0)
            {
                traininfo = new TrainInfo();
                LoadEntity(da.Rows[0], traininfo);
            }

            return traininfo;

        }

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEntityModel(int id)
        {
            string sql = "delete  from TrainInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }

        /// <summary>
        /// 更新数据库
        /// </summary>
        /// <param name="traininfo"></param>
        /// <returns></returns>
        public int UpdataEntityModel(TrainInfo traininfo)
        {
            string sql = "update TrainInfo set Bumenid=@Bumenid,Username=@Username,Trainname=@Trainname,Trainfangshi=@Trainfangshi,Trainzhuban=@Trainzhuban,Trainchengban=@Trainchengban,Traintime=@Traintime,Trainxueshi=@Trainxueshi,Traindidian=@Traindidian,Trainneirong=@Trainneirong,Trainniandu=@Trainniandu where ID=@ID";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Bumenid",traininfo.Bumenid1),
                                    new SqlParameter("@Username",traininfo.Username1),
                                    //new SqlParameter("@Userid",traininfo.Username1),
                                    new SqlParameter("@Trainname",traininfo.Trainname),
                                    new SqlParameter("@Trainfangshi",traininfo.Trainfangshi),
                                    new SqlParameter("@Trainzhuban",traininfo.Trainfangshi),
                                    new SqlParameter("@Trainchengban",traininfo.Trainchengban),
                                    new SqlParameter("@Traintime",traininfo.Traintime),
                                    new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
                                    new SqlParameter("@Traindidian",traininfo.Traindidian),
                                    new SqlParameter("@Trainneirong",traininfo.Trainneirong),
                                    //new SqlParameter("@Traincailiao",traininfo.Traincailiao),
                                    new SqlParameter("@Trainniandu",traininfo.Trainniandu),
                                    //new SqlParameter()
                                    new SqlParameter("@ID",traininfo.Id)
                                    //new SqlParameter("@Trainzhaopian",traininfo.Trainzhaopian)
                                  };

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="traininfo"></param>
        /// <returns></returns>
        public int InsertEntityModel(TrainInfo traininfo)
        {
            string sql = "insert into TrainInfo(Bumenid,Username,Trainname,Trainfangshi,Trainzhuban,Trainchengban,Traintime,Trainxueshi,Traindidian,Trainneirong,Traincailiao,Trainniandu)values(@Bumenid,@Username,@Trainname,@Trainfangshi,@Trainzhuban,@Trainchengban,@Traintime,@Trainxueshi,@Traindidian,@Trainneirong,@Traincailiao,@Trainniandu)";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Bumenid",traininfo.Bumenid1),
                                    new SqlParameter("@Username",traininfo.Username1),
                                    new SqlParameter("@Trainname",traininfo.Trainname),
                                    new SqlParameter("@Trainfangshi",traininfo.Trainfangshi),
                                    new SqlParameter("@Trainzhuban",traininfo.Trainfangshi),
                                    new SqlParameter("@Trainchengban",traininfo.Trainchengban),
                                    new SqlParameter("@Traintime",traininfo.Traintime),
                                    new SqlParameter("@Trainxueshi",traininfo.Trainxueshi),
                                    new SqlParameter("@Traindidian",traininfo.Traindidian),
                                    new SqlParameter("@Trainneirong",traininfo.Trainneirong),
                                    new SqlParameter("@Traincailiao",traininfo.Traincailiao),
                                    new SqlParameter("@Trainniandu",traininfo.Trainniandu)
                                    //new SqlParameter("@Trainzhaopian",traininfo.Trainzhaopian)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        /// <summary>
        /// 得出学分综合
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int Getxuefentol(string username,int niandu)
        {
            int xuefentol = 0;
            string sql = "select Trainxueshi from TrainInfo where Username=@Username and Trainniandu=@niandu";
            SqlParameter[] pars =
            {
                new SqlParameter("@Username",username),
                new SqlParameter("@niandu",niandu)
            };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            if (da.Rows.Count>0)
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
            string sql = "select Trainxueshi from TrainInfo where Username=@Username";
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


        /// <summary>
        /// 将DataRow转换为类TrainInfo
        /// </summary>
        /// <param name="row"></param>
        /// <param name="traininfo"></param>
        public void LoadEntity(DataRow row, TrainInfo traininfo)
        {
            traininfo.Id = Convert.ToInt32(row["ID"]);
            traininfo.Bumenid1 = row["Bumenid"] != DBNull.Value ? row["Bumenid"].ToString() : string.Empty; 
            traininfo.Username1 = row["Username"] != DBNull.Value ? row["Username"].ToString() : string.Empty;
            traininfo.Trainname = row["Trainname"] != DBNull.Value ? row["Trainname"].ToString() : string.Empty;
            traininfo.Trainfangshi = row["Trainfangshi"] != DBNull.Value ? row["Trainfangshi"].ToString() : string.Empty;
            traininfo.Trainzhuban = row["Trainzhuban"] != DBNull.Value ? row["Trainzhuban"].ToString() : string.Empty;
            traininfo.Trainchengban = row["Trainchengban"] != DBNull.Value ? row["Trainchengban"].ToString() : string.Empty;
            traininfo.Traintime = row["Traintime"] != DBNull.Value ? row["Traintime"].ToString() : string.Empty;
            traininfo.Trainxueshi = Convert.ToInt32(row["Trainxueshi"]);
            traininfo.Traindidian = row["Traindidian"] != DBNull.Value ? row["Traindidian"].ToString() : string.Empty;
            traininfo.Trainneirong = row["Trainneirong"] != DBNull.Value ? row["Trainneirong"].ToString() : string.Empty;
            traininfo.Traincailiao = row["Traincailiao"] != DBNull.Value ? row["Traincailiao"].ToString() : string.Empty;
            traininfo.Trainniandu = Convert.ToInt32(row["Trainniandu"]);
            //traininfo.Trainzhaopian = row["Trainzhaopian"] != DBNull.Value ? row["Trainzhaopian"].ToString() : string.Empty;
        }
    }
}
