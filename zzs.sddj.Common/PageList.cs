using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;
using zzs.sddj.Dal;
using System.Data.SqlClient;
using System.Data;
namespace zzs.sddj.Common
{
    public class PageList
    {
        /// <summary>
        /// 获得某人局外培训的次数
        /// </summary>
        /// <param name="juwaicanxunren"></param>
        /// <returns></returns>
        public int Getjuwaicounts(string juwaicanxunren)
        {
            string sql = "select count(*)from TrainInfo where Username=@juwaicanxunren";
            SqlParameter[] pars = { 
                                    new SqlParameter("@juwaicanxunren",juwaicanxunren)
                                  };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text,pars));
        }
        /// <summary>
        /// 返回局外培训列表
        /// </summary>
        /// <param name="Pageindex"></param>
        /// <param name="Pagesize"></param>
        /// <returns></returns>
        public List<TrainInfo> GetPageTrainList(int Pageindex,int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da= SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count>0)
            {
                list = new List<TrainInfo>();
                TrainInfo traininfo = null;
                TrainInfoDal traininfodal = new TrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    traininfo = new TrainInfo();
                    traininfodal.LoadEntity(row, traininfo);
                    list.Add(traininfo);
                }

            }
            return list;
        }


        public List<TrainInfo> GetPageTrainList(int Pageindex, int Pagesize,string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo where Username=@name) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@name",name)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo traininfo = null;
                TrainInfoDal traininfodal = new TrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    traininfo = new TrainInfo();
                    traininfodal.LoadEntity(row, traininfo);
                    list.Add(traininfo);
                }

            }
            return list;
        }



        /// <summary>
        /// 获取局外培训信息表
        /// </summary>
        /// <returns></returns>
        public int GetTraininfoCount()
        {
            string sql = "select count(*) from TrainInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetTraininfoPageCount(int pagesize)
        {
            int recordcount = GetTraininfoCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }


        //public int GetTrainRecordCount()
        //{
        //    string sql = "select count(*) from TrainInfo";
        //}

        public List<Notice> GetPageNoticeList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Notice) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Notice> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Notice>();
                Notice notice = null;
                NoticeDal noticedal = new NoticeDal();
                foreach (DataRow row in da.Rows)
                {
                    notice = new Notice();
                    noticedal.Loadnotice(row, notice);
                    list.Add(notice);
                }

            }
            return list;
        }
        /// <summary>
        /// 总的记录数
        /// </summary>
        /// <returns></returns>
        public int GetNoticeCount()
        {
            string sql = "select count(*) from Notice";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public int GetNoticePageCount(int pagesize)
        {
            int recordcount = GetNoticeCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<ZhiduInfo> GetPagezhiduList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from ZhiDu) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<ZhiduInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<ZhiduInfo>();
                ZhiduInfo zhiduinfo = null;
                ZhiduDal zhidudal = new ZhiduDal();
                foreach (DataRow row in da.Rows)
                {
                    zhiduinfo = new ZhiduInfo();
                    zhidudal.LoadEntity(row, zhiduinfo);
                    list.Add(zhiduinfo);
                }

            }
            return list;
        }
        public int GetZhiduCount()
        {
            string sql = "select count(*) from ZhiDu";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        public int GetZhiduPageCount(int pagesize)
        {
            int recordcount = GetZhiduCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<UserInfo> GetPageUserlogininfoList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from UserInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<UserInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                UserInfo userinfo = null;
                UserInfoDal userinfodal = new UserInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    userinfo = new UserInfo();
                    userinfodal.LoadEntity(row, userinfo);
                    list.Add(userinfo);
                }

            }

            return list;
        }
        /// <summary>
        /// 获取登陆用户信息表
        /// </summary>
        /// <returns></returns>
        public int GetUserLogininfoCount()
        {
            string sql = "select count(*) from UserInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetUserLoginInfoPageCount(int pagesize)
        {
            int recordcount = GetUserLogininfoCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }


        public List<DepartmentInfo> GetPageDepartlogininfoList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from DepartmentLoginInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<DepartmentInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<DepartmentInfo>();
                DepartmentInfo userinfo = null;
                
                DepartmentLoginInfoDal userinfodal = new DepartmentLoginInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    userinfo = new DepartmentInfo();
                    userinfodal.LoadEntity(row, userinfo);
                    list.Add(userinfo);
                }

            }

            return list;
        }

        public int GetDepartLogininfoCount()
        {
            string sql = "select count(*) from DepartmentLoginInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetDepartLoginInfoPageCount(int pagesize)
        {
            int recordcount = GetDepartLogininfoCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }


        public List<AdminLoginInfo> GetPageAdminlogininfoList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from AdminLoginInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<AdminLoginInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<AdminLoginInfo>();
                AdminLoginInfo userinfo = null;
                AdminLoginInfoDal userinfodal = new AdminLoginInfoDal();
                //DepartmentLoginInfoDal userinfodal = new DepartmentLoginInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    userinfo = new AdminLoginInfo();
                    userinfodal.LoadEntity(row, userinfo);
                    list.Add(userinfo);
                }

            }

            return list;
        }
        public int GetAdminLogininfoCount()
        {
            string sql = "select count(*) from AdminLoginInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetAdminLoginInfoPageCount(int pagesize)
        {
            int recordcount = GetAdminLogininfoCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }


        /// <summary>
        /// 得到用户列表的数量
        /// </summary>
        /// <returns></returns>
        public int GetUserinfoallCount()
        {
            string sql = "select count(*) from UserInfo_all";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        /// <summary>
        /// 得到用户信息表页数
        /// </summary>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public int GetUserInfoallPageCount(int pagesize)
        {
            int recordcount = GetUserinfoallCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<UserInfo_all> GetPageUserInfoallList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from UserInfo_all) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                   
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<UserInfo_all> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<UserInfo_all>();
                UserInfo_all userinfoall = null;
                UserInfo_allDal userinfoalldal = new UserInfo_allDal();
                foreach (DataRow row in da.Rows)
                {
                    userinfoall = new UserInfo_all();
                    userinfoalldal.LoadUserinfoall(row, userinfoall);
                    list.Add(userinfoall);
                }
            }
            return list;
        }

        /// <summary>
        /// 学历学位
        /// </summary>
        /// <param name="Pageindex"></param>
        /// <param name="Pagesize"></param>
        /// <returns></returns>
        public List<Xuelixuewei> GetPagexlxwList(int Pageindex, int Pagesize,string Peixunren)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Xuelixuewei where Peixunren=@Peixunren) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Peixunren",Peixunren)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Xuelixuewei> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                Xuelixuewei xlxw = null;
                XuelixueweiDal xlxwdal = new XuelixueweiDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new Xuelixuewei();
                    
                    xlxwdal.Loadxuelixuewei(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<Xuelixuewei> GetPagexlxwList2(int Pageindex, int Pagesize, string spzhuangtai)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Xuelixuewei where Spzhuangtai=@Spzhuangtai) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Spzhuangtai",spzhuangtai)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Xuelixuewei> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                Xuelixuewei xlxw = null;
                XuelixueweiDal xlxwdal = new XuelixueweiDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new Xuelixuewei();

                    xlxwdal.Loadxuelixuewei(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<Xuelixuewei> GetPagexlxwList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Xuelixuewei) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                    //new SqlParameter("@Peixunren",Peixunren)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Xuelixuewei> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                Xuelixuewei xlxw = null;
                XuelixueweiDal xlxwdal = new XuelixueweiDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new Xuelixuewei();

                    xlxwdal.Loadxuelixuewei(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<Xuelixuewei> GetPagexlxwList(int Pageindex, int Pagesize, int Bumenid,string spzhuangtai)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Xuelixuewei where Bumenid=@Bumenid and spzhuangtai=@spzhuangtai) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Bumenid",Bumenid),
                                    new SqlParameter("@spzhuangtai",spzhuangtai)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Xuelixuewei> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                Xuelixuewei xlxw = null;
                XuelixueweiDal xlxwdal = new XuelixueweiDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new Xuelixuewei();

                    xlxwdal.Loadxuelixuewei(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<Xuelixuewei> GetPagexlxwList(int Pageindex, int Pagesize, int Bumenid, string spzhuangtai1,string spzhuangtai2)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Xuelixuewei where Bumenid=@Bumenid and spzhuangtai=@spzhuangtai1 or spzhuangtai=@spzhuangtai2) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Bumenid",Bumenid),
                                    new SqlParameter("@spzhuangtai1",spzhuangtai1),
                                    new SqlParameter("@spzhuangtai2",spzhuangtai2)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Xuelixuewei> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Xuelixuewei>();
                Xuelixuewei xlxw = null;
                XuelixueweiDal xlxwdal = new XuelixueweiDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new Xuelixuewei();

                    xlxwdal.Loadxuelixuewei(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }



        public List<TrainInfo> GetPagetraininfoList(int Pageindex, int Pagesize, string Bumenid,string yongtu)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo where Bumenid=@Bumenid) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = { 
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Bumenid",Bumenid)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo xlxw = null;
                TrainInfoDal xlxwdal = new TrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new TrainInfo();

                    xlxwdal.LoadEntity(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }


        public int GetUserjwtrainCount()
        {
            string sql = "select count(*) from TrainInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetUserjwtrainPageCount(int pagesize)
        {
            int recordcount = GetUserjwtrainCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public int GetUserjwtrainCount(string bumen)
        {
            string sql = "select count(*) from TrainInfo where Bumenid=@bumen";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text,new SqlParameter("@bumen",bumen)));
        }

        public int GetUserjwtrainPageCount(int pagesize,string bumen)
        {
            int recordcount = GetUserjwtrainCount(bumen);
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }





        /// <summary>
        /// 按照姓名来查询局外培训列表
        /// </summary>
        /// <param name="Pageindex"></param>
        /// <param name="Pagesize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<TrainInfo> GetPagetraininfoList(int Pageindex, int Pagesize, string name,int bumenid)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo where Username=@Username and Bumenid=@Bumenid) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Bumenid",bumenid),
                                    new SqlParameter("@Username",name)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo xlxw = null;
                TrainInfoDal xlxwdal = new TrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new TrainInfo();

                    xlxwdal.LoadEntity(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<TrainInfo> GetPagetraininfoList(int Pageindex, int Pagesize, string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo where Username=@Username) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    
                                    new SqlParameter("@Username",name)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo xlxw = null;
                TrainInfoDal xlxwdal = new TrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new TrainInfo();

                    xlxwdal.LoadEntity(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }




        public int GetUserxlxwCount()
        {
            string sql = "select count(*) from Xuelixuewei";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetUserxlxwPageCount(int pagesize)
        {
            int recordcount = GetUserxlxwCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        
        public int Getdepartmentjntraincount(string danweiid)
        {
            string sql = "select count(*) from JuneiTrain where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid))";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text,new SqlParameter("@danweiid",danweiid)));
        }

        public int GetdepartmentPageCount(int pagesize,string danweiid)
        {
            int recordcount = Getdepartmentjntraincount(danweiid);
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<JuneiTrain> GetPagejntraininfoList(int Pageindex, int Pagesize, string danweiid)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select * from(select row_number() over(order by ID) as num,*from JuneiTrain where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid))) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@DanweiID",danweiid)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain jnt = null;
                JuneiTrainDal jntdal = new JuneiTrainDal();
                foreach (DataRow row in da.Rows)
                {
                    jnt = new JuneiTrain();
                    jntdal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }


        public int Getdepartmentjntraincount(string danweiid,string name)
        {
            string sql = "select count(*) from JuneiTrain where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid) and name=@name) ";
            SqlParameter[] pars = {
                                    new SqlParameter("@danweiid",danweiid),
                                    new SqlParameter("@name",name)
                                    
                                  };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text, pars));
        }

        public int GetdepartmentPageCount(int pagesize, string danweiid,string name)
        {
            int recordcount = Getdepartmentjntraincount(danweiid,name);
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<JuneiTrain> GetPagejntraininfoList(int Pageindex, int Pagesize, string danweiid,string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select * from(select row_number() over(order by ID) as num,*from JuneiTrain where Trainrenyuan in (select name from UserInfo_all where danWei =(select Danwei from DanweiInfo where DanweiID = @danweiid))) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@DanweiID",danweiid),
                                    new SqlParameter("@name",name)
                                    
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain jnt = null;
                JuneiTrainDal jntdal = new JuneiTrainDal();
                foreach (DataRow row in da.Rows)
                {
                    if(row["Trainrenyuan"].ToString()==name)
                    {
                        jnt = new JuneiTrain();
                        jntdal.LoadEntity(row, jnt);
                        list.Add(jnt);
                    }
                    
                }

            }
            return list;
        }

        public int GetUserjntrainCount()
        {
            string sql = "select count(*) from JuneiTrain";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetUserjntrainPageCount(int pagesize)
        {
            int recordcount = GetUserjntrainCount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<JuneiTrain> GetPagejnList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrain) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                    //new SqlParameter("@Peixunren",Peixunren)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain xlxw = null;
                JuneiTrainDal xlxwdal = new JuneiTrainDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new JuneiTrain();

                    xlxwdal.LoadEntity(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }

        public List<JuneiTrain> GetPagejnList(int Pageindex, int Pagesize,string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrain where Trainrenyuan=@Trainrenyuan) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Trainrenyuan",name)
                                    //new SqlParameter("@Peixunren",Peixunren)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain xlxw = null;
                JuneiTrainDal xlxwdal = new JuneiTrainDal();
                foreach (DataRow row in da.Rows)
                {
                    xlxw = new JuneiTrain();

                    xlxwdal.LoadEntity(row, xlxw);
                    list.Add(xlxw);
                }

            }
            return list;
        }



        public int Getjntraininfocount(string danweiname)
        {
            string sql = "select *from JuneiTrainInfo where Trainzhuban=@Trainzhuban";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text, new SqlParameter("@Trainzhuban", danweiname)));
        }

        public int GetjntraininfoCount(int pagesize, string danweiname)
        {
            int recordcount = Getjntraininfocount(danweiname);
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }
        public List<JuneiTrainInfo> GetjntraininfoList(int Pageindex, int Pagesize, string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrainInfo where Trainzhuban=@Trainzhuban) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Trainzhuban",name)
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrainInfo>();
                JuneiTrainInfo jnt = null;
                JuneiTrainInfoDal jntdal = new JuneiTrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    jnt = new JuneiTrainInfo();
                    jntdal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }


        public int Getjntraininfocount()
        {
            string sql = "select *from JuneiTrainInfo";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        //public int Getjntraincount()
        //{
        //    string sql = "select (*)from JuneiTrain";
        //    return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        //}

        public int GetjntraininfoCount(int pagesize)
        {
            int recordcount = Getjntraininfocount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        //public int GetjntrainCount(int pagesize)
        //{
        //    int recordcount = Getjntraincount();
        //    int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
        //    return pagecount;
        //}


        public List<JuneiTrainInfo> GetjntraininfoList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrainInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                  
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrainInfo>();
                JuneiTrainInfo jnt = null;
                JuneiTrainInfoDal jntdal = new JuneiTrainInfoDal();
                foreach (DataRow row in da.Rows)
                {
                    jnt = new JuneiTrainInfo();
                    jntdal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }

        public int Getjntraininfocounts()
        {
            string sql = "select count(*) from JuneiTrainInfo";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int Getjntraininfocounts_jntrain()
        {
            string sql = "select count(*) from JuneiTrain";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        public int Getjwtraininfocounts_jwtrain()
        {
            string sql = "select count(*) from TrainInfo";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int Getjwtraininfocount()
        {
            string sql = "select count(*) from TrainInfo";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        public int Getjntraincount()
        {
            string sql = "select count(*) from JuneiTrain";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
        public int GetjwtraininfoCount(int pagesize)
        {
            int recordcount = Getjwtraininfocount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public int GetjntrainCount(int pagesize)
        {
            int recordcount = Getjwtraininfocount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }


        public List<TrainInfo> GetjwtraininfoList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo jnt = null;
                TrainInfoDal jwdal = new TrainInfoDal();
                
                foreach (DataRow row in da.Rows)
                {
                    jnt = new TrainInfo();

                    jwdal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }

        public List<JuneiTrain> GetjntrainList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrain) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain jnt = null;
                JuneiTrainDal jndal = new JuneiTrainDal();

                foreach (DataRow row in da.Rows)
                {
                    jnt = new JuneiTrain();

                    jndal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }


        public List<JuneiTrain> GetjntrainList(int Pageindex, int Pagesize,string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from JuneiTrain where Trainrenyuan=@name) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@name",name)

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<JuneiTrain> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<JuneiTrain>();
                JuneiTrain jnt = null;
                JuneiTrainDal jndal = new JuneiTrainDal();

                foreach (DataRow row in da.Rows)
                {
                    jnt = new JuneiTrain();

                    jndal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }



        public List<TrainInfo> GetjwtraininfoList(int Pageindex, int Pagesize,string name)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from TrainInfo where Username=@Username) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@Username",name)

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<TrainInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<TrainInfo>();
                TrainInfo jnt = null;
                TrainInfoDal jwdal = new TrainInfoDal();

                foreach (DataRow row in da.Rows)
                {
                    jnt = new TrainInfo();

                    jwdal.LoadEntity(row, jnt);
                    list.Add(jnt);
                }

            }
            return list;
        }



        public int Getwlxscount()
        {
            string sql = "select count(*) from Wlxs";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public int GetWlxsCount(int pagesize)
        {
            int recordcount = Getwlxscount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }

        public List<wlxs> GetwlxsList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Wlxs ) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                    

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<wlxs> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<wlxs>();
                wlxs wlxsmodel = null;
                
                wlxsdal wlxsdal = new wlxsdal();
                foreach (DataRow row in da.Rows)
                {
                    wlxsmodel = new wlxs();
                    wlxsdal.LoadEntity(row, wlxsmodel);
                    
                    list.Add(wlxsmodel);
                }

            }
            return list;
        }


        public int GetetmsplanCount(int pagesize)
        {
            int recordcount = Getetmsplancount();
            int pagecount = Convert.ToInt32(Math.Ceiling((double)recordcount / pagesize));
            return pagecount;
        }
        public int Getetmsplancount()
        {
            string sql = "select count(*) from Etmsplan";

            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        public List<Etmsplas> GetetmsplanList(int Pageindex, int Pagesize,int niandu)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Etmsplan where Niandu=@niandu) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize),
                                    new SqlParameter("@niandu",niandu)

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Etmsplas> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Etmsplas>();
                Etmsplas plan = null;
                EtmsplasDal plandal = new EtmsplasDal();
               

                foreach (DataRow row in da.Rows)
                {
                    plan = new Etmsplas();
                    plandal.LoadEntity(row, plan);
                    
                    list.Add(plan);
                }

            }
            return list;
        }


        public List<Etmsplas> GetetmsplanList(int Pageindex, int Pagesize)
        {
            int start = (Pageindex - 1) * Pagesize + 1;
            int end = Pageindex * Pagesize;
            Pageindex = start;
            Pagesize = end;
            string sql = "select *from(select row_number() over(order by ID) as num,*from Etmsplan) as t where t.num>=@Pageindex and t.num<=@Pagesize";
            SqlParameter[] pars = {
                                    new SqlParameter("@Pageindex",Pageindex),
                                    new SqlParameter("@Pagesize",Pagesize)
                                    

                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<Etmsplas> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Etmsplas>();
                Etmsplas plan = null;
                EtmsplasDal plandal = new EtmsplasDal();


                foreach (DataRow row in da.Rows)
                {
                    plan = new Etmsplas();
                    plandal.LoadEntity(row, plan);

                    list.Add(plan);
                }

            }
            return list;
        }


    }
}
